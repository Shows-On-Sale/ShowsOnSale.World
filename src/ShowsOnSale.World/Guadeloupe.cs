// ⚠️ WARNING: This file is automatically generated by scripts/generate-world.ps1
// DO NOT modify this file manually as it will be overwritten when the script is run again.
// To update the data, modify the source data in countries-states-cities-database and run the script.

using System.Collections.Generic;
using ShowsOnSale.World.Models;

namespace ShowsOnSale.World.Data.Countries
{
    public static class Guadeloupe
    {
        public static Country Data { get; } = new()
        {
            Id = 88,
            Name = "Guadeloupe",
            Iso3 = "GLP",
            Iso2 = "GP",
            NumericCode = "312",
            PhoneCode = "590",
            Capital = "Basse-Terre",
            Currency = "EUR",
            CurrencyName = "Euro",
            CurrencySymbol = "€",
            Tld = ".gp",
            Native = "Guadeloupe",
            Region = "Americas",
            RegionId = 2,
            Subregion = "Caribbean",
            SubregionId = 7,
            Nationality = "Guadeloupe",
            Latitude = "16.25000000",
            Longitude = "-61.58333300",
            Emoji = "🇬🇵",
            EmojiU = "U+1F1EC U+1F1F5",
            Timezones = new()
            {
                new() { ZoneName = "America/Guadeloupe", GmtOffset = -14400, GmtOffsetName = "UTC-04:00", Abbreviation = "AST", TzName = "Atlantic Standard Time" }
            },
            Translations = new()
            {
                ["ko"] = "과들루프",
                ["pt-BR"] = "Guadalupe",
                ["pt"] = "Guadalupe",
                ["nl"] = "Guadeloupe",
                ["hr"] = "Gvadalupa",
                ["fa"] = "جزیره گوادلوپ",
                ["de"] = "Guadeloupe",
                ["es"] = "Guadalupe",
                ["fr"] = "Guadeloupe",
                ["ja"] = "グアドループ",
                ["it"] = "Guadeloupa",
                ["zh-CN"] = "瓜德罗普岛",
                ["tr"] = "Guadeloupe",
                ["ru"] = "Гваделупа",
                ["uk"] = "Гваделупа",
                ["pl"] = "Gwadelupa"
            },
            States = new()
            {

                new()
                {
                    Id = 1,
                    Name = "Basse-Terre",
                    StateCode = "01",
                    Latitude = "16.10110190",
                    Longitude = "-62.00545460",
                    Type = "district",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Baie-Mahault", Latitude = "16.24976070", Longitude = "-61.67750720" },
                        new() { Id = 2, Name = "Baillif", Latitude = "16.04973310", Longitude = "-61.75705910" },
                        new() { Id = 3, Name = "Basse-Terre", Latitude = "15.99916310", Longitude = "-61.74998100" },
                        new() { Id = 4, Name = "Bouillante", Latitude = "16.13869370", Longitude = "-61.79898970" },
                        new() { Id = 5, Name = "Capesterre-Belle-Eau", Latitude = "16.04854020", Longitude = "-61.70210450" },
                        new() { Id = 6, Name = "Deshaies", Latitude = "16.31936050", Longitude = "-61.82425780" },
                        new() { Id = 7, Name = "Gourbeyre", Latitude = "16.00565950", Longitude = "-61.73023870" },
                        new() { Id = 8, Name = "Goyave", Latitude = "16.12310770", Longitude = "-61.69740210" },
                        new() { Id = 9, Name = "Lamentin", Latitude = "16.24431320", Longitude = "-61.75191940" },
                        new() { Id = 10, Name = "Petit-Bourg", Latitude = "16.16948810", Longitude = "-61.74043310" },
                        new() { Id = 11, Name = "Pointe-Noire", Latitude = "16.22702770", Longitude = "-61.80631220" },
                        new() { Id = 12, Name = "Saint-Claude", Latitude = "16.04057440", Longitude = "-61.73648730" },
                        new() { Id = 13, Name = "Sainte-Rose", Latitude = "16.29372520", Longitude = "-61.76595760" },
                        new() { Id = 14, Name = "Terre-de-Bas", Latitude = "15.85541960", Longitude = "-61.65329200" },
                        new() { Id = 15, Name = "Terre-de-Haut", Latitude = "15.85803760", Longitude = "-61.60960980" },
                        new() { Id = 16, Name = "Trois-Rivières", Latitude = "15.99313620", Longitude = "-61.69052960" },
                        new() { Id = 17, Name = "Vieux-Fort", Latitude = "15.96070380", Longitude = "-61.71351770" },
                        new() { Id = 18, Name = "Vieux-Habitants", Latitude = "16.08466180", Longitude = "-61.79939230" }
                    }
                },

                new()
                {
                    Id = 2,
                    Name = "Pointe-à-Pitre",
                    StateCode = "02",
                    Latitude = "16.19024380",
                    Longitude = "-61.62917130",
                    Type = "district",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Anse-Bertrand", Latitude = "16.46681810", Longitude = "-61.55217680" },
                        new() { Id = 2, Name = "Capesterre-de-Marie-Galante", Latitude = "15.91763990", Longitude = "-61.27077860" },
                        new() { Id = 3, Name = "Grand-Bourg", Latitude = "15.90853800", Longitude = "-61.33406180" },
                        new() { Id = 4, Name = "La Désirade", Latitude = "16.25845450", Longitude = "-61.14902790" },
                        new() { Id = 5, Name = "Le Gosier", Latitude = "16.22726250", Longitude = "-61.55734490" },
                        new() { Id = 6, Name = "Le Moule", Latitude = "16.33536870", Longitude = "-61.44242930" },
                        new() { Id = 7, Name = "Les Abymes", Latitude = "16.26773830", Longitude = "-61.57907270" },
                        new() { Id = 8, Name = "Morne-à-l'Eau", Latitude = "16.32110610", Longitude = "-61.66356890" },
                        new() { Id = 9, Name = "Petit-Canal", Latitude = "16.39213100", Longitude = "-61.53713120" },
                        new() { Id = 10, Name = "Pointe-à-Pitre", Latitude = "16.23313040", Longitude = "-61.56234850" },
                        new() { Id = 11, Name = "Port-Louis", Latitude = "16.42012820", Longitude = "-61.57039890" },
                        new() { Id = 12, Name = "Saint-François", Latitude = "16.27834950", Longitude = "-61.33624980" },
                        new() { Id = 13, Name = "Saint-Louis", Latitude = "15.96535890", Longitude = "-61.35562500" },
                        new() { Id = 14, Name = "Sainte-Anne", Latitude = "16.25646130", Longitude = "-61.47202880" }
                    }
                }
            }
        };
    }
}
