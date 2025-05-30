// ⚠️ WARNING: This file is automatically generated by scripts/generate-world.ps1
// DO NOT modify this file manually as it will be overwritten when the script is run again.
// To update the data, modify the source data in countries-states-cities-database and run the script.

using System.Collections.Generic;
using ShowsOnSale.World.Models;

namespace ShowsOnSale.World.Data.Countries
{
    public static class Libya
    {
        public static Country Data { get; } = new()
        {
            Id = 123,
            Name = "Libya",
            Iso3 = "LBY",
            Iso2 = "LY",
            NumericCode = "434",
            PhoneCode = "218",
            Capital = "Tripolis",
            Currency = "LYD",
            CurrencyName = "Libyan dinar",
            CurrencySymbol = "د.ل",
            Tld = ".ly",
            Native = "‏ليبيا",
            Region = "Africa",
            RegionId = 1,
            Subregion = "Northern Africa",
            SubregionId = 1,
            Nationality = "Libyan",
            Latitude = "25.00000000",
            Longitude = "17.00000000",
            Emoji = "🇱🇾",
            EmojiU = "U+1F1F1 U+1F1FE",
            Timezones = new()
            {
                new() { ZoneName = "Africa/Tripoli", GmtOffset = 7200, GmtOffsetName = "UTC+02:00", Abbreviation = "EET", TzName = "Eastern European Time" }
            },
            Translations = new()
            {
                ["ko"] = "리비아",
                ["pt-BR"] = "Líbia",
                ["pt"] = "Líbia",
                ["nl"] = "Libië",
                ["hr"] = "Libija",
                ["fa"] = "لیبی",
                ["de"] = "Libyen",
                ["es"] = "Libia",
                ["fr"] = "Libye",
                ["ja"] = "リビア",
                ["it"] = "Libia",
                ["zh-CN"] = "利比亚",
                ["tr"] = "Libya",
                ["ru"] = "Ливия",
                ["uk"] = "Лівія",
                ["pl"] = "Libia"
            },
            States = new()
            {

                new()
                {
                    Id = 1,
                    Name = "Al Wahat",
                    StateCode = "WA",
                    Latitude = "29.04668080",
                    Longitude = "21.85685860",
                    Type = "popularate",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Ajdabiya", Latitude = "30.75545000", Longitude = "20.22625000" },
                        new() { Id = 2, Name = "Al Burayqah", Latitude = "30.40624000", Longitude = "19.57386000" },
                        new() { Id = 3, Name = "Awjilah", Latitude = "29.10806000", Longitude = "21.28694000" },
                        new() { Id = 4, Name = "Az Zuwaytīnah", Latitude = "30.95220000", Longitude = "20.12022000" },
                        new() { Id = 5, Name = "Gialo", Latitude = "29.03333000", Longitude = "21.55000000" },
                        new() { Id = 6, Name = "Marādah", Latitude = "29.22054000", Longitude = "19.20454000" }
                    }
                },

                new()
                {
                    Id = 2,
                    Name = "Benghazi",
                    StateCode = "BA",
                    Latitude = "32.11942420",
                    Longitude = "20.08679090",
                    Type = "popularate",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Benghazi", Latitude = "32.11486000", Longitude = "20.06859000" },
                        new() { Id = 2, Name = "Qaryat Sulūq", Latitude = "31.66818000", Longitude = "20.25205000" }
                    }
                },

                new()
                {
                    Id = 3,
                    Name = "Derna",
                    StateCode = "DR",
                    Latitude = "32.75561300",
                    Longitude = "22.63774320",
                    Type = "popularate",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Al Qubbah", Latitude = "32.75684000", Longitude = "22.24106000" },
                        new() { Id = 2, Name = "Darnah", Latitude = "32.76704000", Longitude = "22.63669000" }
                    }
                },

                new()
                {
                    Id = 4,
                    Name = "Ghat",
                    StateCode = "GT",
                    Latitude = "24.96403710",
                    Longitude = "10.17592850",
                    Type = "popularate",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Ghat", Latitude = "24.96334000", Longitude = "10.18003000" }
                    }
                },

                new()
                {
                    Id = 5,
                    Name = "Jabal al Akhdar",
                    StateCode = "JA",
                    Latitude = "23.18560810",
                    Longitude = "57.37138790",
                    Type = "popularate",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Al Bayḑā’", Latitude = "32.76272000", Longitude = "21.75506000" }
                    }
                },

                new()
                {
                    Id = 6,
                    Name = "Jabal al Gharbi",
                    StateCode = "JG",
                    Latitude = "30.26380320",
                    Longitude = "12.80547530",
                    Type = "popularate",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Gharyan", Latitude = "32.17222000", Longitude = "13.02028000" },
                        new() { Id = 2, Name = "Giado", Latitude = "31.95506000", Longitude = "12.02901000" },
                        new() { Id = 3, Name = "Mizdah", Latitude = "31.44934000", Longitude = "12.98530000" },
                        new() { Id = 4, Name = "Yafran", Latitude = "32.06329000", Longitude = "12.52859000" },
                        new() { Id = 5, Name = "Zintan", Latitude = "31.93155000", Longitude = "12.25291000" }
                    }
                },

                new()
                {
                    Id = 7,
                    Name = "Jafara",
                    StateCode = "JI",
                    Latitude = "32.45259040",
                    Longitude = "12.94355360",
                    Type = "popularate",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Al ‘Azīzīyah", Latitude = "32.53194000", Longitude = "13.01750000" }
                    }
                },

                new()
                {
                    Id = 8,
                    Name = "Jufra",
                    StateCode = "JU",
                    Latitude = "27.98351350",
                    Longitude = "16.91225100",
                    Type = "popularate",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Hūn", Latitude = "29.12684000", Longitude = "15.94772000" },
                        new() { Id = 2, Name = "Waddān", Latitude = "29.16140000", Longitude = "16.13904000" }
                    }
                },

                new()
                {
                    Id = 9,
                    Name = "Kufra",
                    StateCode = "KF",
                    Latitude = "23.31123890",
                    Longitude = "21.85685860",
                    Type = "popularate",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Al Jawf", Latitude = "24.19890000", Longitude = "23.29093000" },
                        new() { Id = 2, Name = "At Tāj", Latitude = "24.20487000", Longitude = "23.28570000" }
                    }
                },

                new()
                {
                    Id = 10,
                    Name = "Marj",
                    StateCode = "MJ",
                    Latitude = "32.05503630",
                    Longitude = "21.18911510",
                    Type = "popularate",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Al Abyār", Latitude = "32.19000000", Longitude = "20.59653000" },
                        new() { Id = 2, Name = "Al Marj", Latitude = "32.49257000", Longitude = "20.82909000" },
                        new() { Id = 3, Name = "Tūkrah", Latitude = "32.53414000", Longitude = "20.57911000" }
                    }
                },

                new()
                {
                    Id = 11,
                    Name = "Misrata",
                    StateCode = "MI",
                    Latitude = "32.32558840",
                    Longitude = "15.09925560",
                    Type = "popularate",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Bani Walid", Latitude = "31.74554000", Longitude = "13.98354000" },
                        new() { Id = 2, Name = "Mişrātah", Latitude = "32.37535000", Longitude = "15.09254000" },
                        new() { Id = 3, Name = "Zliten", Latitude = "32.46739000", Longitude = "14.56874000" }
                    }
                },

                new()
                {
                    Id = 12,
                    Name = "Murqub",
                    StateCode = "MB",
                    Latitude = "32.45996770",
                    Longitude = "14.10013260",
                    Type = "popularate",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Al Khums", Latitude = "32.64861000", Longitude = "14.26191000" },
                        new() { Id = 2, Name = "Masallātah", Latitude = "32.61667000", Longitude = "14.00000000" },
                        new() { Id = 3, Name = "Tarhuna", Latitude = "32.43501000", Longitude = "13.63320000" }
                    }
                },

                new()
                {
                    Id = 13,
                    Name = "Murzuq",
                    StateCode = "MQ",
                    Latitude = "25.91822620",
                    Longitude = "13.92600010",
                    Type = "popularate",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Al Qaţrūn", Latitude = "24.95139000", Longitude = "14.64861000" },
                        new() { Id = 2, Name = "Murzuq", Latitude = "25.91552000", Longitude = "13.91839000" }
                    }
                },

                new()
                {
                    Id = 14,
                    Name = "Nalut",
                    StateCode = "NL",
                    Latitude = "31.87423480",
                    Longitude = "10.97504840",
                    Type = "popularate",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Ghadāmis", Latitude = "30.13366000", Longitude = "9.50072000" },
                        new() { Id = 2, Name = "Nālūt", Latitude = "31.86848000", Longitude = "10.98120000" }
                    }
                },

                new()
                {
                    Id = 15,
                    Name = "Nuqat al Khams",
                    StateCode = "NQ",
                    Latitude = "32.69149090",
                    Longitude = "11.88917210",
                    Type = "popularate",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Al Ajaylat", Latitude = "32.75718000", Longitude = "12.37633000" },
                        new() { Id = 2, Name = "Zalţan", Latitude = "32.94699000", Longitude = "11.86668000" },
                        new() { Id = 3, Name = "Zuwārah", Latitude = "32.93120000", Longitude = "12.08199000" }
                    }
                },

                new()
                {
                    Id = 16,
                    Name = "Sabha",
                    StateCode = "SB",
                    Latitude = "27.03654060",
                    Longitude = "14.42902360",
                    Type = "popularate",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Al Jadīd", Latitude = "27.05000000", Longitude = "14.40000000" },
                        new() { Id = 2, Name = "Sabhā", Latitude = "27.03766000", Longitude = "14.42832000" }
                    }
                },

                new()
                {
                    Id = 17,
                    Name = "Sirte",
                    StateCode = "SR",
                    Latitude = "31.18968900",
                    Longitude = "16.57019270",
                    Type = "popularate",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Qasr Abu Hadi", Latitude = "31.05926000", Longitude = "16.65905000" },
                        new() { Id = 2, Name = "Sirte", Latitude = "31.20892000", Longitude = "16.58866000" }
                    }
                },

                new()
                {
                    Id = 18,
                    Name = "Tripoli",
                    StateCode = "TB",
                    Latitude = "32.64080210",
                    Longitude = "13.26634790",
                    Type = "popularate",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Tagiura", Latitude = "32.88167000", Longitude = "13.35056000" },
                        new() { Id = 2, Name = "Tripoli", Latitude = "32.88743000", Longitude = "13.18733000" }
                    }
                },

                new()
                {
                    Id = 19,
                    Name = "Wadi al Hayaa",
                    StateCode = "WD",
                    Latitude = "26.42259260",
                    Longitude = "12.62162110",
                    Type = "popularate",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Ubari", Latitude = "26.59034000", Longitude = "12.77511000" }
                    }
                },

                new()
                {
                    Id = 20,
                    Name = "Wadi al Shatii",
                    StateCode = "WS",
                    Latitude = "27.73514680",
                    Longitude = "12.43805810",
                    Type = "popularate",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Brak", Latitude = "27.54956000", Longitude = "14.27139000" },
                        new() { Id = 2, Name = "Idrī", Latitude = "27.44707000", Longitude = "13.05173000" }
                    }
                },

                new()
                {
                    Id = 21,
                    Name = "Zawiya",
                    StateCode = "ZA",
                    Latitude = "32.76302820",
                    Longitude = "12.73649620",
                    Type = "popularate",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Az Zāwīyah", Latitude = "32.75710000", Longitude = "12.72764000" },
                        new() { Id = 2, Name = "Şabrātah", Latitude = "32.79335000", Longitude = "12.48845000" },
                        new() { Id = 3, Name = "Şurmān", Latitude = "32.75668000", Longitude = "12.57159000" },
                        new() { Id = 4, Name = "Zawiya", Latitude = "32.75222000", Longitude = "12.72778000" }
                    }
                }
            }
        };
    }
}
