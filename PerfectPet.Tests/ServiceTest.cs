using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using PerfectPet.Model.Services;
using StructureMap;

namespace PerfectPet.Tests
{
    [TestFixture]
    public class ServiceTest
    {
        [SetUp]
        public void Init()
        {
            ContainerBootstrapper.BootstrapStructuremap();    
        }

        [Test]
        public void can_add_new_service()
        {
            try
            {
                var _service = ObjectFactory.GetInstance<IService>();
                var service = _service.Get();
                service.Name = "1 Day Medium Dog Boarding";
                service.Description = "1 Full day of boarding for a large 25-50lbs dog.";
                service.Active = true;
                service.Cost = 20.00;
                service.Retail = 22.00;
                service.CreatedDate = DateTime.Now;
                service.TaxExempt = true;
                Assert.IsNotNull(_service);
                Assert.IsNotNull(service);
                _service.Save(service);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        [Test]
        public void can_get_all_services()
        {
            try
            {
                var _service = ObjectFactory.GetInstance<IService>();
                var service = _service.GetAll();
                Assert.IsNotNull(service);
                foreach (var item in service)
                {
                   Console.WriteLine(item.Name + " " + item.Retail); 
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        [Test]
        public void can_delete_service()
        {
            try
            {
                var _service = ObjectFactory.GetInstance<IService>();
                var service = _service.GetById(6012);
                Assert.IsNotNull(service);
                _service.Delete(service);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        [TearDown]
        public void Cleanup()
        {
            
        }
    }
}
