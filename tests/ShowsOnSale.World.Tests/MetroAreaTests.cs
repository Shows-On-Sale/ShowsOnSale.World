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

    [Theory]
    [InlineData("us-nyc", new[] { 35, 33 })]          // New York, New Jersey
    [InlineData("us-chi", new[] { 16, 17, 56 })]      // Illinois, Indiana, Wisconsin
    [InlineData("nl-randstad", new[] { 8, 10, 11 })]  // North Holland, South Holland, Utrecht
    [InlineData("mx-cdmx", new[] { 7, 11 })]          // Ciudad de México, Estado de México
    public void Metro_SpansExpectedCityStates(string id, int[] expectedStateIds)
    {
        var metro = WorldData.GetMetroAreaById(id)!;

        var stateIds = metro.Members
            .Where(m => m.Type == MetroMemberType.City)
            .Select(m => m.StateId!.Value)
            .Distinct()
            .ToList();

        Assert.Equal(expectedStateIds.OrderBy(x => x), stateIds.OrderBy(x => x));
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

    [Theory]
    [InlineData("us-la")]
    [InlineData("us-sf")]
    [InlineData("us-chi")]
    [InlineData("us-dfw")]
    [InlineData("us-dc")]
    [InlineData("us-mia")]
    [InlineData("us-bos")]
    [InlineData("us-sd")]
    [InlineData("us-phx")]
    [InlineData("us-den")]
    [InlineData("us-hou")]
    [InlineData("us-msp")]
    [InlineData("us-det")]
    [InlineData("us-atl")]
    [InlineData("us-hr")]
    [InlineData("us-phl")]
    [InlineData("us-sea")]
    [InlineData("fr-paris")]
    [InlineData("jp-tokyo")]
    [InlineData("es-madrid")]
    [InlineData("de-berlin")]
    [InlineData("nl-randstad")]
    [InlineData("in-mumbai")]
    [InlineData("au-sydney")]
    [InlineData("ca-toronto")]
    [InlineData("br-saopaulo")]
    [InlineData("mx-cdmx")]
    public void ExpandedSeed_MetrosArePresent(string id)
    {
        Assert.NotNull(WorldData.GetMetroAreaById(id));
    }

    [Fact]
    public void Seed_HasAtLeastThirtyMetros()
    {
        Assert.True(WorldData.MetroAreas.Count >= 30);
    }

    [Fact]
    public void HamptonRoads_ResolvesAllSevenCities()
    {
        var metro = WorldData.GetMetroAreaById("us-hr")!;
        var cities = WorldData.GetMetroCities(metro);

        Assert.Equal(7, cities.Count);
        Assert.Contains(cities, c => c.Name == "Virginia Beach");
        Assert.Contains(cities, c => c.Name == "Norfolk");
    }

    [Fact]
    public void MetroIds_AreUnique()
    {
        var ids = WorldData.MetroAreas.Select(m => m.Id).ToList();
        Assert.Equal(ids.Count, ids.Distinct().Count());
    }

    [Fact]
    public void GetMetroAreasByCountry_ReturnsInternationalMetros()
    {
        Assert.Contains(WorldData.GetMetroAreasByCountry("FR"), m => m.Id == "fr-paris");
        Assert.Contains(WorldData.GetMetroAreasByCountry("JP"), m => m.Id == "jp-tokyo");
        Assert.Contains(WorldData.GetMetroAreasByCountry("GB"), m => m.Id == "gb-london");
    }

    [Fact]
    public void EveryCityMember_ResolvesAgainstWorldData()
    {
        // Validates the curated (stateId, cityId) anchors against the generated world data.
        // City members with both ids set must point at a real city within a real state.
        // State.Id is only unique *within a country* (85 countries reuse id 35, for example),
        // so resolution must scope by the member's country — exactly what ResolveCity does.
        var unresolved = new List<string>();

        foreach (var metro in WorldData.MetroAreas)
        {
            foreach (var member in metro.Members)
            {
                if (member.Type != MetroMemberType.City || member.StateId is null || member.CityId is null)
                    continue;

                if (WorldData.ResolveCity(member) is null)
                    unresolved.Add($"{metro.Id}: {member.Name} (state {member.StateId}, city {member.CityId})");
            }
        }

        Assert.True(unresolved.Count == 0,
            "Unresolved city members: " + string.Join("; ", unresolved));
    }

    [Fact]
    public void ResolveCity_ReturnsLiveCity()
    {
        var metro = WorldData.GetMetroAreaById("us-nyc")!;
        var member = metro.Members.First(m => m.Name == "New York City");

        var city = WorldData.ResolveCity(member);

        Assert.NotNull(city);
        Assert.Equal(632, city.Id);
        Assert.Equal("New York City", city.Name);
    }

    [Fact]
    public void ResolveCity_ReturnsNullForNonCityMember()
    {
        var london = WorldData.GetMetroAreaById("gb-london")!;
        var county = london.Members.First(m => m.Type == MetroMemberType.County);

        Assert.Null(WorldData.ResolveCity(county));
    }

    [Fact]
    public void ResolveState_ReturnsLiveState()
    {
        var metro = WorldData.GetMetroAreaById("us-nyc")!;
        var member = metro.Members.First(m => m.StateName == "New Jersey");

        var state = WorldData.ResolveState(member);

        Assert.NotNull(state);
        Assert.Equal(33, state.Id);
        Assert.Equal("New Jersey", state.Name);
    }

    [Fact]
    public void GetMetroCities_ResolvesAllCityMembers()
    {
        var metro = WorldData.GetMetroAreaById("us-nyc")!;

        var cities = WorldData.GetMetroCities(metro);

        // Every City member with a CityId must resolve; name-only members are excluded by construction.
        // Auto-tracks the growing seed and fails loudly if any id-bearing member stops resolving.
        var expected = metro.Members.Count(m => m.Type == MetroMemberType.City && m.CityId is not null);
        Assert.Equal(expected, cities.Count);
        Assert.Contains(cities, c => c.Name == "New York City");
        Assert.Contains(cities, c => c.Name == "Newark");
    }

    [Fact]
    public void GetMetroCities_SkipsUnresolvableMembers()
    {
        // Basel members carry no ids, so none resolve — but the call is still safe.
        var basel = WorldData.GetMetroAreaById("ch-basel")!;

        Assert.Empty(WorldData.GetMetroCities(basel));
    }

    [Fact]
    public void GetMetroCountries_ReturnsAllTouchedCountries()
    {
        var basel = WorldData.GetMetroAreaById("ch-basel")!;

        var countries = WorldData.GetMetroCountries(basel);

        Assert.Equal(3, countries.Count);
        Assert.Contains(countries, c => c.Iso2 == "CH");
        Assert.Contains(countries, c => c.Iso2 == "FR");
        Assert.Contains(countries, c => c.Iso2 == "DE");
    }

    [Fact]
    public void GetMetroTimezones_AggregatesAcrossCountries_Distinct()
    {
        var basel = WorldData.GetMetroAreaById("ch-basel")!;

        var timezones = WorldData.GetMetroTimezones(basel).ToList();

        Assert.NotEmpty(timezones);
        // Distinct by zone name.
        Assert.Equal(
            timezones.Select(t => t.ZoneName).Distinct().Count(),
            timezones.Count);
    }

    [Theory]
    [InlineData("augusta-richmond-county-ga", MetroAreaType.Msa)]
    [InlineData("tupelo-ms", MetroAreaType.Msa)]
    [InlineData("key-west-fl", MetroAreaType.Micropolitan)]
    [InlineData("aspen-co", MetroAreaType.Micropolitan)]
    [InlineData("pikeville-ky", MetroAreaType.Micropolitan)]
    public void NewStandaloneMetros_ExistWithCorrectType(string id, MetroAreaType type)
    {
        var metro = WorldData.GetMetroAreaById(id);

        Assert.NotNull(metro);
        Assert.Equal(type, metro.Type);
    }

    [Fact]
    public void NameOnlyMember_IsPresentAndSkippedSafely()
    {
        // Venue-towns absent from the world data are carried as name-only members
        // (state known, no city id) and must not break resolution.
        var den = WorldData.GetMetroAreaById("us-den")!;
        var morrison = den.Members.First(m => m.Name == "Morrison");

        Assert.Equal(MetroMemberType.City, morrison.Type);
        Assert.NotNull(morrison.StateId);             // state is known
        Assert.Null(morrison.CityId);                 // city is not in the world data
        Assert.Null(WorldData.ResolveCity(morrison)); // skipped, no throw
        Assert.DoesNotContain(WorldData.GetMetroCities(den), c => c.Name == "Morrison");
    }

    [Fact]
    public void EveryUsCityMember_HasResolvableState()
    {
        // Closes the blind spot in EveryCityMember_ResolvesAgainstWorldData (which skips name-only
        // members): every US city member — id-bearing or name-only — must carry a resolvable state.
        var bad = new List<string>();

        foreach (var metro in WorldData.MetroAreas)
            foreach (var member in metro.Members)
                if (member.Type == MetroMemberType.City && member.CountryIso2 == "US")
                    if (member.StateId is null || WorldData.ResolveState(member) is null)
                        bad.Add($"{metro.Id}: {member.Name}");

        Assert.True(bad.Count == 0, "US city members with unresolvable state: " + string.Join("; ", bad));
    }
}
