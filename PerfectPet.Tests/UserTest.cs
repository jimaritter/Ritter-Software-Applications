using System;
using NUnit.Framework;
using PerfectPet.Model.People;
using PerfectPet.Model.Repository;
using PerfectPet.Model.Users;

namespace PerfectPet.Tests
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
