using System;
using System.Collections.Generic;
using NHibernate;
using PerfectPet.Model.Repository;

namespace PerfectPet.Model.Inventories
{
    public class Inventory : Business<Inventory>, IInventory
    {
        private readonly IInventory _inventory;
        protected ISession _session = null;

        private DateTime _createdDate = DateTime.Now;
        public virtual int Id { get; set; }
        public virtual string Number { get; set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual Double Cost { get; set; }
        public virtual Double Retail { get; set; }
        public virtual bool TaxExempt { get; set; }
        public virtual bool Active { get; set; }
        public virtual DateTime CreatedDate { get; set; }
        public virtual DateTime? ModifiedDate { get; set; }


        public Inventory()
        {
  
        }

        public Inventory(IInventory inventory)
        {
            _inventory = inventory;
        }

        public Inventory Get()
        {
            return new Inventory();
        }

        public IList<Inventory> GetAll()
        {
            try
            {
                if (_session == null)
                {
                    _session = SessionManager.OpenSession();
                }
                var productlist = _session.CreateCriteria(typeof(Inventory)).List<Inventory>();
                return productlist;
            }
            catch (Exception)
            {

                throw;
            }   
        }

        public Inventory GetById(int id)
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                try
                {
                    repository.BeginTransaction();
                    var product = repository.GetById(typeof(Inventory), id);
                    repository.CommitTransaction();
                    return product as Inventory;
                }
                catch (Exception)
                {
                    repository.RollbackTransaction();
                    throw;
                }
            }            
        }

        public void Save(Inventory inventory)
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                try
                {
                    repository.BeginTransaction();
                    repository.Save(inventory);
                    repository.CommitTransaction();
                }
                catch (Exception)
                {
                    repository.RollbackTransaction();
                    throw;
                }
            }
        }

        public void Delete(Inventory inventory)
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                try
                {
                    repository.BeginTransaction();
                    repository.Delete(inventory);
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
