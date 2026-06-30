using System.Collections.Generic;

namespace ShowsOnSale.World.Models
{
    /// <summary>
    /// An administrative division of a <see cref="Country"/> — a state, province, region, territory,
    /// or similar. (For the US this includes DC, territories, and military "states" such as AA/AE/AP,
    /// so the count is greater than 50.)
    /// </summary>
    /// <remarks>
    /// <see cref="Id"/> is unique only <i>within its owning country</i>; many countries reuse the same
    /// numeric ids, so resolve a state together with its country. <see cref="StateCode"/> is empty for
    /// some countries (notably the US), so prefer <see cref="Id"/> as the foreign key in those cases.
    /// </remarks>
    public class State
    {
        /// <summary>Numeric id, unique within the owning <see cref="Country"/>.</summary>
        public int Id { get; set; }

        /// <summary>State / region name.</summary>
        public required string Name { get; set; }

        /// <summary>Short subdivision code (e.g. <c>"NY"</c>). May be empty for some countries.</summary>
        public required string StateCode { get; set; }

        /// <summary>Latitude in decimal degrees, as a string. See <see cref="LatitudeValue"/> for a parsed value.</summary>
        public required string Latitude { get; set; }

        /// <summary>Longitude in decimal degrees, as a string. See <see cref="LongitudeValue"/> for a parsed value.</summary>
        public required string Longitude { get; set; }

        /// <summary>Division type as classified upstream (e.g. <c>"state"</c>, <c>"province"</c>, <c>"territory"</c>).</summary>
        public required string Type { get; set; }

        /// <summary>The cities within this state.</summary>
        public required List<City> Cities { get; set; }

        /// <summary>The <see cref="Latitude"/> parsed to a number (invariant culture), or null if unparseable.</summary>
        public double? LatitudeValue => GeoCoordinate.Parse(Latitude);

        /// <summary>The <see cref="Longitude"/> parsed to a number (invariant culture), or null if unparseable.</summary>
        public double? LongitudeValue => GeoCoordinate.Parse(Longitude);

        /// <inheritdoc/>
        public override string ToString()
        {
            return $"{Name} ({StateCode})";
        }
    }
}
