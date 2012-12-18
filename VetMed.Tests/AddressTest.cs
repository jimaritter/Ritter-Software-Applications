using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Rhino.Mocks;
using VetMed.Model.Adresses;

namespace VetMed.Tests
{
    [TestFixture]
    public class AddressTest
    {
        MockRepository _mocks = new MockRepository();
        readonly IAddress _address = new Address();

        public AddressTest()
        {  
        }

        [Test]
        public void CanGetSingleAddress()
        {
            var address = new Address(_address);
            Assert.IsNotNull(address);
            if (address != null)
            {
                var tempdata = address.GetById(1);
                tempdata.City = "York";
                tempdata.Country = "US";
                tempdata.State = "PA";
                tempdata.Street = "5035 N. Susquehanna Trail";

                address = address.Save(tempdata);
                Console.WriteLine(address.ToString());
            }    
        }
    }
}
