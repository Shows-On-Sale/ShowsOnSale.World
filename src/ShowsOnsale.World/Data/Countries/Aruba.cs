// ⚠️ WARNING: This file is automatically generated by scripts/generate-world.ps1
// DO NOT modify this file manually as it will be overwritten when the script is run again.
// To update the data, modify the source data in countries-states-cities-database and run the script.

using System.Collections.Generic;
using ShowsOnSale.World.Models;

namespace ShowsOnSale.World.Data.Countries
{
    public static class Aruba
    {
        public static Country Data { get; } = new Country
        {
            Id = 13,
            Name = "Aruba",
            Iso3 = "ABW",
            Iso2 = "AW",
            NumericCode = "533",
            PhoneCode = "297",
            Capital = "Oranjestad",
            Currency = "AWG",
            CurrencyName = "Aruban florin",
            CurrencySymbol = "ƒ",
            Tld = ".aw",
            Native = "Aruba",
            Region = "Americas",
            RegionId = 2,
            Subregion = "Caribbean",
            SubregionId = 7,
            Nationality = "Aruban",
            Latitude = "12.50000000",
            Longitude = "-69.96666666",
            Emoji = "🇦🇼",
            EmojiU = "U+1F1E6 U+1F1FC",
            Timezones = new List<Timezone>
            {
                new Timezone
                {
                    ZoneName = "America/Aruba",
                    GmtOffset = -14400,
                    GmtOffsetName = "UTC-04:00",
                    Abbreviation = "AST",
                    TzName = "Atlantic Standard Time"
                }
            },
            Translations = new Dictionary<string, string>
            {
                { "ko" = "아루바" },
                { "pt-BR" = "Aruba" }
                { "pt" = "Aruba" }
                { "nl" = "Aruba" }
                { "hr" = "Aruba" }
                { "fa" = "آروبا" }
                { "de" = "Aruba" }
                { "es" = "Aruba" }
                { "fr" = "Aruba" }
                { "ja" = "アルバ" }
                { "it" = "Aruba" }
                { "zh-CN" = "阿鲁巴" }
                { "tr" = "Aruba" }
                { "ru" = "Аруба" }
                { "uk" = "Аруба" }
                { "pl" = "Aruba" }
            },
            States = new List<State>
            {

                new State
                {
                    Id = 1,
                    Name = "Noord",
                    StateCode = "",
                    Latitude = "12.58243290",
                    Longitude = "-70.06761180",
                    Type = "region",
                    Cities = new List<City>
                    {
                    }
                },

                new State
                {
                    Id = 2,
                    Name = "Oranjestad",
                    StateCode = "",
                    Latitude = "12.50837050",
                    Longitude = "-70.05452530",
                    Type = "capital city",
                    Cities = new List<City>
                    {
                    }
                },

                new State
                {
                    Id = 3,
                    Name = "Oranjestad East",
                    StateCode = "",
                    Latitude = "12.51331810",
                    Longitude = "-70.05048180",
                    Type = "region",
                    Cities = new List<City>
                    {
                    }
                },

                new State
                {
                    Id = 4,
                    Name = "Oranjestad West",
                    StateCode = "",
                    Latitude = "12.53522930",
                    Longitude = "-70.06284040",
                    Type = "region",
                    Cities = new List<City>
                    {
                    }
                },

                new State
                {
                    Id = 5,
                    Name = "Paradera",
                    StateCode = "",
                    Latitude = "12.53628710",
                    Longitude = "-70.01485110",
                    Type = "region",
                    Cities = new List<City>
                    {
                    }
                },

                new State
                {
                    Id = 6,
                    Name = "San Nicolaas Noord",
                    StateCode = "",
                    Latitude = "12.46427170",
                    Longitude = "-69.94349390",
                    Type = "region",
                    Cities = new List<City>
                    {
                    }
                },

                new State
                {
                    Id = 7,
                    Name = "San Nicolaas Zuid",
                    StateCode = "",
                    Latitude = "12.42785580",
                    Longitude = "-69.93810790",
                    Type = "region",
                    Cities = new List<City>
                    {
                    }
                },

                new State
                {
                    Id = 8,
                    Name = "Santa Cruz",
                    StateCode = "",
                    Latitude = "12.51128360",
                    Longitude = "-69.98769660",
                    Type = "region",
                    Cities = new List<City>
                    {
                    }
                },

                new State
                {
                    Id = 9,
                    Name = "Savaneta",
                    StateCode = "",
                    Latitude = "12.46184190",
                    Longitude = "-69.98558580",
                    Type = "region",
                    Cities = new List<City>
                    {
                    }
                }
            }
        };
    }
}
