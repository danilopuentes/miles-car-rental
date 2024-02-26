using MilesCarRentalApi.DataAccess;
using MilesCarRentalApi.Models;

namespace MilesCarRentalApi.Services
{
    public class LocationService : ILocationService
    {
        private readonly ILocationRepository _locationRepository;

        public LocationService(ILocationRepository locationRepository)
        {
            _locationRepository = locationRepository;
        }

        public List<Location> GetLocations()
        {
            return _locationRepository.GetAll();
        }

        public Location CreateLocation(Location location)
        {
            return _locationRepository.Create(location);
        }

        public Location GetLocation(int id)
        {
            return _locationRepository.Read(id);
        }

        public void UpdateLocation(Location location)
        {
            _locationRepository.Update(location);
        }

        public void DeleteLocation(int id)
        {
            _locationRepository.Delete(id);
        }
    }
}
