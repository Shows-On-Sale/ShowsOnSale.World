namespace ShowsOnSale.World.Models
{
    public class Timezone
    {
        public string ZoneName { get; set; }
        public int GmtOffset { get; set; }
        public string GmtOffsetName { get; set; }
        public string Abbreviation { get; set; }
        public string TzName { get; set; }

        public override string ToString()
        {
            return $"{ZoneName} ({GmtOffsetName})";
        }
    }
} 