using System.Collections.Generic;

namespace VetMed.Model.Pets
{
    public interface IBreed
    {
        List<Breed> GetAll();
        Breed GetById(int id);
        void Update(Breed breed);
        void Delete(Breed breed);
    }
}