using System;
using Bootstrap.Extensions.StartupTasks;
using StructureMap.ServiceLocatorAdapter;
using StructureMap;
using Bootstrap;
using Microsoft.Practices.ServiceLocation;

namespace OpenCookly.Common.Bootstrap.StartupTasks
{
	public class SetupServiceLocator : IStartupTask
	{
		#region IStartupTask implementation
		public void Run ()
		{
			var structureMapAdapter = new StructureMapServiceLocator ((IContainer)Bootstrapper.Container);
			ServiceLocator.SetLocatorProvider (() => structureMapAdapter);
		}

		public void Reset ()
		{
		}
		#endregion

	}
}

