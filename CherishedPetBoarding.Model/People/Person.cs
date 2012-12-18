using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CherishedPetBoarding.Model.Addresses;
using CherishedPetBoarding.Model.Pets;
using CherishedPetBoarding.Model.Phones;
using CherishedPetBoarding.Model.Repository;
using CherishedPetBoarding.Model.Users;
using NHibernate;
using NHibernate.Criterion;

namespace CherishedPetBoarding.Model.People
{
    public class Person : Entity<Person>, IPerson
    {
        private readonly IPerson _person;
        public virtual int Id { get; private set; }
        public virtual string FirstName { get; set; }
        public virtual string MiddleName { get; set; }
        public virtual string LastName { get; set; }
        public virtual int Type { get; set; }
        public virtual IList<Address> Addresses { get; private set; }
        public virtual IList<Phone> Phones { get; private set; }
        public virtual IList<Pet> Pets { get; private set; }
        public virtual bool Active { get; set; }
        public virtual DateTime CreatedDate { get; set; }
        public virtual DateTime? ModifiedDate { get; set; }
        protected ISession _session = null;

        public Person()
        {
            
        }

        public Person(IPerson person)
        {
            _person = person;
        }


        public Person Get()
        {
            return this;
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
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }
    }
}
