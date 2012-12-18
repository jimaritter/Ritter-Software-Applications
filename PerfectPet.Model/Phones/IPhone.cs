using System.Collections.Generic;

namespace PerfectPet.Model.Phones
{
    public interface IPhone
    {
        Phone Get();
        IList<Phone> GetAll();
        Phone GetById(int id);
        IEnumerable<Phone> GetAllByPersonId(int personid);
        void Save(Phone phone);
        void Delete(Phone phone);
    }
}