namespace MilesCarRentalApi.Models
{
    public class Location
    {
        /// <summary>
        /// ID unico de la ubicación
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nombre de la ubicación
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Dirección de la localidad
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Año del vehículo
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Estilo del vehículo
        /// </summary>
        public string Country { get; set; }


        /// <summary>
        /// Descripción de la ubicación
        /// </summary>
        public string Description
        {
            get; set;
        }

        public ICollection<Availability> Availabilities {  get; set; }
    }
}
