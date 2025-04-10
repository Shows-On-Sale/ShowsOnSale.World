// ⚠️ WARNING: This file is automatically generated by scripts/generate-world.ps1
// DO NOT modify this file manually as it will be overwritten when the script is run again.
// To update the data, modify the source data in countries-states-cities-database and run the script.

using System.Collections.Generic;
using ShowsOnSale.World.Models;

namespace ShowsOnSale.World.Data.Countries
{
    public static class Cambodia
    {
        public static Country Data { get; } = new()
        {
            Id = 37,
            Name = "Cambodia",
            Iso3 = "KHM",
            Iso2 = "KH",
            NumericCode = "116",
            PhoneCode = "855",
            Capital = "Phnom Penh",
            Currency = "KHR",
            CurrencyName = "Cambodian riel",
            CurrencySymbol = "KHR",
            Tld = ".kh",
            Native = "Kâmpŭchéa",
            Region = "Asia",
            RegionId = 3,
            Subregion = "South-Eastern Asia",
            SubregionId = 13,
            Nationality = "Cambodian",
            Latitude = "13.00000000",
            Longitude = "105.00000000",
            Emoji = "🇰🇭",
            EmojiU = "U+1F1F0 U+1F1ED",
            Timezones = new()
            {
                new() { ZoneName = "Asia/Phnom_Penh", GmtOffset = 25200, GmtOffsetName = "UTC+07:00", Abbreviation = "ICT", TzName = "Indochina Time" }
            },
            Translations = new()
            {
                ["ko"] = "캄보디아",
                ["pt-BR"] = "Camboja",
                ["pt"] = "Camboja",
                ["nl"] = "Cambodja",
                ["hr"] = "Kambodža",
                ["fa"] = "کامبوج",
                ["de"] = "Kambodscha",
                ["es"] = "Camboya",
                ["fr"] = "Cambodge",
                ["ja"] = "カンボジア",
                ["it"] = "Cambogia",
                ["zh-CN"] = "柬埔寨",
                ["tr"] = "Kamboçya",
                ["ru"] = "Камбоджа",
                ["uk"] = "Камбоджа",
                ["pl"] = "Kambodża"
            },
            States = new()
            {

                new()
                {
                    Id = 1,
                    Name = "Banteay Meanchey",
                    StateCode = "1",
                    Latitude = "13.75319140",
                    Longitude = "102.98961500",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Mongkol Borei", Latitude = "13.45531000", Longitude = "102.99186000" },
                        new() { Id = 2, Name = "Paoy Paet", Latitude = "13.65805000", Longitude = "102.56365000" },
                        new() { Id = 3, Name = "Sisophon", Latitude = "13.58588000", Longitude = "102.97369000" },
                        new() { Id = 4, Name = "Srŏk Malai", Latitude = "13.49902000", Longitude = "102.60164000" },
                        new() { Id = 5, Name = "Srŏk Svay Chék", Latitude = "13.81305000", Longitude = "102.95269000" }
                    }
                },

                new()
                {
                    Id = 2,
                    Name = "Battambang",
                    StateCode = "2",
                    Latitude = "13.02869710",
                    Longitude = "102.98961500",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Battambang", Latitude = "13.10271000", Longitude = "103.19822000" },
                        new() { Id = 2, Name = "Srŏk Âk Phnŭm", Latitude = "13.23621000", Longitude = "103.45894000" },
                        new() { Id = 3, Name = "Srŏk Banăn", Latitude = "12.97067000", Longitude = "103.04742000" },
                        new() { Id = 4, Name = "Srŏk Bâvĭl", Latitude = "13.23601000", Longitude = "102.82910000" },
                        new() { Id = 5, Name = "Srŏk Rotanak Mondol", Latitude = "12.84048000", Longitude = "102.88700000" }
                    }
                },

                new()
                {
                    Id = 3,
                    Name = "Kampong Cham",
                    StateCode = "3",
                    Latitude = "12.09829180",
                    Longitude = "105.31311850",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Cheung Prey", Latitude = "12.10000000", Longitude = "105.07000000" },
                        new() { Id = 2, Name = "Kampong Cham", Latitude = "11.98000000", Longitude = "105.44500000" },
                        new() { Id = 3, Name = "Srŏk Bathéay", Latitude = "12.02986000", Longitude = "104.93171000" }
                    }
                },

                new()
                {
                    Id = 4,
                    Name = "Kampong Chhnang",
                    StateCode = "4",
                    Latitude = "12.13923520",
                    Longitude = "104.56552730",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Baribour", Latitude = "12.43000000", Longitude = "104.47000000" },
                        new() { Id = 2, Name = "Kampong Chhnang", Latitude = "12.26000000", Longitude = "104.67000000" },
                        new() { Id = 3, Name = "Rolea B'ier", Latitude = "12.21000000", Longitude = "104.61000000" },
                        new() { Id = 4, Name = "Srŏk Chol Kiri", Latitude = "12.15861000", Longitude = "104.82287000" },
                        new() { Id = 5, Name = "Srŏk Sameakki Mean Chey", Latitude = "11.86788000", Longitude = "104.55549000" }
                    }
                },

                new()
                {
                    Id = 5,
                    Name = "Kampong Speu",
                    StateCode = "5",
                    Latitude = "11.61551090",
                    Longitude = "104.37919120",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Kampong Speu", Latitude = "11.45332000", Longitude = "104.52085000" },
                        new() { Id = 2, Name = "Krŏng Chbar Mon", Latitude = "11.47091000", Longitude = "104.50655000" },
                        new() { Id = 3, Name = "Srŏk Basedth", Latitude = "11.18432000", Longitude = "104.53584000" },
                        new() { Id = 4, Name = "Srŏk Kông Pĭsei", Latitude = "11.31648000", Longitude = "104.65992000" },
                        new() { Id = 5, Name = "Srŏk Ŏdŏngk", Latitude = "11.66845000", Longitude = "104.61224000" }
                    }
                },

                new()
                {
                    Id = 6,
                    Name = "Kampong Thom",
                    StateCode = "6",
                    Latitude = "12.81674850",
                    Longitude = "103.84131040",
                    Type = "province",
                    Cities = new()
                    {
                    }
                },

                new()
                {
                    Id = 7,
                    Name = "Kampot",
                    StateCode = "7",
                    Latitude = "10.73253510",
                    Longitude = "104.37919120",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Angkor Chey", Latitude = "10.76667000", Longitude = "104.65000000" },
                        new() { Id = 2, Name = "Banteay Meas", Latitude = "10.61667000", Longitude = "104.53333000" },
                        new() { Id = 3, Name = "Chhouk District", Latitude = "10.81667000", Longitude = "104.45000000" },
                        new() { Id = 4, Name = "Kampong Bay", Latitude = "10.59554000", Longitude = "104.17136000" },
                        new() { Id = 5, Name = "Kampong Tranch", Latitude = "10.55000000", Longitude = "104.46667000" },
                        new() { Id = 6, Name = "Kampot", Latitude = "10.61041000", Longitude = "104.18145000" },
                        new() { Id = 7, Name = "Srŏk Chŭm Kiri", Latitude = "11.00540000", Longitude = "104.44207000" },
                        new() { Id = 8, Name = "Srŏk Dângtóng", Latitude = "10.70733000", Longitude = "104.42229000" },
                        new() { Id = 9, Name = "Srok Tuek Chhou", Latitude = "10.74557000", Longitude = "104.11013000" }
                    }
                },

                new()
                {
                    Id = 8,
                    Name = "Kandal",
                    StateCode = "8",
                    Latitude = "11.22373830",
                    Longitude = "105.12589550",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Krŏng Ta Khmau", Latitude = "11.45474000", Longitude = "104.94350000" },
                        new() { Id = 2, Name = "Srŏk Khsăch Kândal", Latitude = "11.69224000", Longitude = "105.03732000" },
                        new() { Id = 3, Name = "Ta Khmau", Latitude = "11.48333000", Longitude = "104.95000000" }
                    }
                },

                new()
                {
                    Id = 9,
                    Name = "Kep",
                    StateCode = "23",
                    Latitude = "10.53608900",
                    Longitude = "104.35591580",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Krong Kep", Latitude = "10.48291000", Longitude = "104.31672000" },
                        new() { Id = 2, Name = "Srŏk Dâmnăk Châng’aeur", Latitude = "10.53394000", Longitude = "104.34855000" }
                    }
                },

                new()
                {
                    Id = 10,
                    Name = "Koh Kong",
                    StateCode = "9",
                    Latitude = "11.57628040",
                    Longitude = "103.35872880",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Koh Kong", Latitude = "11.61531000", Longitude = "102.98380000" },
                        new() { Id = 2, Name = "Smach Mean Chey", Latitude = "11.54665000", Longitude = "103.03569000" },
                        new() { Id = 3, Name = "Srae Ambel", Latitude = "11.10968000", Longitude = "103.76226000" },
                        new() { Id = 4, Name = "Srŏk Batum Sakôr", Latitude = "11.11465000", Longitude = "103.38993000" },
                        new() { Id = 5, Name = "Srŏk Môndôl Seima", Latitude = "11.81292000", Longitude = "103.01159000" }
                    }
                },

                new()
                {
                    Id = 11,
                    Name = "Kratie",
                    StateCode = "10",
                    Latitude = "12.50436080",
                    Longitude = "105.96998780",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Kracheh", Latitude = "12.57000000", Longitude = "106.20000000" },
                        new() { Id = 2, Name = "Kratié", Latitude = "12.48811000", Longitude = "106.01879000" },
                        new() { Id = 3, Name = "Snuol", Latitude = "12.19373000", Longitude = "106.47361000" }
                    }
                },

                new()
                {
                    Id = 12,
                    Name = "Mondulkiri",
                    StateCode = "11",
                    Latitude = "12.78794270",
                    Longitude = "107.10119310",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Krŏng Sênmônoŭrôm", Latitude = "12.50480000", Longitude = "107.15525000" },
                        new() { Id = 2, Name = "Sen Monorom", Latitude = "12.45583000", Longitude = "107.18811000" },
                        new() { Id = 3, Name = "Srŏk Kaev Seima", Latitude = "12.41722000", Longitude = "106.77025000" },
                        new() { Id = 4, Name = "Srŏk Pech Chreada", Latitude = "12.72780000", Longitude = "107.09480000" }
                    }
                },

                new()
                {
                    Id = 13,
                    Name = "Oddar Meanchey",
                    StateCode = "22",
                    Latitude = "14.16097380",
                    Longitude = "103.82162610",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Samraong", Latitude = "14.18175000", Longitude = "103.51761000" },
                        new() { Id = 2, Name = "Srŏk Bântéay Âmpĭl", Latitude = "14.18590000", Longitude = "103.25925000" },
                        new() { Id = 3, Name = "Srŏk Sâmraông", Latitude = "14.25039000", Longitude = "103.62739000" },
                        new() { Id = 4, Name = "Srŏk Trâpeăng Prasat", Latitude = "14.25809000", Longitude = "104.30835000" }
                    }
                },

                new()
                {
                    Id = 14,
                    Name = "Pailin",
                    StateCode = "24",
                    Latitude = "12.90929620",
                    Longitude = "102.66755750",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Khan Sala Krau", Latitude = "12.97984000", Longitude = "102.63957000" },
                        new() { Id = 2, Name = "Pailin", Latitude = "12.84895000", Longitude = "102.60928000" }
                    }
                },

                new()
                {
                    Id = 15,
                    Name = "Phnom Penh",
                    StateCode = "12",
                    Latitude = "11.55637380",
                    Longitude = "104.92820990",
                    Type = "autonomous municipality",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Khan 7 Makara", Latitude = "11.56254000", Longitude = "104.91405000" },
                        new() { Id = 2, Name = "Khan Châmkar Mon", Latitude = "11.54390000", Longitude = "104.92175000" },
                        new() { Id = 3, Name = "Khan Dângkaô", Latitude = "11.52457000", Longitude = "104.83944000" },
                        new() { Id = 4, Name = "Khan Duŏn Pénh", Latitude = "11.57561000", Longitude = "104.92025000" },
                        new() { Id = 5, Name = "Khan Méan Chey", Latitude = "11.51976000", Longitude = "104.95467000" },
                        new() { Id = 6, Name = "Khan Russey Keo", Latitude = "11.61946000", Longitude = "104.90990000" },
                        new() { Id = 7, Name = "Khan Saen Sokh", Latitude = "11.61289000", Longitude = "104.86078000" },
                        new() { Id = 8, Name = "Phnom Penh", Latitude = "11.56245000", Longitude = "104.91601000" }
                    }
                },

                new()
                {
                    Id = 16,
                    Name = "Preah Vihear",
                    StateCode = "13",
                    Latitude = "14.00857970",
                    Longitude = "104.84546190",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Sangkom Thmei", Latitude = "13.47395000", Longitude = "104.77051000" },
                        new() { Id = 2, Name = "Srŏk Ch’êh Sên", Latitude = "13.58215000", Longitude = "105.34533000" },
                        new() { Id = 3, Name = "Srŏk Chhêb", Latitude = "13.91077000", Longitude = "105.46180000" },
                        new() { Id = 4, Name = "Srŏk Kulén", Latitude = "13.78597000", Longitude = "104.61052000" },
                        new() { Id = 5, Name = "Srŏk Rôviĕng", Latitude = "13.35105000", Longitude = "105.09956000" },
                        new() { Id = 6, Name = "Srŏk Tbêng Méanchey", Latitude = "13.78622000", Longitude = "105.01586000" },
                        new() { Id = 7, Name = "Tbeng Meanchey", Latitude = "13.80731000", Longitude = "104.98046000" }
                    }
                },

                new()
                {
                    Id = 17,
                    Name = "Prey Veng",
                    StateCode = "14",
                    Latitude = "11.38024420",
                    Longitude = "105.50054830",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Prey Veng", Latitude = "11.48682000", Longitude = "105.32533000" },
                        new() { Id = 2, Name = "Srŏk Kâmpóng Léav", Latitude = "11.50970000", Longitude = "105.30110000" },
                        new() { Id = 3, Name = "Srŏk Mésang", Latitude = "11.35528000", Longitude = "105.57235000" },
                        new() { Id = 4, Name = "Srŏk Preăh Sdéch", Latitude = "11.08690000", Longitude = "105.37497000" }
                    }
                },

                new()
                {
                    Id = 18,
                    Name = "Pursat",
                    StateCode = "15",
                    Latitude = "12.27209560",
                    Longitude = "103.72891670",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Bakan", Latitude = "12.78000000", Longitude = "103.79000000" },
                        new() { Id = 2, Name = "Krakor", Latitude = "12.48000000", Longitude = "104.19000000" },
                        new() { Id = 3, Name = "Pursat", Latitude = "12.53878000", Longitude = "103.91920000" },
                        new() { Id = 4, Name = "Sampov Meas", Latitude = "12.47055000", Longitude = "103.91817000" },
                        new() { Id = 5, Name = "Srŏk Kândiĕng", Latitude = "12.71245000", Longitude = "104.02592000" },
                        new() { Id = 6, Name = "Srŏk Véal Vêng", Latitude = "12.24230000", Longitude = "103.13444000" }
                    }
                },

                new()
                {
                    Id = 19,
                    Name = "Ratanakiri",
                    StateCode = "16",
                    Latitude = "13.85766070",
                    Longitude = "107.10119310",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Banlung", Latitude = "13.73939000", Longitude = "106.98727000" },
                        new() { Id = 2, Name = "Lumphat", Latitude = "13.49146000", Longitude = "106.98022000" },
                        new() { Id = 3, Name = "Srŏk Ândong Méas", Latitude = "13.93352000", Longitude = "107.31155000" },
                        new() { Id = 4, Name = "Srŏk Bâ Kêv", Latitude = "13.70749000", Longitude = "107.19442000" },
                        new() { Id = 5, Name = "Srŏk Ban Lŭng", Latitude = "13.68200000", Longitude = "107.03025000" },
                        new() { Id = 6, Name = "Srŏk Koun Mom", Latitude = "13.51772000", Longitude = "106.75142000" },
                        new() { Id = 7, Name = "Srŏk Ou Chum", Latitude = "13.84069000", Longitude = "107.03469000" },
                        new() { Id = 8, Name = "Srŏk Ou Ya Dav", Latitude = "13.54328000", Longitude = "107.44636000" },
                        new() { Id = 9, Name = "Srŏk Ta Vêng", Latitude = "14.29192000", Longitude = "107.24031000" }
                    }
                },

                new()
                {
                    Id = 20,
                    Name = "Siem Reap",
                    StateCode = "17",
                    Latitude = "13.33026600",
                    Longitude = "104.10013260",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Siem Reap", Latitude = "13.36179000", Longitude = "103.86056000" },
                        new() { Id = 2, Name = "Srŏk Ângkôr Thum", Latitude = "13.57881000", Longitude = "103.85645000" },
                        new() { Id = 3, Name = "Srŏk Prasat Bakong", Latitude = "13.21031000", Longitude = "103.97689000" },
                        new() { Id = 4, Name = "Svay Leu", Latitude = "13.69168000", Longitude = "104.27446000" },
                        new() { Id = 5, Name = "Varin", Latitude = "13.83574000", Longitude = "103.89968000" }
                    }
                },

                new()
                {
                    Id = 21,
                    Name = "Sihanoukville",
                    StateCode = "18",
                    Latitude = "10.75818990",
                    Longitude = "103.82162610",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Sihanoukville", Latitude = "10.60932000", Longitude = "103.52958000" },
                        new() { Id = 2, Name = "Srok Stueng Hav", Latitude = "10.85249000", Longitude = "103.74016000" }
                    }
                },

                new()
                {
                    Id = 22,
                    Name = "Stung Treng",
                    StateCode = "19",
                    Latitude = "13.57647300",
                    Longitude = "105.96998780",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Srŏk Srêsén", Latitude = "13.60530000", Longitude = "106.35819000" },
                        new() { Id = 2, Name = "Stueng Traeng", Latitude = "13.65000000", Longitude = "106.07000000" },
                        new() { Id = 3, Name = "Stung Treng", Latitude = "13.52586000", Longitude = "105.96830000" }
                    }
                },

                new()
                {
                    Id = 23,
                    Name = "Svay Rieng",
                    StateCode = "20",
                    Latitude = "11.14272200",
                    Longitude = "105.82902980",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Srŏk Svay Chrŭm", Latitude = "11.11160000", Longitude = "105.69814000" },
                        new() { Id = 2, Name = "Svay Rieng", Latitude = "11.08785000", Longitude = "105.79935000" }
                    }
                },

                new()
                {
                    Id = 24,
                    Name = "Takeo",
                    StateCode = "21",
                    Latitude = "10.93215190",
                    Longitude = "104.79877100",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Krŏng Doun Kaev", Latitude = "10.99459000", Longitude = "104.79550000" },
                        new() { Id = 2, Name = "Phumĭ Véal Srê", Latitude = "10.98081000", Longitude = "104.77828000" },
                        new() { Id = 3, Name = "Srŏk Ângkôr Borei", Latitude = "10.99291000", Longitude = "104.95177000" },
                        new() { Id = 4, Name = "Srŏk Borei Cholsar", Latitude = "10.81414000", Longitude = "104.98994000" },
                        new() { Id = 5, Name = "Takeo", Latitude = "10.99081000", Longitude = "104.78498000" }
                    }
                }
            }
        };
    }
}
