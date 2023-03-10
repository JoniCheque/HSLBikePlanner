namespace Repository.Entities
{
    public class BicycleDataEntry
    {
        public int Id { get; set; }
        public DateTime Departure { get; set; }
        public DateTime Return { get; set; }
        public string DepartureStationId { get; set; }
        public string DepartureStationName { get; set; }
        public string ReturnStationId { get; set; }
        public string ReturnStationName { get; set; }
        public int Distance { get; set; }
        public int Duration { get; set; }
    }
}
