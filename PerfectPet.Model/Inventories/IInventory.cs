using System.Collections.Generic;

namespace PerfectPet.Model.Inventories
{
    public interface IInventory
    {
        Inventory Get();
        IList<Inventory> GetAll();
        Inventory GetById(int id);
        void Save(Inventory inventory);
        void Delete(Inventory inventory);
    }
}