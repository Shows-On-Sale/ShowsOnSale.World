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
            .OfType<Models.City>()
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
            .OfType<Models.Country>()
            .ToList();
    }

    /// <summary>
    /// Gets the metro area's single local timezone, resolved from its centroid at data-generation
    /// time (see <see cref="Models.MetroArea.TimeZoneId"/>). This is the correct way to get "the
    /// timezone of a metro" — unlike <see cref="GetMetroTimezones"/>, it returns one zone, not the
    /// whole country's candidate set.
    /// </summary>
    /// <param name="metro">The metro area.</param>
    /// <returns>
    /// The <see cref="Models.Timezone"/> matching <see cref="Models.MetroArea.TimeZoneId"/>, or null
    /// if the metro has no resolved id or the dataset carries no matching zone record. When this is
    /// null but <see cref="Models.MetroArea.TimeZoneId"/> is set, callers can still resolve the id
    /// directly via <see cref="System.TimeZoneInfo.FindSystemTimeZoneById(string)"/>.
    /// </returns>
    public static Models.Timezone? GetMetroTimezone(Models.MetroArea metro)
    {
        if (string.IsNullOrEmpty(metro?.TimeZoneId))
            return null;

        // The resolved IANA zone belongs to one of the metro's countries; fall back to the global
        // set so a metro whose primary country list is incomplete still resolves.
        return GetMetroCountries(metro)
            .SelectMany(c => c.Timezones)
            .Concat(Timezones)
            .FirstOrDefault(t => string.Equals(t.ZoneName, metro.TimeZoneId, StringComparison.OrdinalIgnoreCase));
    }

    /// <summary>
    /// Gets the timezones for a metro area. When the metro has a resolved local zone
    /// (<see cref="Models.MetroArea.TimeZoneId"/>) this returns just that single zone; otherwise it
    /// falls back to the <i>candidate</i> set — the union of the timezones of every country the metro
    /// touches, de-duplicated and ordered by zone name. Prefer <see cref="GetMetroTimezone"/> when you
    /// want the one local zone.
    /// </summary>
    /// <param name="metro">The metro area.</param>
    /// <returns>The metro's resolved local zone (single item), or the distinct country-level candidates ordered by zone name.</returns>
    public static IEnumerable<Models.Timezone> GetMetroTimezones(Models.MetroArea metro)
    {
        if (metro is null)
            return Enumerable.Empty<Models.Timezone>();

        var resolved = GetMetroTimezone(metro);
        if (resolved is not null)
            return new[] { resolved };

        return GetMetroCountries(metro)
            .SelectMany(c => c.Timezones)
            .DistinctBy(t => t.ZoneName)
            .OrderBy(t => t.ZoneName);
    }
}
