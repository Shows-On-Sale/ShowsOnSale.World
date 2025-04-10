// ⚠️ WARNING: This file is automatically generated by scripts/generate-world.ps1
// DO NOT modify this file manually as it will be overwritten when the script is run again.
// To update the data, modify the source data in countries-states-cities-database and run the script.

using System.Collections.Generic;
using ShowsOnSale.World.Models;

namespace ShowsOnSale.World.Data.Countries
{
    public static class Mozambique
    {
        public static Country Data { get; } = new()
        {
            Id = 148,
            Name = "Mozambique",
            Iso3 = "MOZ",
            Iso2 = "MZ",
            NumericCode = "508",
            PhoneCode = "258",
            Capital = "Maputo",
            Currency = "MZN",
            CurrencyName = "Mozambican metical",
            CurrencySymbol = "MT",
            Tld = ".mz",
            Native = "Moçambique",
            Region = "Africa",
            RegionId = 1,
            Subregion = "Eastern Africa",
            SubregionId = 4,
            Nationality = "Mozambican",
            Latitude = "-18.25000000",
            Longitude = "35.00000000",
            Emoji = "🇲🇿",
            EmojiU = "U+1F1F2 U+1F1FF",
            Timezones = new()
            {
                new() { ZoneName = "Africa/Maputo", GmtOffset = 7200, GmtOffsetName = "UTC+02:00", Abbreviation = "CAT", TzName = "Central Africa Time" }
            },
            Translations = new()
            {
                { "ko" = "모잠비크" },
                { "pt-BR" = "Moçambique" }
                { "pt" = "Moçambique" }
                { "nl" = "Mozambique" }
                { "hr" = "Mozambik" }
                { "fa" = "موزامبیک" }
                { "de" = "Mosambik" }
                { "es" = "Mozambique" }
                { "fr" = "Mozambique" }
                { "ja" = "モザンビーク" }
                { "it" = "Mozambico" }
                { "zh-CN" = "莫桑比克" }
                { "tr" = "Mozambik" }
                { "ru" = "Мозамбик" }
                { "uk" = "Мозамбік" }
                { "pl" = "Mozambik" }
            },
            States = new()
            {

                new()
                {
                    Id = 1,
                    Name = "Cabo Delgado",
                    StateCode = "P",
                    Latitude = "-12.33354740",
                    Longitude = "39.32062410",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Chiure", Latitude = "-13.46665000", Longitude = "39.70317000" },
                        new() { Id = 2, Name = "Mocímboa", Latitude = "-11.31667000", Longitude = "40.35000000" },
                        new() { Id = 3, Name = "Montepuez", Latitude = "-13.12556000", Longitude = "38.99972000" },
                        new() { Id = 4, Name = "Pemba", Latitude = "-12.97395000", Longitude = "40.51775000" }
                    }
                },

                new()
                {
                    Id = 2,
                    Name = "Gaza",
                    StateCode = "G",
                    Latitude = "-23.02219280",
                    Longitude = "32.71813750",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Chibuto", Latitude = "-24.68667000", Longitude = "33.53056000" },
                        new() { Id = 2, Name = "Chokwé", Latitude = "-24.53333000", Longitude = "32.98333000" },
                        new() { Id = 3, Name = "Macia", Latitude = "-25.02694000", Longitude = "33.09889000" },
                        new() { Id = 4, Name = "Xai-Xai", Latitude = "-25.05194000", Longitude = "33.64417000" }
                    }
                }

                new()
                {
                    Id = 3,
                    Name = "Inhambane",
                    StateCode = "I",
                    Latitude = "-22.85279970",
                    Longitude = "34.55087580",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Inhambane", Latitude = "-23.86500000", Longitude = "35.38333000" },
                        new() { Id = 2, Name = "Maxixe", Latitude = "-23.85972000", Longitude = "35.34722000" }
                    }
                }

                new()
                {
                    Id = 4,
                    Name = "Manica",
                    StateCode = "B",
                    Latitude = "-19.50597870",
                    Longitude = "33.43835300",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Chimoio", Latitude = "-19.11639000", Longitude = "33.48333000" }
                    }
                }

                new()
                {
                    Id = 5,
                    Name = "Maputo",
                    StateCode = "L",
                    Latitude = "-25.25698760",
                    Longitude = "32.53727410",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Boane District", Latitude = "-26.02900000", Longitude = "32.38900000" },
                        new() { Id = 2, Name = "Concelho de Matola", Latitude = "-25.83472000", Longitude = "32.49516000" },
                        new() { Id = 3, Name = "Magude District", Latitude = "-25.02389000", Longitude = "32.65150000" },
                        new() { Id = 4, Name = "Manhica", Latitude = "-25.34035000", Longitude = "32.84234000" },
                        new() { Id = 5, Name = "Marracuene District", Latitude = "-25.73938000", Longitude = "32.67436000" },
                        new() { Id = 6, Name = "Matola", Latitude = "-25.96222000", Longitude = "32.45889000" },
                        new() { Id = 7, Name = "Matutiune District", Latitude = "-26.43418000", Longitude = "32.58820000" },
                        new() { Id = 8, Name = "Moamba District", Latitude = "-25.60934000", Longitude = "32.24321000" },
                        new() { Id = 9, Name = "Namaacha District", Latitude = "-26.10900000", Longitude = "32.18000000" },
                        new() { Id = 10, Name = "Ressano Garcia", Latitude = "-25.44278000", Longitude = "31.99528000" }
                    }
                }

                new()
                {
                    Id = 6,
                    Name = "Maputo",
                    StateCode = "MPM",
                    Latitude = "-25.96924800",
                    Longitude = "32.57317460",
                    Type = "city",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "KaTembe", Latitude = "-26.02985000", Longitude = "32.53204000" },
                        new() { Id = 2, Name = "Maputo", Latitude = "-25.96553000", Longitude = "32.58322000" }
                    }
                }

                new()
                {
                    Id = 7,
                    Name = "Nampula",
                    StateCode = "N",
                    Latitude = "-14.76049310",
                    Longitude = "39.32062410",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "António Enes", Latitude = "-16.23250000", Longitude = "39.90861000" },
                        new() { Id = 2, Name = "Ilha de Moçambique", Latitude = "-15.03417000", Longitude = "40.73583000" },
                        new() { Id = 3, Name = "Mutuáli", Latitude = "-14.87056000", Longitude = "37.00444000" },
                        new() { Id = 4, Name = "Nacala", Latitude = "-14.56257000", Longitude = "40.68538000" },
                        new() { Id = 5, Name = "Nampula", Latitude = "-15.11646000", Longitude = "39.26660000" }
                    }
                }

                new()
                {
                    Id = 8,
                    Name = "Niassa",
                    StateCode = "A",
                    Latitude = "-12.78262020",
                    Longitude = "36.60939260",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Cuamba", Latitude = "-14.80306000", Longitude = "36.53722000" },
                        new() { Id = 2, Name = "Lichinga", Latitude = "-13.31278000", Longitude = "35.24056000" },
                        new() { Id = 3, Name = "Mandimba", Latitude = "-14.35250000", Longitude = "35.65056000" }
                    }
                }

                new()
                {
                    Id = 9,
                    Name = "Sofala",
                    StateCode = "S",
                    Latitude = "-19.20390730",
                    Longitude = "34.86241660",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Beira", Latitude = "-19.84361000", Longitude = "34.83889000" },
                        new() { Id = 2, Name = "Dondo", Latitude = "-19.60944000", Longitude = "34.74306000" },
                        new() { Id = 3, Name = "Nhamatanda District", Latitude = "-19.34900000", Longitude = "34.26800000" }
                    }
                }

                new()
                {
                    Id = 10,
                    Name = "Tete",
                    StateCode = "T",
                    Latitude = "-15.65960560",
                    Longitude = "32.71813750",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Tete", Latitude = "-16.15639000", Longitude = "33.58667000" }
                    }
                },

                new()
                {
                    Id = 11,
                    Name = "Zambezia",
                    StateCode = "Q",
                    Latitude = "-16.56389870",
                    Longitude = "36.60939260",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Alto Molócuè", Latitude = "-15.64932000", Longitude = "37.66384000" },
                        new() { Id = 2, Name = "Chinde", Latitude = "-18.58111000", Longitude = "36.45861000" },
                        new() { Id = 3, Name = "Quelimane", Latitude = "-17.87861000", Longitude = "36.88833000" }
                    }
                }
            }
        };
    }
}
