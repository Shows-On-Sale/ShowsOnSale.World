// ⚠️ WARNING: This file is automatically generated by scripts/generate-world.ps1
// DO NOT modify this file manually as it will be overwritten when the script is run again.
// To update the data, modify the source data in countries-states-cities-database and run the script.

using System.Collections.Generic;
using ShowsOnSale.World.Models;

namespace ShowsOnSale.World.Data.Countries
{
    public static class Congo
    {
        public static Country Data { get; } = new()
        {
            Id = 50,
            Name = "Congo",
            Iso3 = "COG",
            Iso2 = "CG",
            NumericCode = "178",
            PhoneCode = "242",
            Capital = "Brazzaville",
            Currency = "XAF",
            CurrencyName = "Congolese Franc",
            CurrencySymbol = "CDF",
            Tld = ".cg",
            Native = "République du Congo",
            Region = "Africa",
            RegionId = 1,
            Subregion = "Middle Africa",
            SubregionId = 2,
            Nationality = "Congolese",
            Latitude = "-1.00000000",
            Longitude = "15.00000000",
            Emoji = "🇨🇬",
            EmojiU = "U+1F1E8 U+1F1EC",
            Timezones = new()
            {
                new() { ZoneName = "Africa/Brazzaville", GmtOffset = 3600, GmtOffsetName = "UTC+01:00", Abbreviation = "WAT", TzName = "West Africa Time" }
            },
            Translations = new()
            {
                { "ko" = "콩고" },
                { "pt-BR" = "Congo" }
                { "pt" = "Congo" }
                { "nl" = "Congo [Republiek]" }
                { "hr" = "Kongo" }
                { "fa" = "کنگو" }
                { "de" = "Kongo" }
                { "es" = "Congo" }
                { "fr" = "Congo" }
                { "ja" = "コンゴ共和国" }
                { "it" = "Congo" }
                { "zh-CN" = "刚果" }
                { "tr" = "Kongo" }
                { "ru" = "Конго" }
                { "uk" = "Конго" }
                { "pl" = "Kongo" }
            },
            States = new()
            {

                new()
                {
                    Id = 1,
                    Name = "Bouenza",
                    StateCode = "11",
                    Latitude = "-4.11280790",
                    Longitude = "13.72891670",
                    Type = "department",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Kayes", Latitude = "-4.20493000", Longitude = "13.28608000" },
                        new() { Id = 2, Name = "Madingou", Latitude = "-4.15361000", Longitude = "13.55000000" }
                    }
                },

                new()
                {
                    Id = 2,
                    Name = "Brazzaville",
                    StateCode = "BZV",
                    Latitude = "-4.26335970",
                    Longitude = "15.24288530",
                    Type = "department",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Brazzaville", Latitude = "-4.26613000", Longitude = "15.28318000" }
                    }
                }

                new()
                {
                    Id = 3,
                    Name = "Cuvette",
                    StateCode = "8",
                    Latitude = "-0.28774460",
                    Longitude = "16.15809370",
                    Type = "department",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Makoua", Latitude = "0.00694000", Longitude = "15.63333000" },
                        new() { Id = 2, Name = "Owando", Latitude = "-0.48193000", Longitude = "15.89988000" }
                    }
                }

                new()
                {
                    Id = 4,
                    Name = "Cuvette-Ouest",
                    StateCode = "15",
                    Latitude = "0.14475500",
                    Longitude = "14.47233010",
                    Type = "department",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Ewo", Latitude = "-0.87250000", Longitude = "14.82056000" }
                    }
                }

                new()
                {
                    Id = 5,
                    Name = "Kouilou",
                    StateCode = "5",
                    Latitude = "-4.14284130",
                    Longitude = "11.88917210",
                    Type = "department",
                    Cities = new()
                    {
                    }
                }

                new()
                {
                    Id = 6,
                    Name = "Lékoumou",
                    StateCode = "2",
                    Latitude = "-3.17038200",
                    Longitude = "13.35872880",
                    Type = "department",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Sibiti", Latitude = "-3.68192000", Longitude = "13.34985000" }
                    }
                }

                new()
                {
                    Id = 7,
                    Name = "Likouala",
                    StateCode = "7",
                    Latitude = "2.04392400",
                    Longitude = "17.66888700",
                    Type = "department",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Impfondo", Latitude = "1.61804000", Longitude = "18.05981000" }
                    }
                }

                new()
                {
                    Id = 8,
                    Name = "Niari",
                    StateCode = "9",
                    Latitude = "-3.18427000",
                    Longitude = "12.25479190",
                    Type = "department",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Dolisie", Latitude = "-4.19834000", Longitude = "12.66664000" },
                        new() { Id = 2, Name = "Mossendjo", Latitude = "-2.94968000", Longitude = "12.70423000" }
                    }
                }

                new()
                {
                    Id = 9,
                    Name = "Plateaux",
                    StateCode = "14",
                    Latitude = "-2.06800880",
                    Longitude = "15.40680790",
                    Type = "department",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Djambala", Latitude = "-2.54472000", Longitude = "14.75333000" },
                        new() { Id = 2, Name = "Gamboma", Latitude = "-1.87639000", Longitude = "15.86444000" }
                    }
                }

                new()
                {
                    Id = 10,
                    Name = "Pointe-Noire",
                    StateCode = "16",
                    Latitude = "-4.76916230",
                    Longitude = "11.86636200",
                    Type = "department",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Loandjili", Latitude = "-4.75611000", Longitude = "11.85778000" },
                        new() { Id = 2, Name = "Pointe-Noire", Latitude = "-4.77609000", Longitude = "11.86352000" }
                    }
                },

                new()
                {
                    Id = 11,
                    Name = "Pool",
                    StateCode = "12",
                    Latitude = "-3.77626280",
                    Longitude = "14.84546190",
                    Type = "department",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Kinkala", Latitude = "-4.36139000", Longitude = "14.76444000" }
                    }
                },

                new()
                {
                    Id = 12,
                    Name = "Sangha",
                    StateCode = "13",
                    Latitude = "1.46623280",
                    Longitude = "15.40680790",
                    Type = "department",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Ouésso", Latitude = "1.61361000", Longitude = "16.05167000" },
                        new() { Id = 2, Name = "Sémbé", Latitude = "1.64806000", Longitude = "14.58056000" }
                    }
                }
            }
        };
    }
}
