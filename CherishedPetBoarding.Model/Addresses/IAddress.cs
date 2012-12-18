using System.Collections.Generic;

namespace CherishedPetBoarding.Model.Addresses
{
    public interface IAddress
    {
        Address GetById(int id);
        Address Get();
        IList<Address> GetAll();
        IEnumerable<Address> GetAllById(int id);
        void Save(Address address);
        void Delete(Address address);
    }
}