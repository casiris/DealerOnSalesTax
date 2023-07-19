
namespace SalesTax
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.itemInputTextBox = new System.Windows.Forms.TextBox();
            this.quantitySlider = new System.Windows.Forms.NumericUpDown();
            this.calculateTotalButton = new System.Windows.Forms.Button();
            this.itemNameLabel = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.receiptRichTextBox = new System.Windows.Forms.RichTextBox();
            this.itemCategoryGroupBox = new System.Windows.Forms.GroupBox();
            this.importedItemsRadioButton = new System.Windows.Forms.RadioButton();
            this.miscItemsRadioButton = new System.Windows.Forms.RadioButton();
            this.medicalProductsRadioButton = new System.Windows.Forms.RadioButton();
            this.bookRadioButton = new System.Windows.Forms.RadioButton();
            this.foodRadioButton = new System.Windows.Forms.RadioButton();
            this.addToCartButton = new System.Windows.Forms.Button();
            this.priceLabel = new System.Windows.Forms.Label();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.clearCartButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.quantitySlider)).BeginInit();
            this.itemCategoryGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // itemInputTextBox
            // 
            this.itemInputTextBox.Location = new System.Drawing.Point(99, 36);
            this.itemInputTextBox.Name = "itemInputTextBox";
            this.itemInputTextBox.Size = new System.Drawing.Size(156, 20);
            this.itemInputTextBox.TabIndex = 1;
            // 
            // quantitySlider
            // 
            this.quantitySlider.Location = new System.Drawing.Point(487, 36);
            this.quantitySlider.Name = "quantitySlider";
            this.quantitySlider.Size = new System.Drawing.Size(55, 20);
            this.quantitySlider.TabIndex = 3;
            this.quantitySlider.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // calculateTotalButton
            // 
            this.calculateTotalButton.Location = new System.Drawing.Point(217, 294);
            this.calculateTotalButton.Name = "calculateTotalButton";
            this.calculateTotalButton.Size = new System.Drawing.Size(177, 83);
            this.calculateTotalButton.TabIndex = 30;
            this.calculateTotalButton.Text = "Calculate Total";
            this.calculateTotalButton.UseVisualStyleBackColor = true;
            // 
            // itemNameLabel
            // 
            this.itemNameLabel.AutoSize = true;
            this.itemNameLabel.Location = new System.Drawing.Point(32, 39);
            this.itemNameLabel.Name = "itemNameLabel";
            this.itemNameLabel.Size = new System.Drawing.Size(61, 13);
            this.itemNameLabel.TabIndex = 8;
            this.itemNameLabel.Text = "Item Name:";
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(432, 40);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(49, 13);
            this.quantityLabel.TabIndex = 9;
            this.quantityLabel.Text = "Quantity:";
            // 
            // receiptRichTextBox
            // 
            this.receiptRichTextBox.Location = new System.Drawing.Point(675, 40);
            this.receiptRichTextBox.Name = "receiptRichTextBox";
            this.receiptRichTextBox.ReadOnly = true;
            this.receiptRichTextBox.Size = new System.Drawing.Size(475, 337);
            this.receiptRichTextBox.TabIndex = 10;
            this.receiptRichTextBox.TabStop = false;
            this.receiptRichTextBox.Text = "";
            // 
            // itemCategoryGroupBox
            // 
            this.itemCategoryGroupBox.Controls.Add(this.importedItemsRadioButton);
            this.itemCategoryGroupBox.Controls.Add(this.miscItemsRadioButton);
            this.itemCategoryGroupBox.Controls.Add(this.medicalProductsRadioButton);
            this.itemCategoryGroupBox.Controls.Add(this.bookRadioButton);
            this.itemCategoryGroupBox.Controls.Add(this.foodRadioButton);
            this.itemCategoryGroupBox.Location = new System.Drawing.Point(112, 83);
            this.itemCategoryGroupBox.Name = "itemCategoryGroupBox";
            this.itemCategoryGroupBox.Size = new System.Drawing.Size(146, 139);
            this.itemCategoryGroupBox.TabIndex = 4;
            this.itemCategoryGroupBox.TabStop = false;
            this.itemCategoryGroupBox.Text = "Item Category";
            // 
            // importedItemsRadioButton
            // 
            this.importedItemsRadioButton.AutoSize = true;
            this.importedItemsRadioButton.Location = new System.Drawing.Point(6, 112);
            this.importedItemsRadioButton.Name = "importedItemsRadioButton";
            this.importedItemsRadioButton.Size = new System.Drawing.Size(94, 17);
            this.importedItemsRadioButton.TabIndex = 4;
            this.importedItemsRadioButton.TabStop = true;
            this.importedItemsRadioButton.Text = "Imported Items";
            this.importedItemsRadioButton.UseVisualStyleBackColor = true;
            // 
            // miscItemsRadioButton
            // 
            this.miscItemsRadioButton.AutoSize = true;
            this.miscItemsRadioButton.Location = new System.Drawing.Point(6, 89);
            this.miscItemsRadioButton.Name = "miscItemsRadioButton";
            this.miscItemsRadioButton.Size = new System.Drawing.Size(120, 17);
            this.miscItemsRadioButton.TabIndex = 3;
            this.miscItemsRadioButton.TabStop = true;
            this.miscItemsRadioButton.Text = "Miscellaneous Items";
            this.miscItemsRadioButton.UseVisualStyleBackColor = true;
            // 
            // medicalProductsRadioButton
            // 
            this.medicalProductsRadioButton.AutoSize = true;
            this.medicalProductsRadioButton.Location = new System.Drawing.Point(6, 66);
            this.medicalProductsRadioButton.Name = "medicalProductsRadioButton";
            this.medicalProductsRadioButton.Size = new System.Drawing.Size(107, 17);
            this.medicalProductsRadioButton.TabIndex = 2;
            this.medicalProductsRadioButton.TabStop = true;
            this.medicalProductsRadioButton.Text = "Medical Products";
            this.medicalProductsRadioButton.UseVisualStyleBackColor = true;
            // 
            // bookRadioButton
            // 
            this.bookRadioButton.AutoSize = true;
            this.bookRadioButton.Location = new System.Drawing.Point(6, 43);
            this.bookRadioButton.Name = "bookRadioButton";
            this.bookRadioButton.Size = new System.Drawing.Size(55, 17);
            this.bookRadioButton.TabIndex = 1;
            this.bookRadioButton.TabStop = true;
            this.bookRadioButton.Text = "Books";
            this.bookRadioButton.UseVisualStyleBackColor = true;
            // 
            // foodRadioButton
            // 
            this.foodRadioButton.AutoSize = true;
            this.foodRadioButton.Location = new System.Drawing.Point(7, 20);
            this.foodRadioButton.Name = "foodRadioButton";
            this.foodRadioButton.Size = new System.Drawing.Size(49, 17);
            this.foodRadioButton.TabIndex = 0;
            this.foodRadioButton.TabStop = true;
            this.foodRadioButton.Text = "Food";
            this.foodRadioButton.UseVisualStyleBackColor = true;
            // 
            // addToCartButton
            // 
            this.addToCartButton.Location = new System.Drawing.Point(360, 123);
            this.addToCartButton.Name = "addToCartButton";
            this.addToCartButton.Size = new System.Drawing.Size(144, 50);
            this.addToCartButton.TabIndex = 20;
            this.addToCartButton.Text = "Add to Cart";
            this.addToCartButton.UseVisualStyleBackColor = true;
            this.addToCartButton.Click += new System.EventHandler(this.addToCartButton_Click);
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(274, 40);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(34, 13);
            this.priceLabel.TabIndex = 14;
            this.priceLabel.Text = "Price:";
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(314, 37);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(84, 20);
            this.priceTextBox.TabIndex = 2;
            this.priceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.priceTextBox_KeyPress);
            // 
            // clearCartButton
            // 
            this.clearCartButton.Location = new System.Drawing.Point(385, 195);
            this.clearCartButton.Name = "clearCartButton";
            this.clearCartButton.Size = new System.Drawing.Size(96, 27);
            this.clearCartButton.TabIndex = 31;
            this.clearCartButton.Text = "Clear Cart";
            this.clearCartButton.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 450);
            this.Controls.Add(this.clearCartButton);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.addToCartButton);
            this.Controls.Add(this.itemCategoryGroupBox);
            this.Controls.Add(this.receiptRichTextBox);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.itemNameLabel);
            this.Controls.Add(this.calculateTotalButton);
            this.Controls.Add(this.quantitySlider);
            this.Controls.Add(this.itemInputTextBox);
            this.Name = "MainWindow";
            this.Text = "Sales Tax";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quantitySlider)).EndInit();
            this.itemCategoryGroupBox.ResumeLayout(false);
            this.itemCategoryGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox itemInputTextBox;
        private System.Windows.Forms.NumericUpDown quantitySlider;
        private System.Windows.Forms.Button calculateTotalButton;
        private System.Windows.Forms.Label itemNameLabel;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.RichTextBox receiptRichTextBox;
        private System.Windows.Forms.GroupBox itemCategoryGroupBox;
        private System.Windows.Forms.RadioButton importedItemsRadioButton;
        private System.Windows.Forms.RadioButton miscItemsRadioButton;
        private System.Windows.Forms.RadioButton medicalProductsRadioButton;
        private System.Windows.Forms.RadioButton bookRadioButton;
        private System.Windows.Forms.RadioButton foodRadioButton;
        private System.Windows.Forms.Button addToCartButton;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Button clearCartButton;
    }
}

