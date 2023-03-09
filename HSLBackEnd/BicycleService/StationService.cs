using BicycleService.Interfaces;
using Repository.Contexts;
using Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BicycleService
{
    public class StationService : IStationService
    {
        private BicycleDataContext _context;

        public StationService(BicycleDataContext db)
        {
            _context = db;
        }

        public IEnumerable<Station> GetStations()
        {
            return _context.Stations.Select(station => station);
        }
    }
}
