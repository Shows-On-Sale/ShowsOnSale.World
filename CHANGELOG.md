# Changelog

All notable changes to **ShowsOnSale.World** are documented here. This project follows
[Semantic Versioning](https://semver.org/).

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
