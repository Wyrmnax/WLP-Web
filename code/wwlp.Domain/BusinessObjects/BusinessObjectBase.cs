using System;
using wwlp.Domain.Interfaces.Repository;

namespace wwlp.Domain.Interfaces.BusinessObject
{
    public class BusinessObjectBase<TEntity> : IDisposable, IBusinessObjectBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> _repository;

        public BusinessObjectBase(IRepositoryBase<TEntity> repository)
        {
            _repository = repository;
        }

        public void Dispose()
        {
            _repository.Dispose();
        }
    }
}