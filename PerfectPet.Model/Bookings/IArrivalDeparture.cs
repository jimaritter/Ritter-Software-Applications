using System.Collections.Generic;

namespace PerfectPet.Model.Bookings
{
    public interface IArrivalDeparture
    {
        ArrivalDeparture Get();
        IList<ArrivalDeparture> GetAll();
        ArrivalDeparture GetById(int id);
        void Save(ArrivalDeparture arrivalDeparture);
        void Delete(ArrivalDeparture arrivalDeparture);
    }
}