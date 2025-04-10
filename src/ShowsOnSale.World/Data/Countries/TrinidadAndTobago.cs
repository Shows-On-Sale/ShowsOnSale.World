// ⚠️ WARNING: This file is automatically generated by scripts/generate-world.ps1
// DO NOT modify this file manually as it will be overwritten when the script is run again.
// To update the data, modify the source data in countries-states-cities-database and run the script.

using System.Collections.Generic;
using ShowsOnSale.World.Models;

namespace ShowsOnSale.World.Data.Countries
{
    public static class TrinidadAndTobago
    {
        public static Country Data { get; } = new()
        {
            Id = 226,
            Name = "Trinidad and Tobago",
            Iso3 = "TTO",
            Iso2 = "TT",
            NumericCode = "780",
            PhoneCode = "1",
            Capital = "Port of Spain",
            Currency = "TTD",
            CurrencyName = "Trinidad and Tobago dollar",
            CurrencySymbol = "$",
            Tld = ".tt",
            Native = "Trinidad and Tobago",
            Region = "Americas",
            RegionId = 2,
            Subregion = "Caribbean",
            SubregionId = 7,
            Nationality = "Trinidadian or Tobagonian",
            Latitude = "11.00000000",
            Longitude = "-61.00000000",
            Emoji = "🇹🇹",
            EmojiU = "U+1F1F9 U+1F1F9",
            Timezones = new()
            {
                new() { ZoneName = "America/Port_of_Spain", GmtOffset = -14400, GmtOffsetName = "UTC-04:00", Abbreviation = "AST", TzName = "Atlantic Standard Time" }
            },
            Translations = new()
            {
                ["ko"] = "트리니다드 토바고",
                ["pt-BR"] = "Trinidad e Tobago",
                ["pt"] = "Trindade e Tobago",
                ["nl"] = "Trinidad en Tobago",
                ["hr"] = "Trinidad i Tobago",
                ["fa"] = "ترینیداد و توباگو",
                ["de"] = "Trinidad und Tobago",
                ["es"] = "Trinidad y Tobago",
                ["fr"] = "Trinité et Tobago",
                ["ja"] = "トリニダード・トバゴ",
                ["it"] = "Trinidad e Tobago",
                ["zh-CN"] = "特立尼达和多巴哥",
                ["tr"] = "Trinidad Ve Tobago",
                ["ru"] = "Тринидад и Тобаго",
                ["uk"] = "Тринідад і Тобаго",
                ["pl"] = "Trynidad i Tobago"
            },
            States = new()
            {

                new()
                {
                    Id = 1,
                    Name = "Arima",
                    StateCode = "ARI",
                    Latitude = "46.79316040",
                    Longitude = "-71.25843110",
                    Type = "borough",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Arima", Latitude = "10.63737000", Longitude = "-61.28228000" }
                    }
                },

                new()
                {
                    Id = 2,
                    Name = "Chaguanas",
                    StateCode = "CHA",
                    Latitude = "10.51683870",
                    Longitude = "-61.41144820",
                    Type = "borough",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Chaguanas", Latitude = "10.51667000", Longitude = "-61.41667000" },
                        new() { Id = 2, Name = "Ward of Chaguanas", Latitude = "10.50000000", Longitude = "-61.38333000" }
                    }
                },

                new()
                {
                    Id = 3,
                    Name = "Couva-Tabaquite-Talparo",
                    StateCode = "CTT",
                    Latitude = "10.42971450",
                    Longitude = "-61.37352100",
                    Type = "region",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Couva", Latitude = "10.42248000", Longitude = "-61.46748000" },
                        new() { Id = 2, Name = "Tabaquite", Latitude = "10.38824000", Longitude = "-61.29704000" }
                    }
                },

                new()
                {
                    Id = 4,
                    Name = "Diego Martin",
                    StateCode = "DMN",
                    Latitude = "10.73622860",
                    Longitude = "-61.55448360",
                    Type = "region",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Petit Valley", Latitude = "10.69974000", Longitude = "-61.54717000" },
                        new() { Id = 2, Name = "Ward of Diego Martin", Latitude = "10.70000000", Longitude = "-61.58333000" }
                    }
                },

                new()
                {
                    Id = 5,
                    Name = "Eastern Tobago",
                    StateCode = "ETO",
                    Latitude = "11.29793480",
                    Longitude = "-60.55885240",
                    Type = "region",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Scarborough", Latitude = "11.18229000", Longitude = "-60.73525000" }
                    }
                },

                new()
                {
                    Id = 6,
                    Name = "Penal-Debe",
                    StateCode = "PED",
                    Latitude = "10.13374020",
                    Longitude = "-61.44354740",
                    Type = "region",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Debe", Latitude = "10.20846000", Longitude = "-61.45273000" },
                        new() { Id = 2, Name = "Peñal", Latitude = "10.16667000", Longitude = "-61.46667000" }
                    }
                },

                new()
                {
                    Id = 7,
                    Name = "Point Fortin",
                    StateCode = "PTF",
                    Latitude = "10.17027370",
                    Longitude = "-61.67133860",
                    Type = "borough",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Point Fortin", Latitude = "10.17411000", Longitude = "-61.68407000" }
                    }
                },

                new()
                {
                    Id = 8,
                    Name = "Port of Spain",
                    StateCode = "POS",
                    Latitude = "10.66031960",
                    Longitude = "-61.50856250",
                    Type = "city",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Mucurapo", Latitude = "10.66253000", Longitude = "-61.53697000" },
                        new() { Id = 2, Name = "Port of Spain", Latitude = "10.66668000", Longitude = "-61.51889000" }
                    }
                },

                new()
                {
                    Id = 9,
                    Name = "Princes Town",
                    StateCode = "PRT",
                    Latitude = "10.17867460",
                    Longitude = "-61.28019960",
                    Type = "region",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Princes Town", Latitude = "10.27184000", Longitude = "-61.37103000" }
                    }
                },

                new()
                {
                    Id = 10,
                    Name = "Rio Claro-Mayaro",
                    StateCode = "MRC",
                    Latitude = "10.24128320",
                    Longitude = "-61.09372060",
                    Type = "region",
                    Cities = new()
                    {
                    }
                },

                new()
                {
                    Id = 11,
                    Name = "San Fernando",
                    StateCode = "SFO",
                    Latitude = "34.28194610",
                    Longitude = "-118.43897190",
                    Type = "region",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Marabella", Latitude = "10.30618000", Longitude = "-61.44671000" },
                        new() { Id = 2, Name = "Mon Repos", Latitude = "10.27979000", Longitude = "-61.44590000" },
                        new() { Id = 3, Name = "San Fernando", Latitude = "10.27969000", Longitude = "-61.46835000" }
                    }
                },

                new()
                {
                    Id = 12,
                    Name = "San Juan-Laventille",
                    StateCode = "SJL",
                    Latitude = "10.69085780",
                    Longitude = "-61.45522130",
                    Type = "region",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Laventille", Latitude = "10.64917000", Longitude = "-61.49889000" }
                    }
                },

                new()
                {
                    Id = 13,
                    Name = "Sangre Grande",
                    StateCode = "SGE",
                    Latitude = "10.58529390",
                    Longitude = "-61.13158130",
                    Type = "region",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Sangre Grande", Latitude = "10.58705000", Longitude = "-61.13008000" }
                    }
                },

                new()
                {
                    Id = 14,
                    Name = "Siparia",
                    StateCode = "SIP",
                    Latitude = "10.12456260",
                    Longitude = "-61.56032440",
                    Type = "region",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Siparia", Latitude = "10.14525000", Longitude = "-61.50740000" },
                        new() { Id = 2, Name = "Ward of Siparia", Latitude = "10.15000000", Longitude = "-61.46667000" }
                    }
                },

                new()
                {
                    Id = 15,
                    Name = "Tunapuna-Piarco",
                    StateCode = "TUP",
                    Latitude = "10.68590960",
                    Longitude = "-61.30352480",
                    Type = "region",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Arouca", Latitude = "10.62877000", Longitude = "-61.33487000" },
                        new() { Id = 2, Name = "Paradise", Latitude = "10.65298000", Longitude = "-61.36298000" },
                        new() { Id = 3, Name = "Tunapuna", Latitude = "10.65245000", Longitude = "-61.38878000" }
                    }
                },

                new()
                {
                    Id = 16,
                    Name = "Western Tobago",
                    StateCode = "WTO",
                    Latitude = "11.18970720",
                    Longitude = "-60.77954520",
                    Type = "region",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Rio Claro", Latitude = "10.30594000", Longitude = "-61.17556000" }
                    }
                }
            }
        };
    }
}
