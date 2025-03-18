using Microsoft.Data.SqlClient;
using System.Data.Common;
using Utility_001.Libs.Utilities;
using Utility_001.Libs.Constants;
using MySql.Data.MySqlClient;

using System;
namespace Utility_001.Libs.DAL
{
    public static class DataAccessProviderHelper
    {

        public static DbProviderFactory GetDbProviderFactory(string dbProviderFactoryTypename, string assemblyName)
        {
            var instance = ReflectionsUtils.GetStaticProperty(dbProviderFactoryTypename, "Instance");
            if (instance == null)
            {
                var a = ReflectionsUtils.LoadAssembly(assemblyName);
                if (a != null)
                    instance = ReflectionsUtils.GetStaticProperty(dbProviderFactoryTypename, "Instance");
            }
            if (instance == null)
                throw new InvalidOperationException(string.Format("Unable ToRetrieve DbProviderFactory Form {0}", dbProviderFactoryTypename));

            return instance as DbProviderFactory;
        }
        public static DbProviderFactory GetDbProviderFactory(DataAccessProviderTypes type)
        {
            if (type == DataAccessProviderTypes.SqlServer)
                return System.Data.SqlClient.SqlClientFactory.Instance; // this library has a ref to SqlClient so this works
                                                  //return GetDbProviderFactory("System.Data.SQLiteFactory", "System.Data.SqlClient");
            if (type == DataAccessProviderTypes.SqLite)
            {
#if NETFULL
        return GetDbProviderFactory("System.Data.SQLite.SQLiteFactory", "System.Data.SQLite");
#else
                return GetDbProviderFactory("Microsoft.Data.Sqlite.SqliteFactory", "Microsoft.Data.Sqlite");
#endif
            }
            if (type == DataAccessProviderTypes.MySql)
                //return GetDbProviderFactory("MySql.Data.MySqlClient.MySqlClientFactory", "MySql.Data");
                return MySql.Data.MySqlClient.MySqlClientFactory.Instance;
            if (type == DataAccessProviderTypes.PostgreSql)
                return GetDbProviderFactory("Npgsql.NpgsqlFactory", "Npgsql");
#if NETFULL
if (type == DataAccessProviderTypes.OleDb)
        return System.Data.OleDb.OleDbFactory.Instance;
    if (type == DataAccessProviderTypes.SqlServerCompact)
        return DbProviderFactories.GetFactory("System.Data.SqlServerCe.4.0");                
#endif

            throw new NotSupportedException(string.Format("Unsupported Provider {0}", type.ToString()));
        }
        public static DbProviderFactory GetDbProviderFactory(string providerName)
        {
#if NETFULL
    return DbProviderFactories.GetFactory(providerName);
#else
            var providername = providerName.ToLower();

            if (providerName == "system.data.sqlclient")
                return GetDbProviderFactory(DataAccessProviderTypes.SqlServer);
            if (providerName == "system.data.sqlite" || providerName == "microsoft.data.sqlite")
                return GetDbProviderFactory(DataAccessProviderTypes.SqLite);

        if (providerName == "mysql.data.mysqlclient" || providername == "mysql.data")
                return GetDbProviderFactory(DataAccessProviderTypes.MySql);
            if (providerName == "npgsql")
                return GetDbProviderFactory(DataAccessProviderTypes.PostgreSql);
            throw new NotSupportedException(string.Format("Unsupported provided : {0} ", providerName));
#endif
        }
    }
}
