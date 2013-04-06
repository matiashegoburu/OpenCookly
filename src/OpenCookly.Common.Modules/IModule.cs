using System;
using System.Collections.Generic;
using StructureMap;

namespace OpenCookly.Common.Modules
{
    public interface IModule
    {
        string Name { get; }
        string Description { get; }
        List<IActivity> Activities { get; }

        void Initialize(IContainer container);
    }
}

