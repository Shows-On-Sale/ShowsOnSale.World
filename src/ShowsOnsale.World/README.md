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
using ShowsOnSale.World.Models;

// Get all countries
var countries = WorldData.Countries;

// Get a specific country
var usa = WorldData.GetCountry("US");

// Get states/provinces for a country
var usStates = usa.States;

// Get cities in a state
var californiaCities = usa.States.First(s => s.Name == "California").Cities;

// Access timezone information
var timezone = usa.Timezone;

// Get currency information
var currency = usa.Currency;
```

## License

This project is licensed under the MIT License - see the LICENSE file for details.
