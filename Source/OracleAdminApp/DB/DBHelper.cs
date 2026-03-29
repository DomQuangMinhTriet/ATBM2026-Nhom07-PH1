using Oracle.ManagedDataAccess.Client;

namespace OracleAdminApp.Data
{
    public class DbHelper
    {
        private string connectionString =
            "User Id=ATBM_ADMIN;Password=123;Data Source=localhost:1521/xepdb1;";

        public OracleConnection GetConnection()
        {
            return new OracleConnection(connectionString);
        }
    }
}