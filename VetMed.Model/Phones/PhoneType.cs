using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetMed.Model.Phones
{
    public class PhoneType : IPhoneType
    {
        private readonly IPhoneType _phoneType;
        private int _id;
        private string _name;
        private bool _active;
        private int _addedBy;
        private string _addedDate;
        private int _modifiedBy;
        private string _modifiedDate;

        public PhoneType()
        {
            
        }

        public PhoneType(IPhoneType phoneType)
        {
            _phoneType = phoneType;
        }

        public virtual int Id { get; private set; }
        public virtual string Name { get { return _name; } set { value = _name; } }
        public virtual bool Active { get { return _active; } set { value = _active; } }
        public virtual int AddedBy { get { return _addedBy; } set { value = _addedBy; } }
        public virtual string AddedDate { get { return _addedDate; } set { value = _addedDate; } }
        public virtual int ModifiedBy { get { return _modifiedBy; } set { value = _modifiedBy; } }
        public virtual string ModifiedDate { get { return _modifiedDate; } set { value = _modifiedDate; } }

    }
}
