using System;
namespace Utility_001.Libs.DAL
{
    public interface IUnitOfWork:IDisposable
    {
        void SaveChanges();
    }
}
