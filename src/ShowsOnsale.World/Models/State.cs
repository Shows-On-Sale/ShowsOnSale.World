using System.Collections.Generic;

namespace ShowsOnSale.World.Models
{
    public class State
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string StateCode { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string Type { get; set; }
        public List<City> Cities { get; set; }

        public override string ToString()
        {
            return $"{Name} ({StateCode})";
        }
    }
} 