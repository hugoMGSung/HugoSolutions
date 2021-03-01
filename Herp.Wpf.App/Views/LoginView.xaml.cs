using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Herp.Wpf.App.Models;
using Herp.Wpf.App.Processors;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;

namespace Herp.Wpf.App.Views
{
    /// <summary>
    /// LoginView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class LoginView : MetroWindow
    {
        private readonly MainView _parentView;

        private LoginProc _loginProc;

        public LoginView(MainView parentView)
        {
            InitializeComponent();
            _loginProc = new LoginProc();

            _parentView = parentView;

            InitMainEvents();
            InitControlEvents();
            TxtUserId.Focus();
        }

        /// <summary>
        /// 컨트롤 이벤트 설정
        /// </summary>
        private void InitControlEvents()
        {
            TxtUserId.TextChanged += TxtUserIdOnTextChanged;
            TxtPassword.PasswordChanged += TxtPasswordOnPasswordChanged;
            TxtPassword.KeyDown += (sender, args) =>
            {
                if (args.Key == Key.Enter)
                    BtnSignInOnClick(sender, args);
            };

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

        private async void BtnSignInOnClick(object sender, RoutedEventArgs e)
        {
            // 패스워드 확인
            //var result = await this.ShowInputAsync("Hello!", "What is your name?");
            //if (result == null) return;

            //await this.ShowMessageAsync("SignIn", $"{TxtPassword.Password}");
            var paramUser = new Users {
                UserId = TxtUserId.Text.Trim(), 
                Password = TxtPassword.Password.Trim()
            };
            var result = _loginProc.CheckUserInfo(paramUser);
            if (result)
            {
                // 로그인하고 창 닫고 메인화면으로 넘어가기
                _parentView.IsActiveWin = true;
                this.Hide();
            }
            else
            {
                await this.ShowMessageAsync("SignIn", $"Incorrect Information!!");
            }

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
