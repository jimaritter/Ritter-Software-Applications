using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CherishedPetBoarding.Model.People;
using CherishedPetBoarding.Model.Repository;
using CherishedPetBoarding.Model.Users;
using NHibernate;

namespace CherishedPetBoarding.Model.Addresses
{
    public class Address : Business<Address>, IAddress
    {
        private readonly IAddress _address;
        protected ISession _session = null;

        public Address()
        {
  
        }

        public Address(IAddress address)
        {
            _address = address;
        }

        public int Id { get; private set; }
        public virtual bool Active { get; set; }
        public virtual int Type { get; set; }
        public virtual string Street { get; set; }
        public virtual string City { get; set; }
        public virtual string Zip { get; set; }
        public virtual int StateId { get; set; }
        public virtual Person Person { get; set; }
        public virtual DateTime CreatedDate { get; set; }
        public virtual DateTime? ModifiedDate { get; set; }

        public Address GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Address Get()
        {
            return this;
        }

        public IList<Address> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Address> GetAllById(int id)
        {
            try
            {
                if (_session == null)
                {
                    _session = SessionManager.OpenSession();
                }
                var addressList = _session.CreateCriteria(typeof(Address)).List<Address>();

                IEnumerable<Address> addresses = from p in addressList
                                                       where p.Id == id
                                                       orderby p.Type
                                                       select p;

                return addresses;

            }
            catch (Exception)
            {

                throw;
            }            
        }

        public void Save(Address address)
        {
            throw new NotImplementedException();
        }

        public void Delete(Address address)
        {
            throw new NotImplementedException();
        }
    }
}
