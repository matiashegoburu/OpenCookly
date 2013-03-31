using System;
using OpenCookly.Common;
using System.Collections.Generic;
using System.ComponentModel.Composition;

namespace OpenCookly.Modules.Core
{
    [Export(typeof(IModule))]
    public class Module : IModule
    {
        private List<IActivity> _activities;

        public Module()
        {
            _activities = new List<IActivity>();
        }

        #region IModule implementation
        public void Initialize(StructureMap.IContainer container)
        {

        }

        public string Name
        {
            get
            {
                return "Core";
            }
        }

        public string Description
        {
            get
            {
                return "Core system functionality";
            }
        }

        public List<IActivity> Activities
        {
            get
            {
                return _activities;
            }
        }
        #endregion
		
    }
}

