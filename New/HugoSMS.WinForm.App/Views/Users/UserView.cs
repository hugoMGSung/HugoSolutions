using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using HugoSMS.WinForm.App.Helpers;
using HugoSMS.WinForm.App.Models;

namespace HugoSMS.WinForm.App.Views.Users
{
    public partial class UserView : UserControl
    {
        public UserView()
        {
            InitializeComponent();
        }

        private void UserView_Load(object sender, EventArgs e)
        {
            RboAll.Checked = true;
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                DgvUsers.Rows.Clear();
                List<User> temps = Business.DataAccess.GetUsers();
                List<User> users = null;

                if (RboAll.Checked)
                {
                    users = temps;
                    //DgvUsers.DataSource = users;
                    DisplayGridView(users);
                }
                else if (RboActivated.Checked)
                {
                    users = temps.Where(s => s.UserActivated).ToList();
                    DisplayGridView(users);
                }
                else if (RboDeactivated.Checked)
                {
                    users =temps.Where(s => s.UserActivated == false).ToList();
                    DisplayGridView(users);
                }
                else
                {
                    DgvUsers.Rows.Clear();
                }
                DgvUsers.ClearSelection();
            }
            catch (Exception ex)
            {
                COMMONS.LOGGER.Error(ex, "UserView Grid Display error!!");
                return;
            }
        }

        private void DisplayGridView(List<User> users)
        {
            foreach (var user in users)
            {
                DgvUsers.Rows.Add(user.UserID, user.UserIdentityNumber,
                    user.UserName, user.UserSurname, user.UserEmail,
                    user.UserAdmin, user.UserActivated);
            }
        }

        private void BtnAddUser_Click(object sender, EventArgs e)
        {
            var buttonTag = ((Button) sender).Tag.ToString();
            ProcChangeView(buttonTag);
        }

        private void ProcChangeView(string buttonTag)
        {
            switch (buttonTag)
            {
                case "ADD":
                    ((MainView)Parent.Parent).ChangeView<AddUserView>();
                    break;

                case "UPDATE":
                    ((MainView)Parent.Parent).ChangeView<EditUserView>();
                    break;

                case "ACTIVATE": 
                    break;

                default:
                    break;
            }
        }

        private void BtnUpdateUser_Click(object sender, EventArgs e)
        {
            var buttonTag = ((Button)sender).Tag.ToString();
            ProcChangeView(buttonTag);
        }
    }
}
