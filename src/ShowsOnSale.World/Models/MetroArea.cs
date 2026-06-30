using System.Collections.Generic;

namespace ShowsOnSale.World.Models
{
    /// <summary>
    /// A metropolitan area: a named region that groups one or more cities, counties,
    /// and/or states. Membership can cross state and country borders, so a metro area
    /// is modeled as a top-level overlay (see <see cref="WorldData.MetroAreas"/>) rather
    /// than hanging off a single <see cref="Country"/> or <see cref="State"/>.
    /// </summary>
    public class MetroArea
    {
        /// <summary>
        /// Stable, human-readable slug that uniquely identifies the metro area
        /// (e.g. <c>"us-nyc"</c>). Used as the primary key for lookups.
        /// </summary>
        public required string Id { get; init; }

        /// <summary>Full display name (e.g. <c>"New York–Newark–Jersey City"</c>).</summary>
        public required string Name { get; init; }

        /// <summary>Optional short / common name (e.g. <c>"New York"</c>).</summary>
        public string? ShortName { get; init; }

        /// <summary>ISO2 code of the primary country the metro is associated with.</summary>
        public required string CountryIso2 { get; init; }

        /// <summary>
        /// All ISO2 country codes the metro touches. For most metros this is a single
        /// entry equal to <see cref="CountryIso2"/>; trinational metros (e.g. Basel)
        /// list several.
        /// </summary>
        public required List<string> Countries { get; init; }

        /// <summary>
        /// Optional external standard code for the metro (e.g. a US Census/OMB CBSA code,
        /// a Eurostat code). Null where no recognized standard applies.
        /// </summary>
        public string? Code { get; init; }

        /// <summary>
        /// The metro's classification. US metros are <see cref="MetroAreaType.Msa"/>; curated
        /// international metros are <see cref="MetroAreaType.Other"/>.
        /// </summary>
        public MetroAreaType Type { get; init; } = MetroAreaType.Other;

        /// <summary>
        /// Most recent population estimate, if known (US metros use the Census Bureau Vintage 2024
        /// estimate). Null where no figure is curated.
        /// </summary>
        public long? Population { get; init; }

        /// <summary>
        /// Id of the <see cref="CombinedStatisticalArea"/> this metro rolls up into, if any. A metro
        /// belongs to at most one CSA; standalone metros leave this null.
        /// </summary>
        public string? CsaId { get; init; }

        /// <summary>Approximate centroid latitude, as a string (matches the rest of the dataset).</summary>
        public string? Latitude { get; init; }

        /// <summary>Approximate centroid longitude, as a string (matches the rest of the dataset).</summary>
        public string? Longitude { get; init; }

        /// <summary>
        /// The IANA time zone id for the metro's local time (e.g. <c>"America/New_York"</c>),
        /// resolved from the centroid (<see cref="Latitude"/>/<see cref="Longitude"/>) at data-generation
        /// time. This is the metro's single local zone — unlike <see cref="WorldData.GetMetroTimezones"/>,
        /// which returns the country-level candidate set. Pass this to
        /// <see cref="System.TimeZoneInfo.FindSystemTimeZoneById(string)"/> (cross-platform on modern .NET)
        /// or resolve it via <see cref="WorldData.GetMetroTimezone(MetroArea)"/>. Null only if the centroid
        /// could not be resolved.
        /// </summary>
        public string? TimeZoneId { get; init; }

        /// <summary>The cities, counties, and/or states that make up this metro area.</summary>
        public required List<MetroMember> Members { get; init; }

        /// <summary>The <see cref="Latitude"/> parsed to a number (invariant culture), or null if absent/unparseable.</summary>
        public double? LatitudeValue => Models.GeoCoordinate.Parse(Latitude);

        /// <summary>The <see cref="Longitude"/> parsed to a number (invariant culture), or null if absent/unparseable.</summary>
        public double? LongitudeValue => Models.GeoCoordinate.Parse(Longitude);

        /// <inheritdoc/>
        public override string ToString()
        {
            return $"{Name} ({Id})";
        }
    }
}
