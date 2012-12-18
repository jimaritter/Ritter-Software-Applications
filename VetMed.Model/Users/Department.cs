using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetMed.Model.Users
{
    public class Department : IDepartment
    {
        private readonly IDepartment _department;
        private int _id;
        private string _name;
        private bool _active;
        private Location _location;
        private User _manager;

        public Department()
        {
            
        }

        public Department(IDepartment department)
        {
            _department = department;
        }

        public virtual int Id { get; private set; }
        public virtual string Name { get { return _name; } set { value = _name; } }
        public virtual bool Active { get { return _active; } set { value = _active; } }
        public virtual Location Location { get { return _location; } set { value = _location; } }
        public virtual User Manager { get { return _manager; } set { value = _manager; } }

    }
}
