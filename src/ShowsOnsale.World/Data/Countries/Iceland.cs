// ⚠️ WARNING: This file is automatically generated by scripts/generate-world.ps1
// DO NOT modify this file manually as it will be overwritten when the script is run again.
// To update the data, modify the source data in countries-states-cities-database and run the script.

using System.Collections.Generic;
using ShowsOnSale.World.Models;

namespace ShowsOnSale.World.Data.Countries
{
    public static class Iceland
    {
        public static Country Data { get; } = new()
        {
            Id = 100,
            Name = "Iceland",
            Iso3 = "ISL",
            Iso2 = "IS",
            NumericCode = "352",
            PhoneCode = "354",
            Capital = "Reykjavik",
            Currency = "ISK",
            CurrencyName = "Icelandic króna",
            CurrencySymbol = "ko",
            Tld = ".is",
            Native = "Ísland",
            Region = "Europe",
            RegionId = 4,
            Subregion = "Northern Europe",
            SubregionId = 18,
            Nationality = "Icelandic",
            Latitude = "65.00000000",
            Longitude = "-18.00000000",
            Emoji = "🇮🇸",
            EmojiU = "U+1F1EE U+1F1F8",
            Timezones = new()
            {
                new() { ZoneName = "Atlantic/Reykjavik", GmtOffset = 0, GmtOffsetName = "UTC±00", Abbreviation = "GMT", TzName = "Greenwich Mean Time" }
            },
            Translations = new()
            {
                { "ko" = "아이슬란드" },
                { "pt-BR" = "Islândia" }
                { "pt" = "Islândia" }
                { "nl" = "IJsland" }
                { "hr" = "Island" }
                { "fa" = "ایسلند" }
                { "de" = "Island" }
                { "es" = "Islandia" }
                { "fr" = "Islande" }
                { "ja" = "アイスランド" }
                { "it" = "Islanda" }
                { "zh-CN" = "冰岛" }
                { "tr" = "İzlanda" }
                { "ru" = "Исландия" }
                { "uk" = "Ісландія" }
                { "pl" = "Islandia" }
            },
            States = new()
            {

                new()
                {
                    Id = 1,
                    Name = "Capital",
                    StateCode = "1",
                    Latitude = "38.56569570",
                    Longitude = "-92.18169490",
                    Type = "region",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Álftanes", Latitude = "64.10000000", Longitude = "-22.01667000" },
                        new() { Id = 2, Name = "Garðabær", Latitude = "64.08865000", Longitude = "-21.92298000" },
                        new() { Id = 3, Name = "Hafnarfjörður", Latitude = "64.06710000", Longitude = "-21.93774000" },
                        new() { Id = 4, Name = "Kjósarhreppur", Latitude = "64.30644000", Longitude = "-21.49919000" },
                        new() { Id = 5, Name = "Kópavogur", Latitude = "64.11234000", Longitude = "-21.91298000" },
                        new() { Id = 6, Name = "Mosfellsbaer", Latitude = "64.15000000", Longitude = "-21.65000000" },
                        new() { Id = 7, Name = "Mosfellsbær", Latitude = "64.16667000", Longitude = "-21.70000000" },
                        new() { Id = 8, Name = "Reykjavík", Latitude = "64.13548000", Longitude = "-21.89541000" },
                        new() { Id = 9, Name = "Seltjarnarnes", Latitude = "64.15309000", Longitude = "-21.99499000" }
                    }
                },

                new()
                {
                    Id = 2,
                    Name = "Eastern",
                    StateCode = "7",
                    Latitude = "",
                    Longitude = "",
                    Type = "region",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Borgarfjarðarhreppur", Latitude = "65.43401000", Longitude = "-13.82933000" },
                        new() { Id = 2, Name = "Breiðdalshreppur", Latitude = "64.83333000", Longitude = "-14.25000000" },
                        new() { Id = 3, Name = "Egilsstaðir", Latitude = "65.26687000", Longitude = "-14.39485000" },
                        new() { Id = 4, Name = "Eskifjörður", Latitude = "65.07306000", Longitude = "-14.01525000" },
                        new() { Id = 5, Name = "Fjarðabyggð", Latitude = "65.08333000", Longitude = "-14.00000000" },
                        new() { Id = 6, Name = "Fljótsdalshérað", Latitude = "65.25020000", Longitude = "-15.37211000" },
                        new() { Id = 7, Name = "Fljótsdalshreppur", Latitude = "64.85275000", Longitude = "-15.25680000" },
                        new() { Id = 8, Name = "Höfn", Latitude = "64.25388000", Longitude = "-15.21212000" },
                        new() { Id = 9, Name = "Neskaupstaður", Latitude = "65.14819000", Longitude = "-13.68368000" },
                        new() { Id = 10, Name = "Reyðarfjörður", Latitude = "65.03164000", Longitude = "-14.21832000" }
                    }
                },

                new()
                {
                    Id = 3,
                    Name = "Northeastern",
                    StateCode = "6",
                    Latitude = "43.29942850",
                    Longitude = "-74.21793260",
                    Type = "region",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Akureyri", Latitude = "65.68353000", Longitude = "-18.08780000" },
                        new() { Id = 2, Name = "Dalvík", Latitude = "65.97018000", Longitude = "-18.52861000" },
                        new() { Id = 3, Name = "Dalvíkurbyggð", Latitude = "65.87318000", Longitude = "-18.60844000" },
                        new() { Id = 4, Name = "Eyjafjarðarsveit", Latitude = "65.33333000", Longitude = "-18.16667000" },
                        new() { Id = 5, Name = "Fjallabyggð", Latitude = "66.05962000", Longitude = "-18.78220000" },
                        new() { Id = 6, Name = "Grýtubakkahreppur", Latitude = "65.98333000", Longitude = "-18.11667000" },
                        new() { Id = 7, Name = "Hörgársveit", Latitude = "65.64828000", Longitude = "-18.49599000" },
                        new() { Id = 8, Name = "Húsavík", Latitude = "66.04148000", Longitude = "-17.33834000" },
                        new() { Id = 9, Name = "Langanesbyggð", Latitude = "66.05186000", Longitude = "-15.18969000" },
                        new() { Id = 10, Name = "Laugar", Latitude = "65.72159000", Longitude = "-17.37352000" },
                        new() { Id = 11, Name = "Siglufjörður", Latitude = "66.15198000", Longitude = "-18.90815000" },
                        new() { Id = 12, Name = "Skútustaðahreppur", Latitude = "65.17177000", Longitude = "-16.77890000" },
                        new() { Id = 13, Name = "Svalbarðsstrandarhreppur", Latitude = "65.74138000", Longitude = "-18.03513000" },
                        new() { Id = 14, Name = "Tjörneshreppur", Latitude = "66.11667000", Longitude = "-17.20000000" },
                        new() { Id = 15, Name = "Þingeyjarsveit", Latitude = "65.37229000", Longitude = "-17.59927000" }
                    }
                },

                new()
                {
                    Id = 4,
                    Name = "Northwestern",
                    StateCode = "5",
                    Latitude = "41.91339320",
                    Longitude = "-73.04716880",
                    Type = "region",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Akrahreppur", Latitude = "65.35505000", Longitude = "-18.79572000" },
                        new() { Id = 2, Name = "Húnaþing Vestra", Latitude = "65.25000000", Longitude = "-20.91667000" },
                        new() { Id = 3, Name = "Sauðárkrókur", Latitude = "65.74611000", Longitude = "-19.63944000" },
                        new() { Id = 4, Name = "Skagabyggð", Latitude = "65.95000000", Longitude = "-20.25000000" },
                        new() { Id = 5, Name = "Sveitarfélagið Skagafjörður", Latitude = "65.50018000", Longitude = "-19.44566000" }
                    }
                },

                new()
                {
                    Id = 5,
                    Name = "Southern",
                    StateCode = "8",
                    Latitude = "",
                    Longitude = "",
                    Type = "region",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Ásahreppur", Latitude = "63.87589000", Longitude = "-20.59484000" },
                        new() { Id = 2, Name = "Bláskógabyggð", Latitude = "64.41667000", Longitude = "-20.33333000" },
                        new() { Id = 3, Name = "Flóahreppur", Latitude = "63.89569000", Longitude = "-20.80159000" },
                        new() { Id = 4, Name = "Grímsnes- og Grafningshreppur", Latitude = "64.08533000", Longitude = "-20.96710000" },
                        new() { Id = 5, Name = "Hrunamannahreppur", Latitude = "64.40944000", Longitude = "-19.72237000" },
                        new() { Id = 6, Name = "Hveragerði", Latitude = "64.00039000", Longitude = "-21.18602000" },
                        new() { Id = 7, Name = "Mýrdalshreppur", Latitude = "63.50000000", Longitude = "-19.00000000" },
                        new() { Id = 8, Name = "Selfoss", Latitude = "63.93311000", Longitude = "-20.99712000" },
                        new() { Id = 9, Name = "Skaftárhreppur", Latitude = "63.95948000", Longitude = "-18.14491000" },
                        new() { Id = 10, Name = "Skeiða- og Gnúpverjahreppur", Latitude = "64.34738000", Longitude = "-19.37757000" },
                        new() { Id = 11, Name = "Vestmannaeyjabær", Latitude = "63.43877000", Longitude = "-20.26900000" },
                        new() { Id = 12, Name = "Vestmannaeyjar", Latitude = "63.44273000", Longitude = "-20.27339000" },
                        new() { Id = 13, Name = "Þorlákshöfn", Latitude = "63.85591000", Longitude = "-21.38337000" }
                    }
                },

                new()
                {
                    Id = 6,
                    Name = "Southern Peninsula",
                    StateCode = "2",
                    Latitude = "63.91548030",
                    Longitude = "-22.36496670",
                    Type = "region",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Garður", Latitude = "64.06558000", Longitude = "-22.64656000" },
                        new() { Id = 2, Name = "Grindavík", Latitude = "63.83849000", Longitude = "-22.43931000" },
                        new() { Id = 3, Name = "Keflavík", Latitude = "64.00492000", Longitude = "-22.56242000" },
                        new() { Id = 4, Name = "Reykjanesbær", Latitude = "63.99813000", Longitude = "-22.56111000" },
                        new() { Id = 5, Name = "Sandgerði", Latitude = "64.03762000", Longitude = "-22.70799000" },
                        new() { Id = 6, Name = "Vogar", Latitude = "63.98160000", Longitude = "-22.38473000" }
                    }
                },

                new()
                {
                    Id = 7,
                    Name = "Western",
                    StateCode = "3",
                    Latitude = "",
                    Longitude = "",
                    Type = "region",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Akranes", Latitude = "64.32179000", Longitude = "-22.07490000" },
                        new() { Id = 2, Name = "Borgarbyggð", Latitude = "64.71446000", Longitude = "-21.23788000" },
                        new() { Id = 3, Name = "Borgarnes", Latitude = "64.53834000", Longitude = "-21.92064000" },
                        new() { Id = 4, Name = "Dalabyggð", Latitude = "65.10121000", Longitude = "-21.72871000" },
                        new() { Id = 5, Name = "Eyja- og Miklaholtshreppur", Latitude = "64.85846000", Longitude = "-22.54557000" },
                        new() { Id = 6, Name = "Helgafellssveit", Latitude = "64.99069000", Longitude = "-22.78948000" },
                        new() { Id = 7, Name = "Hvalfjarðarsveit", Latitude = "64.44265000", Longitude = "-21.61086000" },
                        new() { Id = 8, Name = "Ólafsvík", Latitude = "64.89429000", Longitude = "-23.70918000" },
                        new() { Id = 9, Name = "Skorradalshreppur", Latitude = "64.51667000", Longitude = "-21.50000000" },
                        new() { Id = 10, Name = "Snæfellsbær", Latitude = "64.86667000", Longitude = "-23.50000000" },
                        new() { Id = 11, Name = "Stykkishólmur", Latitude = "65.07537000", Longitude = "-22.72977000" }
                    }
                },

                new()
                {
                    Id = 8,
                    Name = "Westfjords",
                    StateCode = "4",
                    Latitude = "65.91961500",
                    Longitude = "-21.88117640",
                    Type = "region",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Ísafjarðarbær", Latitude = "66.07586000", Longitude = "-23.12794000" },
                        new() { Id = 2, Name = "Ísafjörður", Latitude = "66.07475000", Longitude = "-23.13498000" },
                        new() { Id = 3, Name = "Reykhólahreppur", Latitude = "65.60990000", Longitude = "-22.33324000" },
                        new() { Id = 4, Name = "Strandabyggð", Latitude = "65.77455000", Longitude = "-21.95725000" },
                        new() { Id = 5, Name = "Tálknafjarðarhreppur", Latitude = "65.61667000", Longitude = "-23.88333000" }
                    }
                }
            }
        };
    }
}
