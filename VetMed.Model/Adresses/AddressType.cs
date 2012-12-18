using System.Collections.Generic;

namespace VetMed.Model.Adresses
{
    public class AddressType : IAddressType
    {
        private readonly IAddressType _addressType;
        private int _id;
        private string _name;

        public AddressType()
        {
            
        }

        public AddressType(IAddressType addressType)
        {
            _addressType = addressType;
        }

        public IList<AddressType> GetAddressList()
        {
            throw new System.NotImplementedException();
        }
    }
}
