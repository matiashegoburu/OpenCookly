using System;
using Gtk;

namespace OpenCookly.Common.Modules
{
    public interface IActivity<TParameters> : IActivity
    {
        Bin Start(TParameters parameters);
    }
}

