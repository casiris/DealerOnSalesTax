using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTax
{
    class Item
    {
        public string Name { get; }
        public double Price { get; }

        public Item(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}
