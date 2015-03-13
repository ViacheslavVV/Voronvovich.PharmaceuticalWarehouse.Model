namespace Project_OSISP
{
    using Voronovich.PharmaceuticalWarehouse.Model;

    /// <summary>
    /// The price of wares.
    /// </summary>
    public class Price : BaseModel
    {
        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        public double Value { get; set; }

        /// <summary>
        /// Gets or sets the currency.
        /// </summary>
        public string Currency { get; set; }

    }
}
