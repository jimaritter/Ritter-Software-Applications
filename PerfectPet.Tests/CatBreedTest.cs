using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using NUnit.Framework;
using PerfectPet.Model.Pets;
using StructureMap;

namespace PerfectPet.Tests
{
    [TestFixture]
    public class CatBreedTest
    {
        protected ISession _session = null;
        private ICatBreed _catBreed;
        private DateTime _addedDate = DateTime.Now;

        [SetUp]
        public void Init()
        {
            ContainerBootstrapper.BootstrapStructuremap();
        }

        [Test]
        public void can_get_all_cat_breeds()
        {
            try
            {
                var catbreeds = ObjectFactory.GetInstance<ICatBreed>();
                foreach (var breed in catbreeds.GetAll())
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
        public void can_get_cat_breed_list()
        {
            string delimiter = ",;";
            List<string> logs = (File.ReadAllLines(@"C:\Projects\catbreeds.txt")
                // leave blank lines
                .Where(line => !string.IsNullOrEmpty(line))
                .Select(line => line.Split(delimiter.ToCharArray(), StringSplitOptions.RemoveEmptyEntries))
                .Select(values => string.Join("/n", values))
                // find all unique values
                .Distinct()
                .ToList<string>());// convert to list  
            var catbreeds = ObjectFactory.GetInstance<ICatBreed>();
            foreach (var log in logs)
            {
                CatBreed catbreed = new CatBreed();
                catbreed.Name = log.ToString();
                catbreeds.Save(catbreed);
            }
        }
        [TearDown]
        public void Cleanup()
        {

        }
    }
}
