namespace BicycleService.DTO
{
    public class StationDataInformationDto
    {
        public int StationId { get; set; }
        public string StationStrId { get; set; }
        public int LongestDistance { get; set; }
        public int ShortestDistance { get; set; }
        public int LongestDuration { get; set; }
        public int ShortestDuration { get; set; }
        public decimal Lat { get; set; }
        public decimal Lon { get; set; }
        public string StationName { get; set; }
    }
}
