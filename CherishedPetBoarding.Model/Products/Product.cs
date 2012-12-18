using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CherishedPetBoarding.Model.Repository;
using CherishedPetBoarding.Model.Sales;
using CherishedPetBoarding.Model.Users;

namespace CherishedPetBoarding.Model.Products
{
    public class Product : Business<Product>, IProduct
    {
        private readonly IProduct _product;
        private DateTime _createdDate = DateTime.Now;

        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual Double UnitCost { get; set; }
        public virtual Double SalePrice { get; set; }
        public virtual DateTime CreatedDate { get; set; }
        public virtual DateTime? ModifiedDate { get; set; }

        public Product()
        {
  
        }

        public Product(IProduct product)
        {
            _product = product;
        }

        public Product Get()
        {
            return this;
        }

        public IList<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Save(Product product)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
