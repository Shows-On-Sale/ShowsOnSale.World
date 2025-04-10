// ⚠️ WARNING: This file is automatically generated by scripts/generate-world.ps1
// DO NOT modify this file manually as it will be overwritten when the script is run again.
// To update the data, modify the source data in countries-states-cities-database and run the script.

using System.Collections.Generic;
using ShowsOnSale.World.Models;

namespace ShowsOnSale.World.Data.Countries
{
    public static class SaintVincentAndTheGrenadines
    {
        public static Country Data { get; } = new()
        {
            Id = 187,
            Name = "Saint Vincent and the Grenadines",
            Iso3 = "VCT",
            Iso2 = "VC",
            NumericCode = "670",
            PhoneCode = "1",
            Capital = "Kingstown",
            Currency = "XCD",
            CurrencyName = "Eastern Caribbean dollar",
            CurrencySymbol = "$",
            Tld = ".vc",
            Native = "Saint Vincent and the Grenadines",
            Region = "Americas",
            RegionId = 2,
            Subregion = "Caribbean",
            SubregionId = 7,
            Nationality = "Saint Vincentian, Vincentian",
            Latitude = "13.25000000",
            Longitude = "-61.20000000",
            Emoji = "🇻🇨",
            EmojiU = "U+1F1FB U+1F1E8",
            Timezones = new()
            {
                new() { ZoneName = "America/St_Vincent", GmtOffset = -14400, GmtOffsetName = "UTC-04:00", Abbreviation = "AST", TzName = "Atlantic Standard Time" }
            },
            Translations = new()
            {
                ["ko"] = "세인트빈센트 그레나딘",
                ["pt-BR"] = "São Vicente e Granadinas",
                ["pt"] = "São Vicente e Granadinas",
                ["nl"] = "Saint Vincent en de Grenadines",
                ["hr"] = "Sveti Vincent i Grenadini",
                ["fa"] = "سنت وینسنت و گرنادین‌ها",
                ["de"] = "Saint Vincent und die Grenadinen",
                ["es"] = "San Vicente y Granadinas",
                ["fr"] = "Saint-Vincent-et-les-Grenadines",
                ["ja"] = "セントビンセントおよびグレナディーン諸島",
                ["it"] = "Saint Vincent e Grenadine",
                ["zh-CN"] = "圣文森特和格林纳丁斯",
                ["tr"] = "Saint Vincent Ve Grenadinler",
                ["ru"] = "Сент-Винсент и Гренадины",
                ["uk"] = "Сент-Вінсент і Гренадини",
                ["pl"] = "Saint Vincent i Grenadyny"
            },
            States = new()
            {

                new()
                {
                    Id = 1,
                    Name = "Charlotte",
                    StateCode = "01",
                    Latitude = "13.21754510",
                    Longitude = "-61.16362440",
                    Type = "parish",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Biabou", Latitude = "13.19430000", Longitude = "-61.13904000" },
                        new() { Id = 2, Name = "Byera Village", Latitude = "13.25636000", Longitude = "-61.11954000" },
                        new() { Id = 3, Name = "Georgetown", Latitude = "13.28054000", Longitude = "-61.11850000" }
                    }
                },

                new()
                {
                    Id = 2,
                    Name = "Grenadines",
                    StateCode = "06",
                    Latitude = "13.01229650",
                    Longitude = "-61.22773010",
                    Type = "parish",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Port Elizabeth", Latitude = "13.01102000", Longitude = "-61.23548000" }
                    }
                },

                new()
                {
                    Id = 3,
                    Name = "Saint Andrew",
                    StateCode = "02",
                    Latitude = "43.02429990",
                    Longitude = "-81.20250000",
                    Type = "parish",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Layou", Latitude = "13.20175000", Longitude = "-61.27014000" }
                    }
                },

                new()
                {
                    Id = 4,
                    Name = "Saint David",
                    StateCode = "03",
                    Latitude = "43.85230950",
                    Longitude = "-79.52366540",
                    Type = "parish",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Chateaubelair", Latitude = "13.29069000", Longitude = "-61.24043000" }
                    }
                },

                new()
                {
                    Id = 5,
                    Name = "Saint George",
                    StateCode = "04",
                    Latitude = "42.95760900",
                    Longitude = "-81.32670500",
                    Type = "parish",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Kingstown", Latitude = "13.15527000", Longitude = "-61.22742000" },
                        new() { Id = 2, Name = "Kingstown Park", Latitude = "13.15924000", Longitude = "-61.23161000" }
                    }
                },

                new()
                {
                    Id = 6,
                    Name = "Saint Patrick",
                    StateCode = "05",
                    Latitude = "39.75091860",
                    Longitude = "-94.84505560",
                    Type = "parish",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Barrouallie", Latitude = "13.23676000", Longitude = "-61.27275000" }
                    }
                }
            }
        };
    }
}
