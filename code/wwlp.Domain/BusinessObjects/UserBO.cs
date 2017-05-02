using System;
using System.Collections.Generic;
using wwlp.Domain.Entities;
using wwlp.Domain.Interfaces.BusinessObject;
using wwlp.Domain.Interfaces.Repository;

namespace wwlp.Domain.BusinessObjects
{
    public class UserBO : BusinessObjectBase<User>, IUserBO
    {
        private readonly IUserRepository _userRepository;

        public UserBO(IUserRepository userRepository)
            : base(userRepository)
        {
            _userRepository = userRepository;
        }

        public IEnumerable<User> GetByFilter()
        {
            return _userRepository.GetByFilter();
        }
    }
}