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
            lblSupplierCode = new Label();
            txtSupplierCode = new TextBox();
            lblSupplierName = new Label();
            txtSupplierName = new TextBox();
            lblSupplierPhone = new Label();
            txtSupplierPhone = new TextBox();
            lblSupplierEmail = new Label();
            txtSupplierEmail = new TextBox();
            lblSupplierAddress = new Label();
            txtSupplierAddress = new TextBox();
            btnAddSupplier = new Button();
            btnClearSupplier = new Button();
            pnlSupplierList = new Panel();
            lblSupplierListTitle = new Label();
            txtSearchSuppliers = new TextBox();
            listView1 = new ListView();
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
            // txtSupplierCode
            // 
            txtSupplierCode.Font = new Font("Segoe UI", 10F);
            txtSupplierCode.Location = new Point(140, 16);
            txtSupplierCode.Name = "txtSupplierCode";
            txtSupplierCode.Size = new Size(220, 25);
            txtSupplierCode.TabIndex = 1;
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
            // txtSupplierName
            // 
            txtSupplierName.Font = new Font("Segoe UI", 10F);
            txtSupplierName.Location = new Point(510, 16);
            txtSupplierName.Name = "txtSupplierName";
            txtSupplierName.Size = new Size(220, 25);
            txtSupplierName.TabIndex = 3;
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
            // txtSupplierPhone
            // 
            txtSupplierPhone.Font = new Font("Segoe UI", 10F);
            txtSupplierPhone.Location = new Point(140, 66);
            txtSupplierPhone.Name = "txtSupplierPhone";
            txtSupplierPhone.Size = new Size(220, 25);
            txtSupplierPhone.TabIndex = 5;
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
            // txtSupplierEmail
            // 
            txtSupplierEmail.Font = new Font("Segoe UI", 10F);
            txtSupplierEmail.Location = new Point(510, 66);
            txtSupplierEmail.Name = "txtSupplierEmail";
            txtSupplierEmail.Size = new Size(220, 25);
            txtSupplierEmail.TabIndex = 7;
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
            // 
            // pnlSupplierList
            // 
            pnlSupplierList.BackColor = Color.White;
            pnlSupplierList.BorderStyle = BorderStyle.FixedSingle;
            pnlSupplierList.Controls.Add(listView1);
            pnlSupplierList.Controls.Add(txtSearchSuppliers);
            pnlSupplierList.Controls.Add(lblSupplierListTitle);
            pnlSupplierList.Location = new Point(25, 340);
            pnlSupplierList.Name = "pnlSupplierList";
            pnlSupplierList.Size = new Size(930, 280);
            pnlSupplierList.TabIndex = 2;
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
            // txtSearchSuppliers
            // 
            txtSearchSuppliers.Font = new Font("Segoe UI", 10F);
            txtSearchSuppliers.Location = new Point(20, 50);
            txtSearchSuppliers.Name = "txtSearchSuppliers";
            txtSearchSuppliers.PlaceholderText = "Search by supplier code or name...";
            txtSearchSuppliers.Size = new Size(350, 25);
            txtSearchSuppliers.TabIndex = 1;
            // 
            // listView1
            // 
            listView1.Location = new Point(192, 154);
            listView1.Name = "listView1";
            listView1.Size = new Size(121, 97);
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
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
        private ListView listView1;
    }
}