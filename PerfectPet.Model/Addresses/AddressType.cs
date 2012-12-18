using System;
using System.Collections.Generic;
using System.Linq;
using NHibernate;
using PerfectPet.Model.Repository;

namespace PerfectPet.Model.Addresses
{
    public class AddressType : Business<AddressType>, IAddressType
    {
        private readonly IAddressType _addressType;
        protected ISession _session = null;
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual DateTime CreatedDate { get; set; }

        public AddressType()
        {
            
        }

        public AddressType(IAddressType addressType)
        {
            _addressType = addressType;
        }

        public AddressType Get()
        {
            return this;
        }

        public IList<AddressType> GetAll()
        {
            try
            {
                if (_session == null)
                {
                    _session = SessionManager.OpenSession();
                }
                var addressTypelist = _session.CreateCriteria(typeof(AddressType)).List<AddressType>();
                return addressTypelist;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IEnumerable<AddressType> GetAllById(int id)
        {
            try
            {
                if (_session == null)
                {
                    _session = SessionManager.OpenSession();
                }
                var addressTypelist = _session.CreateCriteria(typeof(AddressType)).List<AddressType>();

                IEnumerable<AddressType> addresslist = from p in addressTypelist
                                                   where p.Id == id
                                                   orderby p.Name
                                                   select p;

                return addresslist;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public AddressType GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Save(AddressType addressType)
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                try
                {
                    repository.BeginTransaction();
                    repository.Save(addressType);
                    repository.CommitTransaction();
                }
                catch (Exception)
                {
                    repository.RollbackTransaction();
                    throw;
                }
            }
        }

        public void Delete(AddressType addressType)
        {
            using(RepositoryBase repository = new RepositoryBase())
            {
                try
                {
                    repository.BeginTransaction();
                    repository.Delete(addressType);
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
