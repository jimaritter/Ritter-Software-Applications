using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CherishedPetBoarding.Model.People;
using CherishedPetBoarding.Model.Repository;
using CherishedPetBoarding.Model.Users;

namespace CherishedPetBoarding.Model.Pets
{
    public class Pet : Business<Pet>, IPet
    {
        private readonly IPet _pet;
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual Breed Breed { get; set; }
        public virtual string Color { get; set; }
        public virtual int Weight { get; set; }
        public virtual string Diet { get; set; }
        public virtual string Medications { get; set; }
        public virtual int Age { get; set; }
        public virtual int Species { get; set; }
        public virtual Person Person { get; set; }
        public virtual DateTime CreatedDate { get; set; }
        public virtual DateTime? ModifiedDate { get; set; }

        public Pet()
        {
            
        }

        public Pet(IPet pet)
        {
            _pet = pet;
        }

        public Pet Get()
        {
            return this;
        }

        public IList<Pet> GetAll()
        {
            throw new NotImplementedException();
        }

        public Pet GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Save(Pet pet)
        {
            throw new NotImplementedException();
        }

        public void Delete(Pet pet)
        {
            throw new NotImplementedException();
        }
    }
}
