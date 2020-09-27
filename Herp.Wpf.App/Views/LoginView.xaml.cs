using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
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

            InitMainEvents();
            InitControlEvents();
        }

        /// <summary>
        /// 컨트롤 이벤트 설정
        /// </summary>
        private void InitControlEvents()
        {
            TxtUserId.TextChanged += TxtUserIdOnTextChanged;
            TxtPassword.PasswordChanged += TxtPasswordOnPasswordChanged;

            BtnSignIn.Click += BtnSignInOnClick;
            BtnCancel.Click += BtnCancelOnClick;
        }

        private void TxtPasswordOnPasswordChanged(object sender, RoutedEventArgs e)
        {
            ChangeButtonEnable();
        }

        private void TxtUserIdOnTextChanged(object sender, TextChangedEventArgs e)
        {
            ChangeButtonEnable();
        }

        /// <summary>
        /// 버튼 활성화 변경하기
        /// </summary>
        private void ChangeButtonEnable()
        {
            if (TxtUserId.Text.Length > 0 && TxtPassword.Password.Length > 0)
                BtnSignIn.IsEnabled = true;
            else
                BtnSignIn.IsEnabled = false;
        }

        private void BtnCancelOnClick(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0); // 프로그램 완전 종료
        }

        private void BtnSignInOnClick(object sender, RoutedEventArgs e)
        {
            // 패스워드 확인
            MessageBox.Show(TxtPassword.Password);
        }

        /// <summary>
        /// 창 기본 이벤트 설정
        /// </summary>
        private void InitMainEvents()
        {
            Closing += OnClosing;
            Closed += OnClosed;
        }

        private void OnClosed(object sender, EventArgs e)
        {
            Environment.Exit(0); // 프로그램 완전 종료
        }

        private void OnClosing(object sender, CancelEventArgs e)
        {
            _parentView.IsActiveWin = true;
        }
    }
}
