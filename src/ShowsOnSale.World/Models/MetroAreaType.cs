namespace ShowsOnSale.World.Models
{
    /// <summary>
    /// Classifies a <see cref="MetroArea"/>. Mirrors the U.S. OMB Core-Based Statistical Area
    /// (CBSA) vocabulary, with <see cref="Other"/> for curated non-US metros that don't map to
    /// the OMB framework.
    /// </summary>
    public enum MetroAreaType
    {
        /// <summary>Metropolitan Statistical Area — an urban core of 50,000+ (the search unit for events).</summary>
        Msa,

        /// <summary>Micropolitan Statistical Area — an urban core of 10,000–49,999.</summary>
        Micropolitan,

        /// <summary>A curated metro that does not correspond to a U.S. OMB statistical area (e.g. international metros).</summary>
        Other
    }
}
