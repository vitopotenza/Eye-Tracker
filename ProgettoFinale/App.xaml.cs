using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Tobii.Interaction;
using Tobii.Interaction.Wpf;

namespace ProgettoFinale
{
    /// <summary>
    /// Logica di interazione per App.xaml
    /// </summary>
    public partial class App : Application
    
    {
        public static Host Host { get; set; }
        public static WpfInteractorAgent WpfInteractorAgent { get; set; }


        protected override void OnStartup(StartupEventArgs e)
        {
            Host = new Host();
            WpfInteractorAgent = Host.InitializeWpfAgent();
        }

        protected override void OnExit(ExitEventArgs e)
        {
            Host.Dispose();
            base.OnExit(e);
        }
    }
}

