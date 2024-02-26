using MilesCarRentalApi.Models;

namespace MilesCarRentalApi.Services
{
    public interface IVehicleService
    {
        List<Vehicle> GetVehicles();
        Vehicle CreateVehicle(Vehicle vehicle);
        Vehicle GetVehicle(int id);
        void UpdateVehicle(Vehicle vehicle);
        void DeleteVehicle(int id);
    }
}
