using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSB_Restaurant.Model
{
    class Fries : Product
    {
        public Fries(string name, string image, string description, int count, decimal price) : base(name, image, description, count, price)
        {
        }
    }
}
