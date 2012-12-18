using System.Collections.Generic;

namespace VetMed.Model.Pets
{
    public interface IPet
    {
        List<Pet> GetAll();
        Pet GetById(int id);
        void Update(Pet pet);
        void Delete(Pet pet);
    }
}