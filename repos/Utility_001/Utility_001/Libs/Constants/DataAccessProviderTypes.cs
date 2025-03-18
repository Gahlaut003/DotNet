namespace Utility_001.Libs.Constants
{
    public enum DataAccessProviderTypes
    {
        MySql,
        SqlServer,
        SqLite,
       
        PostgreSql
#if NETFULL
OleDb,
SqlServerCompact
#endif
    }
}
