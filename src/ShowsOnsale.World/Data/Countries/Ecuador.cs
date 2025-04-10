// ⚠️ WARNING: This file is automatically generated by scripts/generate-world.ps1
// DO NOT modify this file manually as it will be overwritten when the script is run again.
// To update the data, modify the source data in countries-states-cities-database and run the script.

using System.Collections.Generic;
using ShowsOnSale.World.Models;

namespace ShowsOnSale.World.Data.Countries
{
    public static class Ecuador
    {
        public static Country Data { get; } = new()
        {
            Id = 64,
            Name = "Ecuador",
            Iso3 = "ECU",
            Iso2 = "EC",
            NumericCode = "218",
            PhoneCode = "593",
            Capital = "Quito",
            Currency = "USD",
            CurrencyName = "United States dollar",
            CurrencySymbol = "$",
            Tld = ".ec",
            Native = "Ecuador",
            Region = "Americas",
            RegionId = 2,
            Subregion = "South America",
            SubregionId = 8,
            Nationality = "Ecuadorian",
            Latitude = "-2.00000000",
            Longitude = "-77.50000000",
            Emoji = "🇪🇨",
            EmojiU = "U+1F1EA U+1F1E8",
            Timezones = new()
            {
                new() { ZoneName = "America/Guayaquil", GmtOffset = -18000, GmtOffsetName = "UTC-05:00", Abbreviation = "ECT", TzName = "Ecuador Time" },
                new() { ZoneName = "Pacific/Galapagos", GmtOffset = -21600, GmtOffsetName = "UTC-06:00", Abbreviation = "GALT", TzName = "Galápagos Time" }
            },
            Translations = new()
            {
                { "ko" = "에콰도르" },
                { "pt-BR" = "Equador" }
                { "pt" = "Equador" }
                { "nl" = "Ecuador" }
                { "hr" = "Ekvador" }
                { "fa" = "اکوادور" }
                { "de" = "Ecuador" }
                { "es" = "Ecuador" }
                { "fr" = "Équateur" }
                { "ja" = "エクアドル" }
                { "it" = "Ecuador" }
                { "zh-CN" = "厄瓜多尔" }
                { "tr" = "Ekvator" }
                { "ru" = "Эквадор" }
                { "uk" = "Еквадор" }
                { "pl" = "Ekwador" }
            },
            States = new()
            {

                new()
                {
                    Id = 1,
                    Name = "Azuay",
                    StateCode = "A",
                    Latitude = "-2.89430680",
                    Longitude = "-78.99683440",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Cantón San Fernando", Latitude = "-3.13349000", Longitude = "-79.26893000" },
                        new() { Id = 2, Name = "Cuenca", Latitude = "-2.90055000", Longitude = "-79.00453000" },
                        new() { Id = 3, Name = "Gualaceo", Latitude = "-2.89264000", Longitude = "-78.77814000" },
                        new() { Id = 4, Name = "La Unión", Latitude = "-2.85000000", Longitude = "-78.78333000" },
                        new() { Id = 5, Name = "Llacao", Latitude = "-2.86667000", Longitude = "-78.88333000" },
                        new() { Id = 6, Name = "Nulti", Latitude = "-2.91667000", Longitude = "-78.85000000" }
                    }
                },

                new()
                {
                    Id = 2,
                    Name = "Bolívar",
                    StateCode = "B",
                    Latitude = "-1.70958280",
                    Longitude = "-79.04504290",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Guaranda", Latitude = "-1.59263000", Longitude = "-79.00098000" },
                        new() { Id = 2, Name = "San Miguel", Latitude = "-1.70884000", Longitude = "-79.04311000" }
                    }
                },

                new()
                {
                    Id = 3,
                    Name = "Cañar",
                    StateCode = "F",
                    Latitude = "-2.55893150",
                    Longitude = "-78.93881910",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Azogues", Latitude = "-2.73969000", Longitude = "-78.84860000" },
                        new() { Id = 2, Name = "Cañar", Latitude = "-2.56062000", Longitude = "-78.93940000" },
                        new() { Id = 3, Name = "La Troncal", Latitude = "-2.42355000", Longitude = "-79.33977000" }
                    }
                }

                new()
                {
                    Id = 4,
                    Name = "Carchi",
                    StateCode = "C",
                    Latitude = "0.50269120",
                    Longitude = "-77.90425210",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "El Ángel", Latitude = "0.62279000", Longitude = "-77.94003000" },
                        new() { Id = 2, Name = "San Gabriel", Latitude = "0.59318000", Longitude = "-77.83078000" },
                        new() { Id = 3, Name = "Tulcán", Latitude = "0.81187000", Longitude = "-77.71727000" }
                    }
                }

                new()
                {
                    Id = 5,
                    Name = "Chimborazo",
                    StateCode = "H",
                    Latitude = "-1.66479950",
                    Longitude = "-78.65432550",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Alausí", Latitude = "-2.20329000", Longitude = "-78.84714000" },
                        new() { Id = 2, Name = "Guano", Latitude = "-1.60789000", Longitude = "-78.63105000" },
                        new() { Id = 3, Name = "Riobamba", Latitude = "-1.67098000", Longitude = "-78.64712000" }
                    }
                }

                new()
                {
                    Id = 6,
                    Name = "Cotopaxi",
                    StateCode = "X",
                    Latitude = "-0.83842060",
                    Longitude = "-78.66626780",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "La Maná", Latitude = "-0.94094000", Longitude = "-79.22506000" },
                        new() { Id = 2, Name = "Latacunga", Latitude = "-0.93521000", Longitude = "-78.61554000" },
                        new() { Id = 3, Name = "Pujilí", Latitude = "-0.95759000", Longitude = "-78.69636000" },
                        new() { Id = 4, Name = "San Miguel de Salcedo", Latitude = "-1.04547000", Longitude = "-78.59063000" },
                        new() { Id = 5, Name = "Saquisilí", Latitude = "-0.83990000", Longitude = "-78.66700000" }
                    }
                }

                new()
                {
                    Id = 7,
                    Name = "El Oro",
                    StateCode = "O",
                    Latitude = "-3.25924130",
                    Longitude = "-79.95835410",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Huaquillas", Latitude = "-3.47523000", Longitude = "-80.23084000" },
                        new() { Id = 2, Name = "Machala", Latitude = "-3.25861000", Longitude = "-79.96053000" },
                        new() { Id = 3, Name = "Pasaje", Latitude = "-3.32561000", Longitude = "-79.80697000" },
                        new() { Id = 4, Name = "Piñas", Latitude = "-3.68107000", Longitude = "-79.68083000" },
                        new() { Id = 5, Name = "Portovelo", Latitude = "-3.72145000", Longitude = "-79.62187000" },
                        new() { Id = 6, Name = "Puerto Bolívar", Latitude = "-3.26649000", Longitude = "-79.99749000" },
                        new() { Id = 7, Name = "Santa Rosa", Latitude = "-3.44882000", Longitude = "-79.95952000" },
                        new() { Id = 8, Name = "Zaruma", Latitude = "-3.69132000", Longitude = "-79.61174000" }
                    }
                }

                new()
                {
                    Id = 8,
                    Name = "Esmeraldas",
                    StateCode = "E",
                    Latitude = "0.96817890",
                    Longitude = "-79.65172020",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Esmeraldas", Latitude = "0.95920000", Longitude = "-79.65397000" },
                        new() { Id = 2, Name = "Muisne", Latitude = "0.61129000", Longitude = "-80.01863000" },
                        new() { Id = 3, Name = "Pampanal de Bolívar", Latitude = "1.35251000", Longitude = "-78.89360000" },
                        new() { Id = 4, Name = "Rio Verde", Latitude = "1.06235000", Longitude = "-79.39939000" },
                        new() { Id = 5, Name = "Rosa Zarate", Latitude = "0.32779000", Longitude = "-79.47407000" },
                        new() { Id = 6, Name = "San Lorenzo de Esmeraldas", Latitude = "1.28626000", Longitude = "-78.83514000" },
                        new() { Id = 7, Name = "Valdez", Latitude = "1.24917000", Longitude = "-78.98306000" }
                    }
                }

                new()
                {
                    Id = 9,
                    Name = "Galápagos",
                    StateCode = "W",
                    Latitude = "-0.95376910",
                    Longitude = "-90.96560190",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Puerto Ayora", Latitude = "-0.74018000", Longitude = "-90.31380000" },
                        new() { Id = 2, Name = "Puerto Baquerizo Moreno", Latitude = "-0.90172000", Longitude = "-89.61021000" },
                        new() { Id = 3, Name = "Puerto Villamil", Latitude = "-0.95542000", Longitude = "-90.96654000" }
                    }
                }

                new()
                {
                    Id = 10,
                    Name = "Guayas",
                    StateCode = "G",
                    Latitude = "-1.95748390",
                    Longitude = "-79.91927020",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Alfredo Baquerizo Moreno", Latitude = "-1.91667000", Longitude = "-79.51667000" },
                        new() { Id = 2, Name = "Baláo", Latitude = "-2.91100000", Longitude = "-79.81441000" },
                        new() { Id = 3, Name = "Balzar", Latitude = "-1.36501000", Longitude = "-79.90494000" },
                        new() { Id = 4, Name = "Colimes", Latitude = "-1.54553000", Longitude = "-80.01165000" },
                        new() { Id = 5, Name = "Coronel Marcelino Maridueña", Latitude = "-2.20924000", Longitude = "-79.43248000" },
                        new() { Id = 6, Name = "El Triunfo", Latitude = "-1.93333000", Longitude = "-79.96667000" },
                        new() { Id = 7, Name = "Eloy Alfaro", Latitude = "-2.17579000", Longitude = "-79.85519000" },
                        new() { Id = 8, Name = "Guayaquil", Latitude = "-2.19616000", Longitude = "-79.88621000" },
                        new() { Id = 9, Name = "Lomas de Sargentillo", Latitude = "-1.88333000", Longitude = "-80.08333000" },
                        new() { Id = 10, Name = "Milagro", Latitude = "-2.13404000", Longitude = "-79.59415000" },
                        new() { Id = 11, Name = "Naranjal", Latitude = "-2.67364000", Longitude = "-79.61830000" },
                        new() { Id = 12, Name = "Naranjito", Latitude = "-2.16671000", Longitude = "-79.46540000" },
                        new() { Id = 13, Name = "Palestina", Latitude = "-1.93709000", Longitude = "-79.71396000" },
                        new() { Id = 14, Name = "Pedro Carbo", Latitude = "-1.81563000", Longitude = "-80.23309000" },
                        new() { Id = 15, Name = "Playas", Latitude = "-2.63199000", Longitude = "-80.38808000" },
                        new() { Id = 16, Name = "Samborondón", Latitude = "-1.96276000", Longitude = "-79.72402000" },
                        new() { Id = 17, Name = "Santa Lucía", Latitude = "-2.18333000", Longitude = "-80.00000000" },
                        new() { Id = 18, Name = "Velasco Ibarra", Latitude = "-1.04376000", Longitude = "-79.63837000" },
                        new() { Id = 19, Name = "Yaguachi Nuevo", Latitude = "-2.09680000", Longitude = "-79.69485000" }
                    }
                },

                new()
                {
                    Id = 11,
                    Name = "Imbabura",
                    StateCode = "I",
                    Latitude = "0.34997680",
                    Longitude = "-78.12601290",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Atuntaqui", Latitude = "0.33247000", Longitude = "-78.21371000" },
                        new() { Id = 2, Name = "Cotacachi", Latitude = "0.30107000", Longitude = "-78.26428000" },
                        new() { Id = 3, Name = "Ibarra", Latitude = "0.35171000", Longitude = "-78.12233000" },
                        new() { Id = 4, Name = "Otavalo", Latitude = "0.23457000", Longitude = "-78.26248000" },
                        new() { Id = 5, Name = "Pimampiro", Latitude = "0.39116000", Longitude = "-77.94068000" }
                    }
                },

                new()
                {
                    Id = 12,
                    Name = "Loja",
                    StateCode = "L",
                    Latitude = "-3.99313000",
                    Longitude = "-79.20422000",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Loja", Latitude = "-3.99313000", Longitude = "-79.20422000" }
                    }
                },

                new()
                {
                    Id = 13,
                    Name = "Los Ríos",
                    StateCode = "R",
                    Latitude = "-1.02306070",
                    Longitude = "-79.46088970",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Babahoyo", Latitude = "-1.80217000", Longitude = "-79.53443000" },
                        new() { Id = 2, Name = "Catarama", Latitude = "-1.57504000", Longitude = "-79.45998000" },
                        new() { Id = 3, Name = "Montalvo", Latitude = "-1.79008000", Longitude = "-79.28759000" },
                        new() { Id = 4, Name = "Palenque", Latitude = "-1.43795000", Longitude = "-79.75647000" },
                        new() { Id = 5, Name = "Quevedo", Latitude = "-1.02863000", Longitude = "-79.46352000" },
                        new() { Id = 6, Name = "Ventanas", Latitude = "-1.44158000", Longitude = "-79.45943000" },
                        new() { Id = 7, Name = "Vinces", Latitude = "-1.55611000", Longitude = "-79.75191000" }
                    }
                },

                new()
                {
                    Id = 14,
                    Name = "Manabí",
                    StateCode = "M",
                    Latitude = "-1.05434340",
                    Longitude = "-80.45264400",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Bahía de Caráquez", Latitude = "-0.59792000", Longitude = "-80.42367000" },
                        new() { Id = 2, Name = "Calceta", Latitude = "-0.84582000", Longitude = "-80.16389000" },
                        new() { Id = 3, Name = "Cantón Portoviejo", Latitude = "-1.05000000", Longitude = "-80.45000000" },
                        new() { Id = 4, Name = "Chone", Latitude = "-0.69819000", Longitude = "-80.09361000" },
                        new() { Id = 5, Name = "Jipijapa", Latitude = "-1.34872000", Longitude = "-80.57875000" },
                        new() { Id = 6, Name = "Junín", Latitude = "-0.92777000", Longitude = "-80.20583000" },
                        new() { Id = 7, Name = "Manta", Latitude = "-0.96212000", Longitude = "-80.71271000" },
                        new() { Id = 8, Name = "Montecristi", Latitude = "-1.04576000", Longitude = "-80.65889000" },
                        new() { Id = 9, Name = "Paján", Latitude = "-1.55238000", Longitude = "-80.42958000" },
                        new() { Id = 10, Name = "Pedernales", Latitude = "0.07167000", Longitude = "-80.05250000" },
                        new() { Id = 11, Name = "Portoviejo", Latitude = "-1.05458000", Longitude = "-80.45445000" },
                        new() { Id = 12, Name = "Rocafuerte", Latitude = "-0.92360000", Longitude = "-80.44946000" },
                        new() { Id = 13, Name = "San Vicente", Latitude = "-0.60435000", Longitude = "-80.40267000" },
                        new() { Id = 14, Name = "Santa Ana", Latitude = "-1.20726000", Longitude = "-80.37132000" },
                        new() { Id = 15, Name = "Sucre", Latitude = "-1.27974000", Longitude = "-80.41885000" },
                        new() { Id = 16, Name = "Tosagua", Latitude = "-0.78679000", Longitude = "-80.23473000" }
                    }
                },

                new()
                {
                    Id = 15,
                    Name = "Morona-Santiago",
                    StateCode = "S",
                    Latitude = "-2.30510620",
                    Longitude = "-78.11468660",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Gualaquiza", Latitude = "-3.40359000", Longitude = "-78.58166000" },
                        new() { Id = 2, Name = "Macas", Latitude = "-2.30868000", Longitude = "-78.11135000" },
                        new() { Id = 3, Name = "Palora", Latitude = "-1.70131000", Longitude = "-77.96516000" },
                        new() { Id = 4, Name = "Sucúa", Latitude = "-2.45866000", Longitude = "-78.17171000" }
                    }
                },

                new()
                {
                    Id = 16,
                    Name = "Napo",
                    StateCode = "N",
                    Latitude = "-0.99559640",
                    Longitude = "-77.81296840",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Archidona", Latitude = "-0.90950000", Longitude = "-77.80772000" },
                        new() { Id = 2, Name = "Tena", Latitude = "-0.99380000", Longitude = "-77.81286000" }
                    }
                },

                new()
                {
                    Id = 17,
                    Name = "Orellana",
                    StateCode = "D",
                    Latitude = "-0.45451630",
                    Longitude = "-76.99502860",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Boca Suno", Latitude = "-0.69832000", Longitude = "-77.14083000" },
                        new() { Id = 2, Name = "Francisco de Orellana Canton", Latitude = "-0.46667000", Longitude = "-76.96667000" },
                        new() { Id = 3, Name = "Loreto Canton", Latitude = "-0.69487000", Longitude = "-77.30255000" },
                        new() { Id = 4, Name = "Puerto Francisco de Orellana", Latitude = "-0.46645000", Longitude = "-76.98719000" }
                    }
                },

                new()
                {
                    Id = 18,
                    Name = "Pastaza",
                    StateCode = "Y",
                    Latitude = "-1.48822650",
                    Longitude = "-78.00310570",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Puyo", Latitude = "-1.48369000", Longitude = "-78.00257000" }
                    }
                },

                new()
                {
                    Id = 19,
                    Name = "Pichincha",
                    StateCode = "P",
                    Latitude = "-0.14648470",
                    Longitude = "-78.47519450",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Cayambe", Latitude = "0.04084000", Longitude = "-78.14524000" },
                        new() { Id = 2, Name = "Machachi", Latitude = "-0.51011000", Longitude = "-78.56712000" },
                        new() { Id = 3, Name = "Quito", Latitude = "-0.22985000", Longitude = "-78.52495000" },
                        new() { Id = 4, Name = "Sangolquí", Latitude = "-0.33405000", Longitude = "-78.45217000" }
                    }
                },

                new()
                {
                    Id = 20,
                    Name = "Santa Elena",
                    StateCode = "SE",
                    Latitude = "-2.22671050",
                    Longitude = "-80.85949900",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "La Libertad", Latitude = "-2.23300000", Longitude = "-80.91039000" },
                        new() { Id = 2, Name = "Salinas", Latitude = "-2.21452000", Longitude = "-80.95151000" },
                        new() { Id = 3, Name = "Santa Elena", Latitude = "-2.22622000", Longitude = "-80.85873000" }
                    }
                },

                new()
                {
                    Id = 21,
                    Name = "Santo Domingo de los Tsáchilas",
                    StateCode = "SD",
                    Latitude = "-0.25218820",
                    Longitude = "-79.18793830",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Santo Domingo de los Colorados", Latitude = "-0.25305000", Longitude = "-79.17536000" }
                    }
                },

                new()
                {
                    Id = 22,
                    Name = "Sucumbíos",
                    StateCode = "U",
                    Latitude = "0.08892310",
                    Longitude = "-76.88975570",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Nueva Loja", Latitude = "0.08600000", Longitude = "-76.89528000" }
                    }
                },

                new()
                {
                    Id = 23,
                    Name = "Tungurahua",
                    StateCode = "T",
                    Latitude = "-1.26352840",
                    Longitude = "-78.56608520",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Ambato", Latitude = "-1.24908000", Longitude = "-78.61675000" },
                        new() { Id = 2, Name = "Baños", Latitude = "-1.39699000", Longitude = "-78.42289000" },
                        new() { Id = 3, Name = "Pelileo", Latitude = "-1.32990000", Longitude = "-78.54341000" },
                        new() { Id = 4, Name = "Píllaro", Latitude = "-1.17414000", Longitude = "-78.54676000" }
                    }
                },

                new()
                {
                    Id = 24,
                    Name = "Zamora Chinchipe",
                    StateCode = "Z",
                    Latitude = "-4.06558920",
                    Longitude = "-78.95035250",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Yantzaza", Latitude = "-3.83261000", Longitude = "-78.76076000" },
                        new() { Id = 2, Name = "Zamora", Latitude = "-4.06685000", Longitude = "-78.95488000" }
                    }
                }
            }
        };
    }
}
