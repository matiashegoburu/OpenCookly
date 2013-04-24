using System;
using System.Collections.Generic;
using StructureMap;
using Hegoburu.Presentation.Desktop.Core;

namespace OpenCookly.Common.Modules
{
    public interface IModule
    {
        string Name { get; }
        string Description { get; }
        IViewManager ViewManager { get; set; }
        IModelManager ModelManager { get; set; }
        List<IActivity> Activities { get; }

        void Initialize(IContainer container);
    }
}

