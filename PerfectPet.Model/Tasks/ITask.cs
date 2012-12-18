using System.Collections.Generic;

namespace PerfectPet.Model.Tasks
{
    public interface ITask
    {
        Task Get();
        IList<Task> GetAll();
        Task GetById(int id);
        void Save(Task task);
        void Delete(Task task);
    }
}