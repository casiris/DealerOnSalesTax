using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTax
{
    class CreateReceipt
    {
        private List<Item> cartItems = new List<Item>();        // this should be a dictionary, so i can have Item,quantity
        private float totalTax = 0;
        private float total = 0;

        // Tax needs to be rounded up to the nearest 5 cents
        float CalculateTax()
        {
            return 0;
        }

        float CalculateTotal()
        {
            return 0;
        }
    }
}
