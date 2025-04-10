// ⚠️ WARNING: This file is automatically generated by scripts/generate-world.ps1
// DO NOT modify this file manually as it will be overwritten when the script is run again.
// To update the data, modify the source data in countries-states-cities-database and run the script.

using System.Collections.Generic;
using ShowsOnSale.World.Models;

namespace ShowsOnSale.World.Data.Countries
{
    public static class MarshallIslands
    {
        public static Country Data { get; } = new()
        {
            Id = 135,
            Name = "Marshall Islands",
            Iso3 = "MHL",
            Iso2 = "MH",
            NumericCode = "584",
            PhoneCode = "692",
            Capital = "Majuro",
            Currency = "USD",
            CurrencyName = "United States dollar",
            CurrencySymbol = "$",
            Tld = ".mh",
            Native = "M̧ajeļ",
            Region = "Oceania",
            RegionId = 5,
            Subregion = "Micronesia",
            SubregionId = 21,
            Nationality = "Marshallese",
            Latitude = "9.00000000",
            Longitude = "168.00000000",
            Emoji = "🇲🇭",
            EmojiU = "U+1F1F2 U+1F1ED",
            Timezones = new()
            {
                new() { ZoneName = "Pacific/Kwajalein", GmtOffset = 43200, GmtOffsetName = "UTC+12:00", Abbreviation = "MHT", TzName = "Marshall Islands Time" },
                new() { ZoneName = "Pacific/Majuro", GmtOffset = 43200, GmtOffsetName = "UTC+12:00", Abbreviation = "MHT", TzName = "Marshall Islands Time" }
            },
            Translations = new()
            {
                { "ko" = "마셜 제도" },
                { "pt-BR" = "Ilhas Marshall" }
                { "pt" = "Ilhas Marshall" }
                { "nl" = "Marshalleilanden" }
                { "hr" = "Maršalovi Otoci" }
                { "fa" = "جزایر مارشال" }
                { "de" = "Marshallinseln" }
                { "es" = "Islas Marshall" }
                { "fr" = "Îles Marshall" }
                { "ja" = "マーシャル諸島" }
                { "it" = "Isole Marshall" }
                { "zh-CN" = "马绍尔群岛" }
                { "tr" = "Marşal Adalari" }
                { "ru" = "Маршалловы острова" }
                { "uk" = "Маршаллові острови" }
                { "pl" = "Wyspy Marshalla" }
            },
            States = new()
            {

                new()
                {
                    Id = 1,
                    Name = "Ralik",
                    StateCode = "L",
                    Latitude = "8.13614600",
                    Longitude = "164.88679560",
                    Type = "chain",
                    Cities = new()
                    {
                    }
                },

                new()
                {
                    Id = 2,
                    Name = "Ratak",
                    StateCode = "T",
                    Latitude = "10.27632760",
                    Longitude = "170.55009370",
                    Type = "chain",
                    Cities = new()
                    {
                    }
                }
            }
        };
    }
}
