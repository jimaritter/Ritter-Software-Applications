using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CherishedPetBoarding.Model.Products;
using CherishedPetBoarding.Model.Repository;
using NUnit.Framework;

namespace CherishedPetBoarding.Test
{
    [TestFixture]
    public class ProductTest
    {
        private IProduct _product;

        [SetUp]
        public void Init()
        {
            _product = new Product();    
        }

        [Test]
        public void can_add_new_product()
        {
            using(RepositoryBase repository = new RepositoryBase())
            {
                try
                {
                    repository.BeginTransaction();
                    var product = _product.Get();
                    product.Name = "Feline - Standard Grooming";
                    product.Description = "Shampoo and Dip";
                    product.UnitCost = 145.50;
                    product.SalePrice = 175.00;
                    product.CreatedDate = DateTime.Now;
                    repository.Save(product);
                    repository.CommitTransaction();
                }
                catch (Exception)
                {
                    repository.RollbackTransaction();
                    throw;
                }
            }
        }

        [TearDown]
        public void Cleanup()
        {
            
        }
    }
}
