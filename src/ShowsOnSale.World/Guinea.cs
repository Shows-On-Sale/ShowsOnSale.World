// ⚠️ WARNING: This file is automatically generated by scripts/generate-world.ps1
// DO NOT modify this file manually as it will be overwritten when the script is run again.
// To update the data, modify the source data in countries-states-cities-database and run the script.

using System.Collections.Generic;
using ShowsOnSale.World.Models;

namespace ShowsOnSale.World.Data.Countries
{
    public static class Guinea
    {
        public static Country Data { get; } = new()
        {
            Id = 92,
            Name = "Guinea",
            Iso3 = "GIN",
            Iso2 = "GN",
            NumericCode = "324",
            PhoneCode = "224",
            Capital = "Conakry",
            Currency = "GNF",
            CurrencyName = "Guinean franc",
            CurrencySymbol = "FG",
            Tld = ".gn",
            Native = "Guinée",
            Region = "Africa",
            RegionId = 1,
            Subregion = "Western Africa",
            SubregionId = 3,
            Nationality = "Guinean",
            Latitude = "11.00000000",
            Longitude = "-10.00000000",
            Emoji = "🇬🇳",
            EmojiU = "U+1F1EC U+1F1F3",
            Timezones = new()
            {
                new() { ZoneName = "Africa/Conakry", GmtOffset = 0, GmtOffsetName = "UTC±00", Abbreviation = "GMT", TzName = "Greenwich Mean Time" }
            },
            Translations = new()
            {
                ["ko"] = "기니",
                ["pt-BR"] = "Guiné",
                ["pt"] = "Guiné",
                ["nl"] = "Guinee",
                ["hr"] = "Gvineja",
                ["fa"] = "گینه",
                ["de"] = "Guinea",
                ["es"] = "Guinea",
                ["fr"] = "Guinée",
                ["ja"] = "ギニア",
                ["it"] = "Guinea",
                ["zh-CN"] = "几内亚",
                ["tr"] = "Gine",
                ["ru"] = "Гвинея",
                ["uk"] = "Гвінея",
                ["pl"] = "Gwinea"
            },
            States = new()
            {

                new()
                {
                    Id = 1,
                    Name = "Beyla",
                    StateCode = "BE",
                    Latitude = "8.91981780",
                    Longitude = "-8.30884410",
                    Type = "prefecture",
                    Cities = new()
                    {
                    }
                },

                new()
                {
                    Id = 2,
                    Name = "Boffa",
                    StateCode = "BF",
                    Latitude = "10.18082540",
                    Longitude = "-14.03916150",
                    Type = "prefecture",
                    Cities = new()
                    {
                    }
                },

                new()
                {
                    Id = 3,
                    Name = "Boké",
                    StateCode = "B",
                    Latitude = "11.18646720",
                    Longitude = "-14.10013260",
                    Type = "administrative region",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Boffa", Latitude = "10.33333000", Longitude = "-14.16667000" },
                        new() { Id = 2, Name = "Boké", Latitude = "10.93217000", Longitude = "-14.29055000" },
                        new() { Id = 3, Name = "Boke Prefecture", Latitude = "11.08333000", Longitude = "-14.41667000" },
                        new() { Id = 4, Name = "Fria", Latitude = "10.41667000", Longitude = "-13.58333000" },
                        new() { Id = 5, Name = "Gaoual", Latitude = "11.75000000", Longitude = "-13.20000000" },
                        new() { Id = 6, Name = "Gaoual Prefecture", Latitude = "11.75000000", Longitude = "-13.20000000" },
                        new() { Id = 7, Name = "Kimbo", Latitude = "10.40000000", Longitude = "-13.55000000" },
                        new() { Id = 8, Name = "Koundara", Latitude = "12.48333000", Longitude = "-13.30000000" },
                        new() { Id = 9, Name = "Koundara Prefecture", Latitude = "12.41667000", Longitude = "-13.16667000" },
                        new() { Id = 10, Name = "Sanguéya", Latitude = "10.70000000", Longitude = "-14.36667000" },
                        new() { Id = 11, Name = "Youkounkoun", Latitude = "12.53110000", Longitude = "-13.12240000" }
                    }
                },

                new()
                {
                    Id = 4,
                    Name = "Boké",
                    StateCode = "BK",
                    Latitude = "11.08473790",
                    Longitude = "-14.37919120",
                    Type = "prefecture",
                    Cities = new()
                    {
                    }
                },

                new()
                {
                    Id = 5,
                    Name = "Conakry",
                    StateCode = "C",
                    Latitude = "9.64118550",
                    Longitude = "-13.57840120",
                    Type = "governorate",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Camayenne", Latitude = "9.53500000", Longitude = "-13.68778000" },
                        new() { Id = 2, Name = "Conakry", Latitude = "9.53795000", Longitude = "-13.67729000" }
                    }
                },

                new()
                {
                    Id = 6,
                    Name = "Coyah",
                    StateCode = "CO",
                    Latitude = "9.77155350",
                    Longitude = "-13.31252990",
                    Type = "prefecture",
                    Cities = new()
                    {
                    }
                },

                new()
                {
                    Id = 7,
                    Name = "Dabola",
                    StateCode = "DB",
                    Latitude = "10.72978060",
                    Longitude = "-11.11078540",
                    Type = "prefecture",
                    Cities = new()
                    {
                    }
                },

                new()
                {
                    Id = 8,
                    Name = "Dalaba",
                    StateCode = "DL",
                    Latitude = "10.68681760",
                    Longitude = "-12.24906970",
                    Type = "prefecture",
                    Cities = new()
                    {
                    }
                },

                new()
                {
                    Id = 9,
                    Name = "Dinguiraye",
                    StateCode = "DI",
                    Latitude = "11.68442220",
                    Longitude = "-10.80000510",
                    Type = "prefecture",
                    Cities = new()
                    {
                    }
                },

                new()
                {
                    Id = 10,
                    Name = "Dubréka",
                    StateCode = "DU",
                    Latitude = "9.79073480",
                    Longitude = "-13.51477350",
                    Type = "prefecture",
                    Cities = new()
                    {
                    }
                },

                new()
                {
                    Id = 11,
                    Name = "Faranah",
                    StateCode = "F",
                    Latitude = "10.54730350",
                    Longitude = "-11.85076440",
                    Type = "administrative region",
                    Cities = new()
                    {
                    }
                },

                new()
                {
                    Id = 12,
                    Name = "Faranah",
                    StateCode = "FA",
                    Latitude = "9.90573990",
                    Longitude = "-10.80000510",
                    Type = "prefecture",
                    Cities = new()
                    {
                    }
                },

                new()
                {
                    Id = 13,
                    Name = "Forécariah",
                    StateCode = "FO",
                    Latitude = "9.38861870",
                    Longitude = "-13.08179030",
                    Type = "prefecture",
                    Cities = new()
                    {
                    }
                },

                new()
                {
                    Id = 14,
                    Name = "Fria",
                    StateCode = "FR",
                    Latitude = "10.36745430",
                    Longitude = "-13.58418710",
                    Type = "prefecture",
                    Cities = new()
                    {
                    }
                },

                new()
                {
                    Id = 15,
                    Name = "Gaoual",
                    StateCode = "GA",
                    Latitude = "11.57628040",
                    Longitude = "-13.35872880",
                    Type = "prefecture",
                    Cities = new()
                    {
                    }
                },

                new()
                {
                    Id = 16,
                    Name = "Guéckédou",
                    StateCode = "GU",
                    Latitude = "8.56496880",
                    Longitude = "-10.13111630",
                    Type = "prefecture",
                    Cities = new()
                    {
                    }
                },

                new()
                {
                    Id = 17,
                    Name = "Kankan",
                    StateCode = "KA",
                    Latitude = "10.30344650",
                    Longitude = "-9.36730840",
                    Type = "prefecture",
                    Cities = new()
                    {
                    }
                },

                new()
                {
                    Id = 18,
                    Name = "Kankan",
                    StateCode = "K",
                    Latitude = "10.12092300",
                    Longitude = "-9.54509740",
                    Type = "administrative region",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Kankan", Latitude = "10.38542000", Longitude = "-9.30568000" },
                        new() { Id = 2, Name = "Kankan Prefecture", Latitude = "10.27100000", Longitude = "-9.17800000" },
                        new() { Id = 3, Name = "Kérouané", Latitude = "9.26667000", Longitude = "-9.01667000" },
                        new() { Id = 4, Name = "Kerouane Prefecture", Latitude = "9.16667000", Longitude = "-9.08333000" },
                        new() { Id = 5, Name = "Kouroussa", Latitude = "10.66667000", Longitude = "-9.91667000" },
                        new() { Id = 6, Name = "Mandiana", Latitude = "10.62577000", Longitude = "-8.69413000" },
                        new() { Id = 7, Name = "Mandiana Prefecture", Latitude = "10.65800000", Longitude = "-8.61500000" },
                        new() { Id = 8, Name = "Siguiri", Latitude = "11.42282000", Longitude = "-9.16852000" },
                        new() { Id = 9, Name = "Siguiri Prefecture", Latitude = "11.66667000", Longitude = "-9.50000000" },
                        new() { Id = 10, Name = "Tokonou", Latitude = "9.65000000", Longitude = "-9.78333000" }
                    }
                },

                new()
                {
                    Id = 19,
                    Name = "Kérouané",
                    StateCode = "KE",
                    Latitude = "9.25366430",
                    Longitude = "-9.01289260",
                    Type = "prefecture",
                    Cities = new()
                    {
                    }
                },

                new()
                {
                    Id = 20,
                    Name = "Kindia",
                    StateCode = "D",
                    Latitude = "10.17816940",
                    Longitude = "-12.98961500",
                    Type = "administrative region",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Coyah", Latitude = "9.75000000", Longitude = "-13.41667000" },
                        new() { Id = 2, Name = "Dubréka", Latitude = "9.79111000", Longitude = "-13.52333000" },
                        new() { Id = 3, Name = "Forécariah", Latitude = "9.43056000", Longitude = "-13.08806000" },
                        new() { Id = 4, Name = "Kindia", Latitude = "10.08333000", Longitude = "-12.80000000" },
                        new() { Id = 5, Name = "Préfecture de Dubréka", Latitude = "10.25000000", Longitude = "-13.41667000" },
                        new() { Id = 6, Name = "Préfecture de Forécariah", Latitude = "9.43333000", Longitude = "-13.10000000" },
                        new() { Id = 7, Name = "Télimélé", Latitude = "10.90000000", Longitude = "-13.03333000" },
                        new() { Id = 8, Name = "Telimele Prefecture", Latitude = "10.91667000", Longitude = "-13.33333000" },
                        new() { Id = 9, Name = "Tondon", Latitude = "10.36667000", Longitude = "-13.35000000" }
                    }
                },

                new()
                {
                    Id = 21,
                    Name = "Kindia",
                    StateCode = "KD",
                    Latitude = "10.10132920",
                    Longitude = "-12.71351210",
                    Type = "prefecture",
                    Cities = new()
                    {
                    }
                },

                new()
                {
                    Id = 22,
                    Name = "Kissidougou",
                    StateCode = "KS",
                    Latitude = "9.22520220",
                    Longitude = "-10.08072980",
                    Type = "prefecture",
                    Cities = new()
                    {
                    }
                },

                new()
                {
                    Id = 23,
                    Name = "Koubia",
                    StateCode = "KB",
                    Latitude = "11.58235400",
                    Longitude = "-11.89202370",
                    Type = "prefecture",
                    Cities = new()
                    {
                    }
                },

                new()
                {
                    Id = 24,
                    Name = "Koundara",
                    StateCode = "KN",
                    Latitude = "12.48940210",
                    Longitude = "-13.30675620",
                    Type = "prefecture",
                    Cities = new()
                    {
                    }
                },

                new()
                {
                    Id = 25,
                    Name = "Kouroussa",
                    StateCode = "KO",
                    Latitude = "10.64892290",
                    Longitude = "-9.88505860",
                    Type = "prefecture",
                    Cities = new()
                    {
                    }
                },

                new()
                {
                    Id = 26,
                    Name = "Labé",
                    StateCode = "LA",
                    Latitude = "11.35419390",
                    Longitude = "-12.34638750",
                    Type = "prefecture",
                    Cities = new()
                    {
                    }
                },

                new()
                {
                    Id = 27,
                    Name = "Labé",
                    StateCode = "L",
                    Latitude = "11.32320420",
                    Longitude = "-12.28913140",
                    Type = "administrative region",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Koubia", Latitude = "11.58333000", Longitude = "-11.83333000" },
                        new() { Id = 2, Name = "Labé", Latitude = "11.31823000", Longitude = "-12.28332000" },
                        new() { Id = 3, Name = "Labe Prefecture", Latitude = "11.36600000", Longitude = "-12.30000000" },
                        new() { Id = 4, Name = "Lélouma", Latitude = "11.42383000", Longitude = "-12.68183000" },
                        new() { Id = 5, Name = "Lelouma Prefecture", Latitude = "11.41667000", Longitude = "-12.66667000" },
                        new() { Id = 6, Name = "Mali", Latitude = "12.07900000", Longitude = "-12.29820000" },
                        new() { Id = 7, Name = "Mali Prefecture", Latitude = "12.08333000", Longitude = "-12.08333000" },
                        new() { Id = 8, Name = "Tougué", Latitude = "11.44503000", Longitude = "-11.66422000" },
                        new() { Id = 9, Name = "Tougue Prefecture", Latitude = "11.46667000", Longitude = "-11.60000000" }
                    }
                },

                new()
                {
                    Id = 28,
                    Name = "Lélouma",
                    StateCode = "LE",
                    Latitude = "11.18333300",
                    Longitude = "-12.93333300",
                    Type = "prefecture",
                    Cities = new()
                    {
                    }
                },

                new()
                {
                    Id = 29,
                    Name = "Lola",
                    StateCode = "LO",
                    Latitude = "7.96138180",
                    Longitude = "-8.39649380",
                    Type = "prefecture",
                    Cities = new()
                    {
                    }
                },

                new()
                {
                    Id = 30,
                    Name = "Macenta",
                    StateCode = "MC",
                    Latitude = "8.46157950",
                    Longitude = "-9.27855830",
                    Type = "prefecture",
                    Cities = new()
                    {
                    }
                },

                new()
                {
                    Id = 31,
                    Name = "Mali",
                    StateCode = "ML",
                    Latitude = "11.98370900",
                    Longitude = "-12.25479190",
                    Type = "prefecture",
                    Cities = new()
                    {
                    }
                },

                new()
                {
                    Id = 32,
                    Name = "Mamou",
                    StateCode = "M",
                    Latitude = "10.57360240",
                    Longitude = "-11.88917210",
                    Type = "administrative region",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Dalaba", Latitude = "10.75000000", Longitude = "-12.30000000" },
                        new() { Id = 2, Name = "Mamou", Latitude = "10.37546000", Longitude = "-12.09148000" },
                        new() { Id = 3, Name = "Mamou Prefecture", Latitude = "10.45900000", Longitude = "-11.81500000" },
                        new() { Id = 4, Name = "Pita", Latitude = "10.83333000", Longitude = "-12.58333000" }
                    }
                },

                new()
                {
                    Id = 33,
                    Name = "Mamou",
                    StateCode = "MM",
                    Latitude = "10.57360240",
                    Longitude = "-11.88917210",
                    Type = "prefecture",
                    Cities = new()
                    {
                    }
                },

                new()
                {
                    Id = 34,
                    Name = "Mandiana",
                    StateCode = "MD",
                    Latitude = "10.61728270",
                    Longitude = "-8.69857160",
                    Type = "prefecture",
                    Cities = new()
                    {
                    }
                },

                new()
                {
                    Id = 35,
                    Name = "Nzérékoré",
                    StateCode = "N",
                    Latitude = "8.03858700",
                    Longitude = "-8.83627550",
                    Type = "administrative region",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Beyla", Latitude = "8.69011000", Longitude = "-8.64869000" },
                        new() { Id = 2, Name = "Beyla Prefecture", Latitude = "8.91667000", Longitude = "-8.41667000" },
                        new() { Id = 3, Name = "Gueckedou", Latitude = "8.56744000", Longitude = "-10.13360000" },
                        new() { Id = 4, Name = "Lola", Latitude = "7.83333000", Longitude = "-8.33333000" },
                        new() { Id = 5, Name = "Macenta", Latitude = "8.50000000", Longitude = "-9.41667000" },
                        new() { Id = 6, Name = "Nzérékoré", Latitude = "7.75624000", Longitude = "-8.81790000" },
                        new() { Id = 7, Name = "Nzerekore Prefecture", Latitude = "7.94500000", Longitude = "-8.78300000" },
                        new() { Id = 8, Name = "Préfecture de Guékédou", Latitude = "8.66667000", Longitude = "-10.25000000" },
                        new() { Id = 9, Name = "Yomou", Latitude = "7.50000000", Longitude = "-9.16667000" }
                    }
                },

                new()
                {
                    Id = 36,
                    Name = "Nzérékoré",
                    StateCode = "NZ",
                    Latitude = "7.74783590",
                    Longitude = "-8.82525020",
                    Type = "prefecture",
                    Cities = new()
                    {
                    }
                },

                new()
                {
                    Id = 37,
                    Name = "Pita",
                    StateCode = "PI",
                    Latitude = "10.80620860",
                    Longitude = "-12.71351210",
                    Type = "prefecture",
                    Cities = new()
                    {
                    }
                },

                new()
                {
                    Id = 38,
                    Name = "Siguiri",
                    StateCode = "SI",
                    Latitude = "11.41481130",
                    Longitude = "-9.17883040",
                    Type = "prefecture",
                    Cities = new()
                    {
                    }
                },

                new()
                {
                    Id = 39,
                    Name = "Télimélé",
                    StateCode = "TE",
                    Latitude = "10.90893640",
                    Longitude = "-13.02993310",
                    Type = "prefecture",
                    Cities = new()
                    {
                    }
                },

                new()
                {
                    Id = 40,
                    Name = "Tougué",
                    StateCode = "TO",
                    Latitude = "11.38415830",
                    Longitude = "-11.61577730",
                    Type = "prefecture",
                    Cities = new()
                    {
                    }
                },

                new()
                {
                    Id = 41,
                    Name = "Yomou",
                    StateCode = "YO",
                    Latitude = "7.56962790",
                    Longitude = "-9.25915710",
                    Type = "prefecture",
                    Cities = new()
                    {
                    }
                }
            }
        };
    }
}
