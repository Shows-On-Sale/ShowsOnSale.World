# Shows On Sale : World Database

## Description

This library provides a comprehensive C# model and static data representation of the world's geographical hierarchy, including countries, states/regions, cities, and additional metadata such as timezones, currencies, and ISO codes. It offers a structured and easily accessible way to incorporate global location data into .NET applications without requiring external API calls or database connections.

## Examples

### Basic Usage

```csharp
using ShowsOnSale.World;
using ShowsOnSale.World.Models;

// Get all countries
var allCountries = WorldData.All;

// Get a specific country by name
var usa = WorldData.GetCountryByName("United States");
Console.WriteLine($"USA Capital: {usa.Capital}"); // Output: USA Capital: Washington, D.C.

// Get a country by ISO code
var japan = WorldData.GetCountryByCode("JP");
Console.WriteLine($"Japan Currency: {japan.CurrencySymbol} {japan.CurrencyName}"); // Output: Japan Currency: ¥ Japanese yen

// Access country properties
Console.WriteLine($"Country: {usa.Name} ({usa.Iso2})");
Console.WriteLine($"Region: {usa.Region}, Subregion: {usa.Subregion}");
Console.WriteLine($"Capital: {usa.Capital}");
Console.WriteLine($"Currency: {usa.CurrencySymbol} {usa.CurrencyName}");
Console.WriteLine($"Phone Code: +{usa.PhoneCode}");
Console.WriteLine($"Emoji: {usa.Emoji}");

// Access translations
Console.WriteLine($"USA in French: {usa.Translations["fr"]}"); // Output: USA in French: États-Unis

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

### Finding Countries by Region

```csharp
// Find all countries in Europe
var europeanCountries = WorldData.All.Where(c => c.Region == "Europe").ToList();
Console.WriteLine($"There are {europeanCountries.Count} countries in Europe");

// Find all countries in Asia
var asianCountries = WorldData.All.Where(c => c.Region == "Asia").ToList();
Console.WriteLine($"There are {asianCountries.Count} countries in Asia");
```

### Working with Currencies

```csharp
// Find all countries that use the Euro
var euroCountries = WorldData.All.Where(c => c.Currency == "EUR").ToList();
Console.WriteLine($"There are {euroCountries.Count} countries that use the Euro");

// Find all countries that use the US Dollar
var dollarCountries = WorldData.All.Where(c => c.Currency == "USD").ToList();
Console.WriteLine($"There are {dollarCountries.Count} countries that use the US Dollar");
```

### Working with Timezones

```csharp
// Find all countries in a specific timezone
var utcPlusOneCountries = WorldData.All
    .Where(c => c.Timezones.Any(t => t.GmtOffsetName == "UTC+01:00"))
    .ToList();
Console.WriteLine($"There are {utcPlusOneCountries.Count} countries in UTC+01:00");

// Find countries with multiple timezones
var multiTimezoneCountries = WorldData.All
    .Where(c => c.Timezones.Count > 1)
    .OrderByDescending(c => c.Timezones.Count)
    .Take(5)
    .ToList();

foreach (var country in multiTimezoneCountries)
{
    Console.WriteLine($"{country.Name} has {country.Timezones.Count} timezones");
}
```

### Finding Cities

```csharp
// Find all cities in a country
var usaCities = WorldData.GetCountryByName("United States")
    .States
    .SelectMany(s => s.Cities)
    .ToList();
Console.WriteLine($"The USA has {usaCities.Count} cities in the database");

// Find cities by name (across all countries)
var londonCities = WorldData.All
    .SelectMany(c => c.States)
    .SelectMany(s => s.Cities)
    .Where(city => city.Name.Contains("London"))
    .ToList();
Console.WriteLine($"There are {londonCities.Count} cities named London in the database");
```

## License
This project is licensed under the MIT License. See the LICENSE file for details.

## Data Source
The data is sourced from the following GitHub repository:
https://github.com/dr5hn/countries-states-cities-database

## Data License
The data is licensed under the following license:
https://github.com/dr5hn/countries-states-cities-database/blob/master/LICENSE
