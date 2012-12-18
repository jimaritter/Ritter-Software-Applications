using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using PerfectPet.Model.Bookings;
using PerfectPet.Model.Pets;
using StructureMap;

namespace PerfectPet.Tests
{
    [TestFixture]
    public class BootStrapTest
    {
        [SetUp]
        public void Init()
        {
            ContainerBootstrapper.BootstrapStructuremap();
        }

        [Test]
        public void can_use_structuremap()
        {
            try
            {
                var appointment = ObjectFactory.GetInstance<IAppointments>();
                Assert.IsNotNull(appointment.Get());
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
