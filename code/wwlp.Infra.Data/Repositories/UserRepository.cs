using System;
using System.Collections.Generic;
using wwlp.Domain.Entities;
using wwlp.Domain.Interfaces.Repository;

namespace wwlp.Infra.Data.Repositories
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public IEnumerable<User> GetByFilter()
        {
            List<User> uList = new List<User>();
            User u = new User();
            u.Active = true;
            u.ID = 10;
            u.DataAdded = DateTime.Now;
            uList.Add(u);

            return uList;
        }
    }
}