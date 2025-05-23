// ⚠️ WARNING: This file is automatically generated by scripts/generate-world.ps1
// DO NOT modify this file manually as it will be overwritten when the script is run again.
// To update the data, modify the source data in countries-states-cities-database and run the script.

using System.Collections.Generic;
using ShowsOnSale.World.Models;

namespace ShowsOnSale.World.Data.Countries
{
    public static class SanMarino
    {
        public static Country Data { get; } = new()
        {
            Id = 191,
            Name = "San Marino",
            Iso3 = "SMR",
            Iso2 = "SM",
            NumericCode = "674",
            PhoneCode = "378",
            Capital = "San Marino",
            Currency = "EUR",
            CurrencyName = "Euro",
            CurrencySymbol = "€",
            Tld = ".sm",
            Native = "San Marino",
            Region = "Europe",
            RegionId = 4,
            Subregion = "Southern Europe",
            SubregionId = 16,
            Nationality = "Sammarinese",
            Latitude = "43.76666666",
            Longitude = "12.41666666",
            Emoji = "🇸🇲",
            EmojiU = "U+1F1F8 U+1F1F2",
            Timezones = new()
            {
                new() { ZoneName = "Europe/San_Marino", GmtOffset = 3600, GmtOffsetName = "UTC+01:00", Abbreviation = "CET", TzName = "Central European Time" }
            },
            Translations = new()
            {
                ["ko"] = "산마리노",
                ["pt-BR"] = "San Marino",
                ["pt"] = "São Marinho",
                ["nl"] = "San Marino",
                ["hr"] = "San Marino",
                ["fa"] = "سان مارینو",
                ["de"] = "San Marino",
                ["es"] = "San Marino",
                ["fr"] = "Saint-Marin",
                ["ja"] = "サンマリノ",
                ["it"] = "San Marino",
                ["zh-CN"] = "圣马力诺",
                ["tr"] = "San Marino",
                ["ru"] = "Сан-Марино",
                ["uk"] = "Сан-Марино",
                ["pl"] = "San Marino"
            },
            States = new()
            {

                new()
                {
                    Id = 1,
                    Name = "Acquaviva",
                    StateCode = "01",
                    Latitude = "41.86715970",
                    Longitude = "14.74694790",
                    Type = "municipality",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Acquaviva", Latitude = "43.94593000", Longitude = "12.41850000" }
                    }
                },

                new()
                {
                    Id = 2,
                    Name = "Borgo Maggiore",
                    StateCode = "06",
                    Latitude = "43.95748820",
                    Longitude = "12.45525460",
                    Type = "municipality",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Borgo Maggiore", Latitude = "43.94193000", Longitude = "12.44738000" }
                    }
                },

                new()
                {
                    Id = 3,
                    Name = "Chiesanuova",
                    StateCode = "02",
                    Latitude = "45.42261720",
                    Longitude = "7.65038540",
                    Type = "municipality",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Poggio di Chiesanuova", Latitude = "43.90451000", Longitude = "12.42142000" }
                    }
                },

                new()
                {
                    Id = 4,
                    Name = "Domagnano",
                    StateCode = "03",
                    Latitude = "43.95019290",
                    Longitude = "12.46815370",
                    Type = "municipality",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Domagnano", Latitude = "43.94961000", Longitude = "12.46828000" }
                    }
                },

                new()
                {
                    Id = 5,
                    Name = "Faetano",
                    StateCode = "04",
                    Latitude = "43.93489670",
                    Longitude = "12.48965540",
                    Type = "municipality",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Faetano", Latitude = "43.92831000", Longitude = "12.49798000" }
                    }
                },

                new()
                {
                    Id = 6,
                    Name = "Fiorentino",
                    StateCode = "05",
                    Latitude = "43.90783370",
                    Longitude = "12.45812090",
                    Type = "municipality",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Fiorentino", Latitude = "43.91001000", Longitude = "12.45738000" }
                    }
                },

                new()
                {
                    Id = 7,
                    Name = "Montegiardino",
                    StateCode = "08",
                    Latitude = "43.90529990",
                    Longitude = "12.48105420",
                    Type = "municipality",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Monte Giardino", Latitude = "43.90878000", Longitude = "12.48201000" }
                    }
                },

                new()
                {
                    Id = 8,
                    Name = "San Marino",
                    StateCode = "07",
                    Latitude = "43.94236000",
                    Longitude = "12.45777700",
                    Type = "municipality",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "San Marino", Latitude = "43.93667000", Longitude = "12.44639000" }
                    }
                },

                new()
                {
                    Id = 9,
                    Name = "Serravalle",
                    StateCode = "09",
                    Latitude = "44.72320840",
                    Longitude = "8.85740050",
                    Type = "municipality",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Serravalle", Latitude = "43.96897000", Longitude = "12.48167000" }
                    }
                }
            }
        };
    }
}
