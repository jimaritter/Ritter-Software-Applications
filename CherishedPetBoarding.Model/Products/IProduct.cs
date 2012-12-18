using System.Collections.Generic;

namespace CherishedPetBoarding.Model.Products
{
    public interface IProduct
    {
        Product Get();
        IList<Product> GetAll();
        void Save(Product product);
        void Delete(Product product);
    }
}