#!/usr/bin/env pwsh

# Stop on first error
$ErrorActionPreference = "Stop"

# Configuration
$configuration = if ($args[0]) { $args[0] } else { "Release" }
$version = if ($args[1]) { $args[1] } else { "1.0.0" }

Write-Host "Building ShowsOnSale.World with configuration: $configuration, version: $version" -ForegroundColor Green

# Ensure we're in the repository root
$repoRoot = $PSScriptRoot
Set-Location $repoRoot

# Clean previous builds
Write-Host "Cleaning previous builds..." -ForegroundColor Yellow
dotnet clean src/ShowsOnSale.World/ShowsOnSale.World.csproj --configuration $configuration

# Restore packages
Write-Host "Restoring packages..." -ForegroundColor Yellow
dotnet restore src/ShowsOnSale.World/ShowsOnSale.World.csproj

# Build the project
Write-Host "Building project..." -ForegroundColor Yellow
dotnet build src/ShowsOnSale.World/ShowsOnSale.World.csproj --configuration $configuration --no-restore

# Run tests if they exist
$testProjects = Get-ChildItem -Path "tests" -Filter "*.csproj" -Recurse
if ($testProjects) {
    Write-Host "Running tests..." -ForegroundColor Yellow
    dotnet test tests/ShowsOnSale.World.Tests/ShowsOnSale.World.Tests.csproj --configuration $configuration --no-build
} else {
    Write-Host "No test projects found. Skipping tests." -ForegroundColor Yellow
}

# Create NuGet package
Write-Host "Creating NuGet package..." -ForegroundColor Yellow
dotnet pack src/ShowsOnSale.World/ShowsOnSale.World.csproj --configuration $configuration --no-build -p:Version=$version

Write-Host "Build completed successfully!" -ForegroundColor Green
Write-Host "Package location: src/ShowsOnSale.World/bin/$configuration/ShowsOnSale.World.$version.nupkg" -ForegroundColor Cyan 