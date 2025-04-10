// ⚠️ WARNING: This file is automatically generated by scripts/generate-world.ps1
// DO NOT modify this file manually as it will be overwritten when the script is run again.
// To update the data, modify the source data in countries-states-cities-database and run the script.

using System.Collections.Generic;
using ShowsOnSale.World.Models;

namespace ShowsOnSale.World.Data.Countries
{
    public static class NewZealand
    {
        public static Country Data { get; } = new()
        {
            Id = 155,
            Name = "New Zealand",
            Iso3 = "NZL",
            Iso2 = "NZ",
            NumericCode = "554",
            PhoneCode = "64",
            Capital = "Wellington",
            Currency = "NZD",
            CurrencyName = "New Zealand dollar",
            CurrencySymbol = "$",
            Tld = ".nz",
            Native = "New Zealand",
            Region = "Oceania",
            RegionId = 5,
            Subregion = "Australia and New Zealand",
            SubregionId = 19,
            Nationality = "New Zealand, NZ",
            Latitude = "-41.00000000",
            Longitude = "174.00000000",
            Emoji = "🇳🇿",
            EmojiU = "U+1F1F3 U+1F1FF",
            Timezones = new()
            {
                new() { ZoneName = "Pacific/Auckland", GmtOffset = 46800, GmtOffsetName = "UTC+13:00", Abbreviation = "NZDT", TzName = "New Zealand Daylight Time" },
                new() { ZoneName = "Pacific/Chatham", GmtOffset = 49500, GmtOffsetName = "UTC+13:45", Abbreviation = "CHAST", TzName = "Chatham Standard Time" }
            },
            Translations = new()
            {
                { "ko" = "뉴질랜드" },
                { "pt-BR" = "Nova Zelândia" }
                { "pt" = "Nova Zelândia" }
                { "nl" = "Nieuw-Zeeland" }
                { "hr" = "Novi Zeland" }
                { "fa" = "نیوزیلند" }
                { "de" = "Neuseeland" }
                { "es" = "Nueva Zelanda" }
                { "fr" = "Nouvelle-Zélande" }
                { "ja" = "ニュージーランド" }
                { "it" = "Nuova Zelanda" }
                { "zh-CN" = "新西兰" }
                { "tr" = "Yeni Zelanda" }
                { "ru" = "Новая Зеландия" }
                { "uk" = "Нова Зеландія" }
                { "pl" = "Nowa Zelandia" }
            },
            States = new()
            {

                new()
                {
                    Id = 1,
                    Name = "Auckland",
                    StateCode = "AUK",
                    Latitude = "-36.66753280",
                    Longitude = "174.77333250",
                    Type = "region",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Auckland", Latitude = "-36.84853000", Longitude = "174.76349000" },
                        new() { Id = 2, Name = "Mangere", Latitude = "-36.96807000", Longitude = "174.79875000" },
                        new() { Id = 3, Name = "Manukau City", Latitude = "-36.99282000", Longitude = "174.87986000" },
                        new() { Id = 4, Name = "Muriwai Beach", Latitude = "-36.81667000", Longitude = "174.45000000" },
                        new() { Id = 5, Name = "Murrays Bay", Latitude = "-36.72819000", Longitude = "174.75019000" },
                        new() { Id = 6, Name = "North Shore", Latitude = "-36.80000000", Longitude = "174.75000000" },
                        new() { Id = 7, Name = "Pakuranga", Latitude = "-36.88333000", Longitude = "174.91667000" },
                        new() { Id = 8, Name = "Papakura", Latitude = "-37.06573000", Longitude = "174.94393000" },
                        new() { Id = 9, Name = "Parakai", Latitude = "-36.65000000", Longitude = "174.43333000" },
                        new() { Id = 10, Name = "Pukekohe East", Latitude = "-37.20000000", Longitude = "174.95000000" },
                        new() { Id = 11, Name = "Red Hill", Latitude = "-37.05820000", Longitude = "174.97019000" },
                        new() { Id = 12, Name = "Rosebank", Latitude = "-36.87495000", Longitude = "174.66991000" },
                        new() { Id = 13, Name = "Rothesay Bay", Latitude = "-36.72602000", Longitude = "174.74064000" },
                        new() { Id = 14, Name = "Takanini", Latitude = "-37.04820000", Longitude = "174.90019000" },
                        new() { Id = 15, Name = "Tamaki", Latitude = "-36.88820000", Longitude = "174.86019000" },
                        new() { Id = 16, Name = "Titirangi", Latitude = "-36.93754000", Longitude = "174.65584000" },
                        new() { Id = 17, Name = "Waitakere", Latitude = "-36.91754000", Longitude = "174.65773000" },
                        new() { Id = 18, Name = "Waiuku", Latitude = "-37.24806000", Longitude = "174.73489000" },
                        new() { Id = 19, Name = "Warkworth", Latitude = "-36.40000000", Longitude = "174.66667000" },
                        new() { Id = 20, Name = "Wellsford", Latitude = "-36.28333000", Longitude = "174.51667000" },
                        new() { Id = 21, Name = "Wiri", Latitude = "-36.99820000", Longitude = "174.86019000" }
                    }
                },

                new()
                {
                    Id = 2,
                    Name = "Bay of Plenty",
                    StateCode = "BOP",
                    Latitude = "-37.42339170",
                    Longitude = "176.74163740",
                    Type = "region",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Edgecumbe", Latitude = "-37.98333000", Longitude = "176.83333000" },
                        new() { Id = 2, Name = "Katikati", Latitude = "-37.55000000", Longitude = "175.91667000" },
                        new() { Id = 3, Name = "Kawerau", Latitude = "-38.10000000", Longitude = "176.70000000" },
                        new() { Id = 4, Name = "Maketu", Latitude = "-37.76667000", Longitude = "176.45000000" },
                        new() { Id = 5, Name = "Murupara", Latitude = "-38.46667000", Longitude = "176.70000000" },
                        new() { Id = 6, Name = "Opotiki", Latitude = "-38.00915000", Longitude = "177.28706000" },
                        new() { Id = 7, Name = "Rotorua", Latitude = "-38.13874000", Longitude = "176.24516000" },
                        new() { Id = 8, Name = "Tauranga", Latitude = "-37.68611000", Longitude = "176.16667000" },
                        new() { Id = 9, Name = "Waihi Beach", Latitude = "-37.40000000", Longitude = "175.93333000" },
                        new() { Id = 10, Name = "Whakatane", Latitude = "-37.95855000", Longitude = "176.98545000" }
                    }
                }

                new()
                {
                    Id = 3,
                    Name = "Canterbury",
                    StateCode = "CAN",
                    Latitude = "-43.75422750",
                    Longitude = "171.16372450",
                    Type = "region",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Amberley", Latitude = "-43.15589000", Longitude = "172.72975000" },
                        new() { Id = 2, Name = "Ashburton", Latitude = "-43.89834000", Longitude = "171.73011000" },
                        new() { Id = 3, Name = "Ashburton District", Latitude = "-43.90000000", Longitude = "171.75000000" },
                        new() { Id = 4, Name = "Burnham", Latitude = "-43.61667000", Longitude = "172.31667000" },
                        new() { Id = 5, Name = "Christchurch", Latitude = "-43.53333000", Longitude = "172.63333000" },
                        new() { Id = 6, Name = "Christchurch City", Latitude = "-43.64578000", Longitude = "172.74586000" },
                        new() { Id = 7, Name = "Darfield", Latitude = "-43.48333000", Longitude = "172.11667000" },
                        new() { Id = 8, Name = "Geraldine", Latitude = "-44.09061000", Longitude = "171.24458000" },
                        new() { Id = 9, Name = "Kaiapoi", Latitude = "-43.37832000", Longitude = "172.64013000" },
                        new() { Id = 10, Name = "Leeston", Latitude = "-43.76667000", Longitude = "172.30000000" },
                        new() { Id = 11, Name = "Lincoln", Latitude = "-43.65000000", Longitude = "172.48333000" },
                        new() { Id = 12, Name = "Mackenzie District", Latitude = "-43.93987000", Longitude = "170.51913000" },
                        new() { Id = 13, Name = "Methven", Latitude = "-43.63333000", Longitude = "171.65000000" },
                        new() { Id = 14, Name = "Oxford", Latitude = "-43.30000000", Longitude = "172.18333000" },
                        new() { Id = 15, Name = "Pleasant Point", Latitude = "-44.26667000", Longitude = "171.13333000" },
                        new() { Id = 16, Name = "Prebbleton", Latitude = "-43.58333000", Longitude = "172.51667000" },
                        new() { Id = 17, Name = "Rakaia", Latitude = "-43.75000000", Longitude = "172.01667000" },
                        new() { Id = 18, Name = "Rolleston", Latitude = "-43.58333000", Longitude = "172.38333000" },
                        new() { Id = 19, Name = "Selwyn District", Latitude = "-43.32226000", Longitude = "171.87064000" },
                        new() { Id = 20, Name = "Timaru", Latitude = "-44.39672000", Longitude = "171.25364000" },
                        new() { Id = 21, Name = "Timaru District", Latitude = "-44.40000000", Longitude = "171.21667000" },
                        new() { Id = 22, Name = "Tinwald", Latitude = "-43.91667000", Longitude = "171.71667000" },
                        new() { Id = 23, Name = "Waimakariri District", Latitude = "-43.20750000", Longitude = "172.33286000" },
                        new() { Id = 24, Name = "Woodend", Latitude = "-43.31667000", Longitude = "172.66667000" }
                    }
                }

                new()
                {
                    Id = 4,
                    Name = "Chatham Islands",
                    StateCode = "CIT",
                    Latitude = "-44.00575230",
                    Longitude = "-176.54006740",
                    Type = "special island authority",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Waitangi", Latitude = "-43.95353000", Longitude = "-176.55973000" }
                    }
                }

                new()
                {
                    Id = 5,
                    Name = "Gisborne",
                    StateCode = "GIS",
                    Latitude = "-38.13581740",
                    Longitude = "178.32393090",
                    Type = "region",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Gisborne", Latitude = "-38.65333000", Longitude = "178.00417000" }
                    }
                }

                new()
                {
                    Id = 6,
                    Name = "Hawke's Bay",
                    StateCode = "HKB",
                    Latitude = "-39.60165970",
                    Longitude = "176.58044730",
                    Type = "region",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Hastings", Latitude = "-39.63810000", Longitude = "176.84918000" },
                        new() { Id = 2, Name = "Napier", Latitude = "-39.49260000", Longitude = "176.91233000" },
                        new() { Id = 3, Name = "Taradale", Latitude = "-39.53333000", Longitude = "176.85000000" },
                        new() { Id = 4, Name = "Wairoa", Latitude = "-39.03333000", Longitude = "177.36667000" }
                    }
                }

                new()
                {
                    Id = 7,
                    Name = "Manawatu-Wanganui",
                    StateCode = "MWT",
                    Latitude = "-39.72733560",
                    Longitude = "175.43755740",
                    Type = "region",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Bulls", Latitude = "-40.17487000", Longitude = "175.38463000" },
                        new() { Id = 2, Name = "Foxton", Latitude = "-40.46667000", Longitude = "175.30000000" },
                        new() { Id = 3, Name = "Horowhenua District", Latitude = "-40.57733000", Longitude = "175.38071000" },
                        new() { Id = 4, Name = "Levin", Latitude = "-40.63333000", Longitude = "175.27500000" },
                        new() { Id = 5, Name = "Manawatu District", Latitude = "-40.11979000", Longitude = "175.67426000" },
                        new() { Id = 6, Name = "Palmerston North", Latitude = "-40.35636000", Longitude = "175.61113000" },
                        new() { Id = 7, Name = "Waiouru", Latitude = "-39.47753000", Longitude = "175.66834000" },
                        new() { Id = 8, Name = "Wanganui", Latitude = "-39.93333000", Longitude = "175.05000000" }
                    }
                }

                new()
                {
                    Id = 8,
                    Name = "Marlborough",
                    StateCode = "MBH",
                    Latitude = "-41.59168830",
                    Longitude = "173.76240530",
                    Type = "region",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Blenheim", Latitude = "-41.51603000", Longitude = "173.95280000" },
                        new() { Id = 2, Name = "Picton", Latitude = "-41.29067000", Longitude = "174.00801000" }
                    }
                }

                new()
                {
                    Id = 9,
                    Name = "Nelson",
                    StateCode = "NSN",
                    Latitude = "-41.29853970",
                    Longitude = "173.24414910",
                    Type = "region",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Nelson", Latitude = "-41.27078000", Longitude = "173.28404000" }
                    }
                }

                new()
                {
                    Id = 10,
                    Name = "Northland",
                    StateCode = "NTL",
                    Latitude = "-35.41361720",
                    Longitude = "173.93208060",
                    Type = "region",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Ahipara", Latitude = "-35.16667000", Longitude = "173.16667000" },
                        new() { Id = 2, Name = "Dargaville", Latitude = "-35.93333000", Longitude = "173.88333000" },
                        new() { Id = 3, Name = "Far North District", Latitude = "-35.03359000", Longitude = "173.48841000" },
                        new() { Id = 4, Name = "Kaipara District", Latitude = "-35.99546000", Longitude = "174.04688000" },
                        new() { Id = 5, Name = "Kaitaia", Latitude = "-35.11485000", Longitude = "173.26366000" },
                        new() { Id = 6, Name = "Kawakawa", Latitude = "-35.38333000", Longitude = "174.06667000" },
                        new() { Id = 7, Name = "Kerikeri", Latitude = "-35.22676000", Longitude = "173.94739000" },
                        new() { Id = 8, Name = "Maungatapere", Latitude = "-35.75000000", Longitude = "174.20000000" },
                        new() { Id = 9, Name = "Moerewa", Latitude = "-35.38333000", Longitude = "174.03333000" },
                        new() { Id = 10, Name = "Ngunguru", Latitude = "-35.61667000", Longitude = "174.50000000" },
                        new() { Id = 11, Name = "Paihia", Latitude = "-35.28067000", Longitude = "174.09103000" },
                        new() { Id = 12, Name = "Ruakaka", Latitude = "-35.90818000", Longitude = "174.45019000" },
                        new() { Id = 13, Name = "Taipa", Latitude = "-34.99604000", Longitude = "173.46665000" },
                        new() { Id = 14, Name = "Waimate North", Latitude = "-35.31667000", Longitude = "173.88333000" },
                        new() { Id = 15, Name = "Whangarei", Latitude = "-35.73167000", Longitude = "174.32391000" }
                    }
                },

                new()
                {
                    Id = 11,
                    Name = "Otago",
                    StateCode = "OTA",
                    Latitude = "-45.47906710",
                    Longitude = "170.15475670",
                    Type = "region",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Arrowtown", Latitude = "-44.93837000", Longitude = "168.81007000" },
                        new() { Id = 2, Name = "Balclutha", Latitude = "-46.23389000", Longitude = "169.75000000" },
                        new() { Id = 3, Name = "Clutha District", Latitude = "-46.03883000", Longitude = "169.60617000" },
                        new() { Id = 4, Name = "Cromwell", Latitude = "-45.03837000", Longitude = "169.20008000" },
                        new() { Id = 5, Name = "Dunedin", Latitude = "-45.87416000", Longitude = "170.50361000" },
                        new() { Id = 6, Name = "Kingston", Latitude = "-45.33288000", Longitude = "168.71476000" },
                        new() { Id = 7, Name = "Milton", Latitude = "-46.12083000", Longitude = "169.96944000" },
                        new() { Id = 8, Name = "Oamaru", Latitude = "-45.09758000", Longitude = "170.97087000" },
                        new() { Id = 9, Name = "Papatowai", Latitude = "-46.56069000", Longitude = "169.47068000" },
                        new() { Id = 10, Name = "Portobello", Latitude = "-45.85000000", Longitude = "170.65000000" },
                        new() { Id = 11, Name = "Queenstown", Latitude = "-45.03023000", Longitude = "168.66271000" },
                        new() { Id = 12, Name = "Wanaka", Latitude = "-44.70000000", Longitude = "169.15000000" }
                    }
                },

                new()
                {
                    Id = 12,
                    Name = "Southland",
                    StateCode = "STL",
                    Latitude = "-45.84891590",
                    Longitude = "167.67553870",
                    Type = "region",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Bluff", Latitude = "-46.60000000", Longitude = "168.33333000" },
                        new() { Id = 2, Name = "Gore", Latitude = "-46.10282000", Longitude = "168.94357000" },
                        new() { Id = 3, Name = "Invercargill", Latitude = "-46.40000000", Longitude = "168.35000000" },
                        new() { Id = 4, Name = "Riverton", Latitude = "-46.35000000", Longitude = "168.01667000" },
                        new() { Id = 5, Name = "Southland District", Latitude = "-45.77256000", Longitude = "167.85266000" },
                        new() { Id = 6, Name = "Te Anau", Latitude = "-45.41667000", Longitude = "167.71667000" },
                        new() { Id = 7, Name = "Winton", Latitude = "-46.15000000", Longitude = "168.33333000" }
                    }
                },

                new()
                {
                    Id = 13,
                    Name = "Taranaki",
                    StateCode = "TKI",
                    Latitude = "-39.35381490",
                    Longitude = "174.43827210",
                    Type = "region",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Eltham", Latitude = "-39.42917000", Longitude = "174.30000000" },
                        new() { Id = 2, Name = "Hawera", Latitude = "-39.59167000", Longitude = "174.28333000" },
                        new() { Id = 3, Name = "New Plymouth", Latitude = "-39.06667000", Longitude = "174.08333000" },
                        new() { Id = 4, Name = "New Plymouth District", Latitude = "-39.05865000", Longitude = "174.10309000" },
                        new() { Id = 5, Name = "Opunake", Latitude = "-39.45556000", Longitude = "173.85833000" },
                        new() { Id = 6, Name = "Patea", Latitude = "-39.75833000", Longitude = "174.48333000" },
                        new() { Id = 7, Name = "South Taranaki District", Latitude = "-39.52156000", Longitude = "174.37160000" },
                        new() { Id = 8, Name = "Stratford", Latitude = "-39.32215170", Longitude = "174.26298160" },
                        new() { Id = 9, Name = "Waitara", Latitude = "-39.00158000", Longitude = "174.23836000" }
                    }
                },

                new()
                {
                    Id = 14,
                    Name = "Tasman",
                    StateCode = "TAS",
                    Latitude = "-41.45711840",
                    Longitude = "172.82097400",
                    Type = "region",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Brightwater", Latitude = "-41.38333000", Longitude = "173.11667000" },
                        new() { Id = 2, Name = "Mapua", Latitude = "-41.25000000", Longitude = "173.10000000" },
                        new() { Id = 3, Name = "Motueka", Latitude = "-41.13333000", Longitude = "173.01667000" },
                        new() { Id = 4, Name = "Richmond", Latitude = "-41.33333000", Longitude = "173.18333000" },
                        new() { Id = 5, Name = "Takaka", Latitude = "-40.85000000", Longitude = "172.80000000" },
                        new() { Id = 6, Name = "Wakefield", Latitude = "-41.40000000", Longitude = "173.05000000" }
                    }
                },

                new()
                {
                    Id = 15,
                    Name = "Waikato",
                    StateCode = "WKO",
                    Latitude = "-37.61908620",
                    Longitude = "175.02334600",
                    Type = "region",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Cambridge", Latitude = "-37.87822000", Longitude = "175.44020000" },
                        new() { Id = 2, Name = "Coromandel", Latitude = "-36.76110000", Longitude = "175.49634000" },
                        new() { Id = 3, Name = "Hamilton", Latitude = "-37.78333000", Longitude = "175.28333000" },
                        new() { Id = 4, Name = "Matamata", Latitude = "-37.81060000", Longitude = "175.76237000" },
                        new() { Id = 5, Name = "Ngaruawahia", Latitude = "-37.66738000", Longitude = "175.15554000" },
                        new() { Id = 6, Name = "Ngatea", Latitude = "-37.28333000", Longitude = "175.50000000" },
                        new() { Id = 7, Name = "Otorohanga", Latitude = "-38.18333000", Longitude = "175.20000000" },
                        new() { Id = 8, Name = "Paeroa", Latitude = "-37.36667000", Longitude = "175.66667000" },
                        new() { Id = 9, Name = "Raglan", Latitude = "-37.80000000", Longitude = "174.88333000" },
                        new() { Id = 10, Name = "South Waikato District", Latitude = "-38.16797000", Longitude = "175.88624000" },
                        new() { Id = 11, Name = "Tairua", Latitude = "-37.01667000", Longitude = "175.85000000" },
                        new() { Id = 12, Name = "Taupo", Latitude = "-38.68333000", Longitude = "176.08333000" },
                        new() { Id = 13, Name = "Te Kauwhata", Latitude = "-37.40000000", Longitude = "175.15000000" },
                        new() { Id = 14, Name = "Thames", Latitude = "-37.13832000", Longitude = "175.54011000" },
                        new() { Id = 15, Name = "Tokoroa", Latitude = "-38.23333000", Longitude = "175.86667000" },
                        new() { Id = 16, Name = "Turangi", Latitude = "-38.99037000", Longitude = "175.80837000" },
                        new() { Id = 17, Name = "Waihi", Latitude = "-37.38333000", Longitude = "175.83333000" },
                        new() { Id = 18, Name = "Whangamata", Latitude = "-37.20000000", Longitude = "175.86667000" },
                        new() { Id = 19, Name = "Whitianga", Latitude = "-36.83333000", Longitude = "175.70000000" }
                    }
                },

                new()
                {
                    Id = 16,
                    Name = "Wellington",
                    StateCode = "WGN",
                    Latitude = "-41.02993230",
                    Longitude = "175.43755740",
                    Type = "region",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Brooklyn", Latitude = "-41.30586000", Longitude = "174.76257000" },
                        new() { Id = 2, Name = "Castlepoint", Latitude = "-40.90000000", Longitude = "176.21667000" },
                        new() { Id = 3, Name = "Kapiti Coast District", Latitude = "-40.85682000", Longitude = "175.14690000" },
                        new() { Id = 4, Name = "Kelburn", Latitude = "-41.28333000", Longitude = "174.76667000" },
                        new() { Id = 5, Name = "Khandallah", Latitude = "-41.24500000", Longitude = "174.79422000" },
                        new() { Id = 6, Name = "Lower Hutt", Latitude = "-41.21667000", Longitude = "174.91667000" },
                        new() { Id = 7, Name = "Masterton", Latitude = "-40.95972000", Longitude = "175.65750000" },
                        new() { Id = 8, Name = "Otaki", Latitude = "-40.75833000", Longitude = "175.15000000" },
                        new() { Id = 9, Name = "Paraparaumu", Latitude = "-40.91667000", Longitude = "175.01667000" },
                        new() { Id = 10, Name = "Petone", Latitude = "-41.22827000", Longitude = "174.87019000" },
                        new() { Id = 11, Name = "Porirua", Latitude = "-41.13333000", Longitude = "174.85000000" },
                        new() { Id = 12, Name = "South Wairarapa District", Latitude = "-41.26731000", Longitude = "175.38442000" },
                        new() { Id = 13, Name = "Upper Hutt", Latitude = "-41.13827000", Longitude = "175.05020000" },
                        new() { Id = 14, Name = "Waipawa", Latitude = "-41.41222000", Longitude = "175.51528000" },
                        new() { Id = 15, Name = "Wellington", Latitude = "-41.28664000", Longitude = "174.77557000" },
                        new() { Id = 16, Name = "Wellington City", Latitude = "-41.25300000", Longitude = "174.75424000" }
                    }
                },

                new()
                {
                    Id = 17,
                    Name = "West Coast",
                    StateCode = "WTC",
                    Latitude = "62.41136340",
                    Longitude = "-149.07297140",
                    Type = "region",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Greymouth", Latitude = "-42.46667000", Longitude = "171.20000000" },
                        new() { Id = 2, Name = "Hokitika", Latitude = "-42.71667000", Longitude = "170.96667000" },
                        new() { Id = 3, Name = "Westport", Latitude = "-41.75262000", Longitude = "171.60370000" }
                    }
                }
            }
        };
    }
}
