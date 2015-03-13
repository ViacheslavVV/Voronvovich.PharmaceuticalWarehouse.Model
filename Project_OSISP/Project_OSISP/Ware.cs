namespace Project_OSISP
{
    using System.Collections.Generic;

    using Voronovich.PharmaceuticalWarehouse.Model;

    /// <summary>
    /// The wares.
    /// </summary>
    public class Ware : BaseModel
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the number of wares.
        /// </summary>
        public int Number { get; set; }

        /// <summary>
        /// Gets or sets the number of available wares.
        /// </summary>
        public int NumberOfAvailable { get; set; }

        /// <summary>
        /// Gets or sets the number of expected wares.
        /// </summary>
        public int NumberOfExpected { get; set; }

        /// <summary>
        /// Gets or sets the providers list.
        /// </summary>
        public ICollection<Provider> ProvidersList { get; set; }

        /// <summary>
        /// Gets or sets the order id.
        /// </summary>
        public int OrderId { get; set; }

        /// <summary>
        /// Gets or sets the pharmacies list.
        /// </summary>
        public ICollection<Pharmacy> PharmaciesList { get; set; }
    }
}
