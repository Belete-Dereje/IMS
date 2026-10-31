using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IMS
{
    public partial class TransactionsForm : Form
    {
        public TransactionsForm()
        {
            InitializeComponent();

            RefreshTransactionList();
        }

        private void txtSearchTransactions_TextChanged(object sender, EventArgs e)
        {
            RefreshTransactionList();
        }

        private void RefreshTransactionList()
        {
            // Get the search text
            string searchText = txtSearchTransactions.Text.Trim();

            // Clear the current table
            lvTransactions.Items.Clear();

            // Check every transaction
            foreach (StockTransaction transaction in InventoryData.StockTransactions)
            {
                // Search by product code or product name
                if (transaction.ProductCode.IndexOf(
                        searchText, StringComparison.OrdinalIgnoreCase) >= 0 ||
                    transaction.ProductName.IndexOf(
                        searchText, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    // Find the supplier name
                    string supplierName = "-";

                    foreach (Supplier supplier in InventoryData.Suppliers)
                    {
                        if (supplier.SupplierCode.Equals(
                            transaction.SupplierCode,
                            StringComparison.OrdinalIgnoreCase))
                        {
                            supplierName = supplier.SupplierName;
                            break;
                        }
                    }

                    // Create a transaction row
                    ListViewItem item = new ListViewItem(
                        transaction.TransactionDate.ToString("yyyy-MM-dd HH:mm"));

                    item.SubItems.Add(transaction.TransactionType);
                    item.SubItems.Add(transaction.ProductCode);
                    item.SubItems.Add(transaction.ProductName);
                    item.SubItems.Add(supplierName);
                    item.SubItems.Add(transaction.Quantity.ToString());
                    item.SubItems.Add(transaction.Notes);

                    // Display the transaction
                    lvTransactions.Items.Add(item);
                }
            }
        }
    }
}