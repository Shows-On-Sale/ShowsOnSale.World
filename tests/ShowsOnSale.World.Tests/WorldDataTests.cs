using ShowsOnSale.World.Models;
using Xunit;

namespace ShowsOnSale.World.Tests;

public class WorldDataTests
{
    [Fact]
    public void GetCountries_ReturnsNonEmptyList()
    {
        // Arrange
        var countries = WorldData.All;

        // Assert
        Assert.NotNull(countries);
        Assert.NotEmpty(countries);
    }

    [Fact]
    public void GetCountry_WithValidCode_ReturnsCountry()
    {
        // Arrange
        var countryCode = "US";

        // Act
        var country = WorldData.GetCountryByCode(countryCode);

        // Assert
        Assert.NotNull(country);
        Assert.Equal(countryCode, country.Iso2);
    }

    [Fact]
    public void GetCountry_WithValidIso3Code_ReturnsCountry()
    {
        // Arrange
        var iso3Code = "USA";

        // Act
        var country = WorldData.GetCountryByCode(iso3Code);

        // Assert
        Assert.NotNull(country);
        Assert.Equal(iso3Code, country.Iso3);
    }

    [Fact]
    public void GetCountry_WithInvalidCode_ReturnsNull()
    {
        // Arrange
        var countryCode = "XX";

        // Act
        var country = WorldData.GetCountryByCode(countryCode);

        // Assert
        Assert.Null(country);
    }

    [Fact]
    public void Country_CoordinateAccessors_ParseStrings()
    {
        var us = WorldData.GetCountryByCode("US")!;

        Assert.NotNull(us.LatitudeValue);
        Assert.NotNull(us.LongitudeValue);
        Assert.Equal(double.Parse(us.Latitude, System.Globalization.CultureInfo.InvariantCulture),
            us.LatitudeValue!.Value, 6);
    }

    [Fact]
    public void StateAndCity_CoordinateAccessors_ParseStrings()
    {
        var ny = WorldData.GetStateByName("US", "New York")!;
        Assert.NotNull(ny.LatitudeValue);
        Assert.NotNull(ny.LongitudeValue);

        var city = ny.Cities.First();
        Assert.NotNull(city.LatitudeValue);
        Assert.NotNull(city.LongitudeValue);
    }

    [Theory]
    [InlineData("US", "NY", "New York")]
    [InlineData("USA", "ca", "California")]
    [InlineData("CA", "ON", "Ontario")]
    [InlineData("AU", "NSW", "New South Wales")]
    public void GetStateByCode_ReturnsState(string countryCode, string stateCode, string expectedName)
    {
        var state = WorldData.GetStateByCode(countryCode, stateCode);

        Assert.NotNull(state);
        Assert.Equal(expectedName, state.Name);
    }

    [Fact]
    public void State_ExposesIso3166_2AndTimeZone()
    {
        var ny = WorldData.GetStateByCode("US", "NY")!;

        Assert.Equal("US-NY", ny.Iso3166_2);
        Assert.Equal("America/New_York", ny.TimeZoneId);
    }

    [Fact]
    public void Countries_HaveValidIsoCodes()
    {
        var invalid = WorldData.All
            .Where(c => !IsUpperLetters(c.Iso2, 2) || !IsUpperLetters(c.Iso3, 3))
            .Select(c => $"{c.Name} (Iso2 \"{c.Iso2}\", Iso3 \"{c.Iso3}\")")
            .ToList();

        Assert.True(invalid.Count == 0, $"Countries with an invalid ISO code: {string.Join(", ", invalid)}");
    }

    [Fact]
    public void Countries_HaveUniqueIsoCodes()
    {
        var duplicates = WorldData.All.GroupBy(c => c.Iso2)
            .Concat(WorldData.All.GroupBy(c => c.Iso3))
            .Where(g => g.Count() > 1)
            .Select(g => g.Key)
            .ToList();

        Assert.True(duplicates.Count == 0, $"ISO codes used by more than one country: {string.Join(", ", duplicates)}");
    }

    [Fact]
    public void States_AllHaveStateCode()
    {
        // Regression guard: an upstream schema rename once blanked every StateCode.
        var missing = WorldData.All
            .SelectMany(c => c.States.Where(s => string.IsNullOrWhiteSpace(s.StateCode)).Select(s => $"{c.Iso2}: {s.Name}"))
            .ToList();

        Assert.True(missing.Count == 0, $"{missing.Count} states have no StateCode: {string.Join(", ", missing.Take(20))}");
    }

    [Fact]
    public void States_HaveUniqueStateCodesWithinCountry()
    {
        // GetStateByCode returns the first match, so a duplicate code would hide the other state.
        var duplicates = WorldData.All
            .SelectMany(c => c.States
                .GroupBy(s => s.StateCode, StringComparer.OrdinalIgnoreCase)
                .Where(g => g.Count() > 1)
                .Select(g => $"{c.Iso2}-{g.Key} ({string.Join(" / ", g.Select(s => s.Name))})"))
            .ToList();

        Assert.True(duplicates.Count == 0, $"Duplicate state codes: {string.Join(", ", duplicates)}");
    }

    private static bool IsUpperLetters(string value, int length) =>
        value.Length == length && value.All(ch => ch is >= 'A' and <= 'Z');
}
