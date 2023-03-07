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
        public decimal Distance { get; set; }
        public uint Duration { get; set; }

        public static BicycleDataEntry FromCsv(string line)
        {
            string[] values = line.Split(',');
            try
            {
                var bicycleDataEntry = new BicycleDataEntry();

                bicycleDataEntry.Departure = Convert.ToDateTime(values[0]);
                bicycleDataEntry.Return = Convert.ToDateTime(values[1]);
                bicycleDataEntry.DepartureStationId = values[2];
                bicycleDataEntry.DepartureStationName = values[3];
                bicycleDataEntry.ReturnStationId = values[4];

                bicycleDataEntry.ReturnStationName = values[5];

                if (string.IsNullOrWhiteSpace(values[6]))
                    bicycleDataEntry.Distance = 0;

                else if (values[6].Contains("."))
                    bicycleDataEntry.Distance = Convert.ToDecimal(values[6].Replace(".", ","));

                else
                    bicycleDataEntry.Distance = Convert.ToDecimal(values[6]);

                bicycleDataEntry.Duration = Convert.ToUInt32(values[7]);

                return bicycleDataEntry;
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
