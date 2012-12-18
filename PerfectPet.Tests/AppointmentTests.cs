using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using PerfectPet.Model.Bookings;
using StructureMap;

namespace PerfectPet.Tests
{
    [TestFixture]
    public class AppointmentTests
    {
        [SetUp]
        public void Init()
        {
            ContainerBootstrapper.BootstrapStructuremap();
        }

        [Test]
        public void can_create_new_resource()
        {
            var resource = ObjectFactory.GetInstance<IResources>();
            var obj = resource.Get();
        }

        [Test]
        public void can_create_new_appointment()
        {
            var resource = ObjectFactory.GetInstance<IResources>();
            var objresource = resource.Get();
            objresource.Name = "Large Run 1";
            resource.Save(objresource);

            var appointment = ObjectFactory.GetInstance<IAppointments>();
            var objappointment = appointment.Get();
            //objappointment.AppointmentId = new Guid();
            objappointment.Summary = "Mac Boarding";
            objappointment.Start = DateTime.Now.AddHours(3);
            objappointment.EndDate = DateTime.Now.AddDays(7);
            objappointment.Description = "Description 1";
            //////objappointment.Resources.Add(objresource);
            objappointment.Resource = objresource;
            appointment.Save(objappointment);
        }

        [TearDown]
        public void Cleanup()
        {
            
        }
    }
}
