using System;
using System.ComponentModel;
using MahApps.Metro.Controls;

namespace Herp.Wpf.App.Views
{
    /// <summary>
    /// LoginView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class LoginView : MetroWindow
    {
        private readonly MainView _parentView;

        public LoginView(MainView parentView)
        {
            InitializeComponent();
            _parentView = parentView;

            Closing += OnClosing;
            Closed += OnClosed;
        }

        private void OnClosed(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void OnClosing(object sender, CancelEventArgs e)
        {
            _parentView.IsActiveWin = true;
        }
    }
}
