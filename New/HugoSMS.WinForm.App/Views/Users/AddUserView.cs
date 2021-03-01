using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HugoSMS.WinForm.App.Business;
using HugoSMS.WinForm.App.Helpers;
using HugoSMS.WinForm.App.Models;
using MetroFramework;
using MetroFramework.Controls;
using static System.String;

namespace HugoSMS.WinForm.App.Views.Users
{
    public partial class AddUserView : MetroUserControl
    {
        public AddUserView()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 사용자 버튼 클릭 이벤트 핸들러
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            User tmpUser = new User(); // 임시 사용자 객체 만들기

            tmpUser.UserIdentityNumber = TxtIdNumber.Text.Trim();
            tmpUser.UserName = TxtName.Text.Trim();
            tmpUser.UserSurname = TxtSurName.Text.Trim();
            tmpUser.UserEmail = TxtEmail.Text.Trim();
            tmpUser.UserPassword = TxtPassword.Text.Trim();
            tmpUser.UserAdmin = CboAdmin.SelectedItem.Equals("Yes") ? true : false;
            tmpUser.UserActivated = CboActivated.SelectedItem.Equals("Yes") ? true : false;

            var result = DataAccess.SetUsers(tmpUser);
            if (result == 1)
            {
                COMMONS.LOGGER.Info("New User registered!");
                if (MetroMessageBox.Show(this, "새 사용자를 저장했습니다", "저장성공", MessageBoxButtons.OK,
                    MessageBoxIcon.Information) == DialogResult.OK)
                {
                    ((MainView)Parent.Parent).ChangeView<UserView>();
                }
            }
            else
            {
                MetroMessageBox.Show(this, "사용자 저장 실패했습니다. 관리자에게 문의하세요", "저장실패", MessageBoxButtons.OK, MessageBoxIcon.Error);
                COMMONS.LOGGER.Error("New User registeration failed");
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            ((MainView)Parent.Parent).ChangeView<UserView>();
        }

        private void AddUserView_Load(object sender, EventArgs e)
        {
            try
            {
                CboAdmin.DropDownStyle = CboActivated.DropDownStyle = ComboBoxStyle.DropDownList;
                CboAdmin.Items.Add("Yes");
                CboAdmin.Items.Add("No");
                CboActivated.Items.Add("Yes");
                CboActivated.Items.Add("No");
                CboAdmin.SelectedIndex = CboActivated.SelectedIndex = 0;

                TxtIdNumber.Focus();
            }
            catch (Exception ex)
            {
                COMMONS.LOGGER.Error(ex, "AddUserView initialization error");
                MetroMessageBox.Show(this, "초기화 오류 발생, 관리자에게 문의하세요.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        /// <summary>
        /// ID넘버 중복을 DB에서 찾음
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtIdNumber_Leave(object sender, EventArgs e)
        {
            ValidateTextBoxControls(((TextBox)sender).Name);
        }

        private void ValidateTextBoxControls(string textboxName)
        {
            switch (textboxName.ToUpper())
            {
                case "TXTIDNUMBER":
                    if (IsNullOrEmpty(TxtIdNumber.Text))
                    {
                        LblIDNumberExist.Text = @"ID number is empty";
                        LblIDNumberExist.Visible = true;
                        BtnAdd.Enabled = false;

                    }
                    else if (TxtIdNumber.Text.Trim().Length != 12 || !COMMONS.IsDigitsOnly(TxtIdNumber.Text.Trim()))
                    {
                        LblIDNumberExist.Text = @"ID number has to only number and 12 digits";
                        LblIDNumberExist.Visible = true;
                        BtnAdd.Enabled = false;
                    }
                    else
                    {
                        // DB에서 같은 ID넘버확인
                        var result = DataAccess.GetUsers().Count(s => s.UserIdentityNumber.Equals(TxtIdNumber.Text.Trim()));
                        if (result > 0)
                        {
                            LblIDNumberExist.Text = @"ID number already exists!";
                            LblIDNumberExist.Visible = true;
                            BtnAdd.Enabled = false;
                        }
                        else
                        {
                            LblIDNumberExist.Visible = false;
                        }
                    }
                    break;

                case "TXTNAME": // 
                    if (IsNullOrEmpty(TxtName.Text))
                    {
                        LblInvalidName.Visible = true;
                        BtnAdd.Enabled = false;
                    }
                    else
                    {
                        LblInvalidName.Visible = false;
                    }
                    break;

                case "TXTSURNAME":
                    if (IsNullOrEmpty(TxtSurName.Text))
                    {
                        LblInvalidSurname.Visible = true;
                        BtnAdd.Enabled = false;
                    }
                    else
                    {
                        LblInvalidSurname.Visible = false;
                    }
                    break;

                case "TXTEMAIL":
                    if (IsNullOrEmpty(TxtEmail.Text))
                    {
                        LblEmailExist.Text = @"Email is empty";
                        LblEmailExist.Visible = true;
                        BtnAdd.Enabled = false;
                    }
                    else if (COMMONS.IsValidEmail(TxtEmail.Text.Trim()))
                    {
                        LblInvalidEmail.Visible = true;
                        BtnAdd.Enabled = false;
                    }
                    else
                    {
                        var result = DataAccess.GetUsers().Count(s => s.UserEmail.Equals(TxtEmail.Text.Trim()));
                        if (result > 0)
                        {
                            LblEmailExist.Text = @"Email is duplicated";
                            LblEmailExist.Visible = true;
                            BtnAdd.Enabled = false;
                        }
                        else
                        {
                            LblEmailExist.Visible = false;
                            LblInvalidEmail.Visible = false;
                        }
                        
                    }
                    break;

                case "TXTPASSWORD":
                    if (IsNullOrEmpty(TxtPassword.Text))
                    {
                        LblInvalidPassword.Visible = true;
                        BtnAdd.Enabled = false;
                    }
                    else
                    {
                        LblInvalidPassword.Visible = false;
                        BtnAdd.Enabled = true;
                    }
                    break;

                default:
                    break;
            }

            
        }

        private void TxtName_Leave(object sender, EventArgs e)
        {
            ValidateTextBoxControls(((TextBox)sender).Name);
        }

        private void TxtSurName_Leave(object sender, EventArgs e)
        {
            ValidateTextBoxControls(((TextBox)sender).Name);
        }

        private void TxtEmail_Leave(object sender, EventArgs e)
        {
            ValidateTextBoxControls(((TextBox)sender).Name);
        }

        private void TxtPassword_Leave(object sender, EventArgs e)
        {
            ValidateTextBoxControls(((TextBox)sender).Name);
        }
    }
}
