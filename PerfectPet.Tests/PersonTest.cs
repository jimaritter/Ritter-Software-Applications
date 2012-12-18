using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using PerfectPet.Model.Addresses;
using PerfectPet.Model.People;
using PerfectPet.Model.Pets;
using PerfectPet.Model.Phones;
using PerfectPet.Model.Repository;

namespace PerfectPet.Tests
{
    [TestFixture]
    public class PersonTest
    {
        private IPerson _person;
        private IAddress _address;
        private IPhone _phone;
        private IPet _pet;
        private IPersonType _personType;

        private DateTime _addedDate = DateTime.Now;    
            
        [SetUp]
        public void Init()
        {
            _address = new Address();
            _person = new Person();
            _personType = new PersonType();
        }

        [Test]
        public void can_add_new_person()
        {
           using(RepositoryBase repository = new RepositoryBase())
            {
                try
                {
                    var person = _person.Get();
                    person.FirstName = "Jim";
                    person.MiddleName = "A.";
                    person.LastName = "Ritter";
                    person.Active = true;
                    person.CreatedDate = _addedDate;
                   // person.Type = (int) PersonType.Family;                  
                    repository.BeginTransaction();
                    repository.Save(person);
                    repository.CommitTransaction();
                }
                catch (Exception exception)
                {
                    repository.RollbackTransaction();
                    throw;
                }
            }
        }

        [Test]
        public void can_update_person()
        {
            using(RepositoryBase repository = new RepositoryBase())
            {
                try
                {
                    repository.BeginTransaction();
                    Person person = repository.GetById(typeof(Person), 1002) as Person;
                    person.MiddleName = "Andrew";
                    repository.Save(person);
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
        public void can_delete_person()
        {
            using(RepositoryBase repository = new RepositoryBase())
            {
                try
                {
                    var person = repository.GetById(typeof (Person), 2004);
                    repository.BeginTransaction();
                    repository.Delete(person);
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
        public void can_get_person_with_address_and_phone()
        {
            try
            {
                var people = _person.GetAll();

                var query = from person in people
                            select new {Id = person.Id, Name = person.FirstName};

                foreach (var t in query)
                {
                    Console.WriteLine(t.Id + " - " + t.Name);
                }

                foreach (var person in people)
                {
      

                    foreach (var address in person.Addresses)
                    {
                        Console.WriteLine(address.Street + " - " + person.FirstName);
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }  
        }

        [TearDown]
        public void CleanUp()
        {

        }
    }
}
