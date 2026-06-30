namespace ShowsOnSale.World;

public partial class WorldData
{
    /// <summary>
    /// Gets a combined statistical area by its stable id slug (e.g. "csa-new-york").
    /// </summary>
    /// <param name="id">The CSA id.</param>
    /// <returns>The CSA if found; otherwise, null.</returns>
    public static Models.CombinedStatisticalArea? GetCombinedStatisticalAreaById(string id)
    {
        if (string.IsNullOrWhiteSpace(id))
            return null;

        id = id.Trim();

        return CombinedStatisticalAreas.FirstOrDefault(c =>
            string.Equals(c.Id, id, StringComparison.OrdinalIgnoreCase));
    }

    /// <summary>
    /// Gets the combined statistical area a metro rolls up into, if any.
    /// </summary>
    /// <param name="metroId">The metro area id.</param>
    /// <returns>The containing CSA if the metro belongs to one; otherwise, null.</returns>
    public static Models.CombinedStatisticalArea? GetCsaForMetro(string metroId)
    {
        if (string.IsNullOrWhiteSpace(metroId))
            return null;

        metroId = metroId.Trim();

        return CombinedStatisticalAreas.FirstOrDefault(c =>
            c.MetroIds.Any(m => string.Equals(m, metroId, StringComparison.OrdinalIgnoreCase)));
    }

    /// <summary>
    /// Resolves a CSA's member metro ids to the live <see cref="Models.MetroArea"/> objects.
    /// Ids that don't resolve are skipped.
    /// </summary>
    /// <param name="csa">The combined statistical area.</param>
    /// <returns>The resolved member metros, ordered by population descending where known.</returns>
    public static IReadOnlyList<Models.MetroArea> GetCsaMetros(Models.CombinedStatisticalArea csa)
    {
        if (csa is null)
            return System.Array.Empty<Models.MetroArea>();

        return csa.MetroIds
            .Select(GetMetroAreaById)
            .Where(m => m is not null)
            .Select(m => m!)
            .OrderByDescending(m => m.Population ?? 0)
            .ToList();
    }
}
