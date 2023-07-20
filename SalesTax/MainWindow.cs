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

        private void addToCartButton_Click(object sender, EventArgs e)
        {
            double inputPrice;
            double.TryParse(priceTextBox.Text, out inputPrice);
            inputPrice = Math.Round(inputPrice, 2);

            int inputQuantity = Convert.ToInt32(quantitySlider.Value);

            Item itemToBeAdded;

            // Check radio buttons and import checkbox for type of Item to be added to cart
            if (importedItemCheckBox.Checked)
            {
                if (foodRadioButton.Checked || bookRadioButton.Checked || medicalProductsRadioButton.Checked)
                {
                    // create ImportedItem with import tax only
                    itemToBeAdded = new ImportedItem(itemInputTextBox.Text, inputPrice, inputQuantity, false);
                }
                else
                {
                    // create ImportedItem with import tax plus regular sales tax
                    itemToBeAdded = new ImportedItem(itemInputTextBox.Text, inputPrice, inputQuantity, true);
                }
            }
            else
            {
                if (foodRadioButton.Checked || bookRadioButton.Checked || medicalProductsRadioButton.Checked)
                {
                    itemToBeAdded = new Item(itemInputTextBox.Text, inputPrice, inputQuantity);
                }
                else
                {
                    itemToBeAdded = new TaxableItem(itemInputTextBox.Text, inputPrice, inputQuantity);
                }
            }

            cart.AddToCart(itemToBeAdded, Convert.ToInt32(quantitySlider.Value));
            receiptRichTextBox.Text += $"{itemToBeAdded.Name}: ({Convert.ToInt32(quantitySlider.Value)} @ {itemToBeAdded.Price.ToString("N2")} each) added to cart.\n";

            ResetInputFields();
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
            ResetInputFields();
            receiptRichTextBox.Text = "";
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

            ResetInputFields();
            receiptRichTextBox.Text = "";

            double totalTax = receipt.CalculateTax(cart);
            double total = receipt.CalculateTotal(cart);

            int taxedItemIndex = 0;

            foreach(KeyValuePair<string, Item> item in cart.CartItems)
            {
                receiptRichTextBox.Text += $"{item.Value.Name}: {receipt.PerItemWithTax[taxedItemIndex].ToString("N2")} ({item.Value.Quantity} @ {item.Value.Price.ToString("N2")})\n";
                taxedItemIndex++;
            }

            receiptRichTextBox.Text += $"\nSales Taxes: {totalTax.ToString("N2")}\n";
            receiptRichTextBox.Text += $"Total: {total.ToString("N2")}";

            cart.ClearCart();
        }

        private void ResetInputFields()
        {
            itemInputTextBox.Text = "";
            priceTextBox.Text = "";
            quantitySlider.Value = 1;
            addToCartButton.Enabled = false;
            foodRadioButton.Checked = true;
            importedItemCheckBox.Checked = false;
        }
    }
}
