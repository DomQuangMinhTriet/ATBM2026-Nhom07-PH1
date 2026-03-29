using System;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace OracleAdminApp
{
    public partial class LoginForm : Form
    {
        public string ConnectionString { get; private set; }

        public LoginForm()
        {
            InitializeComponent();
            this.AcceptButton = btnLogin;
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            ValidateInput();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            ValidateInput();
        }

        private void ValidateInput()
        {
            btnLogin.Enabled =
                txtUsername.Text.Length > 0 &&
                txtPassword.Text.Length > 0;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string host = txtHost.Text.Trim();
            string port = txtPort.Text.Trim();
            string service = txtServiceName.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Enter username and password");
                return;
            }

            string connStr =
                $"User Id={username};Password={password};Data Source={host}:{port}/{service};";

            try
            {
                using (OracleConnection conn = new OracleConnection(connStr))
                {
                    conn.Open();
                }

                // Save connection string
                ConnectionString = connStr;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login failed: " + ex.Message);
            }
        }
    }
}