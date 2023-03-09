using Repository.Entities;

namespace BicycleService.Interfaces
{
    public interface IStationService
    {
        IEnumerable<Station> GetStations();
    }
}