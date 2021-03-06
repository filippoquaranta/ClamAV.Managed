﻿using System.Windows;
using ClamAV.Managed.Samples.AsyncGui.ViewModel;

namespace ClamAV.Managed.Samples.AsyncGui
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var mainWindow = new MainWindow { DataContext = new MainWindowViewModel() };

            mainWindow.Show();
        }
    }
}
