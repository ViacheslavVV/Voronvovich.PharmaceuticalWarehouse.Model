
namespace Voronovich.PharmaceuticalWarehouse.Model
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The order.
    /// </summary>
    public class Order : BaseModel
    {
        /// <summary>
        /// Gets or sets the date.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        public Price Price { get; set; }

        /// <summary>
        /// Gets or sets the amount of order.
        /// </summary>
        public int Amount { get; set; }

        /// <summary>
        /// Gets or sets the provider id.
        /// </summary>
        public int ProviderId { get; set; }

        /// <summary>
        /// Gets or sets the ware id list.
        /// </summary>
        public ICollection<Ware> WareList { get; set; }
    }
}
