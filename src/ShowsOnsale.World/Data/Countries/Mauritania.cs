// ⚠️ WARNING: This file is automatically generated by scripts/generate-world.ps1
// DO NOT modify this file manually as it will be overwritten when the script is run again.
// To update the data, modify the source data in countries-states-cities-database and run the script.

using System.Collections.Generic;
using ShowsOnSale.World.Models;

namespace ShowsOnSale.World.Data.Countries
{
    public static class Mauritania
    {
        public static Country Data { get; } = new()
        {
            Id = 137,
            Name = "Mauritania",
            Iso3 = "MRT",
            Iso2 = "MR",
            NumericCode = "478",
            PhoneCode = "222",
            Capital = "Nouakchott",
            Currency = "MRU",
            CurrencyName = "Mauritanian ouguiya",
            CurrencySymbol = "UM",
            Tld = ".mr",
            Native = "موريتانيا",
            Region = "Africa",
            RegionId = 1,
            Subregion = "Western Africa",
            SubregionId = 3,
            Nationality = "Mauritanian",
            Latitude = "20.00000000",
            Longitude = "-12.00000000",
            Emoji = "🇲🇷",
            EmojiU = "U+1F1F2 U+1F1F7",
            Timezones = new()
            {
                new() { ZoneName = "Africa/Nouakchott", GmtOffset = 0, GmtOffsetName = "UTC±00", Abbreviation = "GMT", TzName = "Greenwich Mean Time" }
            },
            Translations = new()
            {
                { "ko" = "모리타니" },
                { "pt-BR" = "Mauritânia" }
                { "pt" = "Mauritânia" }
                { "nl" = "Mauritanië" }
                { "hr" = "Mauritanija" }
                { "fa" = "موریتانی" }
                { "de" = "Mauretanien" }
                { "es" = "Mauritania" }
                { "fr" = "Mauritanie" }
                { "ja" = "モーリタニア" }
                { "it" = "Mauritania" }
                { "zh-CN" = "毛里塔尼亚" }
                { "tr" = "Moritanya" }
                { "ru" = "Мавритания" }
                { "uk" = "Мавританія" }
                { "pl" = "Mauretania" }
            },
            States = new()
            {

                new()
                {
                    Id = 1,
                    Name = "Adrar",
                    StateCode = "07",
                    Latitude = "19.86521760",
                    Longitude = "-12.80547530",
                    Type = "region",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Atar", Latitude = "20.51770000", Longitude = "-13.04857000" },
                        new() { Id = 2, Name = "Azougui", Latitude = "20.56764000", Longitude = "-13.11191000" },
                        new() { Id = 3, Name = "Chingueṭṭi", Latitude = "20.46300000", Longitude = "-12.36200000" },
                        new() { Id = 4, Name = "Ksar el Khali", Latitude = "20.93333333", Longitude = "-11.61666667" }
                    }
                },

                new()
                {
                    Id = 2,
                    Name = "Assaba",
                    StateCode = "03",
                    Latitude = "16.77595580",
                    Longitude = "-11.52480550",
                    Type = "region",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Barkéwol", Latitude = "16.64039000", Longitude = "-12.49849000" },
                        new() { Id = 2, Name = "Kiffa", Latitude = "16.62073000", Longitude = "-11.40208000" }
                    }
                }

                new()
                {
                    Id = 3,
                    Name = "Brakna",
                    StateCode = "05",
                    Latitude = "17.23175610",
                    Longitude = "-13.17403480",
                    Type = "region",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "’Elb el Jmel", Latitude = "17.01050000", Longitude = "-13.97102000" },
                        new() { Id = 2, Name = "Aleg", Latitude = "17.05314000", Longitude = "-13.91312000" },
                        new() { Id = 3, Name = "Bofal", Latitude = "16.41666667", Longitude = "-13.80000000" },
                        new() { Id = 4, Name = "Sori Malé", Latitude = "16.95416667", Longitude = "-13.37916667" }
                    }
                }

                new()
                {
                    Id = 4,
                    Name = "Dakhlet Nouadhibou",
                    StateCode = "08",
                    Latitude = "20.59855880",
                    Longitude = "-16.25221430",
                    Type = "region",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Cansado", Latitude = "20.85333333", Longitude = "-17.03250000" },
                        new() { Id = 2, Name = "Iouik", Latitude = "19.84944444", Longitude = "-16.33083333" },
                        new() { Id = 3, Name = "Nouadhibou", Latitude = "20.94188000", Longitude = "-17.03842000" }
                    }
                }

                new()
                {
                    Id = 5,
                    Name = "Gorgol",
                    StateCode = "04",
                    Latitude = "15.97173570",
                    Longitude = "-12.62162110",
                    Type = "region",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Kaédi", Latitude = "16.15027000", Longitude = "-13.50370000" }
                    }
                }

                new()
                {
                    Id = 6,
                    Name = "Guidimaka",
                    StateCode = "10",
                    Latitude = "15.25573310",
                    Longitude = "-12.25479190",
                    Type = "region",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Sélibaby", Latitude = "15.15846000", Longitude = "-12.18430000" }
                    }
                }

                new()
                {
                    Id = 7,
                    Name = "Hodh Ech Chargui",
                    StateCode = "01",
                    Latitude = "18.67370260",
                    Longitude = "-7.09287700",
                    Type = "region",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Diade", Latitude = "16.23333333", Longitude = "-7.41666667" },
                        new() { Id = 2, Name = "Kataouane", Latitude = "16.06888889", Longitude = "-6.49888889" },
                        new() { Id = 3, Name = "Néma", Latitude = "16.61702000", Longitude = "-7.25649000" },
                        new() { Id = 4, Name = "Timbedra", Latitude = "16.24472222", Longitude = "-8.16750000" }
                    }
                }

                new()
                {
                    Id = 8,
                    Name = "Hodh El Gharbi",
                    StateCode = "02",
                    Latitude = "16.69121490",
                    Longitude = "-9.54509740",
                    Type = "region",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Aioun", Latitude = "16.66140000", Longitude = "-9.61490000" },
                        new() { Id = 2, Name = "Ayoun el Atrous", Latitude = "16.66666667", Longitude = "-9.61666667" },
                        new() { Id = 3, Name = "Togba", Latitude = "17.40000000", Longitude = "-10.36666667" }
                    }
                }

                new()
                {
                    Id = 9,
                    Name = "Inchiri",
                    StateCode = "12",
                    Latitude = "20.02805610",
                    Longitude = "-15.40680790",
                    Type = "region",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Akjoujt", Latitude = "19.74657000", Longitude = "-14.38531000" }
                    }
                }

                new()
                {
                    Id = 10,
                    Name = "Nouakchott-Nord",
                    StateCode = "14",
                    Latitude = "18.11302050",
                    Longitude = "-15.89949560",
                    Type = "region",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Dar-Naim", Latitude = "18.03333333", Longitude = "-15.96666667" },
                        new() { Id = 2, Name = "Teyarett", Latitude = "18.12895720", Longitude = "-15.93778340" },
                        new() { Id = 3, Name = "Toujouonine", Latitude = "18.07169000", Longitude = "-15.90311000" }
                    }
                },

                new()
                {
                    Id = 11,
                    Name = "Nouakchott-Ouest",
                    StateCode = "13",
                    Latitude = "18.15113570",
                    Longitude = "-15.99349100",
                    Type = "region",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Ksar", Latitude = "18.10222222", Longitude = "-15.95500000" },
                        new() { Id = 2, Name = "Sebkha", Latitude = "18.07555556", Longitude = "-16.00194444" },
                        new() { Id = 3, Name = "Tevragh-Zeina", Latitude = "18.11011000", Longitude = "-15.99931000" }
                    }
                },

                new()
                {
                    Id = 12,
                    Name = "Nouakchott-Sud",
                    StateCode = "15",
                    Latitude = "17.97092880",
                    Longitude = "-15.94648740",
                    Type = "region",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Arafat", Latitude = "18.04639000", Longitude = "-15.97194000" },
                        new() { Id = 2, Name = "Riyad", Latitude = "18.10222222", Longitude = "-15.95500000" }
                    }
                },

                new()
                {
                    Id = 13,
                    Name = "Tagant",
                    StateCode = "09",
                    Latitude = "18.54675270",
                    Longitude = "-9.90181310",
                    Type = "region",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Moudjeria", Latitude = "17.97955140", Longitude = "-13.39795340" },
                        new() { Id = 2, Name = "Tichit", Latitude = "18.49686260", Longitude = "-12.12199350" },
                        new() { Id = 3, Name = "Tijigja", Latitude = "18.51647870", Longitude = "-12.98264760" }
                    }
                },

                new()
                {
                    Id = 14,
                    Name = "Tiris Zemmour",
                    StateCode = "11",
                    Latitude = "24.57737640",
                    Longitude = "-9.90181310",
                    Type = "region",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Ain Ben Tili", Latitude = "25.99444444", Longitude = "-9.55333333" },
                        new() { Id = 2, Name = "Chegga", Latitude = "25.37194444", Longitude = "-5.78666667" },
                        new() { Id = 3, Name = "Fderîck", Latitude = "22.67777778", Longitude = "-12.70750000" },
                        new() { Id = 4, Name = "Zouérat", Latitude = "22.73444444", Longitude = "-12.47250000" },
                        new() { Id = 5, Name = "Zouerate", Latitude = "22.73542000", Longitude = "-12.47134000" }
                    }
                },

                new()
                {
                    Id = 15,
                    Name = "Trarza",
                    StateCode = "06",
                    Latitude = "17.86649640",
                    Longitude = "-14.65878210",
                    Type = "region",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Legat", Latitude = "16.75000000", Longitude = "-14.83333333" },
                        new() { Id = 2, Name = "Rosso", Latitude = "16.51378000", Longitude = "-15.80503000" },
                        new() { Id = 3, Name = "Tékane", Latitude = "16.60175000", Longitude = "-15.34866000" }
                    }
                }
            }
        };
    }
}
