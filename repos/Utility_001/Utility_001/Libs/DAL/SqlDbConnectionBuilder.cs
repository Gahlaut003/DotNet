using System.Data.Common;
using Utility_001.Libs.DAL;
using MySql.Data.MySqlClient;

namespace Utility_001.Libs.DAL
{
    public class SqlDbConnectionBuilder : IDBConnectionBuilder
    {
        public DbConnectionStringBuilder GetConnectionStringBuilder(string connectionString)
        {
            return new MySqlConnectionStringBuilder(connectionString);
        }
    }
}
