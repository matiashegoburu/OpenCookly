using System;
using Gtk;

namespace OpenCookly.Common
{
	public interface IActivity
	{
		string Name { get; }
		string Description { get; }
		Bin MainView { get; } 
		void Run ();
	}
}

