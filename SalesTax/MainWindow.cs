using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesTax
{
    public partial class MainWindow : Form
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        // When adding to cart, create an Item using the name, price, and quantity fields, and using the radio buttons to determine the type of Item
        private void addToCartButton_Click(object sender, EventArgs e)
        {
            float inputPrice = 0;
            inputPrice = float.Parse(String.Format("{0:0.00}",priceTextBox.Text));

            Console.WriteLine(inputPrice);
            Console.WriteLine(String.Format("{0:0.00}", 512.4246));

            //Item itemToBeCreated = new Item(itemInputTextBox.Text, inputPrice);

            // Check radio buttons for type of Item to be added to cart
            if (foodRadioButton.Checked || bookRadioButton.Checked || medicalProductsRadioButton.Checked)
            {
                // create Item (non taxable item)
            }
            else if (importedItemsRadioButton.Checked)
            {
                // create ImportedItem
            }
            else
            {
                // create TaxableItem
            }

            // create item of certain type

            // add item to list in receipt
        }

        // Parse price input, and prevent user from entering non-numeric values
        private float ParsePrice(string inputText)
        {
            return 0;
        }

        // Prevent user from entering non-numeric values
        private void priceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Allow for decimal prices
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
