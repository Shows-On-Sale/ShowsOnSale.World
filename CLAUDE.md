# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Project Overview

ShowsOnSale.World is a C# NuGet library that provides static geographical data (countries, states/regions, cities, timezones, currencies, ISO codes). Data is embedded at compile time—no external API or database calls needed.

## Build and Test Commands

```bash
# Build the solution
dotnet build src/ShowsOnSale.World.sln

# Run all tests
dotnet test src/ShowsOnSale.World.sln

# Run a single test
dotnet test tests/ShowsOnSale.World.Tests --filter "FullyQualifiedName~GetCountryByCode"

# Build release package
dotnet build src/ShowsOnSale.World/ShowsOnSale.World.csproj -c Release
```

## Architecture

### Code Structure

- **`src/ShowsOnSale.World/`** - Main library (multi-target: net8.0, net9.0)
  - `WorldData.cs` - Auto-generated list of all countries (DO NOT EDIT MANUALLY)
  - `WorldData.Methods.cs` - Query methods (`GetCountryByCode`, `GetCountryByName`, `GetStateByCode`, `GetStateByName`, `Timezones`)
  - `Models/` - `Country`, `State`, `City`, `Timezone` classes
  - `Data/Countries/` - Auto-generated per-country static data files

- **`tests/ShowsOnSale.World.Tests/`** - xUnit test project

- **`scripts/generate-world.ps1`** - PowerShell script that regenerates country data from the submodule

### Data Generation

Country data is generated from `countries-states-cities-database/` (git submodule). To regenerate:

```powershell
./scripts/generate-world.ps1
```

Files marked with "automatically generated" warnings should not be edited manually.

## Key API

```csharp
WorldData.All                                    // List<Country> - all countries
WorldData.GetCountryByCode("US")                 // by ISO2 or ISO3
WorldData.GetCountryByName("United States")      // by name or translation
WorldData.GetStateByCode("US", "NY")             // state by country + state code
WorldData.GetStateByName("US", "New York")       // state by country + state name
WorldData.Timezones                              // all unique timezones
```
