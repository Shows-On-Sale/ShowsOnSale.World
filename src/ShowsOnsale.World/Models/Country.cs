using System.Collections.Generic;

namespace ShowsOnSale.World.Models
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Iso3 { get; set; }
        public string Iso2 { get; set; }
        public string NumericCode { get; set; }
        public string Phonecode { get; set; }
        public string Capital { get; set; }
        public string Currency { get; set; }
        public string CurrencyName { get; set; }
        public string CurrencySymbol { get; set; }
        public string Tld { get; set; }
        public string Native { get; set; }
        public string Region { get; set; }
        public int RegionId { get; set; }
        public string Subregion { get; set; }
        public int SubregionId { get; set; }
        public string Nationality { get; set; }
        public List<Timezone> Timezones { get; set; }
        public Dictionary<string, string> Translations { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string Emoji { get; set; }
        public string EmojiU { get; set; }
        public List<State> States { get; set; }

        public override string ToString()
        {
            return $"{Name} ({Iso2})";
        }
    }
} 