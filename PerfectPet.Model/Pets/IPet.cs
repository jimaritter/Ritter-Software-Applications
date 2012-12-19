using System.Collections.Generic;

namespace PerfectPet.Model.Pets
{
    public interface IPet
    {
        Pet Get();
        IList<Pet> GetAll();
        Pet GetById(int id);
        IEnumerable<Pet> GetByPersonId(int personid);
        IEnumerable<Pet> GetByMultiplePets(int[] petids);
        IList<Pet> GetAllCheckedIn();
        void Save(Pet pet);
        void Delete(Pet pet);
    }
}