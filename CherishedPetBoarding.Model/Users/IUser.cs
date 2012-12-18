using System.Collections.Generic;

namespace CherishedPetBoarding.Model.Users
{
    public interface IUser
    {
        User Get();
        IList<User> GetAll();
        void Add(User user);
        void Delete(User user);
    }
}