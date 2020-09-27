using System;
using System.Windows.Forms;
using HERP.Origin.App.Business;
using HERP.Origin.App.Helpers;

namespace HERP.Origin.App.Views
{
    public partial class LoginForm : Form
    {
        private LoginProc business;

        public LoginForm()
        {
            InitializeComponent();

            business = new LoginProc();
            Commons.NLogger.Info("로그인창 오픈!");

            if (!string.IsNullOrEmpty(Commons.RegUserId))
            {
                TxtUserId.Text = Commons.RegUserId;
                TxtUserPwd.Focus();
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            var userId = TxtUserId.Text.Trim();
            var userPwd = TxtUserPwd.Text.Trim();
            var result = business.CheckUserInfo(userId, userPwd);

            if (result == 1)
            {
                CurrentUser.UserId = userId;
                CurrentUser.LoginDt = DateTime.Now;

                MessageBox.Show(@"로그인 했습니다", @"로그인", 
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            } 
            // 실패했을때 처리 나중에...
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            BtnOk.Enabled = false;
        }

        private void TxtUserPwd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) // 엔터를 했을때 
            {
                if (TxtUserId.Text.Length >= 0 && TxtUserPwd.Text.Length >= 0)
                {
                    BtnOk_Click(sender, new EventArgs());
                }
            }
            else
            {
                if (TxtUserId.Text.Length >= 0 && TxtUserPwd.Text.Length >= 0)
                {
                    BtnOk.Enabled = true;
                }
            }
        }
    }
}
