namespace ShowsOnSale.World;

public partial class WorldData
{
    /// <summary>
    /// Gets a country by its ISO2 or ISO3 code.
    /// </summary>
    /// <param name="code">The ISO2 or ISO3 code of the country.</param>
    /// <returns>The country if found; otherwise, null.</returns>
    public static Models.Country? GetCountryByCode(string code)
    {
        if (string.IsNullOrWhiteSpace(code))
            return null;
            
        code = code.Trim().ToUpperInvariant();
        
        return All.FirstOrDefault(c => 
            string.Equals(c.Iso2, code, StringComparison.OrdinalIgnoreCase) || 
            string.Equals(c.Iso3, code, StringComparison.OrdinalIgnoreCase));
    }
    
    /// <summary>
    /// Gets a country by its name.
    /// </summary>
    /// <param name="name">The name of the country.</param>
    /// <returns>The country if found; otherwise, null.</returns>
    public static Models.Country? GetCountryByName(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
            return null;
            
        name = name.Trim();
        
        return All.FirstOrDefault(c => 
            string.Equals(c.Name, name, StringComparison.OrdinalIgnoreCase) ||
            c.Translations.Values.Any(t => string.Equals(t, name, StringComparison.OrdinalIgnoreCase)));
    }    

    /// <summary>
    /// Gets a list of all unique timezones across all countries.
    /// </summary>
    /// <returns>A list of unique timezones.</returns>
    public static IEnumerable<Models.Timezone> Timezones
    {
        get
        {
            return All
                .SelectMany(c => c.Timezones)
                .GroupBy(t => t.ZoneName)
                .Select(g => g.First())
                .OrderBy(t => t.ZoneName);
        }
    }
}
