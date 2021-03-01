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
using MetroFramework.Controls;

namespace HugoSMS.WinForm.App.Views.Users
{
    public partial class EditUserView : MetroUserControl
    {
        public EditUserView()
        {
            InitializeComponent();
        }

        private void EditUserView_Load(object sender, EventArgs e)
        {
            try
            {
                CboAdmin.DropDownStyle = CboActivated.DropDownStyle = ComboBoxStyle.DropDownList;
                CboAdmin.Items.Add("Yes");
                CboAdmin.Items.Add("No");
                CboActivated.Items.Add("Yes");
                CboActivated.Items.Add("No");
                CboAdmin.SelectedIndex = CboActivated.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                COMMONS.LOGGER.Error(ex, "EditUserView initialization error");
                MetroMessageBox.Show(this, "초기화 오류 발생, 관리자에게 문의하세요.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
