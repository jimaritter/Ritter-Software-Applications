using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VetMed.Model.Medical;
using VetMed.Model.Persons;

namespace VetMed.Model.Pets
{
    public class Pet : IPet, IBreed, IMedicalRecord
    {
        private readonly IPet _pet;
        private int _id;
        private string _name;
        private string _dob;
        private string _dod;
        private Breed _breed;
        private char _sex;
        private Person _person;
        private MedicalRecord _medicalRecord;
        private bool _active;
        private int _addedBy;
        private string _addedDate;
        private int _modifiedBy;
        private string _modifiedDate;

        public Pet()
        {
        }

        public Pet(IPet pet)
        {
            _pet = pet;
            _name = "Abby";
        }

        public virtual int Id { get; private set; }
        public virtual string Name { get { return _name; } set { value = _name; } }
        public virtual string DateOfBirth { get { return _dob; } set { value = _dob; } }
        public virtual string DateOfDeath { get { return _dod; } set { value = _dod; } }
        public virtual Breed Breed { get { return _breed; } set { value = _breed; } }
        public virtual char Sex { get { return _sex; } set { value = _sex; } }
        public virtual Person Person { get { return _person; } set { value = _person; } }
        public virtual MedicalRecord MedicalRecord { get { return _medicalRecord; } set { value = _medicalRecord; } }
        public virtual bool Active { get { return _active; } set { value = _active; } }        
        public virtual int AddedBy { get { return _addedBy; } set { value = _addedBy; } }
        public virtual string AddedDate { get { return _addedDate; } set { value = _addedDate; } }
        public virtual int ModifiedBy { get { return _modifiedBy; } set { value = _modifiedBy; } }
        public virtual string ModifiedDate { get { return _modifiedDate; } set { value = _modifiedDate; } }

        List<Pet> IPet.GetAll()
        {
            throw new NotImplementedException();
        }

        Breed IBreed.GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Breed breed)
        {
            throw new NotImplementedException();
        }

        public void Delete(Breed breed)
        {
            throw new NotImplementedException();
        }

        List<Breed> IBreed.GetAll()
        {
            throw new NotImplementedException();
        }

        Pet IPet.GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Pet pet)
        {
            throw new NotImplementedException();
        }

        public void Delete(Pet pet)
        {
            throw new NotImplementedException();
        }
    }
}
