using System.Collections.Generic;

namespace PerfectPet.Model.Kennels
{
    public interface IKennel
    {
        Kennel Get();
        IList<Kennel> GetAll();
        Kennel GetById(int id);
        void Save(Kennel kennel);
        void Delete(Kennel kennel);
    }
}