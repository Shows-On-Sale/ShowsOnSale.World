// ⚠️ WARNING: This file is automatically generated by scripts/generate-world.ps1
// DO NOT modify this file manually as it will be overwritten when the script is run again.
// To update the data, modify the source data in countries-states-cities-database and run the script.

using System.Collections.Generic;
using ShowsOnSale.World.Models;

namespace ShowsOnSale.World.Data.Countries
{
    public static class AntiguaAndBarbuda
    {
        public static Country Data { get; } = new Country
        {
            Id = 10,
            Name = "Antigua and Barbuda",
            Iso3 = "ATG",
            Iso2 = "AG",
            NumericCode = "028",
            PhoneCode = "1",
            Capital = "St. John's",
            Currency = "XCD",
            CurrencyName = "Eastern Caribbean dollar",
            CurrencySymbol = "$",
            Tld = ".ag",
            Native = "Antigua and Barbuda",
            Region = "Americas",
            RegionId = 2,
            Subregion = "Caribbean",
            SubregionId = 7,
            Nationality = "Antiguan or Barbudan",
            Latitude = "17.05000000",
            Longitude = "-61.80000000",
            Emoji = "🇦🇬",
            EmojiU = "U+1F1E6 U+1F1EC",
            Timezones = new List<Timezone>
            {
                new Timezone
                {
                    ZoneName = "America/Antigua",
                    GmtOffset = -14400,
                    GmtOffsetName = "UTC-04:00",
                    Abbreviation = "AST",
                    TzName = "Atlantic Standard Time"
                }
            },
            Translations = new Dictionary<string, string>
            {
                { "ko" = "앤티가 바부다" },
                { "pt-BR" = "Antígua e Barbuda" }
                { "pt" = "Antígua e Barbuda" }
                { "nl" = "Antigua en Barbuda" }
                { "hr" = "Antigva i Barbuda" }
                { "fa" = "آنتیگوا و باربودا" }
                { "de" = "Antigua und Barbuda" }
                { "es" = "Antigua y Barbuda" }
                { "fr" = "Antigua-et-Barbuda" }
                { "ja" = "アンティグア・バーブーダ" }
                { "it" = "Antigua e Barbuda" }
                { "zh-CN" = "安提瓜和巴布达" }
                { "tr" = "Antigua Ve Barbuda" }
                { "ru" = "Антигуа и Барбуда" }
                { "uk" = "Антигуа і Барбуда" }
                { "pl" = "Antigua i Barbuda" }
            },
            States = new List<State>
            {

                new State
                {
                    Id = 1,
                    Name = "Barbuda",
                    StateCode = "10",
                    Latitude = "17.62662420",
                    Longitude = "-61.77130280",
                    Type = "dependency",
                    Cities = new List<City>
                    {

                        new City
                        {
                            Id = 1,
                            Name = "Codrington",
                            Latitude = "17.63333000",
                            Longitude = "-61.83333000"
                        }
                    }
                },

                new State
                {
                    Id = 2,
                    Name = "Redonda",
                    StateCode = "11",
                    Latitude = "16.93841600",
                    Longitude = "-62.34551480",
                    Type = "dependency",
                    Cities = new List<City>
                    {
                    }
                },

                new State
                {
                    Id = 3,
                    Name = "Saint George",
                    StateCode = "03",
                    Latitude = "",
                    Longitude = "",
                    Type = "parish",
                    Cities = new List<City>
                    {

                        new City
                        {
                            Id = 1,
                            Name = "Piggotts",
                            Latitude = "17.11667000",
                            Longitude = "-61.80000000"
                        }
                    }
                },

                new State
                {
                    Id = 4,
                    Name = "Saint John",
                    StateCode = "04",
                    Latitude = "",
                    Longitude = "",
                    Type = "parish",
                    Cities = new List<City>
                    {

                        new City
                        {
                            Id = 1,
                            Name = "Potters Village",
                            Latitude = "17.11337000",
                            Longitude = "-61.81962000"
                        },

                        new City
                        {
                            Id = 2,
                            Name = "Saint John’s",
                            Latitude = "17.12096000",
                            Longitude = "-61.84329000"
                        }
                    }
                },

                new State
                {
                    Id = 5,
                    Name = "Saint Mary",
                    StateCode = "05",
                    Latitude = "",
                    Longitude = "",
                    Type = "parish",
                    Cities = new List<City>
                    {

                        new City
                        {
                            Id = 1,
                            Name = "Bolands",
                            Latitude = "17.06565000",
                            Longitude = "-61.87466000"
                        }
                    }
                },

                new State
                {
                    Id = 6,
                    Name = "Saint Paul",
                    StateCode = "06",
                    Latitude = "",
                    Longitude = "",
                    Type = "parish",
                    Cities = new List<City>
                    {

                        new City
                        {
                            Id = 1,
                            Name = "Falmouth",
                            Latitude = "17.02741000",
                            Longitude = "-61.78136000"
                        },

                        new City
                        {
                            Id = 2,
                            Name = "Liberta",
                            Latitude = "17.04141000",
                            Longitude = "-61.79052000"
                        }
                    }
                },

                new State
                {
                    Id = 7,
                    Name = "Saint Peter",
                    StateCode = "07",
                    Latitude = "",
                    Longitude = "",
                    Type = "parish",
                    Cities = new List<City>
                    {

                        new City
                        {
                            Id = 1,
                            Name = "All Saints",
                            Latitude = "17.06671000",
                            Longitude = "-61.79303000"
                        },

                        new City
                        {
                            Id = 2,
                            Name = "Parham",
                            Latitude = "17.09682000",
                            Longitude = "-61.77046000"
                        }
                    }
                },

                new State
                {
                    Id = 8,
                    Name = "Saint Philip",
                    StateCode = "08",
                    Latitude = "40.43682580",
                    Longitude = "-80.06855320",
                    Type = "parish",
                    Cities = new List<City>
                    {
                    }
                }
            }
        };
    }
}
