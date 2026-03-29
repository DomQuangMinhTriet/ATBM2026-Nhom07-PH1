using Oracle.ManagedDataAccess.Client;
using System.Data;
using OracleAdminApp.Data;

namespace OracleAdminApp.Services
{
    public class UserService
    {
        private DbHelper db;

        public UserService(string connectionString)
        {
            db = new DbHelper(connectionString);
        }

        public DataTable GetUsers()
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();

                string sql = "SELECT USERNAME FROM ALL_USERS ORDER BY USERNAME";

                OracleDataAdapter da = new OracleDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
        }
    }
}