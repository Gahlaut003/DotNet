using System.Data.Common;
namespace Utility_001.Libs.DAL
{
    public interface IDBConnectionBuilder
    {
        DbConnectionStringBuilder GetConnectionStringBuilder(string connectionString);
    }
}
