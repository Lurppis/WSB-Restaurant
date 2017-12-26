namespace WSB_Restaurant.Model
{
    abstract class Product
    {
        public string Image { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Count { get; set; }
        public decimal Price { get; set; }
        public decimal TotalPrice { get { return Price * Count; }}

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
