using System;
using System.Windows.Forms;

namespace OracleAdminApp
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            LoginForm login = new LoginForm();

            if (login.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new OracleAdminApp(login.ConnectionString));
            }
        }
    }
}