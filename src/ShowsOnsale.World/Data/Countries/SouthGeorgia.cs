// ⚠️ WARNING: This file is automatically generated by scripts/generate-world.ps1
// DO NOT modify this file manually as it will be overwritten when the script is run again.
// To update the data, modify the source data in countries-states-cities-database and run the script.

using System.Collections.Generic;
using ShowsOnSale.World.Models;

namespace ShowsOnSale.World.Data.Countries
{
    public static class SouthGeorgia
    {
        public static Country Data { get; } = new()
        {
            Id = 205,
            Name = "South Georgia",
            Iso3 = "SGS",
            Iso2 = "GS",
            NumericCode = "239",
            PhoneCode = "500",
            Capital = "Grytviken",
            Currency = "GBP",
            CurrencyName = "British pound",
            CurrencySymbol = "£",
            Tld = ".gs",
            Native = "South Georgia",
            Region = "Americas",
            RegionId = 2,
            Subregion = "South America",
            SubregionId = 8,
            Nationality = "South Georgia or South Sandwich Islands",
            Latitude = "-54.50000000",
            Longitude = "-37.00000000",
            Emoji = "🇬🇸",
            EmojiU = "U+1F1EC U+1F1F8",
            Timezones = new()
            {
                new() { ZoneName = "Atlantic/South_Georgia", GmtOffset = -7200, GmtOffsetName = "UTC-02:00", Abbreviation = "GST", TzName = "South Georgia and the South Sandwich Islands Time" }
            },
            Translations = new()
            {
                ["ko"] = "사우스조지아",
                ["pt-BR"] = "Ilhas Geórgias do Sul e Sandwich do Sul",
                ["pt"] = "Ilhas Geórgia do Sul e Sanduíche do Sul",
                ["nl"] = "Zuid-Georgia en Zuidelijke Sandwicheilanden",
                ["hr"] = "Južna Georgija i otočje Južni Sandwich",
                ["fa"] = "جزایر جورجیای جنوبی و ساندویچ جنوبی",
                ["de"] = "Südgeorgien und die Südlichen Sandwichinseln",
                ["es"] = "Islas Georgias del Sur y Sandwich del Sur",
                ["fr"] = "Géorgie du Sud-et-les Îles Sandwich du Sud",
                ["ja"] = "サウスジョージア・サウスサンドウィッチ諸島",
                ["it"] = "Georgia del Sud e Isole Sandwich Meridionali",
                ["zh-CN"] = "南乔治亚",
                ["tr"] = "Güney Georgia",
                ["ru"] = "Южная Джорджия",
                ["uk"] = "Південна Джорджія",
                ["pl"] = "Południowa Georgia"
            },
            States = new()
            {
            }
        };
    }
}
