// ⚠️ WARNING: This file is automatically generated by scripts/generate-world.ps1
// DO NOT modify this file manually as it will be overwritten when the script is run again.
// To update the data, modify the source data in countries-states-cities-database and run the script.

using System.Collections.Generic;
using ShowsOnSale.World.Models;

namespace ShowsOnSale.World.Data.Countries
{
    public static class Curaao
    {
        public static Country Data { get; } = new()
        {
            Id = 56,
            Name = "Curaçao",
            Iso3 = "CUW",
            Iso2 = "CW",
            NumericCode = "531",
            PhoneCode = "599",
            Capital = "Willemstad",
            Currency = "ANG",
            CurrencyName = "Netherlands Antillean guilder",
            CurrencySymbol = "ƒ",
            Tld = ".cw",
            Native = "Curaçao",
            Region = "Americas",
            RegionId = 2,
            Subregion = "Caribbean",
            SubregionId = 7,
            Nationality = "Curacaoan",
            Latitude = "12.11666700",
            Longitude = "-68.93333300",
            Emoji = "🇨🇼",
            EmojiU = "U+1F1E8 U+1F1FC",
            Timezones = new()
            {
                new() { ZoneName = "America/Curacao", GmtOffset = -14400, GmtOffsetName = "UTC-04:00", Abbreviation = "AST", TzName = "Atlantic Standard Time" }
            },
            Translations = new()
            {
                ["ko"] = "퀴라소",
                ["pt-BR"] = "Curaçao",
                ["pt"] = "Curaçao",
                ["nl"] = "Curaçao",
                ["fa"] = "کوراسائو",
                ["de"] = "Curaçao",
                ["fr"] = "Curaçao",
                ["it"] = "Curaçao",
                ["zh-CN"] = "库拉索",
                ["tr"] = "Curaçao",
                ["ru"] = "Кюрасао",
                ["uk"] = "Кюрасао",
                ["pl"] = "Curaçao"
            },
            States = new()
            {
            }
        };
    }
}
