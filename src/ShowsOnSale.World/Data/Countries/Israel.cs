// ⚠️ WARNING: This file is automatically generated by scripts/generate-world.ps1
// DO NOT modify this file manually as it will be overwritten when the script is run again.
// To update the data, modify the source data in countries-states-cities-database and run the script.

using System.Collections.Generic;
using ShowsOnSale.World.Models;

namespace ShowsOnSale.World.Data.Countries
{
    public static class Israel
    {
        public static Country Data { get; } = new()
        {
            Id = 106,
            Name = "Israel",
            Iso3 = "ISR",
            Iso2 = "IL",
            NumericCode = "376",
            PhoneCode = "972",
            Capital = "Jerusalem",
            Currency = "ILS",
            CurrencyName = "Israeli new shekel",
            CurrencySymbol = "₪",
            Tld = ".il",
            Native = "יִשְׂרָאֵל",
            Region = "Asia",
            RegionId = 3,
            Subregion = "Western Asia",
            SubregionId = 11,
            Nationality = "Israeli",
            Latitude = "31.50000000",
            Longitude = "34.75000000",
            Emoji = "🇮🇱",
            EmojiU = "U+1F1EE U+1F1F1",
            Timezones = new()
            {
                new() { ZoneName = "Asia/Jerusalem", GmtOffset = 7200, GmtOffsetName = "UTC+02:00", Abbreviation = "IST", TzName = "Israel Standard Time" }
            },
            Translations = new()
            {
                ["ko"] = "이스라엘",
                ["pt-BR"] = "Israel",
                ["pt"] = "Israel",
                ["nl"] = "Israël",
                ["hr"] = "Izrael",
                ["fa"] = "اسرائیل",
                ["de"] = "Israel",
                ["es"] = "Israel",
                ["fr"] = "Israël",
                ["ja"] = "イスラエル",
                ["it"] = "Israele",
                ["zh-CN"] = "以色列",
                ["tr"] = "İsrail",
                ["ru"] = "Израиль",
                ["uk"] = "Ізраїль",
                ["pl"] = "Izrael"
            },
            States = new()
            {

                new()
                {
                    Id = 1,
                    Name = "Central",
                    StateCode = "M",
                    Latitude = "47.60875830",
                    Longitude = "-122.29642350",
                    Type = "district",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Bet Dagan", Latitude = "32.00191000", Longitude = "34.82977000" },
                        new() { Id = 2, Name = "Bet Yiẕẖaq", Latitude = "32.32751000", Longitude = "34.88878000" },
                        new() { Id = 3, Name = "Bnei Ayish", Latitude = "31.78333000", Longitude = "34.75000000" },
                        new() { Id = 4, Name = "Elyakhin", Latitude = "32.40793000", Longitude = "34.92433000" },
                        new() { Id = 5, Name = "Eṭ Ṭaiyiba", Latitude = "32.26616000", Longitude = "35.00893000" },
                        new() { Id = 6, Name = "Even Yehuda", Latitude = "32.26959000", Longitude = "34.88759000" },
                        new() { Id = 7, Name = "Gan Yavne", Latitude = "31.78737000", Longitude = "34.70659000" },
                        new() { Id = 8, Name = "Ganei Tikva", Latitude = "32.05971000", Longitude = "34.87320000" },
                        new() { Id = 9, Name = "Gedera", Latitude = "31.81456000", Longitude = "34.77998000" },
                        new() { Id = 10, Name = "Hod HaSharon", Latitude = "32.15934000", Longitude = "34.89320000" },
                        new() { Id = 11, Name = "Jaljūlya", Latitude = "32.15470000", Longitude = "34.95372000" },
                        new() { Id = 12, Name = "Kafr Qāsim", Latitude = "32.11406000", Longitude = "34.97624000" },
                        new() { Id = 13, Name = "Kefar H̱abad", Latitude = "31.98793000", Longitude = "34.85160000" },
                        new() { Id = 14, Name = "Kefar Yona", Latitude = "32.31669000", Longitude = "34.93507000" },
                        new() { Id = 15, Name = "Kfar Saba", Latitude = "32.17500000", Longitude = "34.90694000" },
                        new() { Id = 16, Name = "Lapid", Latitude = "31.91764000", Longitude = "35.03222000" },
                        new() { Id = 17, Name = "Lod", Latitude = "31.94670000", Longitude = "34.89030000" },
                        new() { Id = 18, Name = "Mazkeret Batya", Latitude = "31.85357000", Longitude = "34.84646000" },
                        new() { Id = 19, Name = "Modi‘in Makkabbim Re‘ut", Latitude = "31.89385000", Longitude = "35.01504000" },
                        new() { Id = 20, Name = "Neẖalim", Latitude = "32.06012000", Longitude = "34.91069000" },
                        new() { Id = 21, Name = "Ness Ziona", Latitude = "31.92933000", Longitude = "34.79868000" },
                        new() { Id = 22, Name = "Netanya", Latitude = "32.33291000", Longitude = "34.85992000" },
                        new() { Id = 23, Name = "Nirit", Latitude = "32.14677000", Longitude = "34.98622000" },
                        new() { Id = 24, Name = "Nof Ayalon", Latitude = "31.87111000", Longitude = "34.99081000" },
                        new() { Id = 25, Name = "Nordiyya", Latitude = "32.31470000", Longitude = "34.89617000" },
                        new() { Id = 26, Name = "Pardesiyya", Latitude = "32.30577000", Longitude = "34.90911000" },
                        new() { Id = 27, Name = "Petaẖ Tiqwa", Latitude = "32.08707000", Longitude = "34.88747000" },
                        new() { Id = 28, Name = "Qalansuwa", Latitude = "32.28493000", Longitude = "34.98106000" },
                        new() { Id = 29, Name = "Ra'anana", Latitude = "32.18360000", Longitude = "34.87386000" },
                        new() { Id = 30, Name = "Ramla", Latitude = "31.92923000", Longitude = "34.86563000" },
                        new() { Id = 31, Name = "Reẖovot", Latitude = "31.89421000", Longitude = "34.81199000" },
                        new() { Id = 32, Name = "Rishon LeẔiyyon", Latitude = "31.97102000", Longitude = "34.78939000" },
                        new() { Id = 33, Name = "Rosh Ha‘Ayin", Latitude = "32.09556000", Longitude = "34.95664000" },
                        new() { Id = 34, Name = "Savyon", Latitude = "32.04966000", Longitude = "34.87770000" },
                        new() { Id = 35, Name = "Shoham", Latitude = "31.99866000", Longitude = "34.94559000" },
                        new() { Id = 36, Name = "Tel Mond", Latitude = "32.24995000", Longitude = "34.91737000" },
                        new() { Id = 37, Name = "Tirah", Latitude = "32.23410000", Longitude = "34.95023000" },
                        new() { Id = 38, Name = "Yavné", Latitude = "31.87808000", Longitude = "34.73983000" },
                        new() { Id = 39, Name = "Yehud", Latitude = "32.03317000", Longitude = "34.89091000" },
                        new() { Id = 40, Name = "Ẕur Moshe", Latitude = "32.29819000", Longitude = "34.91313000" }
                    }
                },

                new()
                {
                    Id = 2,
                    Name = "Haifa",
                    StateCode = "HA",
                    Latitude = "32.48141110",
                    Longitude = "34.99475100",
                    Type = "district",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Atlit", Latitude = "32.68889000", Longitude = "34.94236000" },
                        new() { Id = 2, Name = "Caesarea", Latitude = "32.51888000", Longitude = "34.90459000" },
                        new() { Id = 3, Name = "Daliyat al Karmel", Latitude = "32.69383000", Longitude = "35.04686000" },
                        new() { Id = 4, Name = "El Fureidīs", Latitude = "32.59812000", Longitude = "34.95153000" },
                        new() { Id = 5, Name = "Hadera", Latitude = "32.44192000", Longitude = "34.90390000" },
                        new() { Id = 6, Name = "Haifa", Latitude = "32.81841000", Longitude = "34.98850000" },
                        new() { Id = 7, Name = "Ibṭīn", Latitude = "32.76150000", Longitude = "35.11402000" },
                        new() { Id = 8, Name = "Nesher", Latitude = "32.76622000", Longitude = "35.04425000" },
                        new() { Id = 9, Name = "Qiryat Ata", Latitude = "32.81149000", Longitude = "35.11323000" },
                        new() { Id = 10, Name = "Qiryat Bialik", Latitude = "32.82750000", Longitude = "35.08583000" },
                        new() { Id = 11, Name = "Qiryat Moẕqin", Latitude = "32.83706000", Longitude = "35.07760000" },
                        new() { Id = 12, Name = "Qiryat Yam", Latitude = "32.84966000", Longitude = "35.06973000" },
                        new() { Id = 13, Name = "Rekhasim", Latitude = "32.74907000", Longitude = "35.09901000" },
                        new() { Id = 14, Name = "Tirat Karmel", Latitude = "32.76021000", Longitude = "34.97183000" },
                        new() { Id = 15, Name = "Umm el Faḥm", Latitude = "32.51725000", Longitude = "35.15349000" }
                    }
                },

                new()
                {
                    Id = 3,
                    Name = "Jerusalem",
                    StateCode = "JM",
                    Latitude = "31.76482430",
                    Longitude = "34.99475100",
                    Type = "district",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Abū Ghaush", Latitude = "31.80592000", Longitude = "35.10930000" },
                        new() { Id = 2, Name = "Bet Shemesh", Latitude = "31.73072000", Longitude = "34.99293000" },
                        new() { Id = 3, Name = "Har Adar", Latitude = "31.82754000", Longitude = "35.13093000" },
                        new() { Id = 4, Name = "Jerusalem", Latitude = "31.76904000", Longitude = "35.21633000" },
                        new() { Id = 5, Name = "Mevasseret Ẕiyyon", Latitude = "31.80186000", Longitude = "35.15072000" },
                        new() { Id = 6, Name = "Modiin Ilit", Latitude = "31.93221000", Longitude = "35.04416000" },
                        new() { Id = 7, Name = "West Jerusalem", Latitude = "31.78199000", Longitude = "35.21961000" },
                        new() { Id = 8, Name = "Ẕur Hadassa", Latitude = "31.71912000", Longitude = "35.09708000" }
                    }
                },

                new()
                {
                    Id = 4,
                    Name = "Northern",
                    StateCode = "Z",
                    Latitude = "36.15118640",
                    Longitude = "-95.99517630",
                    Type = "district",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "‘Eilabun", Latitude = "32.83693000", Longitude = "35.40029000" },
                        new() { Id = 2, Name = "‘Uzeir", Latitude = "32.79212000", Longitude = "35.32984000" },
                        new() { Id = 3, Name = "Acre", Latitude = "32.92814000", Longitude = "35.07647000" },
                        new() { Id = 4, Name = "Afula", Latitude = "32.60907000", Longitude = "35.28920000" },
                        new() { Id = 5, Name = "Basmat Ṭab‘ūn", Latitude = "32.73898000", Longitude = "35.15716000" },
                        new() { Id = 6, Name = "Beit Jann", Latitude = "32.96464000", Longitude = "35.38152000" },
                        new() { Id = 7, Name = "Bet She’an", Latitude = "32.49728000", Longitude = "35.49632000" },
                        new() { Id = 8, Name = "Bīr el Maksūr", Latitude = "32.77732000", Longitude = "35.22069000" },
                        new() { Id = 9, Name = "Bu‘eina", Latitude = "32.80636000", Longitude = "35.36486000" },
                        new() { Id = 10, Name = "Buqei‘a", Latitude = "32.97747000", Longitude = "35.33345000" },
                        new() { Id = 11, Name = "Dabbūrīya", Latitude = "32.69256000", Longitude = "35.37123000" },
                        new() { Id = 12, Name = "Deir Ḥannā", Latitude = "32.86196000", Longitude = "35.36365000" },
                        new() { Id = 13, Name = "El Mazra‘a", Latitude = "32.98338000", Longitude = "35.09837000" },
                        new() { Id = 14, Name = "Er Reina", Latitude = "32.72339000", Longitude = "35.31622000" },
                        new() { Id = 15, Name = "Esh Sheikh Dannūn", Latitude = "32.99410000", Longitude = "35.14805000" },
                        new() { Id = 16, Name = "Ḥurfeish", Latitude = "33.01711000", Longitude = "35.34835000" },
                        new() { Id = 17, Name = "Iksāl", Latitude = "32.68164000", Longitude = "35.32365000" },
                        new() { Id = 18, Name = "Jīsh", Latitude = "33.02216000", Longitude = "35.44694000" },
                        new() { Id = 19, Name = "Judeida Makr", Latitude = "32.92820000", Longitude = "35.15705000" },
                        new() { Id = 20, Name = "Kābūl", Latitude = "32.86856000", Longitude = "35.21171000" },
                        new() { Id = 21, Name = "Kafr Kammā", Latitude = "32.72129000", Longitude = "35.44122000" },
                        new() { Id = 22, Name = "Kafr Kannā", Latitude = "32.74660000", Longitude = "35.34242000" },
                        new() { Id = 23, Name = "Kafr Mandā", Latitude = "32.81034000", Longitude = "35.26009000" },
                        new() { Id = 24, Name = "Kafr Miṣr", Latitude = "32.64521000", Longitude = "35.42147000" },
                        new() { Id = 25, Name = "Karmi’el", Latitude = "32.91708000", Longitude = "35.30501000" },
                        new() { Id = 26, Name = "Kaukab Abū el Hījā", Latitude = "32.83155000", Longitude = "35.24848000" },
                        new() { Id = 27, Name = "Kefar Rosh HaNiqra", Latitude = "33.08607000", Longitude = "35.11348000" },
                        new() { Id = 28, Name = "Kefar Tavor", Latitude = "32.68655000", Longitude = "35.42118000" },
                        new() { Id = 29, Name = "Kefar Weradim", Latitude = "32.99385000", Longitude = "35.27793000" },
                        new() { Id = 30, Name = "Kfar Yasif", Latitude = "32.95451000", Longitude = "35.16230000" },
                        new() { Id = 31, Name = "maalot Tarshīhā", Latitude = "33.01667000", Longitude = "35.26667000" },
                        new() { Id = 32, Name = "Maghār", Latitude = "32.88984000", Longitude = "35.40703000" },
                        new() { Id = 33, Name = "Metulla", Latitude = "33.27918000", Longitude = "35.57950000" },
                        new() { Id = 34, Name = "Mi‘ilyā", Latitude = "33.02781000", Longitude = "35.25658000" },
                        new() { Id = 35, Name = "Migdal Ha‘Emeq", Latitude = "32.67597000", Longitude = "35.23986000" },
                        new() { Id = 36, Name = "Nahariyya", Latitude = "33.00892000", Longitude = "35.09814000" },
                        new() { Id = 37, Name = "Naḥf", Latitude = "32.93444000", Longitude = "35.31679000" },
                        new() { Id = 38, Name = "Nazareth", Latitude = "32.70056000", Longitude = "35.29722000" },
                        new() { Id = 39, Name = "Nefat ‘Akko", Latitude = "32.95000000", Longitude = "35.23333000" },
                        new() { Id = 40, Name = "Nein", Latitude = "32.63063000", Longitude = "35.34885000" },
                        new() { Id = 41, Name = "Pasuta", Latitude = "33.04895000", Longitude = "35.30893000" },
                        new() { Id = 42, Name = "Qiryat Shemona", Latitude = "33.20733000", Longitude = "35.57212000" },
                        new() { Id = 43, Name = "Ramat Yishay", Latitude = "32.70444000", Longitude = "35.17070000" },
                        new() { Id = 44, Name = "Rosh Pinna", Latitude = "32.96894000", Longitude = "35.54258000" },
                        new() { Id = 45, Name = "Rumat Heib", Latitude = "32.77802000", Longitude = "35.30571000" },
                        new() { Id = 46, Name = "Safed", Latitude = "32.96465000", Longitude = "35.49600000" },
                        new() { Id = 47, Name = "Sājūr", Latitude = "32.94266000", Longitude = "35.34136000" },
                        new() { Id = 48, Name = "Sakhnīn", Latitude = "32.86422000", Longitude = "35.29707000" },
                        new() { Id = 49, Name = "Sallama", Latitude = "32.89443000", Longitude = "35.36931000" },
                        new() { Id = 50, Name = "Shelomi", Latitude = "33.07216000", Longitude = "35.14452000" },
                        new() { Id = 51, Name = "Shibli", Latitude = "32.69464000", Longitude = "35.39252000" },
                        new() { Id = 52, Name = "Sūlam", Latitude = "32.60606000", Longitude = "35.33408000" },
                        new() { Id = 53, Name = "Tamra", Latitude = "32.85301000", Longitude = "35.19870000" },
                        new() { Id = 54, Name = "Tiberias", Latitude = "32.79221000", Longitude = "35.53124000" },
                        new() { Id = 55, Name = "Timrat", Latitude = "32.70302000", Longitude = "35.22359000" },
                        new() { Id = 56, Name = "Yavne’el", Latitude = "32.70619000", Longitude = "35.50435000" }
                    }
                },

                new()
                {
                    Id = 5,
                    Name = "Southern",
                    StateCode = "D",
                    Latitude = "40.71375860",
                    Longitude = "-74.00090590",
                    Type = "district",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "‘En Boqeq", Latitude = "31.19941000", Longitude = "35.36253000" },
                        new() { Id = 2, Name = "Arad", Latitude = "31.25882000", Longitude = "35.21282000" },
                        new() { Id = 3, Name = "Ashdod", Latitude = "31.79213000", Longitude = "34.64966000" },
                        new() { Id = 4, Name = "Ashkelon", Latitude = "31.66926000", Longitude = "34.57149000" },
                        new() { Id = 5, Name = "Beersheba", Latitude = "31.25181000", Longitude = "34.79130000" },
                        new() { Id = 6, Name = "Dimona", Latitude = "31.07079000", Longitude = "35.03269000" },
                        new() { Id = 7, Name = "Eilat", Latitude = "29.55805000", Longitude = "34.94821000" },
                        new() { Id = 8, Name = "Lehavim", Latitude = "31.37284000", Longitude = "34.81619000" },
                        new() { Id = 9, Name = "Midreshet Ben-Gurion", Latitude = "30.85154000", Longitude = "34.78340000" },
                        new() { Id = 10, Name = "Mitzpe Ramon", Latitude = "30.60944000", Longitude = "34.80111000" },
                        new() { Id = 11, Name = "Netivot", Latitude = "31.42305000", Longitude = "34.58911000" },
                        new() { Id = 12, Name = "Ofaqim", Latitude = "31.31410000", Longitude = "34.62025000" },
                        new() { Id = 13, Name = "Qiryat Gat", Latitude = "31.60998000", Longitude = "34.76422000" },
                        new() { Id = 14, Name = "Rahat", Latitude = "31.39547000", Longitude = "34.75699000" },
                        new() { Id = 15, Name = "Sederot", Latitude = "31.52500000", Longitude = "34.59693000" },
                        new() { Id = 16, Name = "Yeroẖam", Latitude = "30.98822000", Longitude = "34.93176000" }
                    }
                },

                new()
                {
                    Id = 6,
                    Name = "Tel Aviv",
                    StateCode = "TA",
                    Latitude = "32.09290750",
                    Longitude = "34.80721650",
                    Type = "district",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Azor", Latitude = "32.02430000", Longitude = "34.80632000" },
                        new() { Id = 2, Name = "Bat Yam", Latitude = "32.02379000", Longitude = "34.75185000" },
                        new() { Id = 3, Name = "Bnei Brak", Latitude = "32.08074000", Longitude = "34.83380000" },
                        new() { Id = 4, Name = "Giv'at Shmuel", Latitude = "32.07817000", Longitude = "34.84858000" },
                        new() { Id = 5, Name = "Givatayim", Latitude = "32.07225000", Longitude = "34.81253000" },
                        new() { Id = 6, Name = "Herzliya", Latitude = "32.16627000", Longitude = "34.82536000" },
                        new() { Id = 7, Name = "Herzliya Pituah", Latitude = "32.17409000", Longitude = "34.80280000" },
                        new() { Id = 8, Name = "H̱olon", Latitude = "32.01034000", Longitude = "34.77918000" },
                        new() { Id = 9, Name = "Jaffa", Latitude = "32.05043000", Longitude = "34.75224000" },
                        new() { Id = 10, Name = "Kefar Shemaryahu", Latitude = "32.18529000", Longitude = "34.82082000" },
                        new() { Id = 11, Name = "Or Yehuda", Latitude = "32.02923000", Longitude = "34.85788000" },
                        new() { Id = 12, Name = "Ramat Gan", Latitude = "32.08227000", Longitude = "34.81065000" },
                        new() { Id = 13, Name = "Ramat HaSharon", Latitude = "32.14613000", Longitude = "34.83940000" },
                        new() { Id = 14, Name = "Tel Aviv", Latitude = "32.08088000", Longitude = "34.78057000" },
                        new() { Id = 15, Name = "Yehud-Monosson", Latitude = "32.02840000", Longitude = "34.87960000" }
                    }
                }
            }
        };
    }
}
