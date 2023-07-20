using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTax
{
    class ImportedItem : TaxableItem
    {
        public double ImportedTaxRate { get; private set; } = 0.05;

        public ImportedItem(string name, double price, bool additionalTax) : base(name, price)
        {
            //Name = "Imported " + Name;
            if (additionalTax)
            {
                ImportedTaxRate += TaxRate;
                Console.WriteLine("imported double tax: {0}", ImportedTaxRate);
            }
        }
    }
}
