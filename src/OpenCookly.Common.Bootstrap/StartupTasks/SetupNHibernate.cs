using System;
using Bootstrap.Extensions.StartupTasks;
using FluentNHibernate.Automapping;
using System.IO;
using System.Collections.Generic;
using OpenCookly.DAL;
using NHibernate.Cfg;
using Bootstrap;
using System.Reflection;
using NHibernate;
using StructureMap;
using FluentNHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using System.Security.Permissions;

namespace OpenCookly.Common.Bootstrap.StartupTasks
{
    public class SetupNHibernate  : IStartupTask
    {
        private const string DbFile = "OpenCookly.db";

		#region IStartupTask implementation
        public void Run()
        {
            var container = (IContainer)Bootstrapper.Container;

            var entitiesAssemblies = new List<Assembly>();
            var path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var assembliesToLoad = Directory.GetFiles(path, "OpenCookly.*.Entities.dll");
            foreach (var assembly in assembliesToLoad)
            {
                entitiesAssemblies.Add(Assembly.LoadFile(assembly));
            }

            var mappings = AutoMap.Assemblies(entitiesAssemblies.ToArray());
			
            var sessionFactory = Fluently.Configure()
				.Database(MonoSQLiteConfiguration.Standard.UsingFile(DbFile))
				.Mappings(m => m.AutoMappings.Add(mappings))
                .ExposeConfiguration(BuildSchema)
				.BuildSessionFactory();
			
            var session = sessionFactory.OpenSession();

            container.Configure(c => 
            {
                c.For<ISessionFactory>().Singleton().Use(sessionFactory);
                c.For<ISession>().Singleton().Use(session); 
            }
            );
        }

        public void Reset()
        {

        }
		#endregion

        private static void BuildSchema(Configuration config)
        {
            #if DEBUG
            new SchemaUpdate(config).Execute(false, true);
            #endif
        }
    }
}

