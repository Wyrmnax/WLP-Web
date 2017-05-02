using System;
using wwlp.Domain.Interfaces.Repository;

namespace wwlp.Infra.Data.Repositories
{
    public class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class
    {

        // protected DataContext DB = new DataContext();

        public void Dispose()
        {
            
        }
    }
}
