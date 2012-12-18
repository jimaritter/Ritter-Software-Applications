using System.Collections.Generic;

namespace CherishedPetBoarding.Model.Addresses
{
    public interface IAddressType
    {
        AddressType Get();
        IList<AddressType> GetAll();
        IEnumerable<AddressType> GetAllById(int id);
        AddressType GetById(int id);
        void Save(AddressType addressType);
        void Delete(AddressType addressType);
    }
}