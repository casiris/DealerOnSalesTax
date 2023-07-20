using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTax
{
    class Receipt
    {
        public double runningTax { get; private set; } = 0;
        public double runningTotal { get; private set; } = 0;
        public List<double> PerItemWithTax { get; private set; } = new List<double>();       // I need each item with tax included for output later

        public void CalculateTotal(Cart cart)
        {
            double itemTax;

            for (int i = 0; i < cart.CartItems.Count(); i++)
            {
                double itemPriceWithQuantity = cart.CartItems[i].Price * cart.CartQuantity[i];

                if (cart.CartItems[i] is ImportedItem)
                {
                    itemTax = itemPriceWithQuantity * ((ImportedItem)cart.CartItems[i]).ImportedTaxRate;
                    itemTax = Math.Ceiling(itemTax / 0.05) * 0.05;      // Tax needs to be rounded up to the nearest 5 cents
                    runningTax += itemTax;

                    PerItemWithTax.Add(itemPriceWithQuantity + itemTax);
                }
                else if (cart.CartItems[i] is TaxableItem)
                {
                    itemTax = itemPriceWithQuantity * ((TaxableItem)cart.CartItems[i]).TaxRate;
                    itemTax = Math.Ceiling(itemTax / 0.05) * 0.05;
                    runningTax += itemTax;

                    PerItemWithTax.Add(itemPriceWithQuantity + itemTax);
                }
                else
                {
                    // Need to add items without tax as well, just with no tax added on
                    PerItemWithTax.Add(itemPriceWithQuantity);
                }
                
                //runningTax = Math.Ceiling(runningTax / 0.05) * 0.05;
                runningTotal += PerItemWithTax[i];
            }
        }
    }
}
