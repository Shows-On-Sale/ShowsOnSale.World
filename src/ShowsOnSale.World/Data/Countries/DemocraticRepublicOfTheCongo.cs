// ⚠️ WARNING: This file is automatically generated by scripts/generate-world.ps1
// DO NOT modify this file manually as it will be overwritten when the script is run again.
// To update the data, modify the source data in countries-states-cities-database and run the script.

using System.Collections.Generic;
using ShowsOnSale.World.Models;

namespace ShowsOnSale.World.Data.Countries
{
    public static class DemocraticRepublicOfTheCongo
    {
        public static Country Data { get; } = new()
        {
            Id = 59,
            Name = "Democratic Republic of the Congo",
            Iso3 = "COD",
            Iso2 = "CD",
            NumericCode = "180",
            PhoneCode = "243",
            Capital = "Kinshasa",
            Currency = "CDF",
            CurrencyName = "Congolese Franc",
            CurrencySymbol = "FC",
            Tld = ".cd",
            Native = "République démocratique du Congo",
            Region = "Africa",
            RegionId = 1,
            Subregion = "Middle Africa",
            SubregionId = 2,
            Nationality = "Congolese",
            Latitude = "0.00000000",
            Longitude = "25.00000000",
            Emoji = "🇨🇩",
            EmojiU = "U+1F1E8 U+1F1E9",
            Timezones = new()
            {
                new() { ZoneName = "Africa/Kinshasa", GmtOffset = 3600, GmtOffsetName = "UTC+01:00", Abbreviation = "WAT", TzName = "West Africa Time" },
                new() { ZoneName = "Africa/Lubumbashi", GmtOffset = 7200, GmtOffsetName = "UTC+02:00", Abbreviation = "CAT", TzName = "Central Africa Time" }
            },
            Translations = new()
            {
                ["ko"] = "콩고 민주 공화국",
                ["pt-BR"] = "RD Congo",
                ["pt"] = "RD Congo",
                ["nl"] = "Congo [DRC]",
                ["hr"] = "Kongo, Demokratska Republika",
                ["fa"] = "جمهوری کنگو",
                ["de"] = "Kongo (Dem. Rep.)",
                ["es"] = "Congo (Rep. Dem.)",
                ["fr"] = "Congo (Rép. dém.)",
                ["ja"] = "コンゴ民主共和国",
                ["it"] = "Congo (Rep. Dem.)",
                ["zh-CN"] = "刚果（金）",
                ["tr"] = "Kongo Demokratik Cumhuriyeti",
                ["ru"] = "Демократическая Республика Конго",
                ["uk"] = "Демократична Республіка Конго",
                ["pl"] = "Demokratyczna Republika Konga"
            },
            States = new()
            {

                new()
                {
                    Id = 1,
                    Name = "Bas-Uélé",
                    StateCode = "BU",
                    Latitude = "3.99010090",
                    Longitude = "24.90422080",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Aketi", Latitude = "2.73877000", Longitude = "23.78326000" },
                        new() { Id = 2, Name = "Bondo", Latitude = "3.81461000", Longitude = "23.68665000" },
                        new() { Id = 3, Name = "Buta", Latitude = "2.78582000", Longitude = "24.72997000" }
                    }
                },

                new()
                {
                    Id = 2,
                    Name = "Équateur",
                    StateCode = "EQ",
                    Latitude = "-1.83123900",
                    Longitude = "-78.18340600",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Gemena", Latitude = "3.25651000", Longitude = "19.77234000" },
                        new() { Id = 2, Name = "Lisala", Latitude = "2.15127000", Longitude = "21.51672000" },
                        new() { Id = 3, Name = "Lukolela", Latitude = "-1.06046000", Longitude = "17.18210000" },
                        new() { Id = 4, Name = "Mbandaka", Latitude = "0.04865000", Longitude = "18.26034000" }
                    }
                },

                new()
                {
                    Id = 3,
                    Name = "Haut-Katanga",
                    StateCode = "HK",
                    Latitude = "-10.41020750",
                    Longitude = "27.54958460",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Likasi", Latitude = "-10.98303000", Longitude = "26.73840000" },
                        new() { Id = 2, Name = "Lubumbashi", Latitude = "-11.66089000", Longitude = "27.47938000" }
                    }
                },

                new()
                {
                    Id = 4,
                    Name = "Haut-Lomami",
                    StateCode = "HL",
                    Latitude = "-7.70527520",
                    Longitude = "24.90422080",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Bukama", Latitude = "-9.20443000", Longitude = "25.85475000" },
                        new() { Id = 2, Name = "Kamina", Latitude = "-8.73508000", Longitude = "24.99798000" }
                    }
                },

                new()
                {
                    Id = 5,
                    Name = "Haut-Uélé",
                    StateCode = "HU",
                    Latitude = "3.58451540",
                    Longitude = "28.29943500",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Isiro", Latitude = "2.77391000", Longitude = "27.61603000" },
                        new() { Id = 2, Name = "Wamba", Latitude = "2.14838000", Longitude = "27.99466000" },
                        new() { Id = 3, Name = "Watsa", Latitude = "3.03716000", Longitude = "29.53551000" }
                    }
                },

                new()
                {
                    Id = 6,
                    Name = "Ituri",
                    StateCode = "IT",
                    Latitude = "1.59576820",
                    Longitude = "29.41793240",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Bunia", Latitude = "1.55941000", Longitude = "30.25224000" }
                    }
                },

                new()
                {
                    Id = 7,
                    Name = "Kasaï",
                    StateCode = "KS",
                    Latitude = "-5.04719790",
                    Longitude = "20.71224650",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Ilebo", Latitude = "-4.33111000", Longitude = "20.58638000" },
                        new() { Id = 2, Name = "Luebo", Latitude = "-5.35218000", Longitude = "21.42192000" },
                        new() { Id = 3, Name = "Mweka", Latitude = "-4.85187000", Longitude = "21.55950000" },
                        new() { Id = 4, Name = "Tshikapa", Latitude = "-6.41621000", Longitude = "20.79995000" }
                    }
                },

                new()
                {
                    Id = 8,
                    Name = "Kasaï Central",
                    StateCode = "KC",
                    Latitude = "-8.44045910",
                    Longitude = "20.41659340",
                    Type = "province",
                    Cities = new()
                    {
                    }
                },

                new()
                {
                    Id = 9,
                    Name = "Kasaï Oriental",
                    StateCode = "KE",
                    Latitude = "-6.03362300",
                    Longitude = "23.57285010",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Gandajika", Latitude = "-6.74504000", Longitude = "23.95328000" },
                        new() { Id = 2, Name = "Kabinda", Latitude = "-6.13791000", Longitude = "24.48179000" },
                        new() { Id = 3, Name = "Mbuji-Mayi", Latitude = "-6.13603000", Longitude = "23.58979000" }
                    }
                },

                new()
                {
                    Id = 10,
                    Name = "Kinshasa",
                    StateCode = "KN",
                    Latitude = "-4.44193110",
                    Longitude = "15.26629310",
                    Type = "city",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Kinshasa", Latitude = "-4.32758000", Longitude = "15.31357000" }
                    }
                },

                new()
                {
                    Id = 11,
                    Name = "Kongo Central",
                    StateCode = "BC",
                    Latitude = "-5.23656850",
                    Longitude = "13.91439900",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Boma", Latitude = "-5.85098000", Longitude = "13.05364000" },
                        new() { Id = 2, Name = "Kasangulu", Latitude = "-4.58330000", Longitude = "15.16554000" },
                        new() { Id = 3, Name = "Matadi", Latitude = "-5.83861000", Longitude = "13.46306000" },
                        new() { Id = 4, Name = "Mbanza-Ngungu", Latitude = "-5.25837000", Longitude = "14.85838000" },
                        new() { Id = 5, Name = "Moanda", Latitude = "-5.92753000", Longitude = "12.37148000" },
                        new() { Id = 6, Name = "Tshela", Latitude = "-4.99707000", Longitude = "12.94840000" }
                    }
                },

                new()
                {
                    Id = 12,
                    Name = "Kwango",
                    StateCode = "KG",
                    Latitude = "-6.43374090",
                    Longitude = "17.66888700",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Kasongo-Lunda", Latitude = "-6.47833000", Longitude = "16.81735000" }
                    }
                },

                new()
                {
                    Id = 13,
                    Name = "Kwilu",
                    StateCode = "KL",
                    Latitude = "-5.11888250",
                    Longitude = "18.42760470",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Bandundu", Latitude = "-3.31687000", Longitude = "17.38063000" },
                        new() { Id = 2, Name = "Bulungu", Latitude = "-4.54437000", Longitude = "18.60364000" },
                        new() { Id = 3, Name = "Kikwit", Latitude = "-5.04098000", Longitude = "18.81619000" },
                        new() { Id = 4, Name = "Mangai", Latitude = "-4.02328000", Longitude = "19.53385000" }
                    }
                },

                new()
                {
                    Id = 14,
                    Name = "Lomami",
                    StateCode = "LO",
                    Latitude = "-6.14539310",
                    Longitude = "24.52426400",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Lubao", Latitude = "-5.38771000", Longitude = "25.74885000" },
                        new() { Id = 2, Name = "Mwene-Ditu", Latitude = "-7.00906000", Longitude = "23.45278000" }
                    }
                },

                new()
                {
                    Id = 15,
                    Name = "Lualaba",
                    StateCode = "LU",
                    Latitude = "-10.48086980",
                    Longitude = "25.62978160",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Kasaji", Latitude = "-10.38342000", Longitude = "23.44987000" },
                        new() { Id = 2, Name = "Kolwezi", Latitude = "-10.71666700", Longitude = "25.46666700" }
                    }
                },

                new()
                {
                    Id = 16,
                    Name = "Mai-Ndombe",
                    StateCode = "MN",
                    Latitude = "-2.63574340",
                    Longitude = "18.42760470",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Bolobo", Latitude = "-2.15800000", Longitude = "16.23249000" },
                        new() { Id = 2, Name = "Inongo", Latitude = "-1.92750000", Longitude = "18.28810000" },
                        new() { Id = 3, Name = "Mushie", Latitude = "-3.01728000", Longitude = "16.92238000" },
                        new() { Id = 4, Name = "Nioki", Latitude = "-2.72037000", Longitude = "17.69001000" }
                    }
                },

                new()
                {
                    Id = 17,
                    Name = "Maniema",
                    StateCode = "MA",
                    Latitude = "-3.07309290",
                    Longitude = "26.04138890",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Kampene", Latitude = "-3.59678000", Longitude = "26.66715000" },
                        new() { Id = 2, Name = "Kasongo", Latitude = "-4.42741000", Longitude = "26.66656000" },
                        new() { Id = 3, Name = "Kindu", Latitude = "-2.94373000", Longitude = "25.92237000" }
                    }
                },

                new()
                {
                    Id = 18,
                    Name = "Mongala",
                    StateCode = "MO",
                    Latitude = "1.99623240",
                    Longitude = "21.47528510",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Bumba", Latitude = "2.18771000", Longitude = "22.46827000" }
                    }
                },

                new()
                {
                    Id = 19,
                    Name = "Nord-Kivu",
                    StateCode = "NK",
                    Latitude = "-0.79177290",
                    Longitude = "29.04599270",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Beni", Latitude = "0.49113000", Longitude = "29.47306000" },
                        new() { Id = 2, Name = "Butembo", Latitude = "0.14164000", Longitude = "29.29117000" },
                        new() { Id = 3, Name = "Goma", Latitude = "-1.67409000", Longitude = "29.22845000" },
                        new() { Id = 4, Name = "Sake", Latitude = "-1.57386000", Longitude = "29.04339000" }
                    }
                },

                new()
                {
                    Id = 20,
                    Name = "Nord-Ubangi",
                    StateCode = "NU",
                    Latitude = "3.78787260",
                    Longitude = "21.47528510",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Bosobolo", Latitude = "4.18980000", Longitude = "19.88330000" },
                        new() { Id = 2, Name = "Businga", Latitude = "3.33863000", Longitude = "20.88577000" },
                        new() { Id = 3, Name = "Gbadolite", Latitude = "4.27900000", Longitude = "21.00284000" }
                    }
                },

                new()
                {
                    Id = 21,
                    Name = "Sankuru",
                    StateCode = "SA",
                    Latitude = "-2.84374530",
                    Longitude = "23.38235450",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Lodja", Latitude = "-3.52105000", Longitude = "23.60050000" },
                        new() { Id = 2, Name = "Lusambo", Latitude = "-4.97503000", Longitude = "23.44391000" }
                    }
                },

                new()
                {
                    Id = 22,
                    Name = "Sud-Kivu",
                    StateCode = "SK",
                    Latitude = "-3.01165800",
                    Longitude = "28.29943500",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Bukavu", Latitude = "-2.49077000", Longitude = "28.84281000" },
                        new() { Id = 2, Name = "Kabare", Latitude = "-2.49682000", Longitude = "28.79081000" },
                        new() { Id = 3, Name = "Uvira", Latitude = "-3.39534000", Longitude = "29.13779000" }
                    }
                },

                new()
                {
                    Id = 23,
                    Name = "Sud-Ubangi",
                    StateCode = "SU",
                    Latitude = "3.22999420",
                    Longitude = "19.18800470",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Bongandanga", Latitude = "1.50695000", Longitude = "21.07260000" },
                        new() { Id = 2, Name = "Libenge", Latitude = "3.65332000", Longitude = "18.63566000" }
                    }
                },

                new()
                {
                    Id = 24,
                    Name = "Tanganyika",
                    StateCode = "TA",
                    Latitude = "-6.27401180",
                    Longitude = "27.92490020",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Kabalo", Latitude = "-6.05255000", Longitude = "26.91430000" },
                        new() { Id = 2, Name = "Kalemie", Latitude = "-5.94749000", Longitude = "29.19471000" },
                        new() { Id = 3, Name = "Kongolo", Latitude = "-5.38532000", Longitude = "27.00029000" }
                    }
                },

                new()
                {
                    Id = 25,
                    Name = "Tshopo",
                    StateCode = "TO",
                    Latitude = "0.54554620",
                    Longitude = "24.90422080",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Basoko", Latitude = "1.23909000", Longitude = "23.61598000" },
                        new() { Id = 2, Name = "Kisangani", Latitude = "0.51528000", Longitude = "25.19099000" },
                        new() { Id = 3, Name = "Yangambi", Latitude = "0.76755000", Longitude = "24.43973000" }
                    }
                },

                new()
                {
                    Id = 26,
                    Name = "Tshuapa",
                    StateCode = "TU",
                    Latitude = "-0.99030230",
                    Longitude = "23.02888440",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Boende", Latitude = "-0.28163000", Longitude = "20.88053000" }
                    }
                }
            }
        };
    }
}
