using System;
using System.Collections.Generic;
using NHibernate;
using PerfectPet.Model.Repository;

namespace PerfectPet.Model.Sales
{
    public class Order : Business<Order>, IOrder
    {
        private readonly IOrder _order;
        private DateTime _createdDate = DateTime.Now;
        public virtual int Id { get; set; }
        public Invoice Invoice { get; set; }
        public virtual DateTime CreatedDate { get; set; }
        public virtual DateTime? ModifiedDate { get; set; }
        protected ISession _session = null;

        public Order()
        {

        }

        public Order(IOrder order)
        {
            _order = order;
        }

        public Order Get()
        {
            return new Order();
        }

        public IList<Order> GetAll()
        {
            try
            {
                if (_session == null)
                {
                    _session = SessionManager.OpenSession();
                }
                var orderlist = _session.CreateCriteria(typeof(Order)).List<Order>();
                return orderlist;
            }
            catch (Exception)
            {

                throw;
            }  
        }

        public Order GetById(int id)
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                try
                {
                    repository.BeginTransaction();
                    var order = repository.GetById(typeof(Order), id);
                    repository.CommitTransaction();
                    return order as Order;
                }
                catch (Exception)
                {
                    repository.RollbackTransaction();
                    throw;
                }
            } 
        }

        public void Save(Order order)
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                try
                {
                    repository.BeginTransaction();
                    repository.Save(order);
                    repository.CommitTransaction();
                }
                catch (Exception)
                {
                    repository.RollbackTransaction();
                    throw;
                }
            }
        }

        public void Delete(Order order)
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                try
                {
                    repository.BeginTransaction();
                    repository.Delete(order);
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
