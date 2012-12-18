using System.Collections.Generic;

namespace PerfectPet.Model.People
{
    public interface IPersonType
    {
        PersonType Get();
        IList<PersonType> GetAll();
        PersonType GetById(int id);
        IEnumerable<PersonType> GetAllById(int id);
        void Save(PersonType phoneType);
        void Delete(PersonType phoneType);
    }
}