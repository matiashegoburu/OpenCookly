using System;
using Bootstrap.Extensions.StartupTasks;
using Hegoburu.DAL.Core;
using Hegoburu.DAL.Core.NHibernate;
using Bootstrap;
using StructureMap;

namespace OpenCookly.Common.Bootstrap.StartupTasks
{
	public class SetupStructureMap : IStartupTask
	{
		#region IStartupTask implementation
		public void Run ()
		{
			var container = (IContainer)Bootstrapper.Container;
			container.Configure (
				c => 
			{
				c.Scan (s => {
					s.AssembliesFromApplicationBaseDirectory ();
					s.WithDefaultConventions ();
				}
				);

				c.For (typeof(IRepository<>)).Use (typeof(Repository<>));
			}
			);
		}

		public void Reset ()
		{
		}
		#endregion
	}
}

