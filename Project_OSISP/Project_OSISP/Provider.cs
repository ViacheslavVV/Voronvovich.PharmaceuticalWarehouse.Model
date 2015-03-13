namespace Project_OSISP
{
    using System.Collections.Generic;

    using Voronovich.PharmaceuticalWarehouse.Model;

    /// <summary>
    /// The provider.
    /// </summary>
    public class Provider : BaseModel
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the number.
        /// </summary>
        public PhoneNumber Number { get; set; }

        /// <summary>
        /// Gets or sets the address.
        /// </summary>
        public Address Address { get; set; }

        /// <summary>
        /// Gets or sets the wares.
        /// </summary>
        public ICollection<Ware> WareList { get; set; }

        /// <summary>
        /// Gets or sets the order list.
        /// </summary>
        public ICollection<Order> OrderList { get; set; }
    }
}
