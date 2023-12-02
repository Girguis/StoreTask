using System.Data.SqlClient;

namespace StoreTask._Repository
{
    public abstract class BaseRepo
    {
        private readonly string connectionString;
        private SqlConnection connection;
        public BaseRepo(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public SqlConnection GetConnectionInstance()
        {
            if (connection == null)
                connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}
