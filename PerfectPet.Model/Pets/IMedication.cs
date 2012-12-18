using System.Collections.Generic;

namespace PerfectPet.Model.Pets
{
    public interface IMedication
    {
        Medication Get();
        IList<Medication> GetAll();
        Medication GetById(int id);
        IEnumerable<Medication> GetByPetId(int petid); 
        void Save(Medication medication);
        void Delete(Medication medication);
    }
}