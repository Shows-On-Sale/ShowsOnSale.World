namespace ShowsOnSale.World.Models
{
    /// <summary>
    /// A city or town within a <see cref="State"/>.
    /// </summary>
    /// <remarks>
    /// <see cref="Id"/> is unique only <i>within its owning state</i>, not globally — resolve a city
    /// together with its state (see <see cref="MetroMember"/> for the composite-key rationale).
    /// </remarks>
    public class City
    {
        /// <summary>Numeric id, unique within the owning <see cref="State"/>.</summary>
        public int Id { get; set; }

        /// <summary>City name.</summary>
        public required string Name { get; set; }

        /// <summary>Latitude in decimal degrees, as a string (e.g. <c>"40.71427000"</c>). See <see cref="LatitudeValue"/> for a parsed value.</summary>
        public required string Latitude { get; set; }

        /// <summary>Longitude in decimal degrees, as a string (e.g. <c>"-74.00597000"</c>). See <see cref="LongitudeValue"/> for a parsed value.</summary>
        public required string Longitude { get; set; }

        /// <summary>The <see cref="Latitude"/> parsed to a number (invariant culture), or null if unparseable.</summary>
        public double? LatitudeValue => GeoCoordinate.Parse(Latitude);

        /// <summary>The <see cref="Longitude"/> parsed to a number (invariant culture), or null if unparseable.</summary>
        public double? LongitudeValue => GeoCoordinate.Parse(Longitude);

        /// <inheritdoc/>
        public override string ToString()
        {
            return $"{Name} ({Latitude}, {Longitude})";
        }
    }
}
