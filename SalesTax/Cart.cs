using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTax
{
    class Cart
    {
        public Dictionary<string, Item> CartItems { get; } = new Dictionary<string, Item>();

        public void AddToCart(Item item, int quantity)
        {
            if (CartItems.ContainsKey(item.Name))
            {
                CartItems[item.Name].IncreaseQuantity(quantity);
            }
            else
            {
                CartItems.Add(item.Name, item);
            }
        }

        public void ClearCart()
        {
            CartItems.Clear();
        }
    }
}
