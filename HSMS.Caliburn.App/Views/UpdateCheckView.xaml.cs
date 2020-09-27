using System;
using System.ComponentModel;
using System.Globalization;
using System.Reflection;
using System.Threading;
using System.Windows;
using System.Windows.Threading;
using AutoUpdaterDotNET;
using Caliburn.Micro;
using HSMS.Caliburn.App.ViewModels;
using MahApps.Metro.Controls;

namespace HSMS.Caliburn.App.Views
{
    /// <summary>
    /// UpdateCheckView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class UpdateCheckView : MetroWindow
    {
        private string updateUrl = "http://localhost/updates/AutoUpdateCheck.xml";
        public UpdateCheckView()
        {
            InitializeComponent();

            Assembly assembly = Assembly.GetEntryAssembly();
            LabelVersion.Content = $"Current Version : {assembly.GetName().Version}";
            Thread.CurrentThread.CurrentCulture =
                Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture("ko");
            AutoUpdater.LetUserSelectRemindLater = true;
            AutoUpdater.RemindLaterTimeSpan = RemindLaterFormat.Minutes;
            AutoUpdater.RemindLaterAt = 1;
            AutoUpdater.ReportErrors = true;
            DispatcherTimer timer = new DispatcherTimer { Interval = TimeSpan.FromMinutes(2) };
            timer.Tick += delegate { AutoUpdater.Start(updateUrl); };
            timer.Start();
        }

        private void ButtonCheckForUpdate_Click(object sender, RoutedEventArgs e)
        {
            AutoUpdater.Start(updateUrl);
        }

        IWindowManager manager = new WindowManager();

        private void Window_Closing(object sender, CancelEventArgs e)
        {
            manager.ShowWindow(new MainViewModel(), null, null);
        }
    }
}
