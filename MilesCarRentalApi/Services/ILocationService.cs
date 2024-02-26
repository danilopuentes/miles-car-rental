using MilesCarRentalApi.Models;

namespace MilesCarRentalApi.Services
{
    public interface ILocationService
    {
        List<Location> GetLocations();
        Location CreateLocation(Location location);
        Location GetLocation(int id);
        void UpdateLocation(Location location);
        void DeleteLocation(int id);
    }
}
