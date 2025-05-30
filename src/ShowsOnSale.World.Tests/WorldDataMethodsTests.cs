namespace ShowsOnSale.World.Tests;

public class WorldDataMethodsTests
{
    
    [Theory]
    [InlineData("US", "New York")]
    [InlineData("us", "new york")] 
    [InlineData("Us", "NEW YORK")] 
    [InlineData("USA", "NEW YORK")] 
    public void GetStateByName_ReturnsMatchingState_WhenValidCountryCodeAndStateNameProvided(string countryCode, string stateName)
    {
        var result = WorldData.GetStateByName(countryCode, stateName);
        
        Assert.NotNull(result);
        Assert.Equal("New York", result.Name);
        Assert.Equal("NY", result.StateCode);
    }
    
    [Theory]
    [InlineData("US", "")]
    [InlineData("US", null)]
    [InlineData("US", " ")]
    [InlineData("", "New York")]
    [InlineData(null, "New York")]
    public void GetStateByName_ReturnsNull_WhenCountryCodeOrStateNameIsNullOrWhitespace(string countryCode, string stateName)
    {
        var result = WorldData.GetStateByName(countryCode, stateName);;
        
        Assert.Null(result);
    }

    [Fact]
    public void GetStateByName_ReturnsNull_WhenStateNameIsNotFound()
    {
        var result = WorldData.GetStateByName("US", "Not a state");
        Assert.Null(result);
    }
    
    [Fact]
    public void GetStateByName_ReturnsNull_WhenCountryCodeIsNotFound()
    {
        var result = WorldData.GetStateByName("XX", "New York");
        Assert.Null(result);
    }
}