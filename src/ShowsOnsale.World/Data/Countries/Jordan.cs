// ⚠️ WARNING: This file is automatically generated by scripts/generate-world.ps1
// DO NOT modify this file manually as it will be overwritten when the script is run again.
// To update the data, modify the source data in countries-states-cities-database and run the script.

using System.Collections.Generic;
using ShowsOnSale.World.Models;

namespace ShowsOnSale.World.Data.Countries
{
    public static class Jordan
    {
        public static Country Data { get; } = new()
        {
            Id = 111,
            Name = "Jordan",
            Iso3 = "JOR",
            Iso2 = "JO",
            NumericCode = "400",
            PhoneCode = "962",
            Capital = "Amman",
            Currency = "JOD",
            CurrencyName = "Jordanian dinar",
            CurrencySymbol = "ا.د",
            Tld = ".jo",
            Native = "الأردن",
            Region = "Asia",
            RegionId = 3,
            Subregion = "Western Asia",
            SubregionId = 11,
            Nationality = "Jordanian",
            Latitude = "31.00000000",
            Longitude = "36.00000000",
            Emoji = "🇯🇴",
            EmojiU = "U+1F1EF U+1F1F4",
            Timezones = new()
            {
                new() { ZoneName = "Asia/Amman", GmtOffset = 7200, GmtOffsetName = "UTC+02:00", Abbreviation = "EET", TzName = "Eastern European Time" }
            },
            Translations = new()
            {
                ["ko"] = "요르단",
                ["pt-BR"] = "Jordânia",
                ["pt"] = "Jordânia",
                ["nl"] = "Jordanië",
                ["hr"] = "Jordan",
                ["fa"] = "اردن",
                ["de"] = "Jordanien",
                ["es"] = "Jordania",
                ["fr"] = "Jordanie",
                ["ja"] = "ヨルダン",
                ["it"] = "Giordania",
                ["zh-CN"] = "约旦",
                ["tr"] = "Ürdün",
                ["ru"] = "Джордан",
                ["uk"] = "Йорданія",
                ["pl"] = "Jordan"
            },
            States = new()
            {

                new()
                {
                    Id = 1,
                    Name = "Ajloun",
                    StateCode = "AJ",
                    Latitude = "32.33255840",
                    Longitude = "35.75168440",
                    Type = "governorate",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "‘Ajlūn", Latitude = "32.33326000", Longitude = "35.75279000" },
                        new() { Id = 2, Name = "‘Anjarah", Latitude = "32.30630000", Longitude = "35.75653000" },
                        new() { Id = 3, Name = "‘Ayn Jannah", Latitude = "32.33466000", Longitude = "35.76370000" },
                        new() { Id = 4, Name = "Ḩalāwah", Latitude = "32.38433000", Longitude = "35.66167000" },
                        new() { Id = 5, Name = "Şakhrah", Latitude = "32.37087000", Longitude = "35.84267000" }
                    }
                },

                new()
                {
                    Id = 2,
                    Name = "Amman",
                    StateCode = "AM",
                    Latitude = "31.94536330",
                    Longitude = "35.92838950",
                    Type = "governorate",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Al Jīzah", Latitude = "31.69893000", Longitude = "35.95530000" },
                        new() { Id = 2, Name = "Al Jubayhah", Latitude = "32.01071000", Longitude = "35.89802000" },
                        new() { Id = 3, Name = "Amman", Latitude = "31.95522000", Longitude = "35.94503000" },
                        new() { Id = 4, Name = "Ḩayy al Bunayyāt", Latitude = "31.89603000", Longitude = "35.88465000" },
                        new() { Id = 5, Name = "Ḩayy al Quwaysimah", Latitude = "31.91037000", Longitude = "35.94975000" },
                        new() { Id = 6, Name = "Jāwā", Latitude = "31.85247000", Longitude = "35.93928000" },
                        new() { Id = 7, Name = "Saḩāb", Latitude = "31.87032000", Longitude = "36.00479000" },
                        new() { Id = 8, Name = "Umm as Summāq", Latitude = "31.88542000", Longitude = "35.85430000" },
                        new() { Id = 9, Name = "Wādī as Sīr", Latitude = "31.95450000", Longitude = "35.81831000" }
                    }
                },

                new()
                {
                    Id = 3,
                    Name = "Aqaba",
                    StateCode = "AQ",
                    Latitude = "29.53208600",
                    Longitude = "35.00628210",
                    Type = "governorate",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Aqaba", Latitude = "29.52667000", Longitude = "35.00778000" },
                        new() { Id = 2, Name = "Tala Bay", Latitude = "29.40842000", Longitude = "34.97918000" }
                    }
                },

                new()
                {
                    Id = 4,
                    Name = "Balqa",
                    StateCode = "BA",
                    Latitude = "32.03668060",
                    Longitude = "35.72884800",
                    Type = "governorate",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Al Karāmah", Latitude = "31.95439000", Longitude = "35.58033000" },
                        new() { Id = 2, Name = "As Salţ", Latitude = "32.03917000", Longitude = "35.72722000" },
                        new() { Id = 3, Name = "Yarqā", Latitude = "31.97583000", Longitude = "35.69638000" }
                    }
                },

                new()
                {
                    Id = 5,
                    Name = "Irbid",
                    StateCode = "IR",
                    Latitude = "32.55696360",
                    Longitude = "35.84789650",
                    Type = "governorate",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Ar Ramthā", Latitude = "32.55873000", Longitude = "36.00816000" },
                        new() { Id = 2, Name = "Ash Shajarah", Latitude = "32.64391000", Longitude = "35.94175000" },
                        new() { Id = 3, Name = "Aţ Ţayyibah", Latitude = "32.54304000", Longitude = "35.71756000" },
                        new() { Id = 4, Name = "Aţ Ţurrah", Latitude = "32.63979000", Longitude = "35.98943000" },
                        new() { Id = 5, Name = "Aydūn", Latitude = "32.50528000", Longitude = "35.85809000" },
                        new() { Id = 6, Name = "Bayt Īdis", Latitude = "32.43775000", Longitude = "35.69765000" },
                        new() { Id = 7, Name = "Bayt Yāfā", Latitude = "32.52253000", Longitude = "35.78618000" },
                        new() { Id = 8, Name = "Dayr Yūsuf", Latitude = "32.48701000", Longitude = "35.79635000" },
                        new() { Id = 9, Name = "Ḩakamā", Latitude = "32.59354000", Longitude = "35.88320000" },
                        new() { Id = 10, Name = "Ḩātim", Latitude = "32.64492000", Longitude = "35.77771000" },
                        new() { Id = 11, Name = "Irbid", Latitude = "32.55556000", Longitude = "35.85000000" },
                        new() { Id = 12, Name = "Judita", Latitude = "32.40792000", Longitude = "35.70802000" },
                        new() { Id = 13, Name = "Kafr Abīl", Latitude = "32.41752000", Longitude = "35.66305000" },
                        new() { Id = 14, Name = "Kafr Asad", Latitude = "32.59800000", Longitude = "35.71266000" },
                        new() { Id = 15, Name = "Kafr Sawm", Latitude = "32.68527000", Longitude = "35.80102000" },
                        new() { Id = 16, Name = "Kharjā", Latitude = "32.65988000", Longitude = "35.88782000" },
                        new() { Id = 17, Name = "Kitim", Latitude = "32.43834000", Longitude = "35.89677000" },
                        new() { Id = 18, Name = "Kurayyimah", Latitude = "32.27639000", Longitude = "35.59938000" },
                        new() { Id = 19, Name = "Malkā", Latitude = "32.67645000", Longitude = "35.74851000" },
                        new() { Id = 20, Name = "Qumaym", Latitude = "32.57174000", Longitude = "35.73452000" },
                        new() { Id = 21, Name = "Saḩam al Kaffārāt", Latitude = "32.69848000", Longitude = "35.77438000" },
                        new() { Id = 22, Name = "Sāl", Latitude = "32.56897000", Longitude = "35.91185000" },
                        new() { Id = 23, Name = "Şammā", Latitude = "32.57102000", Longitude = "35.68984000" },
                        new() { Id = 24, Name = "Tibnah", Latitude = "32.47521000", Longitude = "35.73056000" },
                        new() { Id = 25, Name = "Umm Qays", Latitude = "32.65348000", Longitude = "35.68457000" },
                        new() { Id = 26, Name = "Waqqāş", Latitude = "32.54214000", Longitude = "35.60508000" },
                        new() { Id = 27, Name = "Zaḩar", Latitude = "32.56670000", Longitude = "35.77811000" }
                    }
                },

                new()
                {
                    Id = 6,
                    Name = "Jerash",
                    StateCode = "JA",
                    Latitude = "32.27472370",
                    Longitude = "35.89609540",
                    Type = "governorate",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Al Kittah", Latitude = "32.27685000", Longitude = "35.84114000" },
                        new() { Id = 2, Name = "Balīlā", Latitude = "32.39109000", Longitude = "35.93832000" },
                        new() { Id = 3, Name = "Burmā", Latitude = "32.21930000", Longitude = "35.78507000" },
                        new() { Id = 4, Name = "Jarash", Latitude = "32.28082000", Longitude = "35.89929000" },
                        new() { Id = 5, Name = "Qafqafā", Latitude = "32.34851000", Longitude = "35.93864000" },
                        new() { Id = 6, Name = "Raymūn", Latitude = "32.28202000", Longitude = "35.82779000" },
                        new() { Id = 7, Name = "Sakib", Latitude = "32.28431000", Longitude = "35.80909000" },
                        new() { Id = 8, Name = "Sūf", Latitude = "32.31372000", Longitude = "35.83713000" }
                    }
                },

                new()
                {
                    Id = 7,
                    Name = "Karak",
                    StateCode = "KA",
                    Latitude = "31.18535270",
                    Longitude = "35.70476820",
                    Type = "governorate",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "‘Ayy", Latitude = "31.13371000", Longitude = "35.64375000" },
                        new() { Id = 2, Name = "‘Izrā", Latitude = "31.15889000", Longitude = "35.69278000" },
                        new() { Id = 3, Name = "Adir", Latitude = "31.20217000", Longitude = "35.76155000" },
                        new() { Id = 4, Name = "Al Khinzīrah", Latitude = "31.05056000", Longitude = "35.60606000" },
                        new() { Id = 5, Name = "Al Mazār al Janūbī", Latitude = "31.06722000", Longitude = "35.69486000" },
                        new() { Id = 6, Name = "Al Qaşr", Latitude = "31.31407000", Longitude = "35.74393000" },
                        new() { Id = 7, Name = "Ar Rabbah", Latitude = "31.26923000", Longitude = "35.73829000" },
                        new() { Id = 8, Name = "Karak City", Latitude = "31.16368000", Longitude = "35.76204000" },
                        new() { Id = 9, Name = "Safi", Latitude = "31.03608000", Longitude = "35.46544000" }
                    }
                },

                new()
                {
                    Id = 8,
                    Name = "Ma'an",
                    StateCode = "MN",
                    Latitude = "30.19267890",
                    Longitude = "35.72493190",
                    Type = "governorate",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Al Jafr", Latitude = "30.31840000", Longitude = "36.17775000" },
                        new() { Id = 2, Name = "Al Quwayrah", Latitude = "29.80045000", Longitude = "35.31160000" },
                        new() { Id = 3, Name = "Ash Shawbak", Latitude = "30.52134000", Longitude = "35.57135000" },
                        new() { Id = 4, Name = "Aţ Ţayyibah", Latitude = "30.25125000", Longitude = "35.46570000" },
                        new() { Id = 5, Name = "Ma'an", Latitude = "30.19624000", Longitude = "35.73405000" },
                        new() { Id = 6, Name = "Petra", Latitude = "30.32096000", Longitude = "35.47895000" },
                        new() { Id = 7, Name = "Qīr Moāv", Latitude = "31.18248000", Longitude = "35.69999000" }
                    }
                },

                new()
                {
                    Id = 9,
                    Name = "Madaba",
                    StateCode = "MD",
                    Latitude = "31.71960970",
                    Longitude = "35.79327540",
                    Type = "governorate",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Mādabā", Latitude = "31.71599000", Longitude = "35.79392000" }
                    }
                },

                new()
                {
                    Id = 10,
                    Name = "Mafraq",
                    StateCode = "MA",
                    Latitude = "32.34169230",
                    Longitude = "36.20201750",
                    Type = "governorate",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Al Ḩamrā’", Latitude = "32.44017000", Longitude = "36.15265000" },
                        new() { Id = 2, Name = "Mafraq", Latitude = "32.34289000", Longitude = "36.20804000" },
                        new() { Id = 3, Name = "Rehab", Latitude = "32.32341000", Longitude = "36.09087000" },
                        new() { Id = 4, Name = "Rukban", Latitude = "33.31405000", Longitude = "38.70342000" },
                        new() { Id = 5, Name = "Şabḩā", Latitude = "32.32696000", Longitude = "36.50159000" },
                        new() { Id = 6, Name = "Umm al Qiţţayn", Latitude = "32.31449000", Longitude = "36.62826000" }
                    }
                },

                new()
                {
                    Id = 11,
                    Name = "Tafilah",
                    StateCode = "AT",
                    Latitude = "30.83380630",
                    Longitude = "35.61605130",
                    Type = "governorate",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Aţ Ţafīlah", Latitude = "30.83752000", Longitude = "35.60442000" },
                        new() { Id = 2, Name = "Buşayrā", Latitude = "30.73256000", Longitude = "35.60943000" }
                    }
                },

                new()
                {
                    Id = 12,
                    Name = "Zarqa",
                    StateCode = "AZ",
                    Latitude = "32.06085050",
                    Longitude = "36.09421210",
                    Type = "governorate",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Al Azraq ash Shamālī", Latitude = "31.88209000", Longitude = "36.83017000" },
                        new() { Id = 2, Name = "Russeifa", Latitude = "32.01778000", Longitude = "36.04639000" },
                        new() { Id = 3, Name = "Zarqa", Latitude = "32.07275000", Longitude = "36.08796000" }
                    }
                }
            }
        };
    }
}
