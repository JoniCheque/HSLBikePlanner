namespace Repository.Entities
{
    public class Station
    {
        public int StationId { get; set; }
        public string Name { get; set; }
        public string StationStrId { get; set; }
        public decimal Lat { get; set; }
        public decimal Lon { get; set; }
    }
}
