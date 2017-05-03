using wwlp.Domain.Interfaces.Repository;

namespace wwlp.Domain.Interfaces.BusinessObject
{
    public interface IBusinessObjectBase<TEntity> where TEntity : class
    {
        void Dispose();
    }
}