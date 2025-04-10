// ⚠️ WARNING: This file is automatically generated by scripts/generate-world.ps1
// DO NOT modify this file manually as it will be overwritten when the script is run again.
// To update the data, modify the source data in countries-states-cities-database and run the script.

using System.Collections.Generic;
using ShowsOnSale.World.Models;

namespace ShowsOnSale.World.Data.Countries
{
    public static class Andorra
    {
        public static Country Data { get; } = new Country
        {
            Id = 6,
            Name = "Andorra",
            Iso3 = "AND",
            Iso2 = "AD",
            NumericCode = "020",
            PhoneCode = "376",
            Capital = "Andorra la Vella",
            Currency = "EUR",
            CurrencyName = "Euro",
            CurrencySymbol = "€",
            Tld = ".ad",
            Native = "Andorra",
            Region = "Europe",
            RegionId = 4,
            Subregion = "Southern Europe",
            SubregionId = 16,
            Nationality = "Andorran",
            Latitude = "42.50000000",
            Longitude = "1.50000000",
            Emoji = "🇦🇩",
            EmojiU = "U+1F1E6 U+1F1E9",
            Timezones = new List<Timezone>
            {
                new Timezone
                {
                    ZoneName = "Europe/Andorra",
                    GmtOffset = 3600,
                    GmtOffsetName = "UTC+01:00",
                    Abbreviation = "CET",
                    TzName = "Central European Time"
                }
            },
            Translations = new Dictionary<string, string>
            {
                { "ko" = "안도라" },
                { "pt-BR" = "Andorra" }
                { "pt" = "Andorra" }
                { "nl" = "Andorra" }
                { "hr" = "Andora" }
                { "fa" = "آندورا" }
                { "de" = "Andorra" }
                { "es" = "Andorra" }
                { "fr" = "Andorre" }
                { "ja" = "アンドラ" }
                { "it" = "Andorra" }
                { "zh-CN" = "安道尔" }
                { "tr" = "Andorra" }
                { "ru" = "Андорра" }
                { "uk" = "Андорра" }
                { "pl" = "Andora" }
            },
            States = new List<State>
            {

                new State
                {
                    Id = 1,
                    Name = "Andorra la Vella",
                    StateCode = "07",
                    Latitude = "42.50631740",
                    Longitude = "1.52183550",
                    Type = "parish",
                    Cities = new List<City>
                    {

                        new City
                        {
                            Id = 1,
                            Name = "Andorra la Vella",
                            Latitude = "42.50779000",
                            Longitude = "1.52109000"
                        }
                    }
                },

                new State
                {
                    Id = 2,
                    Name = "Canillo",
                    StateCode = "02",
                    Latitude = "42.59782490",
                    Longitude = "1.65663770",
                    Type = "parish",
                    Cities = new List<City>
                    {

                        new City
                        {
                            Id = 1,
                            Name = "Canillo",
                            Latitude = "42.56760000",
                            Longitude = "1.59756000"
                        },

                        new City
                        {
                            Id = 2,
                            Name = "El Tarter",
                            Latitude = "42.57952000",
                            Longitude = "1.65362000"
                        }
                    }
                },

                new State
                {
                    Id = 3,
                    Name = "Encamp",
                    StateCode = "03",
                    Latitude = "42.53597640",
                    Longitude = "1.58367730",
                    Type = "parish",
                    Cities = new List<City>
                    {

                        new City
                        {
                            Id = 1,
                            Name = "Encamp",
                            Latitude = "42.53474000",
                            Longitude = "1.58014000"
                        },

                        new City
                        {
                            Id = 2,
                            Name = "Pas de la Casa",
                            Latitude = "42.54277000",
                            Longitude = "1.73361000"
                        }
                    }
                },

                new State
                {
                    Id = 4,
                    Name = "Escaldes-Engordany",
                    StateCode = "08",
                    Latitude = "42.49093790",
                    Longitude = "1.58869660",
                    Type = "parish",
                    Cities = new List<City>
                    {

                        new City
                        {
                            Id = 1,
                            Name = "les Escaldes",
                            Latitude = "42.50729000",
                            Longitude = "1.53414000"
                        }
                    }
                },

                new State
                {
                    Id = 5,
                    Name = "La Massana",
                    StateCode = "04",
                    Latitude = "42.54562500",
                    Longitude = "1.51473920",
                    Type = "parish",
                    Cities = new List<City>
                    {

                        new City
                        {
                            Id = 1,
                            Name = "Arinsal",
                            Latitude = "42.57205000",
                            Longitude = "1.48453000"
                        },

                        new City
                        {
                            Id = 2,
                            Name = "la Massana",
                            Latitude = "42.54499000",
                            Longitude = "1.51483000"
                        }
                    }
                },

                new State
                {
                    Id = 6,
                    Name = "Ordino",
                    StateCode = "05",
                    Latitude = "42.59944330",
                    Longitude = "1.54023270",
                    Type = "parish",
                    Cities = new List<City>
                    {

                        new City
                        {
                            Id = 1,
                            Name = "Ordino",
                            Latitude = "42.55623000",
                            Longitude = "1.53319000"
                        }
                    }
                },

                new State
                {
                    Id = 7,
                    Name = "Sant Julià de Lòria",
                    StateCode = "06",
                    Latitude = "42.45296310",
                    Longitude = "1.49182350",
                    Type = "parish",
                    Cities = new List<City>
                    {

                        new City
                        {
                            Id = 1,
                            Name = "Sant Julià de Lòria",
                            Latitude = "42.46372000",
                            Longitude = "1.49129000"
                        }
                    }
                }
            }
        };
    }
}
