using System.Collections.Generic;

namespace PerfectPet.Model.Users
{
    public interface IUser
    {
        User Get();
        IList<User> GetAll();
        User GetById(int id);
        void Add(User user);
        void Delete(User user);
    }
}