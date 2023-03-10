using BicycleService.DTO;
using BicycleService.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repository.Contexts;
using Repository.Entities;

namespace BicycleService
{
    public class StationService : IStationService
    {
        private BicycleDataContext _context;
        private IBicycleDataEntryService _bicycleDataEntryService;

        public StationService(BicycleDataContext db, IBicycleDataEntryService bicycleDataEntryService)
        {
            _context = db;
            _bicycleDataEntryService = bicycleDataEntryService;
        }

        public IEnumerable<Station> GetStations()
        {
            return _context.Stations.Select(station => station);
        }

        public StationDataInformationDto GetStationInformation(string stationStrId)
        {
            var queryThreshold = 1;
            var station = _context.Stations.FirstOrDefault(station => station.StationStrId ==  stationStrId);

            return new StationDataInformationDto
            {
                StationId = station.StationId,
                StationStrId = stationStrId,
                StationName = station.Name,
                Lat = station.Lat,
                Lon = station.Lon,
                LongestDistance = _bicycleDataEntryService.GetLongestDistancesByStationId(stationStrId, queryThreshold)
                    .FirstOrDefault()
                    .Distance,
                ShortestDistance = _bicycleDataEntryService.GetShortestDistancesByStationId(stationStrId, queryThreshold)
                    .FirstOrDefault()
                    .Distance,
                LongestDuration = _bicycleDataEntryService.GetLongestDurationsByStationId(stationStrId, queryThreshold)
                    .FirstOrDefault()
                    .Duration,
                ShortestDuration = _bicycleDataEntryService.GetShortestDurationsByStationId(stationStrId, queryThreshold)
                    .FirstOrDefault()
                    .Duration
            };
        }
    }
}
