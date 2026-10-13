using System.Collections.Generic;
using System.Text.Json.Serialization;

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
    /// a small number of states that have no code upstream.
    /// </remarks>
    public class State
    {
        /// <summary>Numeric id, unique within the owning <see cref="Country"/>.</summary>
        public int Id { get; set; }

        /// <summary>State / region name.</summary>
        public required string Name { get; set; }

        /// <summary>Short subdivision code (e.g. <c>"NY"</c>). Empty for the few states with no code upstream.</summary>
        public required string StateCode { get; set; }

        /// <summary>Full ISO 3166-2 subdivision code including the country prefix (e.g. <c>"US-NY"</c>). May be empty.</summary>
        public string Iso3166_2 { get; set; } = "";

        /// <summary>IANA time zone of the state as classified upstream (e.g. <c>"America/New_York"</c>). May be empty.</summary>
        public string TimeZoneId { get; set; } = "";

        /// <summary>Latitude in decimal degrees, as a string. See <see cref="LatitudeValue"/> for a parsed value.</summary>
        public required string Latitude { get; set; }

        /// <summary>Longitude in decimal degrees, as a string. See <see cref="LongitudeValue"/> for a parsed value.</summary>
        public required string Longitude { get; set; }

        /// <summary>Division type as classified upstream (e.g. <c>"state"</c>, <c>"province"</c>, <c>"territory"</c>).</summary>
        public required string Type { get; set; }

        /// <summary>
        /// Whether this is a first-level administrative division (the level Google reports as
        /// <c>administrative_area_level_1</c>). Upstream lists some lower levels alongside them, e.g. the
        /// London boroughs next to England, the French departments next to the regions, and the Spanish and
        /// Italian provinces next to the communities and regions; those are <c>false</c>. Maintained in
        /// <c>data/state-levels.json</c>. See <see cref="Country.TopLevelStates"/>.
        /// </summary>
        public bool IsTopLevel { get; set; } = true;

        /// <summary>
        /// Other names for the state that do not fold to <see cref="Name"/>: local-language names
        /// (<c>"Wien"</c>, <c>"Toscana"</c>), English names (<c>"Brittany"</c>, <c>"Masovian"</c>), and
        /// conventional abbreviations (<c>"NRW"</c>, <c>"Jal."</c>, <c>"CDMX"</c>). Maintained in
        /// <c>data/state-names.json</c>; empty for most states.
        /// </summary>
        public List<string> AlternateNames { get; set; } = new();

        /// <summary>
        /// A short label for the state: the <see cref="StateCode"/> when it is a recognisable abbreviation of two
        /// or more letters (<c>"BE"</c>, <c>"NRW"</c>-style codes such as <c>"ENG"</c>), otherwise the
        /// <see cref="Name"/>. Codes that are numbers (Austria's <c>"9"</c> for Vienna), a single letter
        /// (Ireland's <c>"D"</c> for Dublin), mix in digits (<c>"20R"</c> for Corsica) or are empty mean nothing to
        /// a reader, so the name is used for those.
        /// </summary>
        [JsonIgnore]
        public string ShortName => StateCode.Length >= 2 && StateCode.All(char.IsLetter) ? StateCode : Name;

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
