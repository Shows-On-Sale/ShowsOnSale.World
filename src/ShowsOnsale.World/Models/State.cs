using System.Collections.Generic;

namespace ShowsOnSale.World.Models
{
    public class State
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string StateCode { get; set; }
        public required string Latitude { get; set; }
        public required string Longitude { get; set; }
        public required string Type { get; set; }
        public required List<City> Cities { get; set; }

        public override string ToString()
        {
            return $"{Name} ({StateCode})";
        }
    }
} 