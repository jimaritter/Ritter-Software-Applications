using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using NUnit.Framework;
using PerfectPet.Model.Bookings;
using PerfectPet.Model.Pets;
using StructureMap;

namespace PerfectPet.Tests
{
    [TestFixture]
    public class DogBreedTest
    {
        protected ISession _session = null;
        private DateTime _addedDate = DateTime.Now;

        [SetUp]
        public void Init()
        {
            ContainerBootstrapper.BootstrapStructuremap();
            // _session = SessionManager.OpenSession();
        }

        [Test]
        public void can_get_all_dog_breeds()
        {
            try
            {
                var dogbreeds = ObjectFactory.GetInstance<IDogBreed>();
                foreach (var breed in dogbreeds.GetAll())
                {
                    Console.WriteLine(breed.Name);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        [Test]
        public void can_get_dog_breed_list()
        {
            string delimiter = ",;";
            List<string> logs = (File.ReadAllLines(@"C:\Projects\dogbreeds.txt")
                // leave blank lines
                .Where(line => !string.IsNullOrEmpty(line))
                // split line seperated by delimiter
                .Select(line => line.Split(delimiter.ToCharArray(), StringSplitOptions.RemoveEmptyEntries))
                // compare the third column to find all records from CityA
                //.Where(values => values[2].Equals("CityA", StringComparison.CurrentCultureIgnoreCase))
                // compare the second column to find all records with age more than or equal to 30
                //.Where(values => int.Parse(values[1]) >= 30)
                // join back the splitted values by underscore
                .Select(values => string.Join("/n", values))
                // find all unique values
                .Distinct()
                .ToList<string>());// convert to list
            var obj = ObjectFactory.GetInstance<IDogBreed>();
            foreach (var log in logs)
            {

                DogBreed dogbreed = new DogBreed();
                dogbreed.Name = log.ToString();
                obj.Save(dogbreed);
            }
        }
        [TearDown]
        public void Cleanup()
        {

        }

    }
}
