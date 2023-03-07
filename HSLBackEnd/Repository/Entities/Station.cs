using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Entities
{
    public class Station
    {
        public string Name { get; set; }
        public string StationId { get; set; }
        public decimal Lat { get; set; }
        public decimal Lon { get; set; }
    }
}
