using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IMS
{
    public partial class StockInForm : Form
    {
        public StockInForm()
        {
            InitializeComponent();

            cmbProduct.DisplayMember = "ProductName";
            cmbProduct.ValueMember = "ProductCode";
            cmbProduct.DataSource = InventoryData.Products;

            // Load suppliers
            cmbSupplier.DisplayMember = "SupplierName";
            cmbSupplier.ValueMember = "SupplierCode";
            cmbSupplier.DataSource = InventoryData.Suppliers;
        }

        private void StockInForm_Load(object sender, EventArgs e)
        {

        }

        private void btnStockIn_Click(object sender, EventArgs e)
        {
            // Check that a product is selected
            if (cmbProduct.SelectedItem == null)
            {
                MessageBox.Show("Please select a product.");
                return;
            }

            // Get the selected product
            Product product = (Product)cmbProduct.SelectedItem;
            // Check that a supplier is selected
            if (cmbSupplier.SelectedItem == null)
            {
                MessageBox.Show("Please select a supplier.");
                return;
            }

            // Get the selected supplier
            Supplier supplier = (Supplier)cmbSupplier.SelectedItem;

            // Get the quantity to add
            int quantityToAdd = (int)numQuantity.Value;

            // Check that the new quantity will not exceed the limit
            if (product.Quantity > 1000000 - quantityToAdd)
            {
                MessageBox.Show("The resulting quantity is too large.");
                return;
            }

            // Increase the product quantity
            product.Quantity = product.Quantity + quantityToAdd;

            // Create a stock receipt record
            StockTransaction transaction = new StockTransaction
            {
                ProductCode = product.ProductCode,
                ProductName = product.ProductName,
                SupplierCode = supplier.SupplierCode,
                TransactionType = "Stock In",
                Quantity = quantityToAdd,

                Notes = txtNotes.Text.Trim(),
                TransactionDate = DateTime.Now
            };

            // Save the transaction in shared memory
            InventoryData.StockTransactions.Add(transaction);

            // Show a confirmation message
            MessageBox.Show(
                "Stock received successfully!",
                "Success");

            // Reset the quantity and notes fields
            numQuantity.Value = 1;
            txtNotes.Clear();
        }
    }
}
