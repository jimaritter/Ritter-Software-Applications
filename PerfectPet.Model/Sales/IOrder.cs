using System.Collections.Generic;

namespace PerfectPet.Model.Sales
{
    public interface IOrder
    {
        Order Get();
        IList<Order> GetAll();
        Order GetById(int id);
        void Save(Order order);
        void Delete(Order order);
    }
}