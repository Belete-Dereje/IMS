namespace IMS
{
    partial class ReportsForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            lblReportsHeading = new Label();
            btnBackToDashboard = new Button();
            pnlReportFilters = new Panel();
            btnClearReport = new Button();
            btnGenerateReport = new Button();
            chkLowStockOnly = new CheckBox();
            txtSearchReport = new TextBox();
            pnlReportResults = new Panel();
            lvReportResults = new ListView();
            colProductCode = new ColumnHeader();
            colProductName = new ColumnHeader();
            colCategory = new ColumnHeader();
            colQuantity = new ColumnHeader();
            colMinimumStock = new ColumnHeader();
            colSellingPrice = new ColumnHeader();
            colStockStatus = new ColumnHeader();
            colSupplier = new ColumnHeader();
            lblReportTitle = new Label();
            pnlReportFilters.SuspendLayout();
            pnlReportResults.SuspendLayout();
            SuspendLayout();
            // 
            // lblReportsHeading
            // 
            lblReportsHeading.AutoSize = true;
            lblReportsHeading.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReportsHeading.ForeColor = Color.FromArgb(31, 58, 95);
            lblReportsHeading.Location = new Point(25, 20);
            lblReportsHeading.Name = "lblReportsHeading";
            lblReportsHeading.Size = new Size(105, 32);
            lblReportsHeading.TabIndex = 0;
            lblReportsHeading.Text = "Reports";
            // 
            // btnBackToDashboard
            // 
            btnBackToDashboard.BackColor = Color.FromArgb(229, 234, 240);
            btnBackToDashboard.FlatStyle = FlatStyle.Flat;
            btnBackToDashboard.Font = new Font("Segoe UI", 10F);
            btnBackToDashboard.ForeColor = Color.FromArgb(31, 58, 95);
            btnBackToDashboard.Location = new Point(721, 17);
            btnBackToDashboard.Name = "btnBackToDashboard";
            btnBackToDashboard.Size = new Size(180, 35);
            btnBackToDashboard.TabIndex = 1;
            btnBackToDashboard.Text = "Back to Dashboard";
            btnBackToDashboard.UseVisualStyleBackColor = false;
            btnBackToDashboard.Click += btnBackToDashboard_Click;
            // 
            // pnlReportFilters
            // 
            pnlReportFilters.BackColor = Color.White;
            pnlReportFilters.BorderStyle = BorderStyle.FixedSingle;
            pnlReportFilters.Controls.Add(btnClearReport);
            pnlReportFilters.Controls.Add(btnGenerateReport);
            pnlReportFilters.Controls.Add(chkLowStockOnly);
            pnlReportFilters.Controls.Add(txtSearchReport);
            pnlReportFilters.Location = new Point(10, 70);
            pnlReportFilters.Name = "pnlReportFilters";
            pnlReportFilters.Size = new Size(934, 100);
            pnlReportFilters.TabIndex = 2;
            // 
            // txtSearchReport
            // 
            txtSearchReport.Font = new Font("Segoe UI", 10F);
            txtSearchReport.Location = new Point(18, 18);
            txtSearchReport.Name = "txtSearchReport";
            txtSearchReport.PlaceholderText = "Search by product code or product name...";
            txtSearchReport.Size = new Size(480, 25);
            txtSearchReport.TabIndex = 0;
            txtSearchReport.TextChanged += txtSearchReport_TextChanged;
            // 
            // chkLowStockOnly
            // 
            chkLowStockOnly.AutoSize = true;
            chkLowStockOnly.Font = new Font("Segoe UI", 10F);
            chkLowStockOnly.ForeColor = Color.FromArgb(31, 41, 55);
            chkLowStockOnly.Location = new Point(18, 58);
            chkLowStockOnly.Name = "chkLowStockOnly";
            chkLowStockOnly.Size = new Size(145, 23);
            chkLowStockOnly.TabIndex = 1;
            chkLowStockOnly.Text = "Show Low Stock Only";
            chkLowStockOnly.UseVisualStyleBackColor = true;
            chkLowStockOnly.CheckedChanged += chkLowStockOnly_CheckedChanged;
            // 
            // btnGenerateReport
            // 
            btnGenerateReport.BackColor = Color.FromArgb(47, 93, 138);
            btnGenerateReport.FlatStyle = FlatStyle.Flat;
            btnGenerateReport.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGenerateReport.ForeColor = Color.White;
            btnGenerateReport.Location = new Point(650, 17);
            btnGenerateReport.Name = "btnGenerateReport";
            btnGenerateReport.Size = new Size(150, 35);
            btnGenerateReport.TabIndex = 2;
            btnGenerateReport.Text = "Generate Report";
            btnGenerateReport.UseVisualStyleBackColor = false;
            btnGenerateReport.Click += btnGenerateReport_Click;
            // 
            // btnClearReport
            // 
            btnClearReport.BackColor = Color.FromArgb(229, 234, 240);
            btnClearReport.FlatStyle = FlatStyle.Flat;
            btnClearReport.Font = new Font("Segoe UI", 10F);
            btnClearReport.ForeColor = Color.FromArgb(31, 58, 95);
            btnClearReport.Location = new Point(815, 17);
            btnClearReport.Name = "btnClearReport";
            btnClearReport.Size = new Size(90, 35);
            btnClearReport.TabIndex = 3;
            btnClearReport.Text = "Clear";
            btnClearReport.UseVisualStyleBackColor = false;
            btnClearReport.Click += btnClearReport_Click;
            // 
            // pnlReportResults
            // 
            pnlReportResults.BackColor = Color.White;
            pnlReportResults.BorderStyle = BorderStyle.FixedSingle;
            pnlReportResults.Controls.Add(lvReportResults);
            pnlReportResults.Controls.Add(lblReportTitle);
            pnlReportResults.Location = new Point(10, 185);
            pnlReportResults.Name = "pnlReportResults";
            pnlReportResults.Size = new Size(934, 380);
            pnlReportResults.TabIndex = 3;
            // 
            // lblReportTitle
            // 
            lblReportTitle.AutoSize = true;
            lblReportTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReportTitle.ForeColor = Color.FromArgb(31, 58, 95);
            lblReportTitle.Location = new Point(18, 12);
            lblReportTitle.Name = "lblReportTitle";
            lblReportTitle.Size = new Size(155, 25);
            lblReportTitle.TabIndex = 0;
            lblReportTitle.Text = "Inventory Report";
            // 
            // lvReportResults
            // 
            lvReportResults.Columns.AddRange(new ColumnHeader[] { colProductCode, colProductName, colCategory, colQuantity, colMinimumStock, colSellingPrice, colStockStatus, colSupplier });
            lvReportResults.FullRowSelect = true;
            lvReportResults.GridLines = true;
            lvReportResults.Location = new Point(14, 48);
            lvReportResults.MultiSelect = false;
            lvReportResults.Name = "lvReportResults";
            lvReportResults.Size = new Size(900, 315);
            lvReportResults.TabIndex = 1;
            lvReportResults.UseCompatibleStateImageBehavior = false;
            lvReportResults.View = View.Details;
            // 
            // Column headers
            // 
            colProductCode.Text = "Product Code"; colProductCode.Width = 105;
            colProductName.Text = "Product Name"; colProductName.Width = 145;
            colCategory.Text = "Category"; colCategory.Width = 105;
            colQuantity.Text = "Quantity"; colQuantity.Width = 70;
            colMinimumStock.Text = "Minimum Stock"; colMinimumStock.Width = 100;
            colSellingPrice.Text = "Selling Price"; colSellingPrice.Width = 95;
            colStockStatus.Text = "Stock Status"; colStockStatus.Width = 110;
            colSupplier.Text = "Supplier"; colSupplier.Width = 145;
            // 
            // ReportsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 246, 249);
            ClientSize = new Size(958, 597);
            Controls.Add(pnlReportResults);
            Controls.Add(pnlReportFilters);
            Controls.Add(btnBackToDashboard);
            Controls.Add(lblReportsHeading);
            Name = "ReportsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reports";
            Load += ReportsForm_Load;
            pnlReportFilters.ResumeLayout(false);
            pnlReportFilters.PerformLayout();
            pnlReportResults.ResumeLayout(false);
            pnlReportResults.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private Label lblReportsHeading;
        private Panel pnlReportFilters;
        private TextBox txtSearchReport;
        private CheckBox chkLowStockOnly;
        private Button btnGenerateReport;
        private Button btnClearReport;
        private Panel pnlReportResults;
        private Label lblReportTitle;
        private ListView lvReportResults;
        private ColumnHeader colProductCode;
        private ColumnHeader colProductName;
        private ColumnHeader colCategory;
        private ColumnHeader colQuantity;
        private ColumnHeader colMinimumStock;
        private ColumnHeader colSellingPrice;
        private ColumnHeader colStockStatus;
        private ColumnHeader colSupplier;
        private Button btnBackToDashboard;
    }
}
