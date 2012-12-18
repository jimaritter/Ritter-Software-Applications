namespace VetMed.Model.Persons
{
    public class PersonType : IPersonType
    {
        private int _id;
        private readonly IPersonType _type;
        private string _name;
        private string _addedDate;
        private int _addedBy;
        private string _modifiedDate;
        private int _modifiedBy;

        public PersonType()
        {
            
        }

        public PersonType(IPersonType type)
        {
            _type = type;
        }

        public virtual int Id { get; private set; }
        public virtual IPersonType Type { get { return _type; } set { value = _type; } }
        public virtual string Name { get { return _name; } set { value = _name; } }
        public virtual string AddedDate { get { return _addedDate; } set { value = _addedDate; } }
        public virtual int AddedBy { get { return _addedBy; } set { value = _addedBy; } }
        public virtual string ModifiedDate { get { return _modifiedDate; } set { value = _modifiedDate; } }
        public virtual int ModifiedBy { get { return _modifiedBy; } set { value = _modifiedBy; } }
    }
}
