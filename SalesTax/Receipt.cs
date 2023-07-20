using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTax
{
    class Receipt
    {
        public List<double> PerItemWithTax { get; private set; } = new List<double>();       // Need each item with tax included for output later
        private double _totalTax = 0;

        public double CalculateTax(Cart cart)
        {
            double itemTax;

            foreach (KeyValuePair<string, Item> item in cart.CartItems)
            {
                itemTax = 0;

                if (item.Value is ImportedItem)
                {
                    itemTax = TaxPerItem(item.Value.Price, ((ImportedItem)item.Value).ImportedTaxRate, item.Value.Quantity);                    
                }
                else if (item.Value is TaxableItem)
                {
                    itemTax = TaxPerItem(item.Value.Price, ((TaxableItem)item.Value).TaxRate, item.Value.Quantity);
                }

                _totalTax += itemTax;
                PerItemWithTax.Add((item.Value.Price * item.Value.Quantity) + itemTax);    // itemTax will be 0 for non-taxed items
            }

            return _totalTax;
        }

        public double CalculateTotal(Cart cart)
        {
            double total = 0;

            foreach (double item in PerItemWithTax)
            {
                total += item;
            }

            return total;
        }

        private double TaxPerItem(double price, double taxRate, int quantity)
        {
            double totalTaxPerItem = price * taxRate;
            // Tax needs to be rounded up to the nearest 5 cents
            totalTaxPerItem = (Math.Ceiling(totalTaxPerItem / 0.05) * 0.05) * quantity;

            return totalTaxPerItem;
        }
    }
}
