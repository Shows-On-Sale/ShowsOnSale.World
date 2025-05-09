// ⚠️ WARNING: This file is automatically generated by scripts/generate-world.ps1
// DO NOT modify this file manually as it will be overwritten when the script is run again.
// To update the data, modify the source data in countries-states-cities-database and run the script.

using System.Collections.Generic;
using ShowsOnSale.World.Models;

namespace ShowsOnSale.World.Data.Countries
{
    public static class Mauritius
    {
        public static Country Data { get; } = new()
        {
            Id = 138,
            Name = "Mauritius",
            Iso3 = "MUS",
            Iso2 = "MU",
            NumericCode = "480",
            PhoneCode = "230",
            Capital = "Port Louis",
            Currency = "MUR",
            CurrencyName = "Mauritian rupee",
            CurrencySymbol = "₨",
            Tld = ".mu",
            Native = "Maurice",
            Region = "Africa",
            RegionId = 1,
            Subregion = "Eastern Africa",
            SubregionId = 4,
            Nationality = "Mauritian",
            Latitude = "-20.28333333",
            Longitude = "57.55000000",
            Emoji = "🇲🇺",
            EmojiU = "U+1F1F2 U+1F1FA",
            Timezones = new()
            {
                new() { ZoneName = "Indian/Mauritius", GmtOffset = 14400, GmtOffsetName = "UTC+04:00", Abbreviation = "MUT", TzName = "Mauritius Time" }
            },
            Translations = new()
            {
                ["ko"] = "모리셔스",
                ["pt-BR"] = "Maurício",
                ["pt"] = "Maurícia",
                ["nl"] = "Mauritius",
                ["hr"] = "Mauricijus",
                ["fa"] = "موریس",
                ["de"] = "Mauritius",
                ["es"] = "Mauricio",
                ["fr"] = "Île Maurice",
                ["ja"] = "モーリシャス",
                ["it"] = "Mauritius",
                ["zh-CN"] = "毛里求斯",
                ["tr"] = "Morityus",
                ["ru"] = "Маврикий",
                ["uk"] = "Маврикій",
                ["pl"] = "Mauritius"
            },
            States = new()
            {

                new()
                {
                    Id = 1,
                    Name = "Agalega Islands",
                    StateCode = "AG",
                    Latitude = "-10.40000000",
                    Longitude = "56.61666670",
                    Type = "dependency",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Vingt Cinq", Latitude = "-10.38803000", Longitude = "56.61795000" }
                    }
                },

                new()
                {
                    Id = 2,
                    Name = "Black River",
                    StateCode = "BL",
                    Latitude = "-20.37084920",
                    Longitude = "57.39486490",
                    Type = "district",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Albion", Latitude = "-20.20814000", Longitude = "57.40766000" },
                        new() { Id = 2, Name = "Bambous", Latitude = "-20.25667000", Longitude = "57.40611000" },
                        new() { Id = 3, Name = "Black River", Latitude = "-20.32047900", Longitude = "57.40372500" },
                        new() { Id = 4, Name = "Cascavelle", Latitude = "-20.28694000", Longitude = "57.40722000" },
                        new() { Id = 5, Name = "Case Noyale", Latitude = "-20.41370400", Longitude = "57.36906500" },
                        new() { Id = 6, Name = "Chamarel", Latitude = "-20.42523600", Longitude = "57.39116500" },
                        new() { Id = 7, Name = "Flic en Flac", Latitude = "-20.27417000", Longitude = "57.36306000" },
                        new() { Id = 8, Name = "Grande Rivière Noire", Latitude = "-20.36028000", Longitude = "57.36611000" },
                        new() { Id = 9, Name = "Gros Cailloux", Latitude = "-20.20722000", Longitude = "57.43000000" },
                        new() { Id = 10, Name = "La Gaulette", Latitude = "-20.42938800", Longitude = "57.35884100" },
                        new() { Id = 11, Name = "Le Morne", Latitude = "-20.44417400", Longitude = "57.33031500" },
                        new() { Id = 12, Name = "Petite Case Noyale", Latitude = "-20.39306000", Longitude = "57.36500000" },
                        new() { Id = 13, Name = "Petite Rivière", Latitude = "-20.19551000", Longitude = "57.44592000" },
                        new() { Id = 14, Name = "Richelieu", Latitude = "-20.19084900", Longitude = "57.46129900" },
                        new() { Id = 15, Name = "Tamarin", Latitude = "-20.32556000", Longitude = "57.37056000" }
                    }
                },

                new()
                {
                    Id = 3,
                    Name = "Flacq",
                    StateCode = "FL",
                    Latitude = "-20.22578360",
                    Longitude = "57.71192740",
                    Type = "district",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Bel Air", Latitude = "-20.25849300", Longitude = "57.75498700" },
                        new() { Id = 2, Name = "Bel Air Rivière Sèche", Latitude = "-20.25777000", Longitude = "57.74976000" },
                        new() { Id = 3, Name = "Bon Accueil", Latitude = "-20.17083000", Longitude = "57.65639000" },
                        new() { Id = 4, Name = "Bramsthan", Latitude = "-20.21297900", Longitude = "57.73768000" },
                        new() { Id = 5, Name = "Brisée Verdière", Latitude = "-20.16389000", Longitude = "57.64667000" },
                        new() { Id = 6, Name = "Camp de Masque", Latitude = "-20.23694000", Longitude = "57.66333000" },
                        new() { Id = 7, Name = "Camp De Masque Pave", Latitude = "-20.25006300", Longitude = "57.67997000" },
                        new() { Id = 8, Name = "Camp Ithier", Latitude = "-20.21583000", Longitude = "57.74556000" },
                        new() { Id = 9, Name = "Centre de Flacq", Latitude = "-20.18972000", Longitude = "57.71444000" },
                        new() { Id = 10, Name = "Clémencia", Latitude = "-20.26389000", Longitude = "57.70611000" },
                        new() { Id = 11, Name = "Ecroignard", Latitude = "-20.22611000", Longitude = "57.73611000" },
                        new() { Id = 12, Name = "Grande Retraite", Latitude = "-20.16507700", Longitude = "57.69461600" },
                        new() { Id = 13, Name = "Grande Rivière Sud Est", Latitude = "-20.28611000", Longitude = "57.77583000" },
                        new() { Id = 14, Name = "Lalmatie", Latitude = "-20.18972000", Longitude = "57.66111000" },
                        new() { Id = 15, Name = "Laventure", Latitude = "-20.14583000", Longitude = "57.67667000" },
                        new() { Id = 16, Name = "Mare La Chaux", Latitude = "-20.19806000", Longitude = "57.74944000" },
                        new() { Id = 17, Name = "Medine Camp De Masque", Latitude = "-20.24395800", Longitude = "57.64703500" },
                        new() { Id = 18, Name = "Olivia", Latitude = "-20.28778000", Longitude = "57.73097000" },
                        new() { Id = 19, Name = "Poste de Flacq", Latitude = "-20.16306000", Longitude = "57.73056000" },
                        new() { Id = 20, Name = "Quatre Cocos", Latitude = "-20.20151000", Longitude = "57.77448000" },
                        new() { Id = 21, Name = "Quatre Soeurs", Latitude = "-20.29917000", Longitude = "57.77056000" },
                        new() { Id = 22, Name = "Queen Victoria", Latitude = "-20.22000000", Longitude = "57.70750000" },
                        new() { Id = 23, Name = "Saint Julien", Latitude = "-20.22639000", Longitude = "57.63639000" },
                        new() { Id = 24, Name = "Sebastopol", Latitude = "-20.29070000", Longitude = "57.68779000" },
                        new() { Id = 25, Name = "Trou D'Eau Douce", Latitude = "-20.23458600", Longitude = "57.79486100" }
                    }
                },

                new()
                {
                    Id = 4,
                    Name = "Grand Port",
                    StateCode = "GP",
                    Latitude = "-20.38515460",
                    Longitude = "57.66657420",
                    Type = "district",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Bambous Virieux", Latitude = "-20.34278000", Longitude = "57.75750000" },
                        new() { Id = 2, Name = "Beau Vallon", Latitude = "-20.41889000", Longitude = "57.69528000" },
                        new() { Id = 3, Name = "Bois des Amourettes", Latitude = "-20.36306000", Longitude = "57.73111000" },
                        new() { Id = 4, Name = "Camp Carol", Latitude = "-20.46178500", Longitude = "57.67845600" },
                        new() { Id = 5, Name = "Cluny", Latitude = "-20.36694000", Longitude = "57.60389000" },
                        new() { Id = 6, Name = "Grand Bel Air", Latitude = "-20.40912400", Longitude = "57.68174200" },
                        new() { Id = 7, Name = "Grand Sable", Latitude = "-20.31417000", Longitude = "57.76444000" },
                        new() { Id = 8, Name = "Mahébourg", Latitude = "-20.40806000", Longitude = "57.70000000" },
                        new() { Id = 9, Name = "Mare D'Albert", Latitude = "-20.42019500", Longitude = "57.62728800" },
                        new() { Id = 10, Name = "Mare Tabac", Latitude = "-20.44035800", Longitude = "57.59421500" },
                        new() { Id = 11, Name = "New Grove", Latitude = "-20.40861000", Longitude = "57.61361000" },
                        new() { Id = 12, Name = "Nouvelle France", Latitude = "-20.37056000", Longitude = "57.56111000" },
                        new() { Id = 13, Name = "Petit Bel Air", Latitude = "-20.39941200", Longitude = "57.69295900" },
                        new() { Id = 14, Name = "Plaine Magnien", Latitude = "-20.42967000", Longitude = "57.66968000" },
                        new() { Id = 15, Name = "Riviere Des Creoles", Latitude = "-20.39084000", Longitude = "57.69696000" },
                        new() { Id = 16, Name = "Rose Belle", Latitude = "-20.40028000", Longitude = "57.59667000" },
                        new() { Id = 17, Name = "Saint Hubert", Latitude = "-20.36417000", Longitude = "57.63833000" },
                        new() { Id = 18, Name = "Seizieme Mille", Latitude = "-20.34211100", Longitude = "57.54924400" },
                        new() { Id = 19, Name = "Trois Boutiques", Latitude = "-20.45046100", Longitude = "57.64682900" },
                        new() { Id = 20, Name = "Union Park", Latitude = "-20.38629400", Longitude = "57.58068000" },
                        new() { Id = 21, Name = "Vieux Grand Port", Latitude = "-20.37406600", Longitude = "57.71607700" }
                    }
                },

                new()
                {
                    Id = 5,
                    Name = "Moka",
                    StateCode = "MO",
                    Latitude = "-20.23997820",
                    Longitude = "57.57592600",
                    Type = "district",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Camp Thorel", Latitude = "-20.21472000", Longitude = "57.61611000" },
                        new() { Id = 2, Name = "Dagotière", Latitude = "-20.24476000", Longitude = "57.56188000" },
                        new() { Id = 3, Name = "Dubreuil", Latitude = "-20.30132000", Longitude = "57.59861000" },
                        new() { Id = 4, Name = "L'Avenir", Latitude = "-20.21714200", Longitude = "57.55048200" },
                        new() { Id = 5, Name = "L'Esperance", Latitude = "-20.23041300", Longitude = "57.59526800" },
                        new() { Id = 6, Name = "La Laura-Malenga", Latitude = "-20.20386100", Longitude = "57.54991500" },
                        new() { Id = 7, Name = "Melrose", Latitude = "-20.26972000", Longitude = "57.63194000" },
                        new() { Id = 8, Name = "Moka", Latitude = "-20.21889000", Longitude = "57.49583000" },
                        new() { Id = 9, Name = "Montagne Blanche", Latitude = "-20.28592000", Longitude = "57.65774600" },
                        new() { Id = 10, Name = "Nouvelle Découverte", Latitude = "-20.18600000", Longitude = "57.59079700" },
                        new() { Id = 11, Name = "Pailles", Latitude = "-20.19271000", Longitude = "57.48826000" },
                        new() { Id = 12, Name = "Providence", Latitude = "-20.24472000", Longitude = "57.61222000" },
                        new() { Id = 13, Name = "Quartier Militaire", Latitude = "-20.24790000", Longitude = "57.59737000" },
                        new() { Id = 14, Name = "Ripailles", Latitude = "-20.19472500", Longitude = "57.58059600" },
                        new() { Id = 15, Name = "Saint Julien D'Hotman", Latitude = "-20.23067000", Longitude = "57.64037800" },
                        new() { Id = 16, Name = "Saint Pierre", Latitude = "-20.21750000", Longitude = "57.52083000" },
                        new() { Id = 17, Name = "Verdun", Latitude = "-20.23417000", Longitude = "57.55476000" }
                    }
                },

                new()
                {
                    Id = 6,
                    Name = "Pamplemousses",
                    StateCode = "PA",
                    Latitude = "-20.11360080",
                    Longitude = "57.57592600",
                    Type = "district",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Arsenal", Latitude = "-20.10556000", Longitude = "57.53528000" },
                        new() { Id = 2, Name = "Calebasses", Latitude = "-20.11167000", Longitude = "57.55389000" },
                        new() { Id = 3, Name = "Congomah", Latitude = "-20.14889000", Longitude = "57.59083000" },
                        new() { Id = 4, Name = "Crève Coeur", Latitude = "-20.19111000", Longitude = "57.55722000" },
                        new() { Id = 5, Name = "D'Epinay", Latitude = "-20.13021100", Longitude = "57.59583800" },
                        new() { Id = 6, Name = "Fond du Sac", Latitude = "-20.04732000", Longitude = "57.58400000" },
                        new() { Id = 7, Name = "Le Hochet", Latitude = "-20.13500000", Longitude = "57.52111000" },
                        new() { Id = 8, Name = "Long Mountain", Latitude = "-20.14306000", Longitude = "57.56222000" },
                        new() { Id = 9, Name = "Morcellement Saint André", Latitude = "-20.07199000", Longitude = "57.56833000" },
                        new() { Id = 10, Name = "Notre Dame", Latitude = "-20.14056000", Longitude = "57.55306000" },
                        new() { Id = 11, Name = "Pamplemousses", Latitude = "-20.10389000", Longitude = "57.57028000" },
                        new() { Id = 12, Name = "Plaine des Papayes", Latitude = "-20.06500000", Longitude = "57.57250000" },
                        new() { Id = 13, Name = "Pointe aux Piments", Latitude = "-20.06494000", Longitude = "57.52347000" },
                        new() { Id = 14, Name = "Terre Rouge", Latitude = "-20.12611000", Longitude = "57.52444000" },
                        new() { Id = 15, Name = "Tombeau Bay", Latitude = "-20.12345100", Longitude = "57.50218400" },
                        new() { Id = 16, Name = "Triolet", Latitude = "-20.05760000", Longitude = "57.55025000" },
                        new() { Id = 17, Name = "Trou Aux Biches", Latitude = "-20.03123500", Longitude = "57.55189700" },
                        new() { Id = 18, Name = "Ville Bague", Latitude = "-20.14604500", Longitude = "57.62414900" }
                    }
                },

                new()
                {
                    Id = 7,
                    Name = "Plaines Wilhems",
                    StateCode = "PW",
                    Latitude = "-20.30548720",
                    Longitude = "57.48535610",
                    Type = "district",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Beau Bassin", Latitude = "-20.22538700", Longitude = "57.47145500" },
                        new() { Id = 2, Name = "Beau Bassin-Rose Hill", Latitude = "-20.23325000", Longitude = "57.46609000" },
                        new() { Id = 3, Name = "Belle Terre", Latitude = "-20.26948370", Longitude = "57.51655530" },
                        new() { Id = 4, Name = "Camp Fouqueraux", Latitude = "-20.28568630", Longitude = "57.51718270" },
                        new() { Id = 5, Name = "Chebel", Latitude = "-20.21373190", Longitude = "57.46075450" },
                        new() { Id = 6, Name = "Coromandel", Latitude = "-20.19522920", Longitude = "57.44565340" },
                        new() { Id = 7, Name = "Curepipe", Latitude = "-20.31628000", Longitude = "57.52594000" },
                        new() { Id = 8, Name = "Eau Coulee", Latitude = "-20.30336600", Longitude = "57.52778800" },
                        new() { Id = 9, Name = "Ebene", Latitude = "-20.24494000", Longitude = "57.49163000" },
                        new() { Id = 10, Name = "Floreal", Latitude = "-20.31121400", Longitude = "57.50726300" },
                        new() { Id = 11, Name = "Forest Side", Latitude = "-20.32952100", Longitude = "57.53898100" },
                        new() { Id = 12, Name = "Glen Park", Latitude = "-20.32440680", Longitude = "57.47531880" },
                        new() { Id = 13, Name = "Henrietta", Latitude = "-20.27200480", Longitude = "57.52898870" },
                        new() { Id = 14, Name = "Hermitage", Latitude = "-20.27685080", Longitude = "57.53471370" },
                        new() { Id = 15, Name = "Highlands", Latitude = "-20.27827480", Longitude = "57.51350410" },
                        new() { Id = 16, Name = "Midlands", Latitude = "-20.31907000", Longitude = "57.57016000" },
                        new() { Id = 17, Name = "Phoenix", Latitude = "-20.28584460", Longitude = "57.50291860" },
                        new() { Id = 18, Name = "Quatre Bornes", Latitude = "-20.26381000", Longitude = "57.47910000" },
                        new() { Id = 19, Name = "Rose Hill", Latitude = "-20.24347800", Longitude = "57.46985500" },
                        new() { Id = 20, Name = "Vacoas", Latitude = "-20.29806000", Longitude = "57.47833000" }
                    }
                },

                new()
                {
                    Id = 8,
                    Name = "Port Louis",
                    StateCode = "PL",
                    Latitude = "-20.16089120",
                    Longitude = "57.50122220",
                    Type = "district",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Bell Village", Latitude = "-20.17049700", Longitude = "57.48618400" },
                        new() { Id = 2, Name = "Caudan Waterfront", Latitude = "-20.16089880", Longitude = "57.49772560" },
                        new() { Id = 3, Name = "China Town", Latitude = "-20.15879700", Longitude = "57.50678900" },
                        new() { Id = 4, Name = "Les Pailles", Latitude = "-20.19352700", Longitude = "57.48962900" },
                        new() { Id = 5, Name = "Les Salines", Latitude = "-20.16016800", Longitude = "57.48904100" },
                        new() { Id = 6, Name = "Plaine Verte", Latitude = "-20.15841000", Longitude = "57.51421500" },
                        new() { Id = 7, Name = "Pointe aux Sables", Latitude = "-20.17168700", Longitude = "57.45389300" },
                        new() { Id = 8, Name = "Port Louis", Latitude = "-20.16194000", Longitude = "57.49889000" },
                        new() { Id = 9, Name = "Soreze", Latitude = "-20.20856100", Longitude = "57.48638200" },
                        new() { Id = 10, Name = "Tour Koenig", Latitude = "-20.17864600", Longitude = "57.46872100" },
                        new() { Id = 11, Name = "Tranquebar", Latitude = "-20.17681600", Longitude = "57.51132900" },
                        new() { Id = 12, Name = "Vallée des Prêtres", Latitude = "-20.16514700", Longitude = "57.53403900" },
                        new() { Id = 13, Name = "Vallee Pitot", Latitude = "-20.16920000", Longitude = "57.51997000" }
                    }
                },

                new()
                {
                    Id = 9,
                    Name = "Rivière du Rempart",
                    StateCode = "RR",
                    Latitude = "-20.05609830",
                    Longitude = "57.65523890",
                    Type = "district",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Amaury", Latitude = "-20.13083000", Longitude = "57.65917000" },
                        new() { Id = 2, Name = "Amitié Gokoola", Latitude = "-20.10688300", Longitude = "57.65472800" },
                        new() { Id = 3, Name = "Cap Malheureux", Latitude = "-19.98417000", Longitude = "57.61417000" },
                        new() { Id = 4, Name = "Cottage", Latitude = "-20.05972000", Longitude = "57.62917000" },
                        new() { Id = 5, Name = "Espérance Trébuchet", Latitude = "-20.06972000", Longitude = "57.64194000" },
                        new() { Id = 6, Name = "Goodlands", Latitude = "-20.03841000", Longitude = "57.65055000" },
                        new() { Id = 7, Name = "Grand Baie", Latitude = "-20.01816000", Longitude = "57.58015000" },
                        new() { Id = 8, Name = "Grand Gaube", Latitude = "-20.00639000", Longitude = "57.66083000" },
                        new() { Id = 9, Name = "Mapou", Latitude = "-20.07583000", Longitude = "57.60139000" },
                        new() { Id = 10, Name = "Petit Raffray", Latitude = "-20.02022000", Longitude = "57.62296000" },
                        new() { Id = 11, Name = "Piton", Latitude = "-20.09028000", Longitude = "57.63028000" },
                        new() { Id = 12, Name = "Plaines des Roches", Latitude = "-20.11167000", Longitude = "57.69083000" },
                        new() { Id = 13, Name = "Poudre D'Or", Latitude = "-20.06162700", Longitude = "57.68297100" },
                        new() { Id = 14, Name = "Poudre D'Or Hamlet", Latitude = "-20.08102400", Longitude = "57.65272600" },
                        new() { Id = 15, Name = "Rivière du Rempart", Latitude = "-20.10306000", Longitude = "57.68472000" },
                        new() { Id = 16, Name = "Roche Terre", Latitude = "-20.01861000", Longitude = "57.64472000" },
                        new() { Id = 17, Name = "Roches Noire", Latitude = "-20.11111000", Longitude = "57.71222000" },
                        new() { Id = 18, Name = "The Vale", Latitude = "-20.03018000", Longitude = "57.60219000" }
                    }
                },

                new()
                {
                    Id = 10,
                    Name = "Rodrigues Island",
                    StateCode = "RO",
                    Latitude = "-19.72453850",
                    Longitude = "63.42721850",
                    Type = "dependency",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Baie aux Huîtres", Latitude = "-19.69444000", Longitude = "63.40833000" },
                        new() { Id = 2, Name = "Port Mathurin", Latitude = "-19.68333000", Longitude = "63.41667000" }
                    }
                },

                new()
                {
                    Id = 11,
                    Name = "Saint Brandon Islands",
                    StateCode = "CC",
                    Latitude = "-16.58333300",
                    Longitude = "59.61666700",
                    Type = "dependency",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Cargados Carajos", Latitude = "-16.60329000", Longitude = "59.65851000" }
                    }
                },

                new()
                {
                    Id = 12,
                    Name = "Savanne",
                    StateCode = "SA",
                    Latitude = "-20.47395300",
                    Longitude = "57.48535610",
                    Type = "district",
                    Cities = new()
                    {
                        new() { Id = 1, Name = "Baie Du Cap", Latitude = "-20.48664400", Longitude = "57.37881500" },
                        new() { Id = 2, Name = "Bel Ombre", Latitude = "-20.50191900", Longitude = "57.42550700" },
                        new() { Id = 3, Name = "Benares", Latitude = "-20.48440700", Longitude = "57.58871700" },
                        new() { Id = 4, Name = "Bois Cheri", Latitude = "-20.42667100", Longitude = "57.53425200" },
                        new() { Id = 5, Name = "Britannia", Latitude = "-20.44865500", Longitude = "57.56340700" },
                        new() { Id = 6, Name = "Camp Diable", Latitude = "-20.46278000", Longitude = "57.57889000" },
                        new() { Id = 7, Name = "Chamouny", Latitude = "-20.48222000", Longitude = "57.46611000" },
                        new() { Id = 8, Name = "Chemin Grenier", Latitude = "-20.48722000", Longitude = "57.46556000" },
                        new() { Id = 9, Name = "Grand Bois", Latitude = "-20.41889000", Longitude = "57.54417000" },
                        new() { Id = 10, Name = "L'Escalier", Latitude = "-20.47333500", Longitude = "57.61867600" },
                        new() { Id = 11, Name = "La Flora", Latitude = "-20.41000500", Longitude = "57.56048700" },
                        new() { Id = 12, Name = "Rivière des Anguilles", Latitude = "-20.48528000", Longitude = "57.55083000" },
                        new() { Id = 13, Name = "Rivière Du Poste", Latitude = "-20.42866200", Longitude = "57.57368100" },
                        new() { Id = 14, Name = "Saint Aubin", Latitude = "-20.49600000", Longitude = "57.55000000" },
                        new() { Id = 15, Name = "Souillac", Latitude = "-20.51667000", Longitude = "57.51667000" },
                        new() { Id = 16, Name = "St Aubin", Latitude = "-20.49444600", Longitude = "57.55033500" },
                        new() { Id = 17, Name = "Surinam", Latitude = "-20.50972000", Longitude = "57.50528000" }
                    }
                }
            }
        };
    }
}
