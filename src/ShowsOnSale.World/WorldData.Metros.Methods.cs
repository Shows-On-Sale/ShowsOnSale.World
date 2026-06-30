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

    /// <summary>
    /// Resolves a member's <c>StateId</c> to the live <see cref="Models.State"/> in the world data.
    /// </summary>
    /// <param name="member">The metro member.</param>
    /// <returns>The state if the member has a resolvable <c>StateId</c>; otherwise, null.</returns>
    public static Models.State? ResolveState(Models.MetroMember member)
    {
        if (member?.StateId is null)
            return null;

        // States are scoped to the member's country first (cheap, unambiguous); fall back to a
        // global search if the country can't be resolved.
        var country = GetCountryByCode(member.CountryIso2);
        var states = country?.States ?? All.SelectMany(c => c.States);

        return states.FirstOrDefault(s => s.Id == member.StateId.Value);
    }

    /// <summary>
    /// Resolves a <see cref="Models.MetroMemberType.City"/> member to the live <see cref="Models.City"/>
    /// in the world data, using the <c>(StateId, CityId)</c> pair.
    /// </summary>
    /// <param name="member">The metro member.</param>
    /// <returns>The city if the member is a resolvable city; otherwise, null.</returns>
    public static Models.City? ResolveCity(Models.MetroMember member)
    {
        if (member is null || member.Type != Models.MetroMemberType.City || member.CityId is null)
            return null;

        var state = ResolveState(member);
        return state?.Cities.FirstOrDefault(c => c.Id == member.CityId.Value);
    }

    /// <summary>
    /// Resolves all city members of a metro area to their live <see cref="Models.City"/> objects.
    /// Members that cannot be resolved (e.g. unresolved cross-border members) are skipped.
    /// </summary>
    /// <param name="metro">The metro area.</param>
    /// <returns>The resolved cities (possibly empty).</returns>
    public static IReadOnlyList<Models.City> GetMetroCities(Models.MetroArea metro)
    {
        if (metro is null)
            return System.Array.Empty<Models.City>();

        return metro.Members
            .Where(m => m.Type == Models.MetroMemberType.City)
            .Select(ResolveCity)
            .Where(c => c is not null)
            .Select(c => c!)
            .ToList();
    }

    /// <summary>
    /// Gets the live <see cref="Models.Country"/> objects a metro area touches.
    /// </summary>
    /// <param name="metro">The metro area.</param>
    /// <returns>The resolved countries (possibly empty).</returns>
    public static IReadOnlyList<Models.Country> GetMetroCountries(Models.MetroArea metro)
    {
        if (metro is null)
            return System.Array.Empty<Models.Country>();

        return metro.Countries
            .Select(GetCountryByCode)
            .Where(c => c is not null)
            .Select(c => c!)
            .ToList();
    }

    /// <summary>
    /// Gets the <i>candidate</i> timezones for a metro area: the union of the timezones of every
    /// country the metro touches, de-duplicated and ordered by zone name. Because the underlying
    /// dataset carries timezones only at the country level (not per city), this is the set a metro
    /// <i>could</i> fall in, not a single resolved local zone. For a metro inside a multi-timezone
    /// country (e.g. any US metro) this returns <b>all</b> of that country's zones, so do not treat
    /// the result as the metro's one local timezone.
    /// </summary>
    /// <param name="metro">The metro area.</param>
    /// <returns>The distinct candidate timezones, ordered by zone name.</returns>
    public static IEnumerable<Models.Timezone> GetMetroTimezones(Models.MetroArea metro)
    {
        if (metro is null)
            return Enumerable.Empty<Models.Timezone>();

        return GetMetroCountries(metro)
            .SelectMany(c => c.Timezones)
            .GroupBy(t => t.ZoneName)
            .Select(g => g.First())
            .OrderBy(t => t.ZoneName);
    }
}
