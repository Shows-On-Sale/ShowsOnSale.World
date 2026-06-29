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
        public required string Id { get; set; }

        /// <summary>Full display name (e.g. <c>"New York–Newark–Jersey City"</c>).</summary>
        public required string Name { get; set; }

        /// <summary>Optional short / common name (e.g. <c>"New York"</c>).</summary>
        public string? ShortName { get; set; }

        /// <summary>ISO2 code of the primary country the metro is associated with.</summary>
        public required string CountryIso2 { get; set; }

        /// <summary>
        /// All ISO2 country codes the metro touches. For most metros this is a single
        /// entry equal to <see cref="CountryIso2"/>; trinational metros (e.g. Basel)
        /// list several.
        /// </summary>
        public required List<string> Countries { get; set; }

        /// <summary>
        /// Optional external standard code for the metro (e.g. a US Census/OMB CBSA code,
        /// a Eurostat code). Null where no recognized standard applies.
        /// </summary>
        public string? Code { get; set; }

        /// <summary>Approximate centroid latitude, as a string (matches the rest of the dataset).</summary>
        public string? Latitude { get; set; }

        /// <summary>Approximate centroid longitude, as a string (matches the rest of the dataset).</summary>
        public string? Longitude { get; set; }

        /// <summary>The cities, counties, and/or states that make up this metro area.</summary>
        public required List<MetroMember> Members { get; set; }

        public override string ToString()
        {
            return $"{Name} ({Id})";
        }
    }
}
