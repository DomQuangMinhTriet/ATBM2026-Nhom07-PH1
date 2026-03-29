using Oracle.ManagedDataAccess.Client;
using System.Data;
using OracleAdminApp.Data;

namespace OracleAdminApp.Services
{
    public class RoleService
    {
        private DbHelper db;

        public RoleService(string connectionString)
        {
            db = new DbHelper(connectionString);
        }

        public DataTable GetRoles()
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();

                string sql = "SELECT ROLE FROM DBA_ROLES ORDER BY ROLE";

                OracleDataAdapter da = new OracleDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
        }
    }
}