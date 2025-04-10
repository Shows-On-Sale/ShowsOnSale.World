// ⚠️ WARNING: This file is automatically generated by scripts/generate-world.ps1
// DO NOT modify this file manually as it will be overwritten when the script is run again.
// To update the data, modify the source data in countries-states-cities-database and run the script.

using System.Collections.Generic;
using ShowsOnSale.World.Models;

namespace ShowsOnSale.World.Data.Countries
{
    public static class Togo
    {
        public static Country Data { get; } = new()
        {
            Id = 223,
            Name = "Togo",
            Iso3 = "TGO",
            Iso2 = "TG",
            NumericCode = "768",
            PhoneCode = "228",
            Capital = "Lome",
            Currency = "XOF",
            CurrencyName = "West African CFA franc",
            CurrencySymbol = "CFA",
            Tld = ".tg",
            Native = "Togo",
            Region = "Africa",
            RegionId = 1,
            Subregion = "Western Africa",
            SubregionId = 3,
            Nationality = "Togolese",
            Latitude = "8.00000000",
            Longitude = "1.16666666",
            Emoji = "🇹🇬",
            EmojiU = "U+1F1F9 U+1F1EC",
            Timezones = new()
            {
                new() { ZoneName = "Africa/Lome", GmtOffset = 0, GmtOffsetName = "UTC±00", Abbreviation = "GMT", TzName = "Greenwich Mean Time" }
            },
            Translations = new()
            {
                ["ko"] = "토고",
                ["pt-BR"] = "Togo",
                ["pt"] = "Togo",
                ["nl"] = "Togo",
                ["hr"] = "Togo",
                ["fa"] = "توگو",
                ["de"] = "Togo",
                ["es"] = "Togo",
                ["fr"] = "Togo",
                ["ja"] = "トーゴ",
                ["it"] = "Togo",
                ["zh-CN"] = "多哥",
                ["tr"] = "Togo",
                ["ru"] = "Того",
                ["uk"] = "Того",
                ["pl"] = "Togo"
            },
            States = new()
            {

                new()
                {
                    Id = 1,
                    Name = "Centrale",
                    StateCode = "C",
                    Latitude = "8.65860290",
                    Longitude = "1.05861350",
                    Type = "region",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Sokodé", Latitude = "8.98333000", Longitude = "1.13333000" },
                        new() { Id = 2, Name = "Sotouboua", Latitude = "8.56340000", Longitude = "0.98399000" },
                        new() { Id = 3, Name = "Tchamba", Latitude = "9.03333000", Longitude = "1.41667000" }
                    }
                },

                new()
                {
                    Id = 2,
                    Name = "Kara",
                    StateCode = "K",
                    Latitude = "9.72163930",
                    Longitude = "1.05861350",
                    Type = "region",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Bafilo", Latitude = "9.35000000", Longitude = "1.26667000" },
                        new() { Id = 2, Name = "Bassar", Latitude = "9.25025000", Longitude = "0.78213000" },
                        new() { Id = 3, Name = "Kandé", Latitude = "9.95778000", Longitude = "1.04472000" },
                        new() { Id = 4, Name = "Kara", Latitude = "9.55111000", Longitude = "1.18611000" },
                        new() { Id = 5, Name = "Niamtougou", Latitude = "9.76806000", Longitude = "1.10528000" },
                        new() { Id = 6, Name = "Pagouda", Latitude = "9.75250000", Longitude = "1.32778000" },
                        new() { Id = 7, Name = "Préfecture de Bassar", Latitude = "9.25000000", Longitude = "0.75000000" }
                    }
                },

                new()
                {
                    Id = 3,
                    Name = "Maritime",
                    StateCode = "M",
                    Latitude = "41.65514930",
                    Longitude = "-83.52784670",
                    Type = "region",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Aného", Latitude = "6.22798000", Longitude = "1.59190000" },
                        new() { Id = 2, Name = "Lomé", Latitude = "6.12874000", Longitude = "1.22154000" },
                        new() { Id = 3, Name = "Tabligbo", Latitude = "6.58333000", Longitude = "1.50000000" },
                        new() { Id = 4, Name = "Tsévié", Latitude = "6.42611000", Longitude = "1.21333000" },
                        new() { Id = 5, Name = "Vogan", Latitude = "6.33333000", Longitude = "1.53333000" }
                    }
                },

                new()
                {
                    Id = 4,
                    Name = "Plateaux",
                    StateCode = "P",
                    Latitude = "7.61013780",
                    Longitude = "1.05861350",
                    Type = "region",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Amlamé", Latitude = "7.46667000", Longitude = "0.90000000" },
                        new() { Id = 2, Name = "Atakpamé", Latitude = "7.53333000", Longitude = "1.13333000" },
                        new() { Id = 3, Name = "Badou", Latitude = "7.58333000", Longitude = "0.60000000" },
                        new() { Id = 4, Name = "Kpalimé", Latitude = "6.90000000", Longitude = "0.63333000" },
                        new() { Id = 5, Name = "Notsé", Latitude = "6.95000000", Longitude = "1.16667000" }
                    }
                },

                new()
                {
                    Id = 5,
                    Name = "Savanes",
                    StateCode = "S",
                    Latitude = "10.52917810",
                    Longitude = "0.52578230",
                    Type = "region",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Dapaong", Latitude = "10.86225000", Longitude = "0.20762000" },
                        new() { Id = 2, Name = "Sansanné-Mango", Latitude = "10.35917000", Longitude = "0.47083000" }
                    }
                }
            }
        };
    }
}
