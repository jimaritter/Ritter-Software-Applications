using System.Collections.Generic;

namespace PerfectPet.Model.Pets
{
    public interface ICatBreed
    {
        CatBreed Get();
        IList<CatBreed> GetAll();
        CatBreed GetById(int id);
        IEnumerable<CatBreed> GetByPetId(int petid);
        void Save(CatBreed breed);
        void Delete(CatBreed breed);
    }
}