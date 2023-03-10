using BicycleService.DTO;
using BicycleService.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Repository.Entities;

namespace API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class StationController
    {
        private readonly IStationService _stationService;

        public StationController(IStationService stationService)
        {
            _stationService = stationService;
        }

        [HttpGet(nameof(GetAllStations))]
        public IEnumerable<Station> GetAllStations()
        {
            return _stationService.GetStations();
        }

        [HttpGet(nameof(GetStationInformation))]
        public StationDataInformationDto GetStationInformation(string stationStrId)
        {
            return _stationService.GetStationInformation(stationStrId);
        }
    }
}
