// ⚠️ WARNING: This file is automatically generated by scripts/generate-world.ps1
// DO NOT modify this file manually as it will be overwritten when the script is run again.
// To update the data, modify the source data in countries-states-cities-database and run the script.

using System.Collections.Generic;
using ShowsOnSale.World.Models;

namespace ShowsOnSale.World.Data.Countries
{
    public static class Cyprus
    {
        public static Country Data { get; } = new()
        {
            Id = 57,
            Name = "Cyprus",
            Iso3 = "CYP",
            Iso2 = "CY",
            NumericCode = "196",
            PhoneCode = "357",
            Capital = "Nicosia",
            Currency = "EUR",
            CurrencyName = "Euro",
            CurrencySymbol = "€",
            Tld = ".cy",
            Native = "Κύπρος",
            Region = "Europe",
            RegionId = 4,
            Subregion = "Southern Europe",
            SubregionId = 16,
            Nationality = "Cypriot",
            Latitude = "35.00000000",
            Longitude = "33.00000000",
            Emoji = "🇨🇾",
            EmojiU = "U+1F1E8 U+1F1FE",
            Timezones = new()
            {
                new() { ZoneName = "Asia/Famagusta", GmtOffset = 7200, GmtOffsetName = "UTC+02:00", Abbreviation = "EET", TzName = "Eastern European Time" },
                new() { ZoneName = "Asia/Nicosia", GmtOffset = 7200, GmtOffsetName = "UTC+02:00", Abbreviation = "EET", TzName = "Eastern European Time" }
            },
            Translations = new()
            {
                ["ko"] = "키프로스",
                ["pt-BR"] = "Chipre",
                ["pt"] = "Chipre",
                ["nl"] = "Cyprus",
                ["hr"] = "Cipar",
                ["fa"] = "قبرس",
                ["de"] = "Zypern",
                ["es"] = "Chipre",
                ["fr"] = "Chypre",
                ["ja"] = "キプロス",
                ["it"] = "Cipro",
                ["zh-CN"] = "塞浦路斯",
                ["tr"] = "Kuzey Kıbrıs Türk Cumhuriyeti",
                ["ru"] = "Кипр",
                ["uk"] = "Кіпр",
                ["pl"] = "Cypr"
            },
            States = new()
            {

                new()
                {
                    Id = 1,
                    Name = "Famagusta (Mağusa)",
                    StateCode = "04",
                    Latitude = "35.28570230",
                    Longitude = "33.84112880",
                    Type = "district",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Acherítou", Latitude = "35.10022000", Longitude = "33.86155000" },
                        new() { Id = 2, Name = "Áchna", Latitude = "35.05515000", Longitude = "33.78388000" },
                        new() { Id = 3, Name = "Ammochostos Municipality", Latitude = "35.11755000", Longitude = "33.94335000" },
                        new() { Id = 4, Name = "Avgórou", Latitude = "35.03615000", Longitude = "33.83918000" },
                        new() { Id = 5, Name = "Ayia Napa", Latitude = "34.98213000", Longitude = "34.00183000" },
                        new() { Id = 6, Name = "Derýneia", Latitude = "35.06484000", Longitude = "33.96083000" },
                        new() { Id = 7, Name = "Famagusta", Latitude = "35.12054000", Longitude = "33.93894000" },
                        new() { Id = 8, Name = "Frénaros", Latitude = "35.04121000", Longitude = "33.92242000" },
                        new() { Id = 9, Name = "Lefkónoiko", Latitude = "35.25980000", Longitude = "33.73189000" },
                        new() { Id = 10, Name = "Leonárisso", Latitude = "35.46892000", Longitude = "34.13886000" },
                        new() { Id = 11, Name = "Liopétri", Latitude = "35.00885000", Longitude = "33.89256000" },
                        new() { Id = 12, Name = "Paralímni", Latitude = "35.03945000", Longitude = "33.98181000" },
                        new() { Id = 13, Name = "Protaras", Latitude = "35.01250000", Longitude = "34.05833000" },
                        new() { Id = 14, Name = "Rizokárpaso", Latitude = "35.59719000", Longitude = "34.37916000" },
                        new() { Id = 15, Name = "Tríkomo", Latitude = "35.28628000", Longitude = "33.89167000" }
                    }
                },

                new()
                {
                    Id = 2,
                    Name = "Kyrenia (Keryneia)",
                    StateCode = "06",
                    Latitude = "35.29919400",
                    Longitude = "33.23632460",
                    Type = "district",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Kyrenia", Latitude = "35.33634000", Longitude = "33.31729000" },
                        new() { Id = 2, Name = "Kyrenia Municipality", Latitude = "35.33672000", Longitude = "33.31504000" },
                        new() { Id = 3, Name = "Lápithos", Latitude = "35.33823000", Longitude = "33.17368000" }
                    }
                },

                new()
                {
                    Id = 3,
                    Name = "Larnaca (Larnaka)",
                    StateCode = "03",
                    Latitude = "34.85072060",
                    Longitude = "33.48319060",
                    Type = "district",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Aradíppou", Latitude = "34.95151000", Longitude = "33.59199000" },
                        new() { Id = 2, Name = "Athíenou", Latitude = "35.06180000", Longitude = "33.54156000" },
                        new() { Id = 3, Name = "Dhromolaxia", Latitude = "34.87551000", Longitude = "33.58684000" },
                        new() { Id = 4, Name = "Kíti", Latitude = "34.84696000", Longitude = "33.57344000" },
                        new() { Id = 5, Name = "Kofínou", Latitude = "34.82449000", Longitude = "33.39130000" },
                        new() { Id = 6, Name = "Kolossi", Latitude = "34.66865000", Longitude = "32.93375000" },
                        new() { Id = 7, Name = "Kórnos", Latitude = "34.92396000", Longitude = "33.39764000" },
                        new() { Id = 8, Name = "Larnaca", Latitude = "34.92291000", Longitude = "33.62330000" },
                        new() { Id = 9, Name = "Livádia", Latitude = "34.95118000", Longitude = "33.62658000" },
                        new() { Id = 10, Name = "Meneou", Latitude = "34.86114000", Longitude = "33.59516000" },
                        new() { Id = 11, Name = "Mosfilotí", Latitude = "34.95256000", Longitude = "33.42511000" },
                        new() { Id = 12, Name = "Pérgamos", Latitude = "35.04167000", Longitude = "33.70833000" },
                        new() { Id = 13, Name = "Perivólia", Latitude = "34.83355000", Longitude = "33.58196000" },
                        new() { Id = 14, Name = "Psevdás", Latitude = "34.94653000", Longitude = "33.46277000" },
                        new() { Id = 15, Name = "Pýla", Latitude = "35.01237000", Longitude = "33.69188000" },
                        new() { Id = 16, Name = "Tersefánou", Latitude = "34.85411000", Longitude = "33.54746000" },
                        new() { Id = 17, Name = "Troúlloi", Latitude = "35.03203000", Longitude = "33.61501000" },
                        new() { Id = 18, Name = "Voróklini", Latitude = "34.98600000", Longitude = "33.65387000" },
                        new() { Id = 19, Name = "Xylofágou", Latitude = "34.97743000", Longitude = "33.84894000" },
                        new() { Id = 20, Name = "Xylotymbou", Latitude = "35.01720000", Longitude = "33.74245000" }
                    }
                },

                new()
                {
                    Id = 4,
                    Name = "Limassol (Leymasun)",
                    StateCode = "02",
                    Latitude = "34.70713010",
                    Longitude = "33.02261740",
                    Type = "district",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Ágios Tomás", Latitude = "34.71158000", Longitude = "32.73129000" },
                        new() { Id = 2, Name = "Ágios Týchon", Latitude = "34.72606000", Longitude = "33.13872000" },
                        new() { Id = 3, Name = "Erími", Latitude = "34.67766000", Longitude = "32.91815000" },
                        new() { Id = 4, Name = "Germasógeia", Latitude = "34.72207000", Longitude = "33.08254000" },
                        new() { Id = 5, Name = "Kyperoúnta", Latitude = "34.93815000", Longitude = "32.97551000" },
                        new() { Id = 6, Name = "Lemesós", Latitude = "34.69218000", Longitude = "33.02854000" },
                        new() { Id = 7, Name = "Limassol", Latitude = "34.68406000", Longitude = "33.03794000" },
                        new() { Id = 8, Name = "Mouttagiáka", Latitude = "34.72022000", Longitude = "33.10066000" },
                        new() { Id = 9, Name = "Páchna", Latitude = "34.77874000", Longitude = "32.79355000" },
                        new() { Id = 10, Name = "Páno Polemídia", Latitude = "34.70559000", Longitude = "32.99269000" },
                        new() { Id = 11, Name = "Parekklisha", Latitude = "34.74583000", Longitude = "33.15833000" },
                        new() { Id = 12, Name = "Peléndri", Latitude = "34.89597000", Longitude = "32.96817000" },
                        new() { Id = 13, Name = "Pissoúri", Latitude = "34.66942000", Longitude = "32.70132000" },
                        new() { Id = 14, Name = "Pyrgos", Latitude = "34.74167000", Longitude = "33.18333000" },
                        new() { Id = 15, Name = "Sotíra", Latitude = "34.71189000", Longitude = "32.86340000" },
                        new() { Id = 16, Name = "Soúni-Zanakiá", Latitude = "34.73570000", Longitude = "32.88437000" },
                        new() { Id = 17, Name = "Ýpsonas", Latitude = "34.68797000", Longitude = "32.96191000" }
                    }
                },

                new()
                {
                    Id = 5,
                    Name = "Nicosia (Lefkoşa)",
                    StateCode = "01",
                    Latitude = "35.18556590",
                    Longitude = "33.38227640",
                    Type = "district",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Akáki", Latitude = "35.13341000", Longitude = "33.12873000" },
                        new() { Id = 2, Name = "Alámpra", Latitude = "34.98898000", Longitude = "33.39887000" },
                        new() { Id = 3, Name = "Aredioú", Latitude = "35.04844000", Longitude = "33.19610000" },
                        new() { Id = 4, Name = "Astromerítis", Latitude = "35.14096000", Longitude = "33.03793000" },
                        new() { Id = 5, Name = "Dáli", Latitude = "35.02294000", Longitude = "33.42195000" },
                        new() { Id = 6, Name = "Ergátes", Latitude = "35.05365000", Longitude = "33.24292000" },
                        new() { Id = 7, Name = "Géri", Latitude = "35.10560000", Longitude = "33.41977000" },
                        new() { Id = 8, Name = "Kakopetriá", Latitude = "34.98768000", Longitude = "32.90468000" },
                        new() { Id = 9, Name = "Káto Defterá", Latitude = "35.08489000", Longitude = "33.27558000" },
                        new() { Id = 10, Name = "Káto Pýrgos", Latitude = "35.17897000", Longitude = "32.68600000" },
                        new() { Id = 11, Name = "Klírou", Latitude = "35.02004000", Longitude = "33.17806000" },
                        new() { Id = 12, Name = "Kokkinotrimithiá", Latitude = "35.15303000", Longitude = "33.19966000" },
                        new() { Id = 13, Name = "Léfka", Latitude = "35.11199000", Longitude = "32.84997000" },
                        new() { Id = 14, Name = "Lýmpia", Latitude = "34.99889000", Longitude = "33.46175000" },
                        new() { Id = 15, Name = "Lythrodóntas", Latitude = "34.95105000", Longitude = "33.29777000" },
                        new() { Id = 16, Name = "Mámmari", Latitude = "35.17604000", Longitude = "33.20435000" },
                        new() { Id = 17, Name = "Méniko", Latitude = "35.10945000", Longitude = "33.14474000" },
                        new() { Id = 18, Name = "Mórfou", Latitude = "35.19869000", Longitude = "32.99338000" },
                        new() { Id = 19, Name = "Nicosia", Latitude = "35.17531000", Longitude = "33.36420000" },
                        new() { Id = 20, Name = "Nicosia Municipality", Latitude = "35.16944000", Longitude = "33.36081000" },
                        new() { Id = 21, Name = "Páno Defterá", Latitude = "35.07778000", Longitude = "33.26584000" },
                        new() { Id = 22, Name = "Péra", Latitude = "35.03350000", Longitude = "33.25413000" },
                        new() { Id = 23, Name = "Peristeróna", Latitude = "35.12928000", Longitude = "33.07858000" },
                        new() { Id = 24, Name = "Psimolofou", Latitude = "35.06250000", Longitude = "33.26250000" },
                        new() { Id = 25, Name = "Tséri", Latitude = "35.07307000", Longitude = "33.32344000" }
                    }
                },

                new()
                {
                    Id = 6,
                    Name = "Paphos (Pafos)",
                    StateCode = "05",
                    Latitude = "34.91645940",
                    Longitude = "32.49200880",
                    Type = "district",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Argáka", Latitude = "35.06646000", Longitude = "32.49446000" },
                        new() { Id = 2, Name = "Chlórakas", Latitude = "34.79768000", Longitude = "32.41207000" },
                        new() { Id = 3, Name = "Emba", Latitude = "34.80700000", Longitude = "32.42406000" },
                        new() { Id = 4, Name = "Geroskipou", Latitude = "34.75498000", Longitude = "32.45155000" },
                        new() { Id = 5, Name = "Geroskípou (quarter)", Latitude = "34.76190000", Longitude = "32.45135000" },
                        new() { Id = 6, Name = "Geroskípou Municipality", Latitude = "34.75142000", Longitude = "32.45449000" },
                        new() { Id = 7, Name = "Kissonerga", Latitude = "34.82279000", Longitude = "32.40131000" },
                        new() { Id = 8, Name = "Koloni", Latitude = "34.75228000", Longitude = "32.46487000" },
                        new() { Id = 9, Name = "Konia", Latitude = "34.78516000", Longitude = "32.45900000" },
                        new() { Id = 10, Name = "Mesógi", Latitude = "34.81577000", Longitude = "32.45542000" },
                        new() { Id = 11, Name = "Paphos", Latitude = "34.77679000", Longitude = "32.42451000" },
                        new() { Id = 12, Name = "Pégeia", Latitude = "34.88341000", Longitude = "32.38166000" },
                        new() { Id = 13, Name = "Pólis", Latitude = "35.03534000", Longitude = "32.42575000" },
                        new() { Id = 14, Name = "Tála", Latitude = "34.83745000", Longitude = "32.43272000" },
                        new() { Id = 15, Name = "Tsáda", Latitude = "34.83801000", Longitude = "32.47547000" }
                    }
                }
            }
        };
    }
}
