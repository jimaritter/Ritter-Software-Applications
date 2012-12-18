using System.Collections.Generic;

namespace PerfectPet.Model.Bookings
{
    public interface IArrival
    {
        Arrival Get();
        IList<Arrival> GetAll();
        Arrival GetById(int id);
        void Save(Arrival arrival);
        void Delete(Arrival arrival);
    }
}