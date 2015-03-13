namespace Voronovich.PharmaceuticalWarehouse.Model
{
    /// <summary>
    /// The full name.
    /// </summary>
    public class FullName : BaseModel
    {
        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the second name.
        /// </summary>
        public string SecondName { get; set; }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        public string LastName { get; set; }
    }
}
