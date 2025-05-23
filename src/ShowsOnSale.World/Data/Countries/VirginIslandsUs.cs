// ⚠️ WARNING: This file is automatically generated by scripts/generate-world.ps1
// DO NOT modify this file manually as it will be overwritten when the script is run again.
// To update the data, modify the source data in countries-states-cities-database and run the script.

using System.Collections.Generic;
using ShowsOnSale.World.Models;

namespace ShowsOnSale.World.Data.Countries
{
    public static class VirginIslandsUs
    {
        public static Country Data { get; } = new()
        {
            Id = 245,
            Name = "Virgin Islands (US)",
            Iso3 = "VIR",
            Iso2 = "VI",
            NumericCode = "850",
            PhoneCode = "1",
            Capital = "Charlotte Amalie",
            Currency = "USD",
            CurrencyName = "United States dollar",
            CurrencySymbol = "$",
            Tld = ".vi",
            Native = "United States Virgin Islands",
            Region = "Americas",
            RegionId = 2,
            Subregion = "Caribbean",
            SubregionId = 7,
            Nationality = "U.S. Virgin Island",
            Latitude = "18.34000000",
            Longitude = "-64.93000000",
            Emoji = "🇻🇮",
            EmojiU = "U+1F1FB U+1F1EE",
            Timezones = new()
            {
                new() { ZoneName = "America/St_Thomas", GmtOffset = -14400, GmtOffsetName = "UTC-04:00", Abbreviation = "AST", TzName = "Atlantic Standard Time" }
            },
            Translations = new()
            {
                ["ko"] = "미국령 버진아일랜드",
                ["pt-BR"] = "Ilhas Virgens Americanas",
                ["pt"] = "Ilhas Virgens Americanas",
                ["nl"] = "Verenigde Staten Maagdeneilanden",
                ["fa"] = "جزایر ویرجین آمریکا",
                ["de"] = "Amerikanische Jungferninseln",
                ["es"] = "Islas Vírgenes de los Estados Unidos",
                ["fr"] = "Îles Vierges des États-Unis",
                ["ja"] = "アメリカ領ヴァージン諸島",
                ["it"] = "Isole Vergini americane",
                ["zh-CN"] = "维尔京群岛（美国）",
                ["tr"] = "Abd Virjin Adalari",
                ["ru"] = "Виргинские острова (США)",
                ["uk"] = "Віргінські острови (США)",
                ["pl"] = "Wyspy Dziewicze (USA)"
            },
            States = new()
            {

                new()
                {
                    Id = 1,
                    Name = "Saint Croix",
                    StateCode = "SC",
                    Latitude = "17.72935200",
                    Longitude = "-64.73437050",
                    Type = "district",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Christiansted", Latitude = "17.74403640", Longitude = "-64.71060860" },
                        new() { Id = 2, Name = "East End", Latitude = "17.75238820", Longitude = "-64.67030100" },
                        new() { Id = 3, Name = "Frederiksted", Latitude = "17.71246910", Longitude = "-64.88671920" },
                        new() { Id = 4, Name = "Good Hope", Latitude = "17.72234420", Longitude = "-64.71724940" },
                        new() { Id = 5, Name = "Northcentral", Latitude = "17.75011450", Longitude = "-64.82384910" },
                        new() { Id = 6, Name = "Northwest", Latitude = "17.73827820", Longitude = "-64.89063470" },
                        new() { Id = 7, Name = "Sion Farm", Latitude = "17.75432760", Longitude = "-64.77946110" },
                        new() { Id = 8, Name = "Southcentral", Latitude = "17.70649170", Longitude = "-64.81448650" },
                        new() { Id = 9, Name = "Southwest", Latitude = "17.69177870", Longitude = "-64.93559390" }
                    }
                },

                new()
                {
                    Id = 2,
                    Name = "Saint John",
                    StateCode = "SJ",
                    Latitude = "18.33561690",
                    Longitude = "-64.80028000",
                    Type = "district",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Central", Latitude = "18.33568380", Longitude = "-64.79470780" },
                        new() { Id = 2, Name = "Coral Bay", Latitude = "18.34800890", Longitude = "-64.72196820" },
                        new() { Id = 3, Name = "Cruz Bay", Latitude = "18.31820370", Longitude = "-64.80242110" },
                        new() { Id = 4, Name = "East End", Latitude = "18.34036470", Longitude = "-64.68062660" }
                    }
                },

                new()
                {
                    Id = 3,
                    Name = "Saint Thomas",
                    StateCode = "ST",
                    Latitude = "18.34284590",
                    Longitude = "-65.07701800",
                    Type = "district",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Charlotte Amalie", Latitude = "18.34127610", Longitude = "-64.94838690" },
                        new() { Id = 2, Name = "East End", Latitude = "18.32901620", Longitude = "-64.87047310" },
                        new() { Id = 3, Name = "Northside", Latitude = "18.37380810", Longitude = "-64.95589090" },
                        new() { Id = 4, Name = "Southside", Latitude = "18.30529120", Longitude = "-64.91724450" },
                        new() { Id = 5, Name = "Tutu", Latitude = "18.33884270", Longitude = "-64.89530720" },
                        new() { Id = 6, Name = "Water Island", Latitude = "18.32086530", Longitude = "-64.96932630" },
                        new() { Id = 7, Name = "West End", Latitude = "18.37243670", Longitude = "-65.06490130" }
                    }
                }
            }
        };
    }
}
