using System;
using Gtk;

namespace OpenCookly.Common.Modules
{
    public interface IActivity
    {
        string Name { get; }
        string Description { get; }
        Bin View { get; } 
    }
}

