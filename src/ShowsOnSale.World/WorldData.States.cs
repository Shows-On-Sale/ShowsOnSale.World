using System.Globalization;
using System.Text;
using ShowsOnSale.World.Models;

namespace ShowsOnSale.World;

public static partial class WorldData
{
    /// <summary>
    /// Resolves a free-form state value, such as a geocoder returns it (sometimes a code, sometimes a full
    /// name, in any language or spelling), to a first-level region of the country. Only
    /// <see cref="Country.TopLevelStates"/> are considered, so a city never matches a level below the region:
    /// <c>"London"</c> is not the borough LND, and <c>"Madrid"</c> is the community MD, not the province M.
    /// </summary>
    /// <remarks>
    /// Tried in order, the first hit wins:
    /// <list type="number">
    /// <item><description>the state code (<c>"BE"</c>), case-insensitively;</description></item>
    /// <item><description>an alternate name (<c>"Wien"</c>, <c>"NRW"</c>, <c>"Jal."</c>), folded as below
    /// but compared both with and without the generic words dropped, so <c>"Mexico City"</c> is not read
    /// as <c>"Mexico"</c>;</description></item>
    /// <item><description>the name, case-insensitively;</description></item>
    /// <item><description>the folded name: case, accents, punctuation and generic words (a leading
    /// <c>"County of"</c>, <c>"State of"</c>, <c>"the"</c>…, a trailing <c>"County"</c>,
    /// <c>"Voivodeship"</c>, <c>"Region"</c>…) removed, so <c>"Zurich"</c> matches <c>"Zürich"</c> and
    /// <c>"County Dublin"</c> matches <c>"Dublin"</c>. Taken only when exactly one region folds to the same
    /// value.</description></item>
    /// </list>
    /// A value that names the country rather than a region is not special-cased; it resolves only if a
    /// region happens to share the country's name.
    /// </remarks>
    /// <param name="countryCode">The ISO2 or ISO3 code of the country.</param>
    /// <param name="codeOrName">The state code, name, or another spelling of the name.</param>
    /// <returns>The first-level region if it is recognised; otherwise, null.</returns>
    public static State? ResolveState(string countryCode, string codeOrName)
    {
        if (string.IsNullOrWhiteSpace(countryCode) || string.IsNullOrWhiteSpace(codeOrName))
            return null;

        var country = GetCountryByCode(countryCode);
        if (country == null)
            return null;

        var value = codeOrName.Trim();
        var regions = country.TopLevelStates;
        var key = FoldStateName(value);

        return regions.FirstOrDefault(s => string.Equals(s.StateCode, value, StringComparison.OrdinalIgnoreCase))
               ?? FindByAlternateName(regions, FoldStateName(value, removeGenericWords: false))
               ?? FindByAlternateName(regions, key)
               ?? regions.FirstOrDefault(s => string.Equals(s.Name, value, StringComparison.OrdinalIgnoreCase))
               ?? FindByFoldedName(regions, key);
    }

    // Alternate names are compared with their generic words kept: "Mexico City" is "mexicocity", never
    // "mexico", which the State of México also folds to.
    private static State? FindByAlternateName(IReadOnlyList<State> regions, string key)
    {
        if (key.Length == 0)
            return null;

        return regions.FirstOrDefault(s => s.AlternateNames.Any(a => FoldStateName(a, removeGenericWords: false) == key));
    }

    // A folded match is only taken when it is unambiguous: "Sofia City Province" folds to "sofia", like both
    // Sofia and Sofia City, so neither is picked that way.
    private static State? FindByFoldedName(IReadOnlyList<State> regions, string key)
    {
        if (key.Length == 0)
            return null;

        var matches = regions.Where(s => FoldStateName(s.Name) == key).Take(2).ToList();

        return matches.Count == 1 ? matches[0] : null;
    }

    private static readonly string[][] LeadingStateWords = [["federal", "territory", "of"], ["county", "of"], ["region", "of"], ["province", "of"], ["state", "of"], ["county"], ["the"]];

    private static readonly HashSet<string> TrailingStateWords = ["county", "voivodeship", "district", "municipality", "city", "region", "province", "prefecture", "state", "department", "governorate"];

    // The state name with case, accents, punctuation and generic words ("County", "Voivodeship") removed, so
    // "Zürich" / "Zurich", "İstanbul" / "Istanbul", "County Dublin" / "Dublin" and
    // "Provence-Alpes-Côte d'Azur" / "Provence-Alpes-Côte-d’Azur" compare equal. A lone generic word is kept,
    // so a name never folds to nothing.
    internal static string FoldStateName(string name, bool removeGenericWords = true)
    {
        var builder = new StringBuilder(name.Length);

        foreach (var c in name.Normalize(NormalizationForm.FormD))
        {
            if (CharUnicodeInfo.GetUnicodeCategory(c) == UnicodeCategory.NonSpacingMark) continue;

            builder.Append(char.ToLowerInvariant(c) switch
            {
                'ı' => "i",
                'ł' => "l",
                'ø' => "o",
                'đ' => "d",
                'ß' => "ss",
                'æ' => "ae",
                var lower when char.IsLetterOrDigit(lower) => lower.ToString(),
                _ => " "
            });
        }

        var words = builder.ToString().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
        if (!removeGenericWords) return string.Concat(words);

        foreach (var leading in LeadingStateWords)
        {
            if (words.Count > leading.Length && words.Take(leading.Length).SequenceEqual(leading))
            {
                words.RemoveRange(0, leading.Length);
                break;
            }
        }

        while (words.Count > 1 && TrailingStateWords.Contains(words[^1])) words.RemoveAt(words.Count - 1);

        return string.Concat(words);
    }
}
