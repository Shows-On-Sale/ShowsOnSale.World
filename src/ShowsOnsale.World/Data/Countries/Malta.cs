// ⚠️ WARNING: This file is automatically generated by scripts/generate-world.ps1
// DO NOT modify this file manually as it will be overwritten when the script is run again.
// To update the data, modify the source data in countries-states-cities-database and run the script.

using System.Collections.Generic;
using ShowsOnSale.World.Models;

namespace ShowsOnSale.World.Data.Countries
{
    public static class Malta
    {
        public static Country Data { get; } = new()
        {
            Id = 133,
            Name = "Malta",
            Iso3 = "MLT",
            Iso2 = "MT",
            NumericCode = "470",
            PhoneCode = "356",
            Capital = "Valletta",
            Currency = "EUR",
            CurrencyName = "Euro",
            CurrencySymbol = "€",
            Tld = ".mt",
            Native = "Malta",
            Region = "Europe",
            RegionId = 4,
            Subregion = "Southern Europe",
            SubregionId = 16,
            Nationality = "Maltese",
            Latitude = "35.83333333",
            Longitude = "14.58333333",
            Emoji = "🇲🇹",
            EmojiU = "U+1F1F2 U+1F1F9",
            Timezones = new()
            {
                new() { ZoneName = "Europe/Malta", GmtOffset = 3600, GmtOffsetName = "UTC+01:00", Abbreviation = "CET", TzName = "Central European Time" }
            },
            Translations = new()
            {
                { "ko" = "몰타" },
                { "pt-BR" = "Malta" }
                { "pt" = "Malta" }
                { "nl" = "Malta" }
                { "hr" = "Malta" }
                { "fa" = "مالت" }
                { "de" = "Malta" }
                { "es" = "Malta" }
                { "fr" = "Malte" }
                { "ja" = "マルタ" }
                { "it" = "Malta" }
                { "zh-CN" = "马耳他" }
                { "tr" = "Malta" }
                { "ru" = "Мальта" }
                { "uk" = "Мальта" }
                { "pl" = "Malta" }
            },
            States = new()
            {

                new()
                {
                    Id = 1,
                    Name = "Attard",
                    StateCode = "01",
                    Latitude = "35.89049670",
                    Longitude = "14.41993220",
                    Type = "local council",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Attard", Latitude = "35.88972000", Longitude = "14.44250000" }
                    }
                },

                new()
                {
                    Id = 2,
                    Name = "Balzan",
                    StateCode = "02",
                    Latitude = "35.89574140",
                    Longitude = "14.45340650",
                    Type = "local council",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Balzan", Latitude = "35.90028000", Longitude = "14.45500000" }
                    }
                },

                new()
                {
                    Id = 3,
                    Name = "Birgu",
                    StateCode = "03",
                    Latitude = "35.88792140",
                    Longitude = "14.52256200",
                    Type = "local council",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Birgu (Vittoriosa)", Latitude = "35.89222000", Longitude = "14.51833000" }
                    }
                },

                new()
                {
                    Id = 4,
                    Name = "Birkirkara",
                    StateCode = "04",
                    Latitude = "35.89547060",
                    Longitude = "14.46650720",
                    Type = "local council",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Birkirkara", Latitude = "35.89722000", Longitude = "14.46111000" },
                        new() { Id = 2, Name = "Fleur De Lys", Latitude = "35.89530000", Longitude = "14.46560000" },
                        new() { Id = 3, Name = "Swatar", Latitude = "35.89877800", Longitude = "14.47659200" }
                    }
                },

                new()
                {
                    Id = 5,
                    Name = "Birżebbuġa",
                    StateCode = "05",
                    Latitude = "35.81359890",
                    Longitude = "14.52474630",
                    Type = "local council",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Birżebbuġa", Latitude = "35.82583000", Longitude = "14.52694000" },
                        new() { Id = 2, Name = "Ħal Far", Latitude = "35.81134900", Longitude = "14.51068600" }
                    }
                },

                new()
                {
                    Id = 6,
                    Name = "Cospicua",
                    StateCode = "06",
                    Latitude = "35.88067530",
                    Longitude = "14.52183380",
                    Type = "local council",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Cospicua", Latitude = "35.88556000", Longitude = "14.52750000" }
                    }
                },

                new()
                {
                    Id = 7,
                    Name = "Dingli",
                    StateCode = "07",
                    Latitude = "35.86273090",
                    Longitude = "14.38501070",
                    Type = "local council",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Dingli", Latitude = "35.86139000", Longitude = "14.38222000" }
                    }
                }

                new()
                {
                    Id = 8,
                    Name = "Fgura",
                    StateCode = "08",
                    Latitude = "35.87382690",
                    Longitude = "14.52329010",
                    Type = "local council",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Fgura", Latitude = "35.87028000", Longitude = "14.51333000" }
                    }
                }

                new()
                {
                    Id = 9,
                    Name = "Floriana",
                    StateCode = "09",
                    Latitude = "45.49521850",
                    Longitude = "-73.71395760",
                    Type = "local council",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Floriana", Latitude = "35.89583000", Longitude = "14.50833000" }
                    }
                }

                new()
                {
                    Id = 10,
                    Name = "Fontana",
                    StateCode = "10",
                    Latitude = "34.09223350",
                    Longitude = "-117.43504800",
                    Type = "local council",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Fontana", Latitude = "36.03750000", Longitude = "14.23611000" }
                    }
                },

                new()
                {
                    Id = 11,
                    Name = "Għajnsielem",
                    StateCode = "13",
                    Latitude = "36.02479660",
                    Longitude = "14.28029610",
                    Type = "local council",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Għajnsielem", Latitude = "36.02639000", Longitude = "14.28500000" },
                        new() { Id = 2, Name = "Ħal Għargħur", Latitude = "35.92409000", Longitude = "14.45118000" }
                    }
                },

                new()
                {
                    Id = 12,
                    Name = "Għarb",
                    StateCode = "14",
                    Latitude = "36.06890900",
                    Longitude = "14.20180980",
                    Type = "local council",
                    Cities = new()
                    {
                    }
                },

                new()
                {
                    Id = 13,
                    Name = "Għargħur",
                    StateCode = "15",
                    Latitude = "35.92205690",
                    Longitude = "14.45631760",
                    Type = "local council",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Ħal Għaxaq", Latitude = "35.84889000", Longitude = "14.51667000" }
                    }
                },

                new()
                {
                    Id = 14,
                    Name = "Għasri",
                    StateCode = "16",
                    Latitude = "36.06680750",
                    Longitude = "14.21924750",
                    Type = "local council",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Gudja", Latitude = "35.84917000", Longitude = "14.50306000" }
                    }
                },

                new()
                {
                    Id = 15,
                    Name = "Għaxaq",
                    StateCode = "17",
                    Latitude = "35.84403590",
                    Longitude = "14.51600900",
                    Type = "local council",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Gżira", Latitude = "35.90583000", Longitude = "14.48806000" }
                    }
                },

                new()
                {
                    Id = 16,
                    Name = "Gudja",
                    StateCode = "11",
                    Latitude = "35.84698030",
                    Longitude = "14.50290400",
                    Type = "local council",
                    Cities = new()
                    {
                    }
                },

                new()
                {
                    Id = 17,
                    Name = "Gżira",
                    StateCode = "12",
                    Latitude = "35.90589700",
                    Longitude = "14.49533380",
                    Type = "local council",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Għarb", Latitude = "36.06000000", Longitude = "14.20889000" }
                    }
                },

                new()
                {
                    Id = 18,
                    Name = "Ħamrun",
                    StateCode = "18",
                    Latitude = "35.88612370",
                    Longitude = "14.48834420",
                    Type = "local council",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Blata l' Bajda", Latitude = "35.88750000", Longitude = "14.49861100" },
                        new() { Id = 2, Name = "Ħamrun", Latitude = "35.88472000", Longitude = "14.48444000" }
                    }
                },

                new()
                {
                    Id = 19,
                    Name = "Iklin",
                    StateCode = "19",
                    Latitude = "35.90987740",
                    Longitude = "14.45777320",
                    Type = "local council",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "L-Iklin", Latitude = "35.90414000", Longitude = "14.45415000" }
                    }
                },

                new()
                {
                    Id = 20,
                    Name = "Kalkara",
                    StateCode = "21",
                    Latitude = "35.89142420",
                    Longitude = "14.53202780",
                    Type = "local council",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Imġarr", Latitude = "35.92056000", Longitude = "14.36639000" },
                        new() { Id = 2, Name = "Mġarr", Latitude = "36.02528000", Longitude = "14.29500000" }
                    }
                },

                new()
                {
                    Id = 21,
                    Name = "Kerċem",
                    StateCode = "22",
                    Latitude = "36.04479390",
                    Longitude = "14.22506050",
                    Type = "local council",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Mqabba", Latitude = "35.84763000", Longitude = "14.46824000" }
                    }
                },

                new()
                {
                    Id = 22,
                    Name = "Kirkop",
                    StateCode = "23",
                    Latitude = "35.84378620",
                    Longitude = "14.48543240",
                    Type = "local council",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Imsida", Latitude = "35.89250000", Longitude = "14.48278000" },
                        new() { Id = 2, Name = "Kirkop", Latitude = "35.84222000", Longitude = "14.48528000" }
                    }
                },

                new()
                {
                    Id = 23,
                    Name = "Lija",
                    StateCode = "24",
                    Latitude = "49.18007600",
                    Longitude = "-123.10331700",
                    Type = "local council",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Ħal Lija", Latitude = "35.90056000", Longitude = "14.44639000" },
                        new() { Id = 2, Name = "Imtarfa", Latitude = "35.89333000", Longitude = "14.39889000" }
                    }
                },

                new()
                {
                    Id = 24,
                    Name = "Luqa",
                    StateCode = "25",
                    Latitude = "35.85828650",
                    Longitude = "14.48688830",
                    Type = "local council",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Ħal Luqa", Latitude = "35.85889000", Longitude = "14.48861000" },
                        new() { Id = 2, Name = "Ħal Safi", Latitude = "35.83333300", Longitude = "14.48500000" },
                        new() { Id = 3, Name = "Senglea", Latitude = "35.88750000", Longitude = "14.51694000" }
                    }
                },

                new()
                {
                    Id = 25,
                    Name = "Marsa",
                    StateCode = "26",
                    Latitude = "34.03195870",
                    Longitude = "-118.44555350",
                    Type = "local council",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Kalkara", Latitude = "35.88917000", Longitude = "14.53278000" }
                    }
                },

                new()
                {
                    Id = 26,
                    Name = "Marsaskala",
                    StateCode = "27",
                    Latitude = "35.86036400",
                    Longitude = "14.55678760",
                    Type = "local council",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Kerċem", Latitude = "36.04194000", Longitude = "14.22667000" },
                        new() { Id = 2, Name = "Marsaskala", Latitude = "35.86220000", Longitude = "14.56701000" }
                    }
                },

                new()
                {
                    Id = 27,
                    Name = "Marsaxlokk",
                    StateCode = "28",
                    Latitude = "35.84116990",
                    Longitude = "14.53930970",
                    Type = "local council",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Marsaxlokk", Latitude = "35.84194000", Longitude = "14.54306000" }
                    }
                },

                new()
                {
                    Id = 28,
                    Name = "Mdina",
                    StateCode = "29",
                    Latitude = "35.88809300",
                    Longitude = "14.40683570",
                    Type = "local council",
                    Cities = new()
                    {
                    }
                },

                new()
                {
                    Id = 29,
                    Name = "Mellieħa",
                    StateCode = "30",
                    Latitude = "35.95235290",
                    Longitude = "14.35009750",
                    Type = "local council",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Manikata", Latitude = "35.94000000", Longitude = "14.35333000" }
                    }
                },

                new()
                {
                    Id = 30,
                    Name = "Mġarr",
                    StateCode = "31",
                    Latitude = "35.91893270",
                    Longitude = "14.36173430",
                    Type = "local council",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Marsa", Latitude = "35.87917000", Longitude = "14.49528000" }
                    }
                },

                new()
                {
                    Id = 31,
                    Name = "Mosta",
                    StateCode = "32",
                    Latitude = "35.91415040",
                    Longitude = "14.42284270",
                    Type = "local council",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Bidnija", Latitude = "35.92694400", Longitude = "14.39833300" }
                    }
                },

                new()
                {
                    Id = 32,
                    Name = "Mqabba",
                    StateCode = "33",
                    Latitude = "35.84441430",
                    Longitude = "14.46941860",
                    Type = "local council",
                    Cities = new()
                    {
                    }
                },

                new()
                {
                    Id = 33,
                    Name = "Msida",
                    StateCode = "34",
                    Latitude = "35.89563880",
                    Longitude = "14.48688830",
                    Type = "local council",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Mellieħa", Latitude = "35.95639000", Longitude = "14.36222000" }
                    }
                },

                new()
                {
                    Id = 34,
                    Name = "Mtarfa",
                    StateCode = "35",
                    Latitude = "35.88951250",
                    Longitude = "14.39519530",
                    Type = "local council",
                    Cities = new()
                    {
                    }
                },

                new()
                {
                    Id = 35,
                    Name = "Munxar",
                    StateCode = "36",
                    Latitude = "36.02880580",
                    Longitude = "14.22506050",
                    Type = "local council",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Munxar", Latitude = "36.03000000", Longitude = "14.23333000" }
                    }
                },

                new()
                {
                    Id = 36,
                    Name = "Nadur",
                    StateCode = "37",
                    Latitude = "36.04470190",
                    Longitude = "14.29192730",
                    Type = "local council",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Nadur", Latitude = "36.03778000", Longitude = "14.29417000" }
                    }
                },

                new()
                {
                    Id = 37,
                    Name = "Naxxar",
                    StateCode = "38",
                    Latitude = "35.93175180",
                    Longitude = "14.43157460",
                    Type = "local council",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Baħar iċ-Ċagħaq", Latitude = "35.93878700", Longitude = "14.45372500" },
                        new() { Id = 2, Name = "Magħtab", Latitude = "35.94500000", Longitude = "14.44000000" },
                        new() { Id = 3, Name = "Naxxar", Latitude = "35.91361000", Longitude = "14.44361000" },
                        new() { Id = 4, Name = "Salina", Latitude = "35.94555600", Longitude = "14.42444400" }
                    }
                },

                new()
                {
                    Id = 38,
                    Name = "Paola",
                    StateCode = "39",
                    Latitude = "38.57223530",
                    Longitude = "-94.87912940",
                    Type = "local council",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Paola", Latitude = "35.87306000", Longitude = "14.49889000" }
                    }
                },

                new()
                {
                    Id = 39,
                    Name = "Pembroke",
                    StateCode = "40",
                    Latitude = "34.68016260",
                    Longitude = "-79.19503730",
                    Type = "local council",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Pembroke", Latitude = "35.93056000", Longitude = "14.47639000" }
                    }
                },

                new()
                {
                    Id = 40,
                    Name = "Pietà",
                    StateCode = "41",
                    Latitude = "42.21862000",
                    Longitude = "-83.73464700",
                    Type = "local council",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Pietà", Latitude = "35.89472000", Longitude = "14.49500000" }
                    }
                },

                new()
                {
                    Id = 41,
                    Name = "Qala",
                    StateCode = "42",
                    Latitude = "36.03886280",
                    Longitude = "14.31810100",
                    Type = "local council",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Qala", Latitude = "36.03611000", Longitude = "14.30944000" }
                    }
                },

                new()
                {
                    Id = 42,
                    Name = "Qormi",
                    StateCode = "43",
                    Latitude = "35.87643880",
                    Longitude = "14.46941860",
                    Type = "local council",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Qormi", Latitude = "35.87601000", Longitude = "14.47200000" }
                    }
                },

                new()
                {
                    Id = 43,
                    Name = "Qrendi",
                    StateCode = "44",
                    Latitude = "35.83284880",
                    Longitude = "14.45486210",
                    Type = "local council",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Qrendi", Latitude = "35.83472000", Longitude = "14.45833000" }
                    }
                },

                new()
                {
                    Id = 44,
                    Name = "Rabat",
                    StateCode = "46",
                    Latitude = "33.97159040",
                    Longitude = "-6.84981290",
                    Type = "local council",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Baħrija", Latitude = "35.89472200", Longitude = "14.34833300" },
                        new() { Id = 2, Name = "Binġemma", Latitude = "35.90277800", Longitude = "14.37777800" }
                    }
                },

                new()
                {
                    Id = 45,
                    Name = "San Ġwann",
                    StateCode = "49",
                    Latitude = "35.90773650",
                    Longitude = "14.47524160",
                    Type = "local council",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "San Ġiljan (St. Julian's)", Latitude = "35.91839000", Longitude = "14.48977000" }
                    }
                },

                new()
                {
                    Id = 46,
                    Name = "San Lawrenz",
                    StateCode = "50",
                    Latitude = "38.95780560",
                    Longitude = "-95.25656890",
                    Type = "local council",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "San Lawrenz", Latitude = "36.05556000", Longitude = "14.20361000" }
                    }
                },

                new()
                {
                    Id = 47,
                    Name = "Sannat",
                    StateCode = "52",
                    Latitude = "36.01926430",
                    Longitude = "14.25994370",
                    Type = "local council",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "San Pawl il-Baħar", Latitude = "35.95064000", Longitude = "14.41561000" },
                        new() { Id = 2, Name = "Sannat", Latitude = "36.02444000", Longitude = "14.24278000" }
                    }
                },

                new()
                {
                    Id = 48,
                    Name = "Santa Luċija",
                    StateCode = "53",
                    Latitude = "35.85614200",
                    Longitude = "14.50436000",
                    Type = "local council",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Santa Venera", Latitude = "35.89083000", Longitude = "14.47417000" }
                    }
                },

                new()
                {
                    Id = 49,
                    Name = "Santa Venera",
                    StateCode = "54",
                    Latitude = "35.89022010",
                    Longitude = "14.47669740",
                    Type = "local council",
                    Cities = new()
                    {
                    }
                },

                new()
                {
                    Id = 50,
                    Name = "Senglea",
                    StateCode = "20",
                    Latitude = "35.88730410",
                    Longitude = "14.51673710",
                    Type = "local council",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Imdina", Latitude = "35.88694000", Longitude = "14.40250000" }
                    }
                },

                new()
                {
                    Id = 51,
                    Name = "Siġġiewi",
                    StateCode = "55",
                    Latitude = "35.84637420",
                    Longitude = "14.43157460",
                    Type = "local council",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Siġġiewi", Latitude = "35.85556000", Longitude = "14.43639000" }
                    }
                },

                new()
                {
                    Id = 52,
                    Name = "Sliema",
                    StateCode = "56",
                    Latitude = "35.91100810",
                    Longitude = "14.50290400",
                    Type = "local council",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Sliema", Latitude = "35.91250000", Longitude = "14.50194000" }
                    }
                },

                new()
                {
                    Id = 53,
                    Name = "St. Julian's",
                    StateCode = "48",
                    Latitude = "42.21225130",
                    Longitude = "-85.89171270",
                    Type = "local council",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Paceville", Latitude = "35.92370000", Longitude = "14.49140000" },
                        new() { Id = 2, Name = "San Ġwann", Latitude = "35.90556000", Longitude = "14.47611000" }
                    }
                },

                new()
                {
                    Id = 54,
                    Name = "St. Paul's Bay",
                    StateCode = "51",
                    Latitude = "35.93601700",
                    Longitude = "14.39665030",
                    Type = "local council",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Buġibba", Latitude = "35.94916700", Longitude = "14.41166700" },
                        new() { Id = 2, Name = "Burmarrad", Latitude = "35.93490000", Longitude = "14.41430000" },
                        new() { Id = 3, Name = "Mosta", Latitude = "35.90917000", Longitude = "14.42556000" },
                        new() { Id = 4, Name = "Qawra", Latitude = "35.95416700", Longitude = "14.42000000" },
                        new() { Id = 5, Name = "Santa Luċija", Latitude = "36.04306000", Longitude = "14.21722000" },
                        new() { Id = 6, Name = "Santa Luċija, Gozo", Latitude = "35.86278000", Longitude = "14.50750000" },
                        new() { Id = 7, Name = "Wardija", Latitude = "35.93795800", Longitude = "14.39254200" },
                        new() { Id = 8, Name = "Xemxija", Latitude = "35.95055600", Longitude = "14.38583300" }
                    }
                },

                new()
                {
                    Id = 55,
                    Name = "Swieqi",
                    StateCode = "57",
                    Latitude = "35.91911820",
                    Longitude = "14.46941860",
                    Type = "local council",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Madliena", Latitude = "35.93333300", Longitude = "14.46666700" },
                        new() { Id = 2, Name = "Swieqi", Latitude = "35.92250000", Longitude = "14.48000000" }
                    }
                },

                new()
                {
                    Id = 56,
                    Name = "Ta' Xbiex",
                    StateCode = "58",
                    Latitude = "35.89914480",
                    Longitude = "14.49635190",
                    Type = "local council",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Ta’ Xbiex", Latitude = "35.89917000", Longitude = "14.49444000" }
                    }
                },

                new()
                {
                    Id = 57,
                    Name = "Tarxien",
                    StateCode = "59",
                    Latitude = "35.86725520",
                    Longitude = "14.51164050",
                    Type = "local council",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Ħal Tarxien", Latitude = "35.86583000", Longitude = "14.51500000" }
                    }
                },

                new()
                {
                    Id = 58,
                    Name = "Valletta",
                    StateCode = "60",
                    Latitude = "35.89890850",
                    Longitude = "14.51455280",
                    Type = "local council",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Valletta", Latitude = "35.89972000", Longitude = "14.51472000" }
                    }
                },

                new()
                {
                    Id = 59,
                    Name = "Victoria",
                    StateCode = "45",
                    Latitude = "28.80526740",
                    Longitude = "-97.00359820",
                    Type = "local council",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Rabat", Latitude = "35.88152000", Longitude = "14.39872000" },
                        new() { Id = 2, Name = "Victoria", Latitude = "36.04444000", Longitude = "14.23972000" }
                    }
                },

                new()
                {
                    Id = 60,
                    Name = "Xagħra",
                    StateCode = "61",
                    Latitude = "36.05084500",
                    Longitude = "14.26748200",
                    Type = "local council",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Xagħra", Latitude = "36.05000000", Longitude = "14.26444000" }
                    }
                },

                new()
                {
                    Id = 61,
                    Name = "Xewkija",
                    StateCode = "62",
                    Latitude = "36.02992360",
                    Longitude = "14.25994370",
                    Type = "local council",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Xewkija", Latitude = "36.03278000", Longitude = "14.25806000" }
                    }
                },

                new()
                {
                    Id = 62,
                    Name = "Xgħajra",
                    StateCode = "63",
                    Latitude = "35.88682820",
                    Longitude = "14.54723910",
                    Type = "local council",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Xgħajra", Latitude = "35.88556000", Longitude = "14.54750000" }
                    }
                },

                new()
                {
                    Id = 63,
                    Name = "Żabbar",
                    StateCode = "64",
                    Latitude = "35.87247150",
                    Longitude = "14.54513540",
                    Type = "local council",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Żabbar", Latitude = "35.87611000", Longitude = "14.53500000" }
                    }
                },

                new()
                {
                    Id = 64,
                    Name = "Żebbuġ Gozo",
                    StateCode = "65",
                    Latitude = "36.07164030",
                    Longitude = "14.24540800",
                    Type = "local council",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Ħaż-Żebbuġ", Latitude = "35.87194000", Longitude = "14.44111000" }
                    }
                },

                new()
                {
                    Id = 65,
                    Name = "Żebbuġ Malta",
                    StateCode = "66",
                    Latitude = "35.87646480",
                    Longitude = "14.43908400",
                    Type = "local council",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Żebbuġ", Latitude = "36.07222000", Longitude = "14.23583000" }
                    }
                },

                new()
                {
                    Id = 66,
                    Name = "Żejtun",
                    StateCode = "67",
                    Latitude = "35.85487140",
                    Longitude = "14.53639690",
                    Type = "local council",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Żejtun", Latitude = "35.85583000", Longitude = "14.53306000" }
                    }
                },

                new()
                {
                    Id = 67,
                    Name = "Żurrieq",
                    StateCode = "68",
                    Latitude = "35.82163060",
                    Longitude = "14.48106480",
                    Type = "local council",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Żurrieq", Latitude = "35.83111000", Longitude = "14.47417000" }
                    }
                }
            }
        };
    }
}
