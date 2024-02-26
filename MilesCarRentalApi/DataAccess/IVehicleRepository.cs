using MilesCarRentalApi.Models;

namespace MilesCarRentalApi.DataAccess
{
    public interface IVehicleRepository
    {
        List<Vehicle> GetAll();
        Vehicle Create(Vehicle vehicle);
        Vehicle Read(int id);
        void Update(Vehicle vehicle);
        void Delete(int id);
    }
}
