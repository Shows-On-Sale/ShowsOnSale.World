using System.Linq;
using ShowsOnSale.World.Models;
using Xunit;

namespace ShowsOnSale.World.Tests;

public class CombinedStatisticalAreaTests
{
    [Fact]
    public void CombinedStatisticalAreas_ReturnsNonEmptyList()
    {
        Assert.NotNull(WorldData.CombinedStatisticalAreas);
        Assert.NotEmpty(WorldData.CombinedStatisticalAreas);
    }

    // The New York CSA's slug is derived from its full OMB title.
    private const string NyCsaId = "csa-new-york-newark-ny-nj-ct-pa";

    [Fact]
    public void GetCsaById_ReturnsCsa()
    {
        var csa = WorldData.GetCombinedStatisticalAreaById(NyCsaId);

        Assert.NotNull(csa);
        Assert.Equal(22342624, csa.Population);
        Assert.Contains("us-nyc", csa.MetroIds);
    }

    [Fact]
    public void NewYorkCsa_ContainsMultipleConstituentMsas()
    {
        var csa = WorldData.GetCombinedStatisticalAreaById(NyCsaId)!;

        // NYC MSA plus Bridgeport, Kiryas Joel/Poughkeepsie, Trenton, Kingston.
        Assert.True(csa.MetroIds.Count >= 5);
        Assert.Contains("us-nyc", csa.MetroIds);
        var metros = WorldData.GetCsaMetros(csa);
        // Ordered by population descending — NYC is the largest.
        Assert.Equal("us-nyc", metros[0].Id);
    }

    [Fact]
    public void GetCsaById_IsCaseInsensitive()
    {
        Assert.NotNull(WorldData.GetCombinedStatisticalAreaById(NyCsaId.ToUpperInvariant()));
    }

    [Fact]
    public void GetCsaForMetro_ReturnsContainingCsa()
    {
        var csa = WorldData.GetCsaForMetro("us-nyc");

        Assert.NotNull(csa);
        Assert.Equal(NyCsaId, csa.Id);
    }

    [Fact]
    public void FullImport_HasHundredsOfMsasAndCsas()
    {
        Assert.True(WorldData.MetroAreas.Count(m => m.Type == MetroAreaType.Msa) >= 380);
        Assert.True(WorldData.CombinedStatisticalAreas.Count >= 150);
        // A representative imported MSA exists and resolved its principal cities.
        var sanJose = WorldData.GetMetroAreaById("san-jose-sunnyvale-santa-clara-ca");
        Assert.NotNull(sanJose);
        Assert.NotEmpty(WorldData.GetMetroCities(sanJose));
    }

    [Fact]
    public void GetCsaForMetro_ReturnsNullForStandaloneMetro()
    {
        // San Diego is a standalone MSA (belongs to no CSA).
        Assert.Null(WorldData.GetCsaForMetro("us-sd"));
    }

    [Fact]
    public void GetCsaMetros_ResolvesMembers()
    {
        var csa = WorldData.GetCombinedStatisticalAreaById(NyCsaId)!;

        var metros = WorldData.GetCsaMetros(csa);

        Assert.Contains(metros, m => m.Id == "us-nyc");
    }

    [Fact]
    public void Metro_CarriesTypeAndPopulation()
    {
        var nyc = WorldData.GetMetroAreaById("us-nyc")!;

        Assert.Equal(MetroAreaType.Msa, nyc.Type);
        Assert.Equal(19940274, nyc.Population);
        Assert.Equal(NyCsaId, nyc.CsaId);
    }

    [Fact]
    public void InternationalMetro_IsTypeOther()
    {
        var tokyo = WorldData.GetMetroAreaById("jp-tokyo")!;

        Assert.Equal(MetroAreaType.Other, tokyo.Type);
        Assert.Null(tokyo.CsaId);
    }

    [Fact]
    public void EveryMetroCsaId_ResolvesToACsa()
    {
        var dangling = WorldData.MetroAreas
            .Where(m => m.CsaId is not null)
            .Where(m => WorldData.GetCombinedStatisticalAreaById(m.CsaId!) is null)
            .Select(m => $"{m.Id} -> {m.CsaId}")
            .ToList();

        Assert.True(dangling.Count == 0, "Dangling CsaId references: " + string.Join("; ", dangling));
    }

    [Fact]
    public void EveryCsaMetroId_ResolvesToAMetro()
    {
        var dangling = WorldData.CombinedStatisticalAreas
            .SelectMany(c => c.MetroIds.Select(id => new { c.Id, MetroId = id }))
            .Where(x => WorldData.GetMetroAreaById(x.MetroId) is null)
            .Select(x => $"{x.Id} -> {x.MetroId}")
            .ToList();

        Assert.True(dangling.Count == 0, "Dangling MetroId references: " + string.Join("; ", dangling));
    }

    [Fact]
    public void CsaMembership_IsConsistentBothWays()
    {
        // If a metro names a CSA, that CSA must list the metro, and vice versa.
        foreach (var metro in WorldData.MetroAreas.Where(m => m.CsaId is not null))
        {
            var csa = WorldData.GetCombinedStatisticalAreaById(metro.CsaId!);
            Assert.NotNull(csa);
            Assert.Contains(metro.Id, csa!.MetroIds);
        }

        foreach (var csa in WorldData.CombinedStatisticalAreas)
        {
            foreach (var metroId in csa.MetroIds)
            {
                var metro = WorldData.GetMetroAreaById(metroId);
                Assert.NotNull(metro);
                Assert.Equal(csa.Id, metro!.CsaId);
            }
        }
    }
}
