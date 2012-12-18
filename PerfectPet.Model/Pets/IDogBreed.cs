using System.Collections.Generic;

namespace PerfectPet.Model.Pets
{
    public interface IDogBreed
    {
        DogBreed Get();
        IList<DogBreed> GetAll();
        DogBreed GetById(int id);
        IEnumerable<DogBreed> GetByPetId(int petid);
        void Save(DogBreed breed);
        void Delete(DogBreed breed);
    }
}