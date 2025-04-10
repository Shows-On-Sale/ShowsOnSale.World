// ⚠️ WARNING: This file is automatically generated by scripts/generate-world.ps1
// DO NOT modify this file manually as it will be overwritten when the script is run again.
// To update the data, modify the source data in countries-states-cities-database and run the script.

using System.Collections.Generic;
using ShowsOnSale.World.Models;

namespace ShowsOnSale.World.Data.Countries
{
    public static class Vanuatu
    {
        public static Country Data { get; } = new()
        {
            Id = 240,
            Name = "Vanuatu",
            Iso3 = "VUT",
            Iso2 = "VU",
            NumericCode = "548",
            PhoneCode = "678",
            Capital = "Port Vila",
            Currency = "VUV",
            CurrencyName = "Vanuatu vatu",
            CurrencySymbol = "VT",
            Tld = ".vu",
            Native = "Vanuatu",
            Region = "Oceania",
            RegionId = 5,
            Subregion = "Melanesia",
            SubregionId = 20,
            Nationality = "Ni-Vanuatu, Vanuatuan",
            Latitude = "-16.00000000",
            Longitude = "167.00000000",
            Emoji = "🇻🇺",
            EmojiU = "U+1F1FB U+1F1FA",
            Timezones = new()
            {
                new() { ZoneName = "Pacific/Efate", GmtOffset = 39600, GmtOffsetName = "UTC+11:00", Abbreviation = "VUT", TzName = "Vanuatu Time" }
            },
            Translations = new()
            {
                { "ko" = "바누아투" },
                { "pt-BR" = "Vanuatu" }
                { "pt" = "Vanuatu" }
                { "nl" = "Vanuatu" }
                { "hr" = "Vanuatu" }
                { "fa" = "وانواتو" }
                { "de" = "Vanuatu" }
                { "es" = "Vanuatu" }
                { "fr" = "Vanuatu" }
                { "ja" = "バヌアツ" }
                { "it" = "Vanuatu" }
                { "zh-CN" = "瓦努阿图" }
                { "tr" = "Vanuatu" }
                { "ru" = "Вануату" }
                { "uk" = "Вануату" }
                { "pl" = "Vanuatu" }
            },
            States = new()
            {

                new()
                {
                    Id = 1,
                    Name = "Malampa",
                    StateCode = "MAP",
                    Latitude = "-16.40114050",
                    Longitude = "167.60778650",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Lakatoro", Latitude = "-16.09992000", Longitude = "167.41636000" },
                        new() { Id = 2, Name = "Norsup", Latitude = "-16.06536000", Longitude = "167.39714000" }
                    }
                },

                new()
                {
                    Id = 2,
                    Name = "Penama",
                    StateCode = "PAM",
                    Latitude = "-15.37957580",
                    Longitude = "167.90531820",
                    Type = "province",
                    Cities = new()
                    {
                    }
                },

                new()
                {
                    Id = 3,
                    Name = "Sanma",
                    StateCode = "SAM",
                    Latitude = "-15.48400170",
                    Longitude = "166.91820970",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Luganville", Latitude = "-15.51989000", Longitude = "167.16235000" },
                        new() { Id = 2, Name = "Port-Olry", Latitude = "-15.04175000", Longitude = "167.07265000" }
                    }
                },

                new()
                {
                    Id = 4,
                    Name = "Shefa",
                    StateCode = "SEE",
                    Latitude = "32.80576500",
                    Longitude = "35.16997100",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Port-Vila", Latitude = "-17.73648000", Longitude = "168.31366000" }
                    }
                },

                new()
                {
                    Id = 5,
                    Name = "Tafea",
                    StateCode = "TAE",
                    Latitude = "-18.72378270",
                    Longitude = "169.06450560",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Isangel", Latitude = "-19.54167000", Longitude = "169.28167000" }
                    }
                },

                new()
                {
                    Id = 6,
                    Name = "Torba",
                    StateCode = "TOB",
                    Latitude = "37.07653000",
                    Longitude = "27.45657300",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Sola", Latitude = "-13.87611000", Longitude = "167.55167000" }
                    }
                }
            }
        };
    }
}
