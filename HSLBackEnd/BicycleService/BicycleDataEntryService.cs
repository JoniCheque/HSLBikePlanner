using BicycleService.Interfaces;
using Repository.Contexts;
using Repository.Entities;

namespace BicycleService
{
    public class BicycleDataEntryService : IBicycleDataEntryService
    {
        private BicycleDataContext _context;

        public BicycleDataEntryService(BicycleDataContext db)
        {
            _context = db;
        }


        public BicycleDataEntry GetFirst()
        {
            var first = _context.BicycleDataEntries.First();

            return first;
        }


        public int GetTotalCountOfEntries()
        { 
            return _context.BicycleDataEntries.Count();
        }

        public IEnumerable<BicycleDataEntry> GetLongestDistances(int amountOfEntries)
        {
            return _context.BicycleDataEntries
                .OrderByDescending(entry => entry.Distance)
                .Take(amountOfEntries)
                .ToList();
        }

        public IEnumerable<BicycleDataEntry> GetShortestDistances(int amountOfEntries)
        {
            return _context.BicycleDataEntries
                .OrderBy(entry => entry.Distance)
                .Take(amountOfEntries)
                .ToList();
        }

        public IEnumerable<BicycleDataEntry> GetLongestDurations(int amountOfEntries)
        {
            return _context.BicycleDataEntries
                .OrderByDescending(entry => entry.Duration)
                .Take(amountOfEntries)
                .ToList();
        }

        public IEnumerable<BicycleDataEntry> GetShortestDurations(int amountOfEntries)
        {
            return _context.BicycleDataEntries
                .OrderBy(entry => entry.Duration)
                .Take(amountOfEntries)
                .ToList();
        }

        public IEnumerable<BicycleDataEntry> GetLongestDistancesByStationId(string stationId, int amountOfEntries)
        {
            return _context.BicycleDataEntries
                .Where(entry => entry.DepartureStationId == stationId)
                .OrderByDescending(entry => entry.Distance)
                .Take(amountOfEntries)
                .ToList();
        }

        public IEnumerable<BicycleDataEntry> GetShortestDistancesByStationId(string stationId, int amountOfEntries)
        {
            return _context.BicycleDataEntries
                .Where(entry => entry.DepartureStationId == stationId)
                .OrderBy(entry => entry.Distance)
                .Take(amountOfEntries)
                .ToList();
        }

        public IEnumerable<BicycleDataEntry> GetLongestDurationsByStationId(string stationId, int amountOfEntries)
        {
            return _context.BicycleDataEntries
                .Where(entry => entry.DepartureStationId == stationId)
                .OrderByDescending(entry => entry.Duration)
                .Take(amountOfEntries)
                .ToList();
        }

        public IEnumerable<BicycleDataEntry> GetShortestDurationsByStationId(string stationId, int amountOfEntries)
        {
            return _context.BicycleDataEntries
                .Where(entry => entry.DepartureStationId == stationId)
                .OrderBy(entry => entry.Duration)
                .Take(amountOfEntries)
                .ToList();
        }
    }
}
