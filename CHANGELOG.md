# Changelog

All notable changes to **ShowsOnSale.World** are documented here. This project follows
[Semantic Versioning](https://semver.org/).

## [2.1.0]

### Added

- **`WorldData.ResolveState(countryCode, codeOrName)`** — resolves a free-form state value (a code, a
  full name, or another spelling, in any language) to a first-level region, in this order: state code,
  alternate name, name, folded name (case, accents, punctuation and generic words such as `"County"`,
  `"Voivodeship"`, `"State of"` removed; taken only when exactly one region matches). Only top-level
  regions are searched, so `"Madrid"` → `MD` (the community, not the province `M`), `"Zurich"` → `ZH`,
  `"County Dublin"` → `D`, `"Mexico City"` → `CMX` while `"State of México"` → `MEX`, and `"London"` does
  not match the borough `LND`.
- **`State.IsTopLevel`** and **`Country.TopLevelStates`** — upstream lists some lower levels next to
  the first-level regions (GB boroughs and districts, FR metropolitan departments plus `75C`/`69M`/`6AE`,
  ES/IT/BE/IE/PH provinces, CZ districts, GR regional units, HU cities with county rights, LT
  municipalities); those are
  `IsTopLevel = false`. Every other state is top level. Maintained in `data/state-levels.json`.
- **`State.AlternateNames`** — local-language and English names and conventional abbreviations that do
  not fold to the state's name (`"Wien"`, `"Praha"`, `"Toscana"`, `"Bogotá"`, `"Brussels"`, `"Masovian"`,
  `"Tāmaki Makaurau"`, `"Bayern"`, `"Cataluña"`, `"Lisboa"`, `"Stockholms län"`, `"NCR"`, `"NRW"`,
  `"Jal."`, `"CDMX"`…). Maintained in `data/state-names.json`.
- **`State.ShortName`** — the state code when it is two or more letters (`"BE"`, `"ENG"`), otherwise the
  name, so numeric, single-letter and mixed codes never reach a reader: Austria's `"9"` → `"Vienna"`,
  Ireland's `"D"` → `"Dublin"`, France's `"20R"` → `"Corse"`. Not serialized.
- `generate-world.ps1 -DataRoot <path>` regenerates from another checkout of the upstream dataset, and
  the script now fails when an overlay entry matches no upstream state.

### Changed

- **`GetStateByName` also matches `State.AlternateNames`** (exact, case-insensitive), after the names
  of all states, so existing lookups return what they did before: `GetStateByName("ES", "Madrid")` is
  still the province.
- **State names corrected** where upstream's was wrong or not in English: the Czech regions are now
  named in English (`"Praha, Hlavní město"` → `"Prague"`, `"Jihomoravský kraj"` →
  `"South Moravian Region"`…), `PH-00` is `"Metro Manila"`, and `DK-84` is
  `"Capital Region of Denmark"` (upstream named it `"Denmark"`). The previous Czech and Philippine names
  remain as alternate names, so `GetStateByName` still finds them; `GetStateByName("DK", "Denmark")` now
  returns null.

### Fixed

- **Stray whitespace removed from names.** `generate-world.ps1` now trims state names, alternate names
  and city names; upstream had a trailing space on 56 of them (`"Guatemala "`, `"Luxembourg "`,
  `"Brussels-Capital "`, all of Bangladesh's divisions…), so a lookup by the correct name failed.

## [2.0.4]

### Added

- **`Country.Aliases` property** — alternative English names for a country (e.g. `"Turkiye"` for Turkey,
  `"Czechia"` for Czech Republic). 48 aliases across 30 countries cover ASCII forms of names that are
  only spelled with diacritics upstream (`Turkiye`, `Cote d'Ivoire`, `Curacao`), former or colloquial
  names (`Burma`, `Macedonia`, `East Timor`, `Holland`, `Falklands`), abbreviations (`USA`, `DRC`,
  `DR Congo`, `Lao PDR`), ISO formal names (`Russian Federation`, `Viet Nam`, `Syrian Arab Republic`),
  `St.`/`St` forms of the `Saint-*` countries (both spellings of each), and the UK constituent
  nations (`England`, `Scotland`, `Wales`, `Northern Ireland` → `GB`).
- **`WorldData.GetCountryByName()` resolves aliases** — matching is exact and case-insensitive
  (after trimming) against the country name, its translations, and its aliases. There is no
  diacritic folding or fuzzy matching, so each spelling is listed explicitly.
  `GetCountryByName("Czechia")` → `CZ`, `GetCountryByName("Turkiye")` → `TR`.

Aliases live in a hand-maintained table (`Data/CountryAliases.cs`) rather than in the generated
per-country files, so regenerating the dataset does not drop them.

## [2.0.3]

### Fixed

- **`State.StateCode` is populated again, so `GetStateByCode` works** (SOS-2429). Upstream renamed the
  `state_code` field to `iso2`, and the January 2026 data update blanked `StateCode` for every
  state in every country (so `GetStateByCode("US", "NY")` returned null). The generator now
  reads `iso2`, falls back to `state_code`, and fails if more than 10% of state codes are empty.

### Added

- `State.Iso3166_2` (e.g. `"US-NY"`) and `State.TimeZoneId` (e.g. `"America/New_York"`), from
  the upstream dataset.
- `generate-world.ps1 -SkipSubmoduleUpdate` regenerates from the currently checked-out data
  instead of pulling the latest upstream.

## [2.0.1]

Hardening release on top of 2.0.0 (the metro/CSA overlay). Addresses the 2.0.x defect review
(SOS-2442 docs/recommendations, SOS-2443 metro-timezone bug).

### Added

- **Per-metro IANA time zone** — `MetroArea.TimeZoneId` and `WorldData.GetMetroTimezone(metro)` return
  the metro's single local zone (e.g. `America/New_York`), resolved from the metro centroid at
  data-generation time.
- **Typed coordinate accessors** — `LatitudeValue` / `LongitudeValue` (`double?`) on `Country`,
  `State`, `City`, and `MetroArea`, parsed with the invariant culture.
- **XML documentation** is now generated and shipped in the package for full IntelliSense.
- A real `README` (metro/CSA/timezone/accessor coverage) and this `CHANGELOG`.

### Changed

- **Multi-targets `net8.0`, `net9.0`, and `net10.0`.** (2.0.0 was `net10.0`-only; .NET 8/9 consumers
  can upgrade again.)
- `GetMetroTimezones(metro)` now returns the metro's single **resolved local zone** when available,
  falling back to the country-level candidate set only when no zone could be resolved. Previously it
  always returned the union of every touched country's zones (so any US metro returned ~29 zones).

### Breaking changes / migration (2.0.0 → 2.0.1)

- **Generated data classes are now `internal`.** The per-country / per-metro / per-CSA classes under
  `ShowsOnSale.World.Data.*` (e.g. `Data.Countries.UnitedStates.Data`) are no longer public. Use the
  public surface instead: `WorldData.All`, `WorldData.MetroAreas`, `WorldData.CombinedStatisticalAreas`,
  and the `WorldData.Get*` lookup methods. If you depended on a `Data.*` class directly, switch to a
  lookup (e.g. `WorldData.GetCountryByCode("US")`).
- `GetMetroTimezones` semantics changed (see **Changed** above). If you specifically need the metro's
  local zone, prefer `GetMetroTimezone` / `MetroArea.TimeZoneId`.

## [2.0.0]

Major release adding a US metro-area / CSA overlay on top of the country/state/city data.

### Added

- **Metro areas** (`WorldData.MetroAreas`): 401 metros (386 MSAs, 3 micropolitan, 12 curated
  international), following the U.S. OMB Core-Based Statistical Area (CBSA) framework. Members can be
  cities, counties, or whole states and may cross state/country borders.
  - Lookups: `GetMetroAreaById`, `GetMetroAreasByCountry`, `GetMetroAreaForCity` (reverse city→metro).
  - Resolution helpers: `GetMetroCities`, `GetMetroCountries`, `ResolveCity`, `ResolveState`.
- **Combined Statistical Areas** (`WorldData.CombinedStatisticalAreas`): 159 CSAs that roll up member
  metros by id (full U.S. OMB import).

## [1.x]

- Static data representation of countries, states/regions, and cities, with timezones, currencies,
  ISO codes, translations, emoji flags, and geographic coordinates.
- Lookups: `GetCountryByCode`, `GetCountryByName`, `GetStateByCode`, `GetStateByName`, `Timezones`.
