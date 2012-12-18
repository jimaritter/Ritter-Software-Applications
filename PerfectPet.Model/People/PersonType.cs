using System;
using System.Collections.Generic;
using System.Linq;
using NHibernate;
using PerfectPet.Model.Repository;

namespace PerfectPet.Model.People
{
    public class PersonType : Business<PersonType>, IPersonType
    {
        private readonly IPersonType _personType;
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual DateTime CreatedDate { get; set; }
        protected ISession _session = null;

        public PersonType()
        {

        }

        public PersonType(IPersonType personType)
        {
            _personType = personType;
        }

        public PersonType Get()
        {
            return this;
        }

        public IList<PersonType> GetAll()
        {
            try
            {
                if (_session == null)
                {
                    _session = SessionManager.OpenSession();
                }
                var persontypelist = _session.CreateCriteria(typeof(PersonType)).List<PersonType>();
                return persontypelist;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public PersonType GetById(int id)
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                try
                {
                    repository.BeginTransaction();
                    var persontype = repository.GetById(typeof(PersonType),id);
                    repository.CommitTransaction();
                    return persontype as PersonType;
                }
                catch (Exception)
                {
                    repository.RollbackTransaction();
                    return null;
                }
            }
        }

        public IEnumerable<PersonType> GetAllById(int id)
        {
            try
            {
                if (_session == null)
                {
                    _session = SessionManager.OpenSession();
                }
                var persontypelist = _session.CreateCriteria(typeof(PersonType)).List<PersonType>();

                IEnumerable<PersonType> personlist = from p in persontypelist
                                                     where p.Id == id
                                                     orderby p.Name
                                                     select p;

                return personlist;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Save(PersonType phoneType)
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                try
                {
                    repository.BeginTransaction();
                    repository.Save(phoneType);
                    repository.CommitTransaction();
                }
                catch (Exception)
                {
                    repository.RollbackTransaction();
                    throw;
                }
            }
        }

        public void Delete(PersonType phoneType)
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                try
                {
                    repository.BeginTransaction();
                    repository.Delete(phoneType);
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
