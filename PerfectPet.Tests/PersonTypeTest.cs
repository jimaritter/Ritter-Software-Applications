using System;
using NHibernate;
using NUnit.Framework;
using PerfectPet.Model.People;
using PerfectPet.Model.Repository;

namespace PerfectPet.Tests
{
    [TestFixture]
    public class PersonTypeTest
    {
        protected ISession _session = null;
        private IPersonType _personType;

        [SetUp]
        public void Init()
        {
            _personType = new PersonType();
            _session = SessionManager.OpenSession();
        }

        [Test]
        public void can_get_list_of_persontype()
        {
            try
            {
                var persontype = _session.CreateCriteria(typeof(PersonType)).List<PersonType>();
                foreach (var a in persontype)
                {
                    Console.WriteLine(a.Name);
                }
            }
            catch (Exception)
            {
                
                throw;
            }     
        }

        [Test]
        public void can_get_list_of_persontype_by_id()
        {
            try
            {
                var persontype = _personType.GetAllById(1002);
                if (persontype != null)
                {
                    foreach (var a in persontype)
                    {
                        Console.WriteLine(a.Name);
                    }                    
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        [Test]
        public void can_create_new_persontype()
        {
            using(RepositoryBase repository = new RepositoryBase())
            {
                try
                {
                    repository.BeginTransaction();
                    var persontype = _personType.Get();
                    persontype.Name = "Owner";
                    persontype.CreatedDate = DateTime.Now;
                    repository.Save(persontype);
                    repository.CommitTransaction();
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                    repository.RollbackTransaction();
                    throw;
                }
            }
        }

        [TearDown]
        public void Cleanup()
        {
            
        }
    }
}
