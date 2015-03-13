namespace Project_OSISP
{
    using System.Collections.Generic;

    using Voronovich.PharmaceuticalWarehouse.Model;
    
    /// <summary>
    /// The pharmacy.
    /// </summary>
    public class Pharmacy : BaseModel
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the address.
        /// </summary>
        public Address Address { get; set; }

        /// <summary>
        /// Gets or sets the number.
        /// </summary>
        public PhoneNumber Number { get; set; }

        /// <summary>
        /// Gets or sets the ware list.
        /// </summary>
        public ICollection<Ware> WareList { get; set; }

        /// <summary>
        /// Gets or sets the employee list.
        /// </summary>
        public ICollection<Employee> EmployeeList { get; set; }
    }
}
