namespace IMS
{
    partial class TransactionsForm
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
            lblTransactionsHeading = new Label();
            txtSearchTransactions = new TextBox();
            lvTransactions = new ListView();
            colDate = new ColumnHeader();
            colType = new ColumnHeader();
            colProductCode = new ColumnHeader();
            colProductName = new ColumnHeader();
            colSupplier = new ColumnHeader();
            colQuantity = new ColumnHeader();
            colNotes = new ColumnHeader();
            SuspendLayout();
            // 
            // lblTransactionsHeading
            // 
            lblTransactionsHeading.AutoSize = true;
            lblTransactionsHeading.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTransactionsHeading.ForeColor = Color.FromArgb(31, 58, 95);
            lblTransactionsHeading.Location = new Point(25, 20);
            lblTransactionsHeading.Name = "lblTransactionsHeading";
            lblTransactionsHeading.Size = new Size(237, 32);
            lblTransactionsHeading.TabIndex = 0;
            lblTransactionsHeading.Text = "Transaction History";
            // 
            // txtSearchTransactions
            // 
            txtSearchTransactions.Font = new Font("Segoe UI", 10F);
            txtSearchTransactions.Location = new Point(25, 70);
            txtSearchTransactions.Name = "txtSearchTransactions";
            txtSearchTransactions.PlaceholderText = "Search by product code or name...";
            txtSearchTransactions.Size = new Size(400, 25);
            txtSearchTransactions.TabIndex = 1;
            txtSearchTransactions.TextChanged += txtSearchTransactions_TextChanged;
            // 
            // lvTransactions
            // 
            lvTransactions.Columns.AddRange(new ColumnHeader[] { colDate, colType, colProductCode, colProductName, colSupplier, colQuantity, colNotes });
            lvTransactions.FullRowSelect = true;
            lvTransactions.GridLines = true;
            lvTransactions.Location = new Point(20, 110);
            lvTransactions.MultiSelect = false;
            lvTransactions.Name = "lvTransactions";
            lvTransactions.Size = new Size(916, 475);
            lvTransactions.TabIndex = 2;
            lvTransactions.UseCompatibleStateImageBehavior = false;
            lvTransactions.View = View.Details;
            // 
            // colDate
            // 
            colDate.Text = "Date";
            colDate.Width = 140;
            // 
            // colType
            // 
            colType.Text = "Transaction Type";
            colType.Width = 120;
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
            // colSupplier
            // 
            colSupplier.Text = "Supplier";
            colSupplier.Width = 130;
            // 
            // colQuantity
            // 
            colQuantity.Text = "Quantity";
            colQuantity.Width = 90;
            // 
            // colNotes
            // 
            colNotes.Text = "Notes";
            colNotes.Width = 200;
            // 
            // TransactionsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 246, 249);
            ClientSize = new Size(958, 597);
            Controls.Add(lvTransactions);
            Controls.Add(txtSearchTransactions);
            Controls.Add(lblTransactionsHeading);
            Name = "TransactionsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Transaction History";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTransactionsHeading;
        private TextBox txtSearchTransactions;
        private ListView lvTransactions;
        private ColumnHeader colDate;
        private ColumnHeader colType;
        private ColumnHeader colProductCode;
        private ColumnHeader colProductName;
        private ColumnHeader colSupplier;
        private ColumnHeader colQuantity;
        private ColumnHeader colNotes;
    }
}