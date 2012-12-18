using System.Collections.Generic;

namespace VetMed.Model.Adresses
{
    public interface IAddressType
    {
        IList<AddressType> GetAddressList();
    }
}
