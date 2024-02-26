namespace MilesCarRentalApi.Models
{
    /// <summary>
    /// Modelo que representa un vehiculo
    /// </summary>
    public class Vehicle
    {
        /// <summary>
        /// ID unico del vehículo
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Marca del vehículo
        /// </summary>
        public string Make { get; set; }

        /// <summary>
        /// Modelo del vehículo
        /// </summary>
        public string Model { get; set; }

        /// <summary>
        /// Año del vehículo
        /// </summary>
        public string Year { get; set; }

        /// <summary>
        /// Estilo del vehículo
        /// </summary>
        public string Style { get; set; }

        /// <summary>
        /// Bandera que marca la disponibilidad del vehículo
        /// </summary>
        public bool Available { get; set; }

        /// <summary>
        /// Descripción general del vehículo
        /// </summary>
        public string Description { get; set; }


        public ICollection<Availability> Availabilities { get; set; }

    }
}
