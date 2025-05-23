// ⚠️ WARNING: This file is automatically generated by scripts/generate-world.ps1
// DO NOT modify this file manually as it will be overwritten when the script is run again.
// To update the data, modify the source data in countries-states-cities-database and run the script.

using System.Collections.Generic;
using ShowsOnSale.World.Models;

namespace ShowsOnSale.World.Data.Countries
{
    public static class Ethiopia
    {
        public static Country Data { get; } = new()
        {
            Id = 71,
            Name = "Ethiopia",
            Iso3 = "ETH",
            Iso2 = "ET",
            NumericCode = "231",
            PhoneCode = "251",
            Capital = "Addis Ababa",
            Currency = "ETB",
            CurrencyName = "Ethiopian birr",
            CurrencySymbol = "Nkf",
            Tld = ".et",
            Native = "ኢትዮጵያ",
            Region = "Africa",
            RegionId = 1,
            Subregion = "Eastern Africa",
            SubregionId = 4,
            Nationality = "Ethiopian",
            Latitude = "8.00000000",
            Longitude = "38.00000000",
            Emoji = "🇪🇹",
            EmojiU = "U+1F1EA U+1F1F9",
            Timezones = new()
            {
                new() { ZoneName = "Africa/Addis_Ababa", GmtOffset = 10800, GmtOffsetName = "UTC+03:00", Abbreviation = "EAT", TzName = "East Africa Time" }
            },
            Translations = new()
            {
                ["ko"] = "에티오피아",
                ["pt-BR"] = "Etiópia",
                ["pt"] = "Etiópia",
                ["nl"] = "Ethiopië",
                ["hr"] = "Etiopija",
                ["fa"] = "اتیوپی",
                ["de"] = "Äthiopien",
                ["es"] = "Etiopía",
                ["fr"] = "Éthiopie",
                ["ja"] = "エチオピア",
                ["it"] = "Etiopia",
                ["zh-CN"] = "埃塞俄比亚",
                ["tr"] = "Etiyopya",
                ["ru"] = "Эфиопия",
                ["uk"] = "Ефіопія",
                ["pl"] = "Etiopia"
            },
            States = new()
            {

                new()
                {
                    Id = 1,
                    Name = "Addis Ababa",
                    StateCode = "AA",
                    Latitude = "8.98060340",
                    Longitude = "38.75776050",
                    Type = "administration",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Addis Ababa", Latitude = "9.02497000", Longitude = "38.74689000" }
                    }
                },

                new()
                {
                    Id = 2,
                    Name = "Afar",
                    StateCode = "AF",
                    Latitude = "11.75593880",
                    Longitude = "40.95868800",
                    Type = "region",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Administrative Zone 2", Latitude = "13.68513000", Longitude = "40.05615000" },
                        new() { Id = 2, Name = "Administrative Zone 3", Latitude = "10.00902000", Longitude = "40.47394000" },
                        new() { Id = 3, Name = "Asaita", Latitude = "11.56838000", Longitude = "41.43869000" },
                        new() { Id = 4, Name = "Āwash", Latitude = "8.98333000", Longitude = "40.16667000" },
                        new() { Id = 5, Name = "Dubti", Latitude = "11.73292000", Longitude = "41.08200000" },
                        new() { Id = 6, Name = "Gewanē", Latitude = "10.16658000", Longitude = "40.64689000" },
                        new() { Id = 7, Name = "Semera", Latitude = "11.79342000", Longitude = "41.00578000" }
                    }
                },

                new()
                {
                    Id = 3,
                    Name = "Amhara",
                    StateCode = "AM",
                    Latitude = "11.34942470",
                    Longitude = "37.97845850",
                    Type = "region",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Abomsa", Latitude = "9.98333000", Longitude = "39.98333000" },
                        new() { Id = 2, Name = "Addiet Canna", Latitude = "11.26667000", Longitude = "37.48333000" },
                        new() { Id = 3, Name = "Ādīs Zemen", Latitude = "12.11667000", Longitude = "37.78333000" },
                        new() { Id = 4, Name = "Bahir Dar", Latitude = "11.59364000", Longitude = "37.39077000" },
                        new() { Id = 5, Name = "Batī", Latitude = "11.19152000", Longitude = "40.01675000" },
                        new() { Id = 6, Name = "Bichena", Latitude = "10.45000000", Longitude = "38.20000000" },
                        new() { Id = 7, Name = "Burē", Latitude = "10.70000000", Longitude = "37.06667000" },
                        new() { Id = 8, Name = "Dabat", Latitude = "12.98417000", Longitude = "37.76500000" },
                        new() { Id = 9, Name = "Debark’", Latitude = "13.15611000", Longitude = "37.89806000" },
                        new() { Id = 10, Name = "Debre Birhan", Latitude = "9.67954000", Longitude = "39.53262000" },
                        new() { Id = 11, Name = "Debre Mark’os", Latitude = "10.35000000", Longitude = "37.73333000" },
                        new() { Id = 12, Name = "Debre Sīna", Latitude = "9.84752000", Longitude = "39.76027000" },
                        new() { Id = 13, Name = "Debre Tabor", Latitude = "11.85000000", Longitude = "38.01667000" },
                        new() { Id = 14, Name = "Debre Werk’", Latitude = "10.66667000", Longitude = "38.16667000" },
                        new() { Id = 15, Name = "Dejen", Latitude = "10.16667000", Longitude = "38.13333000" },
                        new() { Id = 16, Name = "Desē", Latitude = "11.13333000", Longitude = "39.63333000" },
                        new() { Id = 17, Name = "Finote Selam", Latitude = "10.70000000", Longitude = "37.26667000" },
                        new() { Id = 18, Name = "Gondar", Latitude = "12.60000000", Longitude = "37.46667000" },
                        new() { Id = 19, Name = "Kemisē", Latitude = "10.71668000", Longitude = "39.86997000" },
                        new() { Id = 20, Name = "Kombolcha", Latitude = "11.08155000", Longitude = "39.74339000" },
                        new() { Id = 21, Name = "Lalībela", Latitude = "12.03219000", Longitude = "39.04756000" },
                        new() { Id = 22, Name = "North Shewa Zone", Latitude = "9.76900000", Longitude = "39.66800000" },
                        new() { Id = 23, Name = "North Wollo Zone", Latitude = "11.92000000", Longitude = "39.10000000" },
                        new() { Id = 24, Name = "Robīt", Latitude = "12.01667000", Longitude = "39.63333000" },
                        new() { Id = 25, Name = "South Gondar Zone", Latitude = "11.83850000", Longitude = "38.09954000" },
                        new() { Id = 26, Name = "South Wollo Zone", Latitude = "11.00000000", Longitude = "39.25000000" },
                        new() { Id = 27, Name = "Wag Hemra Zone", Latitude = "12.76500000", Longitude = "38.84300000" },
                        new() { Id = 28, Name = "Were Īlu", Latitude = "10.58964000", Longitude = "39.43767000" },
                        new() { Id = 29, Name = "Werota", Latitude = "11.91667000", Longitude = "37.70000000" }
                    }
                },

                new()
                {
                    Id = 4,
                    Name = "Benishangul-Gumuz",
                    StateCode = "BE",
                    Latitude = "10.78028890",
                    Longitude = "35.56578620",
                    Type = "region",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Asosa", Latitude = "10.00000000", Longitude = "34.50000000" },
                        new() { Id = 2, Name = "Metekel", Latitude = "10.42673000", Longitude = "35.71975000" }
                    }
                },

                new()
                {
                    Id = 5,
                    Name = "Dire Dawa",
                    StateCode = "DD",
                    Latitude = "9.60087470",
                    Longitude = "41.85014200",
                    Type = "administration",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Dire Dawa", Latitude = "9.59306000", Longitude = "41.86611000" }
                    }
                },

                new()
                {
                    Id = 6,
                    Name = "Gambela",
                    StateCode = "GA",
                    Latitude = "7.92196870",
                    Longitude = "34.15319470",
                    Type = "region",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Administrative Zone 1", Latitude = "8.14699000", Longitude = "33.97335000" },
                        new() { Id = 2, Name = "Gambēla", Latitude = "8.25000000", Longitude = "34.58333000" }
                    }
                },

                new()
                {
                    Id = 7,
                    Name = "Harari",
                    StateCode = "HA",
                    Latitude = "9.31486600",
                    Longitude = "42.19677160",
                    Type = "region",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Harar", Latitude = "9.31387000", Longitude = "42.11815000" }
                    }
                },

                new()
                {
                    Id = 8,
                    Name = "Oromia",
                    StateCode = "OR",
                    Latitude = "7.54603770",
                    Longitude = "40.63468510",
                    Type = "region",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Ādīs ‘Alem", Latitude = "9.03333000", Longitude = "38.40000000" },
                        new() { Id = 2, Name = "Āgaro", Latitude = "7.85000000", Longitude = "36.65000000" },
                        new() { Id = 3, Name = "Arsi Zone", Latitude = "7.50000000", Longitude = "39.50000000" },
                        new() { Id = 4, Name = "Āsasa", Latitude = "7.10000000", Longitude = "39.20000000" },
                        new() { Id = 5, Name = "Āsbe Teferī", Latitude = "9.08569000", Longitude = "40.86708000" },
                        new() { Id = 6, Name = "Bedelē", Latitude = "8.45600000", Longitude = "36.35302000" },
                        new() { Id = 7, Name = "Bedēsa", Latitude = "8.90000000", Longitude = "40.78333000" },
                        new() { Id = 8, Name = "Bishoftu", Latitude = "8.75225000", Longitude = "38.97846000" },
                        new() { Id = 9, Name = "Deder", Latitude = "9.31168000", Longitude = "41.44301000" },
                        new() { Id = 10, Name = "Dembī Dolo", Latitude = "8.53333000", Longitude = "34.80000000" },
                        new() { Id = 11, Name = "Dodola", Latitude = "6.98333000", Longitude = "39.18333000" },
                        new() { Id = 12, Name = "East Harerghe Zone", Latitude = "8.70114000", Longitude = "42.00241000" },
                        new() { Id = 13, Name = "East Shewa Zone", Latitude = "8.21353000", Longitude = "38.84809000" },
                        new() { Id = 14, Name = "East Wellega Zone", Latitude = "9.51928000", Longitude = "36.75762000" },
                        new() { Id = 15, Name = "Fichē", Latitude = "9.80000000", Longitude = "38.73333000" },
                        new() { Id = 16, Name = "Gebre Guracha", Latitude = "9.80000000", Longitude = "38.40000000" },
                        new() { Id = 17, Name = "Gēdo", Latitude = "9.01667000", Longitude = "37.45000000" },
                        new() { Id = 18, Name = "Gelemso", Latitude = "8.81667000", Longitude = "40.51667000" },
                        new() { Id = 19, Name = "Genet", Latitude = "9.06667000", Longitude = "38.50000000" },
                        new() { Id = 20, Name = "Gimbi", Latitude = "9.17031000", Longitude = "35.83491000" },
                        new() { Id = 21, Name = "Ginir", Latitude = "7.13952000", Longitude = "40.71083000" },
                        new() { Id = 22, Name = "Goba", Latitude = "7.01667000", Longitude = "39.98333000" },
                        new() { Id = 23, Name = "Gorē", Latitude = "8.15000000", Longitude = "35.53333000" },
                        new() { Id = 24, Name = "Guji Zone", Latitude = "5.58800000", Longitude = "39.06700000" },
                        new() { Id = 25, Name = "Hāgere Hiywet", Latitude = "8.98333000", Longitude = "37.85000000" },
                        new() { Id = 26, Name = "Hagere Maryam", Latitude = "5.63418000", Longitude = "38.23603000" },
                        new() { Id = 27, Name = "Hīrna", Latitude = "9.21667000", Longitude = "41.10000000" },
                        new() { Id = 28, Name = "Huruta", Latitude = "8.15000000", Longitude = "39.35000000" },
                        new() { Id = 29, Name = "Illubabor Zone", Latitude = "8.27526000", Longitude = "35.75596000" },
                        new() { Id = 30, Name = "Jimma", Latitude = "7.67344000", Longitude = "36.83441000" },
                        new() { Id = 31, Name = "Jimma Zone", Latitude = "7.66667000", Longitude = "37.00000000" },
                        new() { Id = 32, Name = "Kibre Mengist", Latitude = "5.88333000", Longitude = "38.98333000" },
                        new() { Id = 33, Name = "Kofelē", Latitude = "7.06667000", Longitude = "38.78333000" },
                        new() { Id = 34, Name = "Mēga", Latitude = "4.05000000", Longitude = "38.30000000" },
                        new() { Id = 35, Name = "Mendī", Latitude = "9.80000000", Longitude = "35.10000000" },
                        new() { Id = 36, Name = "Metahāra", Latitude = "8.90000000", Longitude = "39.91667000" },
                        new() { Id = 37, Name = "Metu", Latitude = "8.30000000", Longitude = "35.58333000" },
                        new() { Id = 38, Name = "Mojo", Latitude = "8.58679000", Longitude = "39.12111000" },
                        new() { Id = 39, Name = "Nazrēt", Latitude = "8.55000000", Longitude = "39.26667000" },
                        new() { Id = 40, Name = "Nejo", Latitude = "9.50000000", Longitude = "35.50000000" },
                        new() { Id = 41, Name = "North Shewa Zone", Latitude = "9.66915000", Longitude = "38.81240000" },
                        new() { Id = 42, Name = "Sebeta", Latitude = "8.91667000", Longitude = "38.61667000" },
                        new() { Id = 43, Name = "Sendafa", Latitude = "9.15203000", Longitude = "39.02335000" },
                        new() { Id = 44, Name = "Shakiso", Latitude = "5.76494000", Longitude = "38.91006000" },
                        new() { Id = 45, Name = "Shambu", Latitude = "9.56667000", Longitude = "37.10000000" },
                        new() { Id = 46, Name = "Shashemenē", Latitude = "7.20000000", Longitude = "38.60000000" },
                        new() { Id = 47, Name = "Sirre", Latitude = "8.31667000", Longitude = "39.48333000" },
                        new() { Id = 48, Name = "Tulu Bolo", Latitude = "8.66667000", Longitude = "38.21667000" },
                        new() { Id = 49, Name = "Waliso", Latitude = "8.53417000", Longitude = "37.96515000" },
                        new() { Id = 50, Name = "Wenjī", Latitude = "8.45000000", Longitude = "39.28333000" },
                        new() { Id = 51, Name = "West Harerghe Zone", Latitude = "8.67245000", Longitude = "40.84885000" },
                        new() { Id = 52, Name = "West Wellega Zone", Latitude = "9.17283000", Longitude = "35.05279000" },
                        new() { Id = 53, Name = "Yabēlo", Latitude = "4.88333000", Longitude = "38.08333000" },
                        new() { Id = 54, Name = "Ziway", Latitude = "7.93333000", Longitude = "38.71667000" }
                    }
                },

                new()
                {
                    Id = 9,
                    Name = "Somali",
                    StateCode = "SO",
                    Latitude = "6.66122930",
                    Longitude = "43.79084530",
                    Type = "region",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Afder Zone", Latitude = "5.25000000", Longitude = "43.00000000" },
                        new() { Id = 2, Name = "Degehabur Zone", Latitude = "8.25000000", Longitude = "43.75000000" },
                        new() { Id = 3, Name = "Gode Zone", Latitude = "6.00000000", Longitude = "43.75000000" },
                        new() { Id = 4, Name = "Jijiga", Latitude = "9.35000000", Longitude = "42.80000000" },
                        new() { Id = 5, Name = "Liben zone", Latitude = "4.75000000", Longitude = "40.50000000" },
                        new() { Id = 6, Name = "Shinile Zone", Latitude = "10.17097000", Longitude = "41.83748000" }
                    }
                },

                new()
                {
                    Id = 10,
                    Name = "Southern Nations, Nationalities, and Peoples'",
                    StateCode = "SN",
                    Latitude = "6.51569110",
                    Longitude = "36.95410700",
                    Type = "region",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Alaba Special Wereda", Latitude = "7.45347000", Longitude = "38.21189000" },
                        new() { Id = 2, Name = "Arba Minch", Latitude = "6.03333000", Longitude = "37.55000000" },
                        new() { Id = 3, Name = "Āreka", Latitude = "7.06667000", Longitude = "37.70000000" },
                        new() { Id = 4, Name = "Bako", Latitude = "5.78333000", Longitude = "36.56667000" },
                        new() { Id = 5, Name = "Bench Maji Zone", Latitude = "6.45994000", Longitude = "35.30549000" },
                        new() { Id = 6, Name = "Bodītī", Latitude = "6.96667000", Longitude = "37.86667000" },
                        new() { Id = 7, Name = "Bonga", Latitude = "7.28333000", Longitude = "36.23333000" },
                        new() { Id = 8, Name = "Butajīra", Latitude = "8.11667000", Longitude = "38.36667000" },
                        new() { Id = 9, Name = "Dīla", Latitude = "6.41667000", Longitude = "38.31667000" },
                        new() { Id = 10, Name = "Felege Neway", Latitude = "6.30000000", Longitude = "36.88333000" },
                        new() { Id = 11, Name = "Gedeo Zone", Latitude = "6.12727000", Longitude = "38.27716000" },
                        new() { Id = 12, Name = "Gīdolē", Latitude = "5.65000000", Longitude = "37.36667000" },
                        new() { Id = 13, Name = "Guraghe Zone", Latitude = "8.25000000", Longitude = "38.00000000" },
                        new() { Id = 14, Name = "Hadiya Zone", Latitude = "7.50000000", Longitude = "37.75000000" },
                        new() { Id = 15, Name = "Hāgere Selam", Latitude = "6.48333000", Longitude = "38.51667000" },
                        new() { Id = 16, Name = "Hawassa", Latitude = "7.06205000", Longitude = "38.47635000" },
                        new() { Id = 17, Name = "Hosa’ina", Latitude = "7.54978000", Longitude = "37.85374000" },
                        new() { Id = 18, Name = "Jinka", Latitude = "5.65000000", Longitude = "36.65000000" },
                        new() { Id = 19, Name = "K’olīto", Latitude = "7.31667000", Longitude = "38.08333000" },
                        new() { Id = 20, Name = "Kembata Alaba Tembaro Zone", Latitude = "7.27039000", Longitude = "37.77887000" },
                        new() { Id = 21, Name = "Konso", Latitude = "5.25000000", Longitude = "37.48333000" },
                        new() { Id = 22, Name = "Leku", Latitude = "6.87309000", Longitude = "38.44425000" },
                        new() { Id = 23, Name = "Lobuni", Latitude = "4.83333000", Longitude = "36.10000000" },
                        new() { Id = 24, Name = "Mīzan Teferī", Latitude = "6.99865000", Longitude = "35.58879000" },
                        new() { Id = 25, Name = "Sheka Zone", Latitude = "7.56166000", Longitude = "35.40174000" },
                        new() { Id = 26, Name = "Sidama Zone", Latitude = "6.71800000", Longitude = "38.44800000" },
                        new() { Id = 27, Name = "Sodo", Latitude = "6.86000000", Longitude = "37.76159000" },
                        new() { Id = 28, Name = "Tippi", Latitude = "7.20000000", Longitude = "35.45000000" },
                        new() { Id = 29, Name = "Turmi", Latitude = "4.96667000", Longitude = "36.48333000" },
                        new() { Id = 30, Name = "Wendo", Latitude = "6.60000000", Longitude = "38.41667000" },
                        new() { Id = 31, Name = "Wolayita Zone", Latitude = "6.84312000", Longitude = "37.70051000" },
                        new() { Id = 32, Name = "Yem", Latitude = "7.83333000", Longitude = "37.50000000" },
                        new() { Id = 33, Name = "Yirga ‘Alem", Latitude = "6.75000000", Longitude = "38.41667000" }
                    }
                },

                new()
                {
                    Id = 11,
                    Name = "Tigray",
                    StateCode = "TI",
                    Latitude = "14.03233360",
                    Longitude = "38.31657250",
                    Type = "region",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Ādīgrat", Latitude = "14.27700000", Longitude = "39.46200000" },
                        new() { Id = 2, Name = "Axum", Latitude = "14.12109000", Longitude = "38.72337000" },
                        new() { Id = 3, Name = "Inda Silasē", Latitude = "14.10307000", Longitude = "38.28289000" },
                        new() { Id = 4, Name = "Korem", Latitude = "12.50583000", Longitude = "39.52278000" },
                        new() { Id = 5, Name = "Maych’ew", Latitude = "12.78750000", Longitude = "39.54222000" },
                        new() { Id = 6, Name = "Mek'ele", Latitude = "13.49667000", Longitude = "39.47528000" },
                        new() { Id = 7, Name = "Southeastern Tigray Zone", Latitude = "13.24797000", Longitude = "39.53156000" },
                        new() { Id = 8, Name = "Southern Tigray Zone", Latitude = "12.96033000", Longitude = "39.52831000" }
                    }
                }
            }
        };
    }
}
