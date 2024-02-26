using MilesCarRentalApi.Models;

namespace MilesCarRentalApi.DataAccess
{
    public class LocationRepository : ILocationRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;


        public LocationRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public List<Location> GetAll()
        {
            return _applicationDbContext.Locations.ToList();
        }

        public Location Create(Location location)
        {
            _applicationDbContext.Locations.Add(location);
            _applicationDbContext.SaveChanges();
            return location;
        }

        public Location Read(int id)
        {
            Location location = _applicationDbContext.Locations.Find(id);
            return location;

        }

        public void Update(Location location)
        {
            _applicationDbContext.Locations.Update(location);
            _applicationDbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            Location location = _applicationDbContext.Locations.Find(id);
            _applicationDbContext.Locations.Remove(location);
            _applicationDbContext.SaveChanges();
        }
    }
}
