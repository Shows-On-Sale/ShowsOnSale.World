using System.Collections.Generic;

namespace ShowsOnSale.World.Data
{
    /// <summary>
    /// Maps ISO 3166-1 alpha-2 country codes to alternative English names for those countries.
    /// These aliases are matched by exact, case-insensitive lookup.
    /// </summary>
    internal static class CountryAliases
    {
        public static Dictionary<string, List<string>> Aliases { get; } = new()
        {
            ["BL"] = new() { "Saint Barthelemy", "Saint-Barthelemy", "St. Barthelemy", "St Barthelemy" },
            ["BN"] = new() { "Brunei Darussalam" },
            ["CD"] = new() { "DRC", "DR Congo", "Democratic Republic of the Congo" },
            ["CG"] = new() { "Republic of the Congo", "Congo" },
            ["CW"] = new() { "Curacao", "Curaçao" },
            ["CZ"] = new() { "Czechia" },
            ["CI"] = new() { "Cote d'Ivoire", "Côte d'Ivoire" },
            ["FK"] = new() { "Falklands", "Falkland Islands" },
            ["GB"] = new() { "Great Britain", "England", "Scotland", "Wales", "Northern Ireland" },
            ["KN"] = new() { "St. Kitts and Nevis", "St Kitts and Nevis" },
            ["KR"] = new() { "Republic of Korea" },
            ["LA"] = new() { "Lao PDR" },
            ["LC"] = new() { "St. Lucia", "St Lucia" },
            ["MF"] = new() { "St. Martin", "St Martin" },
            ["MM"] = new() { "Burma" },
            ["MK"] = new() { "Macedonia", "North Macedonia" },
            ["NL"] = new() { "Holland" },
            ["RU"] = new() { "Russian Federation" },
            ["SY"] = new() { "Syrian Arab Republic" },
            ["TL"] = new() { "East Timor", "Timor-Leste" },
            ["TR"] = new() { "Turkiye" },
            ["US"] = new() { "United States of America", "USA" },
            ["VA"] = new() { "Vatican City", "Holy See", "Vatican City State (Holy See)" },
            ["VC"] = new() { "St. Vincent and the Grenadines", "St Vincent and the Grenadines" },
            ["VG"] = new() { "British Virgin Islands", "Virgin Islands (British)" },
            ["VI"] = new() { "US Virgin Islands", "Virgin Islands (US)" },
            ["VN"] = new() { "Viet Nam" },
        };
    }
}
