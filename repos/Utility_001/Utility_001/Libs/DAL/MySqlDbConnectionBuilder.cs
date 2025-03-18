using System.Data.Common;
using Utility_001.Libs.DAL;

namespace Utility_001.Libs.DAL
{
    public class MySqlDbConnectionBuilder : IDBConnectionBuilder
    {
        public DbConnectionStringBuilder GetConnectionStringBuilder(string connectionString)
        {
            return new MySql.Data.MySqlClient.MySqlConnectionStringBuilder(connectionString);
        }
    }
}
