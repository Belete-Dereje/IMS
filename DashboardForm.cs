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

            // Hide the page panel when Dashboard starts
            pnlPageHost.Visible = false;

            // Keep the Dashboard controls in front
            pnlPageHost.SendToBack();

            RefreshDashboard();
        }

        private void lvLowStockProducts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            ShowPage(new ProductsForm());
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            ShowPage(new CatagoriesForm());
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            pnlPageHost.Visible = false;

            // Move the page panel behind Dashboard controls
            pnlPageHost.SendToBack();

            RefreshDashboard();
        }
        private void ShowPage(Form page)
        {
            // Remove the previous page
            pnlPageHost.Controls.Clear();

            // Prepare the selected form
            page.TopLevel = false;
            page.FormBorderStyle = FormBorderStyle.None;
            page.Dock = DockStyle.Fill;

            // Allow scrolling when the page is larger than the panel
            page.AutoScroll = true;

            // Add the form to the panel
            pnlPageHost.Controls.Add(page);

            // Handle closing the page
            page.FormClosed += (s, args) =>
            {
                pnlPageHost.Visible = false;
                pnlPageHost.SendToBack();

                RefreshDashboard();
            };

            // Display the page panel
            pnlPageHost.Visible = true;
            pnlPageHost.BringToFront();

            // Display the selected form
            page.Show();
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
            ShowPage(new StockInForm());
        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            ShowPage(new SuppliersForm());
        }

        private void btnStockOut_Click(object sender, EventArgs e)
        {
            ShowPage(new StockOutForm());
        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            ShowPage(new TransactionsForm());
        }
    }

}
