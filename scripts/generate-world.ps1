# Script to generate static world data from countries-states-cities database
param(
    [switch]$ForceUpdate,
    [switch]$Debug
)

# Function to write debug messages
function Write-DebugMessage {
    param([string]$Message)
    
    if ($Debug) {
        Write-Host "DEBUG: $Message"
    }
}

# Function to ensure submodules are up to date
function Update-Submodules {
    Write-Host "Checking submodules status..."
    $submoduleStatus = git submodule status
    
    if ($submoduleStatus -match "^[+-]") {
        Write-Host "Submodules need to be updated. Running git submodule update..."
        git submodule update --init --recursive
    } else {
        Write-Host "Submodules are up to date."
    }
}

# Function to sanitize names to be alphanumeric and Pascal case
function Get-SanitizedName {
    param([string]$name)
    
    # Remove any non-alphanumeric characters and split by spaces
    $words = $name -replace '[^a-zA-Z0-9\s]', '' -split '\s+'
    
    # Convert each word to Pascal case
    $pascalWords = $words | ForEach-Object {
        $word = $_.ToLower()
        if ($word.Length -gt 0) {
            $word[0].ToString().ToUpper() + $word.Substring(1)
        }
    }
    
    # Join the words together
    $sanitized = $pascalWords -join ''
    
    # Ensure it starts with a letter (C# requirement for identifiers)
    if ($sanitized -match '^[0-9]') {
        $sanitized = "Country$sanitized"
    }
    
    return $sanitized
}

# Function to escape string for C# code
function Get-EscapedString {
    param([string]$text)
    
    if ($text -eq $null) {
        return ""
    }
    
    # Replace double quotes with escaped double quotes
    return $text -replace '"', '\"'
}

# Function to safely convert to integer
function Get-IntegerValue {
    param($value)
    
    Write-DebugMessage "Get-IntegerValue called with value: $value (Type: $($value.GetType()))"
    
    if ($null -eq $value) {
        Write-DebugMessage "Value is null, returning 0"
        return 0
    }
    
    # If it's already an integer, return it
    if ($value -is [int]) {
        Write-DebugMessage "Value is already an integer: $value"
        return $value
    }
    
    # If it's an array, try to get the first non-null value
    if ($value -is [array]) {
        Write-DebugMessage "Value is an array with $($value.Count) elements"
        $firstValue = $value | Where-Object { $null -ne $_ } | Select-Object -First 1
        if ($null -eq $firstValue) {
            Write-DebugMessage "No non-null values found in array, returning 0"
            return 0
        }
        Write-DebugMessage "Using first non-null value from array: $firstValue"
        $value = $firstValue
    }
    
    # Try to parse as integer
    if ([int]::TryParse($value.ToString(), [ref]$null)) {
        Write-DebugMessage "Successfully parsed as integer: $value"
        return [int]$value
    }
    
    Write-DebugMessage "Failed to parse as integer, returning 0"
    return 0
}

# Function to generate C# code from JSON data
function Generate-WorldData {
    $jsonPath = "countries-states-cities-database/json/countries+states+cities.json"
    $outputDir = "src/ShowsOnSale.World/Data/Countries"
    $mainOutputPath = "src/ShowsOnSale.World/WorldData.cs"
    
    Write-Host "Reading JSON data from $jsonPath..."
    $jsonData = Get-Content $jsonPath -Raw | ConvertFrom-Json
    
    # Create the output directory if it doesn't exist
    if (-not (Test-Path $outputDir)) {
        New-Item -ItemType Directory -Path $outputDir -Force | Out-Null
    }
    
    # Create README.md in the Data directory
    $readmePath = "src/ShowsOnSale.World/Data/README.md"
    $readmeContent = @"
# World Data Directory

⚠️ **WARNING: DO NOT MODIFY FILES IN THIS DIRECTORY MANUALLY** ⚠️

This directory contains automatically generated world data files. These files are generated by the `scripts/generate-world.ps1` script and will be overwritten when the script is run again.

If you need to modify the world data:
1. Make changes to the source data in the `countries-states-cities-database` submodule
2. Run the `scripts/generate-world.ps1` script to regenerate the files

## Structure
- `WorldData.cs` - Main entry point containing all countries
- `Countries/` - Directory containing individual country data files
"@
    Set-Content $readmePath $readmeContent -Encoding UTF8
    
    # Write the initial C# code for the main file
    $initialCode = @"
// ⚠️ WARNING: This file is automatically generated by scripts/generate-world.ps1
// DO NOT modify this file manually as it will be overwritten when the script is run again.
// To update the data, modify the source data in countries-states-cities-database and run the script.

using System.Collections.Generic;
using ShowsOnSale.World.Models;

namespace ShowsOnSale.World
{
    public static partial class WorldData
    {
        public static List<Country> All { get; } = new()
        {
"@
    
    Set-Content $mainOutputPath $initialCode -Encoding UTF8
    
    # Process each country
    $totalCountries = [int]$jsonData.Count
    $currentCountry = [int]0
    
    foreach ($country in $jsonData) {
        $currentCountry++
        $countryName = Get-SanitizedName $country.name
        $countryFilePath = Join-Path $outputDir "$countryName.cs"
        Write-Host "Processing country $currentCountry of $totalCountries : $($country.name)"
        
        # Debug country data
        Write-DebugMessage "Country data:"
        Write-DebugMessage "- region_id: $($country.region_id) (Type: $($country.region_id.GetType()))"
        Write-DebugMessage "- subregion_id: $($country.subregion_id) (Type: $($country.subregion_id.GetType()))"
        
        # Generate country file
        $countryCode = @"
// ⚠️ WARNING: This file is automatically generated by scripts/generate-world.ps1
// DO NOT modify this file manually as it will be overwritten when the script is run again.
// To update the data, modify the source data in countries-states-cities-database and run the script.

using System.Collections.Generic;
using ShowsOnSale.World.Models;

namespace ShowsOnSale.World.Data.Countries
{
    public static class $($countryName)
    {
        public static Country Data { get; } = new()
        {
            Id = $($currentCountry),
            Name = "$(Get-EscapedString $country.name)",
            Iso3 = "$($country.iso3)",
            Iso2 = "$($country.iso2)",
            NumericCode = "$($country.numeric_code -eq $null ? "" : $country.numeric_code)",
            PhoneCode = "$($country.phonecode -eq $null ? "" : $country.phonecode)",
            Capital = "$(Get-EscapedString $country.capital)",
            Currency = "$($country.currency)",
            CurrencyName = "$(Get-EscapedString $country.currency_name)",
            CurrencySymbol = "$($country.currency_symbol -eq $null ? "" : $country.currency_symbol)",
            Tld = "$($country.tld -eq $null ? "" : $country.tld)",
            Native = "$(Get-EscapedString $country.native)",
            Region = "$(Get-EscapedString $country.region)",
            RegionId = $(Get-IntegerValue $country.region_id),
            Subregion = "$(Get-EscapedString $country.subregion)",
            SubregionId = $(Get-IntegerValue $country.subregion_id),
            Nationality = "$(Get-EscapedString $country.nationality)",
            Latitude = "$($country.latitude -eq $null ? "" : $country.latitude)",
            Longitude = "$($country.longitude -eq $null ? "" : $country.longitude)",
            Emoji = "$($country.emoji -eq $null ? "" : $country.emoji)",
            EmojiU = "$($country.emojiU -eq $null ? "" : $country.emojiU)",
            Timezones = new()
            {
"@
        
        Set-Content $countryFilePath $countryCode -Encoding UTF8
        
        # Add timezones as single-line entries
        $timezoneCount = [int]$country.timezones.Count
        $currentTimezone = [int]0
        $timezoneEntries = @()
        
        foreach ($timezone in $country.timezones) {
            $currentTimezone++
            $zoneName = Get-EscapedString $timezone.zoneName
            $gmtOffset = Get-IntegerValue $timezone.gmtOffset
            $gmtOffsetName = Get-EscapedString $timezone.gmtOffsetName
            $abbreviation = $timezone.abbreviation -eq $null ? "" : $timezone.abbreviation
            $tzName = Get-EscapedString $timezone.tzName
            
            # Simple integer comparison since variables are already cast to [int]
            $commaValue = $currentTimezone -lt $timezoneCount ? "," : ""
            
            $timezoneEntry = "                new() { ZoneName = `"$zoneName`", GmtOffset = $gmtOffset, GmtOffsetName = `"$gmtOffsetName`", Abbreviation = `"$abbreviation`", TzName = `"$tzName`" }$commaValue"
            $timezoneEntries += $timezoneEntry
        }
        
        # Write all timezone entries at once
        Add-Content $countryFilePath $timezoneEntries -Encoding UTF8
        
        $translationsCode = @"
            },
            Translations = new()
            {
"@
        Add-Content $countryFilePath $translationsCode -Encoding UTF8
        
        # Add translations
        Write-DebugMessage "Processing translations for country $($country.name)"
        
        # Get translations count safely
        $translationsObj = @($country.translations.PSObject.Properties)
        $translationCount = $translationsObj.Length
        Write-DebugMessage "Found $translationCount translations"
        $currentTranslation = 0
        
        foreach ($translation in $translationsObj) {
            $currentTranslation++
            $langCode = $translation.Name
            $translationValue = Get-EscapedString $translation.Value
            
            Write-DebugMessage "Translation $currentTranslation of $translationCount - Language: $langCode, Value: $translationValue"
            
            # Add comma after every entry except the last one
            $commaValue = if ([int]$currentTranslation -lt [int]$translationCount) { "," } else { "" }
            
            # Write each translation entry individually to ensure proper formatting
            $translationEntry = "                [`"$langCode`"] = `"$translationValue`"$commaValue"
            Add-Content $countryFilePath $translationEntry -Encoding UTF8
        }
        
        $statesStartCode = @"
            },
            States = new()
            {
"@
        Add-Content $countryFilePath $statesStartCode -Encoding UTF8
        
        # Process states for this country
        $totalStates = [int]$country.states.Count
        $currentState = [int]0
        
        foreach ($state in $country.states) {
            $currentState++
            Write-Host "  Processing $($country.name) | state $currentState of $totalStates : $($state.name)"
            
            $stateName = Get-EscapedString $state.name
            $stateCode = @"

                new()
                {
                    Id = $($currentState),
                    Name = "$stateName",
                    StateCode = "$($state.state_code -eq $null ? "" : $state.state_code)",
                    Latitude = "$($state.latitude -eq $null ? "" : $state.latitude)",
                    Longitude = "$($state.longitude -eq $null ? "" : $state.longitude)",
                    Type = "$($state.type -eq $null ? "" : $state.type)",
                    Cities = new()
                    {
"@
            
            Add-Content $countryFilePath $stateCode -Encoding UTF8
            
            # Process cities for this state
            Write-DebugMessage "Starting city processing for state: $($state.name)"
            Write-DebugMessage "Cities collection type: $($state.cities.GetType())"
            
            # Get cities count safely
            $citiesCount = $state.cities.Count
            if ($citiesCount -is [array]) {
                Write-DebugMessage "Cities count is an array, using first element"
                $citiesCount = $citiesCount[0]
            }
            $totalCities = [int]$citiesCount
            Write-DebugMessage "Total cities count: $totalCities (Type: $($totalCities.GetType()))"
            $currentCity = [int]0
            
            # Process cities in batches for better performance
            $cityBatchSize = [int]1000
            Write-DebugMessage "City batch size: $cityBatchSize (Type: $($cityBatchSize.GetType()))"
            
            # Calculate number of batches
            $cityBatches = [Math]::Ceiling($totalCities / $cityBatchSize)
            Write-DebugMessage "Number of batches: $cityBatches (Type: $($cityBatches.GetType()))"
            
            for ($batch = 0; $batch -lt $cityBatches; $batch++) {
                $startIndex = $batch * $cityBatchSize
                $endIndex = [Math]::Min(($batch + 1) * $cityBatchSize, $totalCities)
                
                Write-DebugMessage "Processing batch $($batch + 1) - Index range: $startIndex to $endIndex"
                
                # Collect city entries for this batch
                $cityEntries = @()
                
                for ($i = $startIndex; $i -lt $endIndex; $i++) {
                    $city = $state.cities[$i]
                    $currentCity = $i + 1
                    
                    Write-DebugMessage "Processing city index $i - Current city: $currentCity"
                    Write-DebugMessage "City object type: $($city.GetType())"
                    
                    # Create single-line city entry with proper escaping
                    $cityName = Get-EscapedString $city.name
                    
                    # Handle potential array values for latitude and longitude
                    $cityLatitude = if ($city.latitude -is [array]) {
                        $city.latitude[0] -eq $null ? "" : $city.latitude[0]
                    } else {
                        $city.latitude -eq $null ? "" : $city.latitude
                    }
                    
                    $cityLongitude = if ($city.longitude -is [array]) {
                        $city.longitude[0] -eq $null ? "" : $city.longitude[0]
                    } else {
                        $city.longitude -eq $null ? "" : $city.longitude
                    }
                    
                    Write-DebugMessage "City values - Name: $cityName, Lat: $cityLatitude, Long: $cityLongitude"
                    
                    # Simple integer comparison since variables are already cast to [int]
                    $commaValue = $currentCity -lt $totalCities ? "," : ""
                    
                    $cityEntry = "                        new() { Id = $($currentCity), Name = `"$cityName`", Latitude = `"$cityLatitude`", Longitude = `"$cityLongitude`" }$commaValue"
                    $cityEntries += $cityEntry
                }
                
                # Write all city entries for this batch at once
                Add-Content $countryFilePath $cityEntries -Encoding UTF8
            }
            
            # Simple integer comparison since variables are already cast to [int]
            $commaValue = $currentState -lt $totalStates ? "," : ""
            
            $stateEndCode = @"
                    }
                }$commaValue
"@
            
            Add-Content $countryFilePath $stateEndCode -Encoding UTF8
        }
        
        $countryEndCode = @"
            }
        };
    }
}
"@
        
        Add-Content $countryFilePath $countryEndCode -Encoding UTF8
        
        # Simple integer comparison since variables are already cast to [int]
        $commaValue = $currentCountry -lt $totalCountries ? "," : ""
        
        $mainReference = @"

            ShowsOnSale.World.Data.Countries.$countryName.Data$commaValue
"@
        Add-Content $mainOutputPath $mainReference -Encoding UTF8
    }
    
    # Write the final closing brackets for main file
    $finalCode = @"
        };
    }
}
"@
    
    Add-Content $mainOutputPath $finalCode -Encoding UTF8
    Write-Host "Generated C# code at $mainOutputPath and country files in $outputDir"
}

# Main script execution
try {
    # Update submodules if needed
    Update-Submodules
    
    # Generate world data
    Generate-WorldData
    
    Write-Host "World data generation completed successfully!"
} catch {
    Write-Error "An error occurred: $_"
    if ($Debug) {
        Write-Host "DEBUG: Stack trace:"
        Write-Host $_.ScriptStackTrace
    }
    exit 1
}
