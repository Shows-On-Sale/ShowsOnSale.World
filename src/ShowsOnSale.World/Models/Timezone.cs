namespace ShowsOnSale.World.Models
{
    /// <summary>
    /// A time zone associated with a <see cref="Country"/>. A country may have several
    /// (e.g. the US lists every zone from <c>America/New_York</c> to <c>Pacific/Honolulu</c>).
    /// </summary>
    public class Timezone
    {
        /// <summary>IANA zone name (e.g. <c>"America/New_York"</c>).</summary>
        public required string ZoneName { get; set; }

        /// <summary>Offset from UTC in seconds (raw/standard offset as supplied upstream).</summary>
        public int GmtOffset { get; set; }

        /// <summary>Human-readable offset (e.g. <c>"UTC-05:00"</c>).</summary>
        public required string GmtOffsetName { get; set; }

        /// <summary>Short abbreviation (e.g. <c>"EST"</c>).</summary>
        public required string Abbreviation { get; set; }

        /// <summary>Descriptive name (e.g. <c>"Eastern Standard Time"</c>).</summary>
        public required string TzName { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            return $"{ZoneName} ({GmtOffsetName})";
        }
    }
}
