using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetMed.Model.Emails
{
    public class Email : IEmail
    {
        private readonly IEmail _email;
        private int _id;
        private string __address;
        private bool _active;
        private int _addedBy;
        private string _addedDate;
        private int _modifiedBy;
        private string _modifiedDate;

        public Email()
        {
            
        }

        public Email(IEmail email)
        {
            _email = email;
        }

        public virtual int Id { get; private set; }
        public virtual string Address { get { return __address; } set { value = __address; } }
        public virtual bool Active { get { return _active; } set { value = _active; } }
        public virtual int AddedBy { get { return _addedBy; } set { value = _addedBy; } }
        public virtual string AddedDate { get { return _addedDate; } set { value = _addedDate; } }
        public virtual int ModifiedBy { get { return _modifiedBy; } set { value = _modifiedBy; } }
        public virtual string ModifiedDate { get { return _modifiedDate; } set { value = _modifiedDate; } }
    }
}
