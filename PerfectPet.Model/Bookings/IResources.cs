using System.Collections.Generic;

namespace PerfectPet.Model.Bookings
{
    public interface IResources
    {
        Resources Get();
        IList<Resources> GetAll();
        Resources GetById(int id);
        void Save(Resources resource);
        void Delete(Resources resource);
    }
}