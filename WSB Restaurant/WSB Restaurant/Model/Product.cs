namespace WSB_Restaurant.Model
{
    class Product
    {
        private decimal _totalPrice;

        public string Image { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Count { get; set; }
        public decimal Price { get; set; }

        public decimal GetTotalPrice()
        {
            return _totalPrice;
        }

        private void SetTotalPrice()
        {
            _totalPrice = Count * Price;
        }

        public Product(string name, string image, string description, int count)
        {
            this.Name = name;
            this.Description = description;
            this.Image = image;
            this.Count = count;
        }
    }
}
