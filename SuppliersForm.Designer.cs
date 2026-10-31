namespace IMS
{
    partial class SuppliersForm
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
            lblSuppliersHeading = new Label();
            pnlSupplierEntry = new Panel();
            btnClearSupplier = new Button();
            btnAddSupplier = new Button();
            txtSupplierAddress = new TextBox();
            lblSupplierAddress = new Label();
            txtSupplierEmail = new TextBox();
            lblSupplierEmail = new Label();
            txtSupplierPhone = new TextBox();
            lblSupplierPhone = new Label();
            txtSupplierName = new TextBox();
            lblSupplierName = new Label();
            txtSupplierCode = new TextBox();
            lblSupplierCode = new Label();
            pnlSupplierList = new Panel();
            btnDeleteSupplier = new Button();
            btnEditSupplier = new Button();
            lvSuppliers = new ListView();
            colSupplierCode = new ColumnHeader();
            colSupplierName = new ColumnHeader();
            colSupplierPhone = new ColumnHeader();
            colSupplierEmail = new ColumnHeader();
            colSupplierAddress = new ColumnHeader();
            txtSearchSuppliers = new TextBox();
            lblSupplierListTitle = new Label();
            pnlSupplierEntry.SuspendLayout();
            pnlSupplierList.SuspendLayout();
            SuspendLayout();
            // 
            // lblSuppliersHeading
            // 
            lblSuppliersHeading.AutoSize = true;
            lblSuppliersHeading.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSuppliersHeading.ForeColor = Color.FromArgb(31, 58, 95);
            lblSuppliersHeading.Location = new Point(25, 20);
            lblSuppliersHeading.Name = "lblSuppliersHeading";
            lblSuppliersHeading.Size = new Size(267, 32);
            lblSuppliersHeading.TabIndex = 0;
            lblSuppliersHeading.Text = "Supplier Management";
            // 
            // pnlSupplierEntry
            // 
            pnlSupplierEntry.BackColor = Color.White;
            pnlSupplierEntry.BorderStyle = BorderStyle.FixedSingle;
            pnlSupplierEntry.Controls.Add(btnClearSupplier);
            pnlSupplierEntry.Controls.Add(btnAddSupplier);
            pnlSupplierEntry.Controls.Add(txtSupplierAddress);
            pnlSupplierEntry.Controls.Add(lblSupplierAddress);
            pnlSupplierEntry.Controls.Add(txtSupplierEmail);
            pnlSupplierEntry.Controls.Add(lblSupplierEmail);
            pnlSupplierEntry.Controls.Add(txtSupplierPhone);
            pnlSupplierEntry.Controls.Add(lblSupplierPhone);
            pnlSupplierEntry.Controls.Add(txtSupplierName);
            pnlSupplierEntry.Controls.Add(lblSupplierName);
            pnlSupplierEntry.Controls.Add(txtSupplierCode);
            pnlSupplierEntry.Controls.Add(lblSupplierCode);
            pnlSupplierEntry.Location = new Point(25, 70);
            pnlSupplierEntry.Name = "pnlSupplierEntry";
            pnlSupplierEntry.Size = new Size(930, 250);
            pnlSupplierEntry.TabIndex = 1;
            // 
            // btnClearSupplier
            // 
            btnClearSupplier.BackColor = Color.FromArgb(229, 234, 240);
            btnClearSupplier.FlatStyle = FlatStyle.Flat;
            btnClearSupplier.Font = new Font("Segoe UI", 10F);
            btnClearSupplier.ForeColor = Color.FromArgb(31, 58, 95);
            btnClearSupplier.Location = new Point(640, 195);
            btnClearSupplier.Name = "btnClearSupplier";
            btnClearSupplier.Size = new Size(90, 35);
            btnClearSupplier.TabIndex = 11;
            btnClearSupplier.Text = "Clear";
            btnClearSupplier.UseVisualStyleBackColor = false;
            btnClearSupplier.Click += btnClearSupplier_Click;
            // 
            // btnAddSupplier
            // 
            btnAddSupplier.BackColor = Color.FromArgb(47, 93, 138);
            btnAddSupplier.FlatStyle = FlatStyle.Flat;
            btnAddSupplier.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddSupplier.ForeColor = Color.White;
            btnAddSupplier.Location = new Point(740, 195);
            btnAddSupplier.Name = "btnAddSupplier";
            btnAddSupplier.Size = new Size(150, 35);
            btnAddSupplier.TabIndex = 10;
            btnAddSupplier.Text = "Add Supplier";
            btnAddSupplier.UseVisualStyleBackColor = false;
            btnAddSupplier.Click += btnAddSupplier_Click;
            // 
            // txtSupplierAddress
            // 
            txtSupplierAddress.Font = new Font("Segoe UI", 10F);
            txtSupplierAddress.Location = new Point(140, 121);
            txtSupplierAddress.Multiline = true;
            txtSupplierAddress.Name = "txtSupplierAddress";
            txtSupplierAddress.ScrollBars = ScrollBars.Vertical;
            txtSupplierAddress.Size = new Size(550, 50);
            txtSupplierAddress.TabIndex = 9;
            // 
            // lblSupplierAddress
            // 
            lblSupplierAddress.AutoSize = true;
            lblSupplierAddress.Font = new Font("Segoe UI", 10F);
            lblSupplierAddress.ForeColor = Color.FromArgb(31, 41, 55);
            lblSupplierAddress.Location = new Point(20, 125);
            lblSupplierAddress.Name = "lblSupplierAddress";
            lblSupplierAddress.Size = new Size(58, 19);
            lblSupplierAddress.TabIndex = 8;
            lblSupplierAddress.Text = "Address";
            // 
            // txtSupplierEmail
            // 
            txtSupplierEmail.Font = new Font("Segoe UI", 10F);
            txtSupplierEmail.Location = new Point(510, 66);
            txtSupplierEmail.Name = "txtSupplierEmail";
            txtSupplierEmail.Size = new Size(220, 25);
            txtSupplierEmail.TabIndex = 7;
            // 
            // lblSupplierEmail
            // 
            lblSupplierEmail.AutoSize = true;
            lblSupplierEmail.Font = new Font("Segoe UI", 10F);
            lblSupplierEmail.ForeColor = Color.FromArgb(31, 41, 55);
            lblSupplierEmail.Location = new Point(400, 70);
            lblSupplierEmail.Name = "lblSupplierEmail";
            lblSupplierEmail.Size = new Size(41, 19);
            lblSupplierEmail.TabIndex = 6;
            lblSupplierEmail.Text = "Email";
            // 
            // txtSupplierPhone
            // 
            txtSupplierPhone.Font = new Font("Segoe UI", 10F);
            txtSupplierPhone.Location = new Point(140, 66);
            txtSupplierPhone.Name = "txtSupplierPhone";
            txtSupplierPhone.Size = new Size(220, 25);
            txtSupplierPhone.TabIndex = 5;
            // 
            // lblSupplierPhone
            // 
            lblSupplierPhone.AutoSize = true;
            lblSupplierPhone.Font = new Font("Segoe UI", 10F);
            lblSupplierPhone.ForeColor = Color.FromArgb(31, 41, 55);
            lblSupplierPhone.Location = new Point(20, 70);
            lblSupplierPhone.Name = "lblSupplierPhone";
            lblSupplierPhone.Size = new Size(48, 19);
            lblSupplierPhone.TabIndex = 4;
            lblSupplierPhone.Text = "Phone";
            // 
            // txtSupplierName
            // 
            txtSupplierName.Font = new Font("Segoe UI", 10F);
            txtSupplierName.Location = new Point(510, 16);
            txtSupplierName.Name = "txtSupplierName";
            txtSupplierName.Size = new Size(220, 25);
            txtSupplierName.TabIndex = 3;
            // 
            // lblSupplierName
            // 
            lblSupplierName.AutoSize = true;
            lblSupplierName.Font = new Font("Segoe UI", 10F);
            lblSupplierName.ForeColor = Color.FromArgb(31, 41, 55);
            lblSupplierName.Location = new Point(400, 20);
            lblSupplierName.Name = "lblSupplierName";
            lblSupplierName.Size = new Size(98, 19);
            lblSupplierName.TabIndex = 2;
            lblSupplierName.Text = "Supplier Name";
            // 
            // txtSupplierCode
            // 
            txtSupplierCode.Font = new Font("Segoe UI", 10F);
            txtSupplierCode.Location = new Point(140, 16);
            txtSupplierCode.Name = "txtSupplierCode";
            txtSupplierCode.Size = new Size(220, 25);
            txtSupplierCode.TabIndex = 1;
            // 
            // lblSupplierCode
            // 
            lblSupplierCode.AutoSize = true;
            lblSupplierCode.Font = new Font("Segoe UI", 10F);
            lblSupplierCode.ForeColor = Color.FromArgb(31, 41, 55);
            lblSupplierCode.Location = new Point(20, 20);
            lblSupplierCode.Name = "lblSupplierCode";
            lblSupplierCode.Size = new Size(94, 19);
            lblSupplierCode.TabIndex = 0;
            lblSupplierCode.Text = "Supplier Code";
            // 
            // pnlSupplierList
            // 
            pnlSupplierList.BackColor = Color.White;
            pnlSupplierList.BorderStyle = BorderStyle.FixedSingle;
            pnlSupplierList.Controls.Add(btnDeleteSupplier);
            pnlSupplierList.Controls.Add(btnEditSupplier);
            pnlSupplierList.Controls.Add(lvSuppliers);
            pnlSupplierList.Controls.Add(txtSearchSuppliers);
            pnlSupplierList.Controls.Add(lblSupplierListTitle);
            pnlSupplierList.Location = new Point(25, 340);
            pnlSupplierList.Name = "pnlSupplierList";
            pnlSupplierList.Size = new Size(930, 280);
            pnlSupplierList.TabIndex = 2;
            // 
            // btnDeleteSupplier
            // 
            btnDeleteSupplier.BackColor = Color.FromArgb(198, 40, 40);
            btnDeleteSupplier.FlatStyle = FlatStyle.Flat;
            btnDeleteSupplier.Font = new Font("Segoe UI", 10F);
            btnDeleteSupplier.ForeColor = Color.White;
            btnDeleteSupplier.Location = new Point(165, 230);
            btnDeleteSupplier.Name = "btnDeleteSupplier";
            btnDeleteSupplier.Size = new Size(140, 35);
            btnDeleteSupplier.TabIndex = 4;
            btnDeleteSupplier.Text = "Delete Selected";
            btnDeleteSupplier.UseVisualStyleBackColor = false;
            btnDeleteSupplier.Click += btnDeleteSupplier_Click;
            // 
            // btnEditSupplier
            // 
            btnEditSupplier.BackColor = Color.FromArgb(47, 93, 138);
            btnEditSupplier.FlatStyle = FlatStyle.Flat;
            btnEditSupplier.Font = new Font("Segoe UI", 10F);
            btnEditSupplier.ForeColor = Color.White;
            btnEditSupplier.Location = new Point(20, 230);
            btnEditSupplier.Name = "btnEditSupplier";
            btnEditSupplier.Size = new Size(130, 35);
            btnEditSupplier.TabIndex = 3;
            btnEditSupplier.Text = "Edit Selected";
            btnEditSupplier.UseVisualStyleBackColor = false;
            btnEditSupplier.Click += btnEditSupplier_Click;
            // 
            // lvSuppliers
            // 
            lvSuppliers.Columns.AddRange(new ColumnHeader[] { colSupplierCode, colSupplierName, colSupplierPhone, colSupplierEmail, colSupplierAddress });
            lvSuppliers.FullRowSelect = true;
            lvSuppliers.GridLines = true;
            lvSuppliers.Location = new Point(20, 90);
            lvSuppliers.MultiSelect = false;
            lvSuppliers.Name = "lvSuppliers";
            lvSuppliers.Size = new Size(880, 130);
            lvSuppliers.TabIndex = 2;
            lvSuppliers.UseCompatibleStateImageBehavior = false;
            lvSuppliers.View = View.Details;
            // 
            // colSupplierCode
            // 
            colSupplierCode.Text = "Supplier Code";
            colSupplierCode.Width = 110;
            // 
            // colSupplierName
            // 
            colSupplierName.Text = "Supplier Name";
            colSupplierName.Width = 160;
            // 
            // colSupplierPhone
            // 
            colSupplierPhone.Text = "Phone";
            colSupplierPhone.Width = 120;
            // 
            // colSupplierEmail
            // 
            colSupplierEmail.Text = "Email";
            colSupplierEmail.Width = 190;
            // 
            // colSupplierAddress
            // 
            colSupplierAddress.Text = "Address";
            colSupplierAddress.Width = 200;
            // 
            // txtSearchSuppliers
            // 
            txtSearchSuppliers.Font = new Font("Segoe UI", 10F);
            txtSearchSuppliers.Location = new Point(20, 50);
            txtSearchSuppliers.Name = "txtSearchSuppliers";
            txtSearchSuppliers.PlaceholderText = "Search by supplier code or name...";
            txtSearchSuppliers.Size = new Size(350, 25);
            txtSearchSuppliers.TabIndex = 1;
            txtSearchSuppliers.TextChanged += txtSearchSuppliers_TextChanged;
            // 
            // lblSupplierListTitle
            // 
            lblSupplierListTitle.AutoSize = true;
            lblSupplierListTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSupplierListTitle.ForeColor = Color.FromArgb(31, 58, 95);
            lblSupplierListTitle.Location = new Point(20, 15);
            lblSupplierListTitle.Name = "lblSupplierListTitle";
            lblSupplierListTitle.Size = new Size(122, 25);
            lblSupplierListTitle.TabIndex = 0;
            lblSupplierListTitle.Text = "Supplier List";
            // 
            // SuppliersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 246, 249);
            ClientSize = new Size(984, 611);
            Controls.Add(pnlSupplierList);
            Controls.Add(pnlSupplierEntry);
            Controls.Add(lblSuppliersHeading);
            Name = "SuppliersForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Supplier Management";
            pnlSupplierEntry.ResumeLayout(false);
            pnlSupplierEntry.PerformLayout();
            pnlSupplierList.ResumeLayout(false);
            pnlSupplierList.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSuppliersHeading;
        private Panel pnlSupplierEntry;
        private Label lblSupplierCode;
        private Label lblSupplierName;
        private TextBox txtSupplierCode;
        private Label lblSupplierPhone;
        private TextBox txtSupplierName;
        private Label lblSupplierEmail;
        private TextBox txtSupplierPhone;
        private TextBox txtSupplierEmail;
        private TextBox txtSupplierAddress;
        private Label lblSupplierAddress;
        private Button btnAddSupplier;
        private Button btnClearSupplier;
        private Panel pnlSupplierList;
        private Label lblSupplierListTitle;
        private TextBox txtSearchSuppliers;
        private ListView lvSuppliers;
        private ColumnHeader colSupplierCode;
        private ColumnHeader colSupplierName;
        private ColumnHeader colSupplierPhone;
        private ColumnHeader colSupplierEmail;
        private ColumnHeader colSupplierAddress;
        private Button btnEditSupplier;
        private Button btnDeleteSupplier;
    }
}