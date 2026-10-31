namespace IMS
{
    partial class DashboardForm
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
            ListViewItem listViewItem1 = new ListViewItem("Product Code");
            pnlHeader = new Panel();
            lblAppTitle = new Label();
            pnlSidebar = new Panel();
            btnStockOut = new Button();
            btnStockIn = new Button();
            btnReports = new Button();
            btnTransactions = new Button();
            btnSuppliers = new Button();
            btnCategories = new Button();
            btnProducts = new Button();
            btnDashboard = new Button();
            lblMenuTitle = new Label();
            pnlContent = new Panel();
            pnlPageHost = new Panel();
            pnlLowStockSection = new Panel();
            lblLowStockStatus = new Label();
            lvLowStockProducts = new ListView();
            colProductCode = new ColumnHeader();
            colProductName = new ColumnHeader();
            colCurrentQuantity = new ColumnHeader();
            colMinimumStock = new ColumnHeader();
            lblLowStockSectionTitle = new Label();
            pnlTransactionsCard = new Panel();
            lblTransactionsCount = new Label();
            lblTransactionsTitle = new Label();
            pnlLowStockCard = new Panel();
            lblLowStockCount = new Label();
            lblLowStockTitle = new Label();
            pnlCategoriesCard = new Panel();
            lblCategoriesCount = new Label();
            lblCategoriesTitle = new Label();
            pnlProductsCard = new Panel();
            lblProductsCount = new Label();
            lblProductsTitle = new Label();
            lblDashboardHeading = new Label();
            pnlHeader.SuspendLayout();
            pnlSidebar.SuspendLayout();
            pnlContent.SuspendLayout();
            pnlLowStockSection.SuspendLayout();
            pnlTransactionsCard.SuspendLayout();
            pnlLowStockCard.SuspendLayout();
            pnlCategoriesCard.SuspendLayout();
            pnlProductsCard.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(31, 58, 95);
            pnlHeader.Controls.Add(lblAppTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(4, 5, 4, 5);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1691, 125);
            pnlHeader.TabIndex = 0;
            // 
            // lblAppTitle
            // 
            lblAppTitle.AutoSize = true;
            lblAppTitle.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAppTitle.ForeColor = Color.White;
            lblAppTitle.Location = new Point(81, 37);
            lblAppTitle.Margin = new Padding(4, 0, 4, 0);
            lblAppTitle.Name = "lblAppTitle";
            lblAppTitle.Size = new Size(574, 45);
            lblAppTitle.TabIndex = 0;
            lblAppTitle.Text = "INVENTORY MANAGEMENT SYSTEM";
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(229, 234, 240);
            pnlSidebar.Controls.Add(btnStockOut);
            pnlSidebar.Controls.Add(btnStockIn);
            pnlSidebar.Controls.Add(btnReports);
            pnlSidebar.Controls.Add(btnTransactions);
            pnlSidebar.Controls.Add(btnSuppliers);
            pnlSidebar.Controls.Add(btnCategories);
            pnlSidebar.Controls.Add(btnProducts);
            pnlSidebar.Controls.Add(btnDashboard);
            pnlSidebar.Controls.Add(lblMenuTitle);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 125);
            pnlSidebar.Margin = new Padding(4, 5, 4, 5);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(300, 925);
            pnlSidebar.TabIndex = 1;
            // 
            // btnStockOut
            // 
            btnStockOut.BackColor = Color.White;
            btnStockOut.FlatStyle = FlatStyle.Flat;
            btnStockOut.Location = new Point(14, 517);
            btnStockOut.Margin = new Padding(4, 5, 4, 5);
            btnStockOut.Name = "btnStockOut";
            btnStockOut.Size = new Size(264, 70);
            btnStockOut.TabIndex = 8;
            btnStockOut.Text = "Stock Out";
            btnStockOut.UseVisualStyleBackColor = false;
            btnStockOut.Click += btnStockOut_Click;
            // 
            // btnStockIn
            // 
            btnStockIn.BackColor = Color.White;
            btnStockIn.FlatStyle = FlatStyle.Flat;
            btnStockIn.Location = new Point(14, 433);
            btnStockIn.Margin = new Padding(4, 5, 4, 5);
            btnStockIn.Name = "btnStockIn";
            btnStockIn.Size = new Size(264, 70);
            btnStockIn.TabIndex = 7;
            btnStockIn.Text = "Stock In";
            btnStockIn.UseVisualStyleBackColor = false;
            btnStockIn.Click += btnStockIn_Click;
            // 
            // btnReports
            // 
            btnReports.BackColor = Color.White;
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.Location = new Point(14, 683);
            btnReports.Margin = new Padding(4, 5, 4, 5);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(264, 70);
            btnReports.TabIndex = 6;
            btnReports.Text = "Reports";
            btnReports.UseVisualStyleBackColor = false;
            btnReports.Click += btnReports_Click;
            // 
            // btnTransactions
            // 
            btnTransactions.BackColor = Color.White;
            btnTransactions.FlatStyle = FlatStyle.Flat;
            btnTransactions.ForeColor = Color.FromArgb(31, 58, 95);
            btnTransactions.Location = new Point(14, 600);
            btnTransactions.Margin = new Padding(4, 5, 4, 5);
            btnTransactions.Name = "btnTransactions";
            btnTransactions.Size = new Size(264, 70);
            btnTransactions.TabIndex = 5;
            btnTransactions.Text = "Transactions";
            btnTransactions.UseVisualStyleBackColor = false;
            btnTransactions.Click += btnTransactions_Click;
            // 
            // btnSuppliers
            // 
            btnSuppliers.BackColor = Color.White;
            btnSuppliers.FlatStyle = FlatStyle.Flat;
            btnSuppliers.ForeColor = Color.FromArgb(31, 58, 95);
            btnSuppliers.Location = new Point(14, 350);
            btnSuppliers.Margin = new Padding(4, 5, 4, 5);
            btnSuppliers.Name = "btnSuppliers";
            btnSuppliers.Size = new Size(264, 70);
            btnSuppliers.TabIndex = 4;
            btnSuppliers.Text = "Suppliers";
            btnSuppliers.UseVisualStyleBackColor = false;
            btnSuppliers.Click += btnSuppliers_Click;
            // 
            // btnCategories
            // 
            btnCategories.BackColor = Color.White;
            btnCategories.FlatStyle = FlatStyle.Flat;
            btnCategories.ForeColor = Color.FromArgb(31, 58, 95);
            btnCategories.Location = new Point(14, 267);
            btnCategories.Margin = new Padding(4, 5, 4, 5);
            btnCategories.Name = "btnCategories";
            btnCategories.Size = new Size(264, 70);
            btnCategories.TabIndex = 3;
            btnCategories.Text = "Categories";
            btnCategories.UseVisualStyleBackColor = false;
            btnCategories.Click += btnCategories_Click;
            // 
            // btnProducts
            // 
            btnProducts.BackColor = Color.White;
            btnProducts.FlatStyle = FlatStyle.Flat;
            btnProducts.ForeColor = Color.FromArgb(31, 58, 95);
            btnProducts.Location = new Point(14, 183);
            btnProducts.Margin = new Padding(4, 5, 4, 5);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(264, 70);
            btnProducts.TabIndex = 2;
            btnProducts.Text = "Products";
            btnProducts.UseVisualStyleBackColor = false;
            btnProducts.Click += btnProducts_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(47, 93, 138);
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(14, 100);
            btnDashboard.Margin = new Padding(4, 5, 4, 5);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(264, 70);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // lblMenuTitle
            // 
            lblMenuTitle.AutoSize = true;
            lblMenuTitle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMenuTitle.ForeColor = Color.FromArgb(31, 58, 95);
            lblMenuTitle.Location = new Point(21, 33);
            lblMenuTitle.Margin = new Padding(4, 0, 4, 0);
            lblMenuTitle.Name = "lblMenuTitle";
            lblMenuTitle.Size = new Size(136, 28);
            lblMenuTitle.TabIndex = 0;
            lblMenuTitle.Text = "NAVIGATION";
            // 
            // pnlContent
            // 
            pnlContent.BackColor = Color.FromArgb(244, 246, 249);
            pnlContent.Controls.Add(pnlPageHost);
            pnlContent.Controls.Add(pnlLowStockSection);
            pnlContent.Controls.Add(pnlTransactionsCard);
            pnlContent.Controls.Add(pnlLowStockCard);
            pnlContent.Controls.Add(pnlCategoriesCard);
            pnlContent.Controls.Add(pnlProductsCard);
            pnlContent.Controls.Add(lblDashboardHeading);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(300, 125);
            pnlContent.Margin = new Padding(4, 5, 4, 5);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(1391, 925);
            pnlContent.TabIndex = 2;
            // 
            // pnlPageHost
            // 
            pnlPageHost.AllowDrop = true;
            pnlPageHost.AutoScroll = true;
            pnlPageHost.AutoSize = true;
            pnlPageHost.Dock = DockStyle.Fill;
            pnlPageHost.Location = new Point(0, 0);
            pnlPageHost.Margin = new Padding(0);
            pnlPageHost.Name = "pnlPageHost";
            pnlPageHost.Size = new Size(1391, 925);
            pnlPageHost.TabIndex = 7;
            pnlPageHost.Visible = false;
            // 
            // pnlLowStockSection
            // 
            pnlLowStockSection.BackColor = Color.White;
            pnlLowStockSection.BorderStyle = BorderStyle.FixedSingle;
            pnlLowStockSection.Controls.Add(lblLowStockStatus);
            pnlLowStockSection.Controls.Add(lvLowStockProducts);
            pnlLowStockSection.Controls.Add(lblLowStockSectionTitle);
            pnlLowStockSection.Location = new Point(29, 342);
            pnlLowStockSection.Margin = new Padding(4, 5, 4, 5);
            pnlLowStockSection.Name = "pnlLowStockSection";
            pnlLowStockSection.Size = new Size(1263, 532);
            pnlLowStockSection.TabIndex = 5;
            // 
            // lblLowStockStatus
            // 
            lblLowStockStatus.AutoSize = true;
            lblLowStockStatus.ForeColor = Color.FromArgb(107, 114, 128);
            lblLowStockStatus.Location = new Point(21, 467);
            lblLowStockStatus.Margin = new Padding(4, 0, 4, 0);
            lblLowStockStatus.Name = "lblLowStockStatus";
            lblLowStockStatus.Size = new Size(247, 25);
            lblLowStockStatus.TabIndex = 2;
            lblLowStockStatus.Text = "No low-stock products found";
            // 
            // lvLowStockProducts
            // 
            lvLowStockProducts.Columns.AddRange(new ColumnHeader[] { colProductCode, colProductName, colCurrentQuantity, colMinimumStock });
            lvLowStockProducts.GridLines = true;
            lvLowStockProducts.Items.AddRange(new ListViewItem[] { listViewItem1 });
            lvLowStockProducts.Location = new Point(21, 92);
            lvLowStockProducts.Margin = new Padding(4, 5, 4, 5);
            lvLowStockProducts.MultiSelect = false;
            lvLowStockProducts.Name = "lvLowStockProducts";
            lvLowStockProducts.Size = new Size(1213, 331);
            lvLowStockProducts.TabIndex = 1;
            lvLowStockProducts.UseCompatibleStateImageBehavior = false;
            lvLowStockProducts.View = View.Details;
            lvLowStockProducts.SelectedIndexChanged += lvLowStockProducts_SelectedIndexChanged;
            // 
            // colProductCode
            // 
            colProductCode.Text = "";
            colProductCode.Width = 120;
            // 
            // colProductName
            // 
            colProductName.Text = "Product Name";
            colProductName.Width = 250;
            // 
            // colCurrentQuantity
            // 
            colCurrentQuantity.Text = "Current Quantity";
            colCurrentQuantity.Width = 160;
            // 
            // colMinimumStock
            // 
            colMinimumStock.Text = "Minimum Stock";
            colMinimumStock.Width = 150;
            // 
            // lblLowStockSectionTitle
            // 
            lblLowStockSectionTitle.AutoSize = true;
            lblLowStockSectionTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLowStockSectionTitle.Location = new Point(29, 25);
            lblLowStockSectionTitle.Margin = new Padding(4, 0, 4, 0);
            lblLowStockSectionTitle.Name = "lblLowStockSectionTitle";
            lblLowStockSectionTitle.Size = new Size(285, 40);
            lblLowStockSectionTitle.TabIndex = 0;
            lblLowStockSectionTitle.Text = "Low Stock Products";
            // 
            // pnlTransactionsCard
            // 
            pnlTransactionsCard.BackColor = Color.White;
            pnlTransactionsCard.BorderStyle = BorderStyle.FixedSingle;
            pnlTransactionsCard.Controls.Add(lblTransactionsCount);
            pnlTransactionsCard.Controls.Add(lblTransactionsTitle);
            pnlTransactionsCard.Location = new Point(993, 108);
            pnlTransactionsCard.Margin = new Padding(4, 5, 4, 5);
            pnlTransactionsCard.Name = "pnlTransactionsCard";
            pnlTransactionsCard.Size = new Size(299, 199);
            pnlTransactionsCard.TabIndex = 4;
            // 
            // lblTransactionsCount
            // 
            lblTransactionsCount.AutoSize = true;
            lblTransactionsCount.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTransactionsCount.Location = new Point(21, 83);
            lblTransactionsCount.Margin = new Padding(4, 0, 4, 0);
            lblTransactionsCount.Name = "lblTransactionsCount";
            lblTransactionsCount.Size = new Size(50, 60);
            lblTransactionsCount.TabIndex = 1;
            lblTransactionsCount.Text = "0";
            // 
            // lblTransactionsTitle
            // 
            lblTransactionsTitle.AutoSize = true;
            lblTransactionsTitle.Font = new Font("Segoe UI", 10F);
            lblTransactionsTitle.ForeColor = Color.FromArgb(107, 114, 128);
            lblTransactionsTitle.Location = new Point(21, 25);
            lblTransactionsTitle.Margin = new Padding(4, 0, 4, 0);
            lblTransactionsTitle.Name = "lblTransactionsTitle";
            lblTransactionsTitle.Size = new Size(188, 28);
            lblTransactionsTitle.TabIndex = 0;
            lblTransactionsTitle.Text = "Today's Transactions";
            // 
            // pnlLowStockCard
            // 
            pnlLowStockCard.BackColor = Color.White;
            pnlLowStockCard.BorderStyle = BorderStyle.FixedSingle;
            pnlLowStockCard.Controls.Add(lblLowStockCount);
            pnlLowStockCard.Controls.Add(lblLowStockTitle);
            pnlLowStockCard.Location = new Point(671, 108);
            pnlLowStockCard.Margin = new Padding(4, 5, 4, 5);
            pnlLowStockCard.Name = "pnlLowStockCard";
            pnlLowStockCard.Size = new Size(299, 199);
            pnlLowStockCard.TabIndex = 3;
            // 
            // lblLowStockCount
            // 
            lblLowStockCount.AutoSize = true;
            lblLowStockCount.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLowStockCount.Location = new Point(21, 83);
            lblLowStockCount.Margin = new Padding(4, 0, 4, 0);
            lblLowStockCount.Name = "lblLowStockCount";
            lblLowStockCount.Size = new Size(50, 60);
            lblLowStockCount.TabIndex = 1;
            lblLowStockCount.Text = "0";
            // 
            // lblLowStockTitle
            // 
            lblLowStockTitle.AutoSize = true;
            lblLowStockTitle.Font = new Font("Segoe UI", 10F);
            lblLowStockTitle.ForeColor = Color.FromArgb(107, 114, 128);
            lblLowStockTitle.Location = new Point(21, 25);
            lblLowStockTitle.Margin = new Padding(4, 0, 4, 0);
            lblLowStockTitle.Name = "lblLowStockTitle";
            lblLowStockTitle.Size = new Size(152, 28);
            lblLowStockTitle.TabIndex = 0;
            lblLowStockTitle.Text = "Low Stock Items";
            // 
            // pnlCategoriesCard
            // 
            pnlCategoriesCard.BackColor = Color.White;
            pnlCategoriesCard.BorderStyle = BorderStyle.FixedSingle;
            pnlCategoriesCard.Controls.Add(lblCategoriesCount);
            pnlCategoriesCard.Controls.Add(lblCategoriesTitle);
            pnlCategoriesCard.Location = new Point(350, 108);
            pnlCategoriesCard.Margin = new Padding(4, 5, 4, 5);
            pnlCategoriesCard.Name = "pnlCategoriesCard";
            pnlCategoriesCard.Size = new Size(299, 199);
            pnlCategoriesCard.TabIndex = 2;
            // 
            // lblCategoriesCount
            // 
            lblCategoriesCount.AutoSize = true;
            lblCategoriesCount.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategoriesCount.Location = new Point(21, 83);
            lblCategoriesCount.Margin = new Padding(4, 0, 4, 0);
            lblCategoriesCount.Name = "lblCategoriesCount";
            lblCategoriesCount.Size = new Size(50, 60);
            lblCategoriesCount.TabIndex = 1;
            lblCategoriesCount.Text = "0";
            // 
            // lblCategoriesTitle
            // 
            lblCategoriesTitle.AutoSize = true;
            lblCategoriesTitle.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCategoriesTitle.ForeColor = Color.FromArgb(107, 114, 128);
            lblCategoriesTitle.Location = new Point(21, 25);
            lblCategoriesTitle.Margin = new Padding(4, 0, 4, 0);
            lblCategoriesTitle.Name = "lblCategoriesTitle";
            lblCategoriesTitle.Size = new Size(152, 28);
            lblCategoriesTitle.TabIndex = 0;
            lblCategoriesTitle.Text = "Total Categories";
            // 
            // pnlProductsCard
            // 
            pnlProductsCard.BackColor = Color.White;
            pnlProductsCard.BorderStyle = BorderStyle.FixedSingle;
            pnlProductsCard.Controls.Add(lblProductsCount);
            pnlProductsCard.Controls.Add(lblProductsTitle);
            pnlProductsCard.Location = new Point(29, 108);
            pnlProductsCard.Margin = new Padding(4, 5, 4, 5);
            pnlProductsCard.Name = "pnlProductsCard";
            pnlProductsCard.Size = new Size(299, 199);
            pnlProductsCard.TabIndex = 1;
            // 
            // lblProductsCount
            // 
            lblProductsCount.AutoSize = true;
            lblProductsCount.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductsCount.Location = new Point(21, 88);
            lblProductsCount.Margin = new Padding(4, 0, 4, 0);
            lblProductsCount.Name = "lblProductsCount";
            lblProductsCount.Size = new Size(50, 60);
            lblProductsCount.TabIndex = 1;
            lblProductsCount.Text = "0";
            // 
            // lblProductsTitle
            // 
            lblProductsTitle.AutoSize = true;
            lblProductsTitle.Font = new Font("Segoe UI", 10F);
            lblProductsTitle.ForeColor = Color.FromArgb(107, 114, 128);
            lblProductsTitle.Location = new Point(21, 25);
            lblProductsTitle.Margin = new Padding(4, 0, 4, 0);
            lblProductsTitle.Name = "lblProductsTitle";
            lblProductsTitle.Size = new Size(136, 28);
            lblProductsTitle.TabIndex = 0;
            lblProductsTitle.Text = "Total Products";
            // 
            // lblDashboardHeading
            // 
            lblDashboardHeading.AutoSize = true;
            lblDashboardHeading.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDashboardHeading.Location = new Point(29, 25);
            lblDashboardHeading.Margin = new Padding(4, 0, 4, 0);
            lblDashboardHeading.Name = "lblDashboardHeading";
            lblDashboardHeading.Size = new Size(372, 48);
            lblDashboardHeading.TabIndex = 0;
            lblDashboardHeading.Text = "Dashboard Overview";
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1691, 1050);
            Controls.Add(pnlContent);
            Controls.Add(pnlSidebar);
            Controls.Add(pnlHeader);
            ForeColor = Color.FromArgb(31, 58, 95);
            Margin = new Padding(4, 5, 4, 5);
            Name = "DashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventory Management System - Dashboard";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlSidebar.ResumeLayout(false);
            pnlSidebar.PerformLayout();
            pnlContent.ResumeLayout(false);
            pnlContent.PerformLayout();
            pnlLowStockSection.ResumeLayout(false);
            pnlLowStockSection.PerformLayout();
            pnlTransactionsCard.ResumeLayout(false);
            pnlTransactionsCard.PerformLayout();
            pnlLowStockCard.ResumeLayout(false);
            pnlLowStockCard.PerformLayout();
            pnlCategoriesCard.ResumeLayout(false);
            pnlCategoriesCard.PerformLayout();
            pnlProductsCard.ResumeLayout(false);
            pnlProductsCard.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblAppTitle;
        private Panel pnlSidebar;
        private Button btnDashboard;
        private Label lblMenuTitle;
        private Button btnProducts;
        private Button btnSuppliers;
        private Button btnCategories;
        private Button btnReports;
        private Button btnTransactions;
        private Button btnStockOut;
        private Button btnStockIn;
        private Panel pnlContent;
        private Label lblDashboardHeading;
        private Panel pnlProductsCard;
        private Label lblProductsCount;
        private Label lblProductsTitle;
        private Panel pnlLowStockCard;
        private Panel pnlCategoriesCard;
        private Label lblCategoriesTitle;
        private Label lblCategoriesCount;
        private Label lblLowStockTitle;
        private Label lblLowStockCount;
        private Panel pnlTransactionsCard;
        private Label lblTransactionsTitle;
        private Label lblTransactionsCount;
        private Panel pnlLowStockSection;
        private Label lblLowStockSectionTitle;
        private ListView lvLowStockProducts;
        private ColumnHeader colProductCode;
        private ColumnHeader colProductName;
        public ColumnHeader colCurrentQuantity;
        private ColumnHeader colMinimumStock;
        private Label lblLowStockStatus;
        private Panel pnlPageHost;
    }
}