using System;
using System.Collections.Generic;
using System.Linq;
using NHibernate;
using PerfectPet.Model.Repository;

namespace PerfectPet.Model.Phones
{
    public class PhoneType : Business<PhoneType>, IPhoneType
    {
        protected ISession _session = null;
        private readonly IPhoneType _phoneType;
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual DateTime CreatedDate { get; set; }

        public PhoneType()
        {
            
        }

        public PhoneType(IPhoneType phoneType)
        {
            _phoneType = phoneType;
        }

        public PhoneType Get()
        {
            return new PhoneType();
        }

        public IList<PhoneType> GetAll()
        {
            try
            {
                if (_session == null)
                {
                    _session = SessionManager.OpenSession();
                }
                var phonetypelist = _session.CreateCriteria(typeof(PhoneType)).List<PhoneType>();
                return phonetypelist;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IList<PhoneType> GetAllById(int id)
        {
            try
            {
                if (_session == null)
                {
                    _session = SessionManager.OpenSession();
                }
                var phonetypelist = _session.CreateCriteria(typeof(PhoneType)).List<PhoneType>();
                IEnumerable<PhoneType> phonelist = from p in phonetypelist
                                                 where p.Id == id
                                                 orderby p.Name
                                                 select p;

                return phonelist as IList<PhoneType>;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Save(PhoneType phoneType)
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

        public void Delete(PhoneType phoneType)
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
