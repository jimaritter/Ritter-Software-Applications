using System;
using System.Collections.Generic;
using System.Linq;
using NHibernate;
using PerfectPet.Model.People;
using PerfectPet.Model.Repository;

namespace PerfectPet.Model.Phones
{
    public class Phone :  Business<Phone>, IPhone
    {
        private readonly IPhone _phone;
        public virtual int Id { get; set; }
        public virtual string Number { get; set; }
        public virtual string Type { get; set; }
        public Person Person { get; set; }
        public virtual DateTime CreatedDate { get; set; }
        public virtual DateTime? ModifiedDate { get; set; }
        protected ISession _session = null;

        public Phone()
        {
            
        }

        public Phone Get()
        {
            return new Phone();
        }

        public IList<Phone> GetAll()
        {
            try
            {
                if (_session == null)
                {
                    _session = SessionManager.OpenSession();
                }
                var phonelist = _session.CreateCriteria(typeof(Phone)).List<Phone>();
                return phonelist;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Phone GetById(int id)
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                try
                {
                    repository.BeginTransaction();
                    var phone = repository.GetById(typeof(Phone), id);
                    repository.CommitTransaction();

                    return phone as Phone;
                }
                catch (Exception)
                {
                    repository.RollbackTransaction();
                    throw;
                }
            }
        }

        public IEnumerable<Phone> GetAllByPersonId(int personid)
        {
            try
            {
                if (_session == null)
                {
                    _session = SessionManager.OpenSession();
                }
                var petList = _session.CreateCriteria(typeof(Phone)).List<Phone>();

                IEnumerable<Phone> petlist = from p in petList
                                           where p.Person.Id == personid
                                           select p;

                return petlist;

            }
            catch (Exception)
            {
                return null;
            }   
        }

        public void Save(Phone phone)
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                try
                {
                    repository.BeginTransaction();
                    repository.Save(phone);
                    repository.CommitTransaction();
                }
                catch (Exception)
                {
                    repository.RollbackTransaction();
                    throw;
                }
            }
        }

        public void Delete(Phone phone)
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                try
                {
                    repository.BeginTransaction();
                    repository.Delete(phone);
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
