using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using StaticConsulting.Model.Products;
using StaticConsulting.Model.Services;

namespace StaticConsulting.Web.Infrastructure
{
    public class MasterDb : DbContext, IProduct, IService
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Service> Services { get; set; }

        IQueryable<Product> IProduct.Products()
        {
            return Products;
        }

        IQueryable<Service> IService.Services()
        {
            return Services;
        }
    }
}