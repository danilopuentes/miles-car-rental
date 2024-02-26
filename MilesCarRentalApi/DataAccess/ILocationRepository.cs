using MilesCarRentalApi.Models;

namespace MilesCarRentalApi.DataAccess
{
    public interface ILocationRepository
    {
        List<Location> GetAll();
        Location Create(Location location);
        Location Read(int id);
        void Update(Location location);
        void Delete(int id);
    }
}
