// ⚠️ WARNING: This file is automatically generated by scripts/generate-world.ps1
// DO NOT modify this file manually as it will be overwritten when the script is run again.
// To update the data, modify the source data in countries-states-cities-database and run the script.

using System.Collections.Generic;
using ShowsOnSale.World.Models;

namespace ShowsOnSale.World.Data.Countries
{
    public static class CoteDivoireIvoryCoast
    {
        public static Country Data { get; } = new()
        {
            Id = 53,
            Name = "Cote D'Ivoire (Ivory Coast)",
            Iso3 = "CIV",
            Iso2 = "CI",
            NumericCode = "384",
            PhoneCode = "225",
            Capital = "Yamoussoukro",
            Currency = "XOF",
            CurrencyName = "West African CFA franc",
            CurrencySymbol = "CFA",
            Tld = ".ci",
            Native = "",
            Region = "Africa",
            RegionId = 1,
            Subregion = "Western Africa",
            SubregionId = 3,
            Nationality = "Ivorian",
            Latitude = "8.00000000",
            Longitude = "-5.00000000",
            Emoji = "🇨🇮",
            EmojiU = "U+1F1E8 U+1F1EE",
            Timezones = new()
            {
                new() { ZoneName = "Africa/Abidjan", GmtOffset = 0, GmtOffsetName = "UTC±00", Abbreviation = "GMT", TzName = "Greenwich Mean Time" }
            },
            Translations = new()
            {
                { "ko" = "코트디부아르" },
                { "pt-BR" = "Costa do Marfim" }
                { "pt" = "Costa do Marfim" }
                { "nl" = "Ivoorkust" }
                { "hr" = "Obala Bjelokosti" }
                { "fa" = "ساحل عاج" }
                { "de" = "Elfenbeinküste" }
                { "es" = "Costa de Marfil" }
                { "fr" = "Côte d'Ivoire" }
                { "ja" = "コートジボワール" }
                { "it" = "Costa D'Avorio" }
                { "zh-CN" = "科特迪瓦" }
                { "tr" = "Kotdivuar" }
                { "ru" = "Кот-д'Ивуар (Берег Слоновой Кости)" }
                { "uk" = "Кот-д'Івуар (Берег Слонової Кістки)" }
                { "pl" = "Cote D'Ivoire (Wybrzeże Kości Słoniowej)" }
            },
            States = new()
            {

                new()
                {
                    Id = 1,
                    Name = "Abidjan",
                    StateCode = "AB",
                    Latitude = "5.35995170",
                    Longitude = "-4.00825630",
                    Type = "autonomous district",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Abidjan", Latitude = "5.30966000", Longitude = "-4.01266000" },
                        new() { Id = 2, Name = "Abobo", Latitude = "5.41613000", Longitude = "-4.01590000" },
                        new() { Id = 3, Name = "Anyama", Latitude = "5.49462000", Longitude = "-4.05183000" },
                        new() { Id = 4, Name = "Bingerville", Latitude = "5.35581000", Longitude = "-3.88537000" }
                    }
                },

                new()
                {
                    Id = 2,
                    Name = "Agnéby",
                    StateCode = "16",
                    Latitude = "5.32245030",
                    Longitude = "-4.34495290",
                    Type = "region",
                    Cities = new()
                    {
                    }
                },

                new()
                {
                    Id = 3,
                    Name = "Bafing",
                    StateCode = "17",
                    Latitude = "8.32520470",
                    Longitude = "-7.52472430",
                    Type = "region",
                    Cities = new()
                    {
                    }
                },

                new()
                {
                    Id = 4,
                    Name = "Bas-Sassandra",
                    StateCode = "BS",
                    Latitude = "5.27983560",
                    Longitude = "-6.15269850",
                    Type = "district",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Gbôklé", Latitude = "4.95712000", Longitude = "-6.09372000" },
                        new() { Id = 2, Name = "Nawa", Latitude = "5.80112000", Longitude = "-6.60313000" },
                        new() { Id = 3, Name = "San-Pédro", Latitude = "4.76768000", Longitude = "-6.65033000" },
                        new() { Id = 4, Name = "Sassandra", Latitude = "4.95384000", Longitude = "-6.08531000" },
                        new() { Id = 5, Name = "Tabou", Latitude = "4.42295000", Longitude = "-7.35280000" }
                    }
                }

                new()
                {
                    Id = 5,
                    Name = "Bas-Sassandra",
                    StateCode = "09",
                    Latitude = "5.35679160",
                    Longitude = "-6.74939930",
                    Type = "region",
                    Cities = new()
                    {
                    }
                }

                new()
                {
                    Id = 6,
                    Name = "Comoé",
                    StateCode = "CM",
                    Latitude = "5.55279300",
                    Longitude = "-3.25836260",
                    Type = "district",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Abengourou", Latitude = "6.72972000", Longitude = "-3.49639000" },
                        new() { Id = 2, Name = "Aboisso", Latitude = "5.46779000", Longitude = "-3.20711000" },
                        new() { Id = 3, Name = "Adiaké", Latitude = "5.28634000", Longitude = "-3.30403000" },
                        new() { Id = 4, Name = "Agnibilékrou", Latitude = "7.13113000", Longitude = "-3.20415000" },
                        new() { Id = 5, Name = "Ayamé", Latitude = "5.60520000", Longitude = "-3.15709000" },
                        new() { Id = 6, Name = "Bonoua", Latitude = "5.27247000", Longitude = "-3.59625000" },
                        new() { Id = 7, Name = "Grand-Bassam", Latitude = "5.21180000", Longitude = "-3.73884000" },
                        new() { Id = 8, Name = "Indénié-Djuablin", Latitude = "6.74434000", Longitude = "-3.49400000" },
                        new() { Id = 9, Name = "Sud-Comoé", Latitude = "5.49961000", Longitude = "-3.24080000" }
                    }
                }

                new()
                {
                    Id = 7,
                    Name = "Denguélé",
                    StateCode = "DN",
                    Latitude = "48.07077630",
                    Longitude = "-68.56093410",
                    Type = "district",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Folon", Latitude = "9.81241000", Longitude = "-7.51894000" },
                        new() { Id = 2, Name = "Kabadougou", Latitude = "9.60571000", Longitude = "-7.43774000" },
                        new() { Id = 3, Name = "Odienné", Latitude = "9.50511000", Longitude = "-7.56433000" }
                    }
                }

                new()
                {
                    Id = 8,
                    Name = "Denguélé",
                    StateCode = "10",
                    Latitude = "9.46623720",
                    Longitude = "-7.43813550",
                    Type = "region",
                    Cities = new()
                    {
                    }
                }

                new()
                {
                    Id = 9,
                    Name = "Dix-Huit Montagnes",
                    StateCode = "06",
                    Latitude = "7.37623730",
                    Longitude = "-7.43813550",
                    Type = "region",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Bangolo", Latitude = "7.01232000", Longitude = "-7.48639000" },
                        new() { Id = 2, Name = "Biankouma", Latitude = "7.73909000", Longitude = "-7.61377000" },
                        new() { Id = 3, Name = "Cavally", Latitude = "6.56343000", Longitude = "-7.92526000" },
                        new() { Id = 4, Name = "Danané", Latitude = "7.25957000", Longitude = "-8.15498000" },
                        new() { Id = 5, Name = "Duekoué", Latitude = "6.74202000", Longitude = "-7.34918000" },
                        new() { Id = 6, Name = "Guémon", Latitude = "7.09300000", Longitude = "-7.17785000" },
                        new() { Id = 7, Name = "Guiglo", Latitude = "6.54368000", Longitude = "-7.49350000" },
                        new() { Id = 8, Name = "Man", Latitude = "7.41251000", Longitude = "-7.55383000" },
                        new() { Id = 9, Name = "Tonkpi", Latitude = "7.56785000", Longitude = "-7.60941000" },
                        new() { Id = 10, Name = "Toulépleu Gueré", Latitude = "6.57395000", Longitude = "-8.42592000" }
                    }
                }

                new()
                {
                    Id = 10,
                    Name = "Fromager",
                    StateCode = "18",
                    Latitude = "45.54502130",
                    Longitude = "-73.60462230",
                    Type = "region",
                    Cities = new()
                    {
                    }
                },

                new()
                {
                    Id = 11,
                    Name = "Gôh-Djiboua",
                    StateCode = "GD",
                    Latitude = "5.87113930",
                    Longitude = "-5.56172790",
                    Type = "district",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Divo", Latitude = "5.83739000", Longitude = "-5.35723000" },
                        new() { Id = 2, Name = "Gagnoa", Latitude = "6.13193000", Longitude = "-5.95060000" },
                        new() { Id = 3, Name = "Gôh", Latitude = "6.14459000", Longitude = "-5.92644000" },
                        new() { Id = 4, Name = "Guibéroua", Latitude = "6.23869000", Longitude = "-6.17147000" },
                        new() { Id = 5, Name = "Lakota", Latitude = "5.84752000", Longitude = "-5.68200000" },
                        new() { Id = 6, Name = "Lôh-Djiboua", Latitude = "5.82483000", Longitude = "-5.47668000" },
                        new() { Id = 7, Name = "Oumé", Latitude = "6.38309000", Longitude = "-5.41759000" }
                    }
                },

                new()
                {
                    Id = 12,
                    Name = "Haut-Sassandra",
                    StateCode = "02",
                    Latitude = "6.87578480",
                    Longitude = "-6.57833870",
                    Type = "region",
                    Cities = new()
                    {
                    }
                },

                new()
                {
                    Id = 13,
                    Name = "Lacs",
                    StateCode = "07",
                    Latitude = "47.73958660",
                    Longitude = "-70.41866520",
                    Type = "region",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Arrah", Latitude = "6.67342000", Longitude = "-3.96938000" },
                        new() { Id = 2, Name = "Bélier", Latitude = "7.02582000", Longitude = "-5.06744000" },
                        new() { Id = 3, Name = "Bocanda", Latitude = "7.06264000", Longitude = "-4.49948000" },
                        new() { Id = 4, Name = "Bongouanou", Latitude = "6.65175000", Longitude = "-4.20406000" },
                        new() { Id = 5, Name = "Daoukro", Latitude = "7.05910000", Longitude = "-3.96310000" },
                        new() { Id = 6, Name = "Dimbokro", Latitude = "6.64678000", Longitude = "-4.70519000" },
                        new() { Id = 7, Name = "Iffou", Latitude = "7.11509000", Longitude = "-3.95027000" },
                        new() { Id = 8, Name = "Moronou", Latitude = "6.66830000", Longitude = "-4.13155000" },
                        new() { Id = 9, Name = "N'Zi", Latitude = "6.82803000", Longitude = "-4.58130000" },
                        new() { Id = 10, Name = "Toumodi", Latitude = "6.55799000", Longitude = "-5.01769000" },
                        new() { Id = 11, Name = "Yamoussoukro", Latitude = "6.82055000", Longitude = "-5.27674000" }
                    }
                },

                new()
                {
                    Id = 14,
                    Name = "Lacs",
                    StateCode = "LC",
                    Latitude = "48.19801690",
                    Longitude = "-80.45644120",
                    Type = "district",
                    Cities = new()
                    {
                    }
                },

                new()
                {
                    Id = 15,
                    Name = "Lagunes",
                    StateCode = "01",
                    Latitude = "5.88273340",
                    Longitude = "-4.23333550",
                    Type = "region",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Adzopé", Latitude = "6.10694000", Longitude = "-3.86194000" },
                        new() { Id = 2, Name = "Affery", Latitude = "6.32035000", Longitude = "-3.95235000" },
                        new() { Id = 3, Name = "Agboville", Latitude = "5.92801000", Longitude = "-4.21319000" },
                        new() { Id = 4, Name = "Agnéby-Tiassa", Latitude = "5.79488000", Longitude = "-4.37187000" },
                        new() { Id = 5, Name = "Akoupé", Latitude = "6.38423000", Longitude = "-3.88759000" },
                        new() { Id = 6, Name = "Dabou", Latitude = "5.32556000", Longitude = "-4.37685000" },
                        new() { Id = 7, Name = "Grand-Lahou", Latitude = "5.25068000", Longitude = "-5.00333000" },
                        new() { Id = 8, Name = "Grands-Ponts", Latitude = "5.30487000", Longitude = "-4.39247000" },
                        new() { Id = 9, Name = "Tiassalé", Latitude = "5.89839000", Longitude = "-4.82293000" }
                    }
                },

                new()
                {
                    Id = 16,
                    Name = "Lagunes",
                    StateCode = "LG",
                    Latitude = "5.88273340",
                    Longitude = "-4.23333550",
                    Type = "district",
                    Cities = new()
                    {
                    }
                },

                new()
                {
                    Id = 17,
                    Name = "Marahoué",
                    StateCode = "12",
                    Latitude = "6.88462070",
                    Longitude = "-5.89871390",
                    Type = "region",
                    Cities = new()
                    {
                    }
                },

                new()
                {
                    Id = 18,
                    Name = "Montagnes",
                    StateCode = "MG",
                    Latitude = "7.37623730",
                    Longitude = "-7.43813550",
                    Type = "district",
                    Cities = new()
                    {
                    }
                },

                new()
                {
                    Id = 19,
                    Name = "Moyen-Cavally",
                    StateCode = "19",
                    Latitude = "6.52087930",
                    Longitude = "-7.61142170",
                    Type = "region",
                    Cities = new()
                    {
                    }
                },

                new()
                {
                    Id = 20,
                    Name = "Moyen-Comoé",
                    StateCode = "05",
                    Latitude = "6.65149170",
                    Longitude = "-3.50034540",
                    Type = "region",
                    Cities = new()
                    {
                    }
                },

                new()
                {
                    Id = 21,
                    Name = "N'zi-Comoé",
                    StateCode = "11",
                    Latitude = "7.24567490",
                    Longitude = "-4.23333550",
                    Type = "region",
                    Cities = new()
                    {
                    }
                },

                new()
                {
                    Id = 22,
                    Name = "Sassandra-Marahoué",
                    StateCode = "SM",
                    Latitude = "6.88033480",
                    Longitude = "-6.23759470",
                    Type = "district",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Bouaflé", Latitude = "6.99041000", Longitude = "-5.74420000" },
                        new() { Id = 2, Name = "Daloa", Latitude = "6.87735000", Longitude = "-6.45022000" },
                        new() { Id = 3, Name = "Haut-Sassandra", Latitude = "6.66961000", Longitude = "-6.50116000" },
                        new() { Id = 4, Name = "Issia", Latitude = "6.49224000", Longitude = "-6.58558000" },
                        new() { Id = 5, Name = "Marahoué", Latitude = "7.03252000", Longitude = "-5.80215000" },
                        new() { Id = 6, Name = "Vavoua", Latitude = "7.38194000", Longitude = "-6.47778000" },
                        new() { Id = 7, Name = "Zuénoula", Latitude = "7.43027000", Longitude = "-6.05054000" }
                    }
                },

                new()
                {
                    Id = 23,
                    Name = "Savanes",
                    StateCode = "03",
                    Latitude = "",
                    Longitude = "",
                    Type = "region",
                    Cities = new()
                    {
                    }
                },

                new()
                {
                    Id = 24,
                    Name = "Sud-Bandama",
                    StateCode = "15",
                    Latitude = "5.53570830",
                    Longitude = "-5.56172790",
                    Type = "region",
                    Cities = new()
                    {
                    }
                },

                new()
                {
                    Id = 25,
                    Name = "Sud-Comoé",
                    StateCode = "13",
                    Latitude = "5.55279300",
                    Longitude = "-3.25836260",
                    Type = "region",
                    Cities = new()
                    {
                    }
                },

                new()
                {
                    Id = 26,
                    Name = "Vallée du Bandama",
                    StateCode = "04",
                    Latitude = "8.27897800",
                    Longitude = "-4.89356270",
                    Type = "region",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Béoumi", Latitude = "7.67395000", Longitude = "-5.58085000" },
                        new() { Id = 2, Name = "Botro", Latitude = "7.85249000", Longitude = "-5.31063000" },
                        new() { Id = 3, Name = "Bouaké", Latitude = "7.69385000", Longitude = "-5.03031000" },
                        new() { Id = 4, Name = "Dabakala", Latitude = "8.36321000", Longitude = "-4.42863000" },
                        new() { Id = 5, Name = "Gbêkê", Latitude = "7.70271000", Longitude = "-5.28511000" },
                        new() { Id = 6, Name = "Hambol", Latitude = "8.30368000", Longitude = "-5.15396000" },
                        new() { Id = 7, Name = "Katiola", Latitude = "8.13728000", Longitude = "-5.10095000" },
                        new() { Id = 8, Name = "Sakassou", Latitude = "7.45462000", Longitude = "-5.29263000" }
                    }
                },

                new()
                {
                    Id = 27,
                    Name = "Vallée du Bandama",
                    StateCode = "VB",
                    Latitude = "8.27897800",
                    Longitude = "-4.89356270",
                    Type = "district",
                    Cities = new()
                    {
                    }
                },

                new()
                {
                    Id = 28,
                    Name = "Woroba",
                    StateCode = "WR",
                    Latitude = "8.24913720",
                    Longitude = "-6.92091350",
                    Type = "district",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Bafing", Latitude = "8.40611000", Longitude = "-7.58048000" },
                        new() { Id = 2, Name = "Béré", Latitude = "8.18952000", Longitude = "-6.17157000" },
                        new() { Id = 3, Name = "Mankono", Latitude = "8.05861000", Longitude = "-6.18972000" },
                        new() { Id = 4, Name = "Séguéla", Latitude = "7.96111000", Longitude = "-6.67306000" },
                        new() { Id = 5, Name = "Touba", Latitude = "8.28333000", Longitude = "-7.68333000" },
                        new() { Id = 6, Name = "Worodougou", Latitude = "8.16482000", Longitude = "-6.66595000" }
                    }
                },

                new()
                {
                    Id = 29,
                    Name = "Worodougou",
                    StateCode = "14",
                    Latitude = "8.25489620",
                    Longitude = "-6.57833870",
                    Type = "region",
                    Cities = new()
                    {
                    }
                },

                new()
                {
                    Id = 30,
                    Name = "Yamoussoukro",
                    StateCode = "YM",
                    Latitude = "6.82762280",
                    Longitude = "-5.28934330",
                    Type = "district",
                    Cities = new()
                    {
                    }
                },

                new()
                {
                    Id = 31,
                    Name = "Zanzan",
                    StateCode = "ZZ",
                    Latitude = "8.82079040",
                    Longitude = "-3.41955270",
                    Type = "district",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Bondoukou", Latitude = "8.04020000", Longitude = "-2.80003000" },
                        new() { Id = 2, Name = "Bouna", Latitude = "9.26927000", Longitude = "-2.99510000" },
                        new() { Id = 3, Name = "Bounkani", Latitude = "9.47841000", Longitude = "-3.31238000" },
                        new() { Id = 4, Name = "Gontougo", Latitude = "7.87132000", Longitude = "-3.07068000" },
                        new() { Id = 5, Name = "Sinfra", Latitude = "6.62103000", Longitude = "-5.91144000" },
                        new() { Id = 6, Name = "Tanda", Latitude = "7.80335000", Longitude = "-3.16832000" }
                    }
                }
            }
        };
    }
}
