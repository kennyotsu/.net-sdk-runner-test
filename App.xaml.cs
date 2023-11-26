using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace LastDock
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        [DllImport("Kernel32.dll")]
        public static extern bool AttachConsole(int processId);

        protected override void OnStartup(StartupEventArgs e)
        {
            AttachConsole(-1);
            Console.WriteLine("Hello world!");
            Console.WriteLine("LastDock has been successfully built and is now running in a Docker .NET Framework container.");
        }
    }
}
