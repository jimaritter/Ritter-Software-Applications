using System;
using NUnit.Framework;
using PerfectPet.Model.People;
using PerfectPet.Model.Pets;
using PerfectPet.Model.Repository;

namespace PerfectPet.Tests
{
    [TestFixture]
    public class PetTest
    {
        private IPet _pet;

        [SetUp]
        public void Init()
        {
            _pet = new Pet();
        }

        [Test]
        public void can_add_new_pet()
        {
            using(RepositoryBase repository = new RepositoryBase())
            {
                try
                {
                    repository.BeginTransaction();
                    var pet = _pet.Get();
                    pet.Name = "Abby";
                    pet.Age = 6;
                    pet.Color = "Brown and White";
                    //pet.Medications = "Allergy Tablets";
                    pet.Species = Species.Canine.ToString();
                    pet.CreatedDate = DateTime.Now;
                    pet.Breed = "";
                    pet.Person = repository.GetById(typeof(Person), 2004) as Person;
                    repository.Save(pet);
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
        public void Cleanup()
        {
            
        }
    }
}
