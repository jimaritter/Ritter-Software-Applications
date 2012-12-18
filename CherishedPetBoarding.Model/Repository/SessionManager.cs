using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CherishedPetBoarding.Model.Mappings;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;

namespace CherishedPetBoarding.Model.Repository
{
    public static class SessionManager
    {
        private static ISessionFactory _sessionFactory;

        private static ISessionFactory SessionFactory
        {
            get
            {
                if (_sessionFactory == null)
                {
                    //Currently using SQL Server CE database file.
                    _sessionFactory = Fluently.Configure()
                        .Database(MsSqlConfiguration.MsSql2008
                          .ConnectionString(c => c
                            .Server("(local)")
                            .Database("CPB")
                            .Username("CPB")
                            .Password("4Cuzavuw")))
                        .Mappings(m => m.FluentMappings.AddFromAssemblyOf<AddressMap>())
                        .ExposeConfiguration((Configuration config) => new SchemaExport(config).Create(true, false))
                        .BuildSessionFactory();

                    //Session = _sessionFactory.OpenSession();
                }

                return _sessionFactory;
            }
        }

        public static ISession OpenSession()
        {
            return SessionFactory.OpenSession();
        }

    }
}
