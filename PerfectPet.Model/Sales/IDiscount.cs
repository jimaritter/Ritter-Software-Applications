using System.Collections.Generic;

namespace PerfectPet.Model.Sales
{
    public interface IDiscount
    {
        Discount Get();
        IList<Discount> GetAll();
        Discount GetById(int id);
        void Save(Discount discount);
        void Delete(Discount discount);
    }
}