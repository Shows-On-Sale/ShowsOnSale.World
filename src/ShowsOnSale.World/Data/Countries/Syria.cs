// ⚠️ WARNING: This file is automatically generated by scripts/generate-world.ps1
// DO NOT modify this file manually as it will be overwritten when the script is run again.
// To update the data, modify the source data in countries-states-cities-database and run the script.

using System.Collections.Generic;
using ShowsOnSale.World.Models;

namespace ShowsOnSale.World.Data.Countries
{
    public static class Syria
    {
        public static Country Data { get; } = new()
        {
            Id = 215,
            Name = "Syria",
            Iso3 = "SYR",
            Iso2 = "SY",
            NumericCode = "760",
            PhoneCode = "963",
            Capital = "Damascus",
            Currency = "SYP",
            CurrencyName = "Syrian pound",
            CurrencySymbol = "LS",
            Tld = ".sy",
            Native = "سوريا",
            Region = "Asia",
            RegionId = 3,
            Subregion = "Western Asia",
            SubregionId = 11,
            Nationality = "Syrian",
            Latitude = "35.00000000",
            Longitude = "38.00000000",
            Emoji = "🇸🇾",
            EmojiU = "U+1F1F8 U+1F1FE",
            Timezones = new()
            {
                new() { ZoneName = "Asia/Damascus", GmtOffset = 7200, GmtOffsetName = "UTC+02:00", Abbreviation = "EET", TzName = "Eastern European Time" }
            },
            Translations = new()
            {
                ["ko"] = "시리아",
                ["pt-BR"] = "Síria",
                ["pt"] = "Síria",
                ["nl"] = "Syrië",
                ["hr"] = "Sirija",
                ["fa"] = "سوریه",
                ["de"] = "Syrien",
                ["es"] = "Siria",
                ["fr"] = "Syrie",
                ["ja"] = "シリア・アラブ共和国",
                ["it"] = "Siria",
                ["zh-CN"] = "叙利亚",
                ["tr"] = "Suriye",
                ["ru"] = "Сирия",
                ["uk"] = "Сирія",
                ["pl"] = "Syria"
            },
            States = new()
            {

                new()
                {
                    Id = 1,
                    Name = "Al-Hasakah",
                    StateCode = "HA",
                    Latitude = "36.40551500",
                    Longitude = "40.79691490",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Ad Darbāsīyah", Latitude = "37.07279000", Longitude = "40.65199000" },
                        new() { Id = 2, Name = "Al Ḩasakah", Latitude = "36.50237000", Longitude = "40.74772000" },
                        new() { Id = 3, Name = "Al Mālikīyah", Latitude = "37.17701000", Longitude = "42.14006000" },
                        new() { Id = 4, Name = "Al Qāmishlī", Latitude = "37.05215000", Longitude = "41.23142000" },
                        new() { Id = 5, Name = "Al-Malikiyah District", Latitude = "36.94113000", Longitude = "41.90157000" },
                        new() { Id = 6, Name = "Amude", Latitude = "37.10417000", Longitude = "40.93000000" }
                    }
                },

                new()
                {
                    Id = 2,
                    Name = "Al-Raqqah",
                    StateCode = "RA",
                    Latitude = "35.95941060",
                    Longitude = "38.99810520",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Al-Thawrah District", Latitude = "35.79843000", Longitude = "38.34550000" },
                        new() { Id = 2, Name = "Ar Raqqah", Latitude = "35.95283000", Longitude = "39.00788000" },
                        new() { Id = 3, Name = "Ar-Raqqah District", Latitude = "35.87204000", Longitude = "39.04706000" },
                        new() { Id = 4, Name = "Ath Thawrah", Latitude = "35.83758000", Longitude = "38.54828000" },
                        new() { Id = 5, Name = "Tall Abyaḑ", Latitude = "36.69648000", Longitude = "38.95382000" },
                        new() { Id = 6, Name = "Tell Abyad District", Latitude = "36.48280000", Longitude = "39.21360000" }
                    }
                },

                new()
                {
                    Id = 3,
                    Name = "Aleppo",
                    StateCode = "HL",
                    Latitude = "36.22623930",
                    Longitude = "37.46813960",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "‘Afrīn", Latitude = "36.51194000", Longitude = "36.86954000" },
                        new() { Id = 2, Name = "‘Ayn al ‘Arab", Latitude = "36.89095000", Longitude = "38.35347000" },
                        new() { Id = 3, Name = "Afrin District", Latitude = "36.54891000", Longitude = "36.79295000" },
                        new() { Id = 4, Name = "Al Atārib", Latitude = "36.13907000", Longitude = "36.82504000" },
                        new() { Id = 5, Name = "Al Bāb", Latitude = "36.37051000", Longitude = "37.51570000" },
                        new() { Id = 6, Name = "Al-Bab District", Latitude = "36.30946000", Longitude = "37.53277000" },
                        new() { Id = 7, Name = "Aleppo", Latitude = "36.20124000", Longitude = "37.16117000" },
                        new() { Id = 8, Name = "As Safīrah", Latitude = "36.07696000", Longitude = "37.37251000" },
                        new() { Id = 9, Name = "Azaz District", Latitude = "36.49986000", Longitude = "37.18382000" },
                        new() { Id = 10, Name = "Dayr Ḩāfir", Latitude = "36.15694000", Longitude = "37.70778000" },
                        new() { Id = 11, Name = "I‘zāz", Latitude = "36.58662000", Longitude = "37.04628000" },
                        new() { Id = 12, Name = "Jarābulus", Latitude = "36.81750000", Longitude = "38.01111000" },
                        new() { Id = 13, Name = "Kafr Şaghīr", Latitude = "36.29264000", Longitude = "37.25590000" },
                        new() { Id = 14, Name = "Khanāşir", Latitude = "35.78159000", Longitude = "37.49919000" },
                        new() { Id = 15, Name = "Manbij", Latitude = "36.52815000", Longitude = "37.95495000" },
                        new() { Id = 16, Name = "Manbij District", Latitude = "36.06687000", Longitude = "37.91735000" },
                        new() { Id = 17, Name = "Mount Simeon District", Latitude = "35.99956000", Longitude = "37.08473000" },
                        new() { Id = 18, Name = "Nubl", Latitude = "36.37867000", Longitude = "36.99294000" },
                        new() { Id = 19, Name = "Şūrān", Latitude = "36.56579000", Longitude = "37.21270000" },
                        new() { Id = 20, Name = "Tādif", Latitude = "36.34814000", Longitude = "37.53090000" },
                        new() { Id = 21, Name = "Tall Rif‘at", Latitude = "36.47229000", Longitude = "37.09471000" }
                    }
                },

                new()
                {
                    Id = 4,
                    Name = "As-Suwayda",
                    StateCode = "SU",
                    Latitude = "32.79891560",
                    Longitude = "36.78195050",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "As-Suwayda", Latitude = "32.70896000", Longitude = "36.56951000" },
                        new() { Id = 2, Name = "As-Suwayda District", Latitude = "32.78127000", Longitude = "36.86502000" },
                        new() { Id = 3, Name = "Şalākhid", Latitude = "32.87271000", Longitude = "36.57271000" },
                        new() { Id = 4, Name = "Şalkhad", Latitude = "32.49200000", Longitude = "36.71114000" },
                        new() { Id = 5, Name = "Salkhad District", Latitude = "32.51779000", Longitude = "36.91954000" },
                        new() { Id = 6, Name = "Shahbā", Latitude = "32.85514000", Longitude = "36.62896000" },
                        new() { Id = 7, Name = "Shahba District", Latitude = "33.04282000", Longitude = "36.72034000" }
                    }
                },

                new()
                {
                    Id = 5,
                    Name = "Damascus",
                    StateCode = "DI",
                    Latitude = "33.51514440",
                    Longitude = "36.39313540",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Damascus", Latitude = "33.51020000", Longitude = "36.29128000" }
                    }
                },

                new()
                {
                    Id = 6,
                    Name = "Daraa",
                    StateCode = "DR",
                    Latitude = "32.92488130",
                    Longitude = "36.17626150",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Al Ḩarāk", Latitude = "32.74932000", Longitude = "36.30994000" },
                        new() { Id = 2, Name = "Al Muzayrīb", Latitude = "32.71084000", Longitude = "36.02751000" },
                        new() { Id = 3, Name = "Al-Sanamayn District", Latitude = "33.12559000", Longitude = "36.27540000" },
                        new() { Id = 4, Name = "Aş Şanamayn", Latitude = "33.07186000", Longitude = "36.18316000" },
                        new() { Id = 5, Name = "Ash Shaykh Miskīn", Latitude = "32.82944000", Longitude = "36.15933000" },
                        new() { Id = 6, Name = "Buşrá ash Shām", Latitude = "32.52013000", Longitude = "36.48256000" },
                        new() { Id = 7, Name = "Dar‘ā", Latitude = "32.61889000", Longitude = "36.10213000" },
                        new() { Id = 8, Name = "Ghabāghib", Latitude = "33.18235000", Longitude = "36.22534000" },
                        new() { Id = 9, Name = "Inkhil", Latitude = "33.01809000", Longitude = "36.12828000" },
                        new() { Id = 10, Name = "Izra District", Latitude = "32.90121000", Longitude = "36.16144000" },
                        new() { Id = 11, Name = "Izra‘", Latitude = "32.87060000", Longitude = "36.25453000" },
                        new() { Id = 12, Name = "Jāsim", Latitude = "32.99233000", Longitude = "36.06018000" },
                        new() { Id = 13, Name = "Nawá", Latitude = "32.89044000", Longitude = "36.03990000" },
                        new() { Id = 14, Name = "Ţafas", Latitude = "32.73709000", Longitude = "36.06654000" },
                        new() { Id = 15, Name = "Tasīl", Latitude = "32.83395000", Longitude = "35.96973000" }
                    }
                },

                new()
                {
                    Id = 7,
                    Name = "Deir ez-Zor",
                    StateCode = "DY",
                    Latitude = "35.28797980",
                    Longitude = "40.30886260",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Al Mayādīn", Latitude = "35.01982000", Longitude = "40.45154000" },
                        new() { Id = 2, Name = "Ālbū Kamāl", Latitude = "34.45226000", Longitude = "40.91854000" },
                        new() { Id = 3, Name = "Deir ez-Zor", Latitude = "35.33588000", Longitude = "40.14084000" },
                        new() { Id = 4, Name = "Hajīn", Latitude = "34.69508000", Longitude = "40.83138000" },
                        new() { Id = 5, Name = "Subaykhān", Latitude = "34.85305000", Longitude = "40.59987000" }
                    }
                },

                new()
                {
                    Id = 8,
                    Name = "Hama",
                    StateCode = "HM",
                    Latitude = "35.18878650",
                    Longitude = "37.21158290",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Al-Salamiyah District", Latitude = "35.14398000", Longitude = "37.59235000" },
                        new() { Id = 2, Name = "As Salamīyah", Latitude = "35.01127000", Longitude = "37.05324000" },
                        new() { Id = 3, Name = "As Suqaylibīyah", Latitude = "35.36674000", Longitude = "36.39359000" },
                        new() { Id = 4, Name = "Ḩalfāyā", Latitude = "35.26014000", Longitude = "36.60581000" },
                        new() { Id = 5, Name = "Hama District", Latitude = "35.28577000", Longitude = "37.12626000" },
                        new() { Id = 6, Name = "Ḩamāh", Latitude = "35.13179000", Longitude = "36.75783000" },
                        new() { Id = 7, Name = "Kafr Zaytā", Latitude = "35.37425000", Longitude = "36.60330000" },
                        new() { Id = 8, Name = "Maşyāf", Latitude = "35.06530000", Longitude = "36.34060000" },
                        new() { Id = 9, Name = "Masyaf District", Latitude = "35.10335000", Longitude = "36.33920000" },
                        new() { Id = 10, Name = "Mūrak", Latitude = "35.37615000", Longitude = "36.68970000" },
                        new() { Id = 11, Name = "Souran", Latitude = "35.29193000", Longitude = "36.74848000" },
                        new() { Id = 12, Name = "Tall Salḩab", Latitude = "35.25884000", Longitude = "36.38461000" },
                        new() { Id = 13, Name = "Ţayyibat al Imām", Latitude = "35.26592000", Longitude = "36.71219000" },
                        new() { Id = 14, Name = "Tremseh", Latitude = "35.27181000", Longitude = "36.50395000" }
                    }
                },

                new()
                {
                    Id = 9,
                    Name = "Homs",
                    StateCode = "HI",
                    Latitude = "34.25671230",
                    Longitude = "38.31657250",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Al Ghanţū", Latitude = "34.82202000", Longitude = "36.69613000" },
                        new() { Id = 2, Name = "Al Qaryatayn", Latitude = "34.22956000", Longitude = "37.24066000" },
                        new() { Id = 3, Name = "Al Quşayr", Latitude = "34.50780000", Longitude = "36.58029000" },
                        new() { Id = 4, Name = "Al-Rastan District", Latitude = "34.87100000", Longitude = "36.77245000" },
                        new() { Id = 5, Name = "Ar Rastan", Latitude = "34.92667000", Longitude = "36.73241000" },
                        new() { Id = 6, Name = "Hisya", Latitude = "34.41197000", Longitude = "36.75867000" },
                        new() { Id = 7, Name = "Homs", Latitude = "34.72682000", Longitude = "36.72339000" },
                        new() { Id = 8, Name = "Kafr Lāhā", Latitude = "34.89469000", Longitude = "36.49582000" },
                        new() { Id = 9, Name = "Mukharram al Fawqānī", Latitude = "34.81521000", Longitude = "37.08677000" },
                        new() { Id = 10, Name = "Şadad", Latitude = "34.31248000", Longitude = "36.92562000" },
                        new() { Id = 11, Name = "Tadmur", Latitude = "34.56240000", Longitude = "38.28402000" },
                        new() { Id = 12, Name = "Tadmur District", Latitude = "34.42401000", Longitude = "38.64580000" },
                        new() { Id = 13, Name = "Tallbīsah", Latitude = "34.84072000", Longitude = "36.73092000" },
                        new() { Id = 14, Name = "Tallkalakh", Latitude = "34.66842000", Longitude = "36.25995000" }
                    }
                },

                new()
                {
                    Id = 10,
                    Name = "Idlib",
                    StateCode = "ID",
                    Latitude = "35.82687980",
                    Longitude = "36.69572160",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Ad Dānā", Latitude = "36.21254000", Longitude = "36.76998000" },
                        new() { Id = 2, Name = "Arīḩā", Latitude = "35.81374000", Longitude = "36.60964000" },
                        new() { Id = 3, Name = "Armanāz", Latitude = "36.08363000", Longitude = "36.50310000" },
                        new() { Id = 4, Name = "Binnish", Latitude = "35.95664000", Longitude = "36.71380000" },
                        new() { Id = 5, Name = "Darkūsh", Latitude = "35.99180000", Longitude = "36.39361000" },
                        new() { Id = 6, Name = "Harem District", Latitude = "36.14014000", Longitude = "36.56535000" },
                        new() { Id = 7, Name = "Ḩārim", Latitude = "36.21176000", Longitude = "36.52078000" },
                        new() { Id = 8, Name = "Idlib", Latitude = "35.93062000", Longitude = "36.63393000" },
                        new() { Id = 9, Name = "Jisr al-Shughur District", Latitude = "35.87756000", Longitude = "36.32901000" },
                        new() { Id = 10, Name = "Jisr ash Shughūr", Latitude = "35.81418000", Longitude = "36.31983000" },
                        new() { Id = 11, Name = "Kafr Takhārīm", Latitude = "36.11680000", Longitude = "36.51522000" },
                        new() { Id = 12, Name = "Kafranbel", Latitude = "35.61376000", Longitude = "36.56449000" },
                        new() { Id = 13, Name = "Khān Shaykhūn", Latitude = "35.44208000", Longitude = "36.65095000" },
                        new() { Id = 14, Name = "Ma‘arratmişrīn", Latitude = "36.01152000", Longitude = "36.67183000" },
                        new() { Id = 15, Name = "Maarrat al-Nu'man District", Latitude = "35.53858000", Longitude = "36.79193000" },
                        new() { Id = 16, Name = "Salqīn", Latitude = "36.13865000", Longitude = "36.45244000" },
                        new() { Id = 17, Name = "Sarāqib", Latitude = "35.86447000", Longitude = "36.80591000" },
                        new() { Id = 18, Name = "Sarmīn", Latitude = "35.90403000", Longitude = "36.72501000" },
                        new() { Id = 19, Name = "Taftanāz", Latitude = "35.99832000", Longitude = "36.78579000" }
                    }
                },

                new()
                {
                    Id = 11,
                    Name = "Latakia",
                    StateCode = "LA",
                    Latitude = "35.61297910",
                    Longitude = "36.00232250",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Al-Haffah District", Latitude = "35.59687000", Longitude = "36.11198000" },
                        new() { Id = 2, Name = "Jablah", Latitude = "35.36211000", Longitude = "35.92759000" },
                        new() { Id = 3, Name = "Jableh District", Latitude = "35.29048000", Longitude = "36.04490000" },
                        new() { Id = 4, Name = "Kassab", Latitude = "35.92639000", Longitude = "35.98970000" },
                        new() { Id = 5, Name = "Latakia", Latitude = "35.53168000", Longitude = "35.79011000" },
                        new() { Id = 6, Name = "Latakia District", Latitude = "35.72426000", Longitude = "35.94150000" },
                        new() { Id = 7, Name = "Qardaha District", Latitude = "35.39593000", Longitude = "36.08603000" },
                        new() { Id = 8, Name = "Şlinfah", Latitude = "35.59822000", Longitude = "36.18770000" }
                    }
                },

                new()
                {
                    Id = 12,
                    Name = "Quneitra",
                    StateCode = "QU",
                    Latitude = "33.07763180",
                    Longitude = "35.89341360",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Al Qunayţirah", Latitude = "33.12595000", Longitude = "35.82461000" }
                    }
                },

                new()
                {
                    Id = 13,
                    Name = "Rif Dimashq",
                    StateCode = "RD",
                    Latitude = "33.51672890",
                    Longitude = "36.95410700",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "‘Irbīn", Latitude = "33.53719000", Longitude = "36.36635000" },
                        new() { Id = 2, Name = "Al Kiswah", Latitude = "33.35810000", Longitude = "36.24190000" },
                        new() { Id = 3, Name = "Al Quţayfah", Latitude = "33.73848000", Longitude = "36.60071000" },
                        new() { Id = 4, Name = "Al-Zabadani District", Latitude = "33.70819000", Longitude = "36.11198000" },
                        new() { Id = 5, Name = "An Nabk", Latitude = "34.02403000", Longitude = "36.72848000" },
                        new() { Id = 6, Name = "At Tall", Latitude = "33.61033000", Longitude = "36.31070000" },
                        new() { Id = 7, Name = "Az Zabadānī", Latitude = "33.72488000", Longitude = "36.10050000" },
                        new() { Id = 8, Name = "Dārayyā", Latitude = "33.45835000", Longitude = "36.23256000" },
                        new() { Id = 9, Name = "Dayr al ‘Aşāfīr", Latitude = "33.46585000", Longitude = "36.42044000" },
                        new() { Id = 10, Name = "Douma", Latitude = "33.57175000", Longitude = "36.40270000" },
                        new() { Id = 11, Name = "Ḩarastā", Latitude = "33.55869000", Longitude = "36.36515000" },
                        new() { Id = 12, Name = "Jaramānā", Latitude = "33.48620000", Longitude = "36.34614000" },
                        new() { Id = 13, Name = "Jayrūd", Latitude = "33.80709000", Longitude = "36.73861000" },
                        new() { Id = 14, Name = "Ma‘lūlā", Latitude = "33.84529000", Longitude = "36.54514000" },
                        new() { Id = 15, Name = "Medaya", Latitude = "33.69032000", Longitude = "36.10354000" },
                        new() { Id = 16, Name = "Qārah", Latitude = "34.15558000", Longitude = "36.74284000" },
                        new() { Id = 17, Name = "Qaţanā", Latitude = "33.43757000", Longitude = "36.07888000" },
                        new() { Id = 18, Name = "Şaydnāyā", Latitude = "33.69473000", Longitude = "36.37146000" },
                        new() { Id = 19, Name = "Yabrūd", Latitude = "33.96921000", Longitude = "36.65729000" }
                    }
                },

                new()
                {
                    Id = 14,
                    Name = "Tartus",
                    StateCode = "TA",
                    Latitude = "35.00066520",
                    Longitude = "36.00232250",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Ad Duraykīsh", Latitude = "34.89514000", Longitude = "36.14303000" },
                        new() { Id = 2, Name = "Bāniyās", Latitude = "35.18188000", Longitude = "35.94871000" },
                        new() { Id = 3, Name = "Kaff al-Jaa", Latitude = "35.08638000", Longitude = "36.20605000" },
                        new() { Id = 4, Name = "Safita District", Latitude = "34.80419000", Longitude = "36.12293000" },
                        new() { Id = 5, Name = "Satita", Latitude = "34.82099000", Longitude = "36.11773000" },
                        new() { Id = 6, Name = "Tartouss", Latitude = "34.88902000", Longitude = "35.88659000" }
                    }
                }
            }
        };
    }
}
