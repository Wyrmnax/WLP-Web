using System.Collections.Generic;
using wwlp.Domain.Entities;

namespace wwlp.Domain.Interfaces.BusinessObject
{
    public interface IUserBO : IBusinessObjectBase<User>
    {
        IEnumerable<User> GetByFilter();
    }
}