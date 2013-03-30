using System;
using Bootstrap.Extensions.StartupTasks;
using Bootstrap;
using StructureMap;
using System.ComponentModel.Composition.Hosting;
using System.IO;
using System.Reflection;
using System.ComponentModel.Composition;

namespace OpenCookly.Common.Bootstrap.StartupTasks
{
	public class SetupModules : IStartupTask
	{
		#region IStartupTask implementation
		public void Run ()
		{
			//An aggregate catalog that combines multiple catalogs
			var catalog = new AggregateCatalog ();

			//Add all the parts found in all assemblies in
			//the same directory as the executing program
			catalog.Catalogs
				.Add (new DirectoryCatalog (
					Path.GetDirectoryName (Assembly.GetExecutingAssembly ().Location)
					, "OpenCookly.Modules.*.dll")
			);

			//Create the CompositionContainer with the parts in the catalog.
			CompositionContainer container = new CompositionContainer (catalog);

			//Fill the imports of this object
			container.ComposeParts (BootStrapper.Instance);

			//Initialize modules
			foreach (var module in BootStrapper.Instance.Modules)
				module.Initialize ((IContainer)Bootstrapper.Container);
		}

		public void Reset ()
		{

		}
		#endregion
	}
}

