// ⚠️ WARNING: This file is automatically generated by scripts/generate-world.ps1
// DO NOT modify this file manually as it will be overwritten when the script is run again.
// To update the data, modify the source data in countries-states-cities-database and run the script.

using System.Collections.Generic;
using ShowsOnSale.World.Models;

namespace ShowsOnSale.World.Data.Countries
{
    public static class Kuwait
    {
        public static Country Data { get; } = new()
        {
            Id = 116,
            Name = "Kuwait",
            Iso3 = "KWT",
            Iso2 = "KW",
            NumericCode = "414",
            PhoneCode = "965",
            Capital = "Kuwait City",
            Currency = "KWD",
            CurrencyName = "Kuwaiti dinar",
            CurrencySymbol = "ك.د",
            Tld = ".kw",
            Native = "الكويت",
            Region = "Asia",
            RegionId = 3,
            Subregion = "Western Asia",
            SubregionId = 11,
            Nationality = "Kuwaiti",
            Latitude = "29.50000000",
            Longitude = "45.75000000",
            Emoji = "🇰🇼",
            EmojiU = "U+1F1F0 U+1F1FC",
            Timezones = new()
            {
                new() { ZoneName = "Asia/Kuwait", GmtOffset = 10800, GmtOffsetName = "UTC+03:00", Abbreviation = "AST", TzName = "Arabia Standard Time" }
            },
            Translations = new()
            {
                ["ko"] = "쿠웨이트",
                ["pt-BR"] = "Kuwait",
                ["pt"] = "Kuwait",
                ["nl"] = "Koeweit",
                ["hr"] = "Kuvajt",
                ["fa"] = "کویت",
                ["de"] = "Kuwait",
                ["es"] = "Kuwait",
                ["fr"] = "Koweït",
                ["ja"] = "クウェート",
                ["it"] = "Kuwait",
                ["zh-CN"] = "科威特",
                ["tr"] = "Kuveyt",
                ["ru"] = "Кувейт",
                ["uk"] = "Кувейт",
                ["pl"] = "Kuwejt"
            },
            States = new()
            {

                new()
                {
                    Id = 1,
                    Name = "Al Ahmadi",
                    StateCode = "AH",
                    Latitude = "28.57451250",
                    Longitude = "48.10247430",
                    Type = "governorate",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Al Aḩmadī", Latitude = "29.07694000", Longitude = "48.08389000" },
                        new() { Id = 2, Name = "Al Faḩāḩīl", Latitude = "29.08250000", Longitude = "48.13028000" },
                        new() { Id = 3, Name = "Al Finţās", Latitude = "29.17389000", Longitude = "48.12111000" },
                        new() { Id = 4, Name = "Al Mahbūlah", Latitude = "29.14500000", Longitude = "48.13028000" },
                        new() { Id = 5, Name = "Al Manqaf", Latitude = "29.09611000", Longitude = "48.13278000" },
                        new() { Id = 6, Name = "Al Wafrah", Latitude = "28.63917000", Longitude = "47.93056000" },
                        new() { Id = 7, Name = "Ar Riqqah", Latitude = "29.14583000", Longitude = "48.09472000" }
                    }
                },

                new()
                {
                    Id = 2,
                    Name = "Al Asimah",
                    StateCode = "KU",
                    Latitude = "26.22851610",
                    Longitude = "50.58604970",
                    Type = "governorate",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Ad Dasmah", Latitude = "29.36500000", Longitude = "48.00139000" },
                        new() { Id = 2, Name = "Ar Rābiyah", Latitude = "29.29500000", Longitude = "47.93306000" },
                        new() { Id = 3, Name = "Ash Shāmīyah", Latitude = "29.34722000", Longitude = "47.96167000" },
                        new() { Id = 4, Name = "Az Zawr", Latitude = "29.44250000", Longitude = "48.27472000" },
                        new() { Id = 5, Name = "Kuwait City", Latitude = "29.36972000", Longitude = "47.97833000" }
                    }
                },

                new()
                {
                    Id = 3,
                    Name = "Al Farwaniyah",
                    StateCode = "FA",
                    Latitude = "29.27335700",
                    Longitude = "47.94001540",
                    Type = "governorate",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Al Farwānīyah", Latitude = "29.27750000", Longitude = "47.95861000" },
                        new() { Id = 2, Name = "Janūb as Surrah", Latitude = "29.26917000", Longitude = "47.97806000" }
                    }
                },

                new()
                {
                    Id = 4,
                    Name = "Al Jahra",
                    StateCode = "JA",
                    Latitude = "29.99318310",
                    Longitude = "47.76347310",
                    Type = "governorate",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Al Jahrā’", Latitude = "29.33750000", Longitude = "47.65806000" }
                    }
                },

                new()
                {
                    Id = 5,
                    Name = "Hawalli",
                    StateCode = "HA",
                    Latitude = "29.30567160",
                    Longitude = "48.03076130",
                    Type = "governorate",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Ar Rumaythīyah", Latitude = "29.31167000", Longitude = "48.07417000" },
                        new() { Id = 2, Name = "As Sālimīyah", Latitude = "29.33389000", Longitude = "48.07611000" },
                        new() { Id = 3, Name = "Bayān", Latitude = "29.30320000", Longitude = "48.04881000" },
                        new() { Id = 4, Name = "Ḩawallī", Latitude = "29.33278000", Longitude = "48.02861000" },
                        new() { Id = 5, Name = "Salwá", Latitude = "29.29583000", Longitude = "48.07861000" }
                    }
                },

                new()
                {
                    Id = 6,
                    Name = "Mubarak Al-Kabeer",
                    StateCode = "MU",
                    Latitude = "29.21224000",
                    Longitude = "48.06051080",
                    Type = "governorate",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Abu Al Hasaniya", Latitude = "29.19076000", Longitude = "48.11355000" },
                        new() { Id = 2, Name = "Abu Fatira", Latitude = "29.19746000", Longitude = "48.10278000" },
                        new() { Id = 3, Name = "Al Funayţīs", Latitude = "29.22528000", Longitude = "48.10167000" },
                        new() { Id = 4, Name = "Al-Masayel", Latitude = "29.23930000", Longitude = "48.08862000" },
                        new() { Id = 5, Name = "Şabāḩ as Sālim", Latitude = "29.25722000", Longitude = "48.05722000" }
                    }
                }
            }
        };
    }
}
