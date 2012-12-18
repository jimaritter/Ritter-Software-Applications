using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CherishedPetBoarding.Model.People;
using CherishedPetBoarding.Model.Pets;
using CherishedPetBoarding.Model.Repository;
using CherishedPetBoarding.Model.Schedules;
using NUnit.Framework;

namespace CherishedPetBoarding.Test
{
    [TestFixture]
    public class ScheduleTest
    {
        private ISchedule _schedule;

        [SetUp]
        public void Init()
        {
            _schedule = new Schedule();    
        }

        [Test]
        public void can_add_new_schedule()
        {
            using(RepositoryBase repository = new RepositoryBase())
            {
                try
                {
                    repository.BeginTransaction();
                    var schedule = _schedule.Get();
                    schedule.Description = "Boarding for 7 days for Abby";
                    schedule.ScheduleType = ScheduleType.Boarding;
                    schedule.CreatedDate = DateTime.Now;
                    schedule.StartDate = DateTime.Now;
                    schedule.EndDate = DateTime.Now.AddDays(7);
                    schedule.ModifiedDate = DateTime.Now;
                    schedule.Pet = repository.GetById(typeof (Pet), 6012) as Pet;
                    schedule.Person = repository.GetById(typeof (Person), 1002) as Person;
                    repository.Save(schedule);
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
