using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VetMed.Model.Users;

namespace VetMed.Model.Shared
{
    public class SystemUser : ISystemUser
    {
        private readonly ISystemUser _systemUser;
        private int _id;
        private User _user;
        private int _accessLevel;
        private bool _active;

        public SystemUser()
        {
            
        }

        public SystemUser(ISystemUser systemUser)
        {
            _systemUser = systemUser;
        }

        public virtual int Id { get { return _id; } set { value = _id; } }
        public virtual User User { get { return _user; } set { value = _user; } }
        public virtual int AccessLevel { get { return _accessLevel; } set { value = _accessLevel; } }
        public virtual bool Active { get { return _active; } set { value = _active; } }

        public SystemUser GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<SystemUser> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(SystemUser systemUser)
        {
            throw new NotImplementedException();
        }

        public void Delete(SystemUser systemUser)
        {
            throw new NotImplementedException();
        }
    }
}
