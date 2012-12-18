using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticConsulting.Model.Products
{
    public class Product : IProduct
    {
        private readonly IProduct _product;
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual bool Active { get; set; }


        public Product()
        {
            
        }

        public Product(IProduct product)
        {
            _product = product;
        }

        public IQueryable<Product> Products()
        {
            throw new NotImplementedException();
        }
    }
}
