namespace IMS
{
    partial class ReportsForm
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
            lblReportsHeading = new Label();
            pnlReportFilters = new Panel();
            btnClearFilters = new Button();
            btnGenerateReport = new Button();
            dtpTo = new DateTimePicker();
            lblTo = new Label();
            dtpFrom = new DateTimePicker();
            lblFrom = new Label();
            cmbReportType = new ComboBox();
            lblReportType = new Label();
            pnlTotalProductsCard = new Panel();
            lblTotalProductsValue = new Label();
            lblTotalProductsTitle = new Label();
            pnlTotalStockCard = new Panel();
            lblTotalStockValue = new Label();
            lblTotalStockTitle = new Label();
            pnlLowStockCard = new Panel();
            lblLowStockValue = new Label();
            lblLowStockTitle = new Label();
            pnlTransactionsCard = new Panel();
            lblTransactionsValue = new Label();
            lblTransactionsTitle = new Label();
            lblReportStatus = new Label();
            lvReport = new ListView();
            colReport1 = new ColumnHeader();
            colReport2 = new ColumnHeader();
            colReport3 = new ColumnHeader();
            colReport4 = new ColumnHeader();
            colReport5 = new ColumnHeader();
            colReport6 = new ColumnHeader();
            colReport7 = new ColumnHeader();
            pnlReportFilters.SuspendLayout();
            pnlTotalProductsCard.SuspendLayout();
            pnlTotalStockCard.SuspendLayout();
            pnlLowStockCard.SuspendLayout();
            pnlTransactionsCard.SuspendLayout();
            SuspendLayout();
            // 
            // lblReportsHeading
            // 
            lblReportsHeading.AutoSize = true;
            lblReportsHeading.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReportsHeading.ForeColor = Color.FromArgb(31, 58, 95);
            lblReportsHeading.Location = new Point(25, 20);
            lblReportsHeading.Name = "lblReportsHeading";
            lblReportsHeading.Size = new Size(222, 32);
            lblReportsHeading.TabIndex = 0;
            lblReportsHeading.Text = "Inventory Reports";
            // 
            // pnlReportFilters
            // 
            pnlReportFilters.BackColor = Color.White;
            pnlReportFilters.BorderStyle = BorderStyle.FixedSingle;
            pnlReportFilters.Controls.Add(btnClearFilters);
            pnlReportFilters.Controls.Add(btnGenerateReport);
            pnlReportFilters.Controls.Add(dtpTo);
            pnlReportFilters.Controls.Add(lblTo);
            pnlReportFilters.Controls.Add(dtpFrom);
            pnlReportFilters.Controls.Add(lblFrom);
            pnlReportFilters.Controls.Add(cmbReportType);
            pnlReportFilters.Controls.Add(lblReportType);
            pnlReportFilters.Location = new Point(10, 62);
            pnlReportFilters.Name = "pnlReportFilters";
            pnlReportFilters.Size = new Size(934, 100);
            pnlReportFilters.TabIndex = 1;
            // 
            // btnClearFilters
            // 
            btnClearFilters.BackColor = Color.FromArgb(229, 234, 240);
            btnClearFilters.FlatStyle = FlatStyle.Flat;
            btnClearFilters.Font = new Font("Segoe UI", 10F);
            btnClearFilters.ForeColor = Color.FromArgb(31, 58, 95);
            btnClearFilters.Location = new Point(750, 38);
            btnClearFilters.Name = "btnClearFilters";
            btnClearFilters.Size = new Size(100, 33);
            btnClearFilters.TabIndex = 7;
            btnClearFilters.Text = "Clear";
            btnClearFilters.UseVisualStyleBackColor = false;
            btnClearFilters.Click += btnClearFilters_Click;
            // 
            // btnGenerateReport
            // 
            btnGenerateReport.BackColor = Color.FromArgb(47, 93, 138);
            btnGenerateReport.FlatStyle = FlatStyle.Flat;
            btnGenerateReport.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerateReport.ForeColor = Color.White;
            btnGenerateReport.Location = new Point(575, 38);
            btnGenerateReport.Name = "btnGenerateReport";
            btnGenerateReport.Size = new Size(160, 33);
            btnGenerateReport.TabIndex = 6;
            btnGenerateReport.Text = "Generate Report";
            btnGenerateReport.UseVisualStyleBackColor = false;
            btnGenerateReport.Click += btnGenerateReport_Click;
            // 
            // dtpTo
            // 
            dtpTo.Font = new Font("Segoe UI", 10F);
            dtpTo.Format = DateTimePickerFormat.Short;
            dtpTo.Location = new Point(405, 42);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(140, 25);
            dtpTo.TabIndex = 5;
            dtpTo.ValueChanged += dtpTo_ValueChanged;
            // 
            // lblTo
            // 
            lblTo.AutoSize = true;
            lblTo.Font = new Font("Segoe UI", 10F);
            lblTo.ForeColor = Color.FromArgb(31, 41, 55);
            lblTo.Location = new Point(405, 18);
            lblTo.Name = "lblTo";
            lblTo.Size = new Size(23, 19);
            lblTo.TabIndex = 4;
            lblTo.Text = "To";
            // 
            // dtpFrom
            // 
            dtpFrom.Font = new Font("Segoe UI", 10F);
            dtpFrom.Format = DateTimePickerFormat.Short;
            dtpFrom.Location = new Point(245, 42);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(140, 25);
            dtpFrom.TabIndex = 3;
            dtpFrom.ValueChanged += dtpFrom_ValueChanged;
            // 
            // lblFrom
            // 
            lblFrom.AutoSize = true;
            lblFrom.Font = new Font("Segoe UI", 10F);
            lblFrom.ForeColor = Color.FromArgb(31, 41, 55);
            lblFrom.Location = new Point(245, 18);
            lblFrom.Name = "lblFrom";
            lblFrom.Size = new Size(41, 19);
            lblFrom.TabIndex = 2;
            lblFrom.Text = "From";
            // 
            // cmbReportType
            // 
            cmbReportType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbReportType.Font = new Font("Segoe UI", 10F);
            cmbReportType.FormattingEnabled = true;
            cmbReportType.Items.AddRange(new object[] { "Stock Status", "Low Stock Products", "Stock In History", "Stock Out History", "All Transactions" });
            cmbReportType.Location = new Point(20, 42);
            cmbReportType.Name = "cmbReportType";
            cmbReportType.Size = new Size(200, 25);
            cmbReportType.TabIndex = 1;
            cmbReportType.SelectedIndexChanged += cmbReportType_SelectedIndexChanged;
            // 
            // lblReportType
            // 
            lblReportType.AutoSize = true;
            lblReportType.Font = new Font("Segoe UI", 10F);
            lblReportType.ForeColor = Color.FromArgb(31, 41, 55);
            lblReportType.Location = new Point(20, 18);
            lblReportType.Name = "lblReportType";
            lblReportType.Size = new Size(82, 19);
            lblReportType.TabIndex = 0;
            lblReportType.Text = "Report Type";
            // 
            // pnlTotalProductsCard
            // 
            pnlTotalProductsCard.BackColor = Color.White;
            pnlTotalProductsCard.BorderStyle = BorderStyle.FixedSingle;
            pnlTotalProductsCard.Controls.Add(lblTotalProductsValue);
            pnlTotalProductsCard.Controls.Add(lblTotalProductsTitle);
            pnlTotalProductsCard.Location = new Point(10, 175);
            pnlTotalProductsCard.Name = "pnlTotalProductsCard";
            pnlTotalProductsCard.Size = new Size(222, 80);
            pnlTotalProductsCard.TabIndex = 2;
            // 
            // lblTotalProductsValue
            // 
            lblTotalProductsValue.AutoSize = true;
            lblTotalProductsValue.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalProductsValue.ForeColor = Color.FromArgb(31, 58, 95);
            lblTotalProductsValue.Location = new Point(15, 32);
            lblTotalProductsValue.Name = "lblTotalProductsValue";
            lblTotalProductsValue.Size = new Size(28, 32);
            lblTotalProductsValue.TabIndex = 1;
            lblTotalProductsValue.Text = "0";
            // 
            // lblTotalProductsTitle
            // 
            lblTotalProductsTitle.AutoSize = true;
            lblTotalProductsTitle.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalProductsTitle.ForeColor = Color.FromArgb(107, 114, 128);
            lblTotalProductsTitle.Location = new Point(15, 10);
            lblTotalProductsTitle.Name = "lblTotalProductsTitle";
            lblTotalProductsTitle.Size = new Size(91, 17);
            lblTotalProductsTitle.TabIndex = 0;
            lblTotalProductsTitle.Text = "Total Products";
            // 
            // pnlTotalStockCard
            // 
            pnlTotalStockCard.BackColor = Color.White;
            pnlTotalStockCard.BorderStyle = BorderStyle.FixedSingle;
            pnlTotalStockCard.Controls.Add(lblTotalStockValue);
            pnlTotalStockCard.Controls.Add(lblTotalStockTitle);
            pnlTotalStockCard.Location = new Point(247, 175);
            pnlTotalStockCard.Name = "pnlTotalStockCard";
            pnlTotalStockCard.Size = new Size(222, 80);
            pnlTotalStockCard.TabIndex = 3;
            // 
            // lblTotalStockValue
            // 
            lblTotalStockValue.AutoSize = true;
            lblTotalStockValue.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalStockValue.ForeColor = Color.FromArgb(31, 58, 95);
            lblTotalStockValue.Location = new Point(15, 32);
            lblTotalStockValue.Name = "lblTotalStockValue";
            lblTotalStockValue.Size = new Size(28, 32);
            lblTotalStockValue.TabIndex = 1;
            lblTotalStockValue.Text = "0";
            // 
            // lblTotalStockTitle
            // 
            lblTotalStockTitle.AutoSize = true;
            lblTotalStockTitle.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalStockTitle.ForeColor = Color.FromArgb(107, 114, 128);
            lblTotalStockTitle.Location = new Point(15, 10);
            lblTotalStockTitle.Name = "lblTotalStockTitle";
            lblTotalStockTitle.Size = new Size(71, 17);
            lblTotalStockTitle.TabIndex = 0;
            lblTotalStockTitle.Text = "Stock Value";
            // 
            // pnlLowStockCard
            // 
            pnlLowStockCard.BackColor = Color.White;
            pnlLowStockCard.BorderStyle = BorderStyle.FixedSingle;
            pnlLowStockCard.Controls.Add(lblLowStockValue);
            pnlLowStockCard.Controls.Add(lblLowStockTitle);
            pnlLowStockCard.Location = new Point(484, 175);
            pnlLowStockCard.Name = "pnlLowStockCard";
            pnlLowStockCard.Size = new Size(222, 80);
            pnlLowStockCard.TabIndex = 4;
            // 
            // lblLowStockValue
            // 
            lblLowStockValue.AutoSize = true;
            lblLowStockValue.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLowStockValue.ForeColor = Color.FromArgb(198, 40, 40);
            lblLowStockValue.Location = new Point(15, 32);
            lblLowStockValue.Name = "lblLowStockValue";
            lblLowStockValue.Size = new Size(28, 32);
            lblLowStockValue.TabIndex = 1;
            lblLowStockValue.Text = "0";
            // 
            // lblLowStockTitle
            // 
            lblLowStockTitle.AutoSize = true;
            lblLowStockTitle.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLowStockTitle.ForeColor = Color.FromArgb(107, 114, 128);
            lblLowStockTitle.Location = new Point(15, 10);
            lblLowStockTitle.Name = "lblLowStockTitle";
            lblLowStockTitle.Size = new Size(101, 17);
            lblLowStockTitle.TabIndex = 0;
            lblLowStockTitle.Text = "Low Stock Items";
            // 
            // pnlTransactionsCard
            // 
            pnlTransactionsCard.BackColor = Color.White;
            pnlTransactionsCard.BorderStyle = BorderStyle.FixedSingle;
            pnlTransactionsCard.Controls.Add(lblTransactionsValue);
            pnlTransactionsCard.Controls.Add(lblTransactionsTitle);
            pnlTransactionsCard.Location = new Point(721, 175);
            pnlTransactionsCard.Name = "pnlTransactionsCard";
            pnlTransactionsCard.Size = new Size(223, 80);
            pnlTransactionsCard.TabIndex = 5;
            // 
            // lblTransactionsValue
            // 
            lblTransactionsValue.AutoSize = true;
            lblTransactionsValue.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTransactionsValue.ForeColor = Color.FromArgb(31, 58, 95);
            lblTransactionsValue.Location = new Point(15, 32);
            lblTransactionsValue.Name = "lblTransactionsValue";
            lblTransactionsValue.Size = new Size(28, 32);
            lblTransactionsValue.TabIndex = 1;
            lblTransactionsValue.Text = "0";
            // 
            // lblTransactionsTitle
            // 
            lblTransactionsTitle.AutoSize = true;
            lblTransactionsTitle.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTransactionsTitle.ForeColor = Color.FromArgb(107, 114, 128);
            lblTransactionsTitle.Location = new Point(15, 10);
            lblTransactionsTitle.Name = "lblTransactionsTitle";
            lblTransactionsTitle.Size = new Size(112, 17);
            lblTransactionsTitle.TabIndex = 0;
            lblTransactionsTitle.Text = "Total Transactions";
            // 
            // lblReportStatus
            // 
            lblReportStatus.AutoSize = true;
            lblReportStatus.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblReportStatus.ForeColor = Color.FromArgb(107, 114, 128);
            lblReportStatus.Location = new Point(15, 265);
            lblReportStatus.Name = "lblReportStatus";
            lblReportStatus.Size = new Size(128, 17);
            lblReportStatus.TabIndex = 6;
            lblReportStatus.Text = "Showing 0 record(s).";
            // 
            // lvReport
            // 
            lvReport.Columns.AddRange(new ColumnHeader[] { colReport1, colReport2, colReport3, colReport4, colReport5, colReport6, colReport7 });
            lvReport.FullRowSelect = true;
            lvReport.GridLines = true;
            lvReport.Location = new Point(10, 290);
            lvReport.MultiSelect = false;
            lvReport.Name = "lvReport";
            lvReport.Size = new Size(934, 297);
            lvReport.TabIndex = 7;
            lvReport.UseCompatibleStateImageBehavior = false;
            lvReport.View = View.Details;
            // 
            // colReport1
            // 
            colReport1.Text = "Product Code";
            colReport1.Width = 120;
            // 
            // colReport2
            // 
            colReport2.Text = "Product Name";
            colReport2.Width = 200;
            // 
            // colReport3
            // 
            colReport3.Text = "Category";
            colReport3.Width = 140;
            // 
            // colReport4
            // 
            colReport4.Text = "Quantity";
            colReport4.Width = 100;
            // 
            // colReport5
            // 
            colReport5.Text = "Unit";
            colReport5.Width = 90;
            // 
            // colReport6
            // 
            colReport6.Text = "Minimum Stock";
            colReport6.Width = 120;
            // 
            // colReport7
            // 
            colReport7.Text = "Status";
            colReport7.Width = 120;
            // 
            // ReportsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 246, 249);
            ClientSize = new Size(958, 597);
            Controls.Add(lvReport);
            Controls.Add(lblReportStatus);
            Controls.Add(pnlTransactionsCard);
            Controls.Add(pnlLowStockCard);
            Controls.Add(pnlTotalStockCard);
            Controls.Add(pnlTotalProductsCard);
            Controls.Add(pnlReportFilters);
            Controls.Add(lblReportsHeading);
            Name = "ReportsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventory Reports";
            pnlReportFilters.ResumeLayout(false);
            pnlReportFilters.PerformLayout();
            pnlTotalProductsCard.ResumeLayout(false);
            pnlTotalProductsCard.PerformLayout();
            pnlTotalStockCard.ResumeLayout(false);
            pnlTotalStockCard.PerformLayout();
            pnlLowStockCard.ResumeLayout(false);
            pnlLowStockCard.PerformLayout();
            pnlTransactionsCard.ResumeLayout(false);
            pnlTransactionsCard.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblReportsHeading;
        private Panel pnlReportFilters;
        private Label lblReportType;
        private ComboBox cmbReportType;
        private Label lblFrom;
        private DateTimePicker dtpFrom;
        private Label lblTo;
        private DateTimePicker dtpTo;
        private Button btnGenerateReport;
        private Button btnClearFilters;
        private Panel pnlTotalProductsCard;
        private Label lblTotalProductsTitle;
        private Label lblTotalProductsValue;
        private Panel pnlTotalStockCard;
        private Label lblTotalStockTitle;
        private Label lblTotalStockValue;
        private Panel pnlLowStockCard;
        private Label lblLowStockTitle;
        private Label lblLowStockValue;
        private Panel pnlTransactionsCard;
        private Label lblTransactionsTitle;
        private Label lblTransactionsValue;
        private Label lblReportStatus;
        private ListView lvReport;
        private ColumnHeader colReport1;
        private ColumnHeader colReport2;
        private ColumnHeader colReport3;
        private ColumnHeader colReport4;
        private ColumnHeader colReport5;
        private ColumnHeader colReport6;
        private ColumnHeader colReport7;
    }
}
