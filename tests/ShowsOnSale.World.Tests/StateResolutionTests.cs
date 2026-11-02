using ShowsOnSale.World.Models;
using Xunit;

namespace ShowsOnSale.World.Tests;

public class StateResolutionTests
{
    [Theory]
    [InlineData("DE", "Berlin", "BE")]
    [InlineData("DE", "berlin", "BE")]
    [InlineData("ES", "Community of Madrid", "MD")]
    [InlineData("ES", "Valencian Community", "VC")]
    [InlineData("GB", "England", "ENG")]
    [InlineData("GB", "Scotland", "SCT")]
    [InlineData("BE", "Flanders", "VLG")]
    [InlineData("US", "California", "CA")]
    [InlineData("CA", "Ontario", "ON")]
    [InlineData("DEU", "Berlin", "BE")]
    [InlineData(" de ", " Berlin ", "BE")]
    public void ResolveState_WithAFullName_ReturnsTheRegion(string country, string state, string expectedCode)
    {
        Assert.Equal(expectedCode, WorldData.ResolveState(country, state)?.StateCode);
    }

    [Theory]
    [InlineData("AT", "Vienna", "9", "Vienna")]
    [InlineData("AT", "vienna", "9", "Vienna")]
    [InlineData("NO", "Oslo", "03", "Oslo")]
    [InlineData("IT", "Lombardy", "25", "Lombardy")]
    [InlineData("JP", "Tokyo", "13", "Tokyo")]
    public void ResolveState_WithANumericCodedRegion_ReturnsTheRegion(string country, string state, string expectedCode, string expectedName)
    {
        var resolved = WorldData.ResolveState(country, state);

        Assert.NotNull(resolved);
        Assert.Equal(expectedCode, resolved.StateCode);
        Assert.Equal(expectedName, resolved.Name);
    }

    [Theory]
    [InlineData("DE", "BE")]
    [InlineData("DE", "be")]
    [InlineData("ES", "MD")]
    [InlineData("GB", "ENG")]
    [InlineData("US", "CA")]
    [InlineData("US", "GA")]
    [InlineData("AT", "9")]
    public void ResolveState_WithACode_ReturnsThatRegion(string country, string code)
    {
        var resolved = WorldData.ResolveState(country, code);

        Assert.NotNull(resolved);
        Assert.Equal(code, resolved.StateCode, ignoreCase: true);
    }

    [Theory]
    // The country itself is not one of its regions. World used to name Denmark's Capital Region "Denmark".
    [InlineData("DK", "Denmark")]
    [InlineData("DE", "Germany")]
    // DK is the country code, not a Danish region code.
    [InlineData("DK", "DK")]
    [InlineData("DE", "Somewhere Else")]
    [InlineData("DE", "")]
    [InlineData("DE", "   ")]
    [InlineData("", "Berlin")]
    [InlineData("XX", "Berlin")]
    public void ResolveState_WithNothingToMatch_ReturnsNull(string country, string state)
    {
        Assert.Null(WorldData.ResolveState(country, state));
    }

    [Theory]
    // A city in the state column must not match a level below the region: World also lists London (LND),
    // Paris (75C), the province of Madrid (M) and the province of Rome (RM). Cities are not mapped to their
    // region either, so these resolve to nothing.
    [InlineData("GB", "London")]
    [InlineData("GB", "Manchester")]
    [InlineData("FR", "Paris")]
    [InlineData("FR", "Lyon")]
    [InlineData("IT", "Rome")]
    [InlineData("IT", "Milan")]
    [InlineData("ES", "Barcelona")]
    [InlineData("BE", "Antwerp")]
    [InlineData("CZ", "Brno")]
    public void ResolveState_WithACityBelowTheRegionLevel_ReturnsNull(string country, string state)
    {
        Assert.Null(WorldData.ResolveState(country, state));
    }

    [Theory]
    // The lower-level codes are not top-level regions either.
    [InlineData("GB", "LND")]
    [InlineData("FR", "75C")]
    [InlineData("FR", "69M")]
    [InlineData("FR", "6AE")]
    [InlineData("ES", "M")]
    [InlineData("IT", "RM")]
    public void ResolveState_WithALowerLevelCode_ReturnsNull(string country, string code)
    {
        Assert.NotNull(WorldData.GetStateByCode(country, code));
        Assert.Null(WorldData.ResolveState(country, code));
    }

    [Fact]
    public void ResolveState_WithMadrid_ReturnsTheCommunityNotTheProvince()
    {
        Assert.Equal("MD", WorldData.ResolveState("ES", "Madrid")?.StateCode);
        Assert.Equal("M", WorldData.GetStateByName("ES", "Madrid")?.StateCode);
    }

    [Theory]
    // Accents, punctuation and generic words ("County", "Voivodeship", "District") do not stop a match.
    [InlineData("CH", "Zurich", "ZH")]
    [InlineData("CH", "Zürich", "ZH")]
    [InlineData("IE", "County Dublin", "D")]
    [InlineData("IE", "Dublin", "D")]
    [InlineData("SE", "Stockholm County", "AB")]
    [InlineData("FR", "Provence-Alpes-Côte d'Azur", "PAC")]
    [InlineData("FR", "Provence-Alpes-Côte-d’Azur", "PAC")]
    [InlineData("FR", "Pays de la Loire", "PDL")]
    [InlineData("FR", "Grand Est", "GES")]
    [InlineData("TW", "Taipei City", "TPE")]
    [InlineData("QA", "Doha Municipality", "DA")]
    [InlineData("IL", "Tel Aviv District", "TA")]
    [InlineData("PL", "Lesser Poland Voivodeship", "12")]
    [InlineData("TR", "Istanbul", "34")]
    [InlineData("TR", "İstanbul", "34")]
    [InlineData("PA", "Panama City", "8")]
    public void ResolveState_WithASpellingVariant_ReturnsTheRegion(string country, string state, string expectedCode)
    {
        Assert.Equal(expectedCode, WorldData.ResolveState(country, state)?.StateCode);
    }

    [Theory]
    // Names that do not fold to World's, and conventional abbreviations.
    [InlineData("DE", "NRW", "NW")]
    [InlineData("DE", "NDS", "NI")]
    [InlineData("DE", "Nds.", "NI")]
    [InlineData("MX", "CDMX", "CMX")]
    [InlineData("MX", "Jal.", "JAL")]
    [InlineData("MX", "Jal", "JAL")]
    [InlineData("MX", "N.L.", "NLE")]
    [InlineData("MX", "Q.R.", "ROO")]
    [InlineData("ES", "Madrid", "MD")]
    [InlineData("ES", "Castilla y León", "CL")]
    [InlineData("FR", "Brittany", "BRE")]
    [InlineData("FR", "Normandy", "NOR")]
    [InlineData("FR", "Corsica", "20R")]
    [InlineData("BE", "Brussels", "BRU")]
    [InlineData("BE", "Bruxelles", "BRU")]
    [InlineData("AT", "Wien", "9")]
    [InlineData("CO", "Bogotá", "DC")]
    [InlineData("CO", "Bogota", "DC")]
    [InlineData("CZ", "Prague", "10")]
    [InlineData("CZ", "Praha", "10")]
    [InlineData("CZ", "Hlavní město Praha", "10")]
    [InlineData("CZ", "South Moravian Region", "64")]
    [InlineData("CZ", "Jihomoravský kraj", "64")]
    [InlineData("DK", "Capital Region of Denmark", "84")]
    [InlineData("DK", "Region Hovedstaden", "84")]
    [InlineData("PH", "Metro Manila", "00")]
    [InlineData("PH", "NCR", "00")]
    [InlineData("PH", "National Capital Region", "00")]
    [InlineData("MY", "Federal Territory of Kuala Lumpur", "14")]
    [InlineData("NZ", "Tāmaki Makaurau", "AUK")]
    [InlineData("PL", "Masovian Voivodeship", "14")]
    [InlineData("IT", "Toscana", "52")]
    public void ResolveState_WithAnAlternateName_ReturnsTheRegion(string country, string state, string expectedCode)
    {
        Assert.Equal(expectedCode, WorldData.ResolveState(country, state)?.StateCode);
    }

    [Fact]
    public void ResolveState_WithAnAmbiguousFoldedName_ReturnsNull()
    {
        // "Sofia City Province" folds to "sofia", like both Sofia (23) and Sofia City (22).
        Assert.Null(WorldData.ResolveState("BG", "Sofia City Province"));
    }

    [Fact]
    public void ResolveState_KeepsMexicoCityAndTheStateOfMexicoApart()
    {
        // Both fold to "mexico" once the generic words are dropped.
        Assert.Equal("CMX", WorldData.ResolveState("MX", "Mexico City")?.StateCode);
        Assert.Equal("CMX", WorldData.ResolveState("MX", "Ciudad de México")?.StateCode);
        Assert.Equal("MEX", WorldData.ResolveState("MX", "State of México")?.StateCode);
        Assert.Equal("MEX", WorldData.ResolveState("MX", "Estado de México")?.StateCode);
        Assert.Null(WorldData.ResolveState("MX", "Mexico"));
    }

    [Theory]
    [InlineData("Zürich", "zurich")]
    [InlineData("İstanbul", "istanbul")]
    [InlineData("County Dublin", "dublin")]
    [InlineData("Provence-Alpes-Côte-d’Azur", "provencealpescotedazur")]
    [InlineData("Lesser Poland Voivodeship", "lesserpoland")]
    [InlineData("Region of Murcia", "murcia")]
    [InlineData("Łódź", "lodz")]
    [InlineData("Federal Territory of Kuala Lumpur", "kualalumpur")]
    // A lone generic word is kept, so it never folds to nothing.
    [InlineData("City", "city")]
    public void FoldStateName_RemovesCaseAccentsPunctuationAndGenericWords(string name, string expected)
    {
        Assert.Equal(expected, WorldData.FoldStateName(name));
    }

    [Fact]
    public void FoldStateName_WithoutRemovingGenericWords_KeepsThem()
    {
        Assert.Equal("mexicocity", WorldData.FoldStateName("Mexico City", removeGenericWords: false));
    }

    [Fact]
    public void TopLevelStates_ForGreatBritain_AreTheFourNations()
    {
        var codes = WorldData.GetCountryByCode("GB")!.TopLevelStates.Select(s => s.StateCode).OrderBy(c => c);

        Assert.Equal(["ENG", "NIR", "SCT", "WLS"], codes);
    }

    [Fact]
    public void TopLevelStates_ForFrance_AreTheRegionsAndOverseasTerritories()
    {
        var france = WorldData.GetCountryByCode("FR")!;
        var codes = france.TopLevelStates.Select(s => s.StateCode).ToList();

        Assert.Contains("IDF", codes);
        Assert.Contains("PAC", codes);
        Assert.Contains("971", codes);
        Assert.DoesNotContain("75C", codes);
        Assert.DoesNotContain("69M", codes);
        Assert.DoesNotContain("6AE", codes);
        Assert.DoesNotContain(france.TopLevelStates, s => s.Type == "metropolitan department");
    }

    [Fact]
    public void TopLevelStates_ForSpain_AreTheCommunitiesAndAutonomousCities()
    {
        Assert.Equal(19, WorldData.GetCountryByCode("ES")!.TopLevelStates.Count);
    }

    [Fact]
    public void TopLevelStates_ForIreland_AreTheCountiesNotTheProvinces()
    {
        var ireland = WorldData.GetCountryByCode("IE")!;

        Assert.Equal(26, ireland.TopLevelStates.Count);
        Assert.All(ireland.TopLevelStates, s => Assert.Equal("county", s.Type));
    }

    [Theory]
    // The municipalities are below the counties, and several share their county's name.
    [InlineData("LT", "Vilnius", "VL")]
    [InlineData("LT", "Vilnius County", "VL")]
    [InlineData("LT", "Kaunas County", "KU")]
    [InlineData("LT", "Klaipėda County", "KL")]
    [InlineData("LT", "Siauliai", "SA")]
    public void ResolveState_ForLithuania_ReturnsTheCounty(string country, string state, string expectedCode)
    {
        Assert.Equal(expectedCode, WorldData.ResolveState(country, state)?.StateCode);
    }

    [Fact]
    public void TopLevelStates_ForLithuania_AreTheCounties()
    {
        var lithuania = WorldData.GetCountryByCode("LT")!;

        Assert.Equal(10, lithuania.TopLevelStates.Count);
        Assert.All(lithuania.TopLevelStates, s => Assert.Equal("county", s.Type));
        Assert.Null(WorldData.ResolveState("LT", "Palanga"));
    }

    [Fact]
    public void AlternateNames_NeverRepeatTheName()
    {
        var repeats = WorldData.All
            .SelectMany(c => c.States
                .Where(s => s.AlternateNames.Any(a => WorldData.FoldStateName(a, removeGenericWords: false) == WorldData.FoldStateName(s.Name, removeGenericWords: false)))
                .Select(s => $"{c.Iso2}-{s.StateCode}"))
            .ToList();

        Assert.Empty(repeats);
    }

    [Theory]
    // "province" is the top level here, unlike in the countries that list provinces below their regions.
    [InlineData("CA")]
    [InlineData("CN")]
    // No overlay: every state is top level.
    [InlineData("US")]
    [InlineData("DE")]
    public void TopLevelStates_WithoutLowerLevels_AreAllStates(string countryCode)
    {
        var country = WorldData.GetCountryByCode(countryCode)!;

        Assert.Equal(country.States.Count, country.TopLevelStates.Count);
    }

    [Theory]
    [InlineData("CZ", "10", "Prague")]
    [InlineData("CZ", "20", "Central Bohemian Region")]
    [InlineData("CZ", "32", "Plzeň Region")]
    [InlineData("CZ", "80", "Moravian-Silesian Region")]
    [InlineData("DK", "84", "Capital Region of Denmark")]
    [InlineData("PH", "00", "Metro Manila")]
    public void Name_IsCorrectedByTheOverlay(string country, string code, string expectedName)
    {
        Assert.Equal(expectedName, WorldData.GetStateByCode(country, code)?.Name);
    }

    [Theory]
    // The upstream names of the renamed states are kept as alternate names, so these still resolve.
    [InlineData("CZ", "Praha, Hlavní město", "10")]
    [InlineData("CZ", "Středočeský kraj", "20")]
    [InlineData("PH", "National Capital Region (Metro Manila)", "00")]
    [InlineData("AT", "Wien", "9")]
    [InlineData("DE", "nrw", "NW")]
    public void GetStateByName_MatchesAlternateNames(string country, string name, string expectedCode)
    {
        Assert.Equal(expectedCode, WorldData.GetStateByName(country, name)?.StateCode);
    }

    [Fact]
    public void GetStateByName_DoesNotFindDenmarksCapitalRegionAsDenmark()
    {
        Assert.Null(WorldData.GetStateByName("DK", "Denmark"));
    }

    [Fact]
    public void AlternateNames_EachResolveToTheirOwnState()
    {
        var failures = (
            from country in WorldData.All
            from state in country.TopLevelStates
            from name in state.AlternateNames
            let resolved = WorldData.ResolveState(country.Iso2, name)
            where !ReferenceEquals(resolved, state)
            select $"{country.Iso2}: '{name}' resolved to {resolved?.ToString() ?? "nothing"}, expected {state}").ToList();

        Assert.Empty(failures);
    }

    [Fact]
    public void AlternateNames_AreOnlyOnTopLevelStates()
    {
        var misplaced = WorldData.All
            .SelectMany(c => c.States.Where(s => !s.IsTopLevel && s.AlternateNames.Count > 0).Select(s => $"{c.Iso2}-{s.StateCode}"))
            .ToList();

        Assert.Empty(misplaced);
    }

    [Fact]
    public void States_WithoutAnOverlay_HaveTheDefaults()
    {
        var newYork = WorldData.GetStateByCode("US", "NY")!;

        Assert.True(newYork.IsTopLevel);
        Assert.Empty(newYork.AlternateNames);
    }

    [Theory]
    [InlineData("DE", "BE", "BE")]
    [InlineData("GB", "ENG", "ENG")]
    [InlineData("US", "NY", "NY")]
    [InlineData("SE", "AB", "AB")]
    [InlineData("AT", "9", "Vienna")]
    [InlineData("PL", "12", "Lesser Poland")]
    [InlineData("IE", "D", "Dublin")]
    [InlineData("FR", "20R", "Corse")]
    public void ShortName_UsesTheCodeOnlyWhenItIsLetters(string country, string stateCode, string expected)
    {
        var state = WorldData.GetStateByCode(country, stateCode);

        Assert.NotNull(state);
        Assert.Equal(expected, state.ShortName);
    }

    [Fact]
    public void ShortName_IsNeverANumberOrASingleLetter()
    {
        var states = WorldData.All.SelectMany(c => c.States);

        Assert.All(states, s => Assert.True(s.ShortName.Length >= 2 && s.ShortName.Any(char.IsLetter), $"{s.Iso3166_2}: \"{s.ShortName}\""));
    }

    [Fact]
    public void Serialization_LeavesOutDerivedStateLists()
    {
        var json = System.Text.Json.JsonSerializer.Serialize(WorldData.GetCountryByCode("DE"));

        Assert.DoesNotContain("\"TopLevelStates\"", json);
        Assert.DoesNotContain("\"ShortName\"", json);
    }

    [Fact]
    public void Names_HaveNoLeadingOrTrailingWhitespace()
    {
        var names = WorldData.All.SelectMany(c => c.States.SelectMany(s =>
            new[] { (c.Iso2, s.StateCode, Name: s.Name) }
                .Concat(s.AlternateNames.Select(a => (c.Iso2, s.StateCode, Name: a)))
                .Concat(s.Cities.Select(city => (c.Iso2, s.StateCode, Name: city.Name)))));

        Assert.All(names, n => Assert.True(n.Name == n.Name.Trim(), $"{n.Iso2}-{n.StateCode}: \"{n.Name}\""));
    }

    // The local-language names Google returns for the major European cities when the request is not in English.
    [Theory]
    [InlineData("DE", "Bayern", "BY")]
    [InlineData("DE", "Nordrhein-Westfalen", "NW")]
    [InlineData("DE", "Hesse", "HE")]
    [InlineData("NL", "Noord-Holland", "NH")]
    [InlineData("NL", "Zuid-Holland", "ZH")]
    [InlineData("BE", "Vlaanderen", "VLG")]
    [InlineData("ES", "Comunidad de Madrid", "MD")]
    [InlineData("ES", "Cataluña", "CT")]
    [InlineData("ES", "Catalunya", "CT")]
    [InlineData("ES", "Comunidad Valenciana", "VC")]
    [InlineData("PT", "Lisboa", "11")]
    [InlineData("DK", "Hovedstaden", "84")]
    [InlineData("SE", "Stockholms län", "AB")]
    [InlineData("PL", "Mazowieckie", "14")]
    [InlineData("PL", "Małopolskie", "12")]
    [InlineData("GR", "Attiki", "I")]
    [InlineData("RO", "București", "B")]
    [InlineData("RO", "Bucuresti", "B")]
    public void ResolveState_WithALocalLanguageName_ReturnsTheRegion(string country, string state, string expectedCode)
    {
        Assert.Equal(expectedCode, WorldData.ResolveState(country, state)?.StateCode);
    }
}
