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

namespace HugoSMS.WinForm.App.Views.Users
{
    public partial class DeactivateUserView : MetroUserControl
    {
        private List<User> users;

        public DeactivateUserView()
        {
            InitializeComponent();
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

        private void BtnBack_Click(object sender, EventArgs e)
        {
            ((MainView)Parent.Parent).ChangeView<UserView>();
        }

        /// <summary>
        /// 그리드뷰 선택값 변경 이벤트 핸들러
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvUsers_SelectionChanged(object sender, EventArgs e)
        {
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            DgvUsers.Rows.Clear();

            if (!string.IsNullOrEmpty(TxtSearch.Text))
            {
                // 검색
                if (users.Count > 0)
                {
                    var results = (from user in users
                        where user.UserName.Contains(TxtSearch.Text) ||
                              user.UserIdentityNumber.Contains(TxtSearch.Text)
                        select user).ToList();

                    DisplayGridView(results);
                }
            }
            else
            {
                DisplayGridView(users);
            }
        }

        private void DeactivateUserView_Load(object sender, EventArgs e)
        {
            try
            {
                DgvUsers.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                DgvUsers.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DgvUsers.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                DgvUsers.Rows.Clear();
                var temps = Business.DataAccess.GetUsers();
                users = temps;
                DisplayGridView(users);

                DgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                DgvUsers.ClearSelection();
            }
            catch (Exception ex)
            {
                COMMONS.LOGGER.Error(ex, "EditUserView initialization error");
                MetroMessageBox.Show(this, "초기화 오류 발생, 관리자에게 문의하세요.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnDeactivate_Click(object sender, EventArgs e)
        {
            if (DgvUsers.SelectedRows.Count == 0)
            {
                MetroMessageBox.Show(this, "비활성화할 계정을 선택하세요.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedId = Convert.ToInt32(DgvUsers.SelectedRows[0].Cells[0].Value);
            var user = Business.DataAccess.GetUsers().Where(s => s.UserID == selectedId).FirstOrDefault();
            if (user != null)
            {
                user.UserActivated = false;
                DataAccess.SetUsers(user);

                COMMONS.LOGGER.Info("Exist User deactivated!");
                if (MetroMessageBox.Show(this, "사용자를 비활성화했습니다", "비활성화성공", MessageBoxButtons.OK,
                    MessageBoxIcon.Information) == DialogResult.OK)
                {
                    ((MainView)Parent.Parent).ChangeView<UserView>();
                }
            }
            else
            {
                MetroMessageBox.Show(this, "사용자 비활성화 실패했습니다. 관리자에게 문의하세요", "비활성화실패", MessageBoxButtons.OK, MessageBoxIcon.Error);
                COMMONS.LOGGER.Error("Exist User deactivation failed");
            }
        }
    }
}
