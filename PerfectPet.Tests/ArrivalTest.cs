using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using NUnit.Framework;
using PerfectPet.Model.Bookings;
using PerfectPet.Model.Repository;
using StructureMap;

namespace PerfectPet.Tests
{
    [TestFixture]
    public class ArrivalTest
    {
        protected ISession _session = null;
        private IArrivalDeparture _arrivalDeparture;
        private DateTime _addedDate = DateTime.Now;

        [SetUp]
        public void Init()
        {
            ContainerBootstrapper.BootstrapStructuremap();
          // _arrivalDeparture = new ArrivalDepartureDeparture();
          // _session = SessionManager.OpenSession();
        }

        [Test]
        public void can_get_all_arrivals()
        {
            try
            {
                var arrivals = ObjectFactory.GetInstance<IArrivalDeparture>();
                var items = arrivals.GetAll();
                foreach (var a in items)
                {
                    Console.WriteLine(a.Name);
                }
            }
            catch (Exception)
            {
                
                throw;
            }           
        }

        [Test]
        public void can_delete_arrivals()
        {
            try
            {
                var _arrival = ObjectFactory.GetInstance<IArrivalDeparture>();
                var arrival = _arrival.GetAll();
                Assert.IsNotNull(arrival);            
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
