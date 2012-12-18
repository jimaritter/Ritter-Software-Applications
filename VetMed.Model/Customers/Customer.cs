using System.Collections.Generic;
using VetMed.Model.Adresses;
using VetMed.Model.Emails;
using VetMed.Model.Phones;

namespace VetMed.Model.Customers
{
    public class Customer
    {
        private readonly ICustomer _customer;
        private int _id;
        private string _name;
        private List<Address> _addresses;
        private List<Email> _emails;
        private List<Phone> _phones; 
        private bool _active;
        private int _addedBy;
        private string _addedDate;
        private int _modifiedBy;
        private string _modifiedDate;

        public Customer()
        {
            
        }

        public Customer(ICustomer customer)
        {
            _customer = customer;
        }

        public virtual int Id { get; private set; }
        public virtual string Name { get { return _name; } set { value = _name; } }
        public virtual bool Active { get { return _active; } set { value = _active; } }
        public virtual List<Address> Addresses { get { return _addresses; } set { value = _addresses; } }
        public virtual List<Email> Emails { get { return _emails; } set { value = _emails; } }
        public virtual List<Phone> Phones { get { return _phones; } set { value = _phones; } } 
        public virtual int AddedBy { get { return _addedBy; } set { value = _addedBy; } }
        public virtual string AddedDate { get { return _addedDate; } set { value = _addedDate; } }
        public virtual int ModifiedBy { get { return _modifiedBy; } set { value = _modifiedBy; } }
        public virtual string ModifiedDate { get { return _modifiedDate; } set { value = _modifiedDate; } }
    }
}
