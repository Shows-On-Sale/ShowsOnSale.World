using System.Collections.Generic;

namespace ShowsOnSale.World.Models
{
    /// <summary>
    /// A Combined Statistical Area (CSA): a grouping of adjacent <see cref="MetroArea"/>s linked by
    /// commuting ties, mirroring the U.S. OMB framework. A CSA is a roll-up <i>over</i> metros — it
    /// references its member metros by id and never replaces them. For event search the metro is the
    /// catchment; the CSA is the optional wider "region" (e.g. tour routing or market analytics).
    /// </summary>
    public class CombinedStatisticalArea
    {
        /// <summary>Stable, human-readable slug (e.g. <c>"csa-new-york"</c>). Primary key.</summary>
        public required string Id { get; init; }

        /// <summary>Full OMB title (e.g. <c>"New York–Newark, NY-NJ-CT-PA"</c>).</summary>
        public required string Name { get; init; }

        /// <summary>Optional external standard code (e.g. an OMB CSA code). Null where not curated.</summary>
        public string? Code { get; init; }

        /// <summary>ISO2 code of the country the CSA belongs to.</summary>
        public required string CountryIso2 { get; init; }

        /// <summary>Most recent population estimate, if known (Census Bureau Vintage 2024 for US CSAs).</summary>
        public long? Population { get; init; }

        /// <summary>Ids of the member <see cref="MetroArea"/>s that roll up into this CSA.</summary>
        public required List<string> MetroIds { get; init; }

        public override string ToString()
        {
            return $"{Name} ({Id})";
        }
    }
}
