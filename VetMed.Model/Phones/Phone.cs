using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetMed.Model.Phones
{
    public class Phone : IPhone
    {
        private readonly IPhone _phone;
        private int _id;
        private string _number;
        private PhoneType _phoneType;
        private bool _active;
        private int _addedBy;
        private string _addedDate;
        private int _modifiedBy;
        private string _modifiedDate;

        public Phone()
        {
            
        }

        public Phone(IPhone phone)
        {
            _phone = phone;
        }

        public virtual int Id { get; private set; }
        public virtual string Number { get { return _number; } set { value = _number; } }
        public virtual PhoneType PhoneType { get { return _phoneType; } set { value = _phoneType; } }
        public virtual bool Active { get { return _active; } set { value = _active; } }
        public virtual int AddedBy { get { return _addedBy; } set { value = _addedBy; } }
        public virtual string AddedDate { get { return _addedDate; } set { value = _addedDate; } }
        public virtual int ModifiedBy { get { return _modifiedBy; } set { value = _modifiedBy; } }
        public virtual string ModifiedDate { get { return _modifiedDate; } set { value = _modifiedDate; } }

    }
}
