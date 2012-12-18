using System.Collections.Generic;

namespace PerfectPet.Model.Services
{
    public interface IService
    {
        Service Get();
        IList<Service> GetAll();
        Service GetById(int id);
        void Save(Service service);
        void Delete(Service service);
    }
}