using StaticConsulting.Model.Products;
using StaticConsulting.Model.Services;

namespace StaticConsulting.Web.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<StaticConsulting.Web.Infrastructure.MasterDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(StaticConsulting.Web.Infrastructure.MasterDb context)
        {
            context.Products.AddOrUpdate(x => x.Name,
                new Product(){Name="Perfect Pet Kennel Management",Active = true,Description = "Complete Kennel Boarding management application"});
            context.Services.AddOrUpdate(x => x.Name,
                                         new Service()
                                             {
                                                 Active = true,
                                                 Description = "Internet Technology Support",
                                                 Name = "Internet Technology Support"
                                             },
                                         new Service()
                                             {
                                                 Active = true,
                                                 Description = "Application Development",
                                                 Name = "Application Development"
                                             },
                                         new Service()
                                         {
                                             Active = true,
                                             Description = "Application Support",
                                             Name = "Application Support"
                                         }
                );
        }
    }
}
