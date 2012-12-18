using System.Collections.Generic;

namespace CherishedPetBoarding.Model.Pets
{
    public interface IPet
    {
        Pet Get();
        IList<Pet> GetAll();
        Pet GetById(int id);
        void Save(Pet pet);
        void Delete(Pet pet);
    }
}