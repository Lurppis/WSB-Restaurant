using System.Collections.Generic;

namespace WSB_Restaurant.Model
{
    class Bucket
    {
        public List<Product> Products { get; set; }

        public Bucket()
        {
            Products = new List<Product>();
            Products.Add(new Product("Burger", "bnt", "Burger sypa", 2));
            Products.Add(new Product("Burger2", "bnt", "Burger sypa", 2));
            Products.Add(new Product("Burger3", "bnt", "Burger sypa", 5));
        }
    }
}
