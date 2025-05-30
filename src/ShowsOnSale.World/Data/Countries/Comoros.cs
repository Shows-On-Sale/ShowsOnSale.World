// ⚠️ WARNING: This file is automatically generated by scripts/generate-world.ps1
// DO NOT modify this file manually as it will be overwritten when the script is run again.
// To update the data, modify the source data in countries-states-cities-database and run the script.

using System.Collections.Generic;
using ShowsOnSale.World.Models;

namespace ShowsOnSale.World.Data.Countries
{
    public static class Comoros
    {
        public static Country Data { get; } = new()
        {
            Id = 49,
            Name = "Comoros",
            Iso3 = "COM",
            Iso2 = "KM",
            NumericCode = "174",
            PhoneCode = "269",
            Capital = "Moroni",
            Currency = "KMF",
            CurrencyName = "Comorian franc",
            CurrencySymbol = "CF",
            Tld = ".km",
            Native = "Komori",
            Region = "Africa",
            RegionId = 1,
            Subregion = "Eastern Africa",
            SubregionId = 4,
            Nationality = "Comoran, Comorian",
            Latitude = "-12.16666666",
            Longitude = "44.25000000",
            Emoji = "🇰🇲",
            EmojiU = "U+1F1F0 U+1F1F2",
            Timezones = new()
            {
                new() { ZoneName = "Indian/Comoro", GmtOffset = 10800, GmtOffsetName = "UTC+03:00", Abbreviation = "EAT", TzName = "East Africa Time" }
            },
            Translations = new()
            {
                ["ko"] = "코모로",
                ["pt-BR"] = "Comores",
                ["pt"] = "Comores",
                ["nl"] = "Comoren",
                ["hr"] = "Komori",
                ["fa"] = "کومور",
                ["de"] = "Union der Komoren",
                ["es"] = "Comoras",
                ["fr"] = "Comores",
                ["ja"] = "コモロ",
                ["it"] = "Comore",
                ["zh-CN"] = "科摩罗",
                ["tr"] = "Komorlar",
                ["ru"] = "Коморские острова",
                ["uk"] = "Коморські острови",
                ["pl"] = "Komory"
            },
            States = new()
            {

                new()
                {
                    Id = 1,
                    Name = "Anjouan",
                    StateCode = "A",
                    Latitude = "-12.21381450",
                    Longitude = "44.43706060",
                    Type = "island",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Adda-Douéni", Latitude = "-12.29250000", Longitude = "44.49722000" },
                        new() { Id = 2, Name = "Antsahé", Latitude = "-12.35639000", Longitude = "44.52250000" },
                        new() { Id = 3, Name = "Assimpao", Latitude = "-12.23306000", Longitude = "44.31972000" },
                        new() { Id = 4, Name = "Bambao", Latitude = "-12.20325000", Longitude = "44.51638000" },
                        new() { Id = 5, Name = "Bandajou", Latitude = "-12.19167000", Longitude = "44.28694000" },
                        new() { Id = 6, Name = "Barakani", Latitude = "-12.13861000", Longitude = "44.43026000" },
                        new() { Id = 7, Name = "Bimbini", Latitude = "-12.18833000", Longitude = "44.23556000" },
                        new() { Id = 8, Name = "Boungouéni", Latitude = "-12.20556000", Longitude = "44.29944000" },
                        new() { Id = 9, Name = "Chandra", Latitude = "-12.19500000", Longitude = "44.46472000" },
                        new() { Id = 10, Name = "Chironkamba", Latitude = "-12.19111000", Longitude = "44.35250000" },
                        new() { Id = 11, Name = "Chitrouni", Latitude = "-12.18583000", Longitude = "44.33556000" },
                        new() { Id = 12, Name = "Daji", Latitude = "-12.32583000", Longitude = "44.48861000" },
                        new() { Id = 13, Name = "Domoni", Latitude = "-12.25694000", Longitude = "44.53194000" },
                        new() { Id = 14, Name = "Dziani", Latitude = "-12.18333000", Longitude = "44.48333000" },
                        new() { Id = 15, Name = "Hajoho", Latitude = "-12.12434000", Longitude = "44.48881000" },
                        new() { Id = 16, Name = "Harembo", Latitude = "-12.15108000", Longitude = "44.49828000" },
                        new() { Id = 17, Name = "Kangani", Latitude = "-12.32102000", Longitude = "44.47270000" },
                        new() { Id = 18, Name = "Kavani", Latitude = "-12.19194000", Longitude = "44.26944000" },
                        new() { Id = 19, Name = "Koki", Latitude = "-12.17139000", Longitude = "44.44167000" },
                        new() { Id = 20, Name = "Koni-Djodjo", Latitude = "-12.22972000", Longitude = "44.48167000" },
                        new() { Id = 21, Name = "Koni-Ngani", Latitude = "-12.21583000", Longitude = "44.48000000" },
                        new() { Id = 22, Name = "Kyo", Latitude = "-12.33222000", Longitude = "44.51917000" },
                        new() { Id = 23, Name = "Limbi", Latitude = "-12.23944000", Longitude = "44.50528000" },
                        new() { Id = 24, Name = "Lingoni", Latitude = "-12.25583000", Longitude = "44.41833000" },
                        new() { Id = 25, Name = "Magnassini-Nindri", Latitude = "-12.27806000", Longitude = "44.41583000" },
                        new() { Id = 26, Name = "Maraharé", Latitude = "-12.23083000", Longitude = "44.31333000" },
                        new() { Id = 27, Name = "Mirontsi", Latitude = "-12.15667000", Longitude = "44.40806000" },
                        new() { Id = 28, Name = "Mjamaoué", Latitude = "-12.19361000", Longitude = "44.31000000" },
                        new() { Id = 29, Name = "Mjimandra", Latitude = "-12.19167000", Longitude = "44.37028000" },
                        new() { Id = 30, Name = "Moutsamoudou", Latitude = "-12.16672000", Longitude = "44.39944000" },
                        new() { Id = 31, Name = "Moya", Latitude = "-12.30967000", Longitude = "44.43685000" },
                        new() { Id = 32, Name = "Mramani", Latitude = "-12.34639000", Longitude = "44.52861000" },
                        new() { Id = 33, Name = "Mrémani", Latitude = "-12.30833000", Longitude = "44.49861000" },
                        new() { Id = 34, Name = "Ongoni", Latitude = "-12.17028000", Longitude = "44.50694000" },
                        new() { Id = 35, Name = "Ouani", Latitude = "-12.13554000", Longitude = "44.42493000" },
                        new() { Id = 36, Name = "Ouzini", Latitude = "-12.26722000", Longitude = "44.47972000" },
                        new() { Id = 37, Name = "Pajé", Latitude = "-12.16972000", Longitude = "44.38806000" },
                        new() { Id = 38, Name = "Patsi", Latitude = "-12.15556000", Longitude = "44.43722000" },
                        new() { Id = 39, Name = "Sima", Latitude = "-12.19556000", Longitude = "44.27667000" },
                        new() { Id = 40, Name = "Tsimbeo", Latitude = "-12.20583000", Longitude = "44.46472000" },
                        new() { Id = 41, Name = "Vouani", Latitude = "-12.24417000", Longitude = "44.37444000" }
                    }
                },

                new()
                {
                    Id = 2,
                    Name = "Grande Comore",
                    StateCode = "G",
                    Latitude = "-11.71673380",
                    Longitude = "43.36807880",
                    Type = "island",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Bahani", Latitude = "-11.63972000", Longitude = "43.28417000" },
                        new() { Id = 2, Name = "Bambadjani", Latitude = "-11.47861000", Longitude = "43.37722000" },
                        new() { Id = 3, Name = "Bouni", Latitude = "-11.48694000", Longitude = "43.38833000" },
                        new() { Id = 4, Name = "Chezani", Latitude = "-11.43140000", Longitude = "43.39625000" },
                        new() { Id = 5, Name = "Chindini", Latitude = "-11.92328000", Longitude = "43.49109000" },
                        new() { Id = 6, Name = "Chouani", Latitude = "-11.82330000", Longitude = "43.29429000" },
                        new() { Id = 7, Name = "Dembéni", Latitude = "-11.87361000", Longitude = "43.39778000" },
                        new() { Id = 8, Name = "Douniani", Latitude = "-11.42111000", Longitude = "43.28889000" },
                        new() { Id = 9, Name = "Dzahadjou", Latitude = "-11.85287000", Longitude = "43.34987000" },
                        new() { Id = 10, Name = "Foumbouni", Latitude = "-11.86537000", Longitude = "43.49529000" },
                        new() { Id = 11, Name = "Hantsindzi", Latitude = "-11.43178000", Longitude = "43.41102000" },
                        new() { Id = 12, Name = "Héroumbili", Latitude = "-11.54389000", Longitude = "43.37972000" },
                        new() { Id = 13, Name = "Itsandra", Latitude = "-11.67111000", Longitude = "43.25472000" },
                        new() { Id = 14, Name = "Itsandzéni", Latitude = "-11.47278000", Longitude = "43.38444000" },
                        new() { Id = 15, Name = "Ivouani", Latitude = "-11.39157000", Longitude = "43.39454000" },
                        new() { Id = 16, Name = "Koua", Latitude = "-11.42083000", Longitude = "43.27639000" },
                        new() { Id = 17, Name = "Madjeouéni", Latitude = "-11.82167000", Longitude = "43.27806000" },
                        new() { Id = 18, Name = "Mandza", Latitude = "-11.41806000", Longitude = "43.29528000" },
                        new() { Id = 19, Name = "Mavingouni", Latitude = "-11.71639000", Longitude = "43.25250000" },
                        new() { Id = 20, Name = "Mbéni", Latitude = "-11.50139000", Longitude = "43.37750000" },
                        new() { Id = 21, Name = "Mitsamiouli", Latitude = "-11.38472000", Longitude = "43.28444000" },
                        new() { Id = 22, Name = "Mitsoudjé", Latitude = "-11.81209000", Longitude = "43.28043000" },
                        new() { Id = 23, Name = "Mnoungou", Latitude = "-11.51778000", Longitude = "43.37389000" },
                        new() { Id = 24, Name = "Mohoro", Latitude = "-11.82701000", Longitude = "43.45436000" },
                        new() { Id = 25, Name = "Moroni", Latitude = "-11.70216000", Longitude = "43.25506000" },
                        new() { Id = 26, Name = "Mtsamdou", Latitude = "-11.60694000", Longitude = "43.38056000" },
                        new() { Id = 27, Name = "Mvouni", Latitude = "-11.71611000", Longitude = "43.26472000" },
                        new() { Id = 28, Name = "Nioumamilima", Latitude = "-11.85461000", Longitude = "43.44607000" },
                        new() { Id = 29, Name = "Ntsaouéni", Latitude = "-11.46583000", Longitude = "43.26278000" },
                        new() { Id = 30, Name = "Ntsoudjini", Latitude = "-11.65972000", Longitude = "43.26139000" },
                        new() { Id = 31, Name = "Ouellah", Latitude = "-11.39028000", Longitude = "43.33194000" },
                        new() { Id = 32, Name = "Ouhozi", Latitude = "-11.40500000", Longitude = "43.28222000" },
                        new() { Id = 33, Name = "Ourovéni", Latitude = "-11.91375000", Longitude = "43.49804000" },
                        new() { Id = 34, Name = "Oussivo", Latitude = "-11.58500000", Longitude = "43.26722000" },
                        new() { Id = 35, Name = "Salimani", Latitude = "-11.81150000", Longitude = "43.26823000" },
                        new() { Id = 36, Name = "Séléa", Latitude = "-11.78444000", Longitude = "43.26083000" },
                        new() { Id = 37, Name = "Singani", Latitude = "-11.84784000", Longitude = "43.31731000" },
                        new() { Id = 38, Name = "Tsidjé", Latitude = "-11.69806000", Longitude = "43.26194000" },
                        new() { Id = 39, Name = "Vanadjou", Latitude = "-11.60750000", Longitude = "43.27611000" },
                        new() { Id = 40, Name = "Vanambouani", Latitude = "-11.61139000", Longitude = "43.25306000" }
                    }
                },

                new()
                {
                    Id = 3,
                    Name = "Mohéli",
                    StateCode = "M",
                    Latitude = "-12.33773760",
                    Longitude = "43.73340890",
                    Type = "island",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Djoyézi", Latitude = "-12.30587000", Longitude = "43.77425000" },
                        new() { Id = 2, Name = "Fomboni", Latitude = "-12.28759000", Longitude = "43.74344000" },
                        new() { Id = 3, Name = "Hoani", Latitude = "-12.25083000", Longitude = "43.67472000" },
                        new() { Id = 4, Name = "Mtakoudja", Latitude = "-12.26111000", Longitude = "43.70361000" },
                        new() { Id = 5, Name = "Nioumachoua", Latitude = "-12.36139000", Longitude = "43.71528000" },
                        new() { Id = 6, Name = "Ouanani", Latitude = "-12.33750000", Longitude = "43.79750000" },
                        new() { Id = 7, Name = "Ziroudani", Latitude = "-12.33250000", Longitude = "43.77750000" }
                    }
                }
            }
        };
    }
}
