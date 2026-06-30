# Metro Areas — Design

## Concept

A **metro area** is a named region that groups one or more **cities, counties, and/or
states**. It is an editorial overlay on top of the existing `Country → State → City`
hierarchy, not a level within it.

The defining requirement is that a metro **does not nest cleanly under any single parent**:

- The New York metro spans New York *and* New Jersey (and in fuller definitions CT/PA).
- The Basel metro spans Switzerland, France, *and* Germany.

So a metro area is modeled as a **top-level collection** (`WorldData.MetroAreas`) whose
members point back into the geographical tree, rather than as a child of a `Country` or
`State`.

## Scope & decisions

These were the three design forks and the choices made:

| Decision | Choice | Consequence |
|---|---|---|
| Geographic scope | **Global from day one** | No single worldwide standard exists, so most metros are hand-curated. The model must tolerate missing ids and cross-border membership. |
| Membership granularity | **Flexible (city / county / state)** | A single `MetroMemberType` enum lets one metro mix member kinds. Counties are name-only (see below). |
| Data source | **Curated JSON in repo** | `data/metro-areas.json` is the editable source of truth; a generator emits embedded C#. Survives submodule regeneration. |

## Data model

```
MetroArea
├─ Id           string   stable slug, e.g. "us-nyc"  (primary key)
├─ Name         string   "New York–Newark–Jersey City"
├─ ShortName    string?  "New York"
├─ CountryIso2  string   primary country
├─ Countries    [string] every country the metro touches (trinational metros list several)
├─ Code         string?  external standard code (e.g. US CBSA "35620"); null where none applies
├─ Type         enum     Msa | Micropolitan | Other  (US metros are Msa; international are Other)
├─ Population    long?    latest estimate (US: Census Vintage 2024); null where not curated
├─ CsaId        string?  the CombinedStatisticalArea this rolls up into, if any
├─ Latitude     string?  centroid (string, to match the rest of the dataset)
├─ Longitude    string?
└─ Members      [MetroMember]

MetroMember
├─ Type         City | County | State
├─ CountryIso2  string   member's country (members can cross borders)
├─ StateId      int?     FK → State.Id  (globally unique)
├─ StateName    string?  denormalized, for display/robustness
├─ CityId       int?     FK → City.Id   (unique only *within* a state; null for county/state)
└─ Name         string   display name of the city/county/state
```

### Why members use a composite key, not a single id

Two quirks in the underlying countries-states-cities dataset shaped this:

1. **`City.Id` is only unique within a state, not globally.** For example `Newark`
   appears with different ids across NJ, OH, DE, CA, …, and in the UK both `London` and
   `Croydon` carry `Id = 3`. A city must therefore be addressed by **`(StateId, CityId)`**
   together.

2. **`State.StateCode` is empty for some countries (notably the US).** `New York` and
   `New Jersey` both have `StateCode = ""`. So `State.Id` (which *is* globally unique and
   populated) is used as the reliable foreign key, not the state code.

Denormalized `Name` / `StateName` are carried on each member so a metro remains readable
and debuggable even if an upstream id shifts during regeneration.

### Counties

Counties are **not present** in the upstream dataset. The model still supports
`MetroMemberType.County` so metros can be defined the way official US CBSAs are (as sets of
counties), but today a county member is **name-only** (`CityId = null`). If a county dataset
is added later, county members can be upgraded to carry an id without changing the model or
the API.

## Combined Statistical Areas (CSAs)

A **CSA** groups adjacent metros linked by commuting ties (the U.S. OMB framework: e.g.
*New York–Newark, NY-NJ-CT-PA* contains the New York MSA plus the Bridgeport, Trenton,
Poughkeepsie, and Kingston MSAs).

**Why CSAs are a thin roll-up, not the search unit.** This library backs event/show search,
and there the **metro (MSA) is the catchment**: someone searching "Dallas" wants Arlington and
Plano (one MSA), but someone in NYC will not drive to Kingston or Trenton for a show — even
though those share the *same CSA*. So a city/event resolves to exactly **one metro**, which
optionally rolls up to **one CSA**. The CSA is for *widening* a search to the region (tour
routing, market analytics), never for replacing the metro.

```
CombinedStatisticalArea
├─ Id           string   stable slug, e.g. "csa-new-york"
├─ Name         string   OMB title, "New York–Newark, NY-NJ-CT-PA"
├─ Code         string?  external standard code; null where not curated
├─ CountryIso2  string
├─ Population   long?    latest estimate (Census Vintage 2024 for US CSAs)
└─ MetroIds     [string] member metro ids — the CSA references metros, never owns cities
```

The link is kept consistent both ways: a metro's `CsaId` names its CSA, and that CSA's
`MetroIds` lists the metro (a test asserts this in both directions).

## API

**Lookup**

```csharp
WorldData.MetroAreas                          // List<MetroArea> — all metros
WorldData.GetMetroAreaById("us-nyc")          // by stable slug (case-insensitive)
WorldData.GetMetroAreasByCountry("US")        // every metro touching a country (ISO2 or ISO3)
WorldData.GetMetroAreaForCity(stateId, cityId)// reverse lookup: which metro contains this city
```

`GetMetroAreasByCountry` matches against the full `Countries` list, so a trinational metro
is returned for each of its member countries. `GetMetroAreaForCity` keys on `(stateId, cityId)`
for the uniqueness reason above.

**Resolution** — turn the thin member references into live `Country`/`State`/`City`/`Timezone`
objects from the world data:

```csharp
WorldData.ResolveState(member)        // MetroMember → State?
WorldData.ResolveCity(member)         // City member → City?  (null for county/state members)
WorldData.GetMetroCities(metro)       // all resolvable city members → IReadOnlyList<City>
WorldData.GetMetroCountries(metro)    // every touched country → IReadOnlyList<Country>
WorldData.GetMetroTimezones(metro)    // CANDIDATE zones: union of every touched country's zones
```

> ⚠️ `GetMetroTimezones` returns the **union of all zones for every country the metro touches**, not a
> single resolved local zone — the dataset only carries timezones at the country level. For a metro in a
> multi-timezone country (any US metro) this is the whole country's zone list. Use the metro's
> `Latitude`/`Longitude` if you need to pin an actual local zone.

Resolution is intentionally tolerant: members that can't be resolved (e.g. the id-less
cross-border Basel members) are skipped rather than throwing, so the calls are always safe.

**Combined Statistical Areas** — the roll-up layer:

```csharp
WorldData.CombinedStatisticalAreas               // List<CombinedStatisticalArea> — all CSAs
WorldData.GetCombinedStatisticalAreaById("csa-new-york")
WorldData.GetCsaForMetro("us-nyc")               // which CSA a metro rolls up into (null if standalone)
WorldData.GetCsaMetros(csa)                       // member metros, ordered by population desc
```

## Data pipeline

```
data/us-cbsa-source.json ──import-us-cbsa.js──▶ data/metro-areas.json ──generate-metros.ps1──▶ src/.../Data/Metros/<Slug>.cs
  (OMB titles, populations)   (resolve names→ids)  data/combined-statistical-areas.json            src/.../Data/Csas/<Slug>.cs
                                                      (curated source)                              src/.../WorldData.{Metros,Csa}.cs
```

Two stages:

1. **Resolve** (`scripts/import-us-cbsa.js`) — reads the transcribed OMB source, parses each MSA
   title's principal cities + state abbreviations, and resolves them to `(stateId, cityId)` against
   the world data (normalizing `St.`/`Saint`, diacritics, plus a small alias map). It merges the
   result with the hand-curated metros and writes the two curated JSON files. **530 of 530** US
   principal cities resolved automatically.
2. **Generate** (`scripts/generate-metros.ps1`) — emits the embedded C# from the curated JSON.

- The curated JSON files are the source the generator reads; `us-cbsa-source.json` is the upstream
  provenance for the US import (re-run stage 1 to refresh).
- Running `scripts/generate-metros.ps1` regenerates the embedded C#. Generated files carry
  the standard "automatically generated" header and must not be hand-edited.
- The generator is intentionally decoupled from `generate-world.ps1`: it never touches the
  git submodule, because metro areas are a curated overlay the upstream database doesn't
  provide. The two can be run independently.

> Note: at generation time the JSON references `stateId`/`cityId` directly. A future
> enhancement is to let the JSON reference cities by **name + state** and have the generator
> resolve them to ids against `WorldData`, so editors don't have to look ids up by hand.

## Seed data

**396 metros** (384 US MSAs + 12 curated international) and **159 CSAs**. The US set is the
full OMB Bulletin 23-01 / Census Vintage 2024 MSA list, imported via the resolver pipeline
above; the international metros remain hand-curated. The full list lives in
`data/metro-areas.json`; the table below highlights the ones chosen to exercise a specific
design dimension.

| Metro | Country | Demonstrates |
|---|---|---|
| `us-nyc` (New York) | US | Multi-**state** membership (NY + NJ); empty-`StateCode` / non-global-`CityId` handling |
| `us-sf` (San Francisco Bay Area) | US | Disambiguating a reused city name (two "Oakland"s) by `(stateId, cityId)` |
| `us-chi` (Chicago) | US | **Tri-state** membership (IL + IN + WI) |
| `us-dc` (Washington) | US | Cross-jurisdiction (DC + VA + MD) |
| `us-phl` (Philadelphia) | US | Tri-state (PA + NJ + DE) |
| `us-msp` (Minneapolis–St. Paul) | US | Two-state (MN + WI) |
| `us-hr` (Hampton Roads) | US | Many member cities (7) in one state |
| `gb-london` (Greater London) | GB | **Flexible** membership — city + state (borough) + county members in one metro |
| `fr-paris` (Île-de-France) | FR | Non-US country; region-as-state grouping |
| `jp-tokyo` (Greater Tokyo) | JP | Multi-**prefecture** membership (Tokyo + Kanagawa + Saitama + Chiba) |
| `nl-randstad` (Randstad) | NL | Multi-**province** membership (North Holland + South Holland + Utrecht) |
| `mx-cdmx` (Greater Mexico City) | MX | Cross-state (Ciudad de México + Estado de México) |
| `ch-basel` (Basel) | CH/FR/DE | **Cross-border** global metro; members with unresolved ids |

Remaining metros give realistic breadth: `us-la`, `us-dfw`, `us-mia`, `us-bos`, `us-sd`,
`us-phx`, `us-den`, `us-hou`, `us-det`, `us-atl`, `us-sea` (US) and `es-madrid`, `de-berlin`,
`in-mumbai`, `au-sydney`, `ca-toronto`, `br-saopaulo` (international).

A test (`EveryCityMember_ResolvesAgainstWorldData`) asserts that every one of the ~120 city
members' `(stateId, cityId)` resolves to a real city in `WorldData`, guarding against typos
and against drift after a world-data regeneration.

### CSAs

The US MSAs roll up into **159 CSAs** (multi-MSA CSAs only; all-micropolitan CSAs are omitted
as they contribute no metro). Each CSA lists every constituent MSA it contains — e.g. the New
York CSA contains the NYC MSA plus Bridgeport, Kiryas Joel–Poughkeepsie, Trenton, and Kingston.
Standalone MSAs (e.g. San Diego, Austin, Tampa) correctly have `CsaId = null`.

## Open questions / future work

- **Puerto Rico** (6 MSAs / 3 CSAs) and the **micropolitan (μSA)** tier are not yet imported.
- **CBSA codes**: most imported MSAs have `Code = null` (the source document only gives codes for
  a handful); these could be backfilled from the Census delineation files.
- **County data**: official MSAs/CSAs are defined as sets of *counties*. The model supports
  `MetroMemberType.County`, but counties aren't in the upstream dataset, so members are currently
  the title's principal **cities**. If a county dataset is added, members can be county-backed.
- **Validation step** in CI: the resolve/consistency tests already assert anchors and CSA
  membership; wiring them into CI would catch drift after a world-data regeneration automatically.

### Done

- **Full US MSA/CSA import** — 384 MSAs + 159 CSAs from OMB Bulletin 23-01 / Census Vintage 2024,
  via the name→id resolver (`scripts/import-us-cbsa.js`); 530/530 principal cities resolved.
- **Name→id resolution** — the resolver lets the source reference cities by name; ids are matched
  automatically against the world data.
- **Member resolution helpers** — `ResolveState`, `ResolveCity`, `GetMetroCities`,
  `GetMetroCountries`, `GetMetroTimezones`.
- **CSA roll-up layer** — `CombinedStatisticalArea` model + `CombinedStatisticalAreas`,
  `GetCombinedStatisticalAreaById`, `GetCsaForMetro`, `GetCsaMetros`; metros enriched with
  `Type`, `Population`, `CsaId`.
```
