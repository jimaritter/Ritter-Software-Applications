using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using PerfectPet.Model.People;
using PerfectPet.Model.Pets;
using StructureMap;

namespace PerfectPet.Tests
{
    [TestFixture]
    public class PetStatusTest
    {
        [SetUp]
        public void Init()
        {
            ContainerBootstrapper.BootstrapStructuremap();
        }

        [Test]
        public void can_add_new_status()
        {
            try
            {
                var _status = ObjectFactory.GetInstance<IStatus>();
                var status = _status.Get();
                status.Title = "Had kennel cleaned";
                _status.Save(status);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        [Test]
        public void can_add_new_status_to_pet()
        {
            try
            {
                var _person = ObjectFactory.GetInstance<IPerson>();
                var person = _person.GetById(6012);
                Assert.IsNotNull(person);
                var _pet = ObjectFactory.GetInstance<IPet>();
                var pet = _pet.GetById(9018);
                Assert.IsNotNull(pet);
                var _status = ObjectFactory.GetInstance<IStatus>();
                var status = _status.GetById(34034);
                Assert.IsNotNull(status);
                var _petstatus = ObjectFactory.GetInstance<IPetStatus>();
                var petstatus = _petstatus.Get();
                petstatus.Person = person;
                petstatus.Pet = pet;
                petstatus.Status = status;
                petstatus.AddedDate = DateTime.Now;
                _petstatus.Save(petstatus);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        [Test]
        public void can_get_pet_status()
        {
            var _petstatus = ObjectFactory.GetInstance<IPetStatus>();
            var petstatus = _petstatus.GetByPetIdandBetweenDates(9018, DateTime.Now.AddDays(-2), DateTime.Now.AddDays(1));
            Assert.IsNotNull(petstatus);

            foreach (var petstat in petstatus)
            {
                
                var _person = ObjectFactory.GetInstance<IPerson>();
                var person = _person.GetById(petstat.Person.Id);
                Assert.IsNotNull(person);
                var _pet = ObjectFactory.GetInstance<IPet>();
                var pet = _pet.GetById(petstat.Pet.PetId);
                Assert.IsNotNull(pet);
                var _status = ObjectFactory.GetInstance<IStatus>();
                var status = _status.GetById(petstat.Status.Id);
                Assert.IsNotNull(status);
                Console.WriteLine(petstat.AddedDate.ToLongDateString() + " " + petstat.AddedDate.ToShortTimeString() + ": " + pet.Name + " " + status.Title);                
            }

        }

        [TearDown]
        public void CleanUp()
        {
            
        }

    }
}
