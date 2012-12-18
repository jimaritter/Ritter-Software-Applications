using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CherishedPetBoarding.Model.Addresses;
using CherishedPetBoarding.Model.Common;
using CherishedPetBoarding.Model.People;
using CherishedPetBoarding.Model.Repository;
using NHibernate;
using NUnit.Framework;

namespace CherishedPetBoarding.Test
{
    [TestFixture]
    public class AddressTest
    {
        protected ISession _session = null;
        private Address _address;
        private DateTime _addedDate = DateTime.Now;

        [SetUp]
        public void Init()
        {
            _address = new Address();
            _session = SessionManager.OpenSession();
        }

        [Test]
        public void can_get_list_of_addresstype()
        {
            try
            {
                var addresstype = _session.CreateCriteria(typeof(AddressType)).List<AddressType>();
                foreach (var a in addresstype)
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
        public void can_get_list_of_addresses_by_id()
        {
            try
            {
                var address = _address.GetAllById(1002);
                if (address != null)
                {
                    foreach (var a in address)
                    {
                        Console.WriteLine(a.City);
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        [Test]
        public void can_add_new_address()
        {
            using(RepositoryBase repository = new RepositoryBase())
            {
                try
                {
                    _address = _address.Get();
                    _address.Active = true;
                    _address.CreatedDate = _addedDate;
                    _address.Street = "5045 N. Susquehanna Trail";
                    _address.City = "York";   
                    _address.StateId = (int) States.PA;
                    _address.Zip = "17406";
                    //_address.Type = (int) AddressType.Home;
                    _address.Person = repository.GetById(typeof (Person), 1002) as Person;
                    repository.BeginTransaction();
                    repository.Save(_address);
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
        public void can_delete_address()
        {
            using(RepositoryBase repository = new RepositoryBase())
            {
                try
                {
                    _address = repository.GetById(typeof (Address), 3006) as Address;
                    repository.Delete(_address);
                }
                catch (Exception)
                {
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
