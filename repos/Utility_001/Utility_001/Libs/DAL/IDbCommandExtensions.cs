
using Microsoft.AspNetCore.Mvc.Infrastructure;
using System.Data;
using System.Runtime.CompilerServices;

namespace Utility_001.Libs.DAL
{
    public static class IDbCommandExtensions
    {
        public static IDbDataParameter CreateParameter(this IDbCommand command , string name, object value ) {
            var parameter = command.CreateParameter();
            parameter.ParameterName = name;
            parameter.Value = value;
            return parameter;
        }

        public static IDbDataParameter CreateParameter(this IDbCommand command, string name, object value,DbType ParamType)
        {
            var parameter = command.CreateParameter();
            parameter.ParameterName = name;
            parameter.Value = value;
            parameter.DbType = ParamType;
            return parameter;
        }


        public static IDbDataParameter CreateParameter(this IDbCommand command, string name, object value,DbType ParamType, ParameterDirection direction)
        {
            var parameter = command.CreateParameter();
            parameter.ParameterName = name;
            parameter.Value = value;
            parameter.DbType = ParamType;
            parameter.Direction = direction;
            return parameter;
        }

    }
}
