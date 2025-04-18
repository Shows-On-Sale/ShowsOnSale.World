// ⚠️ WARNING: This file is automatically generated by scripts/generate-world.ps1
// DO NOT modify this file manually as it will be overwritten when the script is run again.
// To update the data, modify the source data in countries-states-cities-database and run the script.

using System.Collections.Generic;
using ShowsOnSale.World.Models;

namespace ShowsOnSale.World.Data.Countries
{
    public static class Ghana
    {
        public static Country Data { get; } = new()
        {
            Id = 83,
            Name = "Ghana",
            Iso3 = "GHA",
            Iso2 = "GH",
            NumericCode = "288",
            PhoneCode = "233",
            Capital = "Accra",
            Currency = "GHS",
            CurrencyName = "Ghanaian cedi",
            CurrencySymbol = "GH₵",
            Tld = ".gh",
            Native = "Ghana",
            Region = "Africa",
            RegionId = 1,
            Subregion = "Western Africa",
            SubregionId = 3,
            Nationality = "Ghanaian",
            Latitude = "8.00000000",
            Longitude = "-2.00000000",
            Emoji = "🇬🇭",
            EmojiU = "U+1F1EC U+1F1ED",
            Timezones = new()
            {
                new() { ZoneName = "Africa/Accra", GmtOffset = 0, GmtOffsetName = "UTC±00", Abbreviation = "GMT", TzName = "Greenwich Mean Time" }
            },
            Translations = new()
            {
                ["ko"] = "가나",
                ["pt-BR"] = "Gana",
                ["pt"] = "Gana",
                ["nl"] = "Ghana",
                ["hr"] = "Gana",
                ["fa"] = "غنا",
                ["de"] = "Ghana",
                ["es"] = "Ghana",
                ["fr"] = "Ghana",
                ["ja"] = "ガーナ",
                ["it"] = "Ghana",
                ["zh-CN"] = "加纳",
                ["tr"] = "Gana",
                ["ru"] = "Гана",
                ["uk"] = "Гана",
                ["pl"] = "Ghana"
            },
            States = new()
            {

                new()
                {
                    Id = 1,
                    Name = "Ahafo",
                    StateCode = "AF",
                    Latitude = "7.58213720",
                    Longitude = "-2.54974630",
                    Type = "region",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Asunafo North", Latitude = "6.81968910", Longitude = "-2.80770500" },
                        new() { Id = 2, Name = "Asunafo South", Latitude = "6.64801380", Longitude = "-2.68874370" },
                        new() { Id = 3, Name = "Asutifi North", Latitude = "6.94774860", Longitude = "-2.76757160" },
                        new() { Id = 4, Name = "Asutifi South", Latitude = "6.64801380", Longitude = "-2.68874370" },
                        new() { Id = 5, Name = "Tano North", Latitude = "7.22603010", Longitude = "-2.30456560" },
                        new() { Id = 6, Name = "Tano South", Latitude = "7.19537930", Longitude = "-2.12586610" }
                    }
                },

                new()
                {
                    Id = 2,
                    Name = "Ashanti",
                    StateCode = "AH",
                    Latitude = "6.74704360",
                    Longitude = "-1.52086240",
                    Type = "region",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Agogo", Latitude = "6.80004000", Longitude = "-1.08193000" },
                        new() { Id = 2, Name = "Bekwai", Latitude = "6.45195000", Longitude = "-1.57866000" },
                        new() { Id = 3, Name = "Ejura", Latitude = "7.38558000", Longitude = "-1.35617000" },
                        new() { Id = 4, Name = "Konongo", Latitude = "6.61667000", Longitude = "-1.21667000" },
                        new() { Id = 5, Name = "Kumasi", Latitude = "6.68848000", Longitude = "-1.62443000" },
                        new() { Id = 6, Name = "Mampong", Latitude = "7.06273000", Longitude = "-1.40010000" },
                        new() { Id = 7, Name = "Obuase", Latitude = "6.20228000", Longitude = "-1.66796000" },
                        new() { Id = 8, Name = "Tafo", Latitude = "6.73156000", Longitude = "-1.61370000" }
                    }
                },

                new()
                {
                    Id = 3,
                    Name = "Bono",
                    StateCode = "BO",
                    Latitude = "7.65000000",
                    Longitude = "-2.50000000",
                    Type = "region",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Banda", Latitude = "8.14956710", Longitude = "-2.36639500" },
                        new() { Id = 2, Name = "Berekum East", Latitude = "7.51117580", Longitude = "-2.75998310" },
                        new() { Id = 3, Name = "Berekum West", Latitude = "7.51117580", Longitude = "-2.75998310" },
                        new() { Id = 4, Name = "Dormaa Central", Latitude = "7.27750000", Longitude = "-2.87833300" },
                        new() { Id = 5, Name = "Dormaa East", Latitude = "7.30000000", Longitude = "-2.70000000" },
                        new() { Id = 6, Name = "Dormaa West", Latitude = "7.01666700", Longitude = "-3.05000000" },
                        new() { Id = 7, Name = "Jaman North", Latitude = "7.98832340", Longitude = "-2.96858690" },
                        new() { Id = 8, Name = "Jaman South", Latitude = "7.70843750", Longitude = "-3.07501700" },
                        new() { Id = 9, Name = "Sunyani", Latitude = "7.33803320", Longitude = "-2.34871460" },
                        new() { Id = 10, Name = "Sunyani West", Latitude = "7.35660520", Longitude = "-2.44618620" },
                        new() { Id = 11, Name = "Tain", Latitude = "8.18114110", Longitude = "-2.86487620" },
                        new() { Id = 12, Name = "Wenchi", Latitude = "7.74059920", Longitude = "-2.12267880" }
                    }
                },

                new()
                {
                    Id = 4,
                    Name = "Bono East",
                    StateCode = "BE",
                    Latitude = "7.75000000",
                    Longitude = "-1.05000000",
                    Type = "region",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Atebubu-Amantin", Latitude = "7.70237000", Longitude = "-1.21979430" },
                        new() { Id = 2, Name = "Kintampo North", Latitude = "8.39635790", Longitude = "-1.82000070" },
                        new() { Id = 3, Name = "Kintampo South", Latitude = "7.98971320", Longitude = "-2.00711150" },
                        new() { Id = 4, Name = "Nkoranza North", Latitude = "7.56603310", Longitude = "-1.72365200" },
                        new() { Id = 5, Name = "Nkoranza South", Latitude = "7.62405120", Longitude = "-1.79974460" },
                        new() { Id = 6, Name = "Pru East", Latitude = "8.22620000", Longitude = "-0.65360000" },
                        new() { Id = 7, Name = "Pru West", Latitude = "8.07359930", Longitude = "-1.29055410" },
                        new() { Id = 8, Name = "Sene East", Latitude = "7.78300000", Longitude = "-0.21700000" },
                        new() { Id = 9, Name = "Sene West", Latitude = "7.73420000", Longitude = "-0.68180000" },
                        new() { Id = 10, Name = "Techiman", Latitude = "7.58968560", Longitude = "-1.95122140" },
                        new() { Id = 11, Name = "Techiman North", Latitude = "7.70428020", Longitude = "-2.08140570" }
                    }
                },

                new()
                {
                    Id = 5,
                    Name = "Central",
                    StateCode = "CP",
                    Latitude = "5.50000000",
                    Longitude = "-1.00000000",
                    Type = "region",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Apam", Latitude = "5.28483000", Longitude = "-0.73711000" },
                        new() { Id = 2, Name = "Cape Coast", Latitude = "5.10535000", Longitude = "-1.24660000" },
                        new() { Id = 3, Name = "Dunkwa", Latitude = "5.95996000", Longitude = "-1.77792000" },
                        new() { Id = 4, Name = "Elmina", Latitude = "5.08470000", Longitude = "-1.35093000" },
                        new() { Id = 5, Name = "Foso", Latitude = "5.70119000", Longitude = "-1.28657000" },
                        new() { Id = 6, Name = "Kasoa", Latitude = "5.53449000", Longitude = "-0.41679000" },
                        new() { Id = 7, Name = "Mumford", Latitude = "5.26176000", Longitude = "-0.75897000" },
                        new() { Id = 8, Name = "Saltpond", Latitude = "5.20913000", Longitude = "-1.06058000" },
                        new() { Id = 9, Name = "Swedru", Latitude = "5.53711000", Longitude = "-0.69984000" },
                        new() { Id = 10, Name = "Winneba", Latitude = "5.35113000", Longitude = "-0.62313000" }
                    }
                },

                new()
                {
                    Id = 6,
                    Name = "Eastern",
                    StateCode = "EP",
                    Latitude = "6.50000000",
                    Longitude = "-0.50000000",
                    Type = "region",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Aburi", Latitude = "5.84802000", Longitude = "-0.17449000" },
                        new() { Id = 2, Name = "Akim Oda", Latitude = "5.92665000", Longitude = "-0.98577000" },
                        new() { Id = 3, Name = "Akim Swedru", Latitude = "5.89380000", Longitude = "-1.01636000" },
                        new() { Id = 4, Name = "Akropong", Latitude = "5.97462000", Longitude = "-0.08542000" },
                        new() { Id = 5, Name = "Akwatia", Latitude = "6.04024000", Longitude = "-0.80876000" },
                        new() { Id = 6, Name = "Asamankese", Latitude = "5.86006000", Longitude = "-0.66350000" },
                        new() { Id = 7, Name = "Begoro", Latitude = "6.38706000", Longitude = "-0.37738000" },
                        new() { Id = 8, Name = "Kibi", Latitude = "6.16494000", Longitude = "-0.55376000" },
                        new() { Id = 9, Name = "Koforidua", Latitude = "6.09408000", Longitude = "-0.25913000" },
                        new() { Id = 10, Name = "Mpraeso", Latitude = "6.59321000", Longitude = "-0.73462000" },
                        new() { Id = 11, Name = "Nsawam", Latitude = "5.80893000", Longitude = "-0.35026000" },
                        new() { Id = 12, Name = "Suhum", Latitude = "6.04089000", Longitude = "-0.45004000" }
                    }
                },

                new()
                {
                    Id = 7,
                    Name = "Greater Accra",
                    StateCode = "AA",
                    Latitude = "5.81428360",
                    Longitude = "0.07467670",
                    Type = "region",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Accra", Latitude = "5.55602000", Longitude = "-0.19690000" },
                        new() { Id = 2, Name = "Atsiaman", Latitude = "5.69775000", Longitude = "-0.32824000" },
                        new() { Id = 3, Name = "Dome", Latitude = "5.65003000", Longitude = "-0.23610000" },
                        new() { Id = 4, Name = "Gbawe", Latitude = "5.57692000", Longitude = "-0.31038000" },
                        new() { Id = 5, Name = "Medina Estates", Latitude = "5.66580000", Longitude = "-0.16307000" },
                        new() { Id = 6, Name = "Nungua", Latitude = "5.60105000", Longitude = "-0.07713000" },
                        new() { Id = 7, Name = "Tema", Latitude = "5.66980000", Longitude = "-0.01657000" },
                        new() { Id = 8, Name = "Teshi Old Town", Latitude = "5.58365000", Longitude = "-0.10722000" }
                    }
                },

                new()
                {
                    Id = 8,
                    Name = "North East",
                    StateCode = "NE",
                    Latitude = "10.51666700",
                    Longitude = "-0.36666700",
                    Type = "region",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Bunkpurugu-Nyakpanduri", Latitude = "10.46609170", Longitude = "-0.22711950" },
                        new() { Id = 2, Name = "Chereponi", Latitude = "10.13827720", Longitude = "0.28242580" },
                        new() { Id = 3, Name = "East Mamprusi", Latitude = "10.42931860", Longitude = "-0.53078850" },
                        new() { Id = 4, Name = "Mamprugu-Moagduri", Latitude = "10.23290000", Longitude = "-1.28360000" },
                        new() { Id = 5, Name = "West Mamprusi", Latitude = "10.29906060", Longitude = "-1.36750100" },
                        new() { Id = 6, Name = "Yunyoo-Nasuan", Latitude = "10.48400000", Longitude = "-0.00900000" }
                    }
                },

                new()
                {
                    Id = 9,
                    Name = "Northern",
                    StateCode = "NP",
                    Latitude = "9.50000000",
                    Longitude = "-1.00000000",
                    Type = "region",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Kpandae", Latitude = "8.46885000", Longitude = "-0.01127000" },
                        new() { Id = 2, Name = "Salaga", Latitude = "8.55083000", Longitude = "-0.51875000" },
                        new() { Id = 3, Name = "Savelugu", Latitude = "9.62441000", Longitude = "-0.82530000" },
                        new() { Id = 4, Name = "Tamale", Latitude = "9.40079000", Longitude = "-0.83930000" },
                        new() { Id = 5, Name = "Yendi", Latitude = "9.44272000", Longitude = "-0.00991000" }
                    }
                },

                new()
                {
                    Id = 10,
                    Name = "Oti",
                    StateCode = "OT",
                    Latitude = "7.90000000",
                    Longitude = "0.30000000",
                    Type = "region",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Biakoye", Latitude = "7.11698690", Longitude = "0.32324300" },
                        new() { Id = 2, Name = "Jasikan", Latitude = "7.40940880", Longitude = "0.44301500" },
                        new() { Id = 3, Name = "Kadjebi", Latitude = "7.52631920", Longitude = "0.46704770" },
                        new() { Id = 4, Name = "Krachi East", Latitude = "7.77196980", Longitude = "-0.07763760" },
                        new() { Id = 5, Name = "Krachi Nchumuru", Latitude = "8.14849800", Longitude = "-0.16349880" },
                        new() { Id = 6, Name = "Krachi West", Latitude = "7.98282160", Longitude = "-0.34886270" },
                        new() { Id = 7, Name = "Nkwanta North", Latitude = "8.35180760", Longitude = "0.12217620" },
                        new() { Id = 8, Name = "Nkwanta South", Latitude = "8.25931340", Longitude = "0.50185190" }
                    }
                },

                new()
                {
                    Id = 11,
                    Name = "Savannah",
                    StateCode = "SV",
                    Latitude = "9.08333300",
                    Longitude = "-1.81666700",
                    Type = "region",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Bole", Latitude = "9.02996640", Longitude = "-2.50694300" },
                        new() { Id = 2, Name = "Central Gonja", Latitude = "8.92784320", Longitude = "-1.95369720" },
                        new() { Id = 3, Name = "East Gonja", Latitude = "8.72568400", Longitude = "-1.07135790" },
                        new() { Id = 4, Name = "North East Gonja", Latitude = "9.11746690", Longitude = "-0.55579360" },
                        new() { Id = 5, Name = "North Gonja", Latitude = "9.54130850", Longitude = "-1.39766920" },
                        new() { Id = 6, Name = "Sawla-Tuna-Kalba", Latitude = "9.39114570", Longitude = "-2.70611660" },
                        new() { Id = 7, Name = "West Gonja", Latitude = "9.57513170", Longitude = "-2.26440410" }
                    }
                },

                new()
                {
                    Id = 12,
                    Name = "Upper East",
                    StateCode = "UE",
                    Latitude = "10.70824990",
                    Longitude = "-0.98206680",
                    Type = "region",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Bawku", Latitude = "11.06160000", Longitude = "-0.24169000" },
                        new() { Id = 2, Name = "Bolgatanga", Latitude = "10.78556000", Longitude = "-0.85139000" },
                        new() { Id = 3, Name = "Navrongo", Latitude = "10.89557000", Longitude = "-1.09210000" }
                    }
                },

                new()
                {
                    Id = 13,
                    Name = "Upper West",
                    StateCode = "UW",
                    Latitude = "10.25297570",
                    Longitude = "-2.14502450",
                    Type = "region",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Wa", Latitude = "10.06069000", Longitude = "-2.50192000" }
                    }
                },

                new()
                {
                    Id = 14,
                    Name = "Volta",
                    StateCode = "TV",
                    Latitude = "6.57813730",
                    Longitude = "0.45023680",
                    Type = "region",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Aflao", Latitude = "6.11982000", Longitude = "1.19012000" },
                        new() { Id = 2, Name = "Anloga", Latitude = "5.79473000", Longitude = "0.89728000" },
                        new() { Id = 3, Name = "Ho", Latitude = "6.60084000", Longitude = "0.47130000" },
                        new() { Id = 4, Name = "Hohoe", Latitude = "7.15181000", Longitude = "0.47362000" },
                        new() { Id = 5, Name = "Keta", Latitude = "5.91793000", Longitude = "0.98789000" },
                        new() { Id = 6, Name = "Kete Krachi", Latitude = "7.79391000", Longitude = "-0.04980000" },
                        new() { Id = 7, Name = "Kpandu", Latitude = "6.99536000", Longitude = "0.29306000" }
                    }
                },

                new()
                {
                    Id = 15,
                    Name = "Western",
                    StateCode = "WP",
                    Latitude = "5.50000000",
                    Longitude = "-2.50000000",
                    Type = "region",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Aboso", Latitude = "5.36073000", Longitude = "-1.94856000" },
                        new() { Id = 2, Name = "Axim", Latitude = "4.86641000", Longitude = "-2.24181000" },
                        new() { Id = 3, Name = "Bibiani", Latitude = "6.46346000", Longitude = "-2.31938000" },
                        new() { Id = 4, Name = "Prestea", Latitude = "5.43385000", Longitude = "-2.14295000" },
                        new() { Id = 5, Name = "Sekondi-Takoradi", Latitude = "4.92678000", Longitude = "-1.75773000" },
                        new() { Id = 6, Name = "Shama Junction", Latitude = "5.01806000", Longitude = "-1.66437000" },
                        new() { Id = 7, Name = "Takoradi", Latitude = "4.89816000", Longitude = "-1.76029000" },
                        new() { Id = 8, Name = "Tarkwa", Latitude = "5.30383000", Longitude = "-1.98956000" }
                    }
                },

                new()
                {
                    Id = 16,
                    Name = "Western North",
                    StateCode = "WN",
                    Latitude = "6.30000000",
                    Longitude = "-2.80000000",
                    Type = "region",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Aowin", Latitude = "5.75309280", Longitude = "-3.07518870" },
                        new() { Id = 2, Name = "Bia East", Latitude = "6.76860400", Longitude = "-3.33302410" },
                        new() { Id = 3, Name = "Bia West", Latitude = "6.76860400", Longitude = "-3.33302410" },
                        new() { Id = 4, Name = "Bibiani-Anhwiaso-Bekwai", Latitude = "6.30210040", Longitude = "-2.35675070" },
                        new() { Id = 5, Name = "Bodi", Latitude = "6.22240910", Longitude = "-2.76615150" },
                        new() { Id = 6, Name = "Juaboso", Latitude = "6.33331570", Longitude = "-2.84206140" },
                        new() { Id = 7, Name = "Sefwi-Akontombra", Latitude = "6.04285480", Longitude = "-2.88133620" },
                        new() { Id = 8, Name = "Sefwi-Wiawso", Latitude = "6.21965670", Longitude = "-2.50059150" },
                        new() { Id = 9, Name = "Suaman", Latitude = "5.75309280", Longitude = "-3.07518870" }
                    }
                }
            }
        };
    }
}
