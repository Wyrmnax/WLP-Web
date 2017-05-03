namespace wwlp.Application.Interfaces
{
    public interface IAppObjectsBase<TEntity> where TEntity : class
    {
        void Dispose();
    }
}