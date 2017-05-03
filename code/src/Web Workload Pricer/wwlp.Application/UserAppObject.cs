using System;
using System.Collections.Generic;
using wwlp.Application.Interfaces;
using wwlp.Domain.Entities;
using wwlp.Domain.Interfaces.BusinessObject;

namespace wwlp.Application
{
    public class UserAppObject : AppObjectsBase<User>, IUserAppObject
    {
        private readonly IUserBO _userBusinessObject;

        public UserAppObject(IUserBO userBusinessObject)
            : base(userBusinessObject)
        {
            _userBusinessObject = userBusinessObject;
        }

        public IEnumerable<User> GetByFilter()
        {
            return _userBusinessObject.GetByFilter();
        }
    }
}