// ⚠️ WARNING: This file is automatically generated by scripts/generate-world.ps1
// DO NOT modify this file manually as it will be overwritten when the script is run again.
// To update the data, modify the source data in countries-states-cities-database and run the script.

using System.Collections.Generic;
using ShowsOnSale.World.Models;

namespace ShowsOnSale.World.Data.Countries
{
    public static class Taiwan
    {
        public static Country Data { get; } = new()
        {
            Id = 216,
            Name = "Taiwan",
            Iso3 = "TWN",
            Iso2 = "TW",
            NumericCode = "158",
            PhoneCode = "886",
            Capital = "Taipei",
            Currency = "TWD",
            CurrencyName = "New Taiwan dollar",
            CurrencySymbol = "$",
            Tld = ".tw",
            Native = "臺灣",
            Region = "Asia",
            RegionId = 3,
            Subregion = "Eastern Asia",
            SubregionId = 12,
            Nationality = "Chinese, Taiwanese",
            Latitude = "23.50000000",
            Longitude = "121.00000000",
            Emoji = "🇹🇼",
            EmojiU = "U+1F1F9 U+1F1FC",
            Timezones = new()
            {
                new() { ZoneName = "Asia/Taipei", GmtOffset = 28800, GmtOffsetName = "UTC+08:00", Abbreviation = "CST", TzName = "China Standard Time" }
            },
            Translations = new()
            {
                ["ko"] = "대만",
                ["pt-BR"] = "Taiwan",
                ["pt"] = "Taiwan",
                ["nl"] = "Taiwan",
                ["hr"] = "Tajvan",
                ["fa"] = "تایوان",
                ["de"] = "Taiwan",
                ["es"] = "Taiwán",
                ["fr"] = "Taïwan",
                ["ja"] = "台湾（中華民国）",
                ["it"] = "Taiwan",
                ["zh-CN"] = "中国台湾",
                ["tr"] = "Tayvan",
                ["ru"] = "Тайвань",
                ["uk"] = "Тайвань",
                ["pl"] = "Tajwan"
            },
            States = new()
            {

                new()
                {
                    Id = 1,
                    Name = "Changhua",
                    StateCode = "CHA",
                    Latitude = "24.05179630",
                    Longitude = "120.51613520",
                    Type = "county",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Changhua", Latitude = "23.95361000", Longitude = "120.49083000" },
                        new() { Id = 2, Name = "Yuanlin", Latitude = "23.95671000", Longitude = "120.57608000" }
                    }
                },

                new()
                {
                    Id = 2,
                    Name = "Chiayi",
                    StateCode = "CYI",
                    Latitude = "23.45184280",
                    Longitude = "120.25546150",
                    Type = "city",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Chiayi", Latitude = "23.47722000", Longitude = "120.44527000" },
                        new() { Id = 2, Name = "Pizitou", Latitude = "23.48556000", Longitude = "120.44472000" }
                    }
                },

                new()
                {
                    Id = 3,
                    Name = "Chiayi",
                    StateCode = "CYQ",
                    Latitude = "23.48007510",
                    Longitude = "120.44911130",
                    Type = "county",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Chiayi County", Latitude = "23.46333000", Longitude = "120.58166000" }
                    }
                },

                new()
                {
                    Id = 4,
                    Name = "Hsinchu",
                    StateCode = "HSQ",
                    Latitude = "24.83872260",
                    Longitude = "121.01772460",
                    Type = "county",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Hsinchu", Latitude = "24.80361000", Longitude = "120.96861000" }
                    }
                },

                new()
                {
                    Id = 5,
                    Name = "Hsinchu",
                    StateCode = "HSZ",
                    Latitude = "24.81382870",
                    Longitude = "120.96747980",
                    Type = "city",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Hsinchu County", Latitude = "24.67416000", Longitude = "121.16111000" }
                    }
                },

                new()
                {
                    Id = 6,
                    Name = "Hualien",
                    StateCode = "HUA",
                    Latitude = "23.98715890",
                    Longitude = "121.60157140",
                    Type = "county",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Hualien", Latitude = "23.78166000", Longitude = "121.39333000" },
                        new() { Id = 2, Name = "Hualien City", Latitude = "23.97694000", Longitude = "121.60444000" }
                    }
                },

                new()
                {
                    Id = 7,
                    Name = "Kaohsiung",
                    StateCode = "KHH",
                    Latitude = "22.62727840",
                    Longitude = "120.30143530",
                    Type = "special municipality",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Kaohsiung", Latitude = "22.61626000", Longitude = "120.31333000" }
                    }
                },

                new()
                {
                    Id = 8,
                    Name = "Keelung",
                    StateCode = "KEE",
                    Latitude = "25.12418620",
                    Longitude = "121.64758340",
                    Type = "city",
                    Cities = new()
                    {
                    }
                },

                new()
                {
                    Id = 9,
                    Name = "Kinmen",
                    StateCode = "KIN",
                    Latitude = "24.34877920",
                    Longitude = "118.32856440",
                    Type = "county",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Jincheng", Latitude = "24.43415000", Longitude = "118.31712000" },
                        new() { Id = 2, Name = "Kinmen County", Latitude = "24.45333000", Longitude = "118.38861000" }
                    }
                },

                new()
                {
                    Id = 10,
                    Name = "Lienchiang",
                    StateCode = "LIE",
                    Latitude = "26.15055560",
                    Longitude = "119.92888890",
                    Type = "county",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Lienchiang", Latitude = "26.37004000", Longitude = "120.49545000" },
                        new() { Id = 2, Name = "Nangan", Latitude = "26.15039000", Longitude = "119.93284000" }
                    }
                },

                new()
                {
                    Id = 11,
                    Name = "Miaoli",
                    StateCode = "MIA",
                    Latitude = "24.56015900",
                    Longitude = "120.82142650",
                    Type = "county",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Miaoli", Latitude = "24.48972000", Longitude = "120.90638000" }
                    }
                },

                new()
                {
                    Id = 12,
                    Name = "Nantou",
                    StateCode = "NAN",
                    Latitude = "23.96099810",
                    Longitude = "120.97186380",
                    Type = "county",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Lugu", Latitude = "23.74639000", Longitude = "120.75250000" },
                        new() { Id = 2, Name = "Nantou", Latitude = "23.83419000", Longitude = "120.92704000" },
                        new() { Id = 3, Name = "Puli", Latitude = "23.96639000", Longitude = "120.96952000" },
                        new() { Id = 4, Name = "Zhongxing New Village", Latitude = "23.95908000", Longitude = "120.68516000" }
                    }
                },

                new()
                {
                    Id = 13,
                    Name = "New Taipei",
                    StateCode = "NWT",
                    Latitude = "24.98752780",
                    Longitude = "121.36459470",
                    Type = "special municipality",
                    Cities = new()
                    {
                    }
                },

                new()
                {
                    Id = 14,
                    Name = "Penghu",
                    StateCode = "PEN",
                    Latitude = "23.57118990",
                    Longitude = "119.57931570",
                    Type = "county",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Magong", Latitude = "23.56540000", Longitude = "119.58627000" },
                        new() { Id = 2, Name = "Penghu County", Latitude = "23.57111000", Longitude = "119.61138000" }
                    }
                },

                new()
                {
                    Id = 15,
                    Name = "Pingtung",
                    StateCode = "PIF",
                    Latitude = "22.55197590",
                    Longitude = "120.54875970",
                    Type = "county",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Donggang", Latitude = "22.46515000", Longitude = "120.44927000" },
                        new() { Id = 2, Name = "Hengchun", Latitude = "22.00417000", Longitude = "120.74389000" },
                        new() { Id = 3, Name = "Pingtung", Latitude = "22.49555000", Longitude = "120.61444000" }
                    }
                },

                new()
                {
                    Id = 16,
                    Name = "Taichung",
                    StateCode = "TXG",
                    Latitude = "24.14773580",
                    Longitude = "120.67364820",
                    Type = "special municipality",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Taichung", Latitude = "24.14690000", Longitude = "120.68390000" },
                        new() { Id = 2, Name = "Taichung City", Latitude = "24.15472000", Longitude = "120.67297000" }
                    }
                },

                new()
                {
                    Id = 17,
                    Name = "Tainan",
                    StateCode = "TNN",
                    Latitude = "22.99972810",
                    Longitude = "120.22702770",
                    Type = "special municipality",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Tainan", Latitude = "22.99083000", Longitude = "120.21333000" },
                        new() { Id = 2, Name = "Yujing", Latitude = "23.12493000", Longitude = "120.46138000" }
                    }
                },

                new()
                {
                    Id = 18,
                    Name = "Taipei",
                    StateCode = "TPE",
                    Latitude = "25.03296940",
                    Longitude = "121.56541770",
                    Type = "special municipality",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Banqiao", Latitude = "25.01427000", Longitude = "121.46719000" },
                        new() { Id = 2, Name = "Jiufen", Latitude = "25.10957000", Longitude = "121.84424000" },
                        new() { Id = 3, Name = "Taipei", Latitude = "25.04776000", Longitude = "121.53185000" },
                        new() { Id = 4, Name = "Taipei City", Latitude = "25.08300000", Longitude = "121.55331000" }
                    }
                },

                new()
                {
                    Id = 19,
                    Name = "Taitung",
                    StateCode = "TTT",
                    Latitude = "22.79724470",
                    Longitude = "121.07137020",
                    Type = "county",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Taitung", Latitude = "22.88361000", Longitude = "121.04833000" },
                        new() { Id = 2, Name = "Taitung City", Latitude = "22.75830000", Longitude = "121.14440000" }
                    }
                },

                new()
                {
                    Id = 20,
                    Name = "Taoyuan",
                    StateCode = "TAO",
                    Latitude = "24.99362810",
                    Longitude = "121.30097980",
                    Type = "special municipality",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Daxi", Latitude = "24.88373000", Longitude = "121.29043000" },
                        new() { Id = 2, Name = "Taoyuan", Latitude = "24.89500000", Longitude = "121.24611000" },
                        new() { Id = 3, Name = "Taoyuan City", Latitude = "24.99368000", Longitude = "121.29696000" }
                    }
                },

                new()
                {
                    Id = 21,
                    Name = "Yilan",
                    StateCode = "ILA",
                    Latitude = "24.70210730",
                    Longitude = "121.73775020",
                    Type = "county",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Yilan", Latitude = "24.54250000", Longitude = "121.63361000" }
                    }
                },

                new()
                {
                    Id = 22,
                    Name = "Yunlin",
                    StateCode = "YUN",
                    Latitude = "23.70920330",
                    Longitude = "120.43133730",
                    Type = "county",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Douliu", Latitude = "23.70944000", Longitude = "120.54333000" },
                        new() { Id = 2, Name = "Yunlin", Latitude = "23.70701000", Longitude = "120.38481000" }
                    }
                }
            }
        };
    }
}
