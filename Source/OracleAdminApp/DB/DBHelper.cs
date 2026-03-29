using Oracle.ManagedDataAccess.Client;

namespace OracleAdminApp.Data
{
    public class DbHelper
    {
        private string _connectionString;

        public DbHelper(string connectionString)
        {
            _connectionString = connectionString;
        }

        public OracleConnection GetConnection()
        {
            return new OracleConnection(_connectionString);
        }
    }
}