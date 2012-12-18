using System;
using NUnit.Framework;
using PerfectPet.Model.Bookings;
using PerfectPet.Model.People;
using PerfectPet.Model.Pets;
using PerfectPet.Model.Repository;

namespace PerfectPet.Tests
{
    [TestFixture]
    public class ScheduleTest
    {
        private IBooking _booking;

        [SetUp]
        public void Init()
        {
            _booking = new Booking();    
        }

        [Test]
        public void can_add_new_schedule()
        {
            using(RepositoryBase repository = new RepositoryBase())
            {
                try
                {
                    repository.BeginTransaction();
                    var schedule = _booking.Get();
                    schedule.Description = "Boarding for 7 days for Abby";
                    schedule.ScheduleType = ScheduleType.Boarding;
                    schedule.CreatedDate = DateTime.Now;
                    schedule.StartDate = DateTime.Now;
                    schedule.EndDate = DateTime.Now.AddDays(7);
                    schedule.ModifiedDate = DateTime.Now;
                    //schedule.Pet = repository.GetById(typeof (Pet), 6012) as Pet;
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
