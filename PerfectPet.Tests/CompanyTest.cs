using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using PerfectPet.Model.Companies;
using StructureMap;

namespace PerfectPet.Tests
{
    [TestFixture]
    public class CompanyTest
    {
        [SetUp]
        public void Init()
        {
            ContainerBootstrapper.BootstrapStructuremap();
        }

        [Test]
        public void can_add_company_info()
        {
            var _companyinfo = ObjectFactory.GetInstance<ICompany>();
            var companyinfo = _companyinfo.GetById(1002);
            companyinfo.CompanyName = "Static Consulting";
            companyinfo.TaxRate = .06;
            companyinfo.Street = "5145 N Susquehanna Trail";
            companyinfo.City = "York";
            companyinfo.State = "Pennsylvania";
            companyinfo.Zip = "17406";
            companyinfo.Cell = "717-215-7412";
            companyinfo.Web = "http://www.staticconsulting.com";
            companyinfo.Email = "jim@staticconsulting.com";
            Assert.IsNotNull(_companyinfo);
            _companyinfo.Save(companyinfo);
        }

        [TearDown]
        public void Cleanup()
        {
            
        }
    }
}
