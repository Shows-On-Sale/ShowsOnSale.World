// ⚠️ WARNING: This file is automatically generated by scripts/generate-world.ps1
// DO NOT modify this file manually as it will be overwritten when the script is run again.
// To update the data, modify the source data in countries-states-cities-database and run the script.

using System.Collections.Generic;
using ShowsOnSale.World.Models;

namespace ShowsOnSale.World.Data.Countries
{
    public static class Cuba
    {
        public static Country Data { get; } = new()
        {
            Id = 55,
            Name = "Cuba",
            Iso3 = "CUB",
            Iso2 = "CU",
            NumericCode = "192",
            PhoneCode = "53",
            Capital = "Havana",
            Currency = "CUP",
            CurrencyName = "Cuban peso",
            CurrencySymbol = "$",
            Tld = ".cu",
            Native = "Cuba",
            Region = "Americas",
            RegionId = 2,
            Subregion = "Caribbean",
            SubregionId = 7,
            Nationality = "Cuban",
            Latitude = "21.50000000",
            Longitude = "-80.00000000",
            Emoji = "🇨🇺",
            EmojiU = "U+1F1E8 U+1F1FA",
            Timezones = new()
            {
                new() { ZoneName = "America/Havana", GmtOffset = -18000, GmtOffsetName = "UTC-05:00", Abbreviation = "CST", TzName = "Cuba Standard Time" }
            },
            Translations = new()
            {
                { "ko" = "쿠바" },
                { "pt-BR" = "Cuba" }
                { "pt" = "Cuba" }
                { "nl" = "Cuba" }
                { "hr" = "Kuba" }
                { "fa" = "کوبا" }
                { "de" = "Kuba" }
                { "es" = "Cuba" }
                { "fr" = "Cuba" }
                { "ja" = "キューバ" }
                { "it" = "Cuba" }
                { "zh-CN" = "古巴" }
                { "tr" = "Küba" }
                { "ru" = "Куба" }
                { "uk" = "Куба" }
                { "pl" = "Kuba" }
            },
            States = new()
            {

                new()
                {
                    Id = 1,
                    Name = "Artemisa",
                    StateCode = "15",
                    Latitude = "22.75229030",
                    Longitude = "-82.99316070",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Alquízar", Latitude = "22.80517000", Longitude = "-82.58392000" },
                        new() { Id = 2, Name = "Artemisa", Latitude = "22.81667000", Longitude = "-82.75944000" },
                        new() { Id = 3, Name = "Bahía Honda", Latitude = "22.90332000", Longitude = "-83.15994000" },
                        new() { Id = 4, Name = "Bauta", Latitude = "22.98226000", Longitude = "-82.54719000" },
                        new() { Id = 5, Name = "Cabañas", Latitude = "22.97944000", Longitude = "-82.92214000" },
                        new() { Id = 6, Name = "Candelaria", Latitude = "22.74057000", Longitude = "-82.95912000" },
                        new() { Id = 7, Name = "Guanajay", Latitude = "22.92639000", Longitude = "-82.68750000" },
                        new() { Id = 8, Name = "Güira de Melena", Latitude = "22.79613000", Longitude = "-82.50667000" },
                        new() { Id = 9, Name = "Mariel", Latitude = "22.98931000", Longitude = "-82.75376000" },
                        new() { Id = 10, Name = "Municipio de Artemisa", Latitude = "22.77383000", Longitude = "-82.80419000" },
                        new() { Id = 11, Name = "Municipio de Bauta", Latitude = "22.96957000", Longitude = "-82.49997000" },
                        new() { Id = 12, Name = "Municipio de Guanajay", Latitude = "22.89215000", Longitude = "-82.70873000" },
                        new() { Id = 13, Name = "Municipio de Mariel", Latitude = "22.96515000", Longitude = "-82.80324000" },
                        new() { Id = 14, Name = "Municipio de San Cristóbal", Latitude = "22.71446000", Longitude = "-83.04561000" },
                        new() { Id = 15, Name = "San Antonio de los Baños", Latitude = "22.89018000", Longitude = "-82.50099000" },
                        new() { Id = 16, Name = "San Cristobal", Latitude = "22.71658000", Longitude = "-83.05647000" },
                        new() { Id = 17, Name = "Soroa", Latitude = "22.80000000", Longitude = "-83.01667000" }
                    }
                },

                new()
                {
                    Id = 2,
                    Name = "Camagüey",
                    StateCode = "09",
                    Latitude = "21.21672470",
                    Longitude = "-77.74520810",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Camagüey", Latitude = "21.38083000", Longitude = "-77.91694000" },
                        new() { Id = 2, Name = "El Caney", Latitude = "21.30000000", Longitude = "-78.48333000" },
                        new() { Id = 3, Name = "Esmeralda", Latitude = "21.85139000", Longitude = "-78.11725000" },
                        new() { Id = 4, Name = "Florida", Latitude = "21.52536000", Longitude = "-78.22579000" },
                        new() { Id = 5, Name = "Guáimaro", Latitude = "21.05222000", Longitude = "-77.34990000" },
                        new() { Id = 6, Name = "Jimaguayú", Latitude = "21.24224000", Longitude = "-77.82625000" },
                        new() { Id = 7, Name = "Minas", Latitude = "21.48802000", Longitude = "-77.61033000" },
                        new() { Id = 8, Name = "Municipio de Florida", Latitude = "21.46582000", Longitude = "-78.34848000" },
                        new() { Id = 9, Name = "Municipio de Nuevitas", Latitude = "21.55000000", Longitude = "-77.26667000" },
                        new() { Id = 10, Name = "Nuevitas", Latitude = "21.54585000", Longitude = "-77.26504000" },
                        new() { Id = 11, Name = "Santa Cruz del Sur", Latitude = "20.71633000", Longitude = "-77.99816000" },
                        new() { Id = 12, Name = "Sibanicú", Latitude = "21.23631000", Longitude = "-77.52561000" },
                        new() { Id = 13, Name = "Vertientes", Latitude = "21.25817000", Longitude = "-78.14979000" }
                    }
                }

                new()
                {
                    Id = 3,
                    Name = "Ciego de Ávila",
                    StateCode = "08",
                    Latitude = "21.93295150",
                    Longitude = "-78.56608520",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Baraguá", Latitude = "21.68216000", Longitude = "-78.62567000" },
                        new() { Id = 2, Name = "Chambas", Latitude = "22.19534000", Longitude = "-78.91230000" },
                        new() { Id = 3, Name = "Ciego de Ávila", Latitude = "21.84000000", Longitude = "-78.76194000" },
                        new() { Id = 4, Name = "Ciro Redondo", Latitude = "22.01921000", Longitude = "-78.70365000" },
                        new() { Id = 5, Name = "Florencia", Latitude = "22.14610000", Longitude = "-78.97328000" },
                        new() { Id = 6, Name = "Morón", Latitude = "22.10774000", Longitude = "-78.62667000" },
                        new() { Id = 7, Name = "Municipio de Ciego de Ávila", Latitude = "21.85000000", Longitude = "-78.76667000" },
                        new() { Id = 8, Name = "Municipio de Morón", Latitude = "22.29980000", Longitude = "-78.56875000" },
                        new() { Id = 9, Name = "Primero de Enero", Latitude = "21.94501000", Longitude = "-78.43130000" },
                        new() { Id = 10, Name = "Venezuela", Latitude = "21.73748000", Longitude = "-78.79336000" }
                    }
                }

                new()
                {
                    Id = 4,
                    Name = "Cienfuegos",
                    StateCode = "06",
                    Latitude = "22.23797830",
                    Longitude = "-80.36586500",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Abreus", Latitude = "22.27797000", Longitude = "-80.56931000" },
                        new() { Id = 2, Name = "Aguada de Pasajeros", Latitude = "22.38520000", Longitude = "-80.84792000" },
                        new() { Id = 3, Name = "Cienfuegos", Latitude = "22.14957000", Longitude = "-80.44662000" },
                        new() { Id = 4, Name = "Cruces", Latitude = "22.34203000", Longitude = "-80.27021000" },
                        new() { Id = 5, Name = "Cumanayagua", Latitude = "22.15247000", Longitude = "-80.20354000" },
                        new() { Id = 6, Name = "Lajas", Latitude = "22.41479000", Longitude = "-80.29310000" },
                        new() { Id = 7, Name = "Municipio de Abreus", Latitude = "22.19229000", Longitude = "-80.71465000" },
                        new() { Id = 8, Name = "Municipio de Cienfuegos", Latitude = "22.15000000", Longitude = "-80.45000000" },
                        new() { Id = 9, Name = "Palmira", Latitude = "22.24126000", Longitude = "-80.39110000" },
                        new() { Id = 10, Name = "Rodas", Latitude = "22.34184000", Longitude = "-80.55596000" }
                    }
                }

                new()
                {
                    Id = 5,
                    Name = "Granma",
                    StateCode = "12",
                    Latitude = "20.38449020",
                    Longitude = "-76.64127120",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Bartolomé Masó", Latitude = "20.16635000", Longitude = "-76.94291000" },
                        new() { Id = 2, Name = "Bayamo", Latitude = "20.37417000", Longitude = "-76.64361000" },
                        new() { Id = 3, Name = "Campechuela", Latitude = "20.23329000", Longitude = "-77.27990000" },
                        new() { Id = 4, Name = "Cauto Cristo", Latitude = "20.55709000", Longitude = "-76.47270000" },
                        new() { Id = 5, Name = "Guisa", Latitude = "20.25494000", Longitude = "-76.53930000" },
                        new() { Id = 6, Name = "Jiguaní", Latitude = "20.36785000", Longitude = "-76.42741000" },
                        new() { Id = 7, Name = "Manzanillo", Latitude = "20.34173000", Longitude = "-77.12126000" },
                        new() { Id = 8, Name = "Media Luna", Latitude = "20.14298000", Longitude = "-77.43532000" },
                        new() { Id = 9, Name = "Municipio de Bayamo", Latitude = "20.42511000", Longitude = "-76.68614000" },
                        new() { Id = 10, Name = "Municipio de Manzanillo", Latitude = "20.24732000", Longitude = "-77.10273000" },
                        new() { Id = 11, Name = "Municipio de Niquero", Latitude = "19.93912000", Longitude = "-77.57085000" },
                        new() { Id = 12, Name = "Niquero", Latitude = "20.04698000", Longitude = "-77.58089000" },
                        new() { Id = 13, Name = "Río Cauto", Latitude = "20.55971000", Longitude = "-76.91673000" },
                        new() { Id = 14, Name = "Yara", Latitude = "20.27465000", Longitude = "-76.95132000" }
                    }
                }

                new()
                {
                    Id = 6,
                    Name = "Guantánamo",
                    StateCode = "14",
                    Latitude = "20.14559170",
                    Longitude = "-74.87410450",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Baracoa", Latitude = "20.34711000", Longitude = "-74.49624000" },
                        new() { Id = 2, Name = "Guantánamo", Latitude = "20.14444000", Longitude = "-75.20917000" },
                        new() { Id = 3, Name = "Maisí", Latitude = "20.24673000", Longitude = "-74.15181000" },
                        new() { Id = 4, Name = "Municipio de Guantánamo", Latitude = "20.26723000", Longitude = "-75.15546000" },
                        new() { Id = 5, Name = "Río Guayabal de Yateras", Latitude = "20.36667000", Longitude = "-75.01667000" },
                        new() { Id = 6, Name = "San Antonio del Sur", Latitude = "20.05564000", Longitude = "-74.80750000" }
                    }
                }

                new()
                {
                    Id = 7,
                    Name = "Havana",
                    StateCode = "03",
                    Latitude = "23.05406980",
                    Longitude = "-82.34518900",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Alamar", Latitude = "23.15794000", Longitude = "-82.27837000" },
                        new() { Id = 2, Name = "Arroyo Naranjo", Latitude = "23.03677000", Longitude = "-82.36937000" },
                        new() { Id = 3, Name = "Boyeros", Latitude = "23.00720000", Longitude = "-82.40170000" },
                        new() { Id = 4, Name = "Centro Habana", Latitude = "23.13833000", Longitude = "-82.36417000" },
                        new() { Id = 5, Name = "Cerro", Latitude = "23.10861000", Longitude = "-82.37778000" },
                        new() { Id = 6, Name = "Diez de Octubre", Latitude = "23.08810000", Longitude = "-82.35970000" },
                        new() { Id = 7, Name = "Guanabacoa", Latitude = "23.12360000", Longitude = "-82.30082000" },
                        new() { Id = 8, Name = "Habana del Este", Latitude = "23.15917000", Longitude = "-82.33056000" },
                        new() { Id = 9, Name = "Havana", Latitude = "23.13302000", Longitude = "-82.38304000" },
                        new() { Id = 10, Name = "La Habana Vieja", Latitude = "23.13028000", Longitude = "-82.35306000" },
                        new() { Id = 11, Name = "Regla", Latitude = "23.12500000", Longitude = "-82.33194000" },
                        new() { Id = 12, Name = "San Miguel del Padrón", Latitude = "23.06639000", Longitude = "-82.29472000" },
                        new() { Id = 13, Name = "Santiago de las Vegas", Latitude = "22.97000000", Longitude = "-82.38694000" }
                    }
                }

                new()
                {
                    Id = 8,
                    Name = "Holguín",
                    StateCode = "11",
                    Latitude = "20.78378930",
                    Longitude = "-75.80690820",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Banes", Latitude = "20.96116000", Longitude = "-75.72200000" },
                        new() { Id = 2, Name = "Cacocum", Latitude = "20.73775000", Longitude = "-76.32574000" },
                        new() { Id = 3, Name = "Cueto", Latitude = "20.64855000", Longitude = "-75.92967000" },
                        new() { Id = 4, Name = "Gibara", Latitude = "21.10988000", Longitude = "-76.13145000" },
                        new() { Id = 5, Name = "Holguín", Latitude = "20.88722000", Longitude = "-76.26306000" },
                        new() { Id = 6, Name = "Jobabo", Latitude = "20.96917000", Longitude = "-76.29944000" },
                        new() { Id = 7, Name = "Moa", Latitude = "20.65776000", Longitude = "-74.95075000" },
                        new() { Id = 8, Name = "Municipio de Banes", Latitude = "20.98008000", Longitude = "-75.74933000" },
                        new() { Id = 9, Name = "Municipio de Holguín", Latitude = "20.91192000", Longitude = "-76.27057000" },
                        new() { Id = 10, Name = "Sagua de Tánamo", Latitude = "20.58269000", Longitude = "-75.24116000" },
                        new() { Id = 11, Name = "San Germán", Latitude = "20.60009000", Longitude = "-76.13364000" }
                    }
                }

                new()
                {
                    Id = 9,
                    Name = "Isla de la Juventud",
                    StateCode = "99",
                    Latitude = "21.70847370",
                    Longitude = "-82.82202320",
                    Type = "special municipality",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Nueva Gerona", Latitude = "21.88667000", Longitude = "-82.80556000" }
                    }
                }

                new()
                {
                    Id = 10,
                    Name = "Las Tunas",
                    StateCode = "10",
                    Latitude = "21.06051620",
                    Longitude = "-76.91820970",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Amancio", Latitude = "20.81914000", Longitude = "-77.57958000" },
                        new() { Id = 2, Name = "Colombia", Latitude = "20.98812000", Longitude = "-77.42598000" },
                        new() { Id = 3, Name = "Jesús Menéndez", Latitude = "21.16139000", Longitude = "-76.47919000" },
                        new() { Id = 4, Name = "Jobabo", Latitude = "20.90748000", Longitude = "-77.28194000" },
                        new() { Id = 5, Name = "Las Tunas", Latitude = "20.96167000", Longitude = "-76.95111000" },
                        new() { Id = 6, Name = "Manatí", Latitude = "21.31070000", Longitude = "-76.93403000" },
                        new() { Id = 7, Name = "Puerto Padre", Latitude = "21.19517000", Longitude = "-76.60358000" }
                    }
                },

                new()
                {
                    Id = 11,
                    Name = "Matanzas",
                    StateCode = "04",
                    Latitude = "22.57671230",
                    Longitude = "-81.33994140",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Alacranes", Latitude = "22.76719000", Longitude = "-81.56803000" },
                        new() { Id = 2, Name = "Bolondrón", Latitude = "22.76307000", Longitude = "-81.44780000" },
                        new() { Id = 3, Name = "Calimete", Latitude = "22.53420000", Longitude = "-80.91105000" },
                        new() { Id = 4, Name = "Cárdenas", Latitude = "23.03661000", Longitude = "-81.20596000" },
                        new() { Id = 5, Name = "Colón", Latitude = "22.72064000", Longitude = "-80.90492000" },
                        new() { Id = 6, Name = "Jagüey Grande", Latitude = "22.52694000", Longitude = "-81.12861000" },
                        new() { Id = 7, Name = "Jovellanos", Latitude = "22.80375000", Longitude = "-81.19127000" },
                        new() { Id = 8, Name = "Limonar", Latitude = "22.95035000", Longitude = "-81.41059000" },
                        new() { Id = 9, Name = "Los Arabos", Latitude = "22.72969000", Longitude = "-80.72081000" },
                        new() { Id = 10, Name = "Manguito", Latitude = "22.58733000", Longitude = "-80.91451000" },
                        new() { Id = 11, Name = "Martí", Latitude = "22.94714000", Longitude = "-80.91902000" },
                        new() { Id = 12, Name = "Matanzas", Latitude = "23.04111000", Longitude = "-81.57750000" },
                        new() { Id = 13, Name = "Municipio de Cárdenas", Latitude = "22.98978000", Longitude = "-81.23520000" },
                        new() { Id = 14, Name = "Municipio de Matanzas", Latitude = "23.05000000", Longitude = "-81.58333000" },
                        new() { Id = 15, Name = "Pedro Betancourt", Latitude = "22.72709000", Longitude = "-81.28963000" },
                        new() { Id = 16, Name = "Perico", Latitude = "22.76987000", Longitude = "-81.01830000" },
                        new() { Id = 17, Name = "Unión de Reyes", Latitude = "22.79505000", Longitude = "-81.53617000" },
                        new() { Id = 18, Name = "Varadero", Latitude = "23.15678000", Longitude = "-81.24441000" }
                    }
                },

                new()
                {
                    Id = 12,
                    Name = "Mayabeque",
                    StateCode = "16",
                    Latitude = "22.89265290",
                    Longitude = "-81.95348150",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Batabanó", Latitude = "22.71794000", Longitude = "-82.28965000" },
                        new() { Id = 2, Name = "Bejucal", Latitude = "22.92861000", Longitude = "-82.38861000" },
                        new() { Id = 3, Name = "Güines", Latitude = "22.83727000", Longitude = "-82.02641000" },
                        new() { Id = 4, Name = "Jamaica", Latitude = "22.97559000", Longitude = "-82.16852000" },
                        new() { Id = 5, Name = "Jaruco", Latitude = "23.04419000", Longitude = "-82.00919000" },
                        new() { Id = 6, Name = "La Salud", Latitude = "22.87199000", Longitude = "-82.42328000" },
                        new() { Id = 7, Name = "Madruga", Latitude = "22.91000000", Longitude = "-81.85639000" },
                        new() { Id = 8, Name = "Municipio de Güines", Latitude = "22.78712000", Longitude = "-82.01602000" },
                        new() { Id = 9, Name = "Municipio de Melena del Sur", Latitude = "22.78821000", Longitude = "-82.15113000" },
                        new() { Id = 10, Name = "Quivicán", Latitude = "22.82313000", Longitude = "-82.35558000" },
                        new() { Id = 11, Name = "San José de las Lajas", Latitude = "22.96139000", Longitude = "-82.15111000" },
                        new() { Id = 12, Name = "San Nicolás de Bari", Latitude = "22.78444000", Longitude = "-81.91333000" },
                        new() { Id = 13, Name = "Santa Cruz del Norte", Latitude = "23.15424000", Longitude = "-81.92556000" }
                    }
                },

                new()
                {
                    Id = 13,
                    Name = "Pinar del Río",
                    StateCode = "01",
                    Latitude = "22.40762560",
                    Longitude = "-83.84730150",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Consolación del Sur", Latitude = "22.50419000", Longitude = "-83.51442000" },
                        new() { Id = 2, Name = "Guane", Latitude = "22.20179000", Longitude = "-84.08484000" },
                        new() { Id = 3, Name = "Los Palacios", Latitude = "22.58882000", Longitude = "-83.24671000" },
                        new() { Id = 4, Name = "Mantua", Latitude = "22.29058000", Longitude = "-84.28599000" },
                        new() { Id = 5, Name = "Minas de Matahambre", Latitude = "22.58691000", Longitude = "-83.94551000" },
                        new() { Id = 6, Name = "Municipio de Consolación del Sur", Latitude = "22.44095000", Longitude = "-83.41985000" },
                        new() { Id = 7, Name = "Municipio de Guane", Latitude = "22.24591000", Longitude = "-84.03660000" },
                        new() { Id = 8, Name = "Municipio de La Palma", Latitude = "22.75000000", Longitude = "-83.55000000" },
                        new() { Id = 9, Name = "Municipio de Los Palacios", Latitude = "22.58333000", Longitude = "-83.25000000" },
                        new() { Id = 10, Name = "Pinar del Río", Latitude = "22.41667000", Longitude = "-83.69667000" },
                        new() { Id = 11, Name = "Puerto Esperanza", Latitude = "22.77041000", Longitude = "-83.73138000" },
                        new() { Id = 12, Name = "San Diego de Los Baños", Latitude = "22.64667000", Longitude = "-83.36972000" },
                        new() { Id = 13, Name = "San Luis", Latitude = "22.27898000", Longitude = "-83.75956000" },
                        new() { Id = 14, Name = "Viñales", Latitude = "22.61892000", Longitude = "-83.70694000" }
                    }
                },

                new()
                {
                    Id = 14,
                    Name = "Sancti Spíritus",
                    StateCode = "07",
                    Latitude = "21.99382140",
                    Longitude = "-79.47038850",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Cabaiguán", Latitude = "22.07874000", Longitude = "-79.49726000" },
                        new() { Id = 2, Name = "Condado", Latitude = "21.87670000", Longitude = "-79.84014000" },
                        new() { Id = 3, Name = "Fomento", Latitude = "22.10475000", Longitude = "-79.72141000" },
                        new() { Id = 4, Name = "Guayos", Latitude = "22.04956000", Longitude = "-79.46106000" },
                        new() { Id = 5, Name = "Jatibonico", Latitude = "21.94333000", Longitude = "-79.16906000" },
                        new() { Id = 6, Name = "La Sierpe", Latitude = "21.77241000", Longitude = "-79.26832000" },
                        new() { Id = 7, Name = "Municipio de Cabaiguán", Latitude = "22.08333000", Longitude = "-79.50000000" },
                        new() { Id = 8, Name = "Municipio de Jatibonico", Latitude = "21.93333000", Longitude = "-79.16667000" },
                        new() { Id = 9, Name = "Municipio de Sancti Spíritus", Latitude = "21.82176000", Longitude = "-79.51036000" },
                        new() { Id = 10, Name = "Municipio de Trinidad", Latitude = "21.83195000", Longitude = "-79.88362000" },
                        new() { Id = 11, Name = "Sancti Spíritus", Latitude = "21.92972000", Longitude = "-79.44250000" },
                        new() { Id = 12, Name = "Topes de Collantes", Latitude = "21.91524000", Longitude = "-80.01929000" },
                        new() { Id = 13, Name = "Trinidad", Latitude = "21.80224000", Longitude = "-79.98467000" },
                        new() { Id = 14, Name = "Yaguajay", Latitude = "22.32691000", Longitude = "-79.23567000" },
                        new() { Id = 15, Name = "Zaza del Medio", Latitude = "21.99712000", Longitude = "-79.36678000" }
                    }
                },

                new()
                {
                    Id = 15,
                    Name = "Santiago de Cuba",
                    StateCode = "13",
                    Latitude = "20.23976820",
                    Longitude = "-75.99276520",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Contramaestre", Latitude = "20.29879000", Longitude = "-76.24511000" },
                        new() { Id = 2, Name = "El Cobre", Latitude = "20.04850000", Longitude = "-75.94579000" },
                        new() { Id = 3, Name = "Municipio de Palma Soriano", Latitude = "20.20897000", Longitude = "-76.05776000" },
                        new() { Id = 4, Name = "Municipio de Santiago de Cuba", Latitude = "20.00617000", Longitude = "-75.70816000" },
                        new() { Id = 5, Name = "Palma Soriano", Latitude = "20.21130000", Longitude = "-75.99362000" },
                        new() { Id = 6, Name = "San Luis", Latitude = "20.18809000", Longitude = "-75.85031000" },
                        new() { Id = 7, Name = "Santiago de Cuba", Latitude = "20.02083000", Longitude = "-75.82667000" }
                    }
                },

                new()
                {
                    Id = 16,
                    Name = "Villa Clara",
                    StateCode = "05",
                    Latitude = "22.49372040",
                    Longitude = "-79.91927020",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Caibarién", Latitude = "22.51996000", Longitude = "-79.46599000" },
                        new() { Id = 2, Name = "Calabazar de Sagua", Latitude = "22.64515000", Longitude = "-79.89510000" },
                        new() { Id = 3, Name = "Camajuaní", Latitude = "22.48333000", Longitude = "-79.75000000" },
                        new() { Id = 4, Name = "Cifuentes", Latitude = "22.64930000", Longitude = "-80.04935000" },
                        new() { Id = 5, Name = "Corralillo", Latitude = "22.98212000", Longitude = "-80.58556000" },
                        new() { Id = 6, Name = "Encrucijada", Latitude = "22.61802000", Longitude = "-79.86603000" },
                        new() { Id = 7, Name = "Esperanza", Latitude = "22.44680000", Longitude = "-80.09711000" },
                        new() { Id = 8, Name = "Isabela de Sagua", Latitude = "22.93924000", Longitude = "-80.01185000" },
                        new() { Id = 9, Name = "Manicaragua", Latitude = "22.15021000", Longitude = "-79.97867000" },
                        new() { Id = 10, Name = "Municipio de Placetas", Latitude = "22.22248000", Longitude = "-79.74268000" },
                        new() { Id = 11, Name = "Municipio de Santa Clara", Latitude = "22.40000000", Longitude = "-79.96667000" },
                        new() { Id = 12, Name = "Placetas", Latitude = "22.31184000", Longitude = "-79.65440000" },
                        new() { Id = 13, Name = "Quemado de Güines", Latitude = "22.78816000", Longitude = "-80.25226000" },
                        new() { Id = 14, Name = "Rancho Veloz", Latitude = "22.88042000", Longitude = "-80.39098000" },
                        new() { Id = 15, Name = "Ranchuelo", Latitude = "22.37266000", Longitude = "-80.15046000" },
                        new() { Id = 16, Name = "Sagua la Grande", Latitude = "22.80667000", Longitude = "-80.07556000" },
                        new() { Id = 17, Name = "Santa Clara", Latitude = "22.40694000", Longitude = "-79.96472000" },
                        new() { Id = 18, Name = "Santo Domingo", Latitude = "22.58677000", Longitude = "-80.24261000" }
                    }
                }
            }
        };
    }
}
