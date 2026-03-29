//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace OracleAdminApp
//{
//    public partial class Form1 : Form
//    {
//        public Form1()
//        {
//            InitializeComponent();
//        }
//    }
//}

using System;
using System.Windows.Forms;
using OracleAdminApp.Data;
using Oracle.ManagedDataAccess.Client;

namespace OracleAdminApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                DbHelper db = new DbHelper();
                using (OracleConnection conn = db.GetConnection())
                {
                    conn.Open();
                    MessageBox.Show("Connected successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}