using System.Collections.Generic;

namespace PerfectPet.Model.Phones
{
    public interface IPhoneType
    {
        PhoneType Get();
        IList<PhoneType> GetAll();
        IList<PhoneType> GetAllById(int id);
        void Save(PhoneType phoneType);
        void Delete(PhoneType phoneType);
    }
}