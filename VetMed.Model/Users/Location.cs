using VetMed.Model.Adresses;

namespace VetMed.Model.Users
{
    public class Location : ILocation
    {
        private readonly ILocation _location;
        private int _id;
        private string _name;
        private Address _address;

        public Location()
        {
            
        }

        public Location(ILocation location)
        {
            _location = location;
        }

        public virtual int Id { get; private set; }
        public virtual string Name { get { return _name; } set { value = _name; } }
        public virtual Address Address { get { return _address; } set { value = _address; } }
    }
}