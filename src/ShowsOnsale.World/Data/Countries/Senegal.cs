// ⚠️ WARNING: This file is automatically generated by scripts/generate-world.ps1
// DO NOT modify this file manually as it will be overwritten when the script is run again.
// To update the data, modify the source data in countries-states-cities-database and run the script.

using System.Collections.Generic;
using ShowsOnSale.World.Models;

namespace ShowsOnSale.World.Data.Countries
{
    public static class Senegal
    {
        public static Country Data { get; } = new()
        {
            Id = 194,
            Name = "Senegal",
            Iso3 = "SEN",
            Iso2 = "SN",
            NumericCode = "686",
            PhoneCode = "221",
            Capital = "Dakar",
            Currency = "XOF",
            CurrencyName = "West African CFA franc",
            CurrencySymbol = "CFA",
            Tld = ".sn",
            Native = "Sénégal",
            Region = "Africa",
            RegionId = 1,
            Subregion = "Western Africa",
            SubregionId = 3,
            Nationality = "Senegalese",
            Latitude = "14.00000000",
            Longitude = "-14.00000000",
            Emoji = "🇸🇳",
            EmojiU = "U+1F1F8 U+1F1F3",
            Timezones = new()
            {
                new() { ZoneName = "Africa/Dakar", GmtOffset = 0, GmtOffsetName = "UTC±00", Abbreviation = "GMT", TzName = "Greenwich Mean Time" }
            },
            Translations = new()
            {
                ["ko"] = "세네갈",
                ["pt-BR"] = "Senegal",
                ["pt"] = "Senegal",
                ["nl"] = "Senegal",
                ["hr"] = "Senegal",
                ["fa"] = "سنگال",
                ["de"] = "Senegal",
                ["es"] = "Senegal",
                ["fr"] = "Sénégal",
                ["ja"] = "セネガル",
                ["it"] = "Senegal",
                ["zh-CN"] = "塞内加尔",
                ["tr"] = "Senegal",
                ["ru"] = "Сенегал",
                ["uk"] = "Сенегал",
                ["pl"] = "Senegal"
            },
            States = new()
            {

                new()
                {
                    Id = 1,
                    Name = "Dakar",
                    StateCode = "DK",
                    Latitude = "14.71667700",
                    Longitude = "-17.46768610",
                    Type = "region",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Dakar", Latitude = "14.69370000", Longitude = "-17.44406000" },
                        new() { Id = 2, Name = "Dakar Department", Latitude = "14.71403000", Longitude = "-17.45534000" },
                        new() { Id = 3, Name = "Guédiawaye Department", Latitude = "14.77610000", Longitude = "-17.39560000" },
                        new() { Id = 4, Name = "Mermoz Boabab", Latitude = "14.70649000", Longitude = "-17.47581000" },
                        new() { Id = 5, Name = "N’diareme limamoulaye", Latitude = "14.78148000", Longitude = "-17.38410000" },
                        new() { Id = 6, Name = "Pikine", Latitude = "14.76457000", Longitude = "-17.39071000" },
                        new() { Id = 7, Name = "Pikine Department", Latitude = "14.76515000", Longitude = "-17.35198000" },
                        new() { Id = 8, Name = "Rufisque Department", Latitude = "14.74339000", Longitude = "-17.19841000" }
                    }
                },

                new()
                {
                    Id = 2,
                    Name = "Diourbel Region",
                    StateCode = "DB",
                    Latitude = "14.72830850",
                    Longitude = "-16.25221430",
                    Type = "region",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Mbacké", Latitude = "14.80828000", Longitude = "-15.86454000" },
                        new() { Id = 2, Name = "Mbaké", Latitude = "14.79032000", Longitude = "-15.90803000" },
                        new() { Id = 3, Name = "Tiébo", Latitude = "14.63333000", Longitude = "-16.23333000" },
                        new() { Id = 4, Name = "Touba", Latitude = "14.85000000", Longitude = "-15.88333000" }
                    }
                },

                new()
                {
                    Id = 3,
                    Name = "Fatick",
                    StateCode = "FK",
                    Latitude = "14.33901670",
                    Longitude = "-16.41114250",
                    Type = "region",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Diofior", Latitude = "14.18333000", Longitude = "-16.66667000" },
                        new() { Id = 2, Name = "Fatick Department", Latitude = "14.25909000", Longitude = "-16.49884000" },
                        new() { Id = 3, Name = "Foundiougne", Latitude = "14.13333000", Longitude = "-16.46667000" },
                        new() { Id = 4, Name = "Guinguinéo", Latitude = "14.26667000", Longitude = "-15.95000000" },
                        new() { Id = 5, Name = "Passi", Latitude = "13.98333000", Longitude = "-16.26667000" },
                        new() { Id = 6, Name = "Pourham", Latitude = "14.35000000", Longitude = "-16.41667000" },
                        new() { Id = 7, Name = "Sokone", Latitude = "13.88333000", Longitude = "-16.36667000" }
                    }
                },

                new()
                {
                    Id = 4,
                    Name = "Kaffrine",
                    StateCode = "KA",
                    Latitude = "14.10520200",
                    Longitude = "-15.54157550",
                    Type = "region",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Kaffrine", Latitude = "14.10594000", Longitude = "-15.55080000" },
                        new() { Id = 2, Name = "Koungheul", Latitude = "13.98333000", Longitude = "-14.80000000" }
                    }
                },

                new()
                {
                    Id = 5,
                    Name = "Kaolack",
                    StateCode = "KL",
                    Latitude = "14.16520830",
                    Longitude = "-16.07577490",
                    Type = "region",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Gandiaye", Latitude = "14.23333000", Longitude = "-16.26667000" },
                        new() { Id = 2, Name = "Kaolack", Latitude = "14.15197000", Longitude = "-16.07259000" },
                        new() { Id = 3, Name = "Ndofane", Latitude = "13.91667000", Longitude = "-15.93333000" },
                        new() { Id = 4, Name = "Nioro du Rip", Latitude = "13.75000000", Longitude = "-15.80000000" }
                    }
                },

                new()
                {
                    Id = 6,
                    Name = "Kédougou",
                    StateCode = "KE",
                    Latitude = "12.56046070",
                    Longitude = "-12.17470770",
                    Type = "region",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Département de Salémata", Latitude = "12.59971000", Longitude = "-12.77619000" },
                        new() { Id = 2, Name = "Kédougou", Latitude = "12.55561000", Longitude = "-12.18076000" },
                        new() { Id = 3, Name = "Kédougou Department", Latitude = "12.81716000", Longitude = "-12.17834000" },
                        new() { Id = 4, Name = "Saraya", Latitude = "13.00150000", Longitude = "-11.79627000" }
                    }
                },

                new()
                {
                    Id = 7,
                    Name = "Kolda",
                    StateCode = "KD",
                    Latitude = "12.91074950",
                    Longitude = "-14.95056710",
                    Type = "region",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Kolda", Latitude = "12.89390000", Longitude = "-14.94125000" },
                        new() { Id = 2, Name = "Kolda Department", Latitude = "12.88300000", Longitude = "-14.95000000" },
                        new() { Id = 3, Name = "Marsassoum", Latitude = "12.82750000", Longitude = "-15.98056000" },
                        new() { Id = 4, Name = "Vélingara", Latitude = "13.15000000", Longitude = "-14.11667000" }
                    }
                },

                new()
                {
                    Id = 8,
                    Name = "Louga",
                    StateCode = "LG",
                    Latitude = "15.61417680",
                    Longitude = "-16.22868000",
                    Type = "region",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Dara", Latitude = "15.34844000", Longitude = "-15.47993000" },
                        new() { Id = 2, Name = "Guéoul", Latitude = "15.48333000", Longitude = "-16.35000000" },
                        new() { Id = 3, Name = "Linguere Department", Latitude = "15.35900000", Longitude = "-15.15800000" },
                        new() { Id = 4, Name = "Louga", Latitude = "15.61867000", Longitude = "-16.22436000" },
                        new() { Id = 5, Name = "Ndibène Dahra", Latitude = "15.33380000", Longitude = "-15.47660000" }
                    }
                },

                new()
                {
                    Id = 9,
                    Name = "Matam",
                    StateCode = "MT",
                    Latitude = "15.66002250",
                    Longitude = "-13.25769060",
                    Type = "region",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Diawara", Latitude = "15.02196000", Longitude = "-12.54374000" },
                        new() { Id = 2, Name = "Kanel", Latitude = "15.49160000", Longitude = "-13.17627000" },
                        new() { Id = 3, Name = "Matam", Latitude = "15.65587000", Longitude = "-13.25544000" },
                        new() { Id = 4, Name = "Matam Department", Latitude = "15.73191000", Longitude = "-13.63393000" },
                        new() { Id = 5, Name = "Ouro Sogui", Latitude = "15.60588000", Longitude = "-13.32230000" },
                        new() { Id = 6, Name = "Ranérou", Latitude = "15.30000000", Longitude = "-13.96667000" },
                        new() { Id = 7, Name = "Sémé", Latitude = "15.19422000", Longitude = "-12.94482000" },
                        new() { Id = 8, Name = "Waoundé", Latitude = "15.26367000", Longitude = "-12.86821000" }
                    }
                },

                new()
                {
                    Id = 10,
                    Name = "Saint-Louis",
                    StateCode = "SL",
                    Latitude = "38.62700250",
                    Longitude = "-90.19940420",
                    Type = "region",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Goléré", Latitude = "16.25575000", Longitude = "-14.10165000" },
                        new() { Id = 2, Name = "Ndioum", Latitude = "16.51293000", Longitude = "-14.64706000" },
                        new() { Id = 3, Name = "Polel Diaoubé", Latitude = "15.26667000", Longitude = "-13.00000000" },
                        new() { Id = 4, Name = "Richard-Toll", Latitude = "16.46250000", Longitude = "-15.70083000" },
                        new() { Id = 5, Name = "Rosso", Latitude = "16.42028000", Longitude = "-15.79834000" },
                        new() { Id = 6, Name = "Saint-Louis", Latitude = "16.01793000", Longitude = "-16.48962000" }
                    }
                },

                new()
                {
                    Id = 11,
                    Name = "Sédhiou",
                    StateCode = "SE",
                    Latitude = "12.70460400",
                    Longitude = "-15.55623040",
                    Type = "region",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Goudomp Department", Latitude = "12.57778000", Longitude = "-15.87222000" },
                        new() { Id = 2, Name = "Sédhiou", Latitude = "12.70806000", Longitude = "-15.55694000" }
                    }
                },

                new()
                {
                    Id = 12,
                    Name = "Tambacounda Region",
                    StateCode = "TC",
                    Latitude = "13.56190110",
                    Longitude = "-13.17403480",
                    Type = "region",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Tambacounda", Latitude = "13.77073000", Longitude = "-13.66734000" },
                        new() { Id = 2, Name = "Tambacounda Department", Latitude = "13.60500000", Longitude = "-13.64700000" }
                    }
                },

                new()
                {
                    Id = 13,
                    Name = "Thiès Region",
                    StateCode = "TH",
                    Latitude = "14.79100520",
                    Longitude = "-16.93586040",
                    Type = "region",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Joal-Fadiout", Latitude = "14.16667000", Longitude = "-16.83333000" },
                        new() { Id = 2, Name = "Kayar", Latitude = "14.91893000", Longitude = "-17.11978000" },
                        new() { Id = 3, Name = "Khombole", Latitude = "14.76667000", Longitude = "-16.70000000" },
                        new() { Id = 4, Name = "Mbour", Latitude = "14.40569000", Longitude = "-16.85559000" },
                        new() { Id = 5, Name = "Mékhé", Latitude = "15.10970000", Longitude = "-16.62180000" },
                        new() { Id = 6, Name = "Nguékhokh", Latitude = "14.51255000", Longitude = "-17.00447000" },
                        new() { Id = 7, Name = "Pout", Latitude = "14.77099000", Longitude = "-17.06107000" },
                        new() { Id = 8, Name = "Thiès", Latitude = "14.73004000", Longitude = "-16.86974000" },
                        new() { Id = 9, Name = "Thiès Nones", Latitude = "14.78333000", Longitude = "-16.96667000" },
                        new() { Id = 10, Name = "Tiadiaye", Latitude = "14.41667000", Longitude = "-16.70000000" },
                        new() { Id = 11, Name = "Tivaouane", Latitude = "15.08519000", Longitude = "-16.71058000" },
                        new() { Id = 12, Name = "Warang", Latitude = "14.37349000", Longitude = "-16.94366000" }
                    }
                },

                new()
                {
                    Id = 14,
                    Name = "Ziguinchor",
                    StateCode = "ZG",
                    Latitude = "12.56414790",
                    Longitude = "-16.26398250",
                    Type = "region",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Adéane", Latitude = "12.63000000", Longitude = "-16.01694000" },
                        new() { Id = 2, Name = "Bignona", Latitude = "12.81028000", Longitude = "-16.22639000" },
                        new() { Id = 3, Name = "Oussouye", Latitude = "12.48500000", Longitude = "-16.54694000" },
                        new() { Id = 4, Name = "Tionk Essil", Latitude = "12.78556000", Longitude = "-16.52167000" },
                        new() { Id = 5, Name = "Ziguinchor", Latitude = "12.56801000", Longitude = "-16.27326000" }
                    }
                }
            }
        };
    }
}
