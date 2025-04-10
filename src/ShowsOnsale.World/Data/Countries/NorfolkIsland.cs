// ⚠️ WARNING: This file is automatically generated by scripts/generate-world.ps1
// DO NOT modify this file manually as it will be overwritten when the script is run again.
// To update the data, modify the source data in countries-states-cities-database and run the script.

using System.Collections.Generic;
using ShowsOnSale.World.Models;

namespace ShowsOnSale.World.Data.Countries
{
    public static class NorfolkIsland
    {
        public static Country Data { get; } = new()
        {
            Id = 160,
            Name = "Norfolk Island",
            Iso3 = "NFK",
            Iso2 = "NF",
            NumericCode = "574",
            PhoneCode = "672",
            Capital = "Kingston",
            Currency = "AUD",
            CurrencyName = "Australian dollar",
            CurrencySymbol = "$",
            Tld = ".nf",
            Native = "Norfolk Island",
            Region = "Oceania",
            RegionId = 5,
            Subregion = "Australia and New Zealand",
            SubregionId = 19,
            Nationality = "Norfolk Island",
            Latitude = "-29.03333333",
            Longitude = "167.95000000",
            Emoji = "🇳🇫",
            EmojiU = "U+1F1F3 U+1F1EB",
            Timezones = new()
            {
                new() { ZoneName = "Pacific/Norfolk", GmtOffset = 43200, GmtOffsetName = "UTC+12:00", Abbreviation = "NFT", TzName = "Norfolk Time" }
            },
            Translations = new()
            {
                ["ko"] = "노퍽 섬",
                ["pt-BR"] = "Ilha Norfolk",
                ["pt"] = "Ilha Norfolk",
                ["nl"] = "Norfolkeiland",
                ["hr"] = "Otok Norfolk",
                ["fa"] = "جزیره نورفک",
                ["de"] = "Norfolkinsel",
                ["es"] = "Isla de Norfolk",
                ["fr"] = "Île de Norfolk",
                ["ja"] = "ノーフォーク島",
                ["it"] = "Isola Norfolk",
                ["zh-CN"] = "诺福克岛",
                ["tr"] = "Norfolk Adasi",
                ["ru"] = "Остров Норфолк",
                ["uk"] = "Острів Норфолк",
                ["pl"] = "Wyspa Norfolk"
            },
            States = new()
            {
            }
        };
    }
}
