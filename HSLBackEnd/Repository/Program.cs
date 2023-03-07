using Repository.Contexts;
using Repository.Entities;
using System.Text.Json;

namespace Repository
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var source = new List<StationDTO>();

            using var reader = new StreamReader("C:\\repos\\HSLBikePlanner\\HSLBackEnd\\Repository\\seeding\\stationData.json");

            using (StreamReader r = new StreamReader("C:\\repos\\HSLBikePlanner\\HSLBackEnd\\Repository\\seeding\\stationData.json"))
            {
                string json = r.ReadToEnd();
                source = JsonSerializer.Deserialize<List<StationDTO>>(json);
            }

            var stations = source.Select(row => new Station
            {
                Name = row.name,
                StationId = row.stationId,
                Lat = row.lat,
                Lon = row.lon
            }).ToList();


            Console.WriteLine("starting to add stations");
            using var db = new BicycleDataContext();
            db.AddRange(stations);
            db.SaveChanges();

            Console.WriteLine("ready");
            Console.ReadLine();
        }
    }

    public class StationDTO
    {
        public string name { get; set; }
        public string stationId { get; set; }
        public decimal lat { get; set; }
        public decimal lon { get; set; }
    }
}