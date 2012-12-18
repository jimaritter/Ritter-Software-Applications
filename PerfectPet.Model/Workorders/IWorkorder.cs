using System.Collections.Generic;

namespace PerfectPet.Model.Workorders
{
    public interface IWorkorder
    {
        Workorder Get();
        IList<Workorder> GetAll();
        Workorder GetById(int id);
        IEnumerable<Workorder> GetByPersonId(int personid);
        void Save(Workorder workorder);
        void Delete(Workorder workorder);
    }
}