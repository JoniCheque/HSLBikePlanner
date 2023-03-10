using BicycleService.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Repository.Entities;
using System.Security.Cryptography.Xml;

namespace API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BicycleController : ControllerBase
    {
        private readonly ILogger<BicycleController> _logger;
        private readonly IBicycleDataEntryService _bicycleDataEntryService;
        private const int defaultQueryTreshold = 1;

        public BicycleController(ILogger<BicycleController> logger, IBicycleDataEntryService bicycleDataEntryService)
        {
            _logger = logger;
            _bicycleDataEntryService = bicycleDataEntryService;
        }

        [HttpGet(nameof(GetCount))]
        public int GetCount()
        {
            return _bicycleDataEntryService.GetTotalCountOfEntries();
        }

        [HttpGet(nameof(GetLongestDistances))]
        public IEnumerable<BicycleDataEntry> GetLongestDistances(int amountOfEntries)
        {
            return _bicycleDataEntryService.GetLongestDistances(amountOfEntries);
        }

        [HttpGet(nameof(GetShortestDistances))]
        public IEnumerable<BicycleDataEntry> GetShortestDistances(int amountOfEntries)
        {
            return _bicycleDataEntryService.GetShortestDistances(amountOfEntries);
        }

        [HttpGet(nameof(GetLongestDurations))]
        public IEnumerable<BicycleDataEntry> GetLongestDurations(int amountOfEntries)
        {
            return _bicycleDataEntryService.GetLongestDurations(amountOfEntries);
        }

        [HttpGet(nameof(GetShortestDurations))]
        public IEnumerable<BicycleDataEntry> GetShortestDurations(int amountOfEntries)
        {
            return _bicycleDataEntryService.GetShortestDurations(amountOfEntries);
        }

        [HttpGet(nameof(GetLongestDistancesByStationId))]
        public IEnumerable<BicycleDataEntry> GetLongestDistancesByStationId(string stationId, int amountOfEntries = defaultQueryTreshold)
        {
            return _bicycleDataEntryService.GetLongestDistancesByStationId(stationId, amountOfEntries);
        }

        [HttpGet(nameof(GetShortestDistancesByStationId))]
        public IEnumerable<BicycleDataEntry> GetShortestDistancesByStationId(string stationId, int amountOfEntries = defaultQueryTreshold)
        {
            return _bicycleDataEntryService.GetShortestDistancesByStationId(stationId, amountOfEntries);
        }

        [HttpGet(nameof(GetLongestDurationsByStationId))]
        public IEnumerable<BicycleDataEntry> GetLongestDurationsByStationId(string stationId, int amountOfEntries = defaultQueryTreshold)
        {
            return _bicycleDataEntryService.GetLongestDurationsByStationId(stationId, amountOfEntries);
        }

        [HttpGet(nameof(GetShortestDurationsByStationId))]
        public IEnumerable<BicycleDataEntry> GetShortestDurationsByStationId(string stationId, int amountOfEntries = defaultQueryTreshold)
        {
            return _bicycleDataEntryService.GetShortestDurationsByStationId(stationId, amountOfEntries);
        }
    }
}
