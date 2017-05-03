using System;
using wwlp.Application.Interfaces;
using wwlp.Domain.Interfaces.BusinessObject;

namespace wwlp.Application
{
    public class AppObjectsBase<TEntity> : IDisposable, IAppObjectsBase<TEntity> where TEntity : class
    {
        private readonly IBusinessObjectBase<TEntity> _businessObjectBase;

        public AppObjectsBase(IBusinessObjectBase<TEntity> businessObjectBase)
        {
            _businessObjectBase = businessObjectBase;
        }

        public void Dispose()
        {
            _businessObjectBase.Dispose();
        }
    }
}
