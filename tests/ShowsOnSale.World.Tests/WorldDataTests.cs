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
    public void States_AlmostAllHaveStateCode()
    {
        // Regression guard: an upstream schema rename once blanked every StateCode.
        var states = WorldData.All.SelectMany(c => c.States).ToList();
        var empty = states.Count(s => string.IsNullOrWhiteSpace(s.StateCode));

        Assert.True(empty < states.Count * 0.1, $"{empty} of {states.Count} states have an empty StateCode.");
    }
}
