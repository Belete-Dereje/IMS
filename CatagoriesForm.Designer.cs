namespace IMS
{
    partial class CatagoriesForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblCategoriesHeading = new Label();
            pnlCategoryEntry = new Panel();
            btnClearCategory = new Button();
            btnAddCategory = new Button();
            txtCategoryName = new TextBox();
            lblCategoryName = new Label();
            pnlCategoriesList = new Panel();
            btnDeleteCategory = new Button();
            btnEditCategory = new Button();
            lvCategories = new ListView();
            colCategoryName = new ColumnHeader();
            txtSearchCategories = new TextBox();
            lblCategoryListTitle = new Label();
            btnBackToDashboard = new Button();
            pnlCategoryEntry.SuspendLayout();
            pnlCategoriesList.SuspendLayout();
            SuspendLayout();
            // 
            // lblCategoriesHeading
            // 
            lblCategoriesHeading.AutoSize = true;
            lblCategoriesHeading.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategoriesHeading.ForeColor = Color.FromArgb(31, 58, 95);
            lblCategoriesHeading.Location = new Point(25, 20);
            lblCategoriesHeading.Name = "lblCategoriesHeading";
            lblCategoriesHeading.Size = new Size(286, 32);
            lblCategoriesHeading.TabIndex = 0;
            lblCategoriesHeading.Text = "Category Management";
            // 
            // pnlCategoryEntry
            // 
            pnlCategoryEntry.BackColor = Color.White;
            pnlCategoryEntry.BorderStyle = BorderStyle.FixedSingle;
            pnlCategoryEntry.Controls.Add(btnClearCategory);
            pnlCategoryEntry.Controls.Add(btnAddCategory);
            pnlCategoryEntry.Controls.Add(txtCategoryName);
            pnlCategoryEntry.Controls.Add(lblCategoryName);
            pnlCategoryEntry.Location = new Point(10, 70);
            pnlCategoryEntry.Name = "pnlCategoryEntry";
            pnlCategoryEntry.Size = new Size(934, 150);
            pnlCategoryEntry.TabIndex = 1;
            // 
            // btnClearCategory
            // 
            btnClearCategory.BackColor = Color.FromArgb(229, 234, 240);
            btnClearCategory.FlatStyle = FlatStyle.Flat;
            btnClearCategory.Font = new Font("Segoe UI", 10F);
            btnClearCategory.ForeColor = Color.FromArgb(31, 58, 95);
            btnClearCategory.Location = new Point(600, 16);
            btnClearCategory.Name = "btnClearCategory";
            btnClearCategory.Size = new Size(90, 35);
            btnClearCategory.TabIndex = 3;
            btnClearCategory.Text = "Clear";
            btnClearCategory.UseVisualStyleBackColor = false;
            btnClearCategory.Click += btnClearCategory_Click;
            // 
            // btnAddCategory
            // 
            btnAddCategory.BackColor = Color.FromArgb(47, 93, 138);
            btnAddCategory.FlatStyle = FlatStyle.Flat;
            btnAddCategory.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddCategory.ForeColor = Color.White;
            btnAddCategory.Location = new Point(430, 16);
            btnAddCategory.Name = "btnAddCategory";
            btnAddCategory.Size = new Size(150, 35);
            btnAddCategory.TabIndex = 2;
            btnAddCategory.Text = "Add Category";
            btnAddCategory.UseVisualStyleBackColor = false;
            btnAddCategory.Click += btnAddCategory_Click;
            // 
            // txtCategoryName
            // 
            txtCategoryName.Font = new Font("Segoe UI", 10F);
            txtCategoryName.Location = new Point(140, 20);
            txtCategoryName.MaxLength = 100;
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(260, 25);
            txtCategoryName.TabIndex = 1;
            // 
            // lblCategoryName
            // 
            lblCategoryName.AutoSize = true;
            lblCategoryName.Font = new Font("Segoe UI", 10F);
            lblCategoryName.ForeColor = Color.FromArgb(31, 41, 55);
            lblCategoryName.Location = new Point(20, 25);
            lblCategoryName.Name = "lblCategoryName";
            lblCategoryName.Size = new Size(98, 19);
            lblCategoryName.TabIndex = 0;
            lblCategoryName.Text = "Category Name";
            // 
            // pnlCategoriesList
            // 
            pnlCategoriesList.BackColor = Color.White;
            pnlCategoriesList.BorderStyle = BorderStyle.FixedSingle;
            pnlCategoriesList.Controls.Add(btnDeleteCategory);
            pnlCategoriesList.Controls.Add(btnEditCategory);
            pnlCategoriesList.Controls.Add(lvCategories);
            pnlCategoriesList.Controls.Add(txtSearchCategories);
            pnlCategoriesList.Controls.Add(lblCategoryListTitle);
            pnlCategoriesList.Location = new Point(10, 240);
            pnlCategoriesList.Name = "pnlCategoriesList";
            pnlCategoriesList.Size = new Size(934, 325);
            pnlCategoriesList.TabIndex = 2;
            // 
            // btnDeleteCategory
            // 
            btnDeleteCategory.BackColor = Color.FromArgb(47, 93, 138);
            btnDeleteCategory.FlatStyle = FlatStyle.Flat;
            btnDeleteCategory.Font = new Font("Segoe UI", 10F);
            btnDeleteCategory.ForeColor = Color.White;
            btnDeleteCategory.Location = new Point(148, 250);
            btnDeleteCategory.Name = "btnDeleteCategory";
            btnDeleteCategory.Size = new Size(130, 35);
            btnDeleteCategory.TabIndex = 4;
            btnDeleteCategory.Text = "Delete Selected";
            btnDeleteCategory.UseVisualStyleBackColor = false;
            btnDeleteCategory.Click += btnDeleteCategory_Click;
            // 
            // btnEditCategory
            // 
            btnEditCategory.BackColor = Color.FromArgb(47, 93, 138);
            btnEditCategory.FlatStyle = FlatStyle.Flat;
            btnEditCategory.Font = new Font("Segoe UI", 10F);
            btnEditCategory.ForeColor = Color.White;
            btnEditCategory.Location = new Point(14, 250);
            btnEditCategory.Name = "btnEditCategory";
            btnEditCategory.Size = new Size(120, 35);
            btnEditCategory.TabIndex = 3;
            btnEditCategory.Text = "Edit Selected";
            btnEditCategory.UseVisualStyleBackColor = false;
            btnEditCategory.Click += btnEditCategory_Click;
            // 
            // lvCategories
            // 
            lvCategories.Columns.AddRange(new ColumnHeader[] { colCategoryName });
            lvCategories.FullRowSelect = true;
            lvCategories.GridLines = true;
            lvCategories.Location = new Point(14, 55);
            lvCategories.MultiSelect = false;
            lvCategories.Name = "lvCategories";
            lvCategories.Size = new Size(900, 180);
            lvCategories.TabIndex = 2;
            lvCategories.UseCompatibleStateImageBehavior = false;
            lvCategories.View = View.Details;
            // 
            // colCategoryName
            // 
            colCategoryName.Text = "Category Name";
            colCategoryName.Width = 400;
            // 
            // txtSearchCategories
            // 
            txtSearchCategories.Font = new Font("Segoe UI", 10F);
            txtSearchCategories.Location = new Point(500, 15);
            txtSearchCategories.Name = "txtSearchCategories";
            txtSearchCategories.PlaceholderText = "Search categories...";
            txtSearchCategories.Size = new Size(400, 25);
            txtSearchCategories.TabIndex = 1;
            txtSearchCategories.TextChanged += txtSearchCategories_TextChanged;
            // 
            // lblCategoryListTitle
            // 
            lblCategoryListTitle.AutoSize = true;
            lblCategoryListTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategoryListTitle.ForeColor = Color.FromArgb(31, 58, 95);
            lblCategoryListTitle.Location = new Point(20, 15);
            lblCategoryListTitle.Name = "lblCategoryListTitle";
            lblCategoryListTitle.Size = new Size(117, 25);
            lblCategoryListTitle.TabIndex = 0;
            lblCategoryListTitle.Text = "Category List";
            // 
            // btnBackToDashboard
            // 
            btnBackToDashboard.BackColor = Color.FromArgb(229, 234, 240);
            btnBackToDashboard.FlatStyle = FlatStyle.Flat;
            btnBackToDashboard.ForeColor = Color.FromArgb(31, 58, 95);
            btnBackToDashboard.Location = new Point(721, 17);
            btnBackToDashboard.Name = "btnBackToDashboard";
            btnBackToDashboard.Size = new Size(150, 35);
            btnBackToDashboard.TabIndex = 3;
            btnBackToDashboard.Text = "Back to Dashboard";
            btnBackToDashboard.UseVisualStyleBackColor = false;
            btnBackToDashboard.Click += btnBackToDashboard_Click;
            // 
            // CatagoriesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 246, 249);
            ClientSize = new Size(958, 597);
            Controls.Add(btnBackToDashboard);
            Controls.Add(pnlCategoriesList);
            Controls.Add(pnlCategoryEntry);
            Controls.Add(lblCategoriesHeading);
            Name = "CatagoriesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Category Management";
            Load += CatagoriesForm_Load;
            pnlCategoryEntry.ResumeLayout(false);
            pnlCategoryEntry.PerformLayout();
            pnlCategoriesList.ResumeLayout(false);
            pnlCategoriesList.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCategoriesHeading;
        private Panel pnlCategoryEntry;
        private Label lblCategoryName;
        private TextBox txtCategoryName;
        private Button btnAddCategory;
        private Button btnClearCategory;
        private Panel pnlCategoriesList;
        private Label lblCategoryListTitle;
        private ListView lvCategories;
        private ColumnHeader colCategoryName;
        private TextBox txtSearchCategories;
        private Button btnEditCategory;
        private Button btnDeleteCategory;
        private Button btnBackToDashboard;
    }
}