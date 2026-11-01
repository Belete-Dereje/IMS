using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IMS
{
    public partial class StockOutForm : Form
    {
        public StockOutForm()
        {
            InitializeComponent();

            // Load available products
            cmbProduct.DisplayMember = "ProductName";
            cmbProduct.ValueMember = "ProductCode";
            cmbProduct.DataSource = InventoryData.Products;
        }

        private void btnStockOut_Click(object sender, EventArgs e)
        {
            // Check whether a product is selected
            if (cmbProduct.SelectedItem == null)
            {
                MessageBox.Show("Please select a product.");
                return;
            }

            // Get the selected product
            Product product = (Product)cmbProduct.SelectedItem;

            // Get the quantity to remove
            int quantityToRemove = (int)numQuantity.Value;

            // Check whether enough stock is available
            if (quantityToRemove > product.Quantity)
            {
                MessageBox.Show(
                    "Not enough stock available. Current quantity: "
                    + product.Quantity);

                return;
            }

            // Reduce the product quantity
            product.Quantity = product.Quantity - quantityToRemove;

            // Create a stock transaction record
            StockTransaction transaction = new StockTransaction
            {
                ProductCode = product.ProductCode,
                ProductName = product.ProductName,
                SupplierCode = "",
                TransactionType = "Stock Out",
                Quantity = quantityToRemove,

                // Profit earned = (selling price - purchase cost) x quantity sold
                Profit = (product.SellingPrice - product.PurchaseCost)
                         * quantityToRemove,

                Notes = txtNotes.Text.Trim(),
                TransactionDate = DateTime.Now
            };

            // Save the transaction
            InventoryData.StockTransactions.Add(transaction);

            // Show confirmation
            MessageBox.Show(
                "Stock removed successfully!",
                "Success");

            // Clear the input fields
            numQuantity.Value = 1;
            txtNotes.Clear();
        }
    }
}
