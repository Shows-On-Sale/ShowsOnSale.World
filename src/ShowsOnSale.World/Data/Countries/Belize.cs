// ⚠️ WARNING: This file is automatically generated by scripts/generate-world.ps1
// DO NOT modify this file manually as it will be overwritten when the script is run again.
// To update the data, modify the source data in countries-states-cities-database and run the script.

using System.Collections.Generic;
using ShowsOnSale.World.Models;

namespace ShowsOnSale.World.Data.Countries
{
    public static class Belize
    {
        public static Country Data { get; } = new()
        {
            Id = 22,
            Name = "Belize",
            Iso3 = "BLZ",
            Iso2 = "BZ",
            NumericCode = "084",
            PhoneCode = "501",
            Capital = "Belmopan",
            Currency = "BZD",
            CurrencyName = "Belize dollar",
            CurrencySymbol = "$",
            Tld = ".bz",
            Native = "Belize",
            Region = "Americas",
            RegionId = 2,
            Subregion = "Central America",
            SubregionId = 9,
            Nationality = "Belizean",
            Latitude = "17.25000000",
            Longitude = "-88.75000000",
            Emoji = "🇧🇿",
            EmojiU = "U+1F1E7 U+1F1FF",
            Timezones = new()
            {
                new() { ZoneName = "America/Belize", GmtOffset = -21600, GmtOffsetName = "UTC-06:00", Abbreviation = "CST", TzName = "Central Standard Time (North America)" }
            },
            Translations = new()
            {
                ["ko"] = "벨리즈",
                ["pt-BR"] = "Belize",
                ["pt"] = "Belize",
                ["nl"] = "Belize",
                ["hr"] = "Belize",
                ["fa"] = "بلیز",
                ["de"] = "Belize",
                ["es"] = "Belice",
                ["fr"] = "Belize",
                ["ja"] = "ベリーズ",
                ["it"] = "Belize",
                ["zh-CN"] = "伯利兹",
                ["tr"] = "Belize",
                ["ru"] = "Белиз",
                ["uk"] = "Беліз",
                ["pl"] = "Belize"
            },
            States = new()
            {

                new()
                {
                    Id = 1,
                    Name = "Belize",
                    StateCode = "BZ",
                    Latitude = "17.56776790",
                    Longitude = "-88.40160410",
                    Type = "district",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Belize City", Latitude = "17.49952000", Longitude = "-88.19756000" },
                        new() { Id = 2, Name = "San Pedro", Latitude = "17.91598000", Longitude = "-87.96590000" }
                    }
                },

                new()
                {
                    Id = 2,
                    Name = "Cayo",
                    StateCode = "CY",
                    Latitude = "17.09844450",
                    Longitude = "-88.94138650",
                    Type = "district",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Belmopan", Latitude = "17.25000000", Longitude = "-88.76667000" },
                        new() { Id = 2, Name = "Benque Viejo el Carmen", Latitude = "17.07500000", Longitude = "-89.13917000" },
                        new() { Id = 3, Name = "San Ignacio", Latitude = "17.15880000", Longitude = "-89.06960000" },
                        new() { Id = 4, Name = "Valley of Peace", Latitude = "17.33472000", Longitude = "-88.83472000" }
                    }
                },

                new()
                {
                    Id = 3,
                    Name = "Corozal",
                    StateCode = "CZL",
                    Latitude = "18.13492380",
                    Longitude = "-88.24611830",
                    Type = "district",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Corozal", Latitude = "18.39375000", Longitude = "-88.38849000" }
                    }
                },

                new()
                {
                    Id = 4,
                    Name = "Orange Walk",
                    StateCode = "OW",
                    Latitude = "17.76035300",
                    Longitude = "-88.86469800",
                    Type = "district",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Hopelchén", Latitude = "17.80000000", Longitude = "-89.10000000" },
                        new() { Id = 2, Name = "Orange Walk", Latitude = "18.08124000", Longitude = "-88.56328000" },
                        new() { Id = 3, Name = "Shipyard", Latitude = "17.89382000", Longitude = "-88.65452000" }
                    }
                },

                new()
                {
                    Id = 5,
                    Name = "Stann Creek",
                    StateCode = "SC",
                    Latitude = "16.81166310",
                    Longitude = "-88.40160410",
                    Type = "district",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Dangriga", Latitude = "16.96970000", Longitude = "-88.23313000" },
                        new() { Id = 2, Name = "Placencia", Latitude = "16.51419000", Longitude = "-88.36647000" }
                    }
                },

                new()
                {
                    Id = 6,
                    Name = "Toledo",
                    StateCode = "TOL",
                    Latitude = "16.24919230",
                    Longitude = "-88.86469800",
                    Type = "district",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Punta Gorda", Latitude = "16.09835000", Longitude = "-88.80970000" }
                    }
                }
            }
        };
    }
}
