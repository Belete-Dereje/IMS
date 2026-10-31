namespace IMS
{
    public partial class ReportsForm : Form
    {
        public ReportsForm()
        {
            InitializeComponent();
        }

        private void ReportsForm_Load(object sender, EventArgs e)
        {
            RefreshReport();
        }

        private void txtSearchReport_TextChanged(object sender, EventArgs e)
        {
            RefreshReport();
        }

        private void chkLowStockOnly_CheckedChanged(object sender, EventArgs e)
        {
            RefreshReport();
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            RefreshReport();
        }

        private void btnClearReport_Click(object sender, EventArgs e)
        {
            txtSearchReport.Clear();
            chkLowStockOnly.Checked = false;
            RefreshReport();
        }

        private void btnBackToDashboard_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RefreshReport()
        {
            string searchText = txtSearchReport.Text.Trim();
            lvReportResults.Items.Clear();

            foreach (Product product in InventoryData.Products)
            {
                bool matchesSearch =
                    product.ProductCode.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0 ||
                    product.ProductName.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0 ||
                    product.Category.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0;

                bool isLowStock = product.Quantity <= product.MinimumStock;

                if (!matchesSearch || (chkLowStockOnly.Checked && !isLowStock))
                    continue;

                string supplierName = "Not assigned";
                Supplier? supplier = InventoryData.Suppliers.Find(
                    item => item.SupplierCode.Equals(product.SupplierCode, StringComparison.OrdinalIgnoreCase));

                if (supplier != null)
                    supplierName = supplier.SupplierName;

                ListViewItem row = new ListViewItem(product.ProductCode);
                row.SubItems.Add(product.ProductName);
                row.SubItems.Add(product.Category);
                row.SubItems.Add(product.Quantity.ToString());
                row.SubItems.Add(product.MinimumStock.ToString());
                row.SubItems.Add(product.SellingPrice.ToString("F2"));
                row.SubItems.Add(isLowStock ? "Low Stock" : "In Stock");
                row.SubItems.Add(supplierName);

                lvReportResults.Items.Add(row);
            }
        }
    }
}
