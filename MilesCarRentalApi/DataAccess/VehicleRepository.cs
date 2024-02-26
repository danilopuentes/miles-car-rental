using Microsoft.EntityFrameworkCore;
using MilesCarRentalApi.Models;

namespace MilesCarRentalApi.DataAccess
{
    public class VehicleRepository : IVehicleRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;


        public VehicleRepository(ApplicationDbContext applicationDbContext) { 
            _applicationDbContext = applicationDbContext; 
        }

        public List<Vehicle> GetAll()
        {
            return _applicationDbContext.Vehicles.ToList();
        }

        public Vehicle Create (Vehicle vehicle)
        {
               _applicationDbContext.Vehicles.Add(vehicle);
               _applicationDbContext.SaveChanges();
               return vehicle;
        }

        public Vehicle Read(int id)
        {
            Vehicle vehicle = _applicationDbContext.Vehicles.Find(id);
            return vehicle;

        }

        public void Update(Vehicle vehicle)
        {
            _applicationDbContext.Vehicles.Update(vehicle);
            _applicationDbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            Vehicle vehicle =  _applicationDbContext.Vehicles.Find(id);
            _applicationDbContext.Vehicles.Remove(vehicle);
            _applicationDbContext.SaveChanges();
        }

    }
}
