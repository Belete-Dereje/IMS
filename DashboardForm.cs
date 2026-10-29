using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IMS
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();

            RefreshDashboard();
        }

        private void lvLowStockProducts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            ProductsForm productsForm = new ProductsForm();

            productsForm.FormClosed += (s, args) =>
            {
                this.Show();
                RefreshDashboard();
            };

            this.Hide();
            productsForm.Show();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {

        }
        private void RefreshDashboard()
        {
            // Display the total number of products
            lblProductsCount.Text =
                InventoryData.Products.Count.ToString();

            // Count the different categories
            List<string> categories = new List<string>();

            foreach (Product product in InventoryData.Products)
            {
                if (!categories.Contains(product.Category))
                {
                    categories.Add(product.Category);
                }
            }

            lblCategoriesCount.Text = categories.Count.ToString();
            // Count today's stock transactions
            int todayTransactions = 0;

            foreach (StockTransaction transaction in InventoryData.StockTransactions)
            {
                if (transaction.TransactionDate.Date == DateTime.Today)
                {
                    todayTransactions++;
                }
            }

            // Display today's transaction count
            lblTransactionsCount.Text = todayTransactions.ToString();

            // Clear the Low Stock table
            lvLowStockProducts.Items.Clear();

            int lowStockCount = 0;

            // Find products that need restocking
            foreach (Product product in InventoryData.Products)
            {
                if (product.Quantity <= product.MinimumStock)
                {
                    lowStockCount++;

                    ListViewItem item =
                        new ListViewItem(product.ProductCode);

                    item.SubItems.Add(product.ProductName);
                    item.SubItems.Add(product.Quantity.ToString());
                    item.SubItems.Add(product.MinimumStock.ToString());

                    lvLowStockProducts.Items.Add(item);
                }
            }

            // Display the Low Stock count
            lblLowStockCount.Text = lowStockCount.ToString();

            // Display a message when there are no low-stock products
            if (lowStockCount == 0)
            {
                lblLowStockStatus.Text = "No low-stock products found.";
            }
            else
            {
                lblLowStockStatus.Text =
                    lowStockCount + " product(s) need restocking.";
            }
        }

        private void btnStockIn_Click(object sender, EventArgs e)
        {
            StockInForm stockInForm = new StockInForm();

            stockInForm.FormClosed += (s, args) =>
            {
                this.Show();
                RefreshDashboard();
            };

            this.Hide();
            stockInForm.Show();
        }
    }

}
