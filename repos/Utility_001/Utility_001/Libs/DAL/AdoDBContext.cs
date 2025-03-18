/*using Microsoft.AspNetCore.Connections;
using System.Data;

namespace Utility_001.Libs.DAL
{
    public class AdoDBContext : IDisposable
    {

        private readonly IDbConnection _connection;
        private readonly IConnectionFactory _connectionFactory;
        private readonly ReaderWriterLockSlim _rwLock = new ReaderWriterLockSlim();
        private readonly LinkedList<AdoNetUnitOfWork> _uows = new LinkedList<AdoNetUnitOfWork>();

        private readonly string _connectionString;

 *//*       public AdoDBContext(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }*//*

        public AdoDBContext(IConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;

            _connection = _connectionFactory.Create();
        }
        public AdoDBContext(IConnectionFactory connectionFactory, string connectionName)
        {
            _connectionFactory = connectionFactory;
            _connection =  _connectionFactory.Create(connectionName);
        }
        public void Dispose()
        {
            try
            {
                if (_connection != null)
                    _connection.Dispose();
            }
            catch (System.Exception)
            {


            }

        }
        public IUnitOfWork CreateUnitOfWork()
        {
            var transaction = _connection.BeginTransaction();
            var uow = new AdoNetUnitOfWork(transaction, RemoveTransaction, RemoveTransaction);

            _rwLock.EnterWriteLock();
            _uows.AddLast(uow);
            _rwLock.ExitWriteLock();

            return (IUnitOfWork)uow;
        }
        public IDbCommand CreateCommand()
        {
            var cmd = _connection.CreateCommand();

            _rwLock.EnterReadLock();
            if (_uows.Count > 0)
                cmd.Transaction = _uows.First.Value.Transaction;
            _rwLock.ExitReadLock();
            cmd.CommandTimeout = 240;
            // cmd.CommandTimeout = Convert.ToInt32(System.Configuration.ConfigurationManager.AppSettings["DBCommandTimeOut"]);

            return cmd;
        }
        public IDbDataAdapter GetDataAdapter(IDbCommand command)
        {
            return _connectionFactory.GetDataAdapter(command);
        }
        private void RemoveTransaction(AdoNetUnitOfWork obj)
        {
            _rwLock.EnterWriteLock();
            _uows.Remove(obj);
            _rwLock.ExitWriteLock();
        }
    }
}
*/


using Microsoft.AspNetCore.Connections;
using System.Data;

namespace Utility_001.Libs.DAL
{
    public class AdoDBContext : IDisposable
    {
        private readonly IDbConnection _connection;
        private readonly IConnectionFactory _connectionFactory;
        private readonly ReaderWriterLockSlim _rwLock = new ReaderWriterLockSlim();
        private readonly LinkedList<AdoNetUnitOfWork> _uows = new LinkedList<AdoNetUnitOfWork>();
        private readonly string _connectionString;

        private bool _disposed = false;

        // Constructor using IConnectionFactory
        public AdoDBContext(IConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
            _connection = _connectionFactory.Create();
        }

        // Constructor using IConnectionFactory with connectionName
        public AdoDBContext(IConnectionFactory connectionFactory, string connectionName)
        {
            _connectionFactory = connectionFactory;
            _connection = _connectionFactory.Create(connectionName);
        }

        // Dispose method to clean up resources
        public void Dispose()
        {
            if (!_disposed)
            {
                try
                {
                    _connection?.Dispose();
                }
                catch (Exception ex)
                {
                    // Optionally log the exception here for debugging
                    Console.WriteLine("Error during Dispose: " + ex.Message);
                }
                _disposed = true;
            }
        }

        // Create a UnitOfWork
        public IUnitOfWork CreateUnitOfWork()
        {
            var transaction = _connection.BeginTransaction();
            var uow = new AdoNetUnitOfWork(transaction, RemoveTransaction, RemoveTransaction);

            _rwLock.EnterWriteLock();
            _uows.AddLast(uow);
            _rwLock.ExitWriteLock();

            return (IUnitOfWork)uow;
        }

        // Create a database command
        public IDbCommand CreateCommand()
        {
            var cmd = _connection.CreateCommand();

            _rwLock.EnterReadLock();
            if (_uows.Count > 0)
                cmd.Transaction = _uows.First.Value.Transaction;
            _rwLock.ExitReadLock();

            // Configuring command timeout from a configurable source (optional)
            // For example, getting it from configuration
            int commandTimeout = 240; // default value
            if (int.TryParse(System.Configuration.ConfigurationManager.AppSettings["DBCommandTimeOut"], out int configuredTimeout))
            {
                commandTimeout = configuredTimeout;
            }
            cmd.CommandTimeout = commandTimeout;

            return cmd;
        }

        // Get data adapter for a command
        public IDbDataAdapter GetDataAdapter(IDbCommand command)
        {
            return _connectionFactory.GetDataAdapter(command);
        }

        // Remove a UnitOfWork from the list
        private void RemoveTransaction(AdoNetUnitOfWork obj)
        {
            _rwLock.EnterWriteLock();
            _uows.Remove(obj);
            _rwLock.ExitWriteLock();
        }
    }
}
