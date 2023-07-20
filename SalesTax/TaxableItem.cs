using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTax
{
    class TaxableItem : Item
    {
        public double TaxRate { get; } = 0.1;

        public TaxableItem(string name, double price) : base(name, price)
        {
        }
    }
}
