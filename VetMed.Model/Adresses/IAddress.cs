using System.Collections.Generic;
using NodaTime;

namespace VetMed.Model.Adresses
{
    public interface IAddress
    {
        IList<Address> GetAll();
        Address GetById(int id);
        Address GetByAddedDate(DateTimeZone dateTimeZone);
        Address GetByAddedBy(int id);
        Address Save(Address address);
        void Delete(Address address);
    }
}
