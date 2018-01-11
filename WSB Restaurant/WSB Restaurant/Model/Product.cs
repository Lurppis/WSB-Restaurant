namespace WSB_Restaurant.Model
{
    /// <summary>
    /// Defines the <see cref="Product" />
    /// </summary>
    public abstract class Product
    {
        /// <summary>
        /// Gets or sets the Image
        /// </summary>
        public string Image { get; set; }

        /// <summary>
        /// Gets or sets the Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the Description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the Count
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        /// Gets or sets the Price
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Gets the TotalPrice
        /// </summary>
        public decimal TotalPrice
        {
            get { return Price * Count; }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Product"/> class.
        /// </summary>
        /// <param name="name">The <see cref="string"/></param>
        /// <param name="image">The <see cref="string"/></param>
        /// <param name="description">The <see cref="string"/></param>
        /// <param name="count">The <see cref="int"/></param>
        /// <param name="price">The <see cref="decimal"/></param>
        public Product(string name, string image, string description, int count, decimal price)
        {
            Name = name;
            Description = description;
            Image = image;
            Count = count;
            Price = price;
        }
    }
}
