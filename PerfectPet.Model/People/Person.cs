using System;
using System.Collections.Generic;
using System.Linq;
using NHibernate;
using PerfectPet.Model.Addresses;
using PerfectPet.Model.Pets;
using PerfectPet.Model.Phones;
using PerfectPet.Model.Repository;

namespace PerfectPet.Model.People
{
    public class Person : Entity<Person>, IPerson
    {
        private readonly IPerson _person;
        public virtual int Id { get; private set; }
        public string Number { get; set; }
        public string Salutation { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string MiddleName { get; set; }
        public virtual string LastName { get; set; }
        public virtual string Email { get; set; }
        public virtual string Notes { get; set; }
        public virtual string Type { get; set; }
        public virtual double Discount { get; set; }
        public virtual double Balance { get; set; }
        public virtual string Phone { get; set; }
        public virtual string Mobile { get; set; }
        public virtual string Fax { get; set; }
        public virtual IList<Address> Addresses { get; private set; }
        public virtual IList<Pet> Pets { get; private set; }
        public virtual bool Active { get; set; }
        public virtual DateTime CreatedDate { get; set; }
        public virtual DateTime? ModifiedDate { get; set; }
        protected ISession _session = null;

        public Person()
        {
            
        }

        //public Person(IPerson person)
        //{
        //    _person = person;
        //}


        public Person Get()
        {
            return new Person();
        }

        public IList<Person> GetAll()
        {
            try
            {
                if(_session == null)
                {
                    _session = SessionManager.OpenSession();
                }
                var personlist = _session.CreateCriteria(typeof(Person)).List<Person>();
                return personlist;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public Person GetById(int id)
        {
            using(RepositoryBase repository = new RepositoryBase())
            {
                try
                {
                    repository.BeginTransaction();
                    var person = repository.GetById(typeof(Person), id);
                    repository.CommitTransaction();

                    return person as Person;
                }
                catch (Exception)
                {
                    repository.RollbackTransaction();
                    throw;
                }
            }
        }

        public void Save(Person person)
        {
            using(RepositoryBase repository = new RepositoryBase())
            {
                try
                {
                    repository.BeginTransaction();
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

        public void Delete(Person person)
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                try
                {
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

        public IEnumerable<Person> ManagerList(string persontype)
        {
            try
            {
                if (_session == null)
                {
                    _session = SessionManager.OpenSession();
                }
                var personlist = _session.CreateCriteria(typeof(Person)).List<Person>();

                var query = from persons in personlist
                            where persons.Type == persontype
                            select persons;

                return query;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public IEnumerable<Person> EmployeeList(string persontype)
        {
            try
            {
                if (_session == null)
                {
                    _session = SessionManager.OpenSession();
                }
                var personlist = _session.CreateCriteria(typeof(Person)).List<Person>();

                var query = from persons in personlist
                            where persons.Type == persontype
                            select persons;

                return query;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IEnumerable<Person> CustomerList(string persontype)
        {
            try
            {
                if (_session == null)
                {
                    _session = SessionManager.OpenSession();
                }
                var personlist = _session.CreateCriteria(typeof(Person)).List<Person>();

                var query = from persons in personlist
                            where persons.Type == persontype
                            select persons;

                return query;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
