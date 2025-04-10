namespace ShowsOnSale.World.Models
{
    public class Timezone
    {
        public required string ZoneName { get; set; }
        public int GmtOffset { get; set; }
        public required string GmtOffsetName { get; set; }
        public required string Abbreviation { get; set; }
        public required string TzName { get; set; }

        public override string ToString()
        {
            return $"{ZoneName} ({GmtOffsetName})";
        }
    }
} 