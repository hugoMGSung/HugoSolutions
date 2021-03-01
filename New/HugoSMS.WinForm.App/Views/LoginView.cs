using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HugoSMS.WinForm.App.Helpers;
using HugoSMS.WinForm.App.Models;
using NLog;

namespace HugoSMS.WinForm.App.Views
{
    public partial class LoginView : UserControl
    {
        public LoginView()
        {
            InitializeComponent();
        }

        public void ChangeLocation()
        {
            PnlLogin.Left = (ClientSize.Width - PnlLogin.Width) / 2;
            PnlLogin.Top = (ClientSize.Height - PnlLogin.Height) / 2;
        }

        private void LoginView_Load(object sender, EventArgs e)
        {
            LblResult.Visible = false;
            TxtPassword.UseSystemPasswordChar = true;
            ChangeLocation();
        }

        private void LoginView_ClientSizeChanged(object sender, EventArgs e)
        {
            ChangeLocation();
        }

        private void ChkDispPassword_CheckedChanged(object sender, EventArgs e)
        {
            TxtPassword.UseSystemPasswordChar = !ChkDispPassword.Checked;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(TxtEmail.Text) ||
                    string.IsNullOrEmpty(TxtPassword.Text))
                {
                    LblResult.Visible = true;
                }
                else
                {
                    LblResult.Visible = false;
                    var email = TxtEmail.Text;
                    var password = TxtPassword.Text;
                    var isOurUser = Business.DataAccess.GetUsers()
                        .Where(u => u.UserEmail.Equals(email) && u.UserPassword.Equals(password)).ToList().Count();
                    if (isOurUser == 0)
                        LblResult.Visible = true;
                    else
                    {
                        User user = Business.DataAccess.GetUsers().Where(u => u.UserEmail.Equals(email))
                            .FirstOrDefault();
                        COMMONS.LOGGED_IN_USER = user;
                        ((MainForm)this.Parent.Parent).ChangeView<MainView>();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("로그인 실패! 관리자에게 문의하세요");
                COMMONS.LOGGER.Error(ex);
            }
        }

        private void TxtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                TxtPassword.Focus();
            }
        }

        private void TxtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                BtnLogin_Click(sender, e);
            }
        }
    }
}
