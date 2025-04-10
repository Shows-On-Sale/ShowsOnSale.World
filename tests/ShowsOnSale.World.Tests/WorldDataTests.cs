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
}
