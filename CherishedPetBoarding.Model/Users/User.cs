using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CherishedPetBoarding.Model.People;
using CherishedPetBoarding.Model.Repository;

namespace CherishedPetBoarding.Model.Users
{
    public class User : Business<User>, IUser
    {
        private readonly IUser _user;

        public virtual int Id { get; set; }
        public virtual Person Person { get; set; }
        public virtual bool Active { get; set; }
        public virtual int RoleId { get; set; }
        public virtual DateTime CreatedDate { get; set; }
        public virtual DateTime? ModifiedDate { get; set; }

        public User()
        {
            
        }

        public User(IUser user)
        {
            _user = user;
        }

        public User Get()
        {
            return this;
        }

        public IList<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Add(User user)
        {
            throw new NotImplementedException();
        }

        public void Delete(User user)
        {
            throw new NotImplementedException();
        }
    }
}
