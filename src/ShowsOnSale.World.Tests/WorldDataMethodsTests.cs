namespace ShowsOnSale.World.Tests;

public class WorldDataMethodsTests
{
    
    // SOS-2429: committed world data has blank StateCode for US (and other major countries) because it
    // was generated from a stale submodule. Re-enable after the world-data regen lands.
    [Theory(Skip = "SOS-2429: US StateCode is blank in stale committed world data; re-enable after data regen")]
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
        var result = WorldData.GetStateByName(countryCode, stateName);
        
        Assert.Null(result);
    }

    [Theory]
    [InlineData("US", "Not a state")]
    [InlineData("XX", "New York")] 
    public void GetStateByName_ReturnsNull_WhenStateOrCountryCodeIsInvalid(string countryCode, string stateName)
    {
        var result = WorldData.GetStateByName(countryCode, stateName);
        Assert.Null(result);
    }
    
    // SOS-2429: committed world data has blank StateCode for US (and other major countries) because it
    // was generated from a stale submodule. Re-enable after the world-data regen lands.
    [Theory(Skip = "SOS-2429: US StateCode is blank in stale committed world data; re-enable after data regen")]
    [InlineData("US", "NY")]
    [InlineData("us", "ny")]
    [InlineData("Us", "Ny")]
    [InlineData("USA", "NY")]
    public void GetStateByCode_ReturnsMatchingState_WhenValidCountryCodeAndStateNameProvided(string countryCode, string stateCode)
    {
        var result = WorldData.GetStateByCode(countryCode, stateCode);
        
        Assert.NotNull(result);
        Assert.Equal("New York", result.Name);
        Assert.Equal("NY", result.StateCode);
    }
    
    [Theory]
    [InlineData("US", "")]
    [InlineData("US", null)]
    [InlineData("US", " ")]
    [InlineData("", "NY")]
    [InlineData(null, "NY")]
    public void GetStateByCode_ReturnsNull_WhenCountryCodeOrStateNameIsNullOrWhitespace(string countryCode, string stateCode)
    {
        var result = WorldData.GetStateByCode(countryCode, stateCode);
        
        Assert.Null(result);
    }
    
    [Theory]
    [InlineData("US", "XX")] 
    [InlineData("XX", "NY")] 
    public void GetStateByCode_ReturnsNull_WhenStateOrCountryCodeIsInvalid(string countryCode, string stateCode)
    {
        var result = WorldData.GetStateByCode(countryCode, stateCode);
        Assert.Null(result);
    }
}