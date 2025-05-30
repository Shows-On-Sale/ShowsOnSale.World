// ⚠️ WARNING: This file is automatically generated by scripts/generate-world.ps1
// DO NOT modify this file manually as it will be overwritten when the script is run again.
// To update the data, modify the source data in countries-states-cities-database and run the script.

using System.Collections.Generic;
using ShowsOnSale.World.Models;

namespace ShowsOnSale.World.Data.Countries
{
    public static class CostaRica
    {
        public static Country Data { get; } = new()
        {
            Id = 52,
            Name = "Costa Rica",
            Iso3 = "CRI",
            Iso2 = "CR",
            NumericCode = "188",
            PhoneCode = "506",
            Capital = "San Jose",
            Currency = "CRC",
            CurrencyName = "Costa Rican colón",
            CurrencySymbol = "₡",
            Tld = ".cr",
            Native = "Costa Rica",
            Region = "Americas",
            RegionId = 2,
            Subregion = "Central America",
            SubregionId = 9,
            Nationality = "Costa Rican",
            Latitude = "10.00000000",
            Longitude = "-84.00000000",
            Emoji = "🇨🇷",
            EmojiU = "U+1F1E8 U+1F1F7",
            Timezones = new()
            {
                new() { ZoneName = "America/Costa_Rica", GmtOffset = -21600, GmtOffsetName = "UTC-06:00", Abbreviation = "CST", TzName = "Central Standard Time (North America" }
            },
            Translations = new()
            {
                ["ko"] = "코스타리카",
                ["pt-BR"] = "Costa Rica",
                ["pt"] = "Costa Rica",
                ["nl"] = "Costa Rica",
                ["hr"] = "Kostarika",
                ["fa"] = "کاستاریکا",
                ["de"] = "Costa Rica",
                ["es"] = "Costa Rica",
                ["fr"] = "Costa Rica",
                ["ja"] = "コスタリカ",
                ["it"] = "Costa Rica",
                ["zh-CN"] = "哥斯达黎加",
                ["tr"] = "Kosta Rika",
                ["ru"] = "Коста-Рика",
                ["uk"] = "Коста-Ріка",
                ["pl"] = "Kostaryka"
            },
            States = new()
            {

                new()
                {
                    Id = 1,
                    Name = "Alajuela",
                    StateCode = "A",
                    Latitude = "10.39158300",
                    Longitude = "-84.43827210",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Alajuela", Latitude = "10.01625000", Longitude = "-84.21163000" },
                        new() { Id = 2, Name = "Atenas", Latitude = "9.98333000", Longitude = "-84.38333000" },
                        new() { Id = 3, Name = "Bijagua", Latitude = "10.73279000", Longitude = "-85.05676000" },
                        new() { Id = 4, Name = "Carrillos", Latitude = "10.02918000", Longitude = "-84.27403000" },
                        new() { Id = 5, Name = "Desamparados", Latitude = "9.94727000", Longitude = "-84.50626000" },
                        new() { Id = 6, Name = "Esquipulas", Latitude = "10.05676000", Longitude = "-84.42337000" },
                        new() { Id = 7, Name = "Grecia", Latitude = "10.06892000", Longitude = "-84.31458000" },
                        new() { Id = 8, Name = "Guatuso", Latitude = "10.66667000", Longitude = "-84.83333000" },
                        new() { Id = 9, Name = "La Fortuna", Latitude = "10.47089000", Longitude = "-84.64535000" },
                        new() { Id = 10, Name = "Los Chiles", Latitude = "10.86667000", Longitude = "-84.66667000" },
                        new() { Id = 11, Name = "Naranjo", Latitude = "10.11667000", Longitude = "-84.40000000" },
                        new() { Id = 12, Name = "Orotina", Latitude = "9.90000000", Longitude = "-84.56667000" },
                        new() { Id = 13, Name = "Palmares", Latitude = "10.03333000", Longitude = "-84.43333000" },
                        new() { Id = 14, Name = "Pital", Latitude = "10.45056000", Longitude = "-84.27406000" },
                        new() { Id = 15, Name = "Poás", Latitude = "10.08333000", Longitude = "-84.23333000" },
                        new() { Id = 16, Name = "Pocosol", Latitude = "10.36667000", Longitude = "-84.61667000" },
                        new() { Id = 17, Name = "Quesada", Latitude = "10.32381000", Longitude = "-84.42714000" },
                        new() { Id = 18, Name = "Río Segundo", Latitude = "10.24138000", Longitude = "-84.27933000" },
                        new() { Id = 19, Name = "Sabanilla", Latitude = "10.07404000", Longitude = "-84.21551000" },
                        new() { Id = 20, Name = "San Carlos", Latitude = "10.58333000", Longitude = "-84.41667000" },
                        new() { Id = 21, Name = "San José", Latitude = "10.95173000", Longitude = "-85.13610000" },
                        new() { Id = 22, Name = "San Juan", Latitude = "10.10248000", Longitude = "-84.31694000" },
                        new() { Id = 23, Name = "San Mateo", Latitude = "9.95000000", Longitude = "-84.51667000" },
                        new() { Id = 24, Name = "San Rafael", Latitude = "10.06403000", Longitude = "-84.47281000" },
                        new() { Id = 25, Name = "San Ramón", Latitude = "10.08718000", Longitude = "-84.47044000" },
                        new() { Id = 26, Name = "Santiago", Latitude = "10.02275000", Longitude = "-84.44420000" },
                        new() { Id = 27, Name = "Upala", Latitude = "10.85000000", Longitude = "-85.16667000" },
                        new() { Id = 28, Name = "Valverde Vega", Latitude = "10.18721000", Longitude = "-84.30290000" },
                        new() { Id = 29, Name = "Zarcero", Latitude = "10.20000000", Longitude = "-84.40000000" }
                    }
                },

                new()
                {
                    Id = 2,
                    Name = "Cartago",
                    StateCode = "C",
                    Latitude = "9.86223110",
                    Longitude = "-83.92141870",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Alvarado", Latitude = "9.93333000", Longitude = "-83.80000000" },
                        new() { Id = 2, Name = "Cartago", Latitude = "9.86444000", Longitude = "-83.91944000" },
                        new() { Id = 3, Name = "Concepción", Latitude = "9.93333000", Longitude = "-84.00000000" },
                        new() { Id = 4, Name = "Cot", Latitude = "9.89449000", Longitude = "-83.87302000" },
                        new() { Id = 5, Name = "El Guarco", Latitude = "9.75000000", Longitude = "-83.91667000" },
                        new() { Id = 6, Name = "Jiménez", Latitude = "9.75000000", Longitude = "-83.68333000" },
                        new() { Id = 7, Name = "La Suiza", Latitude = "9.85065000", Longitude = "-83.61690000" },
                        new() { Id = 8, Name = "La Unión", Latitude = "9.91667000", Longitude = "-83.98333000" },
                        new() { Id = 9, Name = "Oreamuno", Latitude = "10.00000000", Longitude = "-83.83333000" },
                        new() { Id = 10, Name = "Orosí", Latitude = "9.79617000", Longitude = "-83.85383000" },
                        new() { Id = 11, Name = "Pacayas", Latitude = "9.80709000", Longitude = "-84.04764000" },
                        new() { Id = 12, Name = "Paraíso", Latitude = "9.75000000", Longitude = "-83.80000000" },
                        new() { Id = 13, Name = "Pejibaye", Latitude = "9.81135000", Longitude = "-83.70336000" },
                        new() { Id = 14, Name = "San Diego", Latitude = "9.89898000", Longitude = "-84.00287000" },
                        new() { Id = 15, Name = "Tobosi", Latitude = "9.83837000", Longitude = "-83.98391000" },
                        new() { Id = 16, Name = "Tres Ríos", Latitude = "9.90644000", Longitude = "-83.98760000" },
                        new() { Id = 17, Name = "Tucurrique", Latitude = "9.85336000", Longitude = "-83.72273000" },
                        new() { Id = 18, Name = "Turrialba", Latitude = "9.80000000", Longitude = "-83.53333000" }
                    }
                },

                new()
                {
                    Id = 3,
                    Name = "Guanacaste",
                    StateCode = "G",
                    Latitude = "10.62673990",
                    Longitude = "-85.44367060",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Abangares", Latitude = "10.21667000", Longitude = "-85.00000000" },
                        new() { Id = 2, Name = "Bagaces", Latitude = "10.50000000", Longitude = "-85.25000000" },
                        new() { Id = 3, Name = "Belén", Latitude = "10.40789000", Longitude = "-85.58836000" },
                        new() { Id = 4, Name = "Cañas", Latitude = "10.48005000", Longitude = "-85.11349000" },
                        new() { Id = 5, Name = "Carrillo", Latitude = "10.41667000", Longitude = "-85.58333000" },
                        new() { Id = 6, Name = "Fortuna", Latitude = "10.67384000", Longitude = "-85.19984000" },
                        new() { Id = 7, Name = "Hojancha", Latitude = "9.96667000", Longitude = "-85.41667000" },
                        new() { Id = 8, Name = "Juntas", Latitude = "10.28089000", Longitude = "-84.95951000" },
                        new() { Id = 9, Name = "La Cruz", Latitude = "11.00000000", Longitude = "-85.58333000" },
                        new() { Id = 10, Name = "Liberia", Latitude = "10.63504000", Longitude = "-85.43772000" },
                        new() { Id = 11, Name = "Nandayure", Latitude = "9.91667000", Longitude = "-85.28333000" },
                        new() { Id = 12, Name = "Nicoya", Latitude = "10.08333000", Longitude = "-85.50000000" },
                        new() { Id = 13, Name = "Sámara", Latitude = "9.88147000", Longitude = "-85.52809000" },
                        new() { Id = 14, Name = "Santa Cruz", Latitude = "10.25000000", Longitude = "-85.66667000" },
                        new() { Id = 15, Name = "Sardinal", Latitude = "10.51674000", Longitude = "-85.64748000" },
                        new() { Id = 16, Name = "Tilarán", Latitude = "10.45878000", Longitude = "-84.97513000" }
                    }
                },

                new()
                {
                    Id = 4,
                    Name = "Heredia",
                    StateCode = "H",
                    Latitude = "10.47352300",
                    Longitude = "-84.01674230",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Ángeles", Latitude = "9.99591000", Longitude = "-84.05126000" },
                        new() { Id = 2, Name = "Barva", Latitude = "10.08333000", Longitude = "-84.10000000" },
                        new() { Id = 3, Name = "Belén", Latitude = "9.98333000", Longitude = "-84.16667000" },
                        new() { Id = 4, Name = "Flores", Latitude = "10.00000000", Longitude = "-84.15000000" },
                        new() { Id = 5, Name = "Heredia", Latitude = "10.00236000", Longitude = "-84.11651000" },
                        new() { Id = 6, Name = "La Asunción", Latitude = "9.97961000", Longitude = "-84.17281000" },
                        new() { Id = 7, Name = "Llorente", Latitude = "9.99844000", Longitude = "-84.15448000" },
                        new() { Id = 8, Name = "Mercedes", Latitude = "10.00695000", Longitude = "-84.13396000" },
                        new() { Id = 9, Name = "San Antonio", Latitude = "9.98333000", Longitude = "-84.18333000" },
                        new() { Id = 10, Name = "San Francisco", Latitude = "9.99299000", Longitude = "-84.12934000" },
                        new() { Id = 11, Name = "San Isidro", Latitude = "10.03333000", Longitude = "-84.03333000" },
                        new() { Id = 12, Name = "San Josecito", Latitude = "10.01667000", Longitude = "-84.10000000" },
                        new() { Id = 13, Name = "San Pablo", Latitude = "10.00000000", Longitude = "-84.08333000" },
                        new() { Id = 14, Name = "San Rafael", Latitude = "10.05000000", Longitude = "-84.06667000" },
                        new() { Id = 15, Name = "Santa Bárbara", Latitude = "10.08333000", Longitude = "-84.15000000" },
                        new() { Id = 16, Name = "Santo Domingo", Latitude = "10.06389000", Longitude = "-84.15499000" },
                        new() { Id = 17, Name = "Sarapiquí", Latitude = "10.50000000", Longitude = "-84.00000000" }
                    }
                },

                new()
                {
                    Id = 5,
                    Name = "Limón",
                    StateCode = "L",
                    Latitude = "9.98963980",
                    Longitude = "-83.03324170",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Batán", Latitude = "10.08354000", Longitude = "-83.33413000" },
                        new() { Id = 2, Name = "Guácimo", Latitude = "10.20000000", Longitude = "-83.66667000" },
                        new() { Id = 3, Name = "Guápiles", Latitude = "10.21682000", Longitude = "-83.78483000" },
                        new() { Id = 4, Name = "Limón", Latitude = "9.99074000", Longitude = "-83.03596000" },
                        new() { Id = 5, Name = "Matina", Latitude = "10.00000000", Longitude = "-83.25000000" },
                        new() { Id = 6, Name = "Pococí", Latitude = "10.50000000", Longitude = "-83.63333000" },
                        new() { Id = 7, Name = "Pocora", Latitude = "10.17185000", Longitude = "-83.60439000" },
                        new() { Id = 8, Name = "Roxana", Latitude = "10.26712000", Longitude = "-83.75110000" },
                        new() { Id = 9, Name = "Siquirres", Latitude = "10.11667000", Longitude = "-83.50000000" },
                        new() { Id = 10, Name = "Sixaola", Latitude = "9.52766000", Longitude = "-82.62185000" },
                        new() { Id = 11, Name = "Talamanca", Latitude = "9.50000000", Longitude = "-83.08333000" }
                    }
                },

                new()
                {
                    Id = 6,
                    Name = "Puntarenas",
                    StateCode = "P",
                    Latitude = "9.21695310",
                    Longitude = "-83.33618800",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Buenos Aires", Latitude = "9.11667000", Longitude = "-83.25000000" },
                        new() { Id = 2, Name = "Canoas", Latitude = "8.53305000", Longitude = "-82.83844000" },
                        new() { Id = 3, Name = "Chacarita", Latitude = "9.98424000", Longitude = "-84.77892000" },
                        new() { Id = 4, Name = "Ciudad Cortés", Latitude = "8.95988000", Longitude = "-83.52381000" },
                        new() { Id = 5, Name = "Corredor", Latitude = "8.64002000", Longitude = "-82.94600000" },
                        new() { Id = 6, Name = "Corredores", Latitude = "8.58333000", Longitude = "-82.91667000" },
                        new() { Id = 7, Name = "Coto Brus", Latitude = "8.88333000", Longitude = "-82.96667000" },
                        new() { Id = 8, Name = "Esparza", Latitude = "10.00000000", Longitude = "-84.66667000" },
                        new() { Id = 9, Name = "Garabito", Latitude = "9.61903000", Longitude = "-84.62013000" },
                        new() { Id = 10, Name = "Golfito", Latitude = "8.60000000", Longitude = "-83.12000000" },
                        new() { Id = 11, Name = "Jacó", Latitude = "9.61497000", Longitude = "-84.62975000" },
                        new() { Id = 12, Name = "Miramar", Latitude = "10.09250000", Longitude = "-84.72978000" },
                        new() { Id = 13, Name = "Montes de Oro", Latitude = "10.10000000", Longitude = "-84.75000000" },
                        new() { Id = 14, Name = "Osa", Latitude = "8.83333000", Longitude = "-83.50000000" },
                        new() { Id = 15, Name = "Paquera", Latitude = "9.82005000", Longitude = "-84.93513000" },
                        new() { Id = 16, Name = "Parrita", Latitude = "9.55000000", Longitude = "-84.33333000" },
                        new() { Id = 17, Name = "Puntarenas", Latitude = "9.97625000", Longitude = "-84.83836000" },
                        new() { Id = 18, Name = "Quepos", Latitude = "9.43187000", Longitude = "-84.16141000" },
                        new() { Id = 19, Name = "San Vito", Latitude = "8.82079000", Longitude = "-82.97092000" }
                    }
                },

                new()
                {
                    Id = 7,
                    Name = "San José",
                    StateCode = "SJ",
                    Latitude = "9.91297270",
                    Longitude = "-84.07682940",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Acosta", Latitude = "9.80000000", Longitude = "-84.20000000" },
                        new() { Id = 2, Name = "Alajuelita", Latitude = "9.90000000", Longitude = "-84.10000000" },
                        new() { Id = 3, Name = "Aserrí", Latitude = "9.86667000", Longitude = "-84.10000000" },
                        new() { Id = 4, Name = "Calle Blancos", Latitude = "9.95000000", Longitude = "-84.06667000" },
                        new() { Id = 5, Name = "Colima", Latitude = "9.95091000", Longitude = "-84.08503000" },
                        new() { Id = 6, Name = "Colón", Latitude = "9.91491000", Longitude = "-84.24170000" },
                        new() { Id = 7, Name = "Curridabat", Latitude = "9.91667000", Longitude = "-84.03333000" },
                        new() { Id = 8, Name = "Daniel Flores", Latitude = "9.33554000", Longitude = "-83.66940000" },
                        new() { Id = 9, Name = "Desamparados", Latitude = "9.90000000", Longitude = "-84.06667000" },
                        new() { Id = 10, Name = "Dota", Latitude = "9.65000000", Longitude = "-83.95000000" },
                        new() { Id = 11, Name = "Escazú", Latitude = "9.93333000", Longitude = "-84.13333000" },
                        new() { Id = 12, Name = "Goicoechea", Latitude = "9.94848000", Longitude = "-84.06365000" },
                        new() { Id = 13, Name = "Granadilla", Latitude = "9.93491000", Longitude = "-84.01688000" },
                        new() { Id = 14, Name = "Guadalupe", Latitude = "9.94805000", Longitude = "-84.05665000" },
                        new() { Id = 15, Name = "Ipís", Latitude = "9.96745000", Longitude = "-84.01326000" },
                        new() { Id = 16, Name = "León Cortés", Latitude = "9.68300000", Longitude = "-84.04781000" },
                        new() { Id = 17, Name = "Mercedes", Latitude = "9.26270000", Longitude = "-83.58202000" },
                        new() { Id = 18, Name = "Montes de Oca", Latitude = "9.93960000", Longitude = "-84.03013000" },
                        new() { Id = 19, Name = "Mora", Latitude = "9.91667000", Longitude = "-84.25000000" },
                        new() { Id = 20, Name = "Moravia", Latitude = "10.04000000", Longitude = "-84.00000000" },
                        new() { Id = 21, Name = "Palmichal", Latitude = "9.83778000", Longitude = "-84.20478000" },
                        new() { Id = 22, Name = "Patarrá", Latitude = "9.88071000", Longitude = "-84.03501000" },
                        new() { Id = 23, Name = "Pérez Zeledón", Latitude = "9.35473000", Longitude = "-83.63484000" },
                        new() { Id = 24, Name = "Puriscal", Latitude = "9.75000000", Longitude = "-84.41667000" },
                        new() { Id = 25, Name = "Purral", Latitude = "9.95808000", Longitude = "-84.03050000" },
                        new() { Id = 26, Name = "Sabanilla", Latitude = "9.94522000", Longitude = "-84.03927000" },
                        new() { Id = 27, Name = "Salitral", Latitude = "9.91163000", Longitude = "-84.17835000" },
                        new() { Id = 28, Name = "Salitrillos", Latitude = "9.85259000", Longitude = "-84.09062000" },
                        new() { Id = 29, Name = "San Felipe", Latitude = "9.90488000", Longitude = "-84.10551000" },
                        new() { Id = 30, Name = "San Ignacio", Latitude = "9.79853000", Longitude = "-84.16173000" },
                        new() { Id = 31, Name = "San Isidro", Latitude = "9.36740000", Longitude = "-83.69713000" },
                        new() { Id = 32, Name = "San José", Latitude = "9.93333000", Longitude = "-84.08333000" },
                        new() { Id = 33, Name = "San Juan", Latitude = "9.95974000", Longitude = "-84.08165000" },
                        new() { Id = 34, Name = "San Juan de Dios", Latitude = "9.87730000", Longitude = "-84.08470000" },
                        new() { Id = 35, Name = "San Marcos", Latitude = "9.66010000", Longitude = "-84.02026000" },
                        new() { Id = 36, Name = "San Miguel", Latitude = "9.87121000", Longitude = "-84.06084000" },
                        new() { Id = 37, Name = "San Pedro", Latitude = "9.92829000", Longitude = "-84.05074000" },
                        new() { Id = 38, Name = "San Rafael", Latitude = "9.92787000", Longitude = "-84.13722000" },
                        new() { Id = 39, Name = "San Rafael Abajo", Latitude = "9.83100000", Longitude = "-84.29008000" },
                        new() { Id = 40, Name = "San Rafael Arriba", Latitude = "9.87556000", Longitude = "-84.07661000" },
                        new() { Id = 41, Name = "San Vicente", Latitude = "9.96016000", Longitude = "-84.04762000" },
                        new() { Id = 42, Name = "San Vicente de Moravia", Latitude = "9.96164000", Longitude = "-84.04880000" },
                        new() { Id = 43, Name = "Santa Ana", Latitude = "9.93260000", Longitude = "-84.18255000" },
                        new() { Id = 44, Name = "Santiago", Latitude = "9.84636000", Longitude = "-84.31428000" },
                        new() { Id = 45, Name = "Tarrazú", Latitude = "9.65965000", Longitude = "-84.02138000" },
                        new() { Id = 46, Name = "Tejar", Latitude = "9.74622000", Longitude = "-84.23368000" },
                        new() { Id = 47, Name = "Tibás", Latitude = "9.96667000", Longitude = "-84.08333000" },
                        new() { Id = 48, Name = "Turrubares", Latitude = "9.75000000", Longitude = "-84.50000000" },
                        new() { Id = 49, Name = "Vázquez de Coronado", Latitude = "10.06000000", Longitude = "-84.00000000" }
                    }
                }
            }
        };
    }
}
