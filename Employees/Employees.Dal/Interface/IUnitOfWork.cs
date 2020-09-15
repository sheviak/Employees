using System;

namespace Employees.Dal.Interface
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<T> Repository<T>() where T : class;
        void Save();
    }
}