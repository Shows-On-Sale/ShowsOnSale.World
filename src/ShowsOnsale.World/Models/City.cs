namespace ShowsOnSale.World.Models
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }

        public override string ToString()
        {
            return $"{Name} ({Latitude}, {Longitude})";
        }
    }
} 