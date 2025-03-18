using System.Data;

namespace Utility_001.Libs.DAL
{
    public interface IConnectionFactory
    {
        IDbConnection Create();
        IDbConnection Create(string connectionName);
        IDbConnection CreateConnectionForYellowFin(string connectionName);
        bool IsMultiTenant { get; }
        string ClientDatabase { get; }
        IDbDataAdapter GetDataAdapter(IDbCommand command);
    }
}
