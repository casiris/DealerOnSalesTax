using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTax
{
    class ImportedItem : TaxableItem
    {
        public double ImportTaxRate { get; } = .05f;

        public ImportedItem(string name, double price) : base(name, price)
        {

        }
    }
}
