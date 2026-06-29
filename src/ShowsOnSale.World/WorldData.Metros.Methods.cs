namespace ShowsOnSale.World;

public partial class WorldData
{
    /// <summary>
    /// Gets a metro area by its stable id slug (e.g. "us-nyc").
    /// </summary>
    /// <param name="id">The metro area id.</param>
    /// <returns>The metro area if found; otherwise, null.</returns>
    public static Models.MetroArea? GetMetroAreaById(string id)
    {
        if (string.IsNullOrWhiteSpace(id))
            return null;

        id = id.Trim();

        return MetroAreas.FirstOrDefault(m =>
            string.Equals(m.Id, id, StringComparison.OrdinalIgnoreCase));
    }

    /// <summary>
    /// Gets all metro areas associated with a country. A metro is matched if the country is
    /// its primary country or appears anywhere in its list of touched countries (so trinational
    /// metros are returned for each member country).
    /// </summary>
    /// <param name="countryCode">The ISO2 or ISO3 code of the country.</param>
    /// <returns>The matching metro areas (possibly empty).</returns>
    public static IEnumerable<Models.MetroArea> GetMetroAreasByCountry(string countryCode)
    {
        if (string.IsNullOrWhiteSpace(countryCode))
            return Enumerable.Empty<Models.MetroArea>();

        // Normalize ISO3 -> ISO2 so callers can pass either form.
        var country = GetCountryByCode(countryCode);
        var iso2 = country?.Iso2 ?? countryCode.Trim();

        return MetroAreas.Where(m =>
            m.Countries.Any(c => string.Equals(c, iso2, StringComparison.OrdinalIgnoreCase)));
    }

    /// <summary>
    /// Reverse lookup: finds the metro area that contains a given city. A city is identified by
    /// the (stateId, cityId) pair because <c>City.Id</c> is only unique within a state.
    /// </summary>
    /// <param name="stateId">The owning <c>State.Id</c>.</param>
    /// <param name="cityId">The <c>City.Id</c>, unique within the state.</param>
    /// <returns>The containing metro area if any; otherwise, null.</returns>
    public static Models.MetroArea? GetMetroAreaForCity(int stateId, int cityId)
    {
        return MetroAreas.FirstOrDefault(m =>
            m.Members.Any(member =>
                member.Type == Models.MetroMemberType.City &&
                member.StateId == stateId &&
                member.CityId == cityId));
    }
}
