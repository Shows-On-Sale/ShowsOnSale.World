// ⚠️ WARNING: This file is automatically generated by scripts/generate-world.ps1
// DO NOT modify this file manually as it will be overwritten when the script is run again.
// To update the data, modify the source data in countries-states-cities-database and run the script.

using System.Collections.Generic;
using ShowsOnSale.World.Models;

namespace ShowsOnSale.World.Data.Countries
{
    public static class Tonga
    {
        public static Country Data { get; } = new()
        {
            Id = 225,
            Name = "Tonga",
            Iso3 = "TON",
            Iso2 = "TO",
            NumericCode = "776",
            PhoneCode = "676",
            Capital = "Nuku'alofa",
            Currency = "TOP",
            CurrencyName = "Tongan paʻanga",
            CurrencySymbol = "$",
            Tld = ".to",
            Native = "Tonga",
            Region = "Oceania",
            RegionId = 5,
            Subregion = "Polynesia",
            SubregionId = 22,
            Nationality = "Tongan",
            Latitude = "-20.00000000",
            Longitude = "-175.00000000",
            Emoji = "🇹🇴",
            EmojiU = "U+1F1F9 U+1F1F4",
            Timezones = new()
            {
                new() { ZoneName = "Pacific/Tongatapu", GmtOffset = 46800, GmtOffsetName = "UTC+13:00", Abbreviation = "TOT", TzName = "Tonga Time" }
            },
            Translations = new()
            {
                ["ko"] = "통가",
                ["pt-BR"] = "Tonga",
                ["pt"] = "Tonga",
                ["nl"] = "Tonga",
                ["hr"] = "Tonga",
                ["fa"] = "تونگا",
                ["de"] = "Tonga",
                ["es"] = "Tonga",
                ["fr"] = "Tonga",
                ["ja"] = "トンガ",
                ["it"] = "Tonga",
                ["zh-CN"] = "汤加",
                ["tr"] = "Tonga",
                ["ru"] = "Тонга",
                ["uk"] = "Тонга",
                ["pl"] = "Tonga"
            },
            States = new()
            {

                new()
                {
                    Id = 1,
                    Name = "Haʻapai",
                    StateCode = "02",
                    Latitude = "-19.75000000",
                    Longitude = "-174.36666700",
                    Type = "division",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Pangai", Latitude = "-19.81468000", Longitude = "-174.35423000" }
                    }
                },

                new()
                {
                    Id = 2,
                    Name = "ʻEua",
                    StateCode = "01",
                    Latitude = "37.09024000",
                    Longitude = "-95.71289100",
                    Type = "division",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "‘Ohonua", Latitude = "-21.33333000", Longitude = "-174.95000000" }
                    }
                },

                new()
                {
                    Id = 3,
                    Name = "Niuas",
                    StateCode = "03",
                    Latitude = "-15.95940000",
                    Longitude = "-173.78300000",
                    Type = "division",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Hihifo", Latitude = "-15.95440000", Longitude = "-173.79616000" }
                    }
                },

                new()
                {
                    Id = 4,
                    Name = "Tongatapu",
                    StateCode = "04",
                    Latitude = "-21.14659680",
                    Longitude = "-175.25154820",
                    Type = "division",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Haveluloto", Latitude = "-21.15216000", Longitude = "-175.21333000" },
                        new() { Id = 2, Name = "Kolonga", Latitude = "-21.13333000", Longitude = "-175.06667000" },
                        new() { Id = 3, Name = "Nuku‘alofa", Latitude = "-21.13938000", Longitude = "-175.20180000" },
                        new() { Id = 4, Name = "Vaini", Latitude = "-21.19292000", Longitude = "-175.17678000" }
                    }
                },

                new()
                {
                    Id = 5,
                    Name = "Vavaʻu",
                    StateCode = "05",
                    Latitude = "-18.62275600",
                    Longitude = "-173.99029820",
                    Type = "division",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Neiafu", Latitude = "-18.65060000", Longitude = "-173.98404000" }
                    }
                }
            }
        };
    }
}
