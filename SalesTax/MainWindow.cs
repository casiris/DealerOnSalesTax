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
            double inputPrice = 0;
            double.TryParse(priceTextBox.Text, out inputPrice);
            inputPrice = Math.Round(inputPrice, 2);

            Item itemToBeAdded;

            // Check radio buttons for type of Item to be added to cart
            if (foodRadioButton.Checked || bookRadioButton.Checked || medicalProductsRadioButton.Checked)
            {
                // create Item (non taxed item)
                itemToBeAdded = new Item(itemInputTextBox.Text, inputPrice);
            }
            else if (importedItemsRadioButton.Checked)
            {
                // create ImportedItem
                itemToBeAdded = new ImportedItem(itemInputTextBox.Text, inputPrice);
            }
            else
            {
                // create TaxableItem
                itemToBeAdded = new TaxableItem(itemInputTextBox.Text, inputPrice);
            }

            // add Item to Cart
            Cart cart = new Cart();     // don't want to create new carts every time i click the button. i should create a cart at startup or whatever, then just add to that cart
            cart.AddToCart(itemToBeAdded);
        }

        // Prevent user from entering non-numeric values
        private void priceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Allow only one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
