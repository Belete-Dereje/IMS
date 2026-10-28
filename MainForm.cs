namespace IMS
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();

            registerForm.FormClosed += (s, args) => this.Show();

            this.Hide();
            registerForm.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DashboardForm dashboard = new DashboardForm();

            dashboard.FormClosed += (s, args) => this.Close();

            this.Hide();
            dashboard.Show();
        }
    }
}
