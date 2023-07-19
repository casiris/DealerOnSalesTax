using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTax
{
    class Cart
    {
        private List<Item> cartItems = new List<Item>();        // this should be a dictionary, so i can have Item,quantity

        public void AddToCart(Item item)
        {
            Console.WriteLine("new item added to cart");
        }
    }
}
