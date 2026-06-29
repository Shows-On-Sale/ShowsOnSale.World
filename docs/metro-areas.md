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

## API

```csharp
WorldData.MetroAreas                          // List<MetroArea> — all metros
WorldData.GetMetroAreaById("us-nyc")          // by stable slug (case-insensitive)
WorldData.GetMetroAreasByCountry("US")        // every metro touching a country (ISO2 or ISO3)
WorldData.GetMetroAreaForCity(stateId, cityId)// reverse lookup: which metro contains this city
```

`GetMetroAreasByCountry` matches against the full `Countries` list, so a trinational metro
is returned for each of its member countries. `GetMetroAreaForCity` keys on `(stateId, cityId)`
for the uniqueness reason above.

## Data pipeline

```
data/metro-areas.json   ──scripts/generate-metros.ps1──▶   src/.../Data/Metros/<Slug>.cs
   (hand-edited)                                            src/.../WorldData.Metros.cs
```

- The JSON is the **only** file a human edits.
- Running `scripts/generate-metros.ps1` regenerates the embedded C#. Generated files carry
  the standard "automatically generated" header and must not be hand-edited.
- The generator is intentionally decoupled from `generate-world.ps1`: it never touches the
  git submodule, because metro areas are a curated overlay the upstream database doesn't
  provide. The two can be run independently.

> Note: at generation time the JSON references `stateId`/`cityId` directly. A future
> enhancement is to let the JSON reference cities by **name + state** and have the generator
> resolve them to ids against `WorldData`, so editors don't have to look ids up by hand.

## Seed data

Three metros seed the concept, each chosen to exercise a different dimension:

| Metro | Demonstrates |
|---|---|
| `us-nyc` (New York) | Multi-**state** membership; the empty-`StateCode` / non-global-`CityId` handling |
| `gb-london` (Greater London) | **Flexible** membership — city + state (borough) + county members in one metro |
| `ch-basel` (Basel) | **Cross-border** global metro spanning CH/FR/DE; members with unresolved ids |

## Open questions / future work

- **Name→id resolution in the generator** so the JSON is editable without manual id lookup.
- **County data**: if/when counties enter the dataset, promote county members from name-only
  to id-backed.
- **Member resolution helpers**: e.g. `metro.ResolveCities()` returning live `City` objects,
  and aggregate timezones for a metro.
- **Validation step** in CI: assert every `(stateId, cityId)` in the JSON resolves against
  `WorldData`, catching drift after a world-data regeneration.
```
