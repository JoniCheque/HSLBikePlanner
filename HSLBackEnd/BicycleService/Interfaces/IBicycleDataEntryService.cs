using Repository.Entities;

namespace BicycleService.Interfaces
{
    public interface IBicycleDataEntryService
    {
        BicycleDataEntry GetFirst();
        int GetTotalCountOfEntries();
        IEnumerable<BicycleDataEntry> GetLongestDistances(int amountOfEntries);
        IEnumerable<BicycleDataEntry> GetShortestDistances(int amountOfEntries);
        IEnumerable<BicycleDataEntry> GetLongestDurations(int amountOfEntries);
        IEnumerable<BicycleDataEntry> GetShortestDurations(int amountOfEntries);
        //IEnumerable<BicycleDataEntry> GetLongestDistancesByStationId(string stationId, int amountOfEntries);
        //IEnumerable<BicycleDataEntry> GetShortestDistancesByStationId(string stationId, int amountOfEntries);
        //IEnumerable<BicycleDataEntry> GetLongestDurationsByStationId(string stationId, int amountOfEntries);
        //IEnumerable<BicycleDataEntry> GetShortestDurationsByStationId(string stationId, int amountOfEntries);
    }
}