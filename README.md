# Shows On Sale : World Database

## Description

ShowsOnSale.World is a comprehensive C# library that provides a static data representation of the world's geographical hierarchy. It includes countries, states/regions, cities, and metadata such as timezones, currencies, and ISO codes — plus a curated overlay of **US metro areas (CBSA)** and **Combined Statistical Areas (CSA)**. All data is embedded at compile time, so there are no external API calls or database connections.

The data currently covers **250 countries**, their states/regions and cities, **401 metro areas** (386 MSAs, 3 micropolitan, 12 curated international), and **159 combined statistical areas**.

## Features

- Complete list of countries with ISO codes, currencies, and more
- States/regions for each country, and cities within them
- US **metro areas** (CBSA/MSA) and **combined statistical areas** (CSA), with reverse city→metro lookup
- **Per-metro IANA time zone** resolved from the metro centroid (e.g. `America/New_York`)
- Timezone, currency, translation, and emoji-flag data
- Geographic coordinates as raw strings **and** parsed `double?` accessors
- Multi-targets **net8.0**, **net9.0**, and **net10.0**
- Ships XML documentation for full IntelliSense

## Installation

```bash
dotnet add package ShowsOnSale.World
```

## Basic Usage

```csharp
using ShowsOnSale.World;
using ShowsOnSale.World.Models;

// All countries
var allCountries = WorldData.All;

// By name or ISO2/ISO3 code
var usa = WorldData.GetCountryByName("United States");
var japan = WorldData.GetCountryByCode("JP"); // or "JPN"

Console.WriteLine($"{usa.Name} ({usa.Iso2}) — capital {usa.Capital}");
Console.WriteLine($"Currency: {japan.CurrencySymbol} {japan.CurrencyName}"); // ¥ Japanese yen
Console.WriteLine($"USA in French: {usa.Translations["fr"]}");                // États-Unis

// States and cities
foreach (var state in usa.States)
{
    Console.WriteLine($"State: {state.Name} ({state.StateCode})");
    foreach (var city in state.Cities)
        Console.WriteLine($"  {city.Name} ({city.LatitudeValue}, {city.LongitudeValue})");
}
```

> **Note on state codes:** `State.StateCode` is empty for some countries (notably the US), so use
> `GetStateByName` rather than `GetStateByCode` for those: `WorldData.GetStateByName("US", "New York")`.

## Metro Areas

A **metro area** groups one or more cities, counties, and/or states into a single named region. US
metros follow the OMB Core-Based Statistical Area (CBSA) framework; a handful of curated international
metros are also included. Metros are a top-level overlay (`WorldData.MetroAreas`) and can cross state
and country borders.

```csharp
// Look up a metro by its stable slug id
var nyc = WorldData.GetMetroAreaById("us-nyc");
Console.WriteLine($"{nyc.Name} — pop {nyc.Population:N0}, CBSA {nyc.Code}");

// The metro's single local IANA time zone (resolved from its centroid)
Console.WriteLine(nyc.TimeZoneId);                          // America/New_York
var tz = WorldData.GetMetroTimezone(nyc);                   // the matching Timezone record
var info = TimeZoneInfo.FindSystemTimeZoneById(nyc.TimeZoneId!); // cross-platform on modern .NET

// All metros touching a country (ISO2 or ISO3); cross-border metros appear for each member country
var usMetros = WorldData.GetMetroAreasByCountry("US");

// Reverse lookup: which metro contains a given city? (use the (StateId, CityId) pair)
var metroForCity = WorldData.GetMetroAreaForCity(stateId: 35, cityId: 632); // us-nyc

// Resolve a metro's members to live City/State/Country objects
foreach (var city in WorldData.GetMetroCities(nyc))
    Console.WriteLine(city.Name);
```

### Time zones, the right way

The underlying dataset carries timezones only at the **country** level, so a country like the US lists
~29 zones. `MetroArea.TimeZoneId` (and `GetMetroTimezone`) give you the metro's **single local zone**,
resolved from the centroid at build time:

```csharp
WorldData.GetMetroTimezone(WorldData.GetMetroAreaById("us-phx")).ZoneName; // America/Phoenix
WorldData.GetMetroTimezone(WorldData.GetMetroAreaById("us-la")).ZoneName;  // America/Los_Angeles
```

`GetMetroTimezones` returns that single resolved zone when available, falling back to the country-level
candidate set only for metros without a resolved id.

## Combined Statistical Areas (CSA)

A **CSA** is a roll-up *over* metros, linked by commuting ties (the wider "region" for tour routing or
market analytics). It references its member metros by id and never replaces them.

```csharp
var csas = WorldData.CombinedStatisticalAreas;
var nyCsa = csas.First(c => c.Id == "csa-new-york-newark-ny-nj-ct-pa");

foreach (var metroId in nyCsa.MetroIds)
    Console.WriteLine(WorldData.GetMetroAreaById(metroId)!.Name);
```

## Coordinates

Latitude/Longitude are stored as decimal-degree **strings** (matching the upstream dataset). Every model
that carries coordinates also exposes parsed `double?` accessors so you don't have to parse them yourself:

```csharp
City city = /* ... */;
double? lat = city.LatitudeValue;   // null if blank/unparseable
double? lon = city.LongitudeValue;
```

Available on `Country`, `State`, `City`, and `MetroArea`.

## API Reference

```csharp
WorldData.All                                   // IReadOnlyList<Country>
WorldData.MetroAreas                            // IReadOnlyList<MetroArea>
WorldData.CombinedStatisticalAreas              // IReadOnlyList<CombinedStatisticalArea>
WorldData.Timezones                             // distinct timezones across all countries

WorldData.GetCountryByCode("US")                // ISO2 or ISO3
WorldData.GetCountryByName("United States")      // name or translation
WorldData.GetStateByCode("US", "NY")            // by country + state code (empty for some countries)
WorldData.GetStateByName("US", "New York")      // by country + state name

WorldData.GetMetroAreaById("us-nyc")
WorldData.GetMetroAreasByCountry("US")
WorldData.GetMetroAreaForCity(stateId, cityId)  // reverse city → metro
WorldData.GetMetroTimezone(metro)               // the metro's single local Timezone
WorldData.GetMetroTimezones(metro)              // resolved zone, else country candidates
WorldData.GetMetroCities(metro)                 // resolved live City objects
WorldData.GetMetroCountries(metro)              // resolved live Country objects
WorldData.ResolveCity(member) / ResolveState(member)
```

## Data Models

### Country

```csharp
public class Country
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Iso3 { get; set; }
    public string Iso2 { get; set; }
    public string NumericCode { get; set; }
    public string PhoneCode { get; set; }
    public string Capital { get; set; }
    public string Currency { get; set; }          // ISO 4217 code, e.g. "USD"
    public string CurrencyName { get; set; }       // e.g. "United States dollar"
    public string CurrencySymbol { get; set; }     // e.g. "$"
    public string Tld { get; set; }
    public string Native { get; set; }
    public string Region { get; set; }
    public int RegionId { get; set; }
    public string Subregion { get; set; }
    public int SubregionId { get; set; }
    public string Nationality { get; set; }
    public List<Timezone> Timezones { get; set; }
    public Dictionary<string, string> Translations { get; set; }
    public string Latitude { get; set; }
    public string Longitude { get; set; }
    public double? LatitudeValue { get; }          // parsed
    public double? LongitudeValue { get; }         // parsed
    public string Emoji { get; set; }
    public string EmojiU { get; set; }
    public List<State> States { get; set; }
}
```

### State

```csharp
public class State
{
    public int Id { get; set; }                    // unique within a country only
    public string Name { get; set; }
    public string StateCode { get; set; }          // may be empty (e.g. US)
    public string Latitude { get; set; }
    public string Longitude { get; set; }
    public double? LatitudeValue { get; }
    public double? LongitudeValue { get; }
    public string Type { get; set; }               // "state", "province", "territory", ...
    public List<City> Cities { get; set; }
}
```

### City

```csharp
public class City
{
    public int Id { get; set; }                    // unique within a state only
    public string Name { get; set; }
    public string Latitude { get; set; }
    public string Longitude { get; set; }
    public double? LatitudeValue { get; }
    public double? LongitudeValue { get; }
}
```

### MetroArea

```csharp
public class MetroArea
{
    public string Id { get; init; }                // stable slug, e.g. "us-nyc"
    public string Name { get; init; }
    public string? ShortName { get; init; }
    public string CountryIso2 { get; init; }       // primary country
    public List<string> Countries { get; init; }   // all countries touched
    public string? Code { get; init; }             // CBSA code for US metros; null otherwise
    public MetroAreaType Type { get; init; }       // Msa | Micropolitan | Other
    public long? Population { get; init; }
    public string? CsaId { get; init; }            // owning CSA, if any
    public string? Latitude { get; init; }
    public string? Longitude { get; init; }
    public double? LatitudeValue { get; }
    public double? LongitudeValue { get; }
    public string? TimeZoneId { get; init; }       // IANA zone resolved from centroid
    public List<MetroMember> Members { get; init; }
}
```

### CombinedStatisticalArea

```csharp
public class CombinedStatisticalArea
{
    public string Id { get; init; }
    public string Name { get; init; }
    public string? Code { get; init; }             // OMB CSA code
    public string CountryIso2 { get; init; }
    public long? Population { get; init; }
    public List<string> MetroIds { get; init; }    // member metros
}
```

### MetroMember

A member is a `City`, `County`, or `State` (`MetroMemberType`). Because `City.Id` is unique only within
a state and `State.Id` only within a country, members are addressed by composite key — resolve them with
`WorldData.ResolveCity` / `ResolveState`. County members carry no `CityId` (counties aren't in the
underlying dataset).

## Versioning / Target Frameworks

- **2.0** multi-targets `net8.0`, `net9.0`, and `net10.0`.
- See [CHANGELOG.md](CHANGELOG.md) for release history and the 1.x → 2.0 migration notes.

## License

This project is licensed under the MIT License. See the LICENSE file for details.

## Data Source

Base country/state/city data is sourced from
[dr5hn/countries-states-cities-database](https://github.com/dr5hn/countries-states-cities-database)
([data license](https://github.com/dr5hn/countries-states-cities-database/blob/master/LICENSE)).
US metro areas and CSAs are a curated overlay derived from the U.S. OMB delineation files.
