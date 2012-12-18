using System.Collections.Generic;
using PerfectPet.Model.People;

namespace PerfectPet.Model.Addresses
{
    public interface IAddress
    {
        Address GetById(int id);
        Address Get();
        IList<Address> GetAll();
        IEnumerable<Address> GetAllById(int id);
        IEnumerable<Address> GetByPersonId(int personid); 
        void Save(Address address);
        void Delete(Address address);
    }
}