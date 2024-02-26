using MilesCarRentalApi.DataAccess;
using MilesCarRentalApi.Models;

namespace MilesCarRentalApi.Services
{
    public class VehicleService : IVehicleService
    {
        private readonly IVehicleRepository _vehicleRepository;

        public VehicleService(IVehicleRepository vehicleRepository)
        {
            _vehicleRepository = vehicleRepository;
        }

        public List<Vehicle> GetVehicles()
        {
            return _vehicleRepository.GetAll();
        }

        public Vehicle CreateVehicle(Vehicle vehicle)
        {
            // Lógica adicional, validaciones, etc.
            return _vehicleRepository.Create(vehicle);
        }

        public Vehicle GetVehicle(int id)
        {
            // Lógica adicional, validaciones, etc.
            return _vehicleRepository.Read(id);
        }

        public void UpdateVehicle(Vehicle vehicle)
        {
            // Lógica adicional, validaciones, etc.
            _vehicleRepository.Update(vehicle);
        }

        public void DeleteVehicle(int id)
        {
            // Lógica adicional, validaciones, etc.
            _vehicleRepository.Delete(id);
        }
    }
}
