using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTax
{
    class Item
    {
        public string Name { get; set; }
        public double Price { get; }
        public int Quantity { get; private set; } = 0;

        public Item(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public void IncreaseQuantity(int amountToBuy)
        {
            Quantity += amountToBuy;
        }
    }
}
