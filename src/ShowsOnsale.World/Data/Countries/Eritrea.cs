// ⚠️ WARNING: This file is automatically generated by scripts/generate-world.ps1
// DO NOT modify this file manually as it will be overwritten when the script is run again.
// To update the data, modify the source data in countries-states-cities-database and run the script.

using System.Collections.Generic;
using ShowsOnSale.World.Models;

namespace ShowsOnSale.World.Data.Countries
{
    public static class Eritrea
    {
        public static Country Data { get; } = new()
        {
            Id = 68,
            Name = "Eritrea",
            Iso3 = "ERI",
            Iso2 = "ER",
            NumericCode = "232",
            PhoneCode = "291",
            Capital = "Asmara",
            Currency = "ERN",
            CurrencyName = "Eritrean nakfa",
            CurrencySymbol = "Nfk",
            Tld = ".er",
            Native = "ኤርትራ",
            Region = "Africa",
            RegionId = 1,
            Subregion = "Eastern Africa",
            SubregionId = 4,
            Nationality = "Eritrean",
            Latitude = "15.00000000",
            Longitude = "39.00000000",
            Emoji = "🇪🇷",
            EmojiU = "U+1F1EA U+1F1F7",
            Timezones = new()
            {
                new() { ZoneName = "Africa/Asmara", GmtOffset = 10800, GmtOffsetName = "UTC+03:00", Abbreviation = "EAT", TzName = "East Africa Time" }
            },
            Translations = new()
            {
                { "ko" = "에리트레아" },
                { "pt-BR" = "Eritreia" }
                { "pt" = "Eritreia" }
                { "nl" = "Eritrea" }
                { "hr" = "Eritreja" }
                { "fa" = "اریتره" }
                { "de" = "Eritrea" }
                { "es" = "Eritrea" }
                { "fr" = "Érythrée" }
                { "ja" = "エリトリア" }
                { "it" = "Eritrea" }
                { "zh-CN" = "厄立特里亚" }
                { "tr" = "Eritre" }
                { "ru" = "Эритрея" }
                { "uk" = "Еритрея" }
                { "pl" = "Erytrea" }
            },
            States = new()
            {

                new()
                {
                    Id = 1,
                    Name = "Anseba",
                    StateCode = "AN",
                    Latitude = "16.47455310",
                    Longitude = "37.80876930",
                    Type = "region",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Keren", Latitude = "15.77792000", Longitude = "38.45107000" }
                    }
                },

                new()
                {
                    Id = 2,
                    Name = "Debub",
                    StateCode = "DU",
                    Latitude = "14.94786920",
                    Longitude = "39.15436770",
                    Type = "region",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Adi Keyh", Latitude = "14.84444000", Longitude = "39.37722000" },
                        new() { Id = 2, Name = "Dek’emhāre", Latitude = "15.07000000", Longitude = "39.04750000" },
                        new() { Id = 3, Name = "Mendefera", Latitude = "14.88722000", Longitude = "38.81528000" }
                    }
                },

                new()
                {
                    Id = 3,
                    Name = "Gash-Barka",
                    StateCode = "GB",
                    Latitude = "15.40688250",
                    Longitude = "37.63866220",
                    Type = "region",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Ak’ordat", Latitude = "15.54798000", Longitude = "37.88291000" },
                        new() { Id = 2, Name = "Barentu", Latitude = "15.10582000", Longitude = "37.59067000" },
                        new() { Id = 3, Name = "Teseney", Latitude = "15.11000000", Longitude = "36.65750000" }
                    }
                },

                new()
                {
                    Id = 4,
                    Name = "Maekel",
                    StateCode = "MA",
                    Latitude = "15.35514090",
                    Longitude = "38.86236830",
                    Type = "region",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Asmara", Latitude = "15.33805000", Longitude = "38.93184000" }
                    }
                },

                new()
                {
                    Id = 5,
                    Name = "Northern Red Sea",
                    StateCode = "SK",
                    Latitude = "16.25839970",
                    Longitude = "38.82054540",
                    Type = "region",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Massawa", Latitude = "15.60811000", Longitude = "39.47455000" }
                    }
                },

                new()
                {
                    Id = 6,
                    Name = "Southern Red Sea",
                    StateCode = "DK",
                    Latitude = "13.51371030",
                    Longitude = "41.76064720",
                    Type = "region",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Assab", Latitude = "13.00917000", Longitude = "42.73944000" },
                        new() { Id = 2, Name = "Edd", Latitude = "13.93088000", Longitude = "41.69380000" }
                    }
                }
            }
        };
    }
}
