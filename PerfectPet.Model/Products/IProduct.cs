using System.Collections.Generic;

namespace PerfectPet.Model.Products
{
    public interface IProduct
    {
        Product Get();
        IList<Product> GetAll();
        Product GetById(int id);
        void Save(Product product);
        void Delete(Product product);
    }
}