using System.Collections.Generic;

namespace VetMed.Model.Pets
{
    public class Breed : IBreed
    {
        private readonly IBreed _breed;
        private int _id;
        private string _name;
        private bool _active;
        private int _addedBy;
        private string _addedDate;
        private int _modifiedBy;
        private string _modifiedDate;

        public Breed()
        {
            
        }

        public Breed(IBreed breed)
        {
            _breed = breed;
        }

        public virtual int Id { get; private set; }
        public virtual string Name { get { return _name; } set { value = _name; } }
        public virtual bool Active { get { return _active; } set { value = _active; } }
        public virtual int AddedBy { get { return _addedBy; } set { value = _addedBy; } }
        public virtual string AddedDate { get { return _addedDate; } set { value = _addedDate; } }
        public virtual int ModifiedBy { get { return _modifiedBy; } set { value = _modifiedBy; } }
        public virtual string ModifiedDate { get { return _modifiedDate; } set { value = _modifiedDate; } }

        public List<Breed> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Breed GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Breed breed)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(Breed breed)
        {
            throw new System.NotImplementedException();
        }
    }
}