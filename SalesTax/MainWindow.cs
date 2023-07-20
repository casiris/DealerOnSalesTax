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
        private Cart cart = new Cart();

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

            // Check radio buttons and import checkbox for type of Item to be added to cart
            if (importedItemCheckBox.Checked)
            {
                if (foodRadioButton.Checked || bookRadioButton.Checked || medicalProductsRadioButton.Checked)
                {
                    // create ImportedItem with import tax only
                    itemToBeAdded = new ImportedItem(itemInputTextBox.Text, inputPrice, false);
                }
                else
                {
                    // create ImportedItem with import tax plus regular sales tax
                    itemToBeAdded = new ImportedItem(itemInputTextBox.Text, inputPrice, true);
                }
            }
            else
            {
                if (foodRadioButton.Checked || bookRadioButton.Checked || medicalProductsRadioButton.Checked)
                {
                    // create Item (non taxed item)
                    itemToBeAdded = new Item(itemInputTextBox.Text, inputPrice);
                }
                else
                {
                    // create TaxableItem
                    itemToBeAdded = new TaxableItem(itemInputTextBox.Text, inputPrice);
                }
            }

            cart.AddToCart(itemToBeAdded, Convert.ToInt32(quantitySlider.Value));
            receiptRichTextBox.Text += $"{itemToBeAdded.Name}: ({Convert.ToInt32(quantitySlider.Value)} @ {itemToBeAdded.Price.ToString("N2")} each) added to cart.\n";

            // Reset input fields
            itemInputTextBox.Text = "";
            priceTextBox.Text = "";
            quantitySlider.Value = 1;
            addToCartButton.Enabled = false;
            foodRadioButton.Checked = true;
            importedItemCheckBox.Checked = false;
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

        private void clearCartButton_Click(object sender, EventArgs e)
        {
            cart.ClearCart();
            receiptRichTextBox.Text = "";
            foodRadioButton.Checked = true;
            importedItemCheckBox.Checked = false;
        }

        // Activate Add to Cart button only if both the Item Name and Price fields are filled
        private void itemInputTextBox_Leave(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(itemInputTextBox.Text) && !String.IsNullOrEmpty(priceTextBox.Text))
            {
                addToCartButton.Enabled = true;
            }
        }

        private void priceTextBox_Leave(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(itemInputTextBox.Text) && !String.IsNullOrEmpty(priceTextBox.Text))
            {
                addToCartButton.Enabled = true;
            }
        }

        private void calculateTotalButton_Click(object sender, EventArgs e)
        {
            Receipt receipt = new Receipt();
            receipt.CalculateTotal(cart);

            receiptRichTextBox.Text = "";
            foodRadioButton.Checked = true;
            importedItemCheckBox.Checked = false;

            for (int i = 0; i < cart.CartItems.Count(); i++)
            {
                receiptRichTextBox.Text += $"{cart.CartItems[i].Name}: {receipt.PerItemWithTax[i].ToString("N2")} ({cart.CartQuantity[i]} @ {cart.CartItems[i].Price.ToString("N2")})\n";
            }
            receiptRichTextBox.Text += $"\nSales Taxes: {receipt.runningTax.ToString("N2")}\n";
            receiptRichTextBox.Text += $"Total: {receipt.runningTotal.ToString("N2")}\n";

            cart.ClearCart();
        }
    }
}
