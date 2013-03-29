using System;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using NHibernate.Cfg;
using FluentNHibernate.Automapping;
using OpenCookly.Entities;

namespace OpenCookly.DAL
{
	public static class Setup
	{
		public static ISessionFactory Run ()
		{
			var sessionFactory = Fluently.Configure ()
				.Database (SQLiteConfiguration.Standard.UsingFile ("OpenCookly.db").ShowSql ())
				.Mappings (m => m.AutoMappings.Add (AutoMap.AssemblyOf<BaseEntity> ()))
				.ExposeConfiguration (BuildSchema)
				.BuildSessionFactory ();
		}

		private static void BuildSchema (Configuration config)
		{
			#if DEBUG
			new SchemaUpdate (config).Execute (true, true);
			#endif
		}
	}
}

