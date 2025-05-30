// ⚠️ WARNING: This file is automatically generated by scripts/generate-world.ps1
// DO NOT modify this file manually as it will be overwritten when the script is run again.
// To update the data, modify the source data in countries-states-cities-database and run the script.

using System.Collections.Generic;
using ShowsOnSale.World.Models;

namespace ShowsOnSale.World.Data.Countries
{
    public static class Albania
    {
        public static Country Data { get; } = new()
        {
            Id = 3,
            Name = "Albania",
            Iso3 = "ALB",
            Iso2 = "AL",
            NumericCode = "008",
            PhoneCode = "355",
            Capital = "Tirana",
            Currency = "ALL",
            CurrencyName = "Albanian lek",
            CurrencySymbol = "Lek",
            Tld = ".al",
            Native = "Shqipëria",
            Region = "Europe",
            RegionId = 4,
            Subregion = "Southern Europe",
            SubregionId = 16,
            Nationality = "Albanian ",
            Latitude = "41.00000000",
            Longitude = "20.00000000",
            Emoji = "🇦🇱",
            EmojiU = "U+1F1E6 U+1F1F1",
            Timezones = new()
            {
                new() { ZoneName = "Europe/Tirane", GmtOffset = 3600, GmtOffsetName = "UTC+01:00", Abbreviation = "CET", TzName = "Central European Time" }
            },
            Translations = new()
            {
                ["ko"] = "알바니아",
                ["pt-BR"] = "Albânia",
                ["pt"] = "Albânia",
                ["nl"] = "Albanië",
                ["hr"] = "Albanija",
                ["fa"] = "آلبانی",
                ["de"] = "Albanien",
                ["es"] = "Albania",
                ["fr"] = "Albanie",
                ["ja"] = "アルバニア",
                ["it"] = "Albania",
                ["zh-CN"] = "阿尔巴尼亚",
                ["tr"] = "Arnavutluk",
                ["ru"] = "Албания",
                ["uk"] = "Албанія",
                ["pl"] = "Albania"
            },
            States = new()
            {

                new()
                {
                    Id = 1,
                    Name = "Berat",
                    StateCode = "BR",
                    Latitude = "40.70863770",
                    Longitude = "19.94373140",
                    Type = "district",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Banaj", Latitude = "40.82492000", Longitude = "19.84074000" },
                        new() { Id = 2, Name = "Bashkia Berat", Latitude = "40.69997000", Longitude = "19.94983000" },
                        new() { Id = 3, Name = "Bashkia Kuçovë", Latitude = "40.82489000", Longitude = "19.95350000" },
                        new() { Id = 4, Name = "Bashkia Poliçan", Latitude = "40.58608000", Longitude = "20.04535000" },
                        new() { Id = 5, Name = "Bashkia Skrapar", Latitude = "40.56036000", Longitude = "20.25477000" },
                        new() { Id = 6, Name = "Berat", Latitude = "40.70583000", Longitude = "19.95222000" },
                        new() { Id = 7, Name = "Çorovodë", Latitude = "40.50417000", Longitude = "20.22722000" },
                        new() { Id = 8, Name = "Kuçovë", Latitude = "40.80028000", Longitude = "19.91667000" },
                        new() { Id = 9, Name = "Poliçan", Latitude = "40.61222000", Longitude = "20.09806000" },
                        new() { Id = 10, Name = "Rrethi i Beratit", Latitude = "40.66667000", Longitude = "20.00000000" },
                        new() { Id = 11, Name = "Rrethi i Kuçovës", Latitude = "40.83333000", Longitude = "19.91667000" },
                        new() { Id = 12, Name = "Rrethi i Skraparit", Latitude = "40.55000000", Longitude = "20.26667000" },
                        new() { Id = 13, Name = "Ura Vajgurore", Latitude = "40.76889000", Longitude = "19.87778000" }
                    }
                },

                new()
                {
                    Id = 2,
                    Name = "Berat",
                    StateCode = "01",
                    Latitude = "40.69530120",
                    Longitude = "20.04496620",
                    Type = "county",
                    Cities = new()
                    {
                    }
                },

                new()
                {
                    Id = 3,
                    Name = "Bulqizë",
                    StateCode = "BU",
                    Latitude = "41.49425870",
                    Longitude = "20.21471570",
                    Type = "district",
                    Cities = new()
                    {
                    }
                },

                new()
                {
                    Id = 4,
                    Name = "Delvinë",
                    StateCode = "DL",
                    Latitude = "39.94813640",
                    Longitude = "20.09558910",
                    Type = "district",
                    Cities = new()
                    {
                    }
                },

                new()
                {
                    Id = 5,
                    Name = "Devoll",
                    StateCode = "DV",
                    Latitude = "40.64473470",
                    Longitude = "20.95066360",
                    Type = "district",
                    Cities = new()
                    {
                    }
                },

                new()
                {
                    Id = 6,
                    Name = "Dibër",
                    StateCode = "09",
                    Latitude = "41.58881630",
                    Longitude = "20.23556470",
                    Type = "county",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Bashkia Bulqizë", Latitude = "41.47152000", Longitude = "20.33192000" },
                        new() { Id = 2, Name = "Bashkia Klos", Latitude = "41.50826000", Longitude = "20.07107000" },
                        new() { Id = 3, Name = "Bashkia Mat", Latitude = "41.63317000", Longitude = "20.01228000" },
                        new() { Id = 4, Name = "Bulqizë", Latitude = "41.49167000", Longitude = "20.22194000" },
                        new() { Id = 5, Name = "Burrel", Latitude = "41.61028000", Longitude = "20.00889000" },
                        new() { Id = 6, Name = "Klos", Latitude = "41.50694000", Longitude = "20.08667000" },
                        new() { Id = 7, Name = "Peshkopi", Latitude = "41.68500000", Longitude = "20.42889000" },
                        new() { Id = 8, Name = "Rrethi i Bulqizës", Latitude = "41.50000000", Longitude = "20.33333000" },
                        new() { Id = 9, Name = "Rrethi i Dibrës", Latitude = "41.75000000", Longitude = "20.33333000" },
                        new() { Id = 10, Name = "Rrethi i Matit", Latitude = "41.58333000", Longitude = "20.08333000" },
                        new() { Id = 11, Name = "Ulëz", Latitude = "41.68278000", Longitude = "19.89333000" }
                    }
                },

                new()
                {
                    Id = 7,
                    Name = "Dibër",
                    StateCode = "DI",
                    Latitude = "41.58881630",
                    Longitude = "20.23556470",
                    Type = "district",
                    Cities = new()
                    {
                    }
                },

                new()
                {
                    Id = 8,
                    Name = "Durrës",
                    StateCode = "DR",
                    Latitude = "41.37065170",
                    Longitude = "19.52110630",
                    Type = "district",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Bashkia Durrës", Latitude = "41.42743000", Longitude = "19.48690000" },
                        new() { Id = 2, Name = "Bashkia Krujë", Latitude = "41.50091000", Longitude = "19.72571000" },
                        new() { Id = 3, Name = "Bashkia Shijak", Latitude = "41.33558000", Longitude = "19.58977000" },
                        new() { Id = 4, Name = "Durrës", Latitude = "41.32355000", Longitude = "19.45469000" },
                        new() { Id = 5, Name = "Durrës District", Latitude = "41.31660000", Longitude = "19.45000000" },
                        new() { Id = 6, Name = "Fushë-Krujë", Latitude = "41.47833000", Longitude = "19.71778000" },
                        new() { Id = 7, Name = "Krujë", Latitude = "41.50917000", Longitude = "19.79278000" },
                        new() { Id = 8, Name = "Rrethi i Krujës", Latitude = "41.55000000", Longitude = "19.75000000" },
                        new() { Id = 9, Name = "Shijak", Latitude = "41.34556000", Longitude = "19.56722000" },
                        new() { Id = 10, Name = "Sukth", Latitude = "41.38056000", Longitude = "19.53778000" }
                    }
                },

                new()
                {
                    Id = 9,
                    Name = "Durrës",
                    StateCode = "02",
                    Latitude = "41.50809720",
                    Longitude = "19.61631850",
                    Type = "county",
                    Cities = new()
                    {
                    }
                },

                new()
                {
                    Id = 10,
                    Name = "Elbasan",
                    StateCode = "03",
                    Latitude = "41.12666720",
                    Longitude = "20.23556470",
                    Type = "county",
                    Cities = new()
                    {
                    }
                },

                new()
                {
                    Id = 11,
                    Name = "Fier",
                    StateCode = "FR",
                    Latitude = "40.72750400",
                    Longitude = "19.56275960",
                    Type = "district",
                    Cities = new()
                    {
                    }
                },

                new()
                {
                    Id = 12,
                    Name = "Fier",
                    StateCode = "04",
                    Latitude = "40.91913920",
                    Longitude = "19.66393090",
                    Type = "county",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Ballsh", Latitude = "40.59889000", Longitude = "19.73472000" },
                        new() { Id = 2, Name = "Bashkia Divjakë", Latitude = "40.95716000", Longitude = "19.52364000" },
                        new() { Id = 3, Name = "Bashkia Fier", Latitude = "40.72937000", Longitude = "19.48690000" },
                        new() { Id = 4, Name = "Bashkia Mallakastër", Latitude = "40.55669000", Longitude = "19.77347000" },
                        new() { Id = 5, Name = "Bashkia Patos", Latitude = "40.67793000", Longitude = "19.65591000" },
                        new() { Id = 6, Name = "Divjakë", Latitude = "40.99667000", Longitude = "19.52944000" },
                        new() { Id = 7, Name = "Fier", Latitude = "40.72389000", Longitude = "19.55611000" },
                        new() { Id = 8, Name = "Fier-Çifçi", Latitude = "40.71667000", Longitude = "19.56667000" },
                        new() { Id = 9, Name = "Lushnjë", Latitude = "40.94194000", Longitude = "19.70500000" },
                        new() { Id = 10, Name = "Patos", Latitude = "40.68333000", Longitude = "19.61944000" },
                        new() { Id = 11, Name = "Patos Fshat", Latitude = "40.64278000", Longitude = "19.65083000" },
                        new() { Id = 12, Name = "Roskovec", Latitude = "40.73750000", Longitude = "19.70222000" },
                        new() { Id = 13, Name = "Rrethi i Mallakastrës", Latitude = "40.55000000", Longitude = "19.78333000" }
                    }
                },

                new()
                {
                    Id = 13,
                    Name = "Gjirokastër",
                    StateCode = "GJ",
                    Latitude = "40.06728740",
                    Longitude = "20.10452290",
                    Type = "district",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Bashkia Dropull", Latitude = "39.98584000", Longitude = "20.30529000" },
                        new() { Id = 2, Name = "Bashkia Kelcyrë", Latitude = "40.36196000", Longitude = "20.16476000" },
                        new() { Id = 3, Name = "Bashkia Libohovë", Latitude = "40.10754000", Longitude = "20.25753000" },
                        new() { Id = 4, Name = "Bashkia Memaliaj", Latitude = "40.41524000", Longitude = "19.96911000" },
                        new() { Id = 5, Name = "Bashkia Përmet", Latitude = "40.23246000", Longitude = "20.41091000" },
                        new() { Id = 6, Name = "Bashkia Tepelenë", Latitude = "40.26736000", Longitude = "19.97003000" },
                        new() { Id = 7, Name = "Gjinkar", Latitude = "40.19944000", Longitude = "20.40611000" },
                        new() { Id = 8, Name = "Gjirokastër", Latitude = "40.07583000", Longitude = "20.13889000" },
                        new() { Id = 9, Name = "Këlcyrë", Latitude = "40.31306000", Longitude = "20.18944000" },
                        new() { Id = 10, Name = "Lazarat", Latitude = "40.04667000", Longitude = "20.14750000" },
                        new() { Id = 11, Name = "Libohovë", Latitude = "40.03111000", Longitude = "20.26306000" },
                        new() { Id = 12, Name = "Memaliaj", Latitude = "40.35167000", Longitude = "19.98028000" },
                        new() { Id = 13, Name = "Përmet", Latitude = "40.23361000", Longitude = "20.35167000" },
                        new() { Id = 14, Name = "Tepelenë", Latitude = "40.29583000", Longitude = "20.01917000" }
                    }
                },

                new()
                {
                    Id = 14,
                    Name = "Gjirokastër",
                    StateCode = "05",
                    Latitude = "40.06728740",
                    Longitude = "20.10452290",
                    Type = "county",
                    Cities = new()
                    {
                    }
                },

                new()
                {
                    Id = 15,
                    Name = "Gramsh",
                    StateCode = "GR",
                    Latitude = "40.86698730",
                    Longitude = "20.18493230",
                    Type = "district",
                    Cities = new()
                    {
                    }
                },

                new()
                {
                    Id = 16,
                    Name = "Has",
                    StateCode = "HA",
                    Latitude = "42.79013360",
                    Longitude = "-83.61220120",
                    Type = "district",
                    Cities = new()
                    {
                    }
                },

                new()
                {
                    Id = 17,
                    Name = "Kavajë",
                    StateCode = "KA",
                    Latitude = "41.18445290",
                    Longitude = "19.56275960",
                    Type = "district",
                    Cities = new()
                    {
                    }
                },

                new()
                {
                    Id = 18,
                    Name = "Kolonjë",
                    StateCode = "ER",
                    Latitude = "40.33732620",
                    Longitude = "20.67946760",
                    Type = "district",
                    Cities = new()
                    {
                    }
                },

                new()
                {
                    Id = 19,
                    Name = "Korçë",
                    StateCode = "06",
                    Latitude = "40.59056700",
                    Longitude = "20.61689210",
                    Type = "county",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Bashkia Devoll", Latitude = "40.60078000", Longitude = "20.93814000" },
                        new() { Id = 2, Name = "Bashkia Kolonjë", Latitude = "40.31420000", Longitude = "20.61482000" },
                        new() { Id = 3, Name = "Bashkia Maliq", Latitude = "40.75508000", Longitude = "20.60748000" },
                        new() { Id = 4, Name = "Bashkia Pustec", Latitude = "40.83591000", Longitude = "20.89405000" },
                        new() { Id = 5, Name = "Bilisht", Latitude = "40.62750000", Longitude = "20.99000000" },
                        new() { Id = 6, Name = "Ersekë", Latitude = "40.33778000", Longitude = "20.67889000" },
                        new() { Id = 7, Name = "Korçë", Latitude = "40.61861000", Longitude = "20.78083000" },
                        new() { Id = 8, Name = "Leskovik", Latitude = "40.15139000", Longitude = "20.59722000" },
                        new() { Id = 9, Name = "Libonik", Latitude = "40.70444000", Longitude = "20.70861000" },
                        new() { Id = 10, Name = "Maliq", Latitude = "40.70583000", Longitude = "20.69972000" },
                        new() { Id = 11, Name = "Mborje", Latitude = "40.60333000", Longitude = "20.80306000" },
                        new() { Id = 12, Name = "Pogradec", Latitude = "40.90250000", Longitude = "20.65250000" },
                        new() { Id = 13, Name = "Rrethi i Devollit", Latitude = "40.58333000", Longitude = "20.91667000" },
                        new() { Id = 14, Name = "Rrethi i Kolonjës", Latitude = "40.25000000", Longitude = "20.66667000" },
                        new() { Id = 15, Name = "Velçan", Latitude = "40.95472000", Longitude = "20.46222000" },
                        new() { Id = 16, Name = "Voskopojë", Latitude = "40.63306000", Longitude = "20.58889000" }
                    }
                },

                new()
                {
                    Id = 20,
                    Name = "Korçë",
                    StateCode = "KO",
                    Latitude = "40.59056700",
                    Longitude = "20.61689210",
                    Type = "district",
                    Cities = new()
                    {
                    }
                },

                new()
                {
                    Id = 21,
                    Name = "Krujë",
                    StateCode = "KR",
                    Latitude = "41.50947650",
                    Longitude = "19.77107320",
                    Type = "district",
                    Cities = new()
                    {
                    }
                },

                new()
                {
                    Id = 22,
                    Name = "Kuçovë",
                    StateCode = "KC",
                    Latitude = "40.78370630",
                    Longitude = "19.87823480",
                    Type = "district",
                    Cities = new()
                    {
                    }
                },

                new()
                {
                    Id = 23,
                    Name = "Kukës",
                    StateCode = "KU",
                    Latitude = "42.08074640",
                    Longitude = "20.41429230",
                    Type = "district",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Bajram Curri", Latitude = "42.35734000", Longitude = "20.07679000" },
                        new() { Id = 2, Name = "Krumë", Latitude = "42.19694000", Longitude = "20.41333000" },
                        new() { Id = 3, Name = "Kukës", Latitude = "42.07694000", Longitude = "20.42194000" },
                        new() { Id = 4, Name = "Rrethi i Hasit", Latitude = "42.16667000", Longitude = "20.33333000" },
                        new() { Id = 5, Name = "Rrethi i Kukësit", Latitude = "42.00000000", Longitude = "20.33333000" }
                    }
                },

                new()
                {
                    Id = 24,
                    Name = "Kukës",
                    StateCode = "07",
                    Latitude = "42.08074640",
                    Longitude = "20.41429230",
                    Type = "county",
                    Cities = new()
                    {
                    }
                },

                new()
                {
                    Id = 25,
                    Name = "Kurbin",
                    StateCode = "KB",
                    Latitude = "41.64126440",
                    Longitude = "19.70559500",
                    Type = "district",
                    Cities = new()
                    {
                    }
                },

                new()
                {
                    Id = 26,
                    Name = "Lezhë",
                    StateCode = "08",
                    Latitude = "41.78137590",
                    Longitude = "19.80679160",
                    Type = "county",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Bashkia Kurbin", Latitude = "41.62215000", Longitude = "19.70734000" },
                        new() { Id = 2, Name = "Bashkia Lezhë", Latitude = "41.81320000", Longitude = "19.64121000" },
                        new() { Id = 3, Name = "Bashkia Mirditë", Latitude = "41.80953000", Longitude = "19.99024000" },
                        new() { Id = 4, Name = "Kurbnesh", Latitude = "41.77972000", Longitude = "20.08361000" },
                        new() { Id = 5, Name = "Laç", Latitude = "41.63556000", Longitude = "19.71306000" },
                        new() { Id = 6, Name = "Lezhë", Latitude = "41.78361000", Longitude = "19.64361000" },
                        new() { Id = 7, Name = "Mamurras", Latitude = "41.57750000", Longitude = "19.69222000" },
                        new() { Id = 8, Name = "Milot", Latitude = "41.68389000", Longitude = "19.71556000" },
                        new() { Id = 9, Name = "Rrëshen", Latitude = "41.76750000", Longitude = "19.87556000" },
                        new() { Id = 10, Name = "Rrethi i Kurbinit", Latitude = "41.63333000", Longitude = "19.71667000" },
                        new() { Id = 11, Name = "Rubik", Latitude = "41.77444000", Longitude = "19.78611000" },
                        new() { Id = 12, Name = "Shëngjin", Latitude = "41.81361000", Longitude = "19.59389000" }
                    }
                },

                new()
                {
                    Id = 27,
                    Name = "Lezhë",
                    StateCode = "LE",
                    Latitude = "41.78607300",
                    Longitude = "19.64607580",
                    Type = "district",
                    Cities = new()
                    {
                    }
                },

                new()
                {
                    Id = 28,
                    Name = "Librazhd",
                    StateCode = "LB",
                    Latitude = "41.18292320",
                    Longitude = "20.31747690",
                    Type = "district",
                    Cities = new()
                    {
                    }
                },

                new()
                {
                    Id = 29,
                    Name = "Lushnjë",
                    StateCode = "LU",
                    Latitude = "40.94198300",
                    Longitude = "19.69964280",
                    Type = "district",
                    Cities = new()
                    {
                    }
                },

                new()
                {
                    Id = 30,
                    Name = "Malësi e Madhe",
                    StateCode = "MM",
                    Latitude = "42.42451730",
                    Longitude = "19.61631850",
                    Type = "district",
                    Cities = new()
                    {
                    }
                },

                new()
                {
                    Id = 31,
                    Name = "Mallakastër",
                    StateCode = "MK",
                    Latitude = "40.52733760",
                    Longitude = "19.78297910",
                    Type = "district",
                    Cities = new()
                    {
                    }
                },

                new()
                {
                    Id = 32,
                    Name = "Mat",
                    StateCode = "MT",
                    Latitude = "41.59376750",
                    Longitude = "19.99732440",
                    Type = "district",
                    Cities = new()
                    {
                    }
                },

                new()
                {
                    Id = 33,
                    Name = "Mirditë",
                    StateCode = "MR",
                    Latitude = "41.76428600",
                    Longitude = "19.90205090",
                    Type = "district",
                    Cities = new()
                    {
                    }
                },

                new()
                {
                    Id = 34,
                    Name = "Peqin",
                    StateCode = "PQ",
                    Latitude = "41.04709020",
                    Longitude = "19.75023840",
                    Type = "district",
                    Cities = new()
                    {
                    }
                },

                new()
                {
                    Id = 35,
                    Name = "Përmet",
                    StateCode = "PR",
                    Latitude = "40.23618370",
                    Longitude = "20.35173340",
                    Type = "district",
                    Cities = new()
                    {
                    }
                },

                new()
                {
                    Id = 36,
                    Name = "Pogradec",
                    StateCode = "PG",
                    Latitude = "40.90153140",
                    Longitude = "20.65562890",
                    Type = "district",
                    Cities = new()
                    {
                    }
                },

                new()
                {
                    Id = 37,
                    Name = "Pukë",
                    StateCode = "PU",
                    Latitude = "42.04697720",
                    Longitude = "19.89609680",
                    Type = "district",
                    Cities = new()
                    {
                    }
                },

                new()
                {
                    Id = 38,
                    Name = "Sarandë",
                    StateCode = "SR",
                    Latitude = "39.85921190",
                    Longitude = "20.02710010",
                    Type = "district",
                    Cities = new()
                    {
                    }
                },

                new()
                {
                    Id = 39,
                    Name = "Shkodër",
                    StateCode = "10",
                    Latitude = "42.15037100",
                    Longitude = "19.66393090",
                    Type = "county",
                    Cities = new()
                    {
                    }
                },

                new()
                {
                    Id = 40,
                    Name = "Shkodër",
                    StateCode = "SH",
                    Latitude = "42.06929850",
                    Longitude = "19.50325590",
                    Type = "district",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Bashkia Malësi e Madhe", Latitude = "42.36798000", Longitude = "19.58977000" },
                        new() { Id = 2, Name = "Bashkia Pukë", Latitude = "42.02997000", Longitude = "19.92778000" },
                        new() { Id = 3, Name = "Bashkia Vau i Dejës", Latitude = "42.04834000", Longitude = "19.69999000" },
                        new() { Id = 4, Name = "Fushë-Arrëz", Latitude = "42.06222000", Longitude = "20.01667000" },
                        new() { Id = 5, Name = "Koplik", Latitude = "42.21361000", Longitude = "19.43639000" },
                        new() { Id = 6, Name = "Pukë", Latitude = "42.04444000", Longitude = "19.89972000" },
                        new() { Id = 7, Name = "Rrethi i Malësia e Madhe", Latitude = "42.33333000", Longitude = "19.58333000" },
                        new() { Id = 8, Name = "Rrethi i Shkodrës", Latitude = "42.06917000", Longitude = "19.53506000" },
                        new() { Id = 9, Name = "Shkodër", Latitude = "42.06828000", Longitude = "19.51258000" },
                        new() { Id = 10, Name = "Vau i Dejës", Latitude = "42.01000000", Longitude = "19.62472000" },
                        new() { Id = 11, Name = "Vukatanë", Latitude = "42.02806000", Longitude = "19.54778000" }
                    }
                },

                new()
                {
                    Id = 41,
                    Name = "Skrapar",
                    StateCode = "SK",
                    Latitude = "40.53499460",
                    Longitude = "20.28322170",
                    Type = "district",
                    Cities = new()
                    {
                    }
                },

                new()
                {
                    Id = 42,
                    Name = "Tepelenë",
                    StateCode = "TE",
                    Latitude = "40.29666320",
                    Longitude = "20.01816730",
                    Type = "district",
                    Cities = new()
                    {
                    }
                },

                new()
                {
                    Id = 43,
                    Name = "Tirana",
                    StateCode = "TR",
                    Latitude = "41.32754590",
                    Longitude = "19.81869820",
                    Type = "district",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Bashkia Kavajë", Latitude = "41.18127000", Longitude = "19.55579000" },
                        new() { Id = 2, Name = "Bashkia Vorë", Latitude = "41.39804000", Longitude = "19.67703000" },
                        new() { Id = 3, Name = "Kamëz", Latitude = "41.38167000", Longitude = "19.76028000" },
                        new() { Id = 4, Name = "Kavajë", Latitude = "41.18556000", Longitude = "19.55694000" },
                        new() { Id = 5, Name = "Krrabë", Latitude = "41.21556000", Longitude = "19.97139000" },
                        new() { Id = 6, Name = "Rrethi i Kavajës", Latitude = "41.16667000", Longitude = "19.58333000" },
                        new() { Id = 7, Name = "Rrethi i Tiranës", Latitude = "41.33333000", Longitude = "19.91667000" },
                        new() { Id = 8, Name = "Rrogozhinë", Latitude = "41.07639000", Longitude = "19.66528000" },
                        new() { Id = 9, Name = "Sinaballaj", Latitude = "41.06889000", Longitude = "19.69944000" },
                        new() { Id = 10, Name = "Tirana", Latitude = "41.32750000", Longitude = "19.81889000" },
                        new() { Id = 11, Name = "Vorë", Latitude = "41.39083000", Longitude = "19.65500000" }
                    }
                },

                new()
                {
                    Id = 44,
                    Name = "Tirana",
                    StateCode = "11",
                    Latitude = "41.24275980",
                    Longitude = "19.80679160",
                    Type = "county",
                    Cities = new()
                    {
                    }
                },

                new()
                {
                    Id = 45,
                    Name = "Tropojë",
                    StateCode = "TP",
                    Latitude = "42.39821510",
                    Longitude = "20.16259550",
                    Type = "district",
                    Cities = new()
                    {
                    }
                },

                new()
                {
                    Id = 46,
                    Name = "Vlorë",
                    StateCode = "12",
                    Latitude = "40.15009600",
                    Longitude = "19.80679160",
                    Type = "county",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Bashkia Finiq", Latitude = "39.84393000", Longitude = "20.16659000" },
                        new() { Id = 2, Name = "Bashkia Himarë", Latitude = "40.11581000", Longitude = "19.81389000" },
                        new() { Id = 3, Name = "Bashkia Konispol", Latitude = "39.70064000", Longitude = "20.13353000" },
                        new() { Id = 4, Name = "Bashkia Selenicë", Latitude = "40.39503000", Longitude = "19.65958000" },
                        new() { Id = 5, Name = "Bashkia Vlorë", Latitude = "40.41340000", Longitude = "19.49792000" },
                        new() { Id = 6, Name = "Delvinë", Latitude = "39.95111000", Longitude = "20.09778000" },
                        new() { Id = 7, Name = "Himarë", Latitude = "40.10167000", Longitude = "19.74472000" },
                        new() { Id = 8, Name = "Konispol", Latitude = "39.65889000", Longitude = "20.18139000" },
                        new() { Id = 9, Name = "Ksamil", Latitude = "39.76889000", Longitude = "19.99972000" },
                        new() { Id = 10, Name = "Orikum", Latitude = "40.32528000", Longitude = "19.47139000" },
                        new() { Id = 11, Name = "Rrethi i Delvinës", Latitude = "39.91667000", Longitude = "20.08333000" },
                        new() { Id = 12, Name = "Sarandë", Latitude = "39.87534000", Longitude = "20.00477000" },
                        new() { Id = 13, Name = "Selenicë", Latitude = "40.53056000", Longitude = "19.63583000" },
                        new() { Id = 14, Name = "Vlorë", Latitude = "40.46860000", Longitude = "19.48318000" }
                    }
                },

                new()
                {
                    Id = 47,
                    Name = "Vlorë",
                    StateCode = "VL",
                    Latitude = "40.46606680",
                    Longitude = "19.49135600",
                    Type = "district",
                    Cities = new()
                    {
                    }
                }
            }
        };
    }
}
