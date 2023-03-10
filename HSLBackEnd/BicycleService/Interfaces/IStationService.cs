using BicycleService.DTO;
using Repository.Entities;

namespace BicycleService.Interfaces
{
    public interface IStationService
    {
        IEnumerable<Station> GetStations();
        StationDataInformationDto GetStationInformation(string stationStrId);
    }
}