using System.Collections.Generic;
using VetMed.Model.Adresses;
using VetMed.Model.Pets;
using VetMed.Model.Phones;

namespace VetMed.Model.Persons 
{
    public class Person : IPerson
    {
        private readonly IPerson _person;
        private int _id;
        private string _firstName;
        private string _middleName;
        private string _lastName;
        private PersonType _personType;
        private IList<Address> _addresses;
        private IList<Phone> _phones;
        private IList<Pet> _pets;
        private bool _active;
        private int _addedBy;
        private string _addedDate;
        private int _modifiedBy;
        private string _modifiedDate;

        public Person()
        {
            
        }

        public Person(IPerson person)
        {
            _person = person;
        }

        public virtual int Id { get; private set; }
        public virtual string FirstName { get { return _firstName; } set { value = _firstName; } }
        public virtual string MiddleName { get { return _middleName; } set { value = _middleName; } }
        public virtual string LastName { get { return _lastName; } set { value = _lastName; } }
        public virtual PersonType PersonType { get { return _personType; } set { value = _personType; } }
        public virtual IList<Address> Addresses { get { return _addresses; } set { value = _addresses; } }
        public virtual IList<Phone> Phones { get { return _phones; } set { value = _phones; } }
        public virtual IList<Pet> Pets { get { return _pets; } set { value = _pets; } }
        public virtual bool Active { get { return _active; } set { value = _active; } }
        public virtual int AddedBy { get { return _addedBy; } set { value = _addedBy; } }
        public virtual string AddedDate {get { return _addedDate; } set { value = _addedDate; }}
        public virtual int ModifiedBy { get { return _modifiedBy; } set { value = _modifiedBy; } }
        public virtual string ModifiedDate { get { return _modifiedDate; } set { value = _modifiedDate; } }
    }
}
