using System;
using System.Collections.Generic;
using CherishedPetBoarding.Model.Repository;
using CherishedPetBoarding.Model.Users;

namespace CherishedPetBoarding.Model.Pets
{
    public class Breed : Business<Breed>, IBreed
    {
        private readonly IBreed _breed;
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual int SpeciesId { get; set; }
        public virtual DateTime CreatedDate { get; set; }
        public virtual DateTime? ModifiedDate { get; set; }

        public Breed()
        {
            
        }

        public Breed(IBreed breed)
        {
            _breed = breed;
        }

        public Breed Get()
        {
            return this;
        }

        public IList<Breed> GetAll()
        {
            throw new NotImplementedException();
        }

        public Breed GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Save(Breed breed)
        {
            throw new NotImplementedException();
        }

        public void Delete(Breed breed)
        {
            throw new NotImplementedException();
        }
    }
}