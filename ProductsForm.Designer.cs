namespace IMS
{
    partial class ProductsForm
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
            lblProductsHeading = new Label();
            pnlProductEntry = new Panel();
            btnClear = new Button();
            btnAddProduct = new Button();
            numMinimumStock = new NumericUpDown();
            lblMinimumStock = new Label();
            numInitialQuantity = new NumericUpDown();
            lblInitialQuantity = new Label();
            numSellingPrice = new NumericUpDown();
            lblSellingPrice = new Label();
            numPurchaseCost = new NumericUpDown();
            lblPurchaseCost = new Label();
            cmbUnit = new ComboBox();
            lblUnit = new Label();
            cmbCategory = new ComboBox();
            lblCategory = new Label();
            txtProductName = new TextBox();
            lblProductName = new Label();
            txtProductCode = new TextBox();
            lblProductCode = new Label();
            pnlProductsList = new Panel();
            btnDeleteProduct = new Button();
            btnEditProduct = new Button();
            lvProducts = new ListView();
            colProductCode = new ColumnHeader();
            colProductName = new ColumnHeader();
            colCategory = new ColumnHeader();
            colQuantity = new ColumnHeader();
            colUnit = new ColumnHeader();
            colSellingPrice = new ColumnHeader();
            colStockStatus = new ColumnHeader();
            txtSearchProducts = new TextBox();
            lblProductListTitle = new Label();
            btnBackToDashboard = new Button();
            pnlProductEntry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numMinimumStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numInitialQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSellingPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPurchaseCost).BeginInit();
            pnlProductsList.SuspendLayout();
            SuspendLayout();
            // 
            // lblProductsHeading
            // 
            lblProductsHeading.AutoSize = true;
            lblProductsHeading.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductsHeading.ForeColor = Color.FromArgb(31, 58, 95);
            lblProductsHeading.Location = new Point(25, 20);
            lblProductsHeading.Name = "lblProductsHeading";
            lblProductsHeading.Size = new Size(263, 32);
            lblProductsHeading.TabIndex = 0;
            lblProductsHeading.Text = "Product Management";
            // 
            // pnlProductEntry
            // 
            pnlProductEntry.BackColor = Color.White;
            pnlProductEntry.BorderStyle = BorderStyle.FixedSingle;
            pnlProductEntry.Controls.Add(btnClear);
            pnlProductEntry.Controls.Add(btnAddProduct);
            pnlProductEntry.Controls.Add(numMinimumStock);
            pnlProductEntry.Controls.Add(lblMinimumStock);
            pnlProductEntry.Controls.Add(numInitialQuantity);
            pnlProductEntry.Controls.Add(lblInitialQuantity);
            pnlProductEntry.Controls.Add(numSellingPrice);
            pnlProductEntry.Controls.Add(lblSellingPrice);
            pnlProductEntry.Controls.Add(numPurchaseCost);
            pnlProductEntry.Controls.Add(lblPurchaseCost);
            pnlProductEntry.Controls.Add(cmbUnit);
            pnlProductEntry.Controls.Add(lblUnit);
            pnlProductEntry.Controls.Add(cmbCategory);
            pnlProductEntry.Controls.Add(lblCategory);
            pnlProductEntry.Controls.Add(txtProductName);
            pnlProductEntry.Controls.Add(lblProductName);
            pnlProductEntry.Controls.Add(txtProductCode);
            pnlProductEntry.Controls.Add(lblProductCode);
            pnlProductEntry.Location = new Point(25, 70);
            pnlProductEntry.Name = "pnlProductEntry";
            pnlProductEntry.Size = new Size(1030, 250);
            pnlProductEntry.TabIndex = 1;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(229, 234, 240);
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 10F);
            btnClear.ForeColor = Color.FromArgb(31, 58, 95);
            btnClear.Location = new Point(700, 205);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(90, 35);
            btnClear.TabIndex = 18;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnAddProduct
            // 
            btnAddProduct.BackColor = Color.FromArgb(47, 93, 138);
            btnAddProduct.FlatStyle = FlatStyle.Flat;
            btnAddProduct.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddProduct.ForeColor = Color.White;
            btnAddProduct.Location = new Point(800, 205);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(160, 35);
            btnAddProduct.TabIndex = 17;
            btnAddProduct.Text = "Add Product";
            btnAddProduct.UseVisualStyleBackColor = false;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // numMinimumStock
            // 
            numMinimumStock.Font = new Font("Segoe UI", 10F);
            numMinimumStock.Location = new Point(510, 166);
            numMinimumStock.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numMinimumStock.Name = "numMinimumStock";
            numMinimumStock.Size = new Size(180, 25);
            numMinimumStock.TabIndex = 16;
            // 
            // lblMinimumStock
            // 
            lblMinimumStock.AutoSize = true;
            lblMinimumStock.Font = new Font("Segoe UI", 10F);
            lblMinimumStock.ForeColor = Color.FromArgb(31, 41, 55);
            lblMinimumStock.Location = new Point(400, 170);
            lblMinimumStock.Name = "lblMinimumStock";
            lblMinimumStock.Size = new Size(105, 19);
            lblMinimumStock.TabIndex = 15;
            lblMinimumStock.Text = "Minimum Stock";
            // 
            // numInitialQuantity
            // 
            numInitialQuantity.Font = new Font("Segoe UI", 10F);
            numInitialQuantity.Location = new Point(140, 166);
            numInitialQuantity.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numInitialQuantity.Name = "numInitialQuantity";
            numInitialQuantity.Size = new Size(180, 25);
            numInitialQuantity.TabIndex = 14;
            // 
            // lblInitialQuantity
            // 
            lblInitialQuantity.AutoSize = true;
            lblInitialQuantity.Font = new Font("Segoe UI", 10F);
            lblInitialQuantity.ForeColor = Color.FromArgb(31, 41, 55);
            lblInitialQuantity.Location = new Point(20, 170);
            lblInitialQuantity.Name = "lblInitialQuantity";
            lblInitialQuantity.Size = new Size(100, 19);
            lblInitialQuantity.TabIndex = 13;
            lblInitialQuantity.Text = "Initial Quantity";
            // 
            // numSellingPrice
            // 
            numSellingPrice.DecimalPlaces = 2;
            numSellingPrice.Font = new Font("Segoe UI", 10F);
            numSellingPrice.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            numSellingPrice.Location = new Point(510, 116);
            numSellingPrice.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numSellingPrice.Name = "numSellingPrice";
            numSellingPrice.Size = new Size(180, 25);
            numSellingPrice.TabIndex = 12;
            // 
            // lblSellingPrice
            // 
            lblSellingPrice.AutoSize = true;
            lblSellingPrice.Font = new Font("Segoe UI", 10F);
            lblSellingPrice.ForeColor = Color.FromArgb(31, 41, 55);
            lblSellingPrice.Location = new Point(400, 120);
            lblSellingPrice.Name = "lblSellingPrice";
            lblSellingPrice.Size = new Size(81, 19);
            lblSellingPrice.TabIndex = 11;
            lblSellingPrice.Text = "Selling Price";
            // 
            // numPurchaseCost
            // 
            numPurchaseCost.DecimalPlaces = 2;
            numPurchaseCost.Font = new Font("Segoe UI", 10F);
            numPurchaseCost.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            numPurchaseCost.Location = new Point(140, 116);
            numPurchaseCost.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numPurchaseCost.Name = "numPurchaseCost";
            numPurchaseCost.Size = new Size(180, 25);
            numPurchaseCost.TabIndex = 10;
            numPurchaseCost.ValueChanged += numPurchaseCost_ValueChanged;
            // 
            // lblPurchaseCost
            // 
            lblPurchaseCost.AutoSize = true;
            lblPurchaseCost.Font = new Font("Segoe UI", 10F);
            lblPurchaseCost.ForeColor = Color.FromArgb(31, 41, 55);
            lblPurchaseCost.Location = new Point(20, 120);
            lblPurchaseCost.Name = "lblPurchaseCost";
            lblPurchaseCost.Size = new Size(96, 19);
            lblPurchaseCost.TabIndex = 9;
            lblPurchaseCost.Text = "Purchase Cost";
            // 
            // cmbUnit
            // 
            cmbUnit.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUnit.Font = new Font("Segoe UI", 10F);
            cmbUnit.FormattingEnabled = true;
            cmbUnit.Items.AddRange(new object[] { "Piece", "Box", "Kg", "Litre", "Pack" });
            cmbUnit.Location = new Point(450, 66);
            cmbUnit.Name = "cmbUnit";
            cmbUnit.Size = new Size(180, 25);
            cmbUnit.TabIndex = 7;
            // 
            // lblUnit
            // 
            lblUnit.AutoSize = true;
            lblUnit.Font = new Font("Segoe UI", 10F);
            lblUnit.ForeColor = Color.FromArgb(31, 41, 55);
            lblUnit.Location = new Point(400, 70);
            lblUnit.Name = "lblUnit";
            lblUnit.Size = new Size(35, 19);
            lblUnit.TabIndex = 6;
            lblUnit.Text = "Unit";
            // 
            // cmbCategory
            // 
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.Font = new Font("Segoe UI", 10F);
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Items.AddRange(new object[] { "Stationery", "Electronics", "Food and Beverages", "Cleaning Supplies", "Other" });
            cmbCategory.Location = new Point(140, 66);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(220, 25);
            cmbCategory.TabIndex = 5;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI", 10F);
            lblCategory.ForeColor = Color.FromArgb(31, 41, 55);
            lblCategory.Location = new Point(20, 70);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(65, 19);
            lblCategory.TabIndex = 4;
            lblCategory.Text = "Category";
            // 
            // txtProductName
            // 
            txtProductName.Font = new Font("Segoe UI", 10F);
            txtProductName.Location = new Point(510, 16);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(220, 25);
            txtProductName.TabIndex = 3;
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Font = new Font("Segoe UI", 10F);
            lblProductName.ForeColor = Color.FromArgb(31, 41, 55);
            lblProductName.Location = new Point(400, 20);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(97, 19);
            lblProductName.TabIndex = 2;
            lblProductName.Text = "Product Name";
            // 
            // txtProductCode
            // 
            txtProductCode.Font = new Font("Segoe UI", 10F);
            txtProductCode.Location = new Point(140, 16);
            txtProductCode.Name = "txtProductCode";
            txtProductCode.Size = new Size(220, 25);
            txtProductCode.TabIndex = 1;
            // 
            // lblProductCode
            // 
            lblProductCode.AutoSize = true;
            lblProductCode.Font = new Font("Segoe UI", 10F);
            lblProductCode.ForeColor = Color.FromArgb(31, 41, 55);
            lblProductCode.Location = new Point(20, 20);
            lblProductCode.Name = "lblProductCode";
            lblProductCode.Size = new Size(93, 19);
            lblProductCode.TabIndex = 0;
            lblProductCode.Text = "Product Code";
            // 
            // pnlProductsList
            // 
            pnlProductsList.BackColor = Color.White;
            pnlProductsList.BorderStyle = BorderStyle.FixedSingle;
            pnlProductsList.Controls.Add(btnDeleteProduct);
            pnlProductsList.Controls.Add(btnEditProduct);
            pnlProductsList.Controls.Add(lvProducts);
            pnlProductsList.Controls.Add(txtSearchProducts);
            pnlProductsList.Controls.Add(lblProductListTitle);
            pnlProductsList.Location = new Point(25, 340);
            pnlProductsList.Name = "pnlProductsList";
            pnlProductsList.Size = new Size(1030, 300);
            pnlProductsList.TabIndex = 2;
            // 
            // btnDeleteProduct
            // 
            btnDeleteProduct.BackColor = Color.FromArgb(198, 40, 40);
            btnDeleteProduct.FlatStyle = FlatStyle.Flat;
            btnDeleteProduct.Font = new Font("Segoe UI", 10F);
            btnDeleteProduct.ForeColor = Color.White;
            btnDeleteProduct.Location = new Point(155, 245);
            btnDeleteProduct.Name = "btnDeleteProduct";
            btnDeleteProduct.Size = new Size(130, 35);
            btnDeleteProduct.TabIndex = 4;
            btnDeleteProduct.Text = "Delete Selected";
            btnDeleteProduct.UseVisualStyleBackColor = false;
            btnDeleteProduct.Click += btnDeleteProduct_Click;
            // 
            // btnEditProduct
            // 
            btnEditProduct.BackColor = Color.FromArgb(47, 93, 138);
            btnEditProduct.FlatStyle = FlatStyle.Flat;
            btnEditProduct.Font = new Font("Segoe UI", 10F);
            btnEditProduct.ForeColor = Color.White;
            btnEditProduct.Location = new Point(20, 245);
            btnEditProduct.Name = "btnEditProduct";
            btnEditProduct.Size = new Size(120, 35);
            btnEditProduct.TabIndex = 3;
            btnEditProduct.Text = "Edit Selected";
            btnEditProduct.UseVisualStyleBackColor = false;
            btnEditProduct.Click += btnEditProduct_Click;
            // 
            // lvProducts
            // 
            lvProducts.Columns.AddRange(new ColumnHeader[] { colProductCode, colProductName, colCategory, colQuantity, colUnit, colSellingPrice, colStockStatus });
            lvProducts.FullRowSelect = true;
            lvProducts.GridLines = true;
            lvProducts.Location = new Point(20, 90);
            lvProducts.MultiSelect = false;
            lvProducts.Name = "lvProducts";
            lvProducts.Size = new Size(980, 140);
            lvProducts.TabIndex = 2;
            lvProducts.UseCompatibleStateImageBehavior = false;
            lvProducts.View = View.Details;
            // 
            // colProductCode
            // 
            colProductCode.Text = "Product Code";
            colProductCode.Width = 110;
            // 
            // colProductName
            // 
            colProductName.Text = "Product Name";
            colProductName.Width = 160;
            // 
            // colCategory
            // 
            colCategory.Text = "Category";
            colCategory.Width = 120;
            // 
            // colQuantity
            // 
            colQuantity.Text = "Quantity";
            colQuantity.Width = 85;
            // 
            // colUnit
            // 
            colUnit.Text = "Unit";
            colUnit.Width = 70;
            // 
            // colSellingPrice
            // 
            colSellingPrice.Text = "Selling Price";
            colSellingPrice.Width = 110;
            // 
            // colStockStatus
            // 
            colStockStatus.Text = "Stock Status";
            colStockStatus.Width = 110;
            // 
            // txtSearchProducts
            // 
            txtSearchProducts.Font = new Font("Segoe UI", 10F);
            txtSearchProducts.Location = new Point(20, 50);
            txtSearchProducts.Name = "txtSearchProducts";
            txtSearchProducts.PlaceholderText = "Search by product code or name...";
            txtSearchProducts.Size = new Size(350, 25);
            txtSearchProducts.TabIndex = 1;
            txtSearchProducts.TextChanged += txtSearchProducts_TextChanged;
            // 
            // lblProductListTitle
            // 
            lblProductListTitle.AutoSize = true;
            lblProductListTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductListTitle.ForeColor = Color.FromArgb(31, 58, 95);
            lblProductListTitle.Location = new Point(20, 15);
            lblProductListTitle.Name = "lblProductListTitle";
            lblProductListTitle.Size = new Size(119, 25);
            lblProductListTitle.TabIndex = 0;
            lblProductListTitle.Text = "Product List";
            // 
            // btnBackToDashboard
            // 
            btnBackToDashboard.BackColor = Color.FromArgb(229, 234, 240);
            btnBackToDashboard.FlatStyle = FlatStyle.Flat;
            btnBackToDashboard.ForeColor = Color.FromArgb(31, 58, 95);
            btnBackToDashboard.Location = new Point(900, 20);
            btnBackToDashboard.Name = "btnBackToDashboard";
            btnBackToDashboard.Size = new Size(150, 35);
            btnBackToDashboard.TabIndex = 3;
            btnBackToDashboard.Text = "Back to Dashboard";
            btnBackToDashboard.UseVisualStyleBackColor = false;
            btnBackToDashboard.Click += btnBackToDashboard_Click;
            // 
            // ProductsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 246, 249);
            ClientSize = new Size(1084, 661);
            Controls.Add(btnBackToDashboard);
            Controls.Add(pnlProductsList);
            Controls.Add(pnlProductEntry);
            Controls.Add(lblProductsHeading);
            Name = "ProductsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Product Management";
            pnlProductEntry.ResumeLayout(false);
            pnlProductEntry.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numMinimumStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)numInitialQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSellingPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPurchaseCost).EndInit();
            pnlProductsList.ResumeLayout(false);
            pnlProductsList.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblProductsHeading;
        private Panel pnlProductEntry;
        private Label lblProductCode;
        private TextBox txtProductCode;
        private Label lblProductName;
        private TextBox txtProductName;
        private Label lblCategory;
        private Label lblUnit;
        private ComboBox cmbCategory;
        private ComboBox cmbUnit;
        private Label lblPurchaseCost;
        private NumericUpDown numPurchaseCost;
        private Label lblSellingPrice;
        private NumericUpDown numSellingPrice;
        private Label lblInitialQuantity;
        private NumericUpDown numInitialQuantity;
        private Label lblMinimumStock;
        private NumericUpDown numMinimumStock;
        private Button btnAddProduct;
        private Button btnClear;
        private Panel pnlProductsList;
        private TextBox txtSearchProducts;
        private Label lblProductListTitle;
        private ListView lvProducts;
        private ColumnHeader colProductCode;
        private ColumnHeader colProductName;
        private ColumnHeader colCategory;
        private ColumnHeader colQuantity;
        private ColumnHeader colUnit;
        private ColumnHeader colSellingPrice;
        private ColumnHeader colStockStatus;
        private Button btnEditProduct;
        private Button btnDeleteProduct;
        private Button btnBackToDashboard;
    }
}