namespace Voronovich.PharmaceuticalWarehouse.Model
{
    /// <summary>
    /// The employee.
    /// </summary>
    public class Employee : BaseModel
    {
        /// <summary>
        /// Gets or sets the full name.
        /// </summary>
        public FullName FullName { get; set; }

        /// <summary>
        /// Gets or sets the number.
        /// </summary>
        public PhoneNumber Number { get; set; }

        /// <summary>
        /// Gets or sets the pharmacy id.
        /// </summary>
        public int PharmacyId { get; set; }


    }
}
