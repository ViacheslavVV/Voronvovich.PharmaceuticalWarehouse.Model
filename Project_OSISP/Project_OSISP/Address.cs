namespace Voronovich.PharmaceuticalWarehouse.Model
{
    using Voronovich.PharmaceuticalWarehouse.Model;

    /// <summary>
    /// The address.
    /// </summary>
    public class Address : BaseModel
    {
        /// <summary>
        /// Gets or sets the street.
        /// </summary>
        public string Street { get; set; }

        /// <summary>
        /// Gets or sets the house.
        /// </summary>
        public string House { get; set; }

        /// <summary>
        /// Gets or sets the flat.
        /// </summary>
        public string Flat { get; set; }
    }
}
