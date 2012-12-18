using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CherishedPetBoarding.Model.People;
using CherishedPetBoarding.Model.Pets;
using CherishedPetBoarding.Model.Repository;

namespace CherishedPetBoarding.Model.Schedules
{
    public class Schedule : Business<Schedule>, ISchedule
    {
        private readonly ISchedule _schedule;
        public int Id { get; set; }
        public string Description { get; set; }
        public Pet Pet { get; set; }
        public Person Person { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public ScheduleType ScheduleType { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public Schedule()
        {
            
        }

        public Schedule(ISchedule schedule)
        {
            _schedule = schedule;
        }

        public Schedule Get()
        {
            return this;
        }

        public IList<Schedule> GetAll()
        {
            throw new NotImplementedException();
        }

        public Schedule GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Save(Schedule schedule)
        {
            throw new NotImplementedException();
        }

        public void Delete(Schedule schedule)
        {
            throw new NotImplementedException();
        }
    }
}
