// ⚠️ WARNING: This file is automatically generated by scripts/generate-world.ps1
// DO NOT modify this file manually as it will be overwritten when the script is run again.
// To update the data, modify the source data in countries-states-cities-database and run the script.

using System.Collections.Generic;
using ShowsOnSale.World.Models;

namespace ShowsOnSale.World.Data.Countries
{
    public static class Martinique
    {
        public static Country Data { get; } = new()
        {
            Id = 136,
            Name = "Martinique",
            Iso3 = "MTQ",
            Iso2 = "MQ",
            NumericCode = "474",
            PhoneCode = "596",
            Capital = "Fort-de-France",
            Currency = "EUR",
            CurrencyName = "Euro",
            CurrencySymbol = "€",
            Tld = ".mq",
            Native = "Martinique",
            Region = "Americas",
            RegionId = 2,
            Subregion = "Caribbean",
            SubregionId = 7,
            Nationality = "Martiniquais, Martinican",
            Latitude = "14.66666700",
            Longitude = "-61.00000000",
            Emoji = "🇲🇶",
            EmojiU = "U+1F1F2 U+1F1F6",
            Timezones = new()
            {
                new() { ZoneName = "America/Martinique", GmtOffset = -14400, GmtOffsetName = "UTC-04:00", Abbreviation = "AST", TzName = "Atlantic Standard Time" }
            },
            Translations = new()
            {
                ["ko"] = "마르티니크",
                ["pt-BR"] = "Martinica",
                ["pt"] = "Martinica",
                ["nl"] = "Martinique",
                ["hr"] = "Martinique",
                ["fa"] = "مونتسرات",
                ["de"] = "Martinique",
                ["es"] = "Martinica",
                ["fr"] = "Martinique",
                ["ja"] = "マルティニーク",
                ["it"] = "Martinica",
                ["zh-CN"] = "马提尼克岛",
                ["tr"] = "Martinik",
                ["ru"] = "Мартиника",
                ["uk"] = "Мартініка",
                ["pl"] = "Martynika"
            },
            States = new()
            {

                new()
                {
                    Id = 1,
                    Name = "Fort-de-France",
                    StateCode = "01",
                    Latitude = "14.64349950",
                    Longitude = "-61.11431890",
                    Type = "district",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Fort-de-France", Latitude = "14.64924180", Longitude = "-61.10984450" },
                        new() { Id = 2, Name = "Le Lamentin", Latitude = "14.62308620", Longitude = "-61.03347490" },
                        new() { Id = 3, Name = "Saint-Joseph", Latitude = "14.68353400", Longitude = "-61.08186620" },
                        new() { Id = 4, Name = "Schœlcher", Latitude = "14.65179970", Longitude = "-61.14128670" }
                    }
                },

                new()
                {
                    Id = 2,
                    Name = "La Trinité",
                    StateCode = "02",
                    Latitude = "14.75519490",
                    Longitude = "-61.20281970",
                    Type = "district",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Basse-Pointe", Latitude = "14.84097080", Longitude = "-61.16485230" },
                        new() { Id = 2, Name = "Grand'Rivière", Latitude = "14.84696630", Longitude = "-61.20427640" },
                        new() { Id = 3, Name = "Gros-Morne", Latitude = "14.70841840", Longitude = "-61.11271220" },
                        new() { Id = 4, Name = "L'Ajoupa-Bouillon", Latitude = "14.81597180", Longitude = "-61.17170630" },
                        new() { Id = 5, Name = "La Trinité", Latitude = "14.73804150", Longitude = "-61.02929560" },
                        new() { Id = 6, Name = "Le Lorrain", Latitude = "14.79952560", Longitude = "-61.11513740" },
                        new() { Id = 7, Name = "Le Marigot", Latitude = "14.77958180", Longitude = "-61.09424580" },
                        new() { Id = 8, Name = "Le Robert", Latitude = "14.67443270", Longitude = "-61.01692720" },
                        new() { Id = 9, Name = "Macouba", Latitude = "14.84743860", Longitude = "-61.16709460" },
                        new() { Id = 10, Name = "Sainte-Marie", Latitude = "14.77300930", Longitude = "-61.04959970" }
                    }
                },

                new()
                {
                    Id = 3,
                    Name = "Le Marin",
                    StateCode = "03",
                    Latitude = "14.52205810",
                    Longitude = "-61.12011970",
                    Type = "district",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Ducos", Latitude = "14.57854420", Longitude = "-61.00973860" },
                        new() { Id = 2, Name = "Le Diamant", Latitude = "14.47680040", Longitude = "-61.05973840" },
                        new() { Id = 3, Name = "Le François", Latitude = "14.60928850", Longitude = "-60.97999110" },
                        new() { Id = 4, Name = "Le Marin", Latitude = "14.48221690", Longitude = "-60.90011410" },
                        new() { Id = 5, Name = "Le Vauclin", Latitude = "14.54208600", Longitude = "-60.90060060" },
                        new() { Id = 6, Name = "Les Anses-d'Arlet", Latitude = "14.49954780", Longitude = "-61.11481620" },
                        new() { Id = 7, Name = "Les Trois-Îlets", Latitude = "14.53287460", Longitude = "-61.07877690" },
                        new() { Id = 8, Name = "Rivière-Pilote", Latitude = "14.50266970", Longitude = "-60.93819210" },
                        new() { Id = 9, Name = "Rivière-Salée", Latitude = "14.52621400", Longitude = "-61.00353090" },
                        new() { Id = 10, Name = "Saint-Esprit", Latitude = "14.56175950", Longitude = "-60.96451110" },
                        new() { Id = 11, Name = "Sainte-Anne", Latitude = "14.43142200", Longitude = "-60.89278760" },
                        new() { Id = 12, Name = "Sainte-Luce", Latitude = "14.49040930", Longitude = "-60.98793650" }
                    }
                },

                new()
                {
                    Id = 4,
                    Name = "Saint-Pierre",
                    StateCode = "04",
                    Latitude = "14.74505200",
                    Longitude = "-61.23631840",
                    Type = "district",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Bellefontaine", Latitude = "14.67474760", Longitude = "-61.16653080" },
                        new() { Id = 2, Name = "Case-Pilote", Latitude = "14.65933990", Longitude = "-61.15026120" },
                        new() { Id = 3, Name = "Fonds-Saint-Denis", Latitude = "14.72275460", Longitude = "-61.16189190" },
                        new() { Id = 4, Name = "Le Carbet", Latitude = "14.70521580", Longitude = "-61.19444680" },
                        new() { Id = 5, Name = "Le Morne-Rouge", Latitude = "14.76953640", Longitude = "-61.16292840" },
                        new() { Id = 6, Name = "Le Morne-Vert", Latitude = "14.70464330", Longitude = "-61.15679770" },
                        new() { Id = 7, Name = "Le Prêcheur", Latitude = "14.82202610", Longitude = "-61.23746860" },
                        new() { Id = 8, Name = "Saint-Pierre", Latitude = "14.77167190", Longitude = "-61.21475010" }
                    }
                }
            }
        };
    }
}
