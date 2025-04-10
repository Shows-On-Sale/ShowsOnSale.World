// ⚠️ WARNING: This file is automatically generated by scripts/generate-world.ps1
// DO NOT modify this file manually as it will be overwritten when the script is run again.
// To update the data, modify the source data in countries-states-cities-database and run the script.

using System.Collections.Generic;
using ShowsOnSale.World.Models;

namespace ShowsOnSale.World.Data.Countries
{
    public static class CapeVerde
    {
        public static Country Data { get; } = new Country
        {
            Id = 40,
            Name = "Cape Verde",
            Iso3 = "CPV",
            Iso2 = "CV",
            NumericCode = "132",
            PhoneCode = "238",
            Capital = "Praia",
            Currency = "CVE",
            CurrencyName = "Cape Verdean escudo",
            CurrencySymbol = "$",
            Tld = ".cv",
            Native = "Cabo Verde",
            Region = "Africa",
            RegionId = 1,
            Subregion = "Western Africa",
            SubregionId = 3,
            Nationality = "Verdean",
            Latitude = "16.00000000",
            Longitude = "-24.00000000",
            Emoji = "🇨🇻",
            EmojiU = "U+1F1E8 U+1F1FB",
            Timezones = new List<Timezone>
            {
                new Timezone
                {
                    ZoneName = "Atlantic/Cape_Verde",
                    GmtOffset = -3600,
                    GmtOffsetName = "UTC-01:00",
                    Abbreviation = "CVT",
                    TzName = "Cape Verde Time"
                }
            },
            Translations = new Dictionary<string, string>
            {
                { "ko" = "카보베르데" },
                { "pt-BR" = "Cabo Verde" }
                { "pt" = "Cabo Verde" }
                { "nl" = "Kaapverdië" }
                { "hr" = "Zelenortska Republika" }
                { "fa" = "کیپ ورد" }
                { "de" = "Kap Verde" }
                { "es" = "Cabo Verde" }
                { "fr" = "Cap Vert" }
                { "ja" = "カーボベルデ" }
                { "it" = "Capo Verde" }
                { "zh-CN" = "佛得角" }
                { "tr" = "Cabo Verde" }
                { "ru" = "Кабо-Верде" }
                { "uk" = "Кабо-Верде" }
                { "pl" = "Republika Zielonego Przylądka" }
            },
            States = new List<State>
            {

                new State
                {
                    Id = 1,
                    Name = "Barlavento Islands",
                    StateCode = "B",
                    Latitude = "16.82368450",
                    Longitude = "-23.99348810",
                    Type = "geographical region",
                    Cities = new List<City>
                    {
                    }
                },

                new State
                {
                    Id = 2,
                    Name = "Boa Vista",
                    StateCode = "BV",
                    Latitude = "38.74346600",
                    Longitude = "-120.73042970",
                    Type = "municipality",
                    Cities = new List<City>
                    {

                        new City
                        {
                            Id = 1,
                            Name = "Sal Rei",
                            Latitude = "16.17611000",
                            Longitude = "-22.91722000"
                        }
                    }
                },

                new State
                {
                    Id = 3,
                    Name = "Brava",
                    StateCode = "BR",
                    Latitude = "40.98977780",
                    Longitude = "-73.68357150",
                    Type = "municipality",
                    Cities = new List<City>
                    {

                        new City
                        {
                            Id = 1,
                            Name = "Nova Sintra",
                            Latitude = "14.87139000",
                            Longitude = "-24.69556000"
                        }
                    }
                }

                new State
                {
                    Id = 4,
                    Name = "Maio",
                    StateCode = "MA",
                    Latitude = "15.20030980",
                    Longitude = "-23.16797930",
                    Type = "municipality",
                    Cities = new List<City>
                    {

                        new City
                        {
                            Id = 1,
                            Name = "Vila do Maio",
                            Latitude = "15.13823000",
                            Longitude = "-23.21158000"
                        }
                    }
                }

                new State
                {
                    Id = 5,
                    Name = "Mosteiros",
                    StateCode = "MO",
                    Latitude = "37.89043480",
                    Longitude = "-25.82075560",
                    Type = "municipality",
                    Cities = new List<City>
                    {

                        new City
                        {
                            Id = 1,
                            Name = "Igreja",
                            Latitude = "15.03389000",
                            Longitude = "-24.32500000"
                        }
                    }
                }

                new State
                {
                    Id = 6,
                    Name = "Paul",
                    StateCode = "PA",
                    Latitude = "37.06250000",
                    Longitude = "-95.67706800",
                    Type = "municipality",
                    Cities = new List<City>
                    {

                        new City
                        {
                            Id = 1,
                            Name = "Pombas",
                            Latitude = "17.15026000",
                            Longitude = "-25.02007000"
                        }
                    }
                }

                new State
                {
                    Id = 7,
                    Name = "Porto Novo",
                    StateCode = "PN",
                    Latitude = "6.49685740",
                    Longitude = "2.62885230",
                    Type = "municipality",
                    Cities = new List<City>
                    {

                        new City
                        {
                            Id = 1,
                            Name = "Porto Novo",
                            Latitude = "17.01969000",
                            Longitude = "-25.06471000"
                        }
                    }
                }

                new State
                {
                    Id = 8,
                    Name = "Praia",
                    StateCode = "PR",
                    Latitude = "14.93305000",
                    Longitude = "-23.51332670",
                    Type = "municipality",
                    Cities = new List<City>
                    {

                        new City
                        {
                            Id = 1,
                            Name = "Praia",
                            Latitude = "14.93152000",
                            Longitude = "-23.51254000"
                        }
                    }
                }

                new State
                {
                    Id = 9,
                    Name = "Ribeira Brava",
                    StateCode = "RB",
                    Latitude = "16.60707390",
                    Longitude = "-24.20338430",
                    Type = "municipality",
                    Cities = new List<City>
                    {

                        new City
                        {
                            Id = 1,
                            Name = "Ribeira Brava",
                            Latitude = "16.61583000",
                            Longitude = "-24.29833000"
                        }
                    }
                }

                new State
                {
                    Id = 10,
                    Name = "Ribeira Grande",
                    StateCode = "RG",
                    Latitude = "37.82103690",
                    Longitude = "-25.51481370",
                    Type = "municipality",
                    Cities = new List<City>
                    {

                        new City
                        {
                            Id = 1,
                            Name = "Ponta do Sol",
                            Latitude = "17.20171000",
                            Longitude = "-25.09217000"
                        },

                        new City
                        {
                            Id = 2,
                            Name = "Ribeira Grande",
                            Latitude = "17.18250000",
                            Longitude = "-25.06500000"
                        }
                    }
                },

                new State
                {
                    Id = 11,
                    Name = "Ribeira Grande de Santiago",
                    StateCode = "RS",
                    Latitude = "14.98302980",
                    Longitude = "-23.65617250",
                    Type = "municipality",
                    Cities = new List<City>
                    {

                        new City
                        {
                            Id = 1,
                            Name = "Cidade Velha",
                            Latitude = "14.91531000",
                            Longitude = "-23.60527000"
                        }
                    }
                },

                new State
                {
                    Id = 12,
                    Name = "Sal",
                    StateCode = "SL",
                    Latitude = "26.59581220",
                    Longitude = "-80.20450830",
                    Type = "municipality",
                    Cities = new List<City>
                    {

                        new City
                        {
                            Id = 1,
                            Name = "Espargos",
                            Latitude = "16.75524000",
                            Longitude = "-22.94460000"
                        },

                        new City
                        {
                            Id = 2,
                            Name = "Santa Maria",
                            Latitude = "16.59796000",
                            Longitude = "-22.90509000"
                        }
                    }
                },

                new State
                {
                    Id = 13,
                    Name = "Santa Catarina",
                    StateCode = "CA",
                    Latitude = "-27.24233920",
                    Longitude = "-50.21885560",
                    Type = "municipality",
                    Cities = new List<City>
                    {

                        new City
                        {
                            Id = 1,
                            Name = "Assomada",
                            Latitude = "15.10000000",
                            Longitude = "-23.68333000"
                        }
                    }
                },

                new State
                {
                    Id = 14,
                    Name = "Santa Catarina do Fogo",
                    StateCode = "CF",
                    Latitude = "14.93091040",
                    Longitude = "-24.32225770",
                    Type = "municipality",
                    Cities = new List<City>
                    {

                        new City
                        {
                            Id = 1,
                            Name = "Cova Figueira",
                            Latitude = "14.89054000",
                            Longitude = "-24.29343000"
                        }
                    }
                },

                new State
                {
                    Id = 15,
                    Name = "Santa Cruz",
                    StateCode = "CR",
                    Latitude = "36.97411710",
                    Longitude = "-122.03079630",
                    Type = "municipality",
                    Cities = new List<City>
                    {

                        new City
                        {
                            Id = 1,
                            Name = "Pedra Badejo",
                            Latitude = "15.13750000",
                            Longitude = "-23.53083000"
                        },

                        new City
                        {
                            Id = 2,
                            Name = "Santa Cruz",
                            Latitude = "15.13333000",
                            Longitude = "-23.56667000"
                        }
                    }
                },

                new State
                {
                    Id = 16,
                    Name = "São Domingos",
                    StateCode = "SD",
                    Latitude = "15.02861650",
                    Longitude = "-23.56392200",
                    Type = "municipality",
                    Cities = new List<City>
                    {

                        new City
                        {
                            Id = 1,
                            Name = "São Domingos",
                            Latitude = "15.02438000",
                            Longitude = "-23.56250000"
                        }
                    }
                },

                new State
                {
                    Id = 17,
                    Name = "São Filipe",
                    StateCode = "SF",
                    Latitude = "14.89516790",
                    Longitude = "-24.49456360",
                    Type = "municipality",
                    Cities = new List<City>
                    {

                        new City
                        {
                            Id = 1,
                            Name = "São Filipe",
                            Latitude = "14.89610000",
                            Longitude = "-24.49556000"
                        }
                    }
                },

                new State
                {
                    Id = 18,
                    Name = "São Lourenço dos Órgãos",
                    StateCode = "SO",
                    Latitude = "15.05378410",
                    Longitude = "-23.60856120",
                    Type = "municipality",
                    Cities = new List<City>
                    {

                        new City
                        {
                            Id = 1,
                            Name = "João Teves",
                            Latitude = "15.06694000",
                            Longitude = "-23.58917000"
                        }
                    }
                },

                new State
                {
                    Id = 19,
                    Name = "São Miguel",
                    StateCode = "SM",
                    Latitude = "37.78041100",
                    Longitude = "-25.49704660",
                    Type = "municipality",
                    Cities = new List<City>
                    {

                        new City
                        {
                            Id = 1,
                            Name = "Calheta",
                            Latitude = "15.18613000",
                            Longitude = "-23.59228000"
                        }
                    }
                },

                new State
                {
                    Id = 20,
                    Name = "São Vicente",
                    StateCode = "SV",
                    Latitude = "-23.96071570",
                    Longitude = "-46.39620220",
                    Type = "municipality",
                    Cities = new List<City>
                    {

                        new City
                        {
                            Id = 1,
                            Name = "Mindelo",
                            Latitude = "16.89014000",
                            Longitude = "-24.98042000"
                        }
                    }
                },

                new State
                {
                    Id = 21,
                    Name = "Sotavento Islands",
                    StateCode = "S",
                    Latitude = "15.00000000",
                    Longitude = "-24.00000000",
                    Type = "geographical region",
                    Cities = new List<City>
                    {
                    }
                },

                new State
                {
                    Id = 22,
                    Name = "Tarrafal",
                    StateCode = "TA",
                    Latitude = "15.27605780",
                    Longitude = "-23.74840770",
                    Type = "municipality",
                    Cities = new List<City>
                    {

                        new City
                        {
                            Id = 1,
                            Name = "Tarrafal",
                            Latitude = "15.27881000",
                            Longitude = "-23.75192000"
                        }
                    }
                },

                new State
                {
                    Id = 23,
                    Name = "Tarrafal de São Nicolau",
                    StateCode = "TS",
                    Latitude = "16.56364980",
                    Longitude = "-24.35494200",
                    Type = "municipality",
                    Cities = new List<City>
                    {

                        new City
                        {
                            Id = 1,
                            Name = "Tarrafal de São Nicolau",
                            Latitude = "16.56622000",
                            Longitude = "-24.35793000"
                        }
                    }
                }
            }
        };
    }
}
