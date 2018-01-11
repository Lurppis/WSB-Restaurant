namespace WSB_Restaurant.Model
{
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="Bucket" />
    /// </summary>
    public class Bucket
    {
        /// <summary>
        /// Gets or sets the Type
        /// </summary>
        public static string Type { get; set; }

        /// <summary>
        /// Gets or sets the Products
        /// </summary>
        public static List<Product> Products { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Bucket"/> class.
        /// </summary>
        public Bucket()
        {
            Products = new List<Product>();
        }
    }
}
