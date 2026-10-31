namespace IMS
{
    partial class StockOutForm
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
            lblStockOutHeading = new Label();
            pnlStockOutEntry = new Panel();
            btnStockOut = new Button();
            txtNotes = new TextBox();
            lblNotes = new Label();
            numQuantity = new NumericUpDown();
            lblQuantity = new Label();
            cmbProduct = new ComboBox();
            lblProduct = new Label();
            pnlStockOutEntry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            SuspendLayout();
            // 
            // lblStockOutHeading
            // 
            lblStockOutHeading.AutoSize = true;
            lblStockOutHeading.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStockOutHeading.ForeColor = Color.FromArgb(31, 58, 95);
            lblStockOutHeading.Location = new Point(25, 20);
            lblStockOutHeading.Name = "lblStockOutHeading";
            lblStockOutHeading.Size = new Size(315, 32);
            lblStockOutHeading.TabIndex = 0;
            lblStockOutHeading.Text = "Stock Out - Issue Products";
            // 
            // pnlStockOutEntry
            // 
            pnlStockOutEntry.BackColor = Color.White;
            pnlStockOutEntry.BorderStyle = BorderStyle.FixedSingle;
            pnlStockOutEntry.Controls.Add(btnStockOut);
            pnlStockOutEntry.Controls.Add(txtNotes);
            pnlStockOutEntry.Controls.Add(lblNotes);
            pnlStockOutEntry.Controls.Add(numQuantity);
            pnlStockOutEntry.Controls.Add(lblQuantity);
            pnlStockOutEntry.Controls.Add(cmbProduct);
            pnlStockOutEntry.Controls.Add(lblProduct);
            pnlStockOutEntry.Location = new Point(25, 70);
            pnlStockOutEntry.Name = "pnlStockOutEntry";
            pnlStockOutEntry.Size = new Size(730, 220);
            pnlStockOutEntry.TabIndex = 1;
            // 
            // btnStockOut
            // 
            btnStockOut.BackColor = Color.FromArgb(198, 40, 40);
            btnStockOut.FlatStyle = FlatStyle.Flat;
            btnStockOut.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStockOut.ForeColor = Color.White;
            btnStockOut.Location = new Point(550, 180);
            btnStockOut.Name = "btnStockOut";
            btnStockOut.Size = new Size(140, 30);
            btnStockOut.TabIndex = 6;
            btnStockOut.Text = "Record Stock Out";
            btnStockOut.UseVisualStyleBackColor = false;
            btnStockOut.Click += btnStockOut_Click;
            // 
            // txtNotes
            // 
            txtNotes.Font = new Font("Segoe UI", 10F);
            txtNotes.Location = new Point(140, 126);
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
            lblNotes.Size = new Size(102, 19);
            lblNotes.TabIndex = 4;
            lblNotes.Text = "Notes / Reason";
            // 
            // numQuantity
            // 
            numQuantity.Font = new Font("Segoe UI", 10F);
            numQuantity.Location = new Point(160, 71);
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
            lblQuantity.Size = new Size(133, 19);
            lblQuantity.TabIndex = 2;
            lblQuantity.Text = "Quantity to Remove";
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
            // StockOutForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 246, 249);
            ClientSize = new Size(784, 511);
            Controls.Add(pnlStockOutEntry);
            Controls.Add(lblStockOutHeading);
            Name = "StockOutForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Stock Out - Issue Products";
            pnlStockOutEntry.ResumeLayout(false);
            pnlStockOutEntry.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStockOutHeading;
        private Panel pnlStockOutEntry;
        private Label lblProduct;
        private Label lblQuantity;
        private ComboBox cmbProduct;
        private NumericUpDown numQuantity;
        private Label lblNotes;
        private TextBox txtNotes;
        private Button btnStockOut;
    }
}