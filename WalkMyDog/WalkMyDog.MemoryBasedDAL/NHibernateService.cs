﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;

namespace WalkMyDog.MemoryBasedDAL
{
    using global::NHibernate;
    using global::NHibernate.Cfg;
    using global::NHibernate.Tool.hbm2ddl;
    using WalkMyDog.MemoryBasedDAL.Mappings;

    public static class NHibernateService
    {
        private static ISessionFactory sessionFactory;

        public static ISession OpenSession()
        {
            //try
            {
                if (sessionFactory == null)
                {
                    sessionFactory = OpenSessionFactory();
                }
                ISession session = sessionFactory.OpenSession();
                return session;
            }
            //catch (Exception e)
            //{
            //    throw e.InnerException ?? e;
            //}
        }

        private static ISessionFactory OpenSessionFactory()
        {
            ISessionFactory sessionFactory = null;
            try
            {


                var nhConfig = Fluently.Configure()
                    .Database(SQLiteConfiguration.Standard
                          .ConnectionString("data source=|DataDirectory|test.db;")
                        .AdoNetBatchSize(100))
                    .Mappings(mappings => mappings.FluentMappings.AddFromAssemblyOf<UserMap>())
                    .BuildConfiguration();

                sessionFactory = nhConfig.BuildSessionFactory();
                var schemaExport = new SchemaUpdate(nhConfig);
                schemaExport.Execute(true, true);
            }
            catch (Exception e)
            {
                Logger.Log(e);
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }

            return sessionFactory;

        }
    }
}
