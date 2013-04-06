using System;
using System.ComponentModel.Composition;
using OpenCookly.Common;
using System.ComponentModel.Composition.Hosting;
using System.Collections.Generic;
using StructureMap;
using System.IO;
using System.Reflection;
using NHibernate;
using Hegoburu.DAL.Core;
using Hegoburu.DAL.Core.NHibernate;
using Bootstrap;
using Bootstrap.StructureMap;
using Bootstrap.Extensions.StartupTasks;
using OpenCookly.Common.Bootstrap.StartupTasks;
using OpenCookly.Common.Modules;

namespace OpenCookly.Common.Bootstrap
{
    public class BootStrapper
    {
        [ImportMany(typeof(IModule))]
        private IEnumerable<IModule>
            _modules;

        public IEnumerable<IModule> Modules
        {
            get { return _modules;}
        }

        protected static BootStrapper _instance;
        public static BootStrapper Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new BootStrapper();

                return _instance;
            }
        }

        public static void Run()
        {
            Instance.Bootstrap();
        }

        public void Bootstrap()
        {
            Bootstrapper
				.With
					.StructureMap()
					.And.StartupTasks()
						.UsingThisExecutionOrder(o => o.First<SetupServiceLocator>())
				.Start();
        }
    }
}

