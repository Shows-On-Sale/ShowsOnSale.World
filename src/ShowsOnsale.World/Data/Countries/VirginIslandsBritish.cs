// ⚠️ WARNING: This file is automatically generated by scripts/generate-world.ps1
// DO NOT modify this file manually as it will be overwritten when the script is run again.
// To update the data, modify the source data in countries-states-cities-database and run the script.

using System.Collections.Generic;
using ShowsOnSale.World.Models;

namespace ShowsOnSale.World.Data.Countries
{
    public static class VirginIslandsBritish
    {
        public static Country Data { get; } = new()
        {
            Id = 244,
            Name = "Virgin Islands (British)",
            Iso3 = "VGB",
            Iso2 = "VG",
            NumericCode = "092",
            PhoneCode = "1",
            Capital = "Road Town",
            Currency = "USD",
            CurrencyName = "United States dollar",
            CurrencySymbol = "$",
            Tld = ".vg",
            Native = "British Virgin Islands",
            Region = "Americas",
            RegionId = 2,
            Subregion = "Caribbean",
            SubregionId = 7,
            Nationality = "British Virgin Island",
            Latitude = "18.43138300",
            Longitude = "-64.62305000",
            Emoji = "🇻🇬",
            EmojiU = "U+1F1FB U+1F1EC",
            Timezones = new()
            {
                new() { ZoneName = "America/Tortola", GmtOffset = -14400, GmtOffsetName = "UTC-04:00", Abbreviation = "AST", TzName = "Atlantic Standard Time" }
            },
            Translations = new()
            {
                { "ko" = "영국령 버진아일랜드" },
                { "pt-BR" = "Ilhas Virgens Britânicas" }
                { "pt" = "Ilhas Virgens Britânicas" }
                { "nl" = "Britse Maagdeneilanden" }
                { "hr" = "Britanski Djevičanski Otoci" }
                { "fa" = "جزایر ویرجین بریتانیا" }
                { "de" = "Britische Jungferninseln" }
                { "es" = "Islas Vírgenes del Reino Unido" }
                { "fr" = "Îles Vierges britanniques" }
                { "ja" = "イギリス領ヴァージン諸島" }
                { "it" = "Isole Vergini Britanniche" }
                { "zh-CN" = "圣文森特和格林纳丁斯" }
                { "tr" = "Britanya Virjin Adalari" }
                { "ru" = "Виргинские острова (Британские)" }
                { "uk" = "Віргінські острови (Британські)" }
                { "pl" = "Wyspy Dziewicze (Brytyjskie)" }
            },
            States = new()
            {
            }
        };
    }
}
