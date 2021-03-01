using System;
using System.Windows.Forms;
using HugoSMS.WinForm.App.Helpers;
using HugoSMS.WinForm.App.Views.Items;
using HugoSMS.WinForm.App.Views.Users;
using MetroFramework;

namespace HugoSMS.WinForm.App.Views
{
    public partial class MainView : UserControl
    {
        public MainView()
        {
            InitializeComponent();
        }

        public void ChangeView<T>() where T : Control, new()
        {
            try
            {
                MainPanel.Controls.Clear();
                T find = new T { Parent = MainPanel, Dock = DockStyle.Fill };
                find.BringToFront();
                COMMONS.LOGGER.Info("MainView change succeed!");
            }
            catch (Exception e)
            {
                COMMONS.LOGGER.Error(e, "MainView change error!");
            }
        }

        private void BtnBooks_Click(object sender, EventArgs e)
        {
            if (COMMONS.IS_SCAN != true)
            {
                COMMONS.LOGGER.Info("BookView change!");
                ChangeView<BookView>();
            }
        }

        private void BtnUsers_Click(object sender, EventArgs e)
        {
            if (COMMONS.IS_SCAN != true)
            {
                if (COMMONS.LOGGED_IN_USER.UserAdmin != true)
                {
                    MetroMessageBox.Show(this, "죄송합니다. 사용자 메뉴에 접근할 권한이 없습니다.");
                    COMMONS.LOGGER.Error("Admin permission error!");
                    return;
                }
                else
                {
                    COMMONS.LOGGER.Info("UserView change!");
                    ChangeView<UserView>();
                }
            }
        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            if (COMMONS.IS_SCAN != true)
            {
                if (MetroMessageBox.Show(this, "로그아웃 하시겠습니까?", "로그아웃", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    COMMONS.LOGGED_IN_USER = null;
                    ((MainForm)this.Parent.Parent).ChangeView<LoginView>();
                }
            }
        }
    }
}
