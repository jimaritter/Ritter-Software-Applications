using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CherishedPetBoarding.Model.Repository;
using NHibernate;

namespace CherishedPetBoarding.Model.Addresses
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
            throw new NotImplementedException();
        }

        public void Delete(AddressType addressType)
        {
            throw new NotImplementedException();
        }
    }
}
