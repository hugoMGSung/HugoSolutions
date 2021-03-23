using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using HugoSMS.WinForm.App.Helpers;
using MetroFramework;

namespace HugoSMS.WinForm.App.Views.MyAccount
{
    public partial class EditAccountView : UserControl
    {
        string _emailUpdateCheck;
        string _emailUpdateCheckCompare;

        public EditAccountView()
        {
            InitializeComponent();
        }

        private void EditAccountView_Load(object sender, EventArgs e)
        {
            try
            {
                ChangeLabelsVisible(false);

                //Margo
                if (COMMONS.LOGGED_IN_USER.UserAdmin == false)
                {
                    CboAdmin.Enabled = false;
                    CboActivated.Enabled = false;

                }
                int amountAdmin = Business.DataAccess.GetUsers().Where(u => u.UserActivated && u.UserAdmin).ToList().Count;
                if (amountAdmin < 2 && COMMONS.LOGGED_IN_USER.UserAdmin)
                {
                    CboAdmin.Enabled = false;
                    CboActivated.Enabled = false;
                    LblAdmin.Visible = true;
                }

                var cboValues = new List<string> {"Yes", "No"};

                CboAdmin.DataSource = cboValues;
                CboActivated.DataSource = cboValues;

                LblUserID.Text = COMMONS.LOGGED_IN_USER.UserID.ToString();

                var user = COMMONS.LOGGED_IN_USER;
                TxtPassword.Text = user.UserPassword;
                TxtIdentityNo.Text = user.UserIdentityNumber;
                TxtUserName.Text = user.UserName;
                TxtUserSurname.Text = user.UserSurname;
                TxtUserEmail.Text = user.UserEmail;

                string isAdminActivated = "";
                string isUserActivated = "";

                isAdminActivated = user.UserAdmin ? "Yes" : "No";
                isUserActivated = user.UserActivated ? "Yes" : "No";

                CboAdmin.Text = isAdminActivated;
                CboActivated.Text = isUserActivated;

                _emailUpdateCheckCompare = TxtUserEmail.Text;
            }
            catch (Exception ex)
            {
                COMMONS.LOGGER.Error($"Error occured : {ex.Message}");
                MetroMessageBox.Show(this, "Sorry Something went wrong, the action was not completed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            ((MainView)Parent.Parent).ChangeView<AccountView>();
        }

        private void ChangeLabelsVisible(bool isVisible)
        {
            LblUserSurname.Visible = isVisible;
            LblPassword.Visible = isVisible;
            LblUserName.Visible = isVisible;
            LblIdentityNo.Visible = isVisible;
            LblUserEmail.Visible = isVisible;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                ChangeLabelsVisible(false);

                var user = COMMONS.LOGGED_IN_USER;

                user.UserName = TxtUserName.Text;
                user.UserSurname = TxtUserSurname.Text;
                user.UserPassword = TxtPassword.Text;

                var emailList = Business.DataAccess.GetUsers().Select(x => x.UserEmail).ToList();
                
                if (!(emailList.Contains(TxtUserEmail.Text)) || _emailUpdateCheck == _emailUpdateCheckCompare)
                {
                    user.UserEmail = TxtUserEmail.Text;
                }
                else
                {
                    LblUserEmail.Visible = true;
                    LblUserEmail.Text = @"등록된 이메일 주소 존재";
                }


                user.UserAdmin = CboAdmin.SelectedItem.Equals("Yes");
                user.UserActivated = CboAdmin.SelectedItem.Equals("Yes");

                //Validation checks
                if (TxtIdentityNo.Text == "" || TxtIdentityNo.Text.Length < 13 || !COMMONS.IsDigitsOnly(TxtIdentityNo.Text))
                {
                    TxtIdentityNo.Visible = true; TxtIdentityNo.Text = @"유요한 ID번호를 입력하세요.";
                }
                if (TxtUserName.Text == "")
                {
                    LblUserName.Visible = true; LblUserName.Text = @"이름을 입력하세요";
                }
                if (TxtUserSurname.Text == "")
                {
                    LblUserSurname.Visible = true; LblUserSurname.Text = @"성을 입력하세요";
                }
                if (TxtUserEmail.Text == "" || !Regex.IsMatch(TxtUserEmail.Text, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase))
                {
                    LblUserEmail.Visible = true; LblUserEmail.Text = @"유효한 이메일 주소를 입력하세요";
                }
                if (TxtPassword.Text == "")
                {
                    LblPassword.Visible = true; LblPassword.Text = @"유요한 패스워드를 입력하세요";
                }

                int isSaved = 0;
                if (LblUserEmail.Visible == false && LblIdentityNo.Visible == false && LblUserName.Visible == false
                    && LblUserSurname.Visible == false && LblPassword.Visible == false)
                {
                    isSaved = Business.DataAccess.SetUsers(user);
                }

                if (isSaved == 0)
                {
                    MetroMessageBox.Show(this, "저장시 문제가 발생했습니다. 관리자에게 문의바랍니다.", "저장오류", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
                else
                {
                    if (MetroMessageBox.Show(this, "정상적으로 수정했습니다.", "수정성공", MessageBoxButtons.OK,
                        MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        ((MainView)this.Parent.Parent).ChangeView<AccountView>();
                    }
                }

            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, $"예외가 발생했습니다. {ex.Message}", "예외발생", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void TxtUserEmail_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtUserEmail.Text))
            {
                _emailUpdateCheck = TxtUserEmail.Text;
            }
        }
    }
}
