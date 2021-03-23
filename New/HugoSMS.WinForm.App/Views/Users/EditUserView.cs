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
    public partial class EditUserView : MetroUserControl
    {
        private List<User> users;

        public EditUserView()
        {
            InitializeComponent();
        }

        private void EditUserView_Load(object sender, EventArgs e)
        {
            try
            {
                // DB에서 가져오기
                CboAdmin.DropDownStyle = CboActivated.DropDownStyle = ComboBoxStyle.DropDownList;
                CboAdmin.Items.Add("Yes");
                CboAdmin.Items.Add("No");
                CboActivated.Items.Add("Yes");
                CboActivated.Items.Add("No");
                CboAdmin.SelectedIndex = CboActivated.SelectedIndex = 0;

                DgvUsers.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                DgvUsers.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DgvUsers.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                lblIdentityNo.Visible =
                    lblName.Visible = lblSurname.Visible = lblEmail.Visible = lblPassword.Visible = false;
                lblAdmin.Visible = false;

                RboAll.Select(); // Radio Button Changed!
            }
            catch (Exception ex)
            {
                COMMONS.LOGGER.Error(ex, "EditUserView initialization error");
                MetroMessageBox.Show(this, "초기화 오류 발생, 관리자에게 문의하세요.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 모든 라이오버튼 클릭 이벤트 변경 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            DgvUsers.Rows.Clear();
            List<User> temps = Business.DataAccess.GetUsers();

            if (RboAll.Checked)
            {
                users = temps;
                DisplayGridView(users);
            }
            else if (RboActivated.Checked)
            {
                users = temps.Where(s => s.UserActivated).ToList();
                DisplayGridView(users);
            }
            else if (RboDeactivated.Checked)
            {
                users = temps.Where(s => s.UserActivated == false).ToList();
                DisplayGridView(users);
            }
            else
            {
                DgvUsers.Rows.Clear();
            }
            DgvUsers.ClearSelection();
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
        /// 수정버튼 클릭 이벤트 핸들러
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            lblIdentityNo.Visible = lblName.Visible = lblSurname.Visible =
                lblAdmin.Visible = lblPassword.Visible = lblEmail.Visible = LblUserID.Visible = false;

            // 각 값에 대한 필터링
            if (string.IsNullOrEmpty(TxtIdNumber.Text))
            {
                lblIdentityNo.Text = @"고유번호가 비어있습니다.";
                lblIdentityNo.Visible = true;
                return;
            }

            if (string.IsNullOrEmpty(TxtName.Text))
            {
                lblName.Text = @"이름이 비어있습니다.";
                lblName.Visible = true;
                return;
            }

            if (string.IsNullOrEmpty(TxtSurName.Text))
            {
                lblSurname.Text = @"성이 비어있습니다.";
                lblSurname.Visible = true;
                return;
            }

            if (string.IsNullOrEmpty(TxtEmail.Text))
            {
                lblEmail.Text = @"이메일 주소가 비어있습니다.";
                lblEmail.Visible = true;
                return;
            }

            if (string.IsNullOrEmpty(TxtPassword.Text))
            {
                lblPassword.Text = @"패스워드를 입력하세요.";
                lblPassword.Visible = true;
                return;
            }

            try
            {
                User tmpUser = new User();
                tmpUser.UserID = int.Parse(LblUserID.Text);
                tmpUser.UserIdentityNumber = TxtIdNumber.Text.Trim();
                tmpUser.UserName = TxtName.Text.Trim();
                tmpUser.UserSurname = TxtSurName.Text.Trim();
                tmpUser.UserEmail = TxtEmail.Text.Trim();
                tmpUser.UserPassword = TxtPassword.Text.Trim();
                tmpUser.UserAdmin = CboAdmin.SelectedItem.Equals("Yes");
                tmpUser.UserActivated = CboActivated.SelectedItem.Equals("Yes");

                var result = DataAccess.SetUsers(tmpUser);

                if (result == 1)
                {
                    COMMONS.LOGGER.Info("Exist User updated!");
                    if (MetroMessageBox.Show(this, "사용자를 수정했습니다", "수정성공", MessageBoxButtons.OK,
                        MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        ((MainView)Parent.Parent).ChangeView<UserView>();
                    }
                }
                else
                {
                    MetroMessageBox.Show(this, "사용자 수정 실패했습니다. 관리자에게 문의하세요", "수정실패", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    COMMONS.LOGGER.Error("Exist User update failed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error : {ex.Message}");
            }

        }

        /// <summary>
        /// 그리드뷰 선택값 변경 이벤트 핸들러
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvUsers_SelectionChanged(object sender, EventArgs e)
        {
            lblAdmin.Visible = false;
            CboAdmin.Enabled = CboActivated.Enabled = true;

            try
            {
                if (DgvUsers.SelectedRows.Count == 1)
                {
                    using (DataGridViewRow item = DgvUsers.SelectedRows[0])
                    {
                        var idx = item.Index;

                        LblUserID.Text = item.Cells[0].Value.ToString();
                        TxtIdNumber.Text = item.Cells[1].Value.ToString();
                        TxtName.Text = item.Cells[2].Value.ToString();
                        TxtSurName.Text = item.Cells[3].Value.ToString();
                        TxtEmail.Text = item.Cells[4].Value.ToString();
                        TxtPassword.Text = string.Empty;

                        CboAdmin.SelectedIndex = (bool) item.Cells[5].Value ? 0 : 1;
                        CboActivated.SelectedIndex = (bool) item.Cells[6].Value ? 0 : 1;
                    }
                }
            }
            catch (Exception ex)
            {
                COMMONS.LOGGER.Error(ex, "DataGridView selection error");
                MetroMessageBox.Show(this, "그리드뷰 선택 오류 발생, 관리자에게 문의하세요.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
    }
}
