using System;
using System.Collections.Generic;
using NHibernate;
using PerfectPet.Model.Repository;

namespace PerfectPet.Model.Products
{
    public class Product : Business<Product>, IProduct
    {
        private readonly IProduct _product;
        protected ISession _session = null;

        private DateTime _createdDate = DateTime.Now;
        public virtual int Id { get; set; }
        public virtual string ProductNumber { get; set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual Double Cost { get; set; }
        public virtual Double Retail { get; set; }
        public virtual bool TaxExempt { get; set; }
        public virtual bool Active { get; set; }
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
            return new Product();
        }

        public IList<Product> GetAll()
        {
            try
            {
                if (_session == null)
                {
                    _session = SessionManager.OpenSession();
                }
                var productlist = _session.CreateCriteria(typeof(Product)).List<Product>();
                return productlist;
            }
            catch (Exception)
            {

                throw;
            }   
        }

        public Product GetById(int id)
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                try
                {
                    repository.BeginTransaction();
                    var product = repository.GetById(typeof(Product), id);
                    repository.CommitTransaction();
                    return product as Product;
                }
                catch (Exception)
                {
                    repository.RollbackTransaction();
                    throw;
                }
            }            
        }

        public void Save(Product product)
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                try
                {
                    repository.BeginTransaction();
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

        public void Delete(Product product)
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                try
                {
                    repository.BeginTransaction();
                    repository.Delete(product);
                    repository.CommitTransaction();
                }
                catch (Exception)
                {
                    repository.RollbackTransaction();
                    throw;
                }
            }
        }
    }
}
