// ⚠️ WARNING: This file is automatically generated by scripts/generate-world.ps1
// DO NOT modify this file manually as it will be overwritten when the script is run again.
// To update the data, modify the source data in countries-states-cities-database and run the script.

using System.Collections.Generic;
using ShowsOnSale.World.Models;

namespace ShowsOnSale.World.Data.Countries
{
    public static class Uzbekistan
    {
        public static Country Data { get; } = new()
        {
            Id = 239,
            Name = "Uzbekistan",
            Iso3 = "UZB",
            Iso2 = "UZ",
            NumericCode = "860",
            PhoneCode = "998",
            Capital = "Tashkent",
            Currency = "UZS",
            CurrencyName = "Uzbekistani soʻm",
            CurrencySymbol = "лв",
            Tld = ".uz",
            Native = "O‘zbekiston",
            Region = "Asia",
            RegionId = 3,
            Subregion = "Central Asia",
            SubregionId = 10,
            Nationality = "Uzbekistani, Uzbek",
            Latitude = "41.00000000",
            Longitude = "64.00000000",
            Emoji = "🇺🇿",
            EmojiU = "U+1F1FA U+1F1FF",
            Timezones = new()
            {
                new() { ZoneName = "Asia/Samarkand", GmtOffset = 18000, GmtOffsetName = "UTC+05:00", Abbreviation = "UZT", TzName = "Uzbekistan Time" },
                new() { ZoneName = "Asia/Tashkent", GmtOffset = 18000, GmtOffsetName = "UTC+05:00", Abbreviation = "UZT", TzName = "Uzbekistan Time" }
            },
            Translations = new()
            {
                ["ko"] = "우즈베키스탄",
                ["pt-BR"] = "Uzbequistão",
                ["pt"] = "Usbequistão",
                ["nl"] = "Oezbekistan",
                ["hr"] = "Uzbekistan",
                ["fa"] = "ازبکستان",
                ["de"] = "Usbekistan",
                ["es"] = "Uzbekistán",
                ["fr"] = "Ouzbékistan",
                ["ja"] = "ウズベキスタン",
                ["it"] = "Uzbekistan",
                ["zh-CN"] = "乌兹别克斯坦",
                ["tr"] = "Özbekistan",
                ["ru"] = "Узбекистан",
                ["uk"] = "Узбекистан",
                ["pl"] = "Uzbekistan"
            },
            States = new()
            {

                new()
                {
                    Id = 1,
                    Name = "Andijan",
                    StateCode = "AN",
                    Latitude = "40.76859410",
                    Longitude = "72.23637900",
                    Type = "region",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Andijon", Latitude = "40.78206000", Longitude = "72.34424000" },
                        new() { Id = 2, Name = "Andijon Tumani", Latitude = "40.80000000", Longitude = "72.41667000" },
                        new() { Id = 3, Name = "Asaka", Latitude = "40.64153000", Longitude = "72.23868000" },
                        new() { Id = 4, Name = "Asaka Tumani", Latitude = "40.66667000", Longitude = "72.25000000" },
                        new() { Id = 5, Name = "Baliqchi Tumani", Latitude = "40.86667000", Longitude = "72.00000000" },
                        new() { Id = 6, Name = "Bo‘z Tumani", Latitude = "40.66667000", Longitude = "71.91667000" },
                        new() { Id = 7, Name = "Buloqboshi Tumani", Latitude = "40.61667000", Longitude = "72.46667000" },
                        new() { Id = 8, Name = "Izboskan Tumani", Latitude = "40.91667000", Longitude = "72.25000000" },
                        new() { Id = 9, Name = "Jalolkuduk Tumani", Latitude = "40.75000000", Longitude = "72.66667000" },
                        new() { Id = 10, Name = "Khŭjaobod Tumani", Latitude = "40.66667000", Longitude = "72.58333000" },
                        new() { Id = 11, Name = "Marhamat", Latitude = "40.48048000", Longitude = "72.31388000" },
                        new() { Id = 12, Name = "Marhamat Tumani", Latitude = "40.50000000", Longitude = "72.31667000" },
                        new() { Id = 13, Name = "Oltinkŭl Tumani", Latitude = "40.80000000", Longitude = "72.16667000" },
                        new() { Id = 14, Name = "Pakhtaobod Tumani", Latitude = "40.93333000", Longitude = "72.50000000" },
                        new() { Id = 15, Name = "Paxtaobod", Latitude = "40.92936000", Longitude = "72.49687000" },
                        new() { Id = 16, Name = "Qo‘rg‘ontepa", Latitude = "40.73192000", Longitude = "72.76177000" },
                        new() { Id = 17, Name = "Qŭrghontepa Tumani", Latitude = "40.75000000", Longitude = "72.83333000" },
                        new() { Id = 18, Name = "Shahrikhon Tumani", Latitude = "40.71667000", Longitude = "72.06667000" },
                        new() { Id = 19, Name = "Shahrixon", Latitude = "40.71331000", Longitude = "72.05706000" },
                        new() { Id = 20, Name = "Ulug‘nor Tumani", Latitude = "40.75000000", Longitude = "71.70000000" },
                        new() { Id = 21, Name = "Xo‘jaobod", Latitude = "40.66886000", Longitude = "72.56002000" }
                    }
                },

                new()
                {
                    Id = 2,
                    Name = "Bukhara",
                    StateCode = "BU",
                    Latitude = "40.25041620",
                    Longitude = "63.20321510",
                    Type = "region",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Bukhara", Latitude = "39.77472000", Longitude = "64.42861000" },
                        new() { Id = 2, Name = "Galaosiyo", Latitude = "39.85778000", Longitude = "64.44833000" },
                        new() { Id = 3, Name = "Gazli", Latitude = "40.13333000", Longitude = "63.45000000" },
                        new() { Id = 4, Name = "Ghijduwon", Latitude = "40.10000000", Longitude = "64.68333000" },
                        new() { Id = 5, Name = "Karakul’", Latitude = "39.53333000", Longitude = "63.83333000" },
                        new() { Id = 6, Name = "Kogon", Latitude = "39.72278000", Longitude = "64.55167000" },
                        new() { Id = 7, Name = "Olot", Latitude = "39.41500000", Longitude = "63.80333000" },
                        new() { Id = 8, Name = "Peshku Tumani", Latitude = "40.41667000", Longitude = "63.83333000" },
                        new() { Id = 9, Name = "Qorako’l", Latitude = "39.49944000", Longitude = "63.85389000" },
                        new() { Id = 10, Name = "Qorovulbozor", Latitude = "39.50056000", Longitude = "64.79361000" },
                        new() { Id = 11, Name = "Romiton", Latitude = "39.92944000", Longitude = "64.37944000" },
                        new() { Id = 12, Name = "Shofirkon", Latitude = "40.12000000", Longitude = "64.50139000" },
                        new() { Id = 13, Name = "Wobkent", Latitude = "40.03028000", Longitude = "64.51500000" },
                        new() { Id = 14, Name = "Wobkent Tumani", Latitude = "40.00000000", Longitude = "64.50000000" }
                    }
                },

                new()
                {
                    Id = 3,
                    Name = "Fergana",
                    StateCode = "FA",
                    Latitude = "40.45680810",
                    Longitude = "71.28742090",
                    Type = "region",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Beshariq", Latitude = "40.43583000", Longitude = "70.61028000" },
                        new() { Id = 2, Name = "Fergana", Latitude = "40.38421000", Longitude = "71.78432000" },
                        new() { Id = 3, Name = "Hamza", Latitude = "40.42762000", Longitude = "71.50534000" },
                        new() { Id = 4, Name = "Kirguli", Latitude = "40.43553000", Longitude = "71.76721000" },
                        new() { Id = 5, Name = "Marg‘ilon", Latitude = "40.47237000", Longitude = "71.72463000" },
                        new() { Id = 6, Name = "Oltiariq", Latitude = "40.39194000", Longitude = "71.47417000" },
                        new() { Id = 7, Name = "Qo‘qon", Latitude = "40.52861000", Longitude = "70.94250000" },
                        new() { Id = 8, Name = "Quva", Latitude = "40.52204000", Longitude = "72.07292000" },
                        new() { Id = 9, Name = "Quvasoy", Latitude = "40.29721000", Longitude = "71.98026000" },
                        new() { Id = 10, Name = "Rishton", Latitude = "40.35667000", Longitude = "71.28472000" },
                        new() { Id = 11, Name = "Shohimardon", Latitude = "39.98322000", Longitude = "71.80512000" },
                        new() { Id = 12, Name = "So‘x Tumani", Latitude = "40.04417000", Longitude = "71.09417000" },
                        new() { Id = 13, Name = "Toshloq", Latitude = "40.47722000", Longitude = "71.76778000" },
                        new() { Id = 14, Name = "Yangi Marg‘ilon", Latitude = "40.42722000", Longitude = "71.71889000" },
                        new() { Id = 15, Name = "Yaypan", Latitude = "40.37583000", Longitude = "70.81556000" }
                    }
                },

                new()
                {
                    Id = 4,
                    Name = "Jizzakh",
                    StateCode = "JI",
                    Latitude = "40.47064150",
                    Longitude = "67.57085360",
                    Type = "region",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Dashtobod", Latitude = "40.12694000", Longitude = "68.49444000" },
                        new() { Id = 2, Name = "Dŭstlik", Latitude = "40.52472000", Longitude = "68.03583000" },
                        new() { Id = 3, Name = "Gagarin", Latitude = "40.66194000", Longitude = "68.17222000" },
                        new() { Id = 4, Name = "Jizzax", Latitude = "40.11583000", Longitude = "67.84222000" },
                        new() { Id = 5, Name = "Paxtakor", Latitude = "40.31528000", Longitude = "67.95444000" },
                        new() { Id = 6, Name = "Zomin", Latitude = "39.96056000", Longitude = "68.39583000" }
                    }
                },

                new()
                {
                    Id = 5,
                    Name = "Karakalpakstan",
                    StateCode = "QR",
                    Latitude = "43.80413340",
                    Longitude = "59.44579880",
                    Type = "republic",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Beruniy", Latitude = "41.69111000", Longitude = "60.75250000" },
                        new() { Id = 2, Name = "Kegeyli Shahar", Latitude = "42.77667000", Longitude = "59.60778000" },
                        new() { Id = 3, Name = "Khŭjayli", Latitude = "42.40043000", Longitude = "59.46005000" },
                        new() { Id = 4, Name = "Manghit", Latitude = "42.11556000", Longitude = "60.05972000" },
                        new() { Id = 5, Name = "Mŭynoq", Latitude = "43.76833000", Longitude = "59.02139000" },
                        new() { Id = 6, Name = "Novyy Turtkul’", Latitude = "41.55000000", Longitude = "61.01667000" },
                        new() { Id = 7, Name = "Nukus", Latitude = "42.45306000", Longitude = "59.61028000" },
                        new() { Id = 8, Name = "Oltinko‘l", Latitude = "43.06874000", Longitude = "58.90372000" }
                    }
                },

                new()
                {
                    Id = 6,
                    Name = "Namangan",
                    StateCode = "NG",
                    Latitude = "41.05100370",
                    Longitude = "71.09731700",
                    Type = "region",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Chortoq", Latitude = "41.06924000", Longitude = "71.82372000" },
                        new() { Id = 2, Name = "Chust", Latitude = "41.00329000", Longitude = "71.23791000" },
                        new() { Id = 3, Name = "Haqqulobod", Latitude = "40.91667000", Longitude = "72.11667000" },
                        new() { Id = 4, Name = "Kosonsoy", Latitude = "41.24944000", Longitude = "71.54738000" },
                        new() { Id = 5, Name = "Namangan", Latitude = "40.99830000", Longitude = "71.67257000" },
                        new() { Id = 6, Name = "Pop", Latitude = "40.87361000", Longitude = "71.10889000" },
                        new() { Id = 7, Name = "To‘rqao‘rg‘on", Latitude = "40.99984000", Longitude = "71.51162000" },
                        new() { Id = 8, Name = "Toshbuloq", Latitude = "40.91617000", Longitude = "71.57819000" },
                        new() { Id = 9, Name = "Uchqŭrghon Shahri", Latitude = "41.11371000", Longitude = "72.07915000" },
                        new() { Id = 10, Name = "Uychi", Latitude = "41.08073000", Longitude = "71.92331000" },
                        new() { Id = 11, Name = "Yangiqo‘rg‘on", Latitude = "41.19474000", Longitude = "71.72385000" }
                    }
                },

                new()
                {
                    Id = 7,
                    Name = "Navoiy",
                    StateCode = "NW",
                    Latitude = "42.69885750",
                    Longitude = "64.63376850",
                    Type = "region",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Navoiy", Latitude = "40.08444000", Longitude = "65.37917000" },
                        new() { Id = 2, Name = "Nurota", Latitude = "40.56139000", Longitude = "65.68861000" },
                        new() { Id = 3, Name = "Qiziltepa", Latitude = "40.03306000", Longitude = "64.85000000" },
                        new() { Id = 4, Name = "Yangirabot", Latitude = "40.02539000", Longitude = "65.96095000" }
                    }
                },

                new()
                {
                    Id = 8,
                    Name = "Qashqadaryo",
                    StateCode = "QA",
                    Latitude = "38.89862310",
                    Longitude = "66.04635340",
                    Type = "region",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Beshkent", Latitude = "38.82139000", Longitude = "65.65306000" },
                        new() { Id = 2, Name = "Chiroqchi", Latitude = "39.03361000", Longitude = "66.57222000" },
                        new() { Id = 3, Name = "G‘uzor", Latitude = "38.62083000", Longitude = "66.24806000" },
                        new() { Id = 4, Name = "Kitob", Latitude = "39.08425000", Longitude = "66.83318000" },
                        new() { Id = 5, Name = "Koson", Latitude = "39.03750000", Longitude = "65.58500000" },
                        new() { Id = 6, Name = "Muborak", Latitude = "39.25528000", Longitude = "65.15278000" },
                        new() { Id = 7, Name = "Nishon Tumani", Latitude = "38.69395000", Longitude = "65.67512000" },
                        new() { Id = 8, Name = "Qarshi", Latitude = "38.86056000", Longitude = "65.78905000" },
                        new() { Id = 9, Name = "Shahrisabz", Latitude = "39.05778000", Longitude = "66.83417000" }
                    }
                },

                new()
                {
                    Id = 9,
                    Name = "Samarqand",
                    StateCode = "SA",
                    Latitude = "39.62701200",
                    Longitude = "66.97497310",
                    Type = "region",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Bulung’ur", Latitude = "39.76472000", Longitude = "67.27139000" },
                        new() { Id = 2, Name = "Charxin", Latitude = "39.69667000", Longitude = "66.76861000" },
                        new() { Id = 3, Name = "Chelak", Latitude = "39.92028000", Longitude = "66.86111000" },
                        new() { Id = 4, Name = "Daxbet", Latitude = "39.76389000", Longitude = "66.91250000" },
                        new() { Id = 5, Name = "Ishtixon", Latitude = "39.96639000", Longitude = "66.48611000" },
                        new() { Id = 6, Name = "Jomboy", Latitude = "39.69889000", Longitude = "67.09333000" },
                        new() { Id = 7, Name = "Juma", Latitude = "39.71611000", Longitude = "66.66417000" },
                        new() { Id = 8, Name = "Kattaqo‘rg‘on", Latitude = "39.89889000", Longitude = "66.25611000" },
                        new() { Id = 9, Name = "Oqtosh", Latitude = "39.92139000", Longitude = "65.92528000" },
                        new() { Id = 10, Name = "Payshanba", Latitude = "40.00778000", Longitude = "66.23694000" },
                        new() { Id = 11, Name = "Samarkand", Latitude = "39.65417000", Longitude = "66.95972000" },
                        new() { Id = 12, Name = "Urgut", Latitude = "39.40222000", Longitude = "67.24306000" }
                    }
                },

                new()
                {
                    Id = 10,
                    Name = "Sirdaryo",
                    StateCode = "SI",
                    Latitude = "40.38638080",
                    Longitude = "68.71549750",
                    Type = "region",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Guliston", Latitude = "40.48972000", Longitude = "68.78417000" },
                        new() { Id = 2, Name = "Sirdaryo", Latitude = "40.84361000", Longitude = "68.66167000" },
                        new() { Id = 3, Name = "Yangiyer", Latitude = "40.27500000", Longitude = "68.82250000" }
                    }
                },

                new()
                {
                    Id = 11,
                    Name = "Surxondaryo",
                    StateCode = "SU",
                    Latitude = "37.94090050",
                    Longitude = "67.57085360",
                    Type = "region",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Boysun", Latitude = "38.20835000", Longitude = "67.20664000" },
                        new() { Id = 2, Name = "Denov", Latitude = "38.26746000", Longitude = "67.89886000" },
                        new() { Id = 3, Name = "Sho‘rchi", Latitude = "37.99944000", Longitude = "67.78750000" },
                        new() { Id = 4, Name = "Tirmiz", Latitude = "37.22417000", Longitude = "67.27833000" }
                    }
                },

                new()
                {
                    Id = 12,
                    Name = "Tashkent",
                    StateCode = "TK",
                    Latitude = "41.29949580",
                    Longitude = "69.24007340",
                    Type = "city",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Bektemir", Latitude = "41.20972000", Longitude = "69.33417000" },
                        new() { Id = 2, Name = "Tashkent", Latitude = "41.26465000", Longitude = "69.21627000" }
                    }
                },

                new()
                {
                    Id = 13,
                    Name = "Tashkent",
                    StateCode = "TO",
                    Latitude = "41.22132340",
                    Longitude = "69.85974060",
                    Type = "region",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Angren", Latitude = "41.01667000", Longitude = "70.14361000" },
                        new() { Id = 2, Name = "Bekobod", Latitude = "40.22083000", Longitude = "69.26972000" },
                        new() { Id = 3, Name = "Bo‘ka", Latitude = "40.81108000", Longitude = "69.19417000" },
                        new() { Id = 4, Name = "Chinoz", Latitude = "40.93633000", Longitude = "68.76128000" },
                        new() { Id = 5, Name = "Chirchiq", Latitude = "41.46889000", Longitude = "69.58222000" },
                        new() { Id = 6, Name = "G‘azalkent", Latitude = "41.55806000", Longitude = "69.77083000" },
                        new() { Id = 7, Name = "Iskandar", Latitude = "41.55389000", Longitude = "69.70083000" },
                        new() { Id = 8, Name = "Kyzyldzhar", Latitude = "41.56667000", Longitude = "70.01667000" },
                        new() { Id = 9, Name = "Ohangaron", Latitude = "40.90639000", Longitude = "69.63833000" },
                        new() { Id = 10, Name = "Olmaliq", Latitude = "40.84472000", Longitude = "69.59833000" },
                        new() { Id = 11, Name = "Parkent", Latitude = "41.29444000", Longitude = "69.67639000" },
                        new() { Id = 12, Name = "Piskent", Latitude = "40.89722000", Longitude = "69.35056000" },
                        new() { Id = 13, Name = "Qibray", Latitude = "41.38972000", Longitude = "69.46500000" },
                        new() { Id = 14, Name = "Salor", Latitude = "41.37222000", Longitude = "69.38167000" },
                        new() { Id = 15, Name = "Tŭytepa", Latitude = "41.03210000", Longitude = "69.36253000" },
                        new() { Id = 16, Name = "Ŭrtaowul", Latitude = "41.18667000", Longitude = "69.14528000" },
                        new() { Id = 17, Name = "Yangiobod", Latitude = "41.11919000", Longitude = "70.09406000" },
                        new() { Id = 18, Name = "Yangiyŭl", Latitude = "41.11202000", Longitude = "69.04710000" },
                        new() { Id = 19, Name = "Zafar", Latitude = "40.98333000", Longitude = "68.90000000" }
                    }
                },

                new()
                {
                    Id = 14,
                    Name = "Xorazm",
                    StateCode = "XO",
                    Latitude = "41.35653360",
                    Longitude = "60.85666860",
                    Type = "region",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Boghot Tumani", Latitude = "41.31495000", Longitude = "60.85327000" },
                        new() { Id = 2, Name = "Gurlan", Latitude = "41.84472000", Longitude = "60.39194000" },
                        new() { Id = 3, Name = "Hazorasp", Latitude = "41.31944000", Longitude = "61.07417000" },
                        new() { Id = 4, Name = "Khiwa", Latitude = "41.37833000", Longitude = "60.36389000" },
                        new() { Id = 5, Name = "Qŭshkŭpir", Latitude = "41.53500000", Longitude = "60.34556000" },
                        new() { Id = 6, Name = "Showot", Latitude = "41.65583000", Longitude = "60.30250000" },
                        new() { Id = 7, Name = "Urganch", Latitude = "41.55000000", Longitude = "60.63333000" }
                    }
                }
            }
        };
    }
}
