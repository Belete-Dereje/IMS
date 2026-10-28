namespace IMS
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlLoginCard = new Panel();
            btnRegister = new Button();
            btnLogin = new Button();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            lblRegisterPrompt = new Label();
            lblPassword = new Label();
            lblUsername = new Label();
            lblSubtitle = new Label();
            lblTitle = new Label();
            pnlLoginCard.SuspendLayout();
            SuspendLayout();
            // 
            // pnlLoginCard
            // 
            pnlLoginCard.BackColor = Color.White;
            pnlLoginCard.BorderStyle = BorderStyle.FixedSingle;
            pnlLoginCard.Controls.Add(btnRegister);
            pnlLoginCard.Controls.Add(btnLogin);
            pnlLoginCard.Controls.Add(txtPassword);
            pnlLoginCard.Controls.Add(txtUsername);
            pnlLoginCard.Controls.Add(lblRegisterPrompt);
            pnlLoginCard.Controls.Add(lblPassword);
            pnlLoginCard.Controls.Add(lblUsername);
            pnlLoginCard.Controls.Add(lblSubtitle);
            pnlLoginCard.Controls.Add(lblTitle);
            pnlLoginCard.Location = new Point(285, 50);
            pnlLoginCard.Name = "pnlLoginCard";
            pnlLoginCard.Size = new Size(430, 480);
            pnlLoginCard.TabIndex = 0;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(47, 93, 138);
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(229, 348);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(92, 33);
            btnRegister.TabIndex = 8;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(47, 93, 138);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(82, 348);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 33);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 11F);
            txtPassword.Location = new Point(141, 270);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(153, 27);
            txtPassword.TabIndex = 6;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 11F);
            txtUsername.Location = new Point(141, 217);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Username";
            txtUsername.Size = new Size(153, 27);
            txtUsername.TabIndex = 5;
            // 
            // lblRegisterPrompt
            // 
            lblRegisterPrompt.AutoSize = true;
            lblRegisterPrompt.ForeColor = Color.FromArgb(107, 114, 128);
            lblRegisterPrompt.Location = new Point(257, 126);
            lblRegisterPrompt.Name = "lblRegisterPrompt";
            lblRegisterPrompt.Size = new Size(131, 15);
            lblRegisterPrompt.TabIndex = 4;
            lblRegisterPrompt.Text = "Don't have an account?";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(61, 277);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(57, 15);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(58, 217);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(60, 15);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "Username";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitle.ForeColor = Color.FromArgb(107, 114, 128);
            lblSubtitle.Location = new Point(135, 124);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(116, 17);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Sign in to continue";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 17.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(40, 41);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(348, 31);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Inventory Management System";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 246, 249);
            ClientSize = new Size(984, 611);
            Controls.Add(pnlLoginCard);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimumSize = new Size(1000, 650);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventory Management System - Login";
            pnlLoginCard.ResumeLayout(false);
            pnlLoginCard.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlLoginCard;
        private Label lblSubtitle;
        private Label lblTitle;
        private TextBox txtUsername;
        private Label lblRegisterPrompt;
        private Label lblPassword;
        private Label lblUsername;
        private Button btnRegister;
        private Button btnLogin;
        private TextBox txtPassword;
    }
}
