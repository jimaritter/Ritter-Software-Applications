using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CherishedPetBoarding.Model.People;
using CherishedPetBoarding.Model.Repository;
using CherishedPetBoarding.Model.Users;
using NUnit.Framework;

namespace CherishedPetBoarding.Test
{
    [TestFixture]
    public class UserTest
    {
        private DateTime _addedDate = DateTime.Now;
        private IUser _user;
        [SetUp]
        public void Init()
        {
            _user = new User();
        }

        [Test]
        public void can_add_user()
        {
          using(RepositoryBase repository = new RepositoryBase())
          {
              try
              {
                  repository.BeginTransaction();
                  Person person = repository.GetById(typeof(Person), 1002) as Person;
                  var user = _user.Get();
                  user.Active = true;
                  user.CreatedDate = _addedDate;
                  user.RoleId = (int) Role.Administrator;
                  user.Person = person;
                  repository.Save(user);
                  repository.CommitTransaction();
              }
              catch (Exception)
              {
                  repository.RollbackTransaction();
                  throw;
              }
          }  
        }

        [Test]
        public void can_delete_user()
        {
            using(RepositoryBase repository = new RepositoryBase())
            {
                try
                {
                    repository.BeginTransaction();
                    var user = repository.GetById(typeof (User), 2004);
                    repository.Delete(user);
                    repository.CommitTransaction();
                }
                catch (Exception)
                {
                    repository.RollbackTransaction();
                    throw;
                }
            }
        }

    }
}
