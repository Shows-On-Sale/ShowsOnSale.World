// ⚠️ WARNING: This file is automatically generated by scripts/generate-world.ps1
// DO NOT modify this file manually as it will be overwritten when the script is run again.
// To update the data, modify the source data in countries-states-cities-database and run the script.

using System.Collections.Generic;
using ShowsOnSale.World.Models;

namespace ShowsOnSale.World.Data.Countries
{
    public static class PalestinianTerritoryOccupied
    {
        public static Country Data { get; } = new()
        {
            Id = 168,
            Name = "Palestinian Territory Occupied",
            Iso3 = "PSE",
            Iso2 = "PS",
            NumericCode = "275",
            PhoneCode = "970",
            Capital = "East Jerusalem",
            Currency = "ILS",
            CurrencyName = "Israeli new shekel",
            CurrencySymbol = "₪",
            Tld = ".ps",
            Native = "فلسطين",
            Region = "Asia",
            RegionId = 3,
            Subregion = "Western Asia",
            SubregionId = 11,
            Nationality = "Palestinian",
            Latitude = "31.90000000",
            Longitude = "35.20000000",
            Emoji = "🇵🇸",
            EmojiU = "U+1F1F5 U+1F1F8",
            Timezones = new()
            {
                new() { ZoneName = "Asia/Gaza", GmtOffset = 7200, GmtOffsetName = "UTC+02:00", Abbreviation = "EET", TzName = "Eastern European Time" },
                new() { ZoneName = "Asia/Hebron", GmtOffset = 7200, GmtOffsetName = "UTC+02:00", Abbreviation = "EET", TzName = "Eastern European Time" }
            },
            Translations = new()
            {
                { "ko" = "팔레스타인 영토" },
                { "pt-BR" = "Palestina" }
                { "pt" = "Palestina" }
                { "nl" = "Palestijnse gebieden" }
                { "hr" = "Palestina" }
                { "fa" = "فلسطین" }
                { "de" = "Palästina" }
                { "es" = "Palestina" }
                { "fr" = "Palestine" }
                { "ja" = "パレスチナ" }
                { "it" = "Palestina" }
                { "zh-CN" = "巴勒斯坦" }
                { "tr" = "Filistin" }
                { "ru" = "Оккупированная палестинская территория" }
                { "uk" = "Окупована палестинська територія" }
                { "pl" = "Okupowane terytorium palestyńskie" }
            },
            States = new()
            {

                new()
                {
                    Id = 1,
                    Name = "Bethlehem",
                    StateCode = "BTH",
                    Latitude = "31.70539960",
                    Longitude = "35.19368770",
                    Type = "governorate",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Al-Dawha", Latitude = "31.69773990", Longitude = "35.14595450" },
                        new() { Id = 2, Name = "al-Khader", Latitude = "31.69484540", Longitude = "35.15014530" },
                        new() { Id = 3, Name = "al-Ubeidiya", Latitude = "31.72386430", Longitude = "35.27122130" },
                        new() { Id = 4, Name = "Battir", Latitude = "31.72821540", Longitude = "35.11743230" },
                        new() { Id = 5, Name = "Beit Fajjar", Latitude = "31.62166990", Longitude = "35.13430330" },
                        new() { Id = 6, Name = "Beit Jala", Latitude = "31.71603340", Longitude = "35.16654930" },
                        new() { Id = 7, Name = "Beit Sahour", Latitude = "31.69787040", Longitude = "35.20793030" },
                        new() { Id = 8, Name = "Bethlehem", Latitude = "31.70541650", Longitude = "35.18184280" },
                        new() { Id = 9, Name = "Husan", Latitude = "31.70846040", Longitude = "35.11282530" },
                        new() { Id = 10, Name = "Nahalin", Latitude = "31.68564240", Longitude = "35.09976230" },
                        new() { Id = 11, Name = "Tuqu'", Latitude = "31.63912740", Longitude = "35.19189030" },
                        new() { Id = 12, Name = "Za'atara", Latitude = "31.67447840", Longitude = "35.23449130" }
                    }
                },

                new()
                {
                    Id = 2,
                    Name = "Deir El Balah",
                    StateCode = "DEB",
                    Latitude = "31.42028970",
                    Longitude = "34.28616400",
                    Type = "governorate",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "az-Zawayda", Latitude = "31.42979750", Longitude = "34.35014230" },
                        new() { Id = 2, Name = "Deir al-Balah", Latitude = "31.41717350", Longitude = "34.33033130" }
                    }
                }

                new()
                {
                    Id = 3,
                    Name = "Gaza",
                    StateCode = "GZA",
                    Latitude = "31.48723970",
                    Longitude = "34.14998900",
                    Type = "governorate",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Al-Zahra", Latitude = "31.47246750", Longitude = "34.37782930" },
                        new() { Id = 2, Name = "Gaza City", Latitude = "31.50172950", Longitude = "34.44624480" }
                    }
                }

                new()
                {
                    Id = 4,
                    Name = "Hebron",
                    StateCode = "HBN",
                    Latitude = "31.53260010",
                    Longitude = "35.06394750",
                    Type = "governorate",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "ad-Dhahiriya", Latitude = "31.40967250", Longitude = "34.95490830" },
                        new() { Id = 2, Name = "as-Samu", Latitude = "31.39864450", Longitude = "35.04468830" },
                        new() { Id = 3, Name = "Bani Na'im", Latitude = "31.51490050", Longitude = "35.14474030" },
                        new() { Id = 4, Name = "Beit 'Awwa", Latitude = "31.50675240", Longitude = "34.92956130" },
                        new() { Id = 5, Name = "Beit Ula", Latitude = "31.59845640", Longitude = "35.00577530" },
                        new() { Id = 6, Name = "Beit Ummar", Latitude = "31.62284640", Longitude = "35.08159930" },
                        new() { Id = 7, Name = "Deir Sammit", Latitude = "31.51996340", Longitude = "34.95207130" },
                        new() { Id = 8, Name = "Dura", Latitude = "31.50512740", Longitude = "35.00692730" },
                        new() { Id = 9, Name = "Halhul", Latitude = "31.57992420", Longitude = "35.07930450" },
                        new() { Id = 10, Name = "Hebron", Latitude = "31.53260350", Longitude = "35.07922630" },
                        new() { Id = 11, Name = "Idhna", Latitude = "31.55728640", Longitude = "34.95864330" },
                        new() { Id = 12, Name = "Kharas", Latitude = "31.61225240", Longitude = "35.02365130" },
                        new() { Id = 13, Name = "Nuba", Latitude = "31.61382080", Longitude = "35.00579200" },
                        new() { Id = 14, Name = "Sa'ir", Latitude = "31.58248950", Longitude = "35.12317630" },
                        new() { Id = 15, Name = "Surif", Latitude = "31.64958640", Longitude = "35.04411230" },
                        new() { Id = 16, Name = "Taffuh", Latitude = "31.53848250", Longitude = "35.03037330" },
                        new() { Id = 17, Name = "Tarqumiya", Latitude = "31.57736440", Longitude = "34.99357430" },
                        new() { Id = 18, Name = "Yatta", Latitude = "31.44418450", Longitude = "35.06950530" }
                    }
                }

                new()
                {
                    Id = 5,
                    Name = "Jenin",
                    StateCode = "JEN",
                    Latitude = "32.42637610",
                    Longitude = "35.08568870",
                    Type = "governorate",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Ajjah", Latitude = "32.36001710", Longitude = "35.17739430" },
                        new() { Id = 2, Name = "al-Yamun", Latitude = "32.48671110", Longitude = "35.21299230" },
                        new() { Id = 3, Name = "Arrabah", Latitude = "32.40331010", Longitude = "35.18531430" },
                        new() { Id = 4, Name = "Burqin", Latitude = "32.45616900", Longitude = "35.24108830" },
                        new() { Id = 5, Name = "Deir Abu Da'if", Latitude = "32.45609510", Longitude = "35.34432230" },
                        new() { Id = 6, Name = "Jaba", Latitude = "32.32506110", Longitude = "35.19956430" },
                        new() { Id = 7, Name = "Jenin", Latitude = "32.45728400", Longitude = "35.28161440" },
                        new() { Id = 8, Name = "Kafr Dan", Latitude = "32.47801110", Longitude = "35.23318730" },
                        new() { Id = 9, Name = "Kafr Rai", Latitude = "32.37345210", Longitude = "35.13493630" },
                        new() { Id = 10, Name = "Meithalun", Latitude = "32.34924410", Longitude = "35.25088430" },
                        new() { Id = 11, Name = "Qabatiya", Latitude = "32.40961710", Longitude = "35.25949330" },
                        new() { Id = 12, Name = "Silat ad-Dhahr", Latitude = "32.31753210", Longitude = "35.16663230" },
                        new() { Id = 13, Name = "Silat al-Harithiya", Latitude = "32.50979700", Longitude = "35.20684730" },
                        new() { Id = 14, Name = "Ya'bad", Latitude = "32.44686800", Longitude = "35.14667430" },
                        new() { Id = 15, Name = "Zababdeh", Latitude = "32.38523610", Longitude = "35.30287930" }
                    }
                }

                new()
                {
                    Id = 6,
                    Name = "Jericho ",
                    StateCode = "JRH",
                    Latitude = "31.96764250",
                    Longitude = "35.13542790",
                    Type = "governorate",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "al-Auja", Latitude = "31.94809930", Longitude = "35.45056430" },
                        new() { Id = 2, Name = "al-Jiftlik", Latitude = "32.14143230", Longitude = "35.44660250" },
                        new() { Id = 3, Name = "Jericho", Latitude = "31.85950700", Longitude = "35.44390820" }
                    }
                }

                new()
                {
                    Id = 7,
                    Name = "Jerusalem (Quds)",
                    StateCode = "JEM",
                    Latitude = "31.80203280",
                    Longitude = "34.95996640",
                    Type = "governorate",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Abu Dis", Latitude = "31.76361630", Longitude = "35.23712230" },
                        new() { Id = 2, Name = "Ar-Ram", Latitude = "31.84928630", Longitude = "35.21288930" },
                        new() { Id = 3, Name = "Beit 'Anan", Latitude = "31.85109930", Longitude = "35.09111930" },
                        new() { Id = 4, Name = "Biddu", Latitude = "31.83445820", Longitude = "35.07441730" },
                        new() { Id = 5, Name = "Bir Nabala", Latitude = "31.85121630", Longitude = "35.18023530" },
                        new() { Id = 6, Name = "East Jerusalem", Latitude = "31.79650430", Longitude = "35.01054340" },
                        new() { Id = 7, Name = "Hizma", Latitude = "31.83649540", Longitude = "35.24263130" },
                        new() { Id = 8, Name = "Kafr Aqab", Latitude = "31.87472270", Longitude = "35.21724000" },
                        new() { Id = 9, Name = "Qalandiya", Latitude = "31.86163130", Longitude = "35.18731430" },
                        new() { Id = 10, Name = "Qatanna", Latitude = "31.82695730", Longitude = "35.08960030" }
                    }
                }

                new()
                {
                    Id = 8,
                    Name = "Khan Yunis",
                    StateCode = "KYS",
                    Latitude = "31.32987660",
                    Longitude = "34.22548330",
                    Type = "governorate",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Abasan al-Kabira", Latitude = "31.32316050", Longitude = "34.32342530" },
                        new() { Id = 2, Name = "Abasan al-Saghira", Latitude = "31.33974350", Longitude = "34.32603330" },
                        new() { Id = 3, Name = "Al-Qarara", Latitude = "31.37134650", Longitude = "34.31466030" },
                        new() { Id = 4, Name = "Bani Suheila", Latitude = "31.34213850", Longitude = "34.30465430" },
                        new() { Id = 5, Name = "Khan Yunis", Latitude = "31.34623510", Longitude = "34.28339890" },
                        new() { Id = 6, Name = "Khuzaʽa", Latitude = "31.30705660", Longitude = "34.33944730" }
                    }
                }

                new()
                {
                    Id = 9,
                    Name = "Nablus",
                    StateCode = "NBS",
                    Latitude = "32.22437550",
                    Longitude = "35.20647930",
                    Type = "governorate",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Aqraba", Latitude = "32.12762020", Longitude = "35.32213530" },
                        new() { Id = 2, Name = "Asira ash-Shamaliya", Latitude = "32.25186910", Longitude = "35.24757130" },
                        new() { Id = 3, Name = "Beit Furik", Latitude = "32.17549020", Longitude = "35.31588430" },
                        new() { Id = 4, Name = "Beita", Latitude = "32.14137420", Longitude = "35.26579930" },
                        new() { Id = 5, Name = "Huwara", Latitude = "32.15134720", Longitude = "35.23619930" },
                        new() { Id = 6, Name = "Jammain", Latitude = "32.13211420", Longitude = "35.18274230" },
                        new() { Id = 7, Name = "Nablus", Latitude = "32.22437550", Longitude = "35.20647930" },
                        new() { Id = 8, Name = "Qabalan", Latitude = "32.10185420", Longitude = "35.26712930" },
                        new() { Id = 9, Name = "Sebastia", Latitude = "32.27827510", Longitude = "35.17803330" }
                    }
                }

                new()
                {
                    Id = 10,
                    Name = "North Gaza",
                    StateCode = "NGZ",
                    Latitude = "31.54750600",
                    Longitude = "34.42814090",
                    Type = "governorate",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Beit Hanoun", Latitude = "31.53851740", Longitude = "34.51617030" },
                        new() { Id = 2, Name = "Beit Lahia", Latitude = "31.55132340", Longitude = "34.48862230" },
                        new() { Id = 3, Name = "Izbat Beit Hanoun", Latitude = "31.54728950", Longitude = "34.50197220" },
                        new() { Id = 4, Name = "Jabalia", Latitude = "31.52943050", Longitude = "34.45914130" }
                    }
                },

                new()
                {
                    Id = 11,
                    Name = "Qalqilya",
                    StateCode = "QQA",
                    Latitude = "32.18103230",
                    Longitude = "34.99369990",
                    Type = "governorate",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Azzun", Latitude = "32.17713520", Longitude = "35.03535730" },
                        new() { Id = 2, Name = "Hableh", Latitude = "32.16387820", Longitude = "34.95768030" },
                        new() { Id = 3, Name = "Kafr Thulth", Latitude = "32.15283320", Longitude = "35.02469030" },
                        new() { Id = 4, Name = "Qalqilya", Latitude = "32.19604910", Longitude = "34.96091330" }
                    }
                },

                new()
                {
                    Id = 12,
                    Name = "Rafah",
                    StateCode = "RFH",
                    Latitude = "31.29688990",
                    Longitude = "34.11166850",
                    Type = "governorate",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Al Qarya as Suwaydiya", Latitude = "31.32316550", Longitude = "34.20157530" },
                        new() { Id = 2, Name = "Al-Bayuk", Latitude = "31.26347860", Longitude = "34.26098130" },
                        new() { Id = 3, Name = "Al-Mawasi", Latitude = "31.34844960", Longitude = "34.23553630" },
                        new() { Id = 4, Name = "Rafah ", Latitude = "31.29681450", Longitude = "34.22288230" },
                        new() { Id = 5, Name = "Shokat as-Sufi", Latitude = "31.25091250", Longitude = "34.24516720" }
                    }
                },

                new()
                {
                    Id = 13,
                    Name = "Ramallah",
                    StateCode = "RBH",
                    Latitude = "31.94301450",
                    Longitude = "34.86456510",
                    Type = "governorate",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Al-Bireh", Latitude = "31.91259730", Longitude = "35.20111730" },
                        new() { Id = 2, Name = "al-Mazra'a ash-Sharqiya", Latitude = "32.00327220", Longitude = "35.25553230" },
                        new() { Id = 3, Name = "Bani Zeid al-Sharqiya", Latitude = "32.04074320", Longitude = "35.15327830" },
                        new() { Id = 4, Name = "Beit Liqya", Latitude = "31.86997130", Longitude = "35.04460230" },
                        new() { Id = 5, Name = "Beitunia", Latitude = "31.88931530", Longitude = "35.14921330" },
                        new() { Id = 6, Name = "Bir Zeit", Latitude = "31.97534830", Longitude = "35.17544230" },
                        new() { Id = 7, Name = "Deir Dibwan", Latitude = "31.91123930", Longitude = "35.24838830" },
                        new() { Id = 8, Name = "Deir Jarir", Latitude = "31.96564630", Longitude = "35.27317630" },
                        new() { Id = 9, Name = "Kharbatha al-Misbah", Latitude = "31.88530030", Longitude = "35.05147330" },
                        new() { Id = 10, Name = "Ni'lin", Latitude = "31.94687730", Longitude = "35.00086130" },
                        new() { Id = 11, Name = "Ramallah", Latitude = "31.90741710", Longitude = "35.16468200" },
                        new() { Id = 12, Name = "Rawabi", Latitude = "32.01021570", Longitude = "35.17129410" },
                        new() { Id = 13, Name = "Silwad", Latitude = "31.97942420", Longitude = "35.24126530" },
                        new() { Id = 14, Name = "Sinjil", Latitude = "32.03364130", Longitude = "35.24333530" },
                        new() { Id = 15, Name = "Turmus Ayya", Latitude = "32.03276020", Longitude = "35.26777530" }
                    }
                },

                new()
                {
                    Id = 14,
                    Name = "Salfit",
                    StateCode = "SLT",
                    Latitude = "32.11122720",
                    Longitude = "34.95787690",
                    Type = "governorate",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "az-Zawiya", Latitude = "32.09470520", Longitude = "35.01867630" },
                        new() { Id = 2, Name = "Biddya", Latitude = "32.11340020", Longitude = "35.05686530" },
                        new() { Id = 3, Name = "Bruqin", Latitude = "32.07264720", Longitude = "35.07780630" },
                        new() { Id = 4, Name = "Deir Ballut", Latitude = "32.06506720", Longitude = "35.00494930" },
                        new() { Id = 5, Name = "Deir Istiya", Latitude = "32.13079620", Longitude = "35.11953630" },
                        new() { Id = 6, Name = "Farkha", Latitude = "32.06877720", Longitude = "35.13027630" },
                        new() { Id = 7, Name = "Haris", Latitude = "32.11344920", Longitude = "35.12311630" },
                        new() { Id = 8, Name = "Iskaka", Latitude = "32.10295520", Longitude = "35.20394930" },
                        new() { Id = 9, Name = "Kafr ad-Dik", Latitude = "32.06863540", Longitude = "35.06050810" },
                        new() { Id = 10, Name = "Kifl Hares", Latitude = "32.11692420", Longitude = "35.13636430" },
                        new() { Id = 11, Name = "Marda", Latitude = "32.11425120", Longitude = "35.17525130" },
                        new() { Id = 12, Name = "Mas-ha", Latitude = "32.10729820", Longitude = "35.03037430" },
                        new() { Id = 13, Name = "Qarawat Bani Hassan", Latitude = "32.12853920", Longitude = "35.07877830" },
                        new() { Id = 14, Name = "Qira", Latitude = "32.12213420", Longitude = "35.15063230" },
                        new() { Id = 15, Name = "Rafat", Latitude = "32.07872020", Longitude = "35.02468730" },
                        new() { Id = 16, Name = "Sarta", Latitude = "32.10336920", Longitude = "35.07123830" },
                        new() { Id = 17, Name = "Yasuf", Latitude = "32.10940520", Longitude = "35.21911530" }
                    }
                },

                new()
                {
                    Id = 15,
                    Name = "Tubas",
                    StateCode = "TBS",
                    Latitude = "32.29380430",
                    Longitude = "34.85109800",
                    Type = "governorate",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "'Aqqaba", Latitude = "32.35257060", Longitude = "35.32674760" },
                        new() { Id = 2, Name = "Tammun", Latitude = "32.28315510", Longitude = "35.36518930" },
                        new() { Id = 3, Name = "Tubas", Latitude = "32.32112010", Longitude = "35.34935330" }
                    }
                },

                new()
                {
                    Id = 16,
                    Name = "Tulkarm",
                    StateCode = "TKM",
                    Latitude = "32.32766720",
                    Longitude = "34.92311080",
                    Type = "governorate",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Anabta", Latitude = "32.30728710", Longitude = "35.09887830" },
                        new() { Id = 2, Name = "Attil", Latitude = "32.37010310", Longitude = "35.05193830" },
                        new() { Id = 3, Name = "Bal'a", Latitude = "32.33255610", Longitude = "35.08935330" },
                        new() { Id = 4, Name = "Baqa ash-Sharqiyya", Latitude = "32.41117510", Longitude = "35.05059330" },
                        new() { Id = 5, Name = "Beit Lid", Latitude = "32.26158210", Longitude = "35.10968030" },
                        new() { Id = 6, Name = "Qaffin", Latitude = "32.43341200", Longitude = "35.06370030" },
                        new() { Id = 7, Name = "Tulkarm", Latitude = "32.30796480", Longitude = "35.00802890" }
                    }
                }
            }
        };
    }
}
