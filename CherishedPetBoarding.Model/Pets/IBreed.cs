using System.Collections.Generic;

namespace CherishedPetBoarding.Model.Pets
{
    public interface IBreed
    {
        Breed Get();
        IList<Breed> GetAll();
        Breed GetById(int id);
        void Save(Breed breed);
        void Delete(Breed breed);
    }
}