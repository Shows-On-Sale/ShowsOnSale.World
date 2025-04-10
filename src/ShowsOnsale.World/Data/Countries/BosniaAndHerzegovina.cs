// ⚠️ WARNING: This file is automatically generated by scripts/generate-world.ps1
// DO NOT modify this file manually as it will be overwritten when the script is run again.
// To update the data, modify the source data in countries-states-cities-database and run the script.

using System.Collections.Generic;
using ShowsOnSale.World.Models;

namespace ShowsOnSale.World.Data.Countries
{
    public static class BosniaAndHerzegovina
    {
        public static Country Data { get; } = new()
        {
            Id = 28,
            Name = "Bosnia and Herzegovina",
            Iso3 = "BIH",
            Iso2 = "BA",
            NumericCode = "070",
            PhoneCode = "387",
            Capital = "Sarajevo",
            Currency = "BAM",
            CurrencyName = "Bosnia and Herzegovina convertible mark",
            CurrencySymbol = "KM",
            Tld = ".ba",
            Native = "Bosna i Hercegovina",
            Region = "Europe",
            RegionId = 4,
            Subregion = "Southern Europe",
            SubregionId = 16,
            Nationality = "Bosnian or Herzegovinian",
            Latitude = "44.00000000",
            Longitude = "18.00000000",
            Emoji = "🇧🇦",
            EmojiU = "U+1F1E7 U+1F1E6",
            Timezones = new()
            {
                new() { ZoneName = "Europe/Sarajevo", GmtOffset = 3600, GmtOffsetName = "UTC+01:00", Abbreviation = "CET", TzName = "Central European Time" }
            },
            Translations = new()
            {
                ["ko"] = "보스니아 헤르체고비나",
                ["pt-BR"] = "Bósnia e Herzegovina",
                ["pt"] = "Bósnia e Herzegovina",
                ["nl"] = "Bosnië en Herzegovina",
                ["hr"] = "Bosna i Hercegovina",
                ["fa"] = "بوسنی و هرزگوین",
                ["de"] = "Bosnien und Herzegowina",
                ["es"] = "Bosnia y Herzegovina",
                ["fr"] = "Bosnie-Herzégovine",
                ["ja"] = "ボスニア・ヘルツェゴビナ",
                ["it"] = "Bosnia ed Erzegovina",
                ["zh-CN"] = "波斯尼亚和黑塞哥维那",
                ["tr"] = "Bosna Hersek",
                ["ru"] = "Босния и Герцеговина",
                ["uk"] = "Боснія і Герцеговина",
                ["pl"] = "Bośnia i Hercegowina"
            },
            States = new()
            {

                new()
                {
                    Id = 1,
                    Name = "Bosnian Podrinje",
                    StateCode = "05",
                    Latitude = "43.68749000",
                    Longitude = "18.82443940",
                    Type = "canton",
                    Cities = new()
                    {
                    }
                },

                new()
                {
                    Id = 2,
                    Name = "Brčko",
                    StateCode = "BRC",
                    Latitude = "44.84059440",
                    Longitude = "18.74215300",
                    Type = "district",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Brčko", Latitude = "44.86995000", Longitude = "18.81012000" },
                        new() { Id = 2, Name = "Brka", Latitude = "44.82837000", Longitude = "18.72420000" }
                    }
                },

                new()
                {
                    Id = 3,
                    Name = "Canton 10",
                    StateCode = "10",
                    Latitude = "43.95341550",
                    Longitude = "16.94251870",
                    Type = "canton",
                    Cities = new()
                    {
                    }
                },

                new()
                {
                    Id = 4,
                    Name = "Central Bosnia",
                    StateCode = "06",
                    Latitude = "44.13818560",
                    Longitude = "17.68667140",
                    Type = "canton",
                    Cities = new()
                    {
                    }
                },

                new()
                {
                    Id = 5,
                    Name = "Federation of Bosnia and Herzegovina",
                    StateCode = "BIH",
                    Latitude = "43.88748970",
                    Longitude = "17.84279300",
                    Type = "entity",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Banovići", Latitude = "44.40596000", Longitude = "18.52648000" },
                        new() { Id = 2, Name = "Barice", Latitude = "44.54065000", Longitude = "18.48069000" },
                        new() { Id = 3, Name = "Bihać", Latitude = "44.81694000", Longitude = "15.87083000" },
                        new() { Id = 4, Name = "Bijela", Latitude = "43.60871000", Longitude = "17.95078000" },
                        new() { Id = 5, Name = "Bila", Latitude = "43.78265000", Longitude = "16.92676000" },
                        new() { Id = 6, Name = "Blagaj", Latitude = "43.25892000", Longitude = "17.88815000" },
                        new() { Id = 7, Name = "Bosanska Krupa", Latitude = "44.88250000", Longitude = "16.15139000" },
                        new() { Id = 8, Name = "Bosanski Petrovac", Latitude = "44.55537000", Longitude = "16.36897000" },
                        new() { Id = 9, Name = "Bosansko Grahovo", Latitude = "44.17944000", Longitude = "16.36389000" },
                        new() { Id = 10, Name = "Breza", Latitude = "44.01862000", Longitude = "18.26063000" },
                        new() { Id = 11, Name = "Bugojno", Latitude = "44.05722000", Longitude = "17.45083000" },
                        new() { Id = 12, Name = "Busovača", Latitude = "44.09769000", Longitude = "17.87830000" },
                        new() { Id = 13, Name = "Bužim", Latitude = "45.05361000", Longitude = "16.03254000" },
                        new() { Id = 14, Name = "Čapljina", Latitude = "43.12139000", Longitude = "17.68444000" },
                        new() { Id = 15, Name = "Cazin", Latitude = "44.96694000", Longitude = "15.94306000" },
                        new() { Id = 16, Name = "Čelić", Latitude = "44.72524000", Longitude = "18.81474000" },
                        new() { Id = 17, Name = "Cim", Latitude = "43.35401000", Longitude = "17.78045000" },
                        new() { Id = 18, Name = "Čitluk", Latitude = "43.22861000", Longitude = "17.70083000" },
                        new() { Id = 19, Name = "Ćoralići", Latitude = "45.00694000", Longitude = "15.87194000" },
                        new() { Id = 20, Name = "Crnići", Latitude = "43.13156000", Longitude = "17.86452000" },
                        new() { Id = 21, Name = "Divičani", Latitude = "44.36682000", Longitude = "17.32678000" },
                        new() { Id = 22, Name = "Dobrinje", Latitude = "44.05008000", Longitude = "18.11958000" },
                        new() { Id = 23, Name = "Domaljevac", Latitude = "45.06110000", Longitude = "18.58612000" },
                        new() { Id = 24, Name = "Donja Dubica", Latitude = "45.07559000", Longitude = "18.41023000" },
                        new() { Id = 25, Name = "Donja Mahala", Latitude = "45.04327000", Longitude = "18.66996000" },
                        new() { Id = 26, Name = "Donja Međiđa", Latitude = "44.80235000", Longitude = "18.40477000" },
                        new() { Id = 27, Name = "Donji Vakuf", Latitude = "44.14361000", Longitude = "17.40000000" },
                        new() { Id = 28, Name = "Drežnica", Latitude = "43.52891000", Longitude = "17.28120000" },
                        new() { Id = 29, Name = "Drinovci", Latitude = "43.35454000", Longitude = "17.32536000" },
                        new() { Id = 30, Name = "Drvar", Latitude = "44.37389000", Longitude = "16.38083000" },
                        new() { Id = 31, Name = "Dubrave Donje", Latitude = "44.48060000", Longitude = "18.69709000" },
                        new() { Id = 32, Name = "Dubrave Gornje", Latitude = "44.47229000", Longitude = "18.72685000" },
                        new() { Id = 33, Name = "Dubravica", Latitude = "44.44131000", Longitude = "18.11883000" },
                        new() { Id = 34, Name = "Fojnica", Latitude = "43.95952000", Longitude = "17.90288000" },
                        new() { Id = 35, Name = "Glamoč", Latitude = "44.04583000", Longitude = "16.84861000" },
                        new() { Id = 36, Name = "Gnojnica", Latitude = "44.62058000", Longitude = "18.44684000" },
                        new() { Id = 37, Name = "Goražde", Latitude = "43.66795000", Longitude = "18.97564000" },
                        new() { Id = 38, Name = "Gorica", Latitude = "43.41833000", Longitude = "17.28500000" },
                        new() { Id = 39, Name = "Gornja Breza", Latitude = "44.03758000", Longitude = "18.24564000" },
                        new() { Id = 40, Name = "Gornja Koprivna", Latitude = "45.01091000", Longitude = "15.95487000" },
                        new() { Id = 41, Name = "Gornja Tuzla", Latitude = "44.55659000", Longitude = "18.76159000" },
                        new() { Id = 42, Name = "Gornje Moštre", Latitude = "44.01911000", Longitude = "18.15477000" },
                        new() { Id = 43, Name = "Gornje Živinice", Latitude = "44.42921000", Longitude = "18.61667000" },
                        new() { Id = 44, Name = "Gornji Vakuf", Latitude = "43.93806000", Longitude = "17.58833000" },
                        new() { Id = 45, Name = "Gostovići", Latitude = "44.41124000", Longitude = "18.17029000" },
                        new() { Id = 46, Name = "Gračanica", Latitude = "43.73333000", Longitude = "18.28333000" },
                        new() { Id = 47, Name = "Gradačac", Latitude = "44.87851000", Longitude = "18.42764000" },
                        new() { Id = 48, Name = "Gromiljak", Latitude = "43.96668000", Longitude = "18.05504000" },
                        new() { Id = 49, Name = "Grude", Latitude = "43.37208000", Longitude = "17.41449000" },
                        new() { Id = 50, Name = "Hadžići", Latitude = "43.82222000", Longitude = "18.20667000" },
                        new() { Id = 51, Name = "Hercegovačko-Neretvanski Kanton", Latitude = "43.45722000", Longitude = "17.81250000" },
                        new() { Id = 52, Name = "Hotonj", Latitude = "43.89341000", Longitude = "18.37751000" },
                        new() { Id = 53, Name = "Ilići", Latitude = "43.34765000", Longitude = "17.76848000" },
                        new() { Id = 54, Name = "Ilijaš", Latitude = "43.95128000", Longitude = "18.27128000" },
                        new() { Id = 55, Name = "Izačić", Latitude = "44.87485000", Longitude = "15.78256000" },
                        new() { Id = 56, Name = "Jablanica", Latitude = "43.66028000", Longitude = "17.76167000" },
                        new() { Id = 57, Name = "Jajce", Latitude = "44.34203000", Longitude = "17.27059000" },
                        new() { Id = 58, Name = "Jelah", Latitude = "44.65400000", Longitude = "17.95897000" },
                        new() { Id = 59, Name = "Jezerski", Latitude = "44.98172000", Longitude = "16.09447000" },
                        new() { Id = 60, Name = "Kačuni", Latitude = "44.06433000", Longitude = "17.93894000" },
                        new() { Id = 61, Name = "Kakanj", Latitude = "44.13311000", Longitude = "18.12292000" },
                        new() { Id = 62, Name = "Kanton Sarajevo", Latitude = "43.84333000", Longitude = "18.24222000" },
                        new() { Id = 63, Name = "Karadaglije", Latitude = "44.57065000", Longitude = "18.01775000" },
                        new() { Id = 64, Name = "Kiseljak", Latitude = "44.48904000", Longitude = "18.56982000" },
                        new() { Id = 65, Name = "Kladanj", Latitude = "44.22669000", Longitude = "18.69274000" },
                        new() { Id = 66, Name = "Ključ", Latitude = "44.53251000", Longitude = "16.77682000" },
                        new() { Id = 67, Name = "Kobilja Glava", Latitude = "43.88188000", Longitude = "18.38864000" },
                        new() { Id = 68, Name = "Kočerin", Latitude = "43.39005000", Longitude = "17.48552000" },
                        new() { Id = 69, Name = "Konjic", Latitude = "43.65126000", Longitude = "17.96082000" },
                        new() { Id = 70, Name = "Kovači", Latitude = "44.44874000", Longitude = "18.20521000" },
                        new() { Id = 71, Name = "Liješnica", Latitude = "44.49497000", Longitude = "18.07644000" },
                        new() { Id = 72, Name = "Livno", Latitude = "43.82695000", Longitude = "17.00746000" },
                        new() { Id = 73, Name = "Ljubuški", Latitude = "43.19694000", Longitude = "17.54500000" },
                        new() { Id = 74, Name = "Lokvine", Latitude = "44.20466000", Longitude = "17.85665000" },
                        new() { Id = 75, Name = "Lukavac", Latitude = "44.54245000", Longitude = "18.52618000" },
                        new() { Id = 76, Name = "Lukavica", Latitude = "44.76452000", Longitude = "18.16887000" },
                        new() { Id = 77, Name = "Maglaj", Latitude = "44.54771000", Longitude = "18.10003000" },
                        new() { Id = 78, Name = "Mahala", Latitude = "44.01194000", Longitude = "18.25528000" },
                        new() { Id = 79, Name = "Mala Kladuša", Latitude = "45.13443000", Longitude = "15.85217000" },
                        new() { Id = 80, Name = "Malešići", Latitude = "44.73824000", Longitude = "18.27335000" },
                        new() { Id = 81, Name = "Mionica", Latitude = "44.86646000", Longitude = "18.46603000" },
                        new() { Id = 82, Name = "Mostar", Latitude = "43.34333000", Longitude = "17.80806000" },
                        new() { Id = 83, Name = "Mramor", Latitude = "44.59234000", Longitude = "18.56458000" },
                        new() { Id = 84, Name = "Neum", Latitude = "42.92333000", Longitude = "17.61556000" },
                        new() { Id = 85, Name = "Novi Šeher", Latitude = "44.51031000", Longitude = "18.02624000" },
                        new() { Id = 86, Name = "Novi Travnik", Latitude = "44.17133000", Longitude = "17.65816000" },
                        new() { Id = 87, Name = "Odžak", Latitude = "45.02461000", Longitude = "18.32107000" },
                        new() { Id = 88, Name = "Olovo", Latitude = "44.12770000", Longitude = "18.58065000" },
                        new() { Id = 89, Name = "Omanjska", Latitude = "44.69831000", Longitude = "17.95757000" },
                        new() { Id = 90, Name = "Orahovica Donja", Latitude = "44.65345000", Longitude = "18.36951000" },
                        new() { Id = 91, Name = "Orašac", Latitude = "44.63039000", Longitude = "16.07443000" },
                        new() { Id = 92, Name = "Orašje", Latitude = "45.03366000", Longitude = "18.69334000" },
                        new() { Id = 93, Name = "Orguz", Latitude = "43.77414000", Longitude = "16.86329000" },
                        new() { Id = 94, Name = "Ostrožac", Latitude = "44.90866000", Longitude = "15.94045000" },
                        new() { Id = 95, Name = "Otoka", Latitude = "44.96000000", Longitude = "16.17917000" },
                        new() { Id = 96, Name = "Pajić Polje", Latitude = "43.97583000", Longitude = "17.52750000" },
                        new() { Id = 97, Name = "Pazarić", Latitude = "43.78882000", Longitude = "18.16049000" },
                        new() { Id = 98, Name = "Peći", Latitude = "44.63139000", Longitude = "16.78250000" },
                        new() { Id = 99, Name = "Pećigrad", Latitude = "45.05444000", Longitude = "15.89694000" },
                        new() { Id = 100, Name = "Pjanići", Latitude = "44.98568000", Longitude = "15.82304000" },
                        new() { Id = 101, Name = "Podhum", Latitude = "43.72295000", Longitude = "16.99887000" },
                        new() { Id = 102, Name = "Podzvizd", Latitude = "45.17417000", Longitude = "15.87361000" },
                        new() { Id = 103, Name = "Polje", Latitude = "43.88014000", Longitude = "18.07452000" },
                        new() { Id = 104, Name = "Polje-Bijela", Latitude = "43.63299000", Longitude = "17.97216000" },
                        new() { Id = 105, Name = "Potoci", Latitude = "43.40953000", Longitude = "17.87855000" },
                        new() { Id = 106, Name = "Prozor", Latitude = "43.82222000", Longitude = "17.60917000" },
                        new() { Id = 107, Name = "Puračić", Latitude = "44.54562000", Longitude = "18.47865000" },
                        new() { Id = 108, Name = "Radišići", Latitude = "43.22302000", Longitude = "17.54056000" },
                        new() { Id = 109, Name = "Rodoč", Latitude = "43.31453000", Longitude = "17.80290000" },
                        new() { Id = 110, Name = "Rumboci", Latitude = "43.83154000", Longitude = "17.50273000" },
                        new() { Id = 111, Name = "Sanica", Latitude = "44.61354000", Longitude = "16.64062000" },
                        new() { Id = 112, Name = "Sanski Most", Latitude = "44.76670000", Longitude = "16.66700000" },
                        new() { Id = 113, Name = "Sapna", Latitude = "44.50380000", Longitude = "18.99818000" },
                        new() { Id = 114, Name = "Sarajevo", Latitude = "43.84864000", Longitude = "18.35644000" },
                        new() { Id = 115, Name = "Šerići", Latitude = "44.46674000", Longitude = "18.56370000" },
                        new() { Id = 116, Name = "Široki Brijeg", Latitude = "43.38290000", Longitude = "17.59416000" },
                        new() { Id = 117, Name = "Skokovi", Latitude = "45.03139000", Longitude = "15.91444000" },
                        new() { Id = 118, Name = "Sladna", Latitude = "44.72897000", Longitude = "18.42575000" },
                        new() { Id = 119, Name = "Solina", Latitude = "44.56226000", Longitude = "18.69322000" },
                        new() { Id = 120, Name = "Srebrenik", Latitude = "44.70819000", Longitude = "18.48834000" },
                        new() { Id = 121, Name = "Stijena", Latitude = "44.93630000", Longitude = "16.02224000" },
                        new() { Id = 122, Name = "Stjepan-Polje", Latitude = "44.71634000", Longitude = "18.25783000" },
                        new() { Id = 123, Name = "Stolac", Latitude = "43.08400000", Longitude = "17.95995000" },
                        new() { Id = 124, Name = "Šturlić", Latitude = "45.06389000", Longitude = "15.77806000" },
                        new() { Id = 125, Name = "Šumatac", Latitude = "45.09743000", Longitude = "15.85818000" },
                        new() { Id = 126, Name = "Tasovčići", Latitude = "43.11333000", Longitude = "17.72000000" },
                        new() { Id = 127, Name = "Tešanj", Latitude = "44.61191000", Longitude = "17.98552000" },
                        new() { Id = 128, Name = "Tešanjka", Latitude = "44.67228000", Longitude = "18.01109000" },
                        new() { Id = 129, Name = "Todorovo", Latitude = "45.08833000", Longitude = "15.93083000" },
                        new() { Id = 130, Name = "Tojšići", Latitude = "44.50133000", Longitude = "18.78523000" },
                        new() { Id = 131, Name = "Tomislavgrad", Latitude = "43.71849000", Longitude = "17.22515000" },
                        new() { Id = 132, Name = "Travnik", Latitude = "44.22637000", Longitude = "17.66583000" },
                        new() { Id = 133, Name = "Tržačka Raštela", Latitude = "44.97597000", Longitude = "15.78489000" },
                        new() { Id = 134, Name = "Turbe", Latitude = "44.24352000", Longitude = "17.57499000" },
                        new() { Id = 135, Name = "Tuzla", Latitude = "44.53842000", Longitude = "18.66709000" },
                        new() { Id = 136, Name = "Ustikolina", Latitude = "43.58338000", Longitude = "18.79106000" },
                        new() { Id = 137, Name = "Vareš", Latitude = "44.16444000", Longitude = "18.32833000" },
                        new() { Id = 138, Name = "Varoška Rijeka", Latitude = "45.08936000", Longitude = "16.01906000" },
                        new() { Id = 139, Name = "Velagići", Latitude = "44.55618000", Longitude = "16.73349000" },
                        new() { Id = 140, Name = "Velika Kladuša", Latitude = "45.18497000", Longitude = "15.80579000" },
                        new() { Id = 141, Name = "Vidoši", Latitude = "43.77139000", Longitude = "17.02833000" },
                        new() { Id = 142, Name = "Visoko", Latitude = "43.98889000", Longitude = "18.17806000" },
                        new() { Id = 143, Name = "Vitez", Latitude = "44.15424000", Longitude = "17.79009000" },
                        new() { Id = 144, Name = "Vitina", Latitude = "43.23750000", Longitude = "17.48389000" },
                        new() { Id = 145, Name = "Vogošća", Latitude = "43.90225000", Longitude = "18.34438000" },
                        new() { Id = 146, Name = "Voljevac", Latitude = "43.87873000", Longitude = "17.65861000" },
                        new() { Id = 147, Name = "Vrnograč", Latitude = "45.16369000", Longitude = "15.95444000" },
                        new() { Id = 148, Name = "Vukovije Donje", Latitude = "44.46209000", Longitude = "18.74941000" },
                        new() { Id = 149, Name = "Zabrišće", Latitude = "43.79224000", Longitude = "16.94224000" },
                        new() { Id = 150, Name = "Zavidovići", Latitude = "44.44583000", Longitude = "18.14972000" },
                        new() { Id = 151, Name = "Zborište", Latitude = "45.14593000", Longitude = "16.01728000" },
                        new() { Id = 152, Name = "Željezno Polje", Latitude = "44.39875000", Longitude = "17.94103000" },
                        new() { Id = 153, Name = "Zenica", Latitude = "44.20169000", Longitude = "17.90397000" },
                        new() { Id = 154, Name = "Žepče", Latitude = "44.42667000", Longitude = "18.03778000" },
                        new() { Id = 155, Name = "Živinice", Latitude = "44.44929000", Longitude = "18.64978000" }
                    }
                },

                new()
                {
                    Id = 6,
                    Name = "Herzegovina-Neretva",
                    StateCode = "07",
                    Latitude = "43.52651590",
                    Longitude = "17.76362100",
                    Type = "canton",
                    Cities = new()
                    {
                    }
                },

                new()
                {
                    Id = 7,
                    Name = "Posavina",
                    StateCode = "02",
                    Latitude = "45.07520940",
                    Longitude = "18.37763040",
                    Type = "canton",
                    Cities = new()
                    {
                    }
                },

                new()
                {
                    Id = 8,
                    Name = "Republika Srpska",
                    StateCode = "SRP",
                    Latitude = "44.72801860",
                    Longitude = "17.31481360",
                    Type = "entity",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Balatun", Latitude = "44.86332000", Longitude = "19.33931000" },
                        new() { Id = 2, Name = "Banja Luka", Latitude = "44.77842000", Longitude = "17.19386000" },
                        new() { Id = 3, Name = "Bijeljina", Latitude = "44.76583000", Longitude = "19.15083000" },
                        new() { Id = 4, Name = "Bileća", Latitude = "42.87645000", Longitude = "18.42967000" },
                        new() { Id = 5, Name = "Blatnica", Latitude = "44.48677000", Longitude = "17.82278000" },
                        new() { Id = 6, Name = "Brod", Latitude = "45.13747000", Longitude = "17.98722000" },
                        new() { Id = 7, Name = "Bronzani Majdan", Latitude = "44.79237000", Longitude = "16.94039000" },
                        new() { Id = 8, Name = "Čajniče", Latitude = "43.55712000", Longitude = "19.07186000" },
                        new() { Id = 9, Name = "Čečava", Latitude = "44.67961000", Longitude = "17.75780000" },
                        new() { Id = 10, Name = "Čelinac", Latitude = "44.72453000", Longitude = "17.32431000" },
                        new() { Id = 11, Name = "Derventa", Latitude = "44.97839000", Longitude = "17.90779000" },
                        new() { Id = 12, Name = "Doboj", Latitude = "44.75944000", Longitude = "18.06500000" },
                        new() { Id = 13, Name = "Dobrljin", Latitude = "45.15106000", Longitude = "16.47869000" },
                        new() { Id = 14, Name = "Dvorovi", Latitude = "44.80753000", Longitude = "19.25999000" },
                        new() { Id = 15, Name = "Foča", Latitude = "43.50646000", Longitude = "18.77854000" },
                        new() { Id = 16, Name = "Gacko", Latitude = "43.16722000", Longitude = "18.53528000" },
                        new() { Id = 17, Name = "Gradiška", Latitude = "45.14484000", Longitude = "17.25453000" },
                        new() { Id = 18, Name = "Hiseti", Latitude = "44.76111000", Longitude = "17.17944000" },
                        new() { Id = 19, Name = "Istočni Mostar", Latitude = "43.42056000", Longitude = "18.00833000" },
                        new() { Id = 20, Name = "Janja", Latitude = "44.66554000", Longitude = "19.24691000" },
                        new() { Id = 21, Name = "Kalenderovci Donji", Latitude = "44.94673000", Longitude = "17.83785000" },
                        new() { Id = 22, Name = "Kneževo", Latitude = "44.49071000", Longitude = "17.38161000" },
                        new() { Id = 23, Name = "Knežica", Latitude = "45.10548000", Longitude = "16.67668000" },
                        new() { Id = 24, Name = "Koran", Latitude = "43.81038000", Longitude = "18.56999000" },
                        new() { Id = 25, Name = "Kostajnica", Latitude = "45.21956000", Longitude = "16.53929000" },
                        new() { Id = 26, Name = "Kotor Varoš", Latitude = "44.61831000", Longitude = "17.37204000" },
                        new() { Id = 27, Name = "Kozarska Dubica", Latitude = "45.17667000", Longitude = "16.80944000" },
                        new() { Id = 28, Name = "Krupa na Vrbasu", Latitude = "44.61875000", Longitude = "17.14351000" },
                        new() { Id = 29, Name = "Laktaši", Latitude = "44.90857000", Longitude = "17.30135000" },
                        new() { Id = 30, Name = "Lamovita", Latitude = "44.92018000", Longitude = "16.89933000" },
                        new() { Id = 31, Name = "Ljubinje", Latitude = "42.95120000", Longitude = "18.08702000" },
                        new() { Id = 32, Name = "Lopare", Latitude = "44.63498000", Longitude = "18.84340000" },
                        new() { Id = 33, Name = "Maglajani", Latitude = "44.94975000", Longitude = "17.35014000" },
                        new() { Id = 34, Name = "Marićka", Latitude = "44.86801000", Longitude = "16.85510000" },
                        new() { Id = 35, Name = "Maslovare", Latitude = "44.56594000", Longitude = "17.53216000" },
                        new() { Id = 36, Name = "Mejdan - Obilićevo", Latitude = "44.76324000", Longitude = "17.19012000" },
                        new() { Id = 37, Name = "Milići", Latitude = "44.17016000", Longitude = "19.09195000" },
                        new() { Id = 38, Name = "Modriča", Latitude = "44.95444000", Longitude = "18.30361000" },
                        new() { Id = 39, Name = "Mrkonjić Grad", Latitude = "44.41729000", Longitude = "17.08288000" },
                        new() { Id = 40, Name = "Nevesinje", Latitude = "43.25861000", Longitude = "18.11333000" },
                        new() { Id = 41, Name = "Novi Grad", Latitude = "45.04643000", Longitude = "16.37782000" },
                        new() { Id = 42, Name = "Obudovac", Latitude = "44.95215000", Longitude = "18.59869000" },
                        new() { Id = 43, Name = "Omarska", Latitude = "44.89170000", Longitude = "16.89814000" },
                        new() { Id = 44, Name = "Opština Oštra Luka", Latitude = "44.73278000", Longitude = "16.82861000" },
                        new() { Id = 45, Name = "Opština Višegrad", Latitude = "43.72167000", Longitude = "19.31361000" },
                        new() { Id = 46, Name = "Oštra Luka", Latitude = "44.99724000", Longitude = "18.58464000" },
                        new() { Id = 47, Name = "Pale", Latitude = "43.81664000", Longitude = "18.56949000" },
                        new() { Id = 48, Name = "Pelagićevo", Latitude = "44.90105000", Longitude = "18.59185000" },
                        new() { Id = 49, Name = "Petkovci", Latitude = "44.46849000", Longitude = "19.07466000" },
                        new() { Id = 50, Name = "Piskavica", Latitude = "44.86717000", Longitude = "16.97464000" },
                        new() { Id = 51, Name = "Podbrdo", Latitude = "44.44189000", Longitude = "17.01495000" },
                        new() { Id = 52, Name = "Popovi", Latitude = "44.76547000", Longitude = "19.28667000" },
                        new() { Id = 53, Name = "Pribinić", Latitude = "44.61010000", Longitude = "17.68981000" },
                        new() { Id = 54, Name = "Priboj", Latitude = "44.60233000", Longitude = "18.93165000" },
                        new() { Id = 55, Name = "Prijedor", Latitude = "44.97991000", Longitude = "16.71401000" },
                        new() { Id = 56, Name = "Rogatica", Latitude = "43.79894000", Longitude = "19.00363000" },
                        new() { Id = 57, Name = "Rudo", Latitude = "43.61781000", Longitude = "19.36719000" },
                        new() { Id = 58, Name = "Šamac", Latitude = "45.05987000", Longitude = "18.46756000" },
                        new() { Id = 59, Name = "Šekovići", Latitude = "44.29896000", Longitude = "18.85532000" },
                        new() { Id = 60, Name = "Šipovo", Latitude = "44.28237000", Longitude = "17.08597000" },
                        new() { Id = 61, Name = "Sokolac", Latitude = "43.93817000", Longitude = "18.80079000" },
                        new() { Id = 62, Name = "Srbac", Latitude = "45.09730000", Longitude = "17.52331000" },
                        new() { Id = 63, Name = "Srebrenica", Latitude = "44.10748000", Longitude = "19.29669000" },
                        new() { Id = 64, Name = "Stanari", Latitude = "44.74475000", Longitude = "17.82714000" },
                        new() { Id = 65, Name = "Starcevica", Latitude = "44.75708000", Longitude = "17.21178000" },
                        new() { Id = 66, Name = "Svodna", Latitude = "45.03770000", Longitude = "16.54019000" },
                        new() { Id = 67, Name = "Teslić", Latitude = "44.60639000", Longitude = "17.85972000" },
                        new() { Id = 68, Name = "Trebinje", Latitude = "42.71197000", Longitude = "18.34362000" },
                        new() { Id = 69, Name = "Trn", Latitude = "44.85829000", Longitude = "17.23583000" },
                        new() { Id = 70, Name = "Ugljevik", Latitude = "44.66361000", Longitude = "19.02028000" },
                        new() { Id = 71, Name = "Velika Obarska", Latitude = "44.80461000", Longitude = "19.16183000" },
                        new() { Id = 72, Name = "Višegrad", Latitude = "43.78260000", Longitude = "19.29256000" },
                        new() { Id = 73, Name = "Vlasenica", Latitude = "44.18183000", Longitude = "18.94096000" },
                        new() { Id = 74, Name = "Živinice", Latitude = "44.54765000", Longitude = "17.37357000" },
                        new() { Id = 75, Name = "Zvornik", Latitude = "44.38605000", Longitude = "19.10247000" }
                    }
                },

                new()
                {
                    Id = 9,
                    Name = "Sarajevo",
                    StateCode = "09",
                    Latitude = "43.85125640",
                    Longitude = "18.29534420",
                    Type = "canton",
                    Cities = new()
                    {
                    }
                },

                new()
                {
                    Id = 10,
                    Name = "Tuzla",
                    StateCode = "03",
                    Latitude = "44.53434630",
                    Longitude = "18.69727970",
                    Type = "canton",
                    Cities = new()
                    {
                    }
                },

                new()
                {
                    Id = 11,
                    Name = "Una-Sana",
                    StateCode = "01",
                    Latitude = "44.65031160",
                    Longitude = "16.31716290",
                    Type = "canton",
                    Cities = new()
                    {
                    }
                },

                new()
                {
                    Id = 12,
                    Name = "West Herzegovina",
                    StateCode = "08",
                    Latitude = "43.43692440",
                    Longitude = "17.38488310",
                    Type = "canton",
                    Cities = new()
                    {
                    }
                },

                new()
                {
                    Id = 13,
                    Name = "Zenica-Doboj",
                    StateCode = "04",
                    Latitude = "44.21271090",
                    Longitude = "18.16046250",
                    Type = "canton",
                    Cities = new()
                    {
                    }
                }
            }
        };
    }
}
