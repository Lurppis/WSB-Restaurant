namespace WSB_Restaurant.Model
{
    /// <summary>
    /// Defines the <see cref="Box" />
    /// </summary>
    public class Box : Product
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Box"/> class.
        /// </summary>
        /// <param name="name">The <see cref="string"/></param>
        /// <param name="image">The <see cref="string"/></param>
        /// <param name="description">The <see cref="string"/></param>
        /// <param name="count">The <see cref="int"/></param>
        /// <param name="price">The <see cref="decimal"/></param>
        public Box(string name, string image, string description, int count, decimal price) : base(name, image, description, count, price)
        {
        }
    }
}
