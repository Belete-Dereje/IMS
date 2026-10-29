using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IMS
{
    public partial class ProductsForm : Form
    {
        private string editingProductCode = "";
        public ProductsForm()
        {
            InitializeComponent();

            // Display the saved in-memory products
            RefreshProductList();
        }

        private void numPurchaseCost_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtProductCode.Clear();
            txtProductName.Clear();

            cmbCategory.SelectedIndex = -1;
            cmbUnit.SelectedIndex = -1;

            numPurchaseCost.Value = 0;
            numSellingPrice.Value = 0;
            numInitialQuantity.Value = 0;
            numMinimumStock.Value = 0;

            editingProductCode = "";
            btnAddProduct.Text = "Add Product";
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            string code = txtProductCode.Text.Trim();
            string name = txtProductName.Text.Trim();

            if (code == "" || name == "")
            {
                MessageBox.Show("Please enter the Product Code and Product Name.");
                return;
            }

            if (cmbCategory.SelectedIndex == -1 ||
                cmbUnit.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a Category and Unit.");
                return;
            }

            // Find the product currently being edited, if any.
            Product productBeingEdited = null;

            if (editingProductCode != "")
            {
                productBeingEdited = InventoryData.Products.Find(
                    p => p.ProductCode.Equals(
                        editingProductCode,
                        StringComparison.OrdinalIgnoreCase));

                if (productBeingEdited == null)
                {
                    MessageBox.Show("The product being edited was not found.");
                    return;
                }
            }

            // Check for duplicate product codes.
            foreach (Product existingProduct in InventoryData.Products)
            {
                if (existingProduct.ProductCode.Equals(
                        code, StringComparison.OrdinalIgnoreCase)
                    && !ReferenceEquals(existingProduct, productBeingEdited))
                {
                    MessageBox.Show("This product code already exists.");
                    return;
                }
            }

            bool isUpdating = productBeingEdited != null;
            Product product;

            if (isUpdating)
            {
                // Update the existing product.
                product = productBeingEdited;
                product.ProductCode = code;
                product.ProductName = name;
                product.Category = cmbCategory.SelectedItem.ToString();
                product.Unit = cmbUnit.SelectedItem.ToString();
                product.PurchaseCost = numPurchaseCost.Value;
                product.SellingPrice = numSellingPrice.Value;
                product.Quantity = (int)numInitialQuantity.Value;
                product.MinimumStock = (int)numMinimumStock.Value;
            }
            else
            {
                // Create a new product.
                product = new Product
                {
                    ProductCode = code,
                    ProductName = name,
                    Category = cmbCategory.SelectedItem.ToString(),
                    Unit = cmbUnit.SelectedItem.ToString(),
                    PurchaseCost = numPurchaseCost.Value,
                    SellingPrice = numSellingPrice.Value,
                    Quantity = (int)numInitialQuantity.Value,
                    MinimumStock = (int)numMinimumStock.Value
                };

                InventoryData.Products.Add(product);
            }

            // Find the existing row when updating.
            RefreshProductList();

            MessageBox.Show(
                isUpdating
                    ? "Product updated successfully!"
                    : "Product added successfully!",
                "Inventory Management System");

            // Return the form to Add Product mode.
            editingProductCode = "";
            btnAddProduct.Text = "Add Product";

            btnClear.PerformClick();
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            if (lvProducts.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a product first.");
                return;
            }

            string selectedCode = lvProducts.SelectedItems[0].Text;

            Product product = InventoryData.Products.Find(
                 p => p.ProductCode.Equals(selectedCode, StringComparison.OrdinalIgnoreCase));

            if (product == null)
            {
                MessageBox.Show("Product not found.");
                return;
            }

            txtProductCode.Text = product.ProductCode;
            txtProductName.Text = product.ProductName;

            editingProductCode = product.ProductCode;
            btnAddProduct.Text = "Update Product";

            cmbCategory.SelectedItem = product.Category;
            cmbUnit.SelectedItem = product.Unit;

            numPurchaseCost.Value = product.PurchaseCost;
            numSellingPrice.Value = product.SellingPrice;
            numInitialQuantity.Value = product.Quantity;
            numMinimumStock.Value = product.MinimumStock;

            MessageBox.Show("Product details loaded into the form.");
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            // Check whether a product is selected
            if (lvProducts.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a product to delete.");
                return;
            }

            // Get the selected product code
            ListViewItem selectedItem = lvProducts.SelectedItems[0];
            string code = selectedItem.Text;

            // Ask for confirmation
            DialogResult answer = MessageBox.Show(
                "Are you sure you want to delete this product?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (answer == DialogResult.No)
            {
                return;
            }

            // Find the product in shared memory
            Product product = InventoryData.Products.Find(
                p => p.ProductCode.Equals(
                    code, StringComparison.OrdinalIgnoreCase));

            if (product == null)
            {
                MessageBox.Show("Product not found.");
                return;
            }

            // Remove the product from memory and the table
            InventoryData.Products.Remove(product);
            selectedItem.Remove();

            // Clear the form if this product was being edited
            if (editingProductCode.Equals(
                code, StringComparison.OrdinalIgnoreCase))
            {
                btnClear.PerformClick();
            }

            MessageBox.Show("Product deleted successfully.");
        }

        private void txtSearchProducts_TextChanged(object sender, EventArgs e)
        {
            RefreshProductList();
        }
        private void RefreshProductList()
        {
            string searchText = txtSearchProducts.Text.Trim();

            // Clear the displayed rows
            lvProducts.Items.Clear();

            // Check every product
            foreach (Product product in InventoryData.Products)
            {
                // Show only products matching the search
                if (product.ProductCode.IndexOf(
                        searchText, StringComparison.OrdinalIgnoreCase) >= 0 ||
                    product.ProductName.IndexOf(
                        searchText, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    ListViewItem item = new ListViewItem(product.ProductCode);

                    item.SubItems.Add(product.ProductName);
                    item.SubItems.Add(product.Category);
                    item.SubItems.Add(product.Quantity.ToString());
                    item.SubItems.Add(product.Unit);
                    item.SubItems.Add(product.SellingPrice.ToString("0.00"));

                    string status = product.Quantity <= product.MinimumStock
                        ? "Low Stock"
                        : "In Stock";

                    item.SubItems.Add(status);

                    lvProducts.Items.Add(item);
                }
            }
        }

        private void btnBackToDashboard_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
