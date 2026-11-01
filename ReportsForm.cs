using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IMS
{
    public partial class ReportsForm : Form
    {
        public ReportsForm()
        {
            InitializeComponent();

            // Default date range for transaction reports
            dtpFrom.Value = DateTime.Today.AddDays(-30);
            dtpTo.Value = DateTime.Today;

            cmbReportType.SelectedIndex = 4;

            GenerateReport();
        }

        private void cmbReportType_SelectedIndexChanged(object sender, EventArgs e)
        {
            GenerateReport();
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            GenerateReport();
        }

        private void btnClearFilters_Click(object sender, EventArgs e)
        {
            dtpFrom.Value = DateTime.Today.AddDays(-30);
            dtpTo.Value = DateTime.Today;

            cmbReportType.SelectedIndex = 4;

            GenerateReport();
        }

        private void dtpFrom_ValueChanged(object sender, EventArgs e)
        {
            GenerateReport();
        }

        private void dtpTo_ValueChanged(object sender, EventArgs e)
        {
            GenerateReport();
        }

        private bool ValidateDateRange()
        {
            if (dtpFrom.Value.Date > dtpTo.Value.Date)
            {
                MessageBox.Show(
                    "The From date cannot be after the To date.",
                    "Invalid Date Range",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return false;
            }

            return true;
        }

        private void GenerateReport()
        {
            UpdateSummary();

            lvReport.Items.Clear();

            if (cmbReportType.SelectedIndex <= 1)
            {
                GenerateStockStatusReport();
            }
            else
            {
                if (!ValidateDateRange())
                {
                    lblReportStatus.Text = "Invalid date range.";
                    return;
                }

                GenerateTransactionReport();
            }

            lblReportStatus.Text =
                "Showing " + lvReport.Items.Count + " record(s).";

            if (cmbReportType.SelectedIndex <= 1)
            {
                lblReportStatus.Text +=
                    " Date filters apply to transaction reports only.";
            }
        }

        private void UpdateSummary()
        {
            decimal totalStockValue = 0;
            int lowStockCount = 0;

            foreach (Product product in InventoryData.Products)
            {
                // Value the stock at its purchase cost
                totalStockValue +=
                    product.Quantity * product.PurchaseCost;

                if (product.Quantity <= product.MinimumStock)
                {
                    lowStockCount++;
                }
            }

            lblTotalProductsValue.Text =
                InventoryData.Products.Count.ToString();

            lblTotalStockValue.Text = totalStockValue.ToString("0.00");
            lblLowStockValue.Text = lowStockCount.ToString();

            lblTransactionsValue.Text =
                InventoryData.StockTransactions.Count.ToString();
        }

        private void GenerateStockStatusReport()
        {
            SetReportColumns(
                new string[]
                {
                    "Product Code",
                    "Product Name",
                    "Category",
                    "Quantity",
                    "Unit",
                    "Minimum Stock",
                    "Status"
                },
                new int[] { 120, 200, 140, 100, 90, 120, 120 });

            bool lowStockOnly = cmbReportType.SelectedIndex == 1;

            foreach (Product product in InventoryData.Products)
            {
                bool isLowStock = product.Quantity <= product.MinimumStock;

                if (lowStockOnly && !isLowStock)
                {
                    continue;
                }

                ListViewItem item = new ListViewItem(product.ProductCode);

                item.SubItems.Add(product.ProductName);
                item.SubItems.Add(product.Category);
                item.SubItems.Add(product.Quantity.ToString());
                item.SubItems.Add(product.Unit);
                item.SubItems.Add(product.MinimumStock.ToString());
                item.SubItems.Add(isLowStock ? "Low Stock" : "In Stock");

                lvReport.Items.Add(item);
            }
        }

        private void GenerateTransactionReport()
        {
            bool stockInOnly = cmbReportType.SelectedIndex == 2;
            bool stockOutOnly = cmbReportType.SelectedIndex == 3;

            DateTime fromDate = dtpFrom.Value.Date;
            DateTime toDate = dtpTo.Value.Date.AddDays(1);

            if (stockInOnly)
            {
                SetReportColumns(
                    new string[]
                    {
                        "Date",
                        "Product Code",
                        "Product Name",
                        "Supplier",
                        "Quantity",
                        "Notes"
                    },
                    new int[] { 140, 130, 190, 160, 100, 200 });
            }
            else if (stockOutOnly)
            {
                SetReportColumns(
                    new string[]
                    {
                        "Date",
                        "Product Code",
                        "Product Name",
                        "Quantity",
                        "Profit",
                        "Notes"
                    },
                    new int[] { 130, 120, 200, 90, 110, 280 });
            }
            else
            {
                SetReportColumns(
                    new string[]
                    {
                        "Date",
                        "Transaction Type",
                        "Product Code",
                        "Product Name",
                        "Supplier",
                        "Quantity",
                        "Profit",
                        "Notes"
                    },
                    new int[] { 120, 110, 100, 150, 110, 80, 100, 160 });
            }

            foreach (StockTransaction transaction in InventoryData.StockTransactions)
            {
                if (transaction.TransactionDate < fromDate ||
                    transaction.TransactionDate >= toDate)
                {
                    continue;
                }

                if (stockInOnly && transaction.TransactionType != "Stock In")
                {
                    continue;
                }

                if (stockOutOnly && transaction.TransactionType != "Stock Out")
                {
                    continue;
                }

                ListViewItem item = new ListViewItem(
                    transaction.TransactionDate.ToString("yyyy-MM-dd HH:mm"));

                if (stockInOnly)
                {
                    item.SubItems.Add(transaction.ProductCode);
                    item.SubItems.Add(transaction.ProductName);
                    item.SubItems.Add(GetSupplierName(transaction.SupplierCode));
                    item.SubItems.Add(transaction.Quantity.ToString());
                    item.SubItems.Add(transaction.Notes);
                }
                else if (stockOutOnly)
                {
                    item.SubItems.Add(transaction.ProductCode);
                    item.SubItems.Add(transaction.ProductName);
                    item.SubItems.Add(transaction.Quantity.ToString());
                    item.SubItems.Add(transaction.Profit.ToString("0.00"));
                    item.SubItems.Add(transaction.Notes);
                }
                else
                {
                    item.SubItems.Add(transaction.TransactionType);
                    item.SubItems.Add(transaction.ProductCode);
                    item.SubItems.Add(transaction.ProductName);
                    item.SubItems.Add(GetSupplierName(transaction.SupplierCode));
                    item.SubItems.Add(transaction.Quantity.ToString());
                    item.SubItems.Add(
                        transaction.TransactionType == "Stock Out"
                            ? transaction.Profit.ToString("0.00")
                            : "-");
                    item.SubItems.Add(transaction.Notes);
                }

                lvReport.Items.Add(item);
            }
        }

        private void SetReportColumns(string[] headers, int[] widths)
        {
            lvReport.Columns.Clear();

            for (int index = 0; index < headers.Length; index++)
            {
                lvReport.Columns.Add(headers[index], widths[index]);
            }
        }

        private string GetSupplierName(string supplierCode)
        {
            foreach (Supplier supplier in InventoryData.Suppliers)
            {
                if (supplier.SupplierCode.Equals(
                    supplierCode, StringComparison.OrdinalIgnoreCase))
                {
                    return supplier.SupplierName;
                }
            }

            return "-";
        }
    }
}
