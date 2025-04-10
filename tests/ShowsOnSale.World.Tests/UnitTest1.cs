using ShowsOnSale.World.Models;
using Xunit;

namespace ShowsOnSale.World.Tests;

public class WorldDataTests
{
    [Fact]
    public void GetCountries_ReturnsNonEmptyList()
    {
        // Arrange
        var countries = WorldData.Countries;

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
        var country = WorldData.GetCountry(countryCode);

        // Assert
        Assert.NotNull(country);
        Assert.Equal(countryCode, country.Code);
    }

    [Fact]
    public void GetCountry_WithInvalidCode_ReturnsNull()
    {
        // Arrange
        var countryCode = "XX";

        // Act
        var country = WorldData.GetCountry(countryCode);

        // Assert
        Assert.Null(country);
    }
}
