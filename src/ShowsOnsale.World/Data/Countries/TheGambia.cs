// ⚠️ WARNING: This file is automatically generated by scripts/generate-world.ps1
// DO NOT modify this file manually as it will be overwritten when the script is run again.
// To update the data, modify the source data in countries-states-cities-database and run the script.

using System.Collections.Generic;
using ShowsOnSale.World.Models;

namespace ShowsOnSale.World.Data.Countries
{
    public static class TheGambia
    {
        public static Country Data { get; } = new()
        {
            Id = 221,
            Name = "The Gambia ",
            Iso3 = "GMB",
            Iso2 = "GM",
            NumericCode = "270",
            PhoneCode = "220",
            Capital = "Banjul",
            Currency = "GMD",
            CurrencyName = "Gambian dalasi",
            CurrencySymbol = "D",
            Tld = ".gm",
            Native = "Gambia",
            Region = "Africa",
            RegionId = 1,
            Subregion = "Western Africa",
            SubregionId = 3,
            Nationality = "Gambian",
            Latitude = "13.46666666",
            Longitude = "-16.56666666",
            Emoji = "🇬🇲",
            EmojiU = "U+1F1EC U+1F1F2",
            Timezones = new()
            {
                new() { ZoneName = "Africa/Banjul", GmtOffset = 0, GmtOffsetName = "UTC±00", Abbreviation = "GMT", TzName = "Greenwich Mean Time" }
            },
            Translations = new()
            {
                { "ko" = "감비아" },
                { "pt-BR" = "Gâmbia" }
                { "pt" = "Gâmbia" }
                { "nl" = "Gambia" }
                { "hr" = "Gambija" }
                { "fa" = "گامبیا" }
                { "de" = "Gambia" }
                { "es" = "Gambia" }
                { "fr" = "Gambie" }
                { "ja" = "ガンビア" }
                { "it" = "Gambia" }
                { "zh-CN" = "冈比亚" }
                { "tr" = "Gambiya" }
                { "ru" = "Гамбия" }
                { "uk" = "Гамбія The" }
                { "pl" = "Gambia The" }
            },
            States = new()
            {

                new()
                {
                    Id = 1,
                    Name = "Banjul",
                    StateCode = "B",
                    Latitude = "13.45487610",
                    Longitude = "-16.57903230",
                    Type = "city",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Bakau", Latitude = "13.47806000", Longitude = "-16.68194000" },
                        new() { Id = 2, Name = "Banjul", Latitude = "13.45274000", Longitude = "-16.57803000" },
                        new() { Id = 3, Name = "Kombo Saint Mary District", Latitude = "13.44389000", Longitude = "-16.64583000" },
                        new() { Id = 4, Name = "Serekunda", Latitude = "13.43833000", Longitude = "-16.67806000" }
                    }
                },

                new()
                {
                    Id = 2,
                    Name = "Central River",
                    StateCode = "M",
                    Latitude = "13.59944690",
                    Longitude = "-14.89216680",
                    Type = "division",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Bansang", Latitude = "13.43333000", Longitude = "-14.65000000" },
                        new() { Id = 2, Name = "Brikama Nding", Latitude = "13.53333000", Longitude = "-14.93333000" },
                        new() { Id = 3, Name = "Dankunku", Latitude = "13.56667000", Longitude = "-15.31667000" },
                        new() { Id = 4, Name = "Denton", Latitude = "13.50000000", Longitude = "-14.93333000" },
                        new() { Id = 5, Name = "Fulladu West", Latitude = "13.50000000", Longitude = "-14.75000000" },
                        new() { Id = 6, Name = "Galleh Manda", Latitude = "13.43333000", Longitude = "-14.78333000" },
                        new() { Id = 7, Name = "Georgetown", Latitude = "13.54039000", Longitude = "-14.76374000" },
                        new() { Id = 8, Name = "Jakhaly", Latitude = "13.55000000", Longitude = "-14.96667000" },
                        new() { Id = 9, Name = "Janjanbureh", Latitude = "13.53564000", Longitude = "-14.76515000" },
                        new() { Id = 10, Name = "Jarreng", Latitude = "13.61667000", Longitude = "-15.18333000" },
                        new() { Id = 11, Name = "Karantaba", Latitude = "13.66667000", Longitude = "-15.03333000" },
                        new() { Id = 12, Name = "Kass Wollof", Latitude = "13.78333000", Longitude = "-14.93333000" },
                        new() { Id = 13, Name = "Kuntaur", Latitude = "13.67085000", Longitude = "-14.88977000" },
                        new() { Id = 14, Name = "Kunting", Latitude = "13.53333000", Longitude = "-14.66667000" },
                        new() { Id = 15, Name = "Lower Saloum", Latitude = "13.71667000", Longitude = "-15.36667000" },
                        new() { Id = 16, Name = "Niamina East District", Latitude = "13.63333000", Longitude = "-15.08333000" },
                        new() { Id = 17, Name = "Niamina West District", Latitude = "13.58333000", Longitude = "-15.25000000" },
                        new() { Id = 18, Name = "Niani", Latitude = "13.66667000", Longitude = "-14.91667000" },
                        new() { Id = 19, Name = "Nianija District", Latitude = "13.72900000", Longitude = "-15.09100000" },
                        new() { Id = 20, Name = "Pateh Sam", Latitude = "13.61667000", Longitude = "-15.06667000" },
                        new() { Id = 21, Name = "Sami", Latitude = "13.58333000", Longitude = "-15.20000000" },
                        new() { Id = 22, Name = "Sami District", Latitude = "13.58333000", Longitude = "-14.58333000" },
                        new() { Id = 23, Name = "Saruja", Latitude = "13.55000000", Longitude = "-14.91667000" },
                        new() { Id = 24, Name = "Sukuta", Latitude = "13.61667000", Longitude = "-14.91667000" },
                        new() { Id = 25, Name = "Upper Saloum", Latitude = "13.75000000", Longitude = "-15.20000000" },
                        new() { Id = 26, Name = "Wassu", Latitude = "13.69094000", Longitude = "-14.87884000" }
                    }
                },

                new()
                {
                    Id = 3,
                    Name = "Lower River",
                    StateCode = "L",
                    Latitude = "13.35533060",
                    Longitude = "-15.92299000",
                    Type = "division",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Baro Kunda", Latitude = "13.48333000", Longitude = "-15.26667000" },
                        new() { Id = 2, Name = "Bureng", Latitude = "13.41667000", Longitude = "-15.28333000" },
                        new() { Id = 3, Name = "Jali", Latitude = "13.35000000", Longitude = "-15.96667000" },
                        new() { Id = 4, Name = "Jarra Central", Latitude = "13.41667000", Longitude = "-15.41667000" },
                        new() { Id = 5, Name = "Jarra East", Latitude = "13.41667000", Longitude = "-15.25000000" },
                        new() { Id = 6, Name = "Jarra West", Latitude = "13.41667000", Longitude = "-15.53333000" },
                        new() { Id = 7, Name = "Jenoi", Latitude = "13.48333000", Longitude = "-15.56667000" },
                        new() { Id = 8, Name = "Jifarong", Latitude = "13.30000000", Longitude = "-15.86667000" },
                        new() { Id = 9, Name = "Kaiaf", Latitude = "13.40000000", Longitude = "-15.61667000" },
                        new() { Id = 10, Name = "Karantaba", Latitude = "13.43333000", Longitude = "-15.51667000" },
                        new() { Id = 11, Name = "Keneba", Latitude = "13.32889000", Longitude = "-16.01500000" },
                        new() { Id = 12, Name = "Kiang Central", Latitude = "13.40000000", Longitude = "-15.75000000" },
                        new() { Id = 13, Name = "Kiang East", Latitude = "13.41667000", Longitude = "-15.63333000" },
                        new() { Id = 14, Name = "Kiang West District", Latitude = "13.33333000", Longitude = "-16.00000000" },
                        new() { Id = 15, Name = "Mansa Konko", Latitude = "13.44325000", Longitude = "-15.53570000" },
                        new() { Id = 16, Name = "Nioro", Latitude = "13.35000000", Longitude = "-15.75000000" },
                        new() { Id = 17, Name = "Sankwia", Latitude = "13.46667000", Longitude = "-15.51667000" },
                        new() { Id = 18, Name = "Si Kunda", Latitude = "13.43333000", Longitude = "-15.56667000" },
                        new() { Id = 19, Name = "Soma", Latitude = "13.43333000", Longitude = "-15.53333000" },
                        new() { Id = 20, Name = "Sutukung", Latitude = "13.46667000", Longitude = "-15.26667000" },
                        new() { Id = 21, Name = "Toniataba", Latitude = "13.43333000", Longitude = "-15.58333000" },
                        new() { Id = 22, Name = "Wellingara Ba", Latitude = "13.41667000", Longitude = "-15.40000000" }
                    }
                },

                new()
                {
                    Id = 4,
                    Name = "North Bank",
                    StateCode = "N",
                    Latitude = "13.52854360",
                    Longitude = "-16.01699710",
                    Type = "division",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Bambali", Latitude = "13.48333000", Longitude = "-15.33333000" },
                        new() { Id = 2, Name = "Barra", Latitude = "13.48278000", Longitude = "-16.54556000" },
                        new() { Id = 3, Name = "Central Baddibu", Latitude = "13.53333000", Longitude = "-15.91667000" },
                        new() { Id = 4, Name = "Chilla", Latitude = "13.55000000", Longitude = "-16.28333000" },
                        new() { Id = 5, Name = "Daru Rilwan", Latitude = "13.55000000", Longitude = "-15.98333000" },
                        new() { Id = 6, Name = "Essau", Latitude = "13.48389000", Longitude = "-16.53472000" },
                        new() { Id = 7, Name = "Farafenni", Latitude = "13.56667000", Longitude = "-15.60000000" },
                        new() { Id = 8, Name = "Gunjur", Latitude = "13.52278000", Longitude = "-16.02778000" },
                        new() { Id = 9, Name = "Jokadu", Latitude = "13.53333000", Longitude = "-16.18333000" },
                        new() { Id = 10, Name = "Katchang", Latitude = "13.50000000", Longitude = "-15.75000000" },
                        new() { Id = 11, Name = "Kerewan", Latitude = "13.48980000", Longitude = "-16.08879000" },
                        new() { Id = 12, Name = "Lamin", Latitude = "13.35222000", Longitude = "-16.43389000" },
                        new() { Id = 13, Name = "Lower Baddibu District", Latitude = "13.50000000", Longitude = "-16.05000000" },
                        new() { Id = 14, Name = "Lower Niumi District", Latitude = "13.53333000", Longitude = "-16.41667000" },
                        new() { Id = 15, Name = "No Kunda", Latitude = "13.56667000", Longitude = "-15.83333000" },
                        new() { Id = 16, Name = "Saba", Latitude = "13.51639000", Longitude = "-16.04917000" },
                        new() { Id = 17, Name = "Sara Kunda", Latitude = "13.53333000", Longitude = "-15.41667000" },
                        new() { Id = 18, Name = "Upper Baddibu", Latitude = "13.55000000", Longitude = "-15.66667000" },
                        new() { Id = 19, Name = "Upper Niumi District", Latitude = "13.40000000", Longitude = "-16.33333000" }
                    }
                },

                new()
                {
                    Id = 5,
                    Name = "Upper River",
                    StateCode = "U",
                    Latitude = "13.42573660",
                    Longitude = "-14.00723480",
                    Type = "division",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Bakadagy", Latitude = "13.30000000", Longitude = "-14.38333000" },
                        new() { Id = 2, Name = "Basse Santa Su", Latitude = "13.30995000", Longitude = "-14.21373000" },
                        new() { Id = 3, Name = "Brifu", Latitude = "13.50000000", Longitude = "-13.93333000" },
                        new() { Id = 4, Name = "Daba Kunda", Latitude = "13.31667000", Longitude = "-14.30000000" },
                        new() { Id = 5, Name = "Demba Kunda", Latitude = "13.25000000", Longitude = "-14.26667000" },
                        new() { Id = 6, Name = "Diabugu", Latitude = "13.38333000", Longitude = "-14.40000000" },
                        new() { Id = 7, Name = "Diabugu Basilla", Latitude = "13.33333000", Longitude = "-13.95000000" },
                        new() { Id = 8, Name = "Fulladu East", Latitude = "13.33333000", Longitude = "-14.25000000" },
                        new() { Id = 9, Name = "Gunjur Kuta", Latitude = "13.53333000", Longitude = "-14.11667000" },
                        new() { Id = 10, Name = "Kantora", Latitude = "13.41667000", Longitude = "-13.91667000" },
                        new() { Id = 11, Name = "Koina", Latitude = "13.48333000", Longitude = "-13.86667000" },
                        new() { Id = 12, Name = "Kumbija", Latitude = "13.26667000", Longitude = "-14.18333000" },
                        new() { Id = 13, Name = "Nyamanari", Latitude = "13.33333000", Longitude = "-13.86667000" },
                        new() { Id = 14, Name = "Perai", Latitude = "13.38333000", Longitude = "-14.03333000" },
                        new() { Id = 15, Name = "Sabi", Latitude = "13.23333000", Longitude = "-14.20000000" },
                        new() { Id = 16, Name = "Sandu", Latitude = "13.41667000", Longitude = "-14.36667000" },
                        new() { Id = 17, Name = "Sudowol", Latitude = "13.36667000", Longitude = "-13.96667000" },
                        new() { Id = 18, Name = "Sun Kunda", Latitude = "13.38333000", Longitude = "-13.85000000" },
                        new() { Id = 19, Name = "Sutukoba", Latitude = "13.50000000", Longitude = "-14.01667000" },
                        new() { Id = 20, Name = "Wuli", Latitude = "13.50000000", Longitude = "-14.08333000" }
                    }
                },

                new()
                {
                    Id = 6,
                    Name = "West Coast",
                    StateCode = "W",
                    Latitude = "5.97727980",
                    Longitude = "116.07542880",
                    Type = "division",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Abuko", Latitude = "13.40417000", Longitude = "-16.65583000" },
                        new() { Id = 2, Name = "Brikama", Latitude = "13.27136000", Longitude = "-16.64944000" },
                        new() { Id = 3, Name = "Foni Bondali", Latitude = "13.21667000", Longitude = "-15.93333000" },
                        new() { Id = 4, Name = "Foni Brefet", Latitude = "13.21667000", Longitude = "-16.33333000" },
                        new() { Id = 5, Name = "Foni Jarrol", Latitude = "13.23333000", Longitude = "-15.83333000" },
                        new() { Id = 6, Name = "Foni Kansala", Latitude = "13.21667000", Longitude = "-16.05000000" },
                        new() { Id = 7, Name = "Gunjur", Latitude = "13.20194000", Longitude = "-16.73389000" },
                        new() { Id = 8, Name = "Kombo Central District", Latitude = "13.25000000", Longitude = "-16.66667000" },
                        new() { Id = 9, Name = "Kombo East District", Latitude = "13.21667000", Longitude = "-16.51667000" },
                        new() { Id = 10, Name = "Kombo North District", Latitude = "13.36667000", Longitude = "-16.66667000" },
                        new() { Id = 11, Name = "Kombo South District", Latitude = "13.25000000", Longitude = "-16.75000000" },
                        new() { Id = 12, Name = "Somita", Latitude = "13.20583000", Longitude = "-16.30556000" },
                        new() { Id = 13, Name = "Sukuta", Latitude = "13.41033000", Longitude = "-16.70815000" }
                    }
                }
            }
        };
    }
}
