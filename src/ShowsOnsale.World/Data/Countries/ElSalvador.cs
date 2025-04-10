// ⚠️ WARNING: This file is automatically generated by scripts/generate-world.ps1
// DO NOT modify this file manually as it will be overwritten when the script is run again.
// To update the data, modify the source data in countries-states-cities-database and run the script.

using System.Collections.Generic;
using ShowsOnSale.World.Models;

namespace ShowsOnSale.World.Data.Countries
{
    public static class ElSalvador
    {
        public static Country Data { get; } = new()
        {
            Id = 66,
            Name = "El Salvador",
            Iso3 = "SLV",
            Iso2 = "SV",
            NumericCode = "222",
            PhoneCode = "503",
            Capital = "San Salvador",
            Currency = "USD",
            CurrencyName = "United States dollar",
            CurrencySymbol = "$",
            Tld = ".sv",
            Native = "El Salvador",
            Region = "Americas",
            RegionId = 2,
            Subregion = "Central America",
            SubregionId = 9,
            Nationality = "Salvadoran",
            Latitude = "13.83333333",
            Longitude = "-88.91666666",
            Emoji = "🇸🇻",
            EmojiU = "U+1F1F8 U+1F1FB",
            Timezones = new()
            {
                new() { ZoneName = "America/El_Salvador", GmtOffset = -21600, GmtOffsetName = "UTC-06:00", Abbreviation = "CST", TzName = "Central Standard Time (North America" }
            },
            Translations = new()
            {
                ["ko"] = "엘살바도르",
                ["pt-BR"] = "El Salvador",
                ["pt"] = "El Salvador",
                ["nl"] = "El Salvador",
                ["hr"] = "Salvador",
                ["fa"] = "السالوادور",
                ["de"] = "El Salvador",
                ["es"] = "El Salvador",
                ["fr"] = "Salvador",
                ["ja"] = "エルサルバドル",
                ["it"] = "El Salvador",
                ["zh-CN"] = "萨尔瓦多",
                ["tr"] = "El Salvador",
                ["ru"] = "Сальвадор",
                ["uk"] = "Сальвадор",
                ["pl"] = "Salwador"
            },
            States = new()
            {

                new()
                {
                    Id = 1,
                    Name = "Ahuachapán",
                    StateCode = "AH",
                    Latitude = "13.82161480",
                    Longitude = "-89.92532330",
                    Type = "department",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Ahuachapán", Latitude = "13.92139000", Longitude = "-89.84500000" },
                        new() { Id = 2, Name = "Atiquizaya", Latitude = "13.97694000", Longitude = "-89.75250000" },
                        new() { Id = 3, Name = "Concepción de Ataco", Latitude = "13.87028000", Longitude = "-89.84861000" },
                        new() { Id = 4, Name = "Guaymango", Latitude = "13.75028000", Longitude = "-89.84222000" },
                        new() { Id = 5, Name = "Jujutla", Latitude = "13.78694000", Longitude = "-89.85722000" },
                        new() { Id = 6, Name = "San Francisco Menéndez", Latitude = "13.84306000", Longitude = "-90.01583000" },
                        new() { Id = 7, Name = "Tacuba", Latitude = "13.90111000", Longitude = "-89.92972000" }
                    }
                },

                new()
                {
                    Id = 2,
                    Name = "Cabañas",
                    StateCode = "CA",
                    Latitude = "13.86482880",
                    Longitude = "-88.74939980",
                    Type = "department",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Sensuntepeque", Latitude = "13.86667000", Longitude = "-88.63333000" },
                        new() { Id = 2, Name = "Victoria", Latitude = "13.95000000", Longitude = "-88.63333000" }
                    }
                },

                new()
                {
                    Id = 3,
                    Name = "Chalatenango",
                    StateCode = "CH",
                    Latitude = "14.19166480",
                    Longitude = "-89.17059980",
                    Type = "department",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Chalatenango", Latitude = "14.03333000", Longitude = "-88.93333000" },
                        new() { Id = 2, Name = "Nueva Concepción", Latitude = "14.13333000", Longitude = "-89.30000000" }
                    }
                },

                new()
                {
                    Id = 4,
                    Name = "Cuscatlán",
                    StateCode = "CU",
                    Latitude = "13.86619570",
                    Longitude = "-89.05615320",
                    Type = "department",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Cojutepeque", Latitude = "13.71667000", Longitude = "-88.93333000" },
                        new() { Id = 2, Name = "San Martín", Latitude = "13.78333000", Longitude = "-88.91667000" },
                        new() { Id = 3, Name = "Suchitoto", Latitude = "13.93806000", Longitude = "-89.02778000" },
                        new() { Id = 4, Name = "Tecoluca", Latitude = "13.78917000", Longitude = "-89.00528000" },
                        new() { Id = 5, Name = "Tenancingo", Latitude = "13.83333000", Longitude = "-88.98333000" }
                    }
                },

                new()
                {
                    Id = 5,
                    Name = "La Libertad",
                    StateCode = "LI",
                    Latitude = "13.68176610",
                    Longitude = "-89.36062980",
                    Type = "department",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Antiguo Cuscatlán", Latitude = "13.66492000", Longitude = "-89.25319000" },
                        new() { Id = 2, Name = "Ciudad Arce", Latitude = "13.84028000", Longitude = "-89.44722000" },
                        new() { Id = 3, Name = "La Libertad", Latitude = "13.48833000", Longitude = "-89.32222000" },
                        new() { Id = 4, Name = "Nuevo Cuscatlán", Latitude = "13.64861000", Longitude = "-89.26528000" },
                        new() { Id = 5, Name = "Quezaltepeque", Latitude = "13.83124000", Longitude = "-89.27221000" },
                        new() { Id = 6, Name = "San Juan Opico", Latitude = "13.87611000", Longitude = "-89.35972000" },
                        new() { Id = 7, Name = "San Pablo Tacachico", Latitude = "13.97556000", Longitude = "-89.34000000" },
                        new() { Id = 8, Name = "Santa Tecla", Latitude = "13.67694000", Longitude = "-89.27972000" },
                        new() { Id = 9, Name = "Zaragoza", Latitude = "13.58944000", Longitude = "-89.28889000" }
                    }
                },

                new()
                {
                    Id = 6,
                    Name = "La Paz",
                    StateCode = "PA",
                    Latitude = "",
                    Longitude = "",
                    Type = "department",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "El Rosario", Latitude = "13.49778000", Longitude = "-89.02972000" },
                        new() { Id = 2, Name = "Olocuilta", Latitude = "13.56972000", Longitude = "-89.11722000" },
                        new() { Id = 3, Name = "San Pedro Masahuat", Latitude = "13.54361000", Longitude = "-89.03861000" },
                        new() { Id = 4, Name = "Santiago Nonualco", Latitude = "13.51667000", Longitude = "-88.95000000" },
                        new() { Id = 5, Name = "Zacatecoluca", Latitude = "13.50000000", Longitude = "-88.86667000" }
                    }
                },

                new()
                {
                    Id = 7,
                    Name = "La Unión ",
                    StateCode = "UN",
                    Latitude = "13.48864430",
                    Longitude = "-87.89424510",
                    Type = "department",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Anamorós", Latitude = "13.74056000", Longitude = "-87.87361000" },
                        new() { Id = 2, Name = "Conchagua", Latitude = "13.30778000", Longitude = "-87.86472000" },
                        new() { Id = 3, Name = "Intipucá", Latitude = "13.19694000", Longitude = "-88.05444000" },
                        new() { Id = 4, Name = "La Unión", Latitude = "13.33694000", Longitude = "-87.84389000" },
                        new() { Id = 5, Name = "Nueva Esparta", Latitude = "13.78361000", Longitude = "-87.83861000" },
                        new() { Id = 6, Name = "Pasaquina", Latitude = "13.58444000", Longitude = "-87.84111000" },
                        new() { Id = 7, Name = "San Alejo", Latitude = "13.43139000", Longitude = "-87.96306000" },
                        new() { Id = 8, Name = "Santa Rosa de Lima", Latitude = "13.62472000", Longitude = "-87.89361000" }
                    }
                },

                new()
                {
                    Id = 8,
                    Name = "Morazán",
                    StateCode = "MO",
                    Latitude = "13.76820000",
                    Longitude = "-88.12913870",
                    Type = "department",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Cacaopera", Latitude = "13.76667000", Longitude = "-88.08333000" },
                        new() { Id = 2, Name = "Corinto", Latitude = "13.81083000", Longitude = "-87.97139000" },
                        new() { Id = 3, Name = "Guatajiagua", Latitude = "13.66667000", Longitude = "-88.20000000" },
                        new() { Id = 4, Name = "Jocoro", Latitude = "13.61667000", Longitude = "-88.01667000" },
                        new() { Id = 5, Name = "San Francisco", Latitude = "13.70000000", Longitude = "-88.10000000" },
                        new() { Id = 6, Name = "Sociedad", Latitude = "13.70000000", Longitude = "-88.01667000" }
                    }
                },

                new()
                {
                    Id = 9,
                    Name = "San Miguel",
                    StateCode = "SM",
                    Latitude = "13.44510410",
                    Longitude = "-88.24611830",
                    Type = "department",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Chapeltique", Latitude = "13.63333000", Longitude = "-88.26667000" },
                        new() { Id = 2, Name = "Chinameca", Latitude = "13.50000000", Longitude = "-88.35000000" },
                        new() { Id = 3, Name = "Chirilagua", Latitude = "13.22028000", Longitude = "-88.13861000" },
                        new() { Id = 4, Name = "Ciudad Barrios", Latitude = "13.76667000", Longitude = "-88.26667000" },
                        new() { Id = 5, Name = "El Tránsito", Latitude = "13.35000000", Longitude = "-88.35000000" },
                        new() { Id = 6, Name = "Lolotique", Latitude = "13.55000000", Longitude = "-88.35000000" },
                        new() { Id = 7, Name = "Moncagua", Latitude = "13.53333000", Longitude = "-88.25000000" },
                        new() { Id = 8, Name = "Nueva Guadalupe", Latitude = "13.53333000", Longitude = "-88.35000000" },
                        new() { Id = 9, Name = "San Miguel", Latitude = "13.48333000", Longitude = "-88.18333000" },
                        new() { Id = 10, Name = "San Rafael Oriente", Latitude = "13.38333000", Longitude = "-88.35000000" },
                        new() { Id = 11, Name = "Sesori", Latitude = "13.71667000", Longitude = "-88.36667000" }
                    }
                },

                new()
                {
                    Id = 10,
                    Name = "San Salvador",
                    StateCode = "SS",
                    Latitude = "13.77399970",
                    Longitude = "-89.20867730",
                    Type = "department",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Aguilares", Latitude = "13.95722000", Longitude = "-89.18972000" },
                        new() { Id = 2, Name = "Apopa", Latitude = "13.80722000", Longitude = "-89.17917000" },
                        new() { Id = 3, Name = "Ayutuxtepeque", Latitude = "13.74556000", Longitude = "-89.20639000" },
                        new() { Id = 4, Name = "Cuscatancingo", Latitude = "13.73611000", Longitude = "-89.18139000" },
                        new() { Id = 5, Name = "Delgado", Latitude = "13.72417000", Longitude = "-89.17028000" },
                        new() { Id = 6, Name = "El Paisnal", Latitude = "13.97361000", Longitude = "-89.21861000" },
                        new() { Id = 7, Name = "Guazapa", Latitude = "13.87694000", Longitude = "-89.17306000" },
                        new() { Id = 8, Name = "Ilopango", Latitude = "13.70167000", Longitude = "-89.10944000" },
                        new() { Id = 9, Name = "Mejicanos", Latitude = "13.74028000", Longitude = "-89.21306000" },
                        new() { Id = 10, Name = "Panchimalco", Latitude = "13.61278000", Longitude = "-89.18000000" },
                        new() { Id = 11, Name = "Rosario de Mora", Latitude = "13.57528000", Longitude = "-89.20889000" },
                        new() { Id = 12, Name = "San Marcos", Latitude = "13.65889000", Longitude = "-89.18306000" },
                        new() { Id = 13, Name = "San Salvador", Latitude = "13.68935000", Longitude = "-89.18718000" },
                        new() { Id = 14, Name = "Santo Tomás", Latitude = "13.64083000", Longitude = "-89.13333000" },
                        new() { Id = 15, Name = "Soyapango", Latitude = "13.71024000", Longitude = "-89.13989000" },
                        new() { Id = 16, Name = "Tonacatepeque", Latitude = "13.78111000", Longitude = "-89.11861000" }
                    }
                },

                new()
                {
                    Id = 11,
                    Name = "San Vicente",
                    StateCode = "SV",
                    Latitude = "13.58685610",
                    Longitude = "-88.74939980",
                    Type = "department",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Apastepeque", Latitude = "13.66667000", Longitude = "-88.78333000" },
                        new() { Id = 2, Name = "San Sebastián", Latitude = "13.73333000", Longitude = "-88.83333000" },
                        new() { Id = 3, Name = "San Vicente", Latitude = "13.63333000", Longitude = "-88.80000000" }
                    }
                },

                new()
                {
                    Id = 12,
                    Name = "Santa Ana",
                    StateCode = "SA",
                    Latitude = "14.14611210",
                    Longitude = "-89.51200840",
                    Type = "department",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Candelaria de La Frontera", Latitude = "14.11667000", Longitude = "-89.65000000" },
                        new() { Id = 2, Name = "Chalchuapa", Latitude = "13.98667000", Longitude = "-89.68111000" },
                        new() { Id = 3, Name = "Coatepeque", Latitude = "13.92861000", Longitude = "-89.50417000" },
                        new() { Id = 4, Name = "El Congo", Latitude = "13.90889000", Longitude = "-89.49583000" },
                        new() { Id = 5, Name = "Metapán", Latitude = "14.33333000", Longitude = "-89.45000000" },
                        new() { Id = 6, Name = "Santa Ana", Latitude = "13.99417000", Longitude = "-89.55972000" },
                        new() { Id = 7, Name = "Texistepeque", Latitude = "14.13333000", Longitude = "-89.50000000" }
                    }
                },

                new()
                {
                    Id = 13,
                    Name = "Sonsonate",
                    StateCode = "SO",
                    Latitude = "13.68235800",
                    Longitude = "-89.66281110",
                    Type = "department",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Acajutla", Latitude = "13.59278000", Longitude = "-89.82750000" },
                        new() { Id = 2, Name = "Armenia", Latitude = "13.74361000", Longitude = "-89.49889000" },
                        new() { Id = 3, Name = "Izalco", Latitude = "13.74472000", Longitude = "-89.67306000" },
                        new() { Id = 4, Name = "Juayúa", Latitude = "13.84139000", Longitude = "-89.74556000" },
                        new() { Id = 5, Name = "Nahuizalco", Latitude = "13.77750000", Longitude = "-89.73667000" },
                        new() { Id = 6, Name = "San Antonio del Monte", Latitude = "13.71639000", Longitude = "-89.73833000" },
                        new() { Id = 7, Name = "Sonsonate", Latitude = "13.71889000", Longitude = "-89.72417000" },
                        new() { Id = 8, Name = "Sonzacate", Latitude = "13.73417000", Longitude = "-89.71472000" }
                    }
                },

                new()
                {
                    Id = 14,
                    Name = "Usulután",
                    StateCode = "US",
                    Latitude = "13.44706340",
                    Longitude = "-88.55653100",
                    Type = "department",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Berlín", Latitude = "13.50000000", Longitude = "-88.53333000" },
                        new() { Id = 2, Name = "Concepción Batres", Latitude = "13.35000000", Longitude = "-88.36667000" },
                        new() { Id = 3, Name = "Jiquilisco", Latitude = "13.31667000", Longitude = "-88.58333000" },
                        new() { Id = 4, Name = "Jucuapa", Latitude = "13.51667000", Longitude = "-88.38333000" },
                        new() { Id = 5, Name = "Jucuarán", Latitude = "13.25389000", Longitude = "-88.24778000" },
                        new() { Id = 6, Name = "Ozatlán", Latitude = "13.38333000", Longitude = "-88.50000000" },
                        new() { Id = 7, Name = "Puerto El Triunfo", Latitude = "13.28333000", Longitude = "-88.55000000" },
                        new() { Id = 8, Name = "San Agustín", Latitude = "13.43333000", Longitude = "-88.60000000" },
                        new() { Id = 9, Name = "Santa Elena", Latitude = "13.38333000", Longitude = "-88.41667000" },
                        new() { Id = 10, Name = "Santiago de María", Latitude = "13.48333000", Longitude = "-88.46667000" },
                        new() { Id = 11, Name = "Usulután", Latitude = "13.35000000", Longitude = "-88.45000000" }
                    }
                }
            }
        };
    }
}
