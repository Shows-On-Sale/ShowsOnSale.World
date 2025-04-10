// ⚠️ WARNING: This file is automatically generated by scripts/generate-world.ps1
// DO NOT modify this file manually as it will be overwritten when the script is run again.
// To update the data, modify the source data in countries-states-cities-database and run the script.

using System.Collections.Generic;
using ShowsOnSale.World.Models;

namespace ShowsOnSale.World.Data.Countries
{
    public static class Gibraltar
    {
        public static Country Data { get; } = new()
        {
            Id = 84,
            Name = "Gibraltar",
            Iso3 = "GIB",
            Iso2 = "GI",
            NumericCode = "292",
            PhoneCode = "350",
            Capital = "Gibraltar",
            Currency = "GIP",
            CurrencyName = "Gibraltar pound",
            CurrencySymbol = "£",
            Tld = ".gi",
            Native = "Gibraltar",
            Region = "Europe",
            RegionId = 4,
            Subregion = "Southern Europe",
            SubregionId = 16,
            Nationality = "Gibraltar",
            Latitude = "36.13333333",
            Longitude = "-5.35000000",
            Emoji = "🇬🇮",
            EmojiU = "U+1F1EC U+1F1EE",
            Timezones = new()
            {
                new() { ZoneName = "Europe/Gibraltar", GmtOffset = 3600, GmtOffsetName = "UTC+01:00", Abbreviation = "CET", TzName = "Central European Time" }
            },
            Translations = new()
            {
                ["ko"] = "지브롤터",
                ["pt-BR"] = "Gibraltar",
                ["pt"] = "Gibraltar",
                ["nl"] = "Gibraltar",
                ["hr"] = "Gibraltar",
                ["fa"] = "جبل‌طارق",
                ["de"] = "Gibraltar",
                ["es"] = "Gibraltar",
                ["fr"] = "Gibraltar",
                ["ja"] = "ジブラルタル",
                ["it"] = "Gibilterra",
                ["zh-CN"] = "直布罗陀",
                ["tr"] = "Cebelitarik",
                ["ru"] = "Гибралтар",
                ["uk"] = "Гібралтар",
                ["pl"] = "Gibraltar"
            },
            States = new()
            {
            }
        };
    }
}
