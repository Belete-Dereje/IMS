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
            lblMenuTitle = new Label();
            btnDashboard = new Button();
            btnProducts = new Button();
            btnCategories = new Button();
            btnSuppliers = new Button();
            btnTransactions = new Button();
            btnReports = new Button();
            btnStockIn = new Button();
            btnStockOut = new Button();
            pnlContent = new Panel();
            lblDashboardHeading = new Label();
            pnlProductsCard = new Panel();
            lblProductsTitle = new Label();
            lblProductsCount = new Label();
            pnlCategoriesCard = new Panel();
            pnlLowStockCard = new Panel();
            lblCategoriesTitle = new Label();
            lblCategoriesCount = new Label();
            lblLowStockTitle = new Label();
            lblLowStockCount = new Label();
            pnlTransactionsCard = new Panel();
            lblTransactionsTitle = new Label();
            lblTransactionsCount = new Label();
            pnlLowStockSection = new Panel();
            lblLowStockSectionTitle = new Label();
            lvLowStockProducts = new ListView();
            colProductCode = new ColumnHeader();
            colProductName = new ColumnHeader();
            colCurrentQuantity = new ColumnHeader();
            colMinimumStock = new ColumnHeader();
            lblLowStockStatus = new Label();
            pnlHeader.SuspendLayout();
            pnlSidebar.SuspendLayout();
            pnlContent.SuspendLayout();
            pnlProductsCard.SuspendLayout();
            pnlCategoriesCard.SuspendLayout();
            pnlLowStockCard.SuspendLayout();
            pnlTransactionsCard.SuspendLayout();
            pnlLowStockSection.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(31, 58, 95);
            pnlHeader.Controls.Add(lblAppTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1184, 75);
            pnlHeader.TabIndex = 0;
            // 
            // lblAppTitle
            // 
            lblAppTitle.AutoSize = true;
            lblAppTitle.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAppTitle.ForeColor = Color.White;
            lblAppTitle.Location = new Point(57, 22);
            lblAppTitle.Name = "lblAppTitle";
            lblAppTitle.Size = new Size(378, 30);
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
            pnlSidebar.Location = new Point(0, 75);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(210, 636);
            pnlSidebar.TabIndex = 1;
            // 
            // lblMenuTitle
            // 
            lblMenuTitle.AutoSize = true;
            lblMenuTitle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMenuTitle.ForeColor = Color.FromArgb(31, 58, 95);
            lblMenuTitle.Location = new Point(15, 20);
            lblMenuTitle.Name = "lblMenuTitle";
            lblMenuTitle.Size = new Size(88, 17);
            lblMenuTitle.TabIndex = 0;
            lblMenuTitle.Text = "NAVIGATION";
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(47, 93, 138);
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(10, 60);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(185, 42);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            // 
            // btnProducts
            // 
            btnProducts.BackColor = Color.White;
            btnProducts.FlatStyle = FlatStyle.Flat;
            btnProducts.ForeColor = Color.FromArgb(31, 58, 95);
            btnProducts.Location = new Point(10, 110);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(185, 42);
            btnProducts.TabIndex = 2;
            btnProducts.Text = "Products";
            btnProducts.UseVisualStyleBackColor = false;
            // 
            // btnCategories
            // 
            btnCategories.BackColor = Color.White;
            btnCategories.FlatStyle = FlatStyle.Flat;
            btnCategories.ForeColor = Color.FromArgb(31, 58, 95);
            btnCategories.Location = new Point(10, 160);
            btnCategories.Name = "btnCategories";
            btnCategories.Size = new Size(185, 42);
            btnCategories.TabIndex = 3;
            btnCategories.Text = "Categories";
            btnCategories.UseVisualStyleBackColor = false;
            // 
            // btnSuppliers
            // 
            btnSuppliers.BackColor = Color.White;
            btnSuppliers.FlatStyle = FlatStyle.Flat;
            btnSuppliers.ForeColor = Color.FromArgb(31, 58, 95);
            btnSuppliers.Location = new Point(10, 210);
            btnSuppliers.Name = "btnSuppliers";
            btnSuppliers.Size = new Size(185, 42);
            btnSuppliers.TabIndex = 4;
            btnSuppliers.Text = "Suppliers";
            btnSuppliers.UseVisualStyleBackColor = false;
            // 
            // btnTransactions
            // 
            btnTransactions.BackColor = Color.White;
            btnTransactions.FlatStyle = FlatStyle.Flat;
            btnTransactions.ForeColor = Color.FromArgb(31, 58, 95);
            btnTransactions.Location = new Point(10, 360);
            btnTransactions.Name = "btnTransactions";
            btnTransactions.Size = new Size(185, 42);
            btnTransactions.TabIndex = 5;
            btnTransactions.Text = "Transactions";
            btnTransactions.UseVisualStyleBackColor = false;
            // 
            // btnReports
            // 
            btnReports.BackColor = Color.White;
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.Location = new Point(10, 410);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(185, 42);
            btnReports.TabIndex = 6;
            btnReports.Text = "Reports";
            btnReports.UseVisualStyleBackColor = false;
            // 
            // btnStockIn
            // 
            btnStockIn.BackColor = Color.White;
            btnStockIn.FlatStyle = FlatStyle.Flat;
            btnStockIn.Location = new Point(10, 260);
            btnStockIn.Name = "btnStockIn";
            btnStockIn.Size = new Size(185, 42);
            btnStockIn.TabIndex = 7;
            btnStockIn.Text = "Stock In";
            btnStockIn.UseVisualStyleBackColor = false;
            // 
            // btnStockOut
            // 
            btnStockOut.BackColor = Color.White;
            btnStockOut.FlatStyle = FlatStyle.Flat;
            btnStockOut.Location = new Point(10, 310);
            btnStockOut.Name = "btnStockOut";
            btnStockOut.Size = new Size(185, 42);
            btnStockOut.TabIndex = 8;
            btnStockOut.Text = "Stock Out";
            btnStockOut.UseVisualStyleBackColor = false;
            // 
            // pnlContent
            // 
            pnlContent.BackColor = Color.FromArgb(244, 246, 249);
            pnlContent.Controls.Add(pnlLowStockSection);
            pnlContent.Controls.Add(pnlTransactionsCard);
            pnlContent.Controls.Add(pnlLowStockCard);
            pnlContent.Controls.Add(pnlCategoriesCard);
            pnlContent.Controls.Add(pnlProductsCard);
            pnlContent.Controls.Add(lblDashboardHeading);
            pnlContent.Location = new Point(225, 95);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(940, 590);
            pnlContent.TabIndex = 2;
            // 
            // lblDashboardHeading
            // 
            lblDashboardHeading.AutoSize = true;
            lblDashboardHeading.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDashboardHeading.Location = new Point(20, 15);
            lblDashboardHeading.Name = "lblDashboardHeading";
            lblDashboardHeading.Size = new Size(252, 32);
            lblDashboardHeading.TabIndex = 0;
            lblDashboardHeading.Text = "Dashboard Overview";
            // 
            // pnlProductsCard
            // 
            pnlProductsCard.BackColor = Color.White;
            pnlProductsCard.BorderStyle = BorderStyle.FixedSingle;
            pnlProductsCard.Controls.Add(lblProductsCount);
            pnlProductsCard.Controls.Add(lblProductsTitle);
            pnlProductsCard.Location = new Point(20, 65);
            pnlProductsCard.Name = "pnlProductsCard";
            pnlProductsCard.Size = new Size(210, 120);
            pnlProductsCard.TabIndex = 1;
            // 
            // lblProductsTitle
            // 
            lblProductsTitle.AutoSize = true;
            lblProductsTitle.Font = new Font("Segoe UI", 10F);
            lblProductsTitle.ForeColor = Color.FromArgb(107, 114, 128);
            lblProductsTitle.Location = new Point(15, 15);
            lblProductsTitle.Name = "lblProductsTitle";
            lblProductsTitle.Size = new Size(96, 19);
            lblProductsTitle.TabIndex = 0;
            lblProductsTitle.Text = "Total Products";
            // 
            // lblProductsCount
            // 
            lblProductsCount.AutoSize = true;
            lblProductsCount.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductsCount.Location = new Point(15, 53);
            lblProductsCount.Name = "lblProductsCount";
            lblProductsCount.Size = new Size(34, 40);
            lblProductsCount.TabIndex = 1;
            lblProductsCount.Text = "0";
            // 
            // pnlCategoriesCard
            // 
            pnlCategoriesCard.BackColor = Color.White;
            pnlCategoriesCard.BorderStyle = BorderStyle.FixedSingle;
            pnlCategoriesCard.Controls.Add(lblCategoriesCount);
            pnlCategoriesCard.Controls.Add(lblCategoriesTitle);
            pnlCategoriesCard.Location = new Point(245, 65);
            pnlCategoriesCard.Name = "pnlCategoriesCard";
            pnlCategoriesCard.Size = new Size(210, 120);
            pnlCategoriesCard.TabIndex = 2;
            // 
            // pnlLowStockCard
            // 
            pnlLowStockCard.BackColor = Color.White;
            pnlLowStockCard.BorderStyle = BorderStyle.FixedSingle;
            pnlLowStockCard.Controls.Add(lblLowStockCount);
            pnlLowStockCard.Controls.Add(lblLowStockTitle);
            pnlLowStockCard.Location = new Point(470, 65);
            pnlLowStockCard.Name = "pnlLowStockCard";
            pnlLowStockCard.Size = new Size(210, 120);
            pnlLowStockCard.TabIndex = 3;
            // 
            // lblCategoriesTitle
            // 
            lblCategoriesTitle.AutoSize = true;
            lblCategoriesTitle.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCategoriesTitle.ForeColor = Color.FromArgb(107, 114, 128);
            lblCategoriesTitle.Location = new Point(15, 15);
            lblCategoriesTitle.Name = "lblCategoriesTitle";
            lblCategoriesTitle.Size = new Size(103, 17);
            lblCategoriesTitle.TabIndex = 0;
            lblCategoriesTitle.Text = "Total Categories";
            // 
            // lblCategoriesCount
            // 
            lblCategoriesCount.AutoSize = true;
            lblCategoriesCount.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategoriesCount.Location = new Point(15, 50);
            lblCategoriesCount.Name = "lblCategoriesCount";
            lblCategoriesCount.Size = new Size(34, 40);
            lblCategoriesCount.TabIndex = 1;
            lblCategoriesCount.Text = "0";
            // 
            // lblLowStockTitle
            // 
            lblLowStockTitle.AutoSize = true;
            lblLowStockTitle.Font = new Font("Segoe UI", 10F);
            lblLowStockTitle.ForeColor = Color.FromArgb(107, 114, 128);
            lblLowStockTitle.Location = new Point(15, 15);
            lblLowStockTitle.Name = "lblLowStockTitle";
            lblLowStockTitle.Size = new Size(109, 19);
            lblLowStockTitle.TabIndex = 0;
            lblLowStockTitle.Text = "Low Stock Items";
            // 
            // lblLowStockCount
            // 
            lblLowStockCount.AutoSize = true;
            lblLowStockCount.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLowStockCount.Location = new Point(15, 50);
            lblLowStockCount.Name = "lblLowStockCount";
            lblLowStockCount.Size = new Size(34, 40);
            lblLowStockCount.TabIndex = 1;
            lblLowStockCount.Text = "0";
            // 
            // pnlTransactionsCard
            // 
            pnlTransactionsCard.BackColor = Color.White;
            pnlTransactionsCard.BorderStyle = BorderStyle.FixedSingle;
            pnlTransactionsCard.Controls.Add(lblTransactionsCount);
            pnlTransactionsCard.Controls.Add(lblTransactionsTitle);
            pnlTransactionsCard.Location = new Point(695, 65);
            pnlTransactionsCard.Name = "pnlTransactionsCard";
            pnlTransactionsCard.Size = new Size(210, 120);
            pnlTransactionsCard.TabIndex = 4;
            // 
            // lblTransactionsTitle
            // 
            lblTransactionsTitle.AutoSize = true;
            lblTransactionsTitle.Font = new Font("Segoe UI", 10F);
            lblTransactionsTitle.ForeColor = Color.FromArgb(107, 114, 128);
            lblTransactionsTitle.Location = new Point(15, 15);
            lblTransactionsTitle.Name = "lblTransactionsTitle";
            lblTransactionsTitle.Size = new Size(133, 19);
            lblTransactionsTitle.TabIndex = 0;
            lblTransactionsTitle.Text = "Today's Transactions";
            // 
            // lblTransactionsCount
            // 
            lblTransactionsCount.AutoSize = true;
            lblTransactionsCount.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTransactionsCount.Location = new Point(15, 50);
            lblTransactionsCount.Name = "lblTransactionsCount";
            lblTransactionsCount.Size = new Size(34, 40);
            lblTransactionsCount.TabIndex = 1;
            lblTransactionsCount.Text = "0";
            // 
            // pnlLowStockSection
            // 
            pnlLowStockSection.BackColor = Color.White;
            pnlLowStockSection.BorderStyle = BorderStyle.FixedSingle;
            pnlLowStockSection.Controls.Add(lblLowStockStatus);
            pnlLowStockSection.Controls.Add(lvLowStockProducts);
            pnlLowStockSection.Controls.Add(lblLowStockSectionTitle);
            pnlLowStockSection.Location = new Point(20, 205);
            pnlLowStockSection.Name = "pnlLowStockSection";
            pnlLowStockSection.Size = new Size(885, 320);
            pnlLowStockSection.TabIndex = 5;
            // 
            // lblLowStockSectionTitle
            // 
            lblLowStockSectionTitle.AutoSize = true;
            lblLowStockSectionTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLowStockSectionTitle.Location = new Point(20, 15);
            lblLowStockSectionTitle.Name = "lblLowStockSectionTitle";
            lblLowStockSectionTitle.Size = new Size(189, 25);
            lblLowStockSectionTitle.TabIndex = 0;
            lblLowStockSectionTitle.Text = "Low Stock Products";
            // 
            // lvLowStockProducts
            // 
            lvLowStockProducts.Columns.AddRange(new ColumnHeader[] { colProductCode, colProductName, colCurrentQuantity, colMinimumStock });
            lvLowStockProducts.GridLines = true;
            lvLowStockProducts.Items.AddRange(new ListViewItem[] { listViewItem1 });
            lvLowStockProducts.Location = new Point(15, 55);
            lvLowStockProducts.MultiSelect = false;
            lvLowStockProducts.Name = "lvLowStockProducts";
            lvLowStockProducts.Size = new Size(850, 200);
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
            // lblLowStockStatus
            // 
            lblLowStockStatus.AutoSize = true;
            lblLowStockStatus.ForeColor = Color.FromArgb(107, 114, 128);
            lblLowStockStatus.Location = new Point(15, 280);
            lblLowStockStatus.Name = "lblLowStockStatus";
            lblLowStockStatus.Size = new Size(163, 15);
            lblLowStockStatus.TabIndex = 2;
            lblLowStockStatus.Text = "No low-stock products found";
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1184, 711);
            Controls.Add(pnlContent);
            Controls.Add(pnlSidebar);
            Controls.Add(pnlHeader);
            ForeColor = Color.FromArgb(31, 58, 95);
            Name = "DashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventory Management System - Dashboard";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlSidebar.ResumeLayout(false);
            pnlSidebar.PerformLayout();
            pnlContent.ResumeLayout(false);
            pnlContent.PerformLayout();
            pnlProductsCard.ResumeLayout(false);
            pnlProductsCard.PerformLayout();
            pnlCategoriesCard.ResumeLayout(false);
            pnlCategoriesCard.PerformLayout();
            pnlLowStockCard.ResumeLayout(false);
            pnlLowStockCard.PerformLayout();
            pnlTransactionsCard.ResumeLayout(false);
            pnlTransactionsCard.PerformLayout();
            pnlLowStockSection.ResumeLayout(false);
            pnlLowStockSection.PerformLayout();
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
    }
}