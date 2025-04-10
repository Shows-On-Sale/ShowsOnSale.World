// ⚠️ WARNING: This file is automatically generated by scripts/generate-world.ps1
// DO NOT modify this file manually as it will be overwritten when the script is run again.
// To update the data, modify the source data in countries-states-cities-database and run the script.

using System.Collections.Generic;
using ShowsOnSale.World.Models;

namespace ShowsOnSale.World.Data.Countries
{
    public static class Sudan
    {
        public static Country Data { get; } = new()
        {
            Id = 210,
            Name = "Sudan",
            Iso3 = "SDN",
            Iso2 = "SD",
            NumericCode = "729",
            PhoneCode = "249",
            Capital = "Khartoum",
            Currency = "SDG",
            CurrencyName = "Sudanese pound",
            CurrencySymbol = ".س.ج",
            Tld = ".sd",
            Native = "السودان",
            Region = "Africa",
            RegionId = 1,
            Subregion = "Northern Africa",
            SubregionId = 1,
            Nationality = "Sudanese",
            Latitude = "15.00000000",
            Longitude = "30.00000000",
            Emoji = "🇸🇩",
            EmojiU = "U+1F1F8 U+1F1E9",
            Timezones = new()
            {
                new() { ZoneName = "Africa/Khartoum", GmtOffset = 7200, GmtOffsetName = "UTC+02:00", Abbreviation = "EAT", TzName = "Eastern African Time" }
            },
            Translations = new()
            {
                ["ko"] = "수단",
                ["pt-BR"] = "Sudão",
                ["pt"] = "Sudão",
                ["nl"] = "Soedan",
                ["hr"] = "Sudan",
                ["fa"] = "سودان",
                ["de"] = "Sudan",
                ["es"] = "Sudán",
                ["fr"] = "Soudan",
                ["ja"] = "スーダン",
                ["it"] = "Sudan",
                ["zh-CN"] = "苏丹",
                ["tr"] = "Sudan",
                ["ru"] = "Судан",
                ["uk"] = "Судан",
                ["pl"] = "Sudan"
            },
            States = new()
            {

                new()
                {
                    Id = 1,
                    Name = "Al Jazirah",
                    StateCode = "GZ",
                    Latitude = "14.88596110",
                    Longitude = "33.43835300",
                    Type = "state",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Al Hasaheisa", Latitude = "14.75264000", Longitude = "33.29836000" },
                        new() { Id = 2, Name = "Al Hilāliyya", Latitude = "14.93980000", Longitude = "33.23400000" },
                        new() { Id = 3, Name = "Al Kiremit al ‘Arakiyyīn", Latitude = "14.34760000", Longitude = "32.94370000" },
                        new() { Id = 4, Name = "Al Manāqil", Latitude = "14.24590000", Longitude = "32.98910000" },
                        new() { Id = 5, Name = "Al Masallamiyya", Latitude = "14.57480000", Longitude = "33.33730000" },
                        new() { Id = 6, Name = "Wad Medani", Latitude = "14.40118000", Longitude = "33.51989000" },
                        new() { Id = 7, Name = "Wad Rāwah", Latitude = "15.16028000", Longitude = "33.13972000" }
                    }
                },

                new()
                {
                    Id = 2,
                    Name = "Al Qadarif",
                    StateCode = "GD",
                    Latitude = "14.02430700",
                    Longitude = "35.36856790",
                    Type = "state",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Al Ḩawātah", Latitude = "13.41667000", Longitude = "34.63333000" },
                        new() { Id = 2, Name = "Al Qadarif", Latitude = "14.03493000", Longitude = "35.38344000" },
                        new() { Id = 3, Name = "Doka", Latitude = "13.51667000", Longitude = "35.76667000" }
                    }
                },

                new()
                {
                    Id = 3,
                    Name = "Blue Nile",
                    StateCode = "NB",
                    Latitude = "47.59867300",
                    Longitude = "-122.33441900",
                    Type = "state",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Ad-Damazin", Latitude = "11.78910000", Longitude = "34.35920000" },
                        new() { Id = 2, Name = "Ar Ruseris", Latitude = "11.86590000", Longitude = "34.38690000" },
                        new() { Id = 3, Name = "Kurmuk", Latitude = "10.55000000", Longitude = "34.28333000" }
                    }
                },

                new()
                {
                    Id = 4,
                    Name = "Central Darfur",
                    StateCode = "DC",
                    Latitude = "14.37827470",
                    Longitude = "24.90422080",
                    Type = "state",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Zalingei", Latitude = "12.90918000", Longitude = "23.47058000" }
                    }
                },

                new()
                {
                    Id = 5,
                    Name = "East Darfur",
                    StateCode = "DE",
                    Latitude = "14.37827470",
                    Longitude = "24.90422080",
                    Type = "state",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "El Daein", Latitude = "11.46186000", Longitude = "26.12583000" }
                    }
                },

                new()
                {
                    Id = 6,
                    Name = "Kassala",
                    StateCode = "KA",
                    Latitude = "15.45813320",
                    Longitude = "36.40396290",
                    Type = "state",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Aroma", Latitude = "15.81667000", Longitude = "36.13333000" },
                        new() { Id = 2, Name = "Kassala", Latitude = "15.45099000", Longitude = "36.39998000" },
                        new() { Id = 3, Name = "Wagar", Latitude = "16.15250000", Longitude = "36.20320000" }
                    }
                },

                new()
                {
                    Id = 7,
                    Name = "Khartoum",
                    StateCode = "KH",
                    Latitude = "15.50065440",
                    Longitude = "32.55989940",
                    Type = "state",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Khartoum", Latitude = "15.55177000", Longitude = "32.53241000" },
                        new() { Id = 2, Name = "Omdurman", Latitude = "15.64453000", Longitude = "32.47773000" }
                    }
                },

                new()
                {
                    Id = 8,
                    Name = "North Darfur",
                    StateCode = "DN",
                    Latitude = "15.76619690",
                    Longitude = "24.90422080",
                    Type = "state",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "El Fasher", Latitude = "13.62793000", Longitude = "25.34936000" },
                        new() { Id = 2, Name = "Kutum", Latitude = "14.20000000", Longitude = "24.66667000" },
                        new() { Id = 3, Name = "Umm Kaddadah", Latitude = "13.60169000", Longitude = "26.68759000" }
                    }
                },

                new()
                {
                    Id = 9,
                    Name = "North Kordofan",
                    StateCode = "KN",
                    Latitude = "13.83064410",
                    Longitude = "29.41793240",
                    Type = "state",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Ar Rahad", Latitude = "12.71667000", Longitude = "30.65000000" },
                        new() { Id = 2, Name = "Bārah", Latitude = "13.70000000", Longitude = "30.36667000" },
                        new() { Id = 3, Name = "El Obeid", Latitude = "13.18421000", Longitude = "30.21669000" },
                        new() { Id = 4, Name = "Umm Ruwaba", Latitude = "12.90610000", Longitude = "31.21580000" }
                    }
                },

                new()
                {
                    Id = 10,
                    Name = "Northern",
                    StateCode = "NO",
                    Latitude = "38.06381700",
                    Longitude = "-84.46286480",
                    Type = "state",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Ad Dabbah", Latitude = "18.05000000", Longitude = "30.95000000" },
                        new() { Id = 2, Name = "Argo", Latitude = "19.51667000", Longitude = "30.41667000" },
                        new() { Id = 3, Name = "Dongola", Latitude = "19.18163000", Longitude = "30.47689000" },
                        new() { Id = 4, Name = "Karmah an Nuzul", Latitude = "19.63333000", Longitude = "30.41667000" },
                        new() { Id = 5, Name = "Kuraymah", Latitude = "18.55000000", Longitude = "31.85000000" },
                        new() { Id = 6, Name = "Merowe", Latitude = "18.47036000", Longitude = "31.81126000" }
                    }
                },

                new()
                {
                    Id = 11,
                    Name = "Red Sea",
                    StateCode = "RS",
                    Latitude = "20.28023200",
                    Longitude = "38.51257300",
                    Type = "state",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Gebeit", Latitude = "21.06667000", Longitude = "36.31667000" },
                        new() { Id = 2, Name = "Port Sudan", Latitude = "19.61745000", Longitude = "37.21644000" },
                        new() { Id = 3, Name = "Sawākin", Latitude = "19.10590000", Longitude = "37.33210000" },
                        new() { Id = 4, Name = "Tokār", Latitude = "18.42540000", Longitude = "37.72900000" }
                    }
                },

                new()
                {
                    Id = 12,
                    Name = "River Nile",
                    StateCode = "NR",
                    Latitude = "23.97275950",
                    Longitude = "32.87492060",
                    Type = "state",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Atbara", Latitude = "17.70217000", Longitude = "33.98638000" },
                        new() { Id = 2, Name = "Berber", Latitude = "18.02158000", Longitude = "33.98299000" },
                        new() { Id = 3, Name = "Ed Damer", Latitude = "17.59898000", Longitude = "33.97205000" },
                        new() { Id = 4, Name = "El Bauga", Latitude = "18.26197000", Longitude = "33.90812000" },
                        new() { Id = 5, Name = "El Matama", Latitude = "16.70950000", Longitude = "33.35650000" },
                        new() { Id = 6, Name = "Shendi", Latitude = "16.69150000", Longitude = "33.43410000" }
                    }
                },

                new()
                {
                    Id = 13,
                    Name = "Sennar",
                    StateCode = "SI",
                    Latitude = "13.56746900",
                    Longitude = "33.56720450",
                    Type = "state",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Ad Dindar", Latitude = "13.20000000", Longitude = "34.16667000" },
                        new() { Id = 2, Name = "As Sūkī", Latitude = "13.31667000", Longitude = "33.88333000" },
                        new() { Id = 3, Name = "Jalqani", Latitude = "12.44860000", Longitude = "34.21860000" },
                        new() { Id = 4, Name = "Kināna", Latitude = "14.03610000", Longitude = "33.17120000" },
                        new() { Id = 5, Name = "Maiurno", Latitude = "13.41667000", Longitude = "33.66667000" },
                        new() { Id = 6, Name = "Singa", Latitude = "13.14830000", Longitude = "33.93117000" },
                        new() { Id = 7, Name = "Sinnar", Latitude = "13.56907000", Longitude = "33.56718000" }
                    }
                },

                new()
                {
                    Id = 14,
                    Name = "South Darfur",
                    StateCode = "DS",
                    Latitude = "11.64886390",
                    Longitude = "24.90422080",
                    Type = "state",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Gereida", Latitude = "11.27543000", Longitude = "25.14026000" },
                        new() { Id = 2, Name = "Nyala", Latitude = "12.04888000", Longitude = "24.88069000" }
                    }
                },

                new()
                {
                    Id = 15,
                    Name = "South Kordofan",
                    StateCode = "KS",
                    Latitude = "11.19901920",
                    Longitude = "29.41793240",
                    Type = "state",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Abu Jibeha", Latitude = "11.45620000", Longitude = "31.22850000" },
                        new() { Id = 2, Name = "Al Fūlah", Latitude = "11.73292000", Longitude = "28.35786000" },
                        new() { Id = 3, Name = "Dilling", Latitude = "12.05000000", Longitude = "29.65000000" },
                        new() { Id = 4, Name = "Kadugli", Latitude = "11.01111000", Longitude = "29.71833000" },
                        new() { Id = 5, Name = "Talodi", Latitude = "10.63246000", Longitude = "30.37970000" }
                    }
                },

                new()
                {
                    Id = 16,
                    Name = "West Darfur",
                    StateCode = "DW",
                    Latitude = "12.84635610",
                    Longitude = "23.00119890",
                    Type = "state",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Geneina", Latitude = "13.45262000", Longitude = "22.44725000" }
                    }
                },

                new()
                {
                    Id = 17,
                    Name = "West Kordofan",
                    StateCode = "GK",
                    Latitude = "11.19901920",
                    Longitude = "29.41793240",
                    Type = "state",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Abū Zabad", Latitude = "12.35000000", Longitude = "29.25000000" },
                        new() { Id = 2, Name = "Al Lagowa", Latitude = "11.40000000", Longitude = "29.13333000" },
                        new() { Id = 3, Name = "Al Mijlad", Latitude = "11.03333000", Longitude = "27.73333000" },
                        new() { Id = 4, Name = "An Nuhūd", Latitude = "12.70000000", Longitude = "28.43333000" }
                    }
                },

                new()
                {
                    Id = 18,
                    Name = "White Nile",
                    StateCode = "NW",
                    Latitude = "9.33215160",
                    Longitude = "31.46153000",
                    Type = "state",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Ad Douiem", Latitude = "14.00120000", Longitude = "32.31160000" },
                        new() { Id = 2, Name = "Al Kawa", Latitude = "13.74630000", Longitude = "32.49960000" },
                        new() { Id = 3, Name = "Al Qiţena", Latitude = "14.86480000", Longitude = "32.36680000" },
                        new() { Id = 4, Name = "Kosti", Latitude = "13.16290000", Longitude = "32.66347000" },
                        new() { Id = 5, Name = "Marabba", Latitude = "12.35000000", Longitude = "32.18333000" },
                        new() { Id = 6, Name = "Rabak", Latitude = "13.18087000", Longitude = "32.73999000" },
                        new() { Id = 7, Name = "Tandaltī", Latitude = "13.01667000", Longitude = "31.86667000" },
                        new() { Id = 8, Name = "Um Jar Al Gharbiyya", Latitude = "13.80130000", Longitude = "32.40780000" },
                        new() { Id = 9, Name = "Wad az Zāki", Latitude = "14.46190000", Longitude = "32.20650000" }
                    }
                }
            }
        };
    }
}
