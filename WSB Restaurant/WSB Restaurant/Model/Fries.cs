namespace WSB_Restaurant.Model
{
    /// <summary>
    /// Defines the <see cref="Fries" />
    /// </summary>
    public class Fries : Product
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Fries"/> class.
        /// </summary>
        /// <param name="name">The <see cref="string"/></param>
        /// <param name="image">The <see cref="string"/></param>
        /// <param name="description">The <see cref="string"/></param>
        /// <param name="count">The <see cref="int"/></param>
        /// <param name="price">The <see cref="decimal"/></param>
        public Fries(string name, string image, string description, int count, decimal price) : base(name, image, description, count, price)
        {
        }
    }
}
