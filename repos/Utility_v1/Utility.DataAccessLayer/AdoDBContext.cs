using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utility.DataAccessLayer
{
    public class AdoDBContext : IDisposable
    {
        private readonly IDbConnection _connection;
        private IDbConnectionFactory _connectionFactory;
        private readonly ReaderWriterLockSlim _lock = new ReaderWriterLockSlim();
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
