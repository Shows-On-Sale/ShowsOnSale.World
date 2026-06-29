using System.Linq;
using ShowsOnSale.World.Models;
using Xunit;

namespace ShowsOnSale.World.Tests;

public class MetroAreaTests
{
    [Fact]
    public void MetroAreas_ReturnsNonEmptyList()
    {
        Assert.NotNull(WorldData.MetroAreas);
        Assert.NotEmpty(WorldData.MetroAreas);
    }

    [Fact]
    public void GetMetroAreaById_WithValidId_ReturnsMetro()
    {
        var metro = WorldData.GetMetroAreaById("us-nyc");

        Assert.NotNull(metro);
        Assert.Equal("us-nyc", metro.Id);
        Assert.Equal("US", metro.CountryIso2);
    }

    [Fact]
    public void GetMetroAreaById_IsCaseInsensitive()
    {
        Assert.NotNull(WorldData.GetMetroAreaById("US-NYC"));
    }

    [Fact]
    public void GetMetroAreaById_WithInvalidId_ReturnsNull()
    {
        Assert.Null(WorldData.GetMetroAreaById("does-not-exist"));
    }

    [Fact]
    public void NycMetro_SpansMultipleStates()
    {
        var metro = WorldData.GetMetroAreaById("us-nyc")!;

        var stateIds = metro.Members
            .Where(m => m.Type == MetroMemberType.City)
            .Select(m => m.StateId)
            .Distinct()
            .ToList();

        // New York (35) and New Jersey (33)
        Assert.Contains(35, stateIds);
        Assert.Contains(33, stateIds);
    }

    [Fact]
    public void GetMetroAreasByCountry_ReturnsMetrosForPrimaryCountry()
    {
        var metros = WorldData.GetMetroAreasByCountry("US").ToList();

        Assert.Contains(metros, m => m.Id == "us-nyc");
    }

    [Fact]
    public void GetMetroAreasByCountry_AcceptsIso3()
    {
        var metros = WorldData.GetMetroAreasByCountry("USA").ToList();

        Assert.Contains(metros, m => m.Id == "us-nyc");
    }

    [Fact]
    public void GetMetroAreasByCountry_ReturnsCrossBorderMetroForEachMember()
    {
        // Basel is trinational (CH, FR, DE) and should surface for any of its members.
        Assert.Contains(WorldData.GetMetroAreasByCountry("CH"), m => m.Id == "ch-basel");
        Assert.Contains(WorldData.GetMetroAreasByCountry("FR"), m => m.Id == "ch-basel");
        Assert.Contains(WorldData.GetMetroAreasByCountry("DE"), m => m.Id == "ch-basel");
    }

    [Fact]
    public void GetMetroAreaForCity_FindsContainingMetro()
    {
        // New York City: State.Id 35, City.Id 632
        var metro = WorldData.GetMetroAreaForCity(35, 632);

        Assert.NotNull(metro);
        Assert.Equal("us-nyc", metro.Id);
    }

    [Fact]
    public void GetMetroAreaForCity_DisambiguatesByState()
    {
        // City.Id 322 ("Newark") only belongs to the NYC metro under New Jersey (state 33),
        // not under some other state that happens to reuse id 322.
        Assert.NotNull(WorldData.GetMetroAreaForCity(33, 322));
        Assert.Null(WorldData.GetMetroAreaForCity(999, 322));
    }

    [Fact]
    public void Metro_SupportsFlexibleMemberTypes()
    {
        var london = WorldData.GetMetroAreaById("gb-london")!;

        Assert.Contains(london.Members, m => m.Type == MetroMemberType.City);
        Assert.Contains(london.Members, m => m.Type == MetroMemberType.County);
        // County members carry no city id.
        Assert.All(
            london.Members.Where(m => m.Type == MetroMemberType.County),
            m => Assert.Null(m.CityId));
    }
}
