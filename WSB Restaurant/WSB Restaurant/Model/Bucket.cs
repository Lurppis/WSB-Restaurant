using System.Collections.Generic;

namespace WSB_Restaurant.Model
{
    class Bucket
    {
        public static List<Product> Products { get; set; }

        public Bucket()
        {
            Products = new List<Product>();
        }
    }
}
