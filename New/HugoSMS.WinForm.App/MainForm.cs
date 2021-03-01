using System;
using System.Windows.Forms;
using HugoSMS.WinForm.App.Helpers;
using HugoSMS.WinForm.App.Views;
using MetroFramework;
using MetroFramework.Forms;

namespace HugoSMS.WinForm.App
{
    public partial class MainForm : MetroForm
    {
        //public User LoggedInUser;

        public MainForm()
        {
            InitializeComponent();
            this.Load += OnLoad;
        }

        private void OnLoad(object sender, EventArgs e)
        {
            ChangeView<LoginView>();
        }

        public void ChangeView<T>() where T : Control, new()
        {
            try
            {
                CustPanel.Controls.Clear();
                T find = new T {Parent = CustPanel, Dock = DockStyle.Fill};
                find.BringToFront();
                COMMONS.LOGGER.Info("ChangeView change succeed!");
            }
            catch (Exception e)
            {
                COMMONS.LOGGER.Error(e, "ChangeView change error!");
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (COMMONS.IS_SCAN != true)
            {
                if (MetroMessageBox.Show(this, "종료하시겠습니까?", "종료", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    COMMONS.LOGGER.Info("Program terminated");
                    Environment.Exit(0);
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}