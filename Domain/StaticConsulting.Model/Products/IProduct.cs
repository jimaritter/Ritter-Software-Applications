using System.Linq;

namespace StaticConsulting.Model.Products
{
    public interface IProduct
    {
        IQueryable<Product> Products();
    }
}