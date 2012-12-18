using System;
using System.Collections.Generic;
using System.Linq;
using NHibernate;
using PerfectPet.Model.People;
using PerfectPet.Model.Repository;

namespace PerfectPet.Model.Addresses
{
    public class Address : Business<Address>, IAddress
    {
        private readonly IAddress _address;
        private readonly IPerson _person;
        protected ISession _session = null;

        public Address()
        {
  
        }

        //public Address(IAddress address, IPerson person)
        //{
        //    _address = address;
        //    _person = person;
        //}

        public virtual int Id { get; set; }
        public virtual bool Active { get; set; }
        public virtual string Type { get; set; }
        public virtual string Street { get; set; }
        public virtual string City { get; set; }
        public virtual string Zip { get; set; }
        public virtual string State { get; set; }
        public virtual Person Person { get; set; }
        public virtual DateTime CreatedDate { get; set; }
        public virtual DateTime? ModifiedDate { get; set; }

        public Address GetById(int id)
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                try
                {
                    repository.BeginTransaction();
                    var address = repository.GetById(typeof(Address), id);
                    repository.CommitTransaction();

                    return address as Address;
                }
                catch (Exception)
                {
                    repository.RollbackTransaction();
                    throw;
                }
            }
        }

        public Address Get()
        {
            return new Address();
        }

        public IList<Address> GetAll()
        {
            try
            {
                if (_session == null)
                {
                    _session = SessionManager.OpenSession();
                }
                var addresslist = _session.CreateCriteria(typeof(Address)).List<Address>();
                return addresslist;
            }
            catch (Exception)
            {

                throw;
            }
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
                                                       select p;

                return addresses;

            }
            catch (Exception)
            {

                throw;
            }            
        }

        public IEnumerable<Address> GetByPersonId(int personid)
        {
            try
            {
                if (_session == null)
                {
                    _session = SessionManager.OpenSession();
                }
                var addressList = _session.CreateCriteria(typeof(Address)).List<Address>();

                IEnumerable<Address> addresses = from p in addressList
                                                 where p.Person.Id == personid
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
            using (RepositoryBase repository = new RepositoryBase())
            {
                try
                {
                    repository.BeginTransaction();
                    repository.Save(address);
                    repository.CommitTransaction();
                }
                catch (Exception)
                {
                    repository.RollbackTransaction();
                    throw;
                }
            }
        }

        public void Delete(Address address)
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                try
                {
                    repository.BeginTransaction();
                    repository.Delete(address);
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
