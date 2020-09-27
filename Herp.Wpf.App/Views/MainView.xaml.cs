using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;
using System.Windows.Media.Animation;
using MahApps.Metro.Controls;

namespace Herp.Wpf.App.Views
{
    /// <summary>
    /// MainView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainView : MetroWindow
    {
        public MainView()
        {
            InitializeComponent();

            InitPopWindow();
            InitMainEvents();
        }

        private void InitMainEvents()
        {
            ContentRendered += OnContentRendered;
        }

        private void OnContentRendered(object sender, EventArgs e)
        {
            LoginView childWindow = new LoginView(this);
            IsActiveWin = false;
            childWindow.Owner = this;
            IsEnabled = false;
            childWindow.ShowDialog();
            IsEnabled = true;
        }

        #region 팝업윈도우 관련 메서드 

        private enum FadeDirection
        {
            FadeIn,
            FadeOut
        }

        private TransparentAdorner _windowAdorner;

        private bool _isActiveWin = true;
        /// <summary>
        /// 활성 윈도우 여부
        /// </summary>
        public bool IsActiveWin
        {
            get => _isActiveWin;

            set
            {
                if (_isActiveWin == value) return;
                _isActiveWin = value;

                if (_isActiveWin)
                    DettachWindowAdorner();
                else
                    AttachWindowAdorner();
            }
        }

        private void InitPopWindow()
        {
            _windowAdorner = new TransparentAdorner(borderWindow);
        }

        private void AttachWindowAdorner()
        {
            var parentAdorner = AdornerLayer.GetAdornerLayer(borderWindow);
            parentAdorner?.Add(_windowAdorner);

            FadeAnimation(borderWindow, FadeDirection.FadeIn);
        }

        private void DettachWindowAdorner()
        {
            FadeAnimation(borderWindow, FadeDirection.FadeOut);

            AdornerLayer parentAdorner = AdornerLayer.GetAdornerLayer(borderWindow);
            parentAdorner?.Remove(_windowAdorner);
        }

        private void FadeAnimation(Border border, FadeDirection fadeDirection)
        {
            var animFade = new DoubleAnimation();

            if (fadeDirection == FadeDirection.FadeIn)
            {
                animFade.From = 0;
                animFade.To = .10;
            }
            else
            {
                animFade.From = .10;
                animFade.To = 0;
            }

            animFade.Duration = new Duration(TimeSpan.FromSeconds(0.5));
            var brush = new SolidColorBrush { Color = Colors.Black };
            brush.BeginAnimation(Brush.OpacityProperty, animFade);
            border.Background = brush;
        }

        #endregion
    }
}
