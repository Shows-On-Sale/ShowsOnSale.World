namespace ShowsOnSale.World.Models
{
    public class City
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Latitude { get; set; }
        public required string Longitude { get; set; }

        public override string ToString()
        {
            return $"{Name} ({Latitude}, {Longitude})";
        }
    }
} 