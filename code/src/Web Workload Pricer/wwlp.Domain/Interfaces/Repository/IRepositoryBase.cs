using System;
using System.Collections.Generic;
using System.Text;

namespace wwlp.Domain.Interfaces.Repository
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        void Dispose();
    }
}
