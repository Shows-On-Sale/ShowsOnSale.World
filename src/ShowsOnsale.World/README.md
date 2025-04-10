# ShowsOnSale.World

A comprehensive C# library providing a static data representation of the world's geographical hierarchy, including countries, states/regions, cities, and additional metadata such as timezones, currencies, and ISO codes.

## Features

- Complete geographical data for countries worldwide
- Detailed information for states/provinces and cities
- Timezone data for each country
- Currency information including symbols and names
- ISO codes (ISO2, ISO3, numeric codes)
- Region and subregion classifications
- Translations for country names in multiple languages
- Emoji flags for countries

## Installation

Install the package via NuGet Package Manager:

```powershell
Install-Package ShowsOnSale.World
```

Or via the .NET CLI:

```bash
dotnet add package ShowsOnSale.World
```

## Usage

```csharp
using ShowsOnSale.World;
using ShowsOnSale.World.Models;

// Get all countries
var allCountries = WorldData.All;

// Get a specific country by name
var usa = WorldData.GetCountryByName("United States");

// Get a country by ISO code
var japan = WorldData.GetCountryByCode("JP");

// Access country properties
Console.WriteLine($"Country: {usa.Name} ({usa.Iso2})");
Console.WriteLine($"Region: {usa.Region}, Subregion: {usa.Subregion}");
Console.WriteLine($"Capital: {usa.Capital}");
Console.WriteLine($"Currency: {usa.CurrencySymbol} {usa.CurrencyName}");
Console.WriteLine($"Phone Code: +{usa.PhoneCode}");
Console.WriteLine($"Emoji: {usa.Emoji}");

// Access translations
Console.WriteLine($"USA in French: {usa.Translations["fr"]}");

// Access timezones
foreach (var timezone in usa.Timezones)
{
    Console.WriteLine($"Timezone: {timezone.ZoneName} ({timezone.GmtOffsetName})");
}

// Access states/regions
foreach (var state in usa.States)
{
    Console.WriteLine($"State: {state.Name} ({state.StateCode})");
    
    // Access cities in each state
    foreach (var city in state.Cities)
    {
        Console.WriteLine($"  City: {city.Name} ({city.Latitude}, {city.Longitude})");
    }
}
```

## License

This project is licensed under the MIT License - see the LICENSE file for details.
