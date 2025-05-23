// ⚠️ WARNING: This file is automatically generated by scripts/generate-world.ps1
// DO NOT modify this file manually as it will be overwritten when the script is run again.
// To update the data, modify the source data in countries-states-cities-database and run the script.

using System.Collections.Generic;
using ShowsOnSale.World.Models;

namespace ShowsOnSale.World.Data.Countries
{
    public static class SierraLeone
    {
        public static Country Data { get; } = new()
        {
            Id = 197,
            Name = "Sierra Leone",
            Iso3 = "SLE",
            Iso2 = "SL",
            NumericCode = "694",
            PhoneCode = "232",
            Capital = "Freetown",
            Currency = "SLL",
            CurrencyName = "Sierra Leonean leone",
            CurrencySymbol = "Le",
            Tld = ".sl",
            Native = "Sierra Leone",
            Region = "Africa",
            RegionId = 1,
            Subregion = "Western Africa",
            SubregionId = 3,
            Nationality = "Sierra Leonean",
            Latitude = "8.50000000",
            Longitude = "-11.50000000",
            Emoji = "🇸🇱",
            EmojiU = "U+1F1F8 U+1F1F1",
            Timezones = new()
            {
                new() { ZoneName = "Africa/Freetown", GmtOffset = 0, GmtOffsetName = "UTC±00", Abbreviation = "GMT", TzName = "Greenwich Mean Time" }
            },
            Translations = new()
            {
                ["ko"] = "시에라리온",
                ["pt-BR"] = "Serra Leoa",
                ["pt"] = "Serra Leoa",
                ["nl"] = "Sierra Leone",
                ["hr"] = "Sijera Leone",
                ["fa"] = "سیرالئون",
                ["de"] = "Sierra Leone",
                ["es"] = "Sierra Leone",
                ["fr"] = "Sierra Leone",
                ["ja"] = "シエラレオネ",
                ["it"] = "Sierra Leone",
                ["zh-CN"] = "塞拉利昂",
                ["tr"] = "Sierra Leone",
                ["ru"] = "Сьерра-Леоне",
                ["uk"] = "Сьєрра-Леоне",
                ["pl"] = "Sierra Leone"
            },
            States = new()
            {

                new()
                {
                    Id = 1,
                    Name = "Eastern",
                    StateCode = "E",
                    Latitude = "",
                    Longitude = "",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Barma", Latitude = "8.34959000", Longitude = "-11.33059000" },
                        new() { Id = 2, Name = "Blama", Latitude = "7.87481000", Longitude = "-11.34548000" },
                        new() { Id = 3, Name = "Boajibu", Latitude = "8.18763000", Longitude = "-11.34026000" },
                        new() { Id = 4, Name = "Buedu", Latitude = "8.27960000", Longitude = "-10.37135000" },
                        new() { Id = 5, Name = "Bunumbu", Latitude = "8.17421000", Longitude = "-10.86432000" },
                        new() { Id = 6, Name = "Daru", Latitude = "7.98976000", Longitude = "-10.84223000" },
                        new() { Id = 7, Name = "Giehun", Latitude = "7.88405000", Longitude = "-11.04908000" },
                        new() { Id = 8, Name = "Gorahun", Latitude = "7.46439000", Longitude = "-11.23952000" },
                        new() { Id = 9, Name = "Hangha", Latitude = "7.93974000", Longitude = "-11.14132000" },
                        new() { Id = 10, Name = "Jojoima", Latitude = "7.87815000", Longitude = "-10.78976000" },
                        new() { Id = 11, Name = "Kailahun", Latitude = "8.27890000", Longitude = "-10.57300000" },
                        new() { Id = 12, Name = "Kailahun District", Latitude = "8.10768000", Longitude = "-10.75146000" },
                        new() { Id = 13, Name = "Kayima", Latitude = "8.88790000", Longitude = "-11.15932000" },
                        new() { Id = 14, Name = "Kenema", Latitude = "7.87687000", Longitude = "-11.19025000" },
                        new() { Id = 15, Name = "Kenema District", Latitude = "7.95171000", Longitude = "-11.19004000" },
                        new() { Id = 16, Name = "Koidu", Latitude = "8.64387000", Longitude = "-10.97140000" },
                        new() { Id = 17, Name = "Kono District", Latitude = "8.70687000", Longitude = "-10.93368000" },
                        new() { Id = 18, Name = "Koyima", Latitude = "8.70552000", Longitude = "-11.02241000" },
                        new() { Id = 19, Name = "Manowa", Latitude = "8.17392000", Longitude = "-10.74834000" },
                        new() { Id = 20, Name = "Mobai", Latitude = "7.99343000", Longitude = "-10.75355000" },
                        new() { Id = 21, Name = "Motema", Latitude = "8.61427000", Longitude = "-11.01252000" },
                        new() { Id = 22, Name = "Panguma", Latitude = "8.18507000", Longitude = "-11.13290000" },
                        new() { Id = 23, Name = "Pendembu", Latitude = "8.09807000", Longitude = "-10.69429000" },
                        new() { Id = 24, Name = "Segbwema", Latitude = "7.99471000", Longitude = "-10.95020000" },
                        new() { Id = 25, Name = "Simbakoro", Latitude = "8.61243000", Longitude = "-11.00755000" },
                        new() { Id = 26, Name = "Tefeya", Latitude = "8.70395000", Longitude = "-11.21260000" },
                        new() { Id = 27, Name = "Tombodu", Latitude = "8.13526000", Longitude = "-10.61960000" },
                        new() { Id = 28, Name = "Tombu", Latitude = "8.53991000", Longitude = "-10.73132000" },
                        new() { Id = 29, Name = "Wima", Latitude = "8.30052000", Longitude = "-11.20455000" },
                        new() { Id = 30, Name = "Yengema", Latitude = "8.71441000", Longitude = "-11.17057000" }
                    }
                },

                new()
                {
                    Id = 2,
                    Name = "Northern",
                    StateCode = "N",
                    Latitude = "",
                    Longitude = "",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Alikalia", Latitude = "9.15356000", Longitude = "-11.38712000" },
                        new() { Id = 2, Name = "Bindi", Latitude = "9.91376000", Longitude = "-11.44669000" },
                        new() { Id = 3, Name = "Binkolo", Latitude = "8.95225000", Longitude = "-11.98029000" },
                        new() { Id = 4, Name = "Bombali District", Latitude = "9.28444000", Longitude = "-12.16449000" },
                        new() { Id = 5, Name = "Bumbuna", Latitude = "9.04466000", Longitude = "-11.74576000" },
                        new() { Id = 6, Name = "Gberia Fotombu", Latitude = "9.87852000", Longitude = "-11.16548000" },
                        new() { Id = 7, Name = "Kabala", Latitude = "9.58893000", Longitude = "-11.55256000" },
                        new() { Id = 8, Name = "Kamakwie", Latitude = "9.49689000", Longitude = "-12.24061000" },
                        new() { Id = 9, Name = "Kambia", Latitude = "9.12504000", Longitude = "-12.91816000" },
                        new() { Id = 10, Name = "Kassiri", Latitude = "8.93814000", Longitude = "-13.11541000" },
                        new() { Id = 11, Name = "Koinadugu District", Latitude = "9.50991000", Longitude = "-11.34601000" },
                        new() { Id = 12, Name = "Konakridee", Latitude = "8.69778000", Longitude = "-13.23917000" },
                        new() { Id = 13, Name = "Kukuna", Latitude = "9.39841000", Longitude = "-12.66476000" },
                        new() { Id = 14, Name = "Loma", Latitude = "9.75931000", Longitude = "-12.03383000" },
                        new() { Id = 15, Name = "Lunsar", Latitude = "8.68439000", Longitude = "-12.53499000" },
                        new() { Id = 16, Name = "Magburaka", Latitude = "8.72306000", Longitude = "-11.94880000" },
                        new() { Id = 17, Name = "Makali", Latitude = "8.62964000", Longitude = "-11.66168000" },
                        new() { Id = 18, Name = "Makeni", Latitude = "8.88605000", Longitude = "-12.04417000" },
                        new() { Id = 19, Name = "Mambolo", Latitude = "8.91860000", Longitude = "-13.03674000" },
                        new() { Id = 20, Name = "Mange", Latitude = "8.92262000", Longitude = "-12.85688000" },
                        new() { Id = 21, Name = "Masaka", Latitude = "8.66492000", Longitude = "-11.80260000" },
                        new() { Id = 22, Name = "Masingbi", Latitude = "8.78197000", Longitude = "-11.95171000" },
                        new() { Id = 23, Name = "Masoyila", Latitude = "8.61119000", Longitude = "-13.19101000" },
                        new() { Id = 24, Name = "Pepel", Latitude = "8.58611000", Longitude = "-13.05444000" },
                        new() { Id = 25, Name = "Rokupr", Latitude = "8.67121000", Longitude = "-12.38497000" },
                        new() { Id = 26, Name = "Sawkta", Latitude = "8.63230000", Longitude = "-13.20250000" },
                        new() { Id = 27, Name = "Seidu", Latitude = "9.01801000", Longitude = "-10.59496000" },
                        new() { Id = 28, Name = "Tintafor", Latitude = "8.62667000", Longitude = "-13.21500000" },
                        new() { Id = 29, Name = "Tonkolili District", Latitude = "8.61885000", Longitude = "-11.84173000" },
                        new() { Id = 30, Name = "Yonibana", Latitude = "8.44347000", Longitude = "-12.23929000" }
                    }
                },

                new()
                {
                    Id = 3,
                    Name = "Southern",
                    StateCode = "S",
                    Latitude = "",
                    Longitude = "",
                    Type = "province",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Baiima", Latitude = "8.10826000", Longitude = "-11.84772000" },
                        new() { Id = 2, Name = "Baoma", Latitude = "7.99344000", Longitude = "-11.71468000" },
                        new() { Id = 3, Name = "Bo", Latitude = "7.96472000", Longitude = "-11.73833000" },
                        new() { Id = 4, Name = "Bo District", Latitude = "7.98877000", Longitude = "-11.67340000" },
                        new() { Id = 5, Name = "Bomi", Latitude = "7.24611000", Longitude = "-11.52583000" },
                        new() { Id = 6, Name = "Bonthe", Latitude = "7.52639000", Longitude = "-12.50500000" },
                        new() { Id = 7, Name = "Bonthe District", Latitude = "7.51622000", Longitude = "-12.33591000" },
                        new() { Id = 8, Name = "Bumpe", Latitude = "7.89209000", Longitude = "-11.90541000" },
                        new() { Id = 9, Name = "Foindu", Latitude = "7.40906000", Longitude = "-11.54328000" },
                        new() { Id = 10, Name = "Gandorhun", Latitude = "7.55502000", Longitude = "-11.69260000" },
                        new() { Id = 11, Name = "Gbewebu", Latitude = "7.55091000", Longitude = "-11.60750000" },
                        new() { Id = 12, Name = "Koribundu", Latitude = "7.70952000", Longitude = "-11.69354000" },
                        new() { Id = 13, Name = "Largo", Latitude = "8.27903000", Longitude = "-12.15780000" },
                        new() { Id = 14, Name = "Mamboma", Latitude = "8.08742000", Longitude = "-11.68841000" },
                        new() { Id = 15, Name = "Mogbwemo", Latitude = "7.76237000", Longitude = "-12.30864000" },
                        new() { Id = 16, Name = "Moyamba", Latitude = "8.15898000", Longitude = "-12.43168000" },
                        new() { Id = 17, Name = "Moyamba District", Latitude = "8.06290000", Longitude = "-12.44401000" },
                        new() { Id = 18, Name = "Palima", Latitude = "8.11996000", Longitude = "-11.50702000" },
                        new() { Id = 19, Name = "Potoru", Latitude = "7.50596000", Longitude = "-11.47897000" },
                        new() { Id = 20, Name = "Pujehun", Latitude = "7.35806000", Longitude = "-11.72083000" },
                        new() { Id = 21, Name = "Pujehun District", Latitude = "7.31855000", Longitude = "-11.57920000" },
                        new() { Id = 22, Name = "Rotifunk", Latitude = "8.22591000", Longitude = "-12.67760000" },
                        new() { Id = 23, Name = "Serabu", Latitude = "7.79311000", Longitude = "-12.05294000" },
                        new() { Id = 24, Name = "Sumbuya", Latitude = "7.64789000", Longitude = "-11.96060000" },
                        new() { Id = 25, Name = "Tongole", Latitude = "7.45092000", Longitude = "-11.90071000" },
                        new() { Id = 26, Name = "Zimmi", Latitude = "7.31356000", Longitude = "-11.30818000" }
                    }
                },

                new()
                {
                    Id = 4,
                    Name = "Western",
                    StateCode = "W",
                    Latitude = "40.25459690",
                    Longitude = "-80.24554440",
                    Type = "area",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Freetown", Latitude = "8.48714000", Longitude = "-13.23560000" },
                        new() { Id = 2, Name = "Hastings", Latitude = "8.37994000", Longitude = "-13.13693000" },
                        new() { Id = 3, Name = "Kent", Latitude = "8.33333000", Longitude = "-13.06667000" },
                        new() { Id = 4, Name = "Waterloo", Latitude = "8.33890000", Longitude = "-13.07091000" }
                    }
                }
            }
        };
    }
}
