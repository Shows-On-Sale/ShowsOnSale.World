# This script generates a JSON schema from the countries+states+cities.json file

# Define paths
$inputFile = Join-Path -Path $PSScriptRoot -ChildPath "..\countries-states-cities-database\json\countries+states+cities.json"
$outputFile = Join-Path -Path $PSScriptRoot -ChildPath "..\schema\countries-states-cities.schema.json"

# Ensure output directory exists
$outputDir = Split-Path -Path $outputFile -Parent
if (-not (Test-Path -Path $outputDir)) {
    New-Item -Path $outputDir -ItemType Directory -Force | Out-Null
}

# Run the generator
Write-Host "Generating schema from $inputFile..."
dotnet run --project (Join-Path -Path $PSScriptRoot -ChildPath "..\src\ShowOnSale.World.SchemaGenerator") -- $inputFile $outputFile

if ($LASTEXITCODE -eq 0) {
    Write-Host "Schema successfully generated at $outputFile" -ForegroundColor Green
} else {
    Write-Host "Schema generation failed with exit code $LASTEXITCODE" -ForegroundColor Red
}
