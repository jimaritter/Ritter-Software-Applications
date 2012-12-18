using System;
using System.Collections.Generic;
using NHibernate;
using NUnit.Framework;
using PerfectPet.Model.Addresses;
using PerfectPet.Model.Common;
using PerfectPet.Model.People;
using PerfectPet.Model.Repository;

namespace PerfectPet.Tests
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
        public void can_get_list_of_addresses()
        {
            try
            {
                var addresses = _session.CreateCriteria(typeof(Address)).List<Address>();
                foreach (var a in addresses)
                {
                    Console.WriteLine(a.Person.Id);
                    Person p = a.Person;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        [Test]
        public void can_get_list_of_addresses_by_person()
        {
            try
            {
                IEnumerable<Address> address = _address.GetByPersonId(2004);
                foreach (var a in address)
                {
                    Console.WriteLine(a.Street);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        [Test]
        public void can_get_address()
        {
            try
            {
                Address address = _session.Get(typeof(Address), 7014) as Address;
                Person p = address.Person;
                Console.WriteLine(p.FirstName);
            }
            catch (Exception)
            {

                throw;
            }
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
                    _address.Street = "40 Test Road";
                    _address.City = "York";   
                    _address.State = Enum.GetName(typeof(AddressTypeList),States.PA);
                    _address.Zip = "17406";
                    //_address.Type = (int) AddressType.Home;
                    _address.Person = repository.GetById(typeof(Person), 1002) as Person;
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
