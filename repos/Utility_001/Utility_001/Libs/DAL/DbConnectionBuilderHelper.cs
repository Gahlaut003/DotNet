using Microsoft.AspNetCore.Connections;
using Microsoft.Extensions.Options;
using Utility_001.Libs.Constants;
using Utility_001.Libs.Entities;

namespace Utility_001.Libs.DAL
{
    public static class DbConnectionBuilderHelper
    {
        public static IDBConnectionBuilder GetConnectionBuilder(IOptions<ConnectionSettings> connectionOptions)
        {
            return GetConnectionBuilder(connectionOptions.Value);
        }
        public static IDBConnectionBuilder GetConnectionBuilder(ConnectionSettings connectionOptions)
        {
            DataAccessProviderTypes dtOptionValue = connectionOptions.DatabaseType;
            if (dtOptionValue == DataAccessProviderTypes.MySql)
            {
                return new MySqlDbConnectionBuilder();
            }
            else if (connectionOptions.DatabaseType == DataAccessProviderTypes.SqlServer)
            {
                return new SqlDbConnectionBuilder();

            }
            else if (connectionOptions.DatabaseType == DataAccessProviderTypes.PostgreSql)
            {
                System.Collections.Generic.List<string> oL = new System.Collections.Generic.List<string>();
                oL.Add("Postgres support not activated in ADO Data Layer : ");
                throw new OptionsValidationException("ConnectionStrings::DatabaseType", typeof(DataAccessProviderTypes), oL);

            }
            else
            {

                System.Collections.Generic.List<string> oL = new System.Collections.Generic.List<string>();
                oL.Add("Invalid Option: " + nameof(dtOptionValue));
                throw new OptionsValidationException("ConnectionStrings::DatabaseType", typeof(DataAccessProviderTypes), oL);
            }
        }

    }
}
