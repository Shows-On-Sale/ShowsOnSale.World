using System.Collections.Generic;

namespace ShowsOnSale.World.Models
{
    public class Country
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Iso3 { get; set; }
        public required string Iso2 { get; set; }
        public required string NumericCode { get; set; }
        public required string PhoneCode { get; set; }
        public required string Capital { get; set; }
        public required string Currency { get; set; }
        public required string CurrencyName { get; set; }
        public required string CurrencySymbol { get; set; }
        public required string Tld { get; set; }
        public required string Native { get; set; }
        public required string Region { get; set; }
        public int RegionId { get; set; }
        public required string Subregion { get; set; }
        public int SubregionId { get; set; }
        public required string Nationality { get; set; }
        public required List<Timezone> Timezones { get; set; }
        public required Dictionary<string, string> Translations { get; set; }
        public required string Latitude { get; set; }
        public required string Longitude { get; set; }
        public required string Emoji { get; set; }
        public required string EmojiU { get; set; }
        public required List<State> States { get; set; }

        public override string ToString()
        {
            return $"{Name} ({Iso2})";
        }
    }
} 