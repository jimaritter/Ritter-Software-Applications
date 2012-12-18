using System.IO;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using PerfectPet.Model.Mappings;

namespace PerfectPet.Model.Repository
{
    public static class SessionManager
    {
        private static ISessionFactory _sessionFactory;
        private static bool _overwriteExisting = false;
        private static string _dbFile = @"C:\Projects\StaticConsulting\Data\perfectpet.db";

        private static ISessionFactory SessionFactory
        {
            get
            {
                if (_sessionFactory == null)
                {
                    //Currently using SQL Server CE database file.
                    _sessionFactory = Fluently.Configure()
                                    .Database((
                        SQLiteConfiguration.Standard
                        .UsingFile(_dbFile)
                        ))
                        .Mappings(m => m.FluentMappings.AddFromAssemblyOf<AddressMap>())
                        .ExposeConfiguration((Configuration config) => new SchemaUpdate(config).Execute(false, true))
                        .BuildSessionFactory();

                    //Session = _sessionFactory.OpenSession();
                }

                return _sessionFactory;
            }
        }

        //private static ISessionFactory SessionFactory
        //{
        //    get
        //    {
        //        if (_sessionFactory == null)
        //        {
        //            //Currently using SQL Server CE database file.
        //            _sessionFactory = Fluently.Configure()
        //                .Database(MsSqlConfiguration.MsSql2008
        //                  .ConnectionString(c => c
        //                    .Server("(local)")
        //                    .Database("PerfectPet")
        //                    .Username("PerfectPet")
        //                    .Password("4Cuzavuw")))
        //                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<AddressMap>())
        //                .ExposeConfiguration((Configuration config) => new SchemaExport(config).Create(true, false))
        //                .BuildSessionFactory();

        //            //Session = _sessionFactory.OpenSession();
        //        }

        //        return _sessionFactory;
        //    }
        //}

        private static void BuildSchema(Configuration config)
        {
            if (_overwriteExisting)
            {
                if (File.Exists(_dbFile))
                {
                     File.Delete(_dbFile);
                }
                var se = new SchemaExport(config);
                se.Create(false, true);
            }else
            {
                File.Create(_dbFile);
                var se = new SchemaExport(config);
                se.Create(true, true);
            }
        }
        public static ISession OpenSession()
        {
            return SessionFactory.OpenSession();
        }

        public static void CloseSession()
        {
            SessionFactory.Close();
        }

    }
}
