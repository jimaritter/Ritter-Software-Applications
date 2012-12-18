using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetMed.Model.Users
{
    public class User : IUser
    {
        private readonly IUser _user;
        private int _id;
        private string _firstName;
        private string _middleName;
        private string _lastName;

        public User()
        {
            
        }

        public User(IUser user)
        {
            _user = user;
        }
    }
}
