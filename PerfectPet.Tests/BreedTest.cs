using System;
using NUnit.Framework;
using PerfectPet.Model.Pets;
using PerfectPet.Model.Repository;

namespace PerfectPet.Tests
{
    [TestFixture]
    public class BreedTest
    {
        private IBreed _breed;

        [SetUp]
        public void Init()
        {
            _breed = new Breed();
        }

        [Test]
        public void can_add_new_breed()
        {
            using(RepositoryBase repository = new RepositoryBase())
            {
                try
                {
                    repository.BeginTransaction();
                    var breed = _breed.Get();
                    breed.Name = "Jack Russell Terrier";
                    breed.SpeciesId = (int) Species.Canine;
                    breed.CreatedDate = DateTime.Now;
                    repository.Save(breed);
                    repository.CommitTransaction();
                }
                catch (Exception)
                {
                    repository.RollbackTransaction();
                    throw;
                }
            }
        }

        [TearDown]
        public void TearDown()
        {
            
        }
    }
}
