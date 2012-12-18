using System;
using System.Collections.Generic;
using NodaTime;

namespace VetMed.Model.Adresses
{
    public class Address : IAddress
    {
        private IAddress _address;
        private int _id;
        private string _street;
        private string _city;
        private string _state;
        private int _postalCode;
        private string _country;
        private AddressType _addressType;
        private int _addedBy;
        private string _addedDate;
        private int _modifiedBy;
        private string _modifiedDate;

        public Address()
        {
            
        }

        public Address(IAddress address)
        {
            this._address = address;
        }

        public virtual int Id { get; private set; }
        public virtual string Street { get { return _street; } set { value = _street; } }
        public virtual string City { get { return _city; } set { value = _city; } }
        public virtual string State { get { return _state; } set { value = _state; } }
        public virtual int PostalCode { get { return _postalCode; } set { value = _postalCode; } }
        public virtual string Country { get { return _country; } set { value = _country; } }
        public virtual AddressType AddressType { get { return _addressType; } set { value = _addressType; } }
        public virtual int AddedBy { get { return _addedBy; } set { value = _addedBy; } }
        public virtual string AddedDate { get { return _addedDate; } set { value = _addedDate; } }
        public virtual int ModifiedBy { get { return _modifiedBy; } set { value = _modifiedBy; } }
        public virtual string ModifiedDate { get { return _modifiedDate; } set { value = _modifiedDate; } }

        public IList<Address> GetAll()
        {
            throw new NotImplementedException();
        }

        public Address GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Address GetByAddedDate(DateTimeZone dateTimeZone)
        {
            throw new NotImplementedException();
        }

        public Address GetByAddedBy(int id)
        {
            throw new NotImplementedException();
        }

        public Address Save(Address address)
        {
            throw new NotImplementedException();
        }

        public void Delete(Address address)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return this.Street + " " + this.AddedDate.ToString();
        }

    }
}
