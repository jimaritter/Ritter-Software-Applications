using System;
using NUnit.Framework;
using PerfectPet.Model.Products;
using PerfectPet.Model.Repository;
using StructureMap;

namespace PerfectPet.Tests
{
    [TestFixture]
    public class ProductTest
    {
        private IProduct _product;

        [Test]
        public void can_add_new_product()
        {
            var _product = ObjectFactory.GetInstance<IProduct>();
            var product = _product.Get();
            product.Name = @"Top Paw™ Gentle and Tearless Puppy Shampoo";
            product.Description = @"Pamper your pup from head to tail with our exclusive gentle and tearless puppy shampoo.";
            product.Cost = 12.00;
            product.Retail = 16.99;
            product.TaxExempt = false;
            product.Active = true;
            product.CreatedDate = DateTime.Now;
            Assert.IsNotNull(product);
            _product.Save(product);
        }

        [SetUp]
        public void Init()
        {
            ContainerBootstrapper.BootstrapStructuremap();   
        }

        [Test]
        public void can_get_all_products()
        {
            var _product = ObjectFactory.GetInstance<IProduct>();
            var product = _product.GetAll();
            Assert.IsNotNull(product);
            foreach (var item in product)
            {
                Console.WriteLine(item.Name + " " + item.Retail.ToString());
            }
        }

        [Test]
        public void can_delete_product()
        {
            var _product = ObjectFactory.GetInstance<IProduct>();
            var product = _product.GetById(2004);
            Assert.IsNotNull(product);
            _product.Delete(product);
        }

        [TearDown]
        public void Cleanup()
        {
            
        }
    }
}
