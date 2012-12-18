using System.Collections.Generic;

namespace PerfectPet.Model.Pets
{
    public interface IBreed
    {
        Breed Get();
        IList<Breed> GetAll();
        Breed GetById(int id);
        IEnumerable<Breed> GetByPetId(int petid);
        void Save(Breed breed);
        void Delete(Breed breed);
    }
}