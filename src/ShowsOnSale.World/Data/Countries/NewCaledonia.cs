// ⚠️ WARNING: This file is automatically generated by scripts/generate-world.ps1
// DO NOT modify this file manually as it will be overwritten when the script is run again.
// To update the data, modify the source data in countries-states-cities-database and run the script.

using System.Collections.Generic;
using ShowsOnSale.World.Models;

namespace ShowsOnSale.World.Data.Countries
{
    public static class NewCaledonia
    {
        public static Country Data { get; } = new()
        {
            Id = 154,
            Name = "New Caledonia",
            Iso3 = "NCL",
            Iso2 = "NC",
            NumericCode = "540",
            PhoneCode = "687",
            Capital = "Noumea",
            Currency = "XPF",
            CurrencyName = "CFP franc",
            CurrencySymbol = "₣",
            Tld = ".nc",
            Native = "Nouvelle-Calédonie",
            Region = "Oceania",
            RegionId = 5,
            Subregion = "Melanesia",
            SubregionId = 20,
            Nationality = "New Caledonian",
            Latitude = "-21.50000000",
            Longitude = "165.50000000",
            Emoji = "🇳🇨",
            EmojiU = "U+1F1F3 U+1F1E8",
            Timezones = new()
            {
                new() { ZoneName = "Pacific/Noumea", GmtOffset = 39600, GmtOffsetName = "UTC+11:00", Abbreviation = "NCT", TzName = "New Caledonia Time" }
            },
            Translations = new()
            {
                ["ko"] = "누벨칼레도니",
                ["pt-BR"] = "Nova Caledônia",
                ["pt"] = "Nova Caledónia",
                ["nl"] = "Nieuw-Caledonië",
                ["hr"] = "Nova Kaledonija",
                ["fa"] = "کالدونیای جدید",
                ["de"] = "Neukaledonien",
                ["es"] = "Nueva Caledonia",
                ["fr"] = "Nouvelle-Calédonie",
                ["ja"] = "ニューカレドニア",
                ["it"] = "Nuova Caledonia",
                ["zh-CN"] = "新喀里多尼亚",
                ["tr"] = "Yeni Kaledonya",
                ["ru"] = "Новая Каледония",
                ["uk"] = "Нова Каледонія",
                ["pl"] = "Nowa Kaledonia"
            },
            States = new()
            {

                new()
                {
                    Id = 1,
                    Name = "Loyalty Islands Province",
                    StateCode = "03",
                    Latitude = "-20.96670000",
                    Longitude = "167.23330000",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Lifou", Latitude = "-20.96670000", Longitude = "167.23330000" },
                        new() { Id = 2, Name = "Maré", Latitude = "-21.51670000", Longitude = "167.98330000" }
                    }
                },

                new()
                {
                    Id = 2,
                    Name = "North Province",
                    StateCode = "02",
                    Latitude = "-22.27580000",
                    Longitude = "166.45800000",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Houaïlou", Latitude = "-21.29090000", Longitude = "165.62170000" },
                        new() { Id = 2, Name = "Koné", Latitude = "-21.05900000", Longitude = "164.85180000" },
                        new() { Id = 3, Name = "Poindimié", Latitude = "-20.94960000", Longitude = "165.32930000" }
                    }
                },

                new()
                {
                    Id = 3,
                    Name = "South Province",
                    StateCode = "01",
                    Latitude = "-22.27580000",
                    Longitude = "166.45800000",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Bourail", Latitude = "-21.57010000", Longitude = "165.48040000" },
                        new() { Id = 2, Name = "Dumbéa", Latitude = "-22.15000000", Longitude = "166.45000000" },
                        new() { Id = 3, Name = "Le Mont-Dore", Latitude = "-22.21570000", Longitude = "166.46650000" },
                        new() { Id = 4, Name = "Nouméa", Latitude = "-22.27580000", Longitude = "166.45800000" },
                        new() { Id = 5, Name = "Païta", Latitude = "-22.13370000", Longitude = "166.35050000" }
                    }
                }
            }
        };
    }
}
