using System.Collections.Generic;
using wwlp.Domain.Entities;

namespace wwlp.Domain.Interfaces.Repository
{
    public interface IUserRepository : IRepositoryBase<User>
    {
        IEnumerable<User> GetByFilter();
    }
}