#!/usr/bin/env bash

# Stop on first error
set -e

# Configuration
CONFIGURATION=${1:-"Release"}
VERSION=${2:-"1.0.0"}

echo -e "\033[32mBuilding ShowsOnSale.World with configuration: $CONFIGURATION, version: $VERSION\033[0m"

# Ensure we're in the repository root
SCRIPT_DIR="$( cd "$( dirname "${BASH_SOURCE[0]}" )" && pwd )"
cd "$SCRIPT_DIR"

# Clean previous builds
echo -e "\033[33mCleaning previous builds...\033[0m"
dotnet clean src/ShowsOnSale.World/ShowsOnSale.World.csproj --configuration "$CONFIGURATION"

# Restore packages
echo -e "\033[33mRestoring packages...\033[0m"
dotnet restore src/ShowsOnSale.World/ShowsOnSale.World.csproj

# Build the project
echo -e "\033[33mBuilding project...\033[0m"
dotnet build src/ShowsOnSale.World/ShowsOnSale.World.csproj --configuration "$CONFIGURATION" --no-restore

# Run tests if they exist
if [ -d "tests" ]; then
    echo -e "\033[33mRunning tests...\033[0m"
    dotnet test tests/*.csproj --configuration "$CONFIGURATION" --no-build
fi

# Create NuGet package
echo -e "\033[33mCreating NuGet package...\033[0m"
dotnet pack src/ShowsOnSale.World/ShowsOnSale.World.csproj --configuration "$CONFIGURATION" --no-build -p:Version="$VERSION"

echo -e "\033[32mBuild completed successfully!\033[0m"
echo -e "\033[36mPackage location: src/bin/$CONFIGURATION/ShowsOnSale.World.$VERSION.nupkg\033[0m" 