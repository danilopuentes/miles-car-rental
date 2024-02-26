namespace MilesCarRentalApi.Models
{
    public class Availability
    {
        /// <summary>
        /// ID unico de la ubicación
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Id del vehiculo
        /// </summary>
        public int VehicleId { get; set; }

        /// <summary>
        /// Id de la ubicación
        /// </summary>
        public int LocationId { get; set; }

        /// <summary>
        /// Fecha de disponibilidad
        /// </summary>
        public DateTime AvailabilityDate { get; set; }

        /// <summary>
        /// Relación con vehicle: Cada disponibilidad pertenece a un vehículo
        /// </summary>
        public Vehicle Vehicle {  get; set; }

        /// <summary>
        /// Relación con loction: Cada disponibilidad pertenece a una ubicación
        /// </summary>
        public Location Location { get; set; }

    }
}
