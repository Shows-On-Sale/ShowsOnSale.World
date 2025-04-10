// ⚠️ WARNING: This file is automatically generated by scripts/generate-world.ps1
// DO NOT modify this file manually as it will be overwritten when the script is run again.
// To update the data, modify the source data in countries-states-cities-database and run the script.

using System.Collections.Generic;
using ShowsOnSale.World.Models;

namespace ShowsOnSale.World.Data.Countries
{
    public static class SaoTomeAndPrincipe
    {
        public static Country Data { get; } = new()
        {
            Id = 192,
            Name = "Sao Tome and Principe",
            Iso3 = "STP",
            Iso2 = "ST",
            NumericCode = "678",
            PhoneCode = "239",
            Capital = "Sao Tome",
            Currency = "STN",
            CurrencyName = "Dobra",
            CurrencySymbol = "Db",
            Tld = ".st",
            Native = "São Tomé e Príncipe",
            Region = "Africa",
            RegionId = 1,
            Subregion = "Middle Africa",
            SubregionId = 2,
            Nationality = "Sao Tomean",
            Latitude = "1.00000000",
            Longitude = "7.00000000",
            Emoji = "🇸🇹",
            EmojiU = "U+1F1F8 U+1F1F9",
            Timezones = new()
            {
                new() { ZoneName = "Africa/Sao_Tome", GmtOffset = 0, GmtOffsetName = "UTC±00", Abbreviation = "GMT", TzName = "Greenwich Mean Time" }
            },
            Translations = new()
            {
                { "ko" = "상투메 프린시페" },
                { "pt-BR" = "São Tomé e Príncipe" }
                { "pt" = "São Tomé e Príncipe" }
                { "nl" = "Sao Tomé en Principe" }
                { "hr" = "Sveti Toma i Princip" }
                { "fa" = "کواترو دو فرویرو" }
                { "de" = "São Tomé und Príncipe" }
                { "es" = "Santo Tomé y Príncipe" }
                { "fr" = "Sao Tomé-et-Principe" }
                { "ja" = "サントメ・プリンシペ" }
                { "it" = "São Tomé e Príncipe" }
                { "zh-CN" = "圣多美和普林西比" }
                { "tr" = "Sao Tome Ve Prinsipe" }
                { "ru" = "Сан-Томе и Принсипи" }
                { "uk" = "Сан-Томе і Принсіпі" }
                { "pl" = "Wyspy Świętego Tomasza i Książęca" }
            },
            States = new()
            {

                new()
                {
                    Id = 1,
                    Name = "Príncipe",
                    StateCode = "P",
                    Latitude = "1.61393810",
                    Longitude = "7.40569280",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Santo António", Latitude = "1.63943000", Longitude = "7.41951000" }
                    }
                },

                new()
                {
                    Id = 2,
                    Name = "São Tomé",
                    StateCode = "S",
                    Latitude = "0.33019240",
                    Longitude = "6.73334300",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Cantagalo District", Latitude = "0.21667000", Longitude = "6.70000000" },
                        new() { Id = 2, Name = "Caué District", Latitude = "0.13415000", Longitude = "6.63825000" },
                        new() { Id = 3, Name = "São Tomé", Latitude = "0.33654000", Longitude = "6.72732000" },
                        new() { Id = 4, Name = "Trindade", Latitude = "0.29667000", Longitude = "6.68139000" }
                    }
                }
            }
        };
    }
}
