using System.Collections.ObjectModel;
using System.Security.Cryptography;
using System.Windows;
using System.Windows.Controls;
using Caliburn.Micro;
using HSMS.Caliburn.App.Helpers;
using HSMS.Caliburn.App.Models;
using HSMS.Caliburn.App.Views;
using MvvmDialogs;

namespace HSMS.Caliburn.App.ViewModels
{
    public class MainViewModel : Conductor<object>
    {
        readonly IWindowManager _windowManager;
        readonly IDialogService _dialogService;

        private ObservableCollection<College> _colleges;

        public ObservableCollection<College> Colleges
        {
            get => _colleges;
            set
            {
                _colleges = value;
                NotifyOfPropertyChange(() => _colleges);
            }
        }

        private string _promptResult;
        private string _userName;
        private string _userPwd;
        private College _selectedCollege;

        public string PromptResult
        {
            get => _promptResult;
            set
            {
                _promptResult = value;
                NotifyOfPropertyChange(() => _promptResult);
            }
        }

        public string UserName
        {
            get => _userName;
            set
            {
                _userName = value;
                NotifyOfPropertyChange(() => _userName);
                NotifyOfPropertyChange(() => CanSignIn);
            }
        }

        public string UserPwd
        {
            get => _userPwd;
            set
            {
                _userPwd = value;
                NotifyOfPropertyChange(() => _userPwd);
                NotifyOfPropertyChange(() => CanSignIn);
            }
        }

        public College SelectedCollege
        {
            get => _selectedCollege;
            set
            {
                _selectedCollege = value;
                NotifyOfPropertyChange(() => _selectedCollege);
                NotifyOfPropertyChange(() => CanSignIn);
            }
        }

        public MainViewModel() : this(new WindowManager(), new DialogService())
        {

        }

        public MainViewModel(IWindowManager windowManager, IDialogService dialogService)
        {
            _windowManager = windowManager;
            _dialogService = dialogService;

            DisplayName = @"Hugo Student Management System v1.0";

            Colleges = new ObservableCollection<College>();
            var list = SqlHelper.GetAllColleges();

            foreach (var item in list)
            {
                Colleges.Add(new College { Idx = item.Idx, Name = item.Name });
            }
        }

        public void SignUp()
        {
            MessageBox.Show("Sign UPP!!");
            // Later
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="source"></param>
        public void OnPasswordChanged(PasswordBox source)
        {
            UserPwd = source.Password;
        }

        public bool CanSignIn
        {
            get => !(string.IsNullOrEmpty(UserName) ||
                     string.IsNullOrEmpty(UserPwd) ||
                    SelectedCollege is null);
        }

        public void SignIn()
        {
            PromptResult = string.Empty;

            //if (HugoCore.Utils.StringUtils.IsAnyNullOrEmpty(UserName, UserPwd))
            //{
            //    DialogViewModel dialogVM = new DialogViewModel();
            //    dialogVM.DisplayName = $"정확한 정보를 입력하세요";
            //    bool? success = _windowManager.ShowDialog(dialogVM);
            //    return;
            //}

            //if (SelectedCollege is null)
            //{
            //    DialogViewModel dialogVM = new DialogViewModel();
            //    dialogVM.DisplayName = $"단과대학을 선택하세요";
            //    bool? success = _windowManager.ShowDialog(dialogVM);
            //    return;
            //}

            // CanExecute 속성하고 나면 위는 필요없음
            // DB처리 아이디, 패스워드, 단과대아이디가 맞는지
            // MD5 변경
            string strTemp = UserPwd;
            var mdHash = MD5.Create();
            var passResult = Commons.GetMd5Hash(mdHash, strTemp);

            var result = SqlHelper.CheckUserLogin(UserName, passResult, SelectedCollege.Idx);
            if (result == 1)
            {
                MajorViewModel majorVM = new MajorViewModel();
                _windowManager.ShowWindow(majorVM, null, null);

                TryClose();
            }
            else
            {
                DialogViewModel dialogVM = new DialogViewModel();
                dialogVM.DisplayName = $"로그인 실패!";
                bool? success = _windowManager.ShowDialog(dialogVM);
                return;
            }
        }
    }
}
