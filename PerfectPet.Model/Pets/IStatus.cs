using System.Collections.Generic;

namespace PerfectPet.Model.Pets
{
    public interface IStatus
    {
        Status Get();
        IList<Status> GetAll();
        Status GetById(int id);
        void Save(Status status);
        void Delete(Status status);
    }
}