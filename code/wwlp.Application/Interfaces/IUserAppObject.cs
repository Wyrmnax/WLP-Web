using System.Collections.Generic;
using wwlp.Domain.Entities;

namespace wwlp.Application.Interfaces
{
    public interface IUserAppObject : IAppObjectsBase<User>
    {
        IEnumerable<User> GetByFilter();
    }
}