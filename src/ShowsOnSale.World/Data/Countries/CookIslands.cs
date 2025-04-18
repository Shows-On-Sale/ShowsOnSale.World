// ⚠️ WARNING: This file is automatically generated by scripts/generate-world.ps1
// DO NOT modify this file manually as it will be overwritten when the script is run again.
// To update the data, modify the source data in countries-states-cities-database and run the script.

using System.Collections.Generic;
using ShowsOnSale.World.Models;

namespace ShowsOnSale.World.Data.Countries
{
    public static class CookIslands
    {
        public static Country Data { get; } = new()
        {
            Id = 51,
            Name = "Cook Islands",
            Iso3 = "COK",
            Iso2 = "CK",
            NumericCode = "184",
            PhoneCode = "682",
            Capital = "Avarua",
            Currency = "NZD",
            CurrencyName = "New Zealand dollar",
            CurrencySymbol = "$",
            Tld = ".ck",
            Native = "Cook Islands",
            Region = "Oceania",
            RegionId = 5,
            Subregion = "Polynesia",
            SubregionId = 22,
            Nationality = "Cook Island",
            Latitude = "-21.23333333",
            Longitude = "-159.76666666",
            Emoji = "🇨🇰",
            EmojiU = "U+1F1E8 U+1F1F0",
            Timezones = new()
            {
                new() { ZoneName = "Pacific/Rarotonga", GmtOffset = -36000, GmtOffsetName = "UTC-10:00", Abbreviation = "CKT", TzName = "Cook Island Time" }
            },
            Translations = new()
            {
                ["ko"] = "쿡 제도",
                ["pt-BR"] = "Ilhas Cook",
                ["pt"] = "Ilhas Cook",
                ["nl"] = "Cookeilanden",
                ["hr"] = "Cookovo Otočje",
                ["fa"] = "جزایر کوک",
                ["de"] = "Cookinseln",
                ["es"] = "Islas Cook",
                ["fr"] = "Îles Cook",
                ["ja"] = "クック諸島",
                ["it"] = "Isole Cook",
                ["zh-CN"] = "库克群岛",
                ["tr"] = "Cook Adalari",
                ["ru"] = "Острова Кука",
                ["uk"] = "Острови Кука",
                ["pl"] = "Wyspy Cooka"
            },
            States = new()
            {
            }
        };
    }
}
