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
            lblProductCode = new Label();
            txtProductCode = new TextBox();
            pnlProductEntry.SuspendLayout();
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
            pnlProductEntry.Controls.Add(txtProductCode);
            pnlProductEntry.Controls.Add(lblProductCode);
            pnlProductEntry.Location = new Point(25, 70);
            pnlProductEntry.Name = "pnlProductEntry";
            pnlProductEntry.Size = new Size(1030, 230);
            pnlProductEntry.TabIndex = 1;
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
            // txtProductCode
            // 
            txtProductCode.Font = new Font("Segoe UI", 10F);
            txtProductCode.Location = new Point(140, 16);
            txtProductCode.Name = "txtProductCode";
            txtProductCode.Size = new Size(220, 25);
            txtProductCode.TabIndex = 1;
            // 
            // ProductsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 246, 249);
            ClientSize = new Size(1084, 661);
            Controls.Add(pnlProductEntry);
            Controls.Add(lblProductsHeading);
            Name = "ProductsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Product Management";
            pnlProductEntry.ResumeLayout(false);
            pnlProductEntry.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblProductsHeading;
        private Panel pnlProductEntry;
        private Label lblProductCode;
        private TextBox txtProductCode;
    }
}