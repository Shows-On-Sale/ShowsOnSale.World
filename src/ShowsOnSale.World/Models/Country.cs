using System.Collections.Generic;

namespace ShowsOnSale.World.Models
{
    /// <summary>
    /// A country, with its ISO codes, currency, geography, localized names, and its
    /// <see cref="States"/> and <see cref="Timezones"/>.
    /// </summary>
    public class Country
    {
        /// <summary>Numeric id from the upstream dataset.</summary>
        public int Id { get; set; }

        /// <summary>Common English name (e.g. <c>"United States"</c>).</summary>
        public required string Name { get; set; }

        /// <summary>ISO 3166-1 alpha-3 code (e.g. <c>"USA"</c>).</summary>
        public required string Iso3 { get; set; }

        /// <summary>ISO 3166-1 alpha-2 code (e.g. <c>"US"</c>).</summary>
        public required string Iso2 { get; set; }

        /// <summary>ISO 3166-1 numeric code (e.g. <c>"840"</c>).</summary>
        public required string NumericCode { get; set; }

        /// <summary>International dialing code (e.g. <c>"1"</c>).</summary>
        public required string PhoneCode { get; set; }

        /// <summary>Capital city name.</summary>
        public required string Capital { get; set; }

        /// <summary>ISO 4217 currency code (e.g. <c>"USD"</c>).</summary>
        public required string Currency { get; set; }

        /// <summary>Currency display name (e.g. <c>"United States dollar"</c>).</summary>
        public required string CurrencyName { get; set; }

        /// <summary>Currency symbol (e.g. <c>"$"</c>).</summary>
        public required string CurrencySymbol { get; set; }

        /// <summary>Top-level domain (e.g. <c>".us"</c>).</summary>
        public required string Tld { get; set; }

        /// <summary>Native-language name.</summary>
        public required string Native { get; set; }

        /// <summary>Geographic region (e.g. <c>"Americas"</c>).</summary>
        public required string Region { get; set; }

        /// <summary>Numeric id of the <see cref="Region"/>.</summary>
        public int RegionId { get; set; }

        /// <summary>Geographic subregion (e.g. <c>"Northern America"</c>).</summary>
        public required string Subregion { get; set; }

        /// <summary>Numeric id of the <see cref="Subregion"/>.</summary>
        public int SubregionId { get; set; }

        /// <summary>Demonym / nationality (e.g. <c>"American"</c>).</summary>
        public required string Nationality { get; set; }

        /// <summary>Time zones the country spans.</summary>
        public required List<Timezone> Timezones { get; set; }

        /// <summary>Localized country names keyed by language code.</summary>
        public required Dictionary<string, string> Translations { get; set; }

        /// <summary>Latitude in decimal degrees, as a string. See <see cref="LatitudeValue"/> for a parsed value.</summary>
        public required string Latitude { get; set; }

        /// <summary>Longitude in decimal degrees, as a string. See <see cref="LongitudeValue"/> for a parsed value.</summary>
        public required string Longitude { get; set; }

        /// <summary>Flag emoji (e.g. <c>"🇺🇸"</c>).</summary>
        public required string Emoji { get; set; }

        /// <summary>Unicode code points of the flag emoji (e.g. <c>"U+1F1FA U+1F1F8"</c>).</summary>
        public required string EmojiU { get; set; }

        /// <summary>The administrative divisions (states/regions) of the country.</summary>
        public required List<State> States { get; set; }

        /// <summary>The <see cref="Latitude"/> parsed to a number (invariant culture), or null if unparseable.</summary>
        public double? LatitudeValue => GeoCoordinate.Parse(Latitude);

        /// <summary>The <see cref="Longitude"/> parsed to a number (invariant culture), or null if unparseable.</summary>
        public double? LongitudeValue => GeoCoordinate.Parse(Longitude);

        /// <inheritdoc/>
        public override string ToString()
        {
            return $"{Name} ({Iso2})";
        }
    }
}
