// ⚠️ WARNING: This file is automatically generated by scripts/generate-world.ps1
// DO NOT modify this file manually as it will be overwritten when the script is run again.
// To update the data, modify the source data in countries-states-cities-database and run the script.

using System.Collections.Generic;
using ShowsOnSale.World.Models;

namespace ShowsOnSale.World.Data.Countries
{
    public static class Montenegro
    {
        public static Country Data { get; } = new()
        {
            Id = 145,
            Name = "Montenegro",
            Iso3 = "MNE",
            Iso2 = "ME",
            NumericCode = "499",
            PhoneCode = "382",
            Capital = "Podgorica",
            Currency = "EUR",
            CurrencyName = "Euro",
            CurrencySymbol = "€",
            Tld = ".me",
            Native = "Црна Гора",
            Region = "Europe",
            RegionId = 4,
            Subregion = "Southern Europe",
            SubregionId = 16,
            Nationality = "Montenegrin",
            Latitude = "42.50000000",
            Longitude = "19.30000000",
            Emoji = "🇲🇪",
            EmojiU = "U+1F1F2 U+1F1EA",
            Timezones = new()
            {
                new() { ZoneName = "Europe/Podgorica", GmtOffset = 3600, GmtOffsetName = "UTC+01:00", Abbreviation = "CET", TzName = "Central European Time" }
            },
            Translations = new()
            {
                ["ko"] = "몬테네그로",
                ["pt-BR"] = "Montenegro",
                ["pt"] = "Montenegro",
                ["nl"] = "Montenegro",
                ["hr"] = "Crna Gora",
                ["fa"] = "مونته‌نگرو",
                ["de"] = "Montenegro",
                ["es"] = "Montenegro",
                ["fr"] = "Monténégro",
                ["ja"] = "モンテネグロ",
                ["it"] = "Montenegro",
                ["zh-CN"] = "黑山",
                ["tr"] = "Karadağ",
                ["ru"] = "Черногория",
                ["uk"] = "Чорногорія",
                ["pl"] = "Czarnogóra"
            },
            States = new()
            {

                new()
                {
                    Id = 1,
                    Name = "Andrijevica",
                    StateCode = "01",
                    Latitude = "42.73624770",
                    Longitude = "19.78595560",
                    Type = "municipality",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Andrijevica", Latitude = "42.73389000", Longitude = "19.79194000" }
                    }
                },

                new()
                {
                    Id = 2,
                    Name = "Bar",
                    StateCode = "02",
                    Latitude = "42.12781190",
                    Longitude = "19.14043800",
                    Type = "municipality",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Bar", Latitude = "42.09306000", Longitude = "19.10028000" },
                        new() { Id = 2, Name = "Stari Bar", Latitude = "42.09700000", Longitude = "19.13600000" },
                        new() { Id = 3, Name = "Šušanj", Latitude = "42.11556000", Longitude = "19.08833000" },
                        new() { Id = 4, Name = "Sutomore", Latitude = "42.14278000", Longitude = "19.04667000" }
                    }
                },

                new()
                {
                    Id = 3,
                    Name = "Berane",
                    StateCode = "03",
                    Latitude = "42.82572890",
                    Longitude = "19.90205090",
                    Type = "municipality",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Berane", Latitude = "42.84250000", Longitude = "19.87333000" }
                    }
                },

                new()
                {
                    Id = 4,
                    Name = "Bijelo Polje",
                    StateCode = "04",
                    Latitude = "43.08465260",
                    Longitude = "19.71154720",
                    Type = "municipality",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Bijelo Polje", Latitude = "43.03834000", Longitude = "19.74758000" }
                    }
                },

                new()
                {
                    Id = 5,
                    Name = "Budva",
                    StateCode = "05",
                    Latitude = "42.31407200",
                    Longitude = "18.83138320",
                    Type = "municipality",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Budva", Latitude = "42.28639000", Longitude = "18.84000000" },
                        new() { Id = 2, Name = "Petrovac na Moru", Latitude = "42.20556000", Longitude = "18.94250000" }
                    }
                },

                new()
                {
                    Id = 6,
                    Name = "Danilovgrad",
                    StateCode = "07",
                    Latitude = "42.58357000",
                    Longitude = "19.14043800",
                    Type = "municipality",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Danilovgrad", Latitude = "42.55384000", Longitude = "19.14608000" },
                        new() { Id = 2, Name = "Spuž", Latitude = "42.51500000", Longitude = "19.19500000" }
                    }
                },

                new()
                {
                    Id = 7,
                    Name = "Gusinje",
                    StateCode = "22",
                    Latitude = "42.55634550",
                    Longitude = "19.83060510",
                    Type = "municipality",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Gusinje", Latitude = "42.56194000", Longitude = "19.83389000" }
                    }
                },

                new()
                {
                    Id = 8,
                    Name = "Kolašin",
                    StateCode = "09",
                    Latitude = "42.76019160",
                    Longitude = "19.42591140",
                    Type = "municipality",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Kolašin", Latitude = "42.82229000", Longitude = "19.51653000" }
                    }
                },

                new()
                {
                    Id = 9,
                    Name = "Kotor",
                    StateCode = "10",
                    Latitude = "42.57402610",
                    Longitude = "18.64131450",
                    Type = "municipality",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Dobrota", Latitude = "42.45417000", Longitude = "18.76833000" },
                        new() { Id = 2, Name = "Kotor", Latitude = "42.42067000", Longitude = "18.76825000" },
                        new() { Id = 3, Name = "Prčanj", Latitude = "42.45750000", Longitude = "18.74222000" },
                        new() { Id = 4, Name = "Risan", Latitude = "42.51500000", Longitude = "18.69556000" }
                    }
                },

                new()
                {
                    Id = 10,
                    Name = "Mojkovac",
                    StateCode = "11",
                    Latitude = "42.96880180",
                    Longitude = "19.52110630",
                    Type = "municipality",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Mojkovac", Latitude = "42.96044000", Longitude = "19.58330000" }
                    }
                },

                new()
                {
                    Id = 11,
                    Name = "Nikšić",
                    StateCode = "12",
                    Latitude = "42.79971840",
                    Longitude = "18.76009630",
                    Type = "municipality",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Nikšić", Latitude = "42.77310000", Longitude = "18.94446000" }
                    }
                },

                new()
                {
                    Id = 12,
                    Name = "Old Royal Capital Cetinje",
                    StateCode = "06",
                    Latitude = "42.39309590",
                    Longitude = "18.91159640",
                    Type = "municipality",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Cetinje", Latitude = "42.39063000", Longitude = "18.91417000" }
                    }
                },

                new()
                {
                    Id = 13,
                    Name = "Petnjica",
                    StateCode = "23",
                    Latitude = "42.93534800",
                    Longitude = "20.02114490",
                    Type = "municipality",
                    Cities = new()
                    {
                    }
                },

                new()
                {
                    Id = 14,
                    Name = "Plav",
                    StateCode = "13",
                    Latitude = "42.60013370",
                    Longitude = "19.94075410",
                    Type = "municipality",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Plav", Latitude = "42.59694000", Longitude = "19.94556000" }
                    }
                },

                new()
                {
                    Id = 15,
                    Name = "Pljevlja",
                    StateCode = "14",
                    Latitude = "43.27233830",
                    Longitude = "19.28315310",
                    Type = "municipality",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Pljevlja", Latitude = "43.35670000", Longitude = "19.35843000" }
                    }
                },

                new()
                {
                    Id = 16,
                    Name = "Plužine",
                    StateCode = "15",
                    Latitude = "43.15933840",
                    Longitude = "18.85514840",
                    Type = "municipality",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Plužine", Latitude = "43.15278000", Longitude = "18.83944000" }
                    }
                },

                new()
                {
                    Id = 17,
                    Name = "Podgorica",
                    StateCode = "16",
                    Latitude = "42.36938340",
                    Longitude = "19.28315310",
                    Type = "municipality",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Golubovci", Latitude = "42.33500000", Longitude = "19.23111000" },
                        new() { Id = 2, Name = "Goričani", Latitude = "42.33222000", Longitude = "19.21194000" },
                        new() { Id = 3, Name = "Mataguži", Latitude = "42.32361000", Longitude = "19.27278000" },
                        new() { Id = 4, Name = "Mojanovići", Latitude = "42.34167000", Longitude = "19.22139000" },
                        new() { Id = 5, Name = "Podgorica", Latitude = "42.44111000", Longitude = "19.26361000" },
                        new() { Id = 6, Name = "Tuzi", Latitude = "42.36556000", Longitude = "19.33139000" }
                    }
                },

                new()
                {
                    Id = 18,
                    Name = "Rožaje",
                    StateCode = "17",
                    Latitude = "42.84083890",
                    Longitude = "20.16706280",
                    Type = "municipality",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Rožaje", Latitude = "42.83299000", Longitude = "20.16652000" }
                    }
                },

                new()
                {
                    Id = 19,
                    Name = "Šavnik",
                    StateCode = "18",
                    Latitude = "42.96037560",
                    Longitude = "19.14043800",
                    Type = "municipality",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Šavnik", Latitude = "42.95639000", Longitude = "19.09667000" }
                    }
                },

                new()
                {
                    Id = 20,
                    Name = "Tivat",
                    StateCode = "19",
                    Latitude = "42.42348000",
                    Longitude = "18.71851840",
                    Type = "municipality",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Tivat", Latitude = "42.43639000", Longitude = "18.69611000" }
                    }
                },

                new()
                {
                    Id = 21,
                    Name = "Ulcinj",
                    StateCode = "20",
                    Latitude = "41.96527950",
                    Longitude = "19.30694320",
                    Type = "municipality",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Ulcinj", Latitude = "41.92936000", Longitude = "19.22436000" }
                    }
                },

                new()
                {
                    Id = 22,
                    Name = "Žabljak",
                    StateCode = "21",
                    Latitude = "43.15551520",
                    Longitude = "19.12260180",
                    Type = "municipality",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Žabljak", Latitude = "43.15423000", Longitude = "19.12325000" }
                    }
                }
            }
        };
    }
}
