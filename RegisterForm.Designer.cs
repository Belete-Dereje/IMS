namespace IMS
{
    partial class RegisterForm
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
            pnlRegisterCard = new Panel();
            lblTitle = new Label();
            lblFullName = new Label();
            lblRegUsername = new Label();
            lblEmail = new Label();
            lblRegPassword = new Label();
            lblConfirmPassword = new Label();
            txtFullName = new TextBox();
            txtRegUsername = new TextBox();
            txtEmail = new TextBox();
            txtRegPassword = new TextBox();
            txtConfirmPassword = new TextBox();
            btnCreateAccount = new Button();
            btnBackToLogin = new Button();
            pnlRegisterCard.SuspendLayout();
            SuspendLayout();
            // 
            // pnlRegisterCard
            // 
            pnlRegisterCard.BackColor = Color.White;
            pnlRegisterCard.BorderStyle = BorderStyle.FixedSingle;
            pnlRegisterCard.Controls.Add(btnBackToLogin);
            pnlRegisterCard.Controls.Add(btnCreateAccount);
            pnlRegisterCard.Controls.Add(txtConfirmPassword);
            pnlRegisterCard.Controls.Add(txtRegPassword);
            pnlRegisterCard.Controls.Add(txtEmail);
            pnlRegisterCard.Controls.Add(txtRegUsername);
            pnlRegisterCard.Controls.Add(txtFullName);
            pnlRegisterCard.Controls.Add(lblConfirmPassword);
            pnlRegisterCard.Controls.Add(lblRegPassword);
            pnlRegisterCard.Controls.Add(lblEmail);
            pnlRegisterCard.Controls.Add(lblRegUsername);
            pnlRegisterCard.Controls.Add(lblFullName);
            pnlRegisterCard.Controls.Add(lblTitle);
            pnlRegisterCard.Location = new Point(270, 50);
            pnlRegisterCard.Name = "pnlRegisterCard";
            pnlRegisterCard.Size = new Size(460, 520);
            pnlRegisterCard.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 17.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(134, 29);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(177, 31);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Create Account";
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Location = new Point(86, 103);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(61, 15);
            lblFullName.TabIndex = 1;
            lblFullName.Text = "Full Name";
            // 
            // lblRegUsername
            // 
            lblRegUsername.AutoSize = true;
            lblRegUsername.Location = new Point(86, 153);
            lblRegUsername.Name = "lblRegUsername";
            lblRegUsername.Size = new Size(60, 15);
            lblRegUsername.TabIndex = 2;
            lblRegUsername.Text = "Username";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(86, 200);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email";
            // 
            // lblRegPassword
            // 
            lblRegPassword.AutoSize = true;
            lblRegPassword.Location = new Point(85, 249);
            lblRegPassword.Name = "lblRegPassword";
            lblRegPassword.Size = new Size(57, 15);
            lblRegPassword.TabIndex = 4;
            lblRegPassword.Text = "Password";
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Location = new Point(67, 302);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(104, 15);
            lblConfirmPassword.TabIndex = 5;
            lblConfirmPassword.Text = "Confirm Password";
            // 
            // txtFullName
            // 
            txtFullName.Font = new Font("Segoe UI", 11F);
            txtFullName.Location = new Point(200, 96);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(163, 27);
            txtFullName.TabIndex = 6;
            // 
            // txtRegUsername
            // 
            txtRegUsername.Font = new Font("Segoe UI", 11F);
            txtRegUsername.Location = new Point(200, 141);
            txtRegUsername.Name = "txtRegUsername";
            txtRegUsername.Size = new Size(163, 27);
            txtRegUsername.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 11F);
            txtEmail.Location = new Point(200, 188);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(163, 27);
            txtEmail.TabIndex = 8;
            // 
            // txtRegPassword
            // 
            txtRegPassword.Font = new Font("Segoe UI", 11F);
            txtRegPassword.Location = new Point(200, 237);
            txtRegPassword.Name = "txtRegPassword";
            txtRegPassword.PasswordChar = '*';
            txtRegPassword.Size = new Size(163, 27);
            txtRegPassword.TabIndex = 9;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Font = new Font("Segoe UI", 11F);
            txtConfirmPassword.Location = new Point(200, 290);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.Size = new Size(163, 27);
            txtConfirmPassword.TabIndex = 10;
            // 
            // btnCreateAccount
            // 
            btnCreateAccount.BackColor = Color.FromArgb(47, 93, 138);
            btnCreateAccount.FlatStyle = FlatStyle.Flat;
            btnCreateAccount.ForeColor = Color.White;
            btnCreateAccount.Location = new Point(233, 379);
            btnCreateAccount.Name = "btnCreateAccount";
            btnCreateAccount.Size = new Size(86, 33);
            btnCreateAccount.TabIndex = 11;
            btnCreateAccount.Text = "Register";
            btnCreateAccount.UseVisualStyleBackColor = false;
            // 
            // btnBackToLogin
            // 
            btnBackToLogin.BackColor = Color.FromArgb(47, 93, 138);
            btnBackToLogin.FlatStyle = FlatStyle.Flat;
            btnBackToLogin.ForeColor = Color.White;
            btnBackToLogin.Location = new Point(67, 379);
            btnBackToLogin.Name = "btnBackToLogin";
            btnBackToLogin.Size = new Size(101, 33);
            btnBackToLogin.TabIndex = 12;
            btnBackToLogin.Text = "Back to Login";
            btnBackToLogin.UseVisualStyleBackColor = false;
            btnBackToLogin.Click += btnBackToLogin_Click;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 246, 249);
            ClientSize = new Size(984, 611);
            Controls.Add(pnlRegisterCard);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimizeBox = false;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventory Management System - Register";
            Load += RegisterForm_Load;
            pnlRegisterCard.ResumeLayout(false);
            pnlRegisterCard.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlRegisterCard;
        private Label lblTitle;
        private TextBox txtFullName;
        private Label lblConfirmPassword;
        private Label lblRegPassword;
        private Label lblEmail;
        private Label lblRegUsername;
        private Label lblFullName;
        private Button btnBackToLogin;
        private Button btnCreateAccount;
        private TextBox txtConfirmPassword;
        private TextBox txtRegPassword;
        private TextBox txtEmail;
        private TextBox txtRegUsername;
    }
}