using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CherishedPetBoarding.Model.People;
using CherishedPetBoarding.Model.Pets;
using CherishedPetBoarding.Model.Repository;
using NUnit.Framework;

namespace CherishedPetBoarding.Test
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
                    pet.Medications = "Allergy Tablets";
                    pet.Species = (int) Species.Canine;
                    pet.CreatedDate = DateTime.Now;
                    pet.Breed = repository.GetById(typeof(Breed), 5010) as Breed;
                    pet.Person = repository.GetById(typeof (Person), 1002) as Person;
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
