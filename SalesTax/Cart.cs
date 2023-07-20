using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTax
{
    class Cart
    {
        //public IDictionary<Item, int> CartItems { get; } = new Dictionary<Item, int>();
        public List<Item> CartItems { get; } = new List<Item>();
        public List<int> CartQuantity { get; } = new List<int>();

        public void AddToCart(Item item, int quantity)
        {
            CartItems.Add(item);
            CartQuantity.Add(quantity);
        }

        public void ClearCart()
        {
            CartItems.Clear();
        }
    }
}
