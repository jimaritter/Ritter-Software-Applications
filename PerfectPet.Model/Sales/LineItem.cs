﻿using System;
using System.Collections.Generic;
using System.Linq;
using NHibernate;
using PerfectPet.Model.Inventories;
using PerfectPet.Model.Repository;
using PerfectPet.Model.Services;

namespace PerfectPet.Model.Sales
{
    public class LineItem : Business<LineItem>, ILineItem
    {
        private readonly ILineItem _lineItem;
        public virtual int Id { get; set; }
        public virtual int LineNumber { get; set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual Inventory Inventory { get; set; }
        public virtual Service Service { get; set; }
        public virtual Invoice Invoice { get; set; }
        public virtual int Quantity { get; set; }
        public virtual Double UnitPrice { get; set; }
        public virtual Double Tax { get; set; }
        public virtual Double LineTotal { get; set; }
        public virtual DateTime CreatedDate { get; set; }
        public virtual DateTime ModifiedDate { get; set; }
        protected ISession _session = null;

        public LineItem()
        {
            
        }

        private double Total()
        {
            var total = Quantity*UnitPrice*Tax;
            return total;
        }

        public LineItem(ILineItem lineItem)
        {
            _lineItem = lineItem;
        }

        public LineItem Get()
        {
            return new LineItem();
        }

        public IList<LineItem> GetAll()
        {
            try
            {
                if (_session == null)
                {
                    _session = SessionManager.OpenSession();
                }
                var lineitemlist = _session.CreateCriteria(typeof(LineItem)).List<LineItem>();
                return lineitemlist;
            }
            catch (Exception)
            {

                throw;
            }  
        }

        public IList<LineItem> GetAllByInvoiceId(int invoiceId)
        {
            try
            {
                if (_session == null)
                {
                    _session = SessionManager.OpenSession();
                }
                var lineitemlist = _session.CreateCriteria(typeof(LineItem)).List<LineItem>();
                var query = from item in lineitemlist
                            where item.Invoice.InvoiceId == invoiceId
                            select item;

                return query.ToList();
            }
            catch (Exception)
            {

                throw;
            }  
        }


        public LineItem GetById(int id)
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                try
                {
                    repository.BeginTransaction();
                    var lineitem = repository.GetById(typeof(LineItem), id);
                    repository.CommitTransaction();
                    return lineitem as LineItem;
                }
                catch (Exception)
                {
                    repository.RollbackTransaction();
                    throw;
                }
            }    
        }

        public void Save(LineItem lineitem)
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                try
                {
                    repository.BeginTransaction();
                    repository.Save(lineitem);
                    repository.CommitTransaction();
                }
                catch (Exception)
                {
                    repository.RollbackTransaction();
                    throw;
                }
            }
        }

        public void Delete(LineItem lineitem)
        {
            using (RepositoryBase repository = new RepositoryBase())
            {
                try
                {
                    repository.BeginTransaction();
                    repository.Delete(lineitem);
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
