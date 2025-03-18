using System.Data;
using System;
using System.Collections.Generic;


namespace Utility_001.Libs.DAL
{
    public class AdoNetUnitOfWork
    {
        private IDbTransaction _transaction;
        private readonly Action<AdoNetUnitOfWork> _rolledBack;
        private readonly Action<AdoNetUnitOfWork> _committed;
        public AdoNetUnitOfWork(IDbTransaction transaction, Action<AdoNetUnitOfWork> rolledBack, Action<AdoNetUnitOfWork> committed)
        {
            Transaction = transaction;
            _transaction = transaction;
            _rolledBack = rolledBack;
            _committed = committed;
        }
        public IDbTransaction Transaction { get; private set; }

        public void Dispose()
        {
            if (_transaction == null)
                return;

            _transaction.Rollback();
            _transaction.Dispose();
            _rolledBack(this);
            _transaction = null;
        }
        public void SaveChanges()
        {
            if (_transaction == null)
                throw new InvalidOperationException("Do not call save changes twice.");

            _transaction.Commit();
            _committed(this);
            _transaction = null;
        }
    }
}
