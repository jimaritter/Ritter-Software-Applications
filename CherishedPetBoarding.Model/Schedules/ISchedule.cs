using System.Collections.Generic;

namespace CherishedPetBoarding.Model.Schedules
{
    public interface ISchedule
    {
        Schedule Get();
        IList<Schedule> GetAll();
        Schedule GetById(int id);
        void Save(Schedule schedule);
        void Delete(Schedule schedule);
    }
}