using Utility_001.Libs.Constants;
using Utility_001.Libs.Entities;
namespace Utility_001.Libs.Entities
{
    public class ConnectionSettings
    {

        public DataAccessProviderTypes DatabaseType { get; set; }
        public DataConnectorType DataConnector { get; set; }
        public int MultiTenant { get; set; }

        public string DefaultConnection { get; set; }
        public bool IsEncrypted { get; set; }
    }
}
