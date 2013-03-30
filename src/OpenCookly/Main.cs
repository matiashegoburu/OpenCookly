using System;
using Gtk;
using Mono.Data.Sqlite;
using System.Data;

namespace OpenCookly
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            OpenCookly.Common.Bootstrap.BootStrapper.Run();

            Application.Init();
            MainWindow win = new MainWindow();
            win.Show();
            Application.Run();
        }
    }
}
