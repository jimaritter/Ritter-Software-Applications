using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using VetMed.Model.Medical;
using VetMed.Model.Pets;

namespace VetMed.Tests
{
    [TestFixture]
    public class MedicalCodeTest
    {

        private readonly IMedicalDental _medicalDental;
        private readonly IPet _pet = new Pet();
        [SetUp]
        public void Init()
        {
                IocBootstrap.SetupForIoc();
        }

        public MedicalCodeTest()
        {
            _medicalDental = new MedicalDental();
        }

        [Test]
        public void GetMedicalDentalCode()
        {

            //See if we can get Dental Code
            Console.WriteLine(_medicalDental.GetCode());
            Assert.IsNotNull(_pet);
            var query = from a in _pet.GetAll()
                        select a;
            foreach (var pet in query)
            {
                Console.WriteLine(pet.Name);                
            }
        }
    }
}
