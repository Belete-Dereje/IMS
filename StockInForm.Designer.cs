namespace IMS
{
    partial class StockInForm
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
            lblStockInHeading = new Label();
            pnlStockInEntry = new Panel();
            btnStockIn = new Button();
            txtNotes = new TextBox();
            lblNotes = new Label();
            numQuantity = new NumericUpDown();
            lblQuantity = new Label();
            cmbProduct = new ComboBox();
            lblProduct = new Label();
            pnlStockInEntry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            SuspendLayout();
            // 
            // lblStockInHeading
            // 
            lblStockInHeading.AutoSize = true;
            lblStockInHeading.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStockInHeading.ForeColor = Color.FromArgb(31, 58, 95);
            lblStockInHeading.Location = new Point(25, 20);
            lblStockInHeading.Name = "lblStockInHeading";
            lblStockInHeading.Size = new Size(324, 32);
            lblStockInHeading.TabIndex = 0;
            lblStockInHeading.Text = "Stock In - Receive Products";
            // 
            // pnlStockInEntry
            // 
            pnlStockInEntry.BackColor = Color.White;
            pnlStockInEntry.BorderStyle = BorderStyle.FixedSingle;
            pnlStockInEntry.Controls.Add(btnStockIn);
            pnlStockInEntry.Controls.Add(txtNotes);
            pnlStockInEntry.Controls.Add(lblNotes);
            pnlStockInEntry.Controls.Add(numQuantity);
            pnlStockInEntry.Controls.Add(lblQuantity);
            pnlStockInEntry.Controls.Add(cmbProduct);
            pnlStockInEntry.Controls.Add(lblProduct);
            pnlStockInEntry.Location = new Point(25, 70);
            pnlStockInEntry.Name = "pnlStockInEntry";
            pnlStockInEntry.Size = new Size(730, 220);
            pnlStockInEntry.TabIndex = 1;
            // 
            // btnStockIn
            // 
            btnStockIn.BackColor = Color.FromArgb(47, 93, 138);
            btnStockIn.FlatStyle = FlatStyle.Flat;
            btnStockIn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStockIn.ForeColor = Color.White;
            btnStockIn.Location = new Point(550, 180);
            btnStockIn.Name = "btnStockIn";
            btnStockIn.Size = new Size(140, 30);
            btnStockIn.TabIndex = 6;
            btnStockIn.Text = "Record Stock In";
            btnStockIn.UseVisualStyleBackColor = false;
            btnStockIn.Click += btnStockIn_Click;
            // 
            // txtNotes
            // 
            txtNotes.Font = new Font("Segoe UI", 10F);
            txtNotes.Location = new Point(130, 124);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.ScrollBars = ScrollBars.Vertical;
            txtNotes.Size = new Size(550, 50);
            txtNotes.TabIndex = 5;
            // 
            // lblNotes
            // 
            lblNotes.AutoSize = true;
            lblNotes.Font = new Font("Segoe UI", 10F);
            lblNotes.ForeColor = Color.FromArgb(31, 41, 55);
            lblNotes.Location = new Point(20, 130);
            lblNotes.Name = "lblNotes";
            lblNotes.Size = new Size(45, 19);
            lblNotes.TabIndex = 4;
            lblNotes.Text = "Notes";
            // 
            // numQuantity
            // 
            numQuantity.Font = new Font("Segoe UI", 10F);
            numQuantity.Location = new Point(140, 71);
            numQuantity.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(180, 25);
            numQuantity.TabIndex = 3;
            numQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Segoe UI", 10F);
            lblQuantity.ForeColor = Color.FromArgb(31, 41, 55);
            lblQuantity.Location = new Point(20, 75);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(109, 19);
            lblQuantity.TabIndex = 2;
            lblQuantity.Text = "Quantity to Add";
            // 
            // cmbProduct
            // 
            cmbProduct.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProduct.Font = new Font("Segoe UI", 10F);
            cmbProduct.FormattingEnabled = true;
            cmbProduct.Location = new Point(140, 21);
            cmbProduct.Name = "cmbProduct";
            cmbProduct.Size = new Size(300, 25);
            cmbProduct.TabIndex = 1;
            // 
            // lblProduct
            // 
            lblProduct.AutoSize = true;
            lblProduct.Font = new Font("Segoe UI", 10F);
            lblProduct.ForeColor = Color.FromArgb(31, 41, 55);
            lblProduct.Location = new Point(20, 25);
            lblProduct.Name = "lblProduct";
            lblProduct.Size = new Size(57, 19);
            lblProduct.TabIndex = 0;
            lblProduct.Text = "Product";
            // 
            // StockInForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 246, 249);
            ClientSize = new Size(784, 511);
            Controls.Add(pnlStockInEntry);
            Controls.Add(lblStockInHeading);
            Name = "StockInForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Stock In - Inventory Management";
            Load += StockInForm_Load;
            pnlStockInEntry.ResumeLayout(false);
            pnlStockInEntry.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStockInHeading;
        private Panel pnlStockInEntry;
        private Label lblProduct;
        private ComboBox cmbProduct;
        private Label lblQuantity;
        private NumericUpDown numQuantity;
        private Label lblNotes;
        private TextBox txtNotes;
        private Button btnStockIn;
    }
}