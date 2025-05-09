// ⚠️ WARNING: This file is automatically generated by scripts/generate-world.ps1
// DO NOT modify this file manually as it will be overwritten when the script is run again.
// To update the data, modify the source data in countries-states-cities-database and run the script.

using System.Collections.Generic;
using ShowsOnSale.World.Models;

namespace ShowsOnSale.World.Data.Countries
{
    public static class Burundi
    {
        public static Country Data { get; } = new()
        {
            Id = 36,
            Name = "Burundi",
            Iso3 = "BDI",
            Iso2 = "BI",
            NumericCode = "108",
            PhoneCode = "257",
            Capital = "Bujumbura",
            Currency = "BIF",
            CurrencyName = "Burundian franc",
            CurrencySymbol = "FBu",
            Tld = ".bi",
            Native = "Burundi",
            Region = "Africa",
            RegionId = 1,
            Subregion = "Eastern Africa",
            SubregionId = 4,
            Nationality = "Burundian",
            Latitude = "-3.50000000",
            Longitude = "30.00000000",
            Emoji = "🇧🇮",
            EmojiU = "U+1F1E7 U+1F1EE",
            Timezones = new()
            {
                new() { ZoneName = "Africa/Bujumbura", GmtOffset = 7200, GmtOffsetName = "UTC+02:00", Abbreviation = "CAT", TzName = "Central Africa Time" }
            },
            Translations = new()
            {
                ["ko"] = "부룬디",
                ["pt-BR"] = "Burundi",
                ["pt"] = "Burúndi",
                ["nl"] = "Burundi",
                ["hr"] = "Burundi",
                ["fa"] = "بوروندی",
                ["de"] = "Burundi",
                ["es"] = "Burundi",
                ["fr"] = "Burundi",
                ["ja"] = "ブルンジ",
                ["it"] = "Burundi",
                ["zh-CN"] = "布隆迪",
                ["tr"] = "Burundi",
                ["ru"] = "Бурунди",
                ["uk"] = "Бурунді",
                ["pl"] = "Burundi"
            },
            States = new()
            {

                new()
                {
                    Id = 1,
                    Name = "Bubanza",
                    StateCode = "BB",
                    Latitude = "-3.15724030",
                    Longitude = "29.37149090",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Bubanza", Latitude = "-3.08040000", Longitude = "29.39100000" }
                    }
                },

                new()
                {
                    Id = 2,
                    Name = "Bujumbura Mairie",
                    StateCode = "BM",
                    Latitude = "-3.38841410",
                    Longitude = "29.34826460",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Bujumbura", Latitude = "-3.38193000", Longitude = "29.36142000" }
                    }
                },

                new()
                {
                    Id = 3,
                    Name = "Bujumbura Rural",
                    StateCode = "BL",
                    Latitude = "-3.50901440",
                    Longitude = "29.46435900",
                    Type = "province",
                    Cities = new()
                    {
                    }
                },

                new()
                {
                    Id = 4,
                    Name = "Bururi",
                    StateCode = "BR",
                    Latitude = "-3.90068510",
                    Longitude = "29.51077080",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Bururi", Latitude = "-3.94877000", Longitude = "29.62438000" }
                    }
                },

                new()
                {
                    Id = 5,
                    Name = "Cankuzo",
                    StateCode = "CA",
                    Latitude = "-3.15277880",
                    Longitude = "30.61998950",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Cankuzo", Latitude = "-3.21860000", Longitude = "30.55280000" }
                    }
                },

                new()
                {
                    Id = 6,
                    Name = "Cibitoke",
                    StateCode = "CI",
                    Latitude = "-2.81028970",
                    Longitude = "29.18557850",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Cibitoke", Latitude = "-2.88690000", Longitude = "29.12480000" }
                    }
                },

                new()
                {
                    Id = 7,
                    Name = "Gitega",
                    StateCode = "GI",
                    Latitude = "-3.49290510",
                    Longitude = "29.92779470",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Gitega", Latitude = "-3.42708000", Longitude = "29.92463000" }
                    }
                },

                new()
                {
                    Id = 8,
                    Name = "Karuzi",
                    StateCode = "KR",
                    Latitude = "-3.13403470",
                    Longitude = "30.11273500",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Karuzi", Latitude = "-3.10139000", Longitude = "30.16278000" }
                    }
                },

                new()
                {
                    Id = 9,
                    Name = "Kayanza",
                    StateCode = "KY",
                    Latitude = "-3.00779810",
                    Longitude = "29.64991620",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Kayanza", Latitude = "-2.92210000", Longitude = "29.62930000" }
                    }
                },

                new()
                {
                    Id = 10,
                    Name = "Kirundo",
                    StateCode = "KI",
                    Latitude = "-2.57628820",
                    Longitude = "30.11273500",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Kirundo", Latitude = "-2.58450000", Longitude = "30.09590000" }
                    }
                },

                new()
                {
                    Id = 11,
                    Name = "Makamba",
                    StateCode = "MA",
                    Latitude = "-4.32570620",
                    Longitude = "29.69626770",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Makamba", Latitude = "-4.13480000", Longitude = "29.80400000" }
                    }
                },

                new()
                {
                    Id = 12,
                    Name = "Muramvya",
                    StateCode = "MU",
                    Latitude = "-3.28983980",
                    Longitude = "29.64991620",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Muramvya", Latitude = "-3.26820000", Longitude = "29.60790000" }
                    }
                },

                new()
                {
                    Id = 13,
                    Name = "Muyinga",
                    StateCode = "MY",
                    Latitude = "-2.77935110",
                    Longitude = "30.29741990",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Muyinga", Latitude = "-2.84510000", Longitude = "30.34140000" }
                    }
                },

                new()
                {
                    Id = 14,
                    Name = "Mwaro",
                    StateCode = "MW",
                    Latitude = "-3.50259180",
                    Longitude = "29.64991620",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Mwaro", Latitude = "-3.51128000", Longitude = "29.70334000" }
                    }
                },

                new()
                {
                    Id = 15,
                    Name = "Ngozi",
                    StateCode = "NG",
                    Latitude = "-2.89582430",
                    Longitude = "29.88152030",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Ngozi", Latitude = "-2.90750000", Longitude = "29.83060000" }
                    }
                },

                new()
                {
                    Id = 16,
                    Name = "Rumonge",
                    StateCode = "RM",
                    Latitude = "-3.97540490",
                    Longitude = "29.43880140",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Rumonge", Latitude = "-3.97360000", Longitude = "29.43860000" }
                    }
                },

                new()
                {
                    Id = 17,
                    Name = "Rutana",
                    StateCode = "RT",
                    Latitude = "-3.87915230",
                    Longitude = "30.06652360",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Rutana", Latitude = "-3.92790000", Longitude = "29.99200000" }
                    }
                },

                new()
                {
                    Id = 18,
                    Name = "Ruyigi",
                    StateCode = "RY",
                    Latitude = "-3.44620700",
                    Longitude = "30.25127280",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Ruyigi", Latitude = "-3.47639000", Longitude = "30.24861000" }
                    }
                }
            }
        };
    }
}
