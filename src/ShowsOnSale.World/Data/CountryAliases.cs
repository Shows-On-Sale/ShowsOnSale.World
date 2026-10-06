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
            ["BL"] = new() { "Saint Barthelemy", "Saint Barthélemy", "St. Barthelemy", "St Barthelemy" },
            ["BN"] = new() { "Brunei Darussalam" },
            ["CD"] = new() { "DRC", "DR Congo" },
            ["CG"] = new() { "Republic of the Congo" },
            ["CW"] = new() { "Curacao" },
            ["CZ"] = new() { "Czechia" },
            ["CI"] = new() { "Cote d'Ivoire", "Côte d'Ivoire" },
            ["FK"] = new() { "Falklands" },
            ["GB"] = new() { "Great Britain", "England", "Scotland", "Wales", "Northern Ireland" },
            ["KN"] = new() { "St. Kitts and Nevis", "St Kitts and Nevis" },
            ["KR"] = new() { "Republic of Korea" },
            ["LA"] = new() { "Lao PDR" },
            ["LC"] = new() { "St. Lucia", "St Lucia" },
            ["MF"] = new() { "St. Martin", "St Martin" },
            ["MM"] = new() { "Burma" },
            ["MK"] = new() { "Macedonia" },
            ["NL"] = new() { "Holland" },
            ["PM"] = new() { "St. Pierre and Miquelon", "St Pierre and Miquelon" },
            ["RU"] = new() { "Russian Federation" },
            ["SH"] = new() { "St. Helena", "St Helena" },
            ["SX"] = new() { "St. Maarten", "St Maarten" },
            ["SY"] = new() { "Syrian Arab Republic" },
            ["TL"] = new() { "East Timor" },
            ["TR"] = new() { "Turkiye" },
            ["US"] = new() { "United States of America", "USA" },
            ["VA"] = new() { "Vatican City", "Holy See" },
            ["VC"] = new() { "St. Vincent and the Grenadines", "St Vincent and the Grenadines" },
            ["VG"] = new() { "British Virgin Islands" },
            ["VI"] = new() { "US Virgin Islands" },
            ["VN"] = new() { "Viet Nam" },
        };
    }
}
