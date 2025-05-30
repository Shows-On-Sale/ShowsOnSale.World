// ⚠️ WARNING: This file is automatically generated by scripts/generate-world.ps1
// DO NOT modify this file manually as it will be overwritten when the script is run again.
// To update the data, modify the source data in countries-states-cities-database and run the script.

using System.Collections.Generic;
using ShowsOnSale.World.Models;

namespace ShowsOnSale.World.Data.Countries
{
    public static class ManIsleOf
    {
        public static Country Data { get; } = new()
        {
            Id = 134,
            Name = "Man (Isle of)",
            Iso3 = "IMN",
            Iso2 = "IM",
            NumericCode = "833",
            PhoneCode = "44",
            Capital = "Douglas, Isle of Man",
            Currency = "GBP",
            CurrencyName = "British pound",
            CurrencySymbol = "£",
            Tld = ".im",
            Native = "Isle of Man",
            Region = "Europe",
            RegionId = 4,
            Subregion = "Northern Europe",
            SubregionId = 18,
            Nationality = "Manx",
            Latitude = "54.25000000",
            Longitude = "-4.50000000",
            Emoji = "🇮🇲",
            EmojiU = "U+1F1EE U+1F1F2",
            Timezones = new()
            {
                new() { ZoneName = "Europe/Isle_of_Man", GmtOffset = 0, GmtOffsetName = "UTC±00", Abbreviation = "GMT", TzName = "Greenwich Mean Time" }
            },
            Translations = new()
            {
                ["ko"] = "맨 섬",
                ["pt-BR"] = "Ilha de Man",
                ["pt"] = "Ilha de Man",
                ["nl"] = "Isle of Man",
                ["hr"] = "Otok Man",
                ["fa"] = "جزیره من",
                ["de"] = "Insel Man",
                ["es"] = "Isla de Man",
                ["fr"] = "Île de Man",
                ["ja"] = "マン島",
                ["it"] = "Isola di Man",
                ["zh-CN"] = "马恩岛",
                ["tr"] = "Man Adasi",
                ["ru"] = "Мэн (остров)",
                ["uk"] = "Мен (острів Мен)",
                ["pl"] = "Man (Wyspa)"
            },
            States = new()
            {

                new()
                {
                    Id = 1,
                    Name = "Ayre",
                    StateCode = "01",
                    Latitude = "54.32975770",
                    Longitude = "-4.60258790",
                    Type = "sheadings",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Andreas", Latitude = "54.36841400", Longitude = "-4.52114630" },
                        new() { Id = 2, Name = "Bride", Latitude = "54.38316570", Longitude = "-4.40803560" },
                        new() { Id = 3, Name = "Lezayre", Latitude = "54.29621930", Longitude = "-4.53110150" }
                    }
                },

                new()
                {
                    Id = 2,
                    Name = "Garff",
                    StateCode = "02",
                    Latitude = "54.25687200",
                    Longitude = "-4.55473070",
                    Type = "sheadings",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Lonan", Latitude = "54.22104520", Longitude = "-4.50103060" },
                        new() { Id = 2, Name = "Maughold", Latitude = "54.25494540", Longitude = "-4.51223490" },
                        new() { Id = 3, Name = "Onchan", Latitude = "54.19815080", Longitude = "-4.54908980" }
                    }
                },

                new()
                {
                    Id = 3,
                    Name = "Glenfaba",
                    StateCode = "03",
                    Latitude = "54.19855340",
                    Longitude = "-4.81314070",
                    Type = "sheadings",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "German", Latitude = "54.21871450", Longitude = "-4.70652730" }
                    }
                },

                new()
                {
                    Id = 4,
                    Name = "Michael",
                    StateCode = "04",
                    Latitude = "54.27427780",
                    Longitude = "-4.64273250",
                    Type = "sheadings",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Ballaugh", Latitude = "54.30481210", Longitude = "-4.62075260" },
                        new() { Id = 2, Name = "Jurby", Latitude = "54.35905280", Longitude = "-4.54065860" },
                        new() { Id = 3, Name = "Michael", Latitude = "54.27427780", Longitude = "-4.64273250" }
                    }
                },

                new()
                {
                    Id = 5,
                    Name = "Middle",
                    StateCode = "05",
                    Latitude = "54.17770520",
                    Longitude = "-4.81064360",
                    Type = "sheadings",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Braddan", Latitude = "54.16328280", Longitude = "-4.52585060" },
                        new() { Id = 2, Name = "Marown", Latitude = "54.18462420", Longitude = "-4.64952180" },
                        new() { Id = 3, Name = "Santon", Latitude = "54.12054890", Longitude = "-4.64937750" }
                    }
                },

                new()
                {
                    Id = 6,
                    Name = "Rushen",
                    StateCode = "06",
                    Latitude = "54.09574060",
                    Longitude = "-4.82835170",
                    Type = "sheadings",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Arbory", Latitude = "54.10878070", Longitude = "-4.83564540" },
                        new() { Id = 2, Name = "Malew", Latitude = "54.11180490", Longitude = "-4.80138270" },
                        new() { Id = 3, Name = "Rushen", Latitude = "54.09084920", Longitude = "-4.84149820" }
                    }
                }
            }
        };
    }
}
