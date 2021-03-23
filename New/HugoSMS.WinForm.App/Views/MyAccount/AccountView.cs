using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HugoSMS.WinForm.App.Helpers;
using MetroFramework;

namespace HugoSMS.WinForm.App.Views.MyAccount
{
    public partial class AccountView : UserControl
    {
        public AccountView()
        {
            InitializeComponent();
        }

        private void AccountView_Load(object sender, EventArgs e)
        {
            try
            {
                LblUserID.Text = COMMONS.LOGGED_IN_USER.UserID.ToString();
                LblIdentityNum.Text = COMMONS.LOGGED_IN_USER.UserIdentityNumber;
                LblUserName.Text = COMMONS.LOGGED_IN_USER.UserName;
                LblUserSurname.Text = COMMONS.LOGGED_IN_USER.UserSurname;
                LblUserEmail.Text = COMMONS.LOGGED_IN_USER.UserEmail;
                LblUserAdmin.Text = COMMONS.LOGGED_IN_USER.UserAdmin.ToString();
                LblUserActivated.Text = COMMONS.LOGGED_IN_USER.UserActivated.ToString();

            }
            catch (Exception ex)
            {
                COMMONS.LOGGER.Error($"Error occured : {ex.Message}");
                MetroMessageBox.Show(this, "계정정보 로드 오류 발생", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void BtnUpdateAccount_Click(object sender, EventArgs e)
        {
            ((MainView)this.Parent.Parent).ChangeView<EditAccountView>();
        }
    }
}
