using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using HugoSMS.WinForm.App.Helpers;
using HugoSMS.WinForm.App.Models;
using iTextSharp.text;
using iTextSharp.text.pdf;

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

            DgvUsers.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DgvUsers.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvUsers.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
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
                    users = temps.Where(s => s.UserActivated == false).ToList();
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

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            var buttonTag = ((Button)sender).Tag.ToString();
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
                    ((MainView)Parent.Parent).ChangeView<DeactivateUserView>();
                    break;

                default:
                    break;
            }
        }

        private void BtnExportPdf_Click(object sender, EventArgs e)
        {
            DlgExportPdf.DefaultExt = "pdf";
            DlgExportPdf.Filter = @"pdf file(*.pdf)|*.pdf";
            if (DlgExportPdf.ShowDialog() == DialogResult.OK)
            {
                ExportPdf(DlgExportPdf.FileName);
            }
        }

        private void ExportPdf(string fileName)
        {
            try
            {
                PdfPTable pdfTable = new PdfPTable(DgvUsers.Columns.Count);
                pdfTable.DefaultCell.Padding = 3;
                pdfTable.WidthPercentage = 100;
                pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                foreach (DataGridViewColumn column in DgvUsers.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                    pdfTable.AddCell(cell);
                }

                foreach (DataGridViewRow row in DgvUsers.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        pdfTable.AddCell(cell.Value.ToString());
                    }
                }

                using (FileStream stream = new FileStream(fileName, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                    PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    pdfDoc.Add(pdfTable);
                    pdfDoc.Close();
                    stream.Close();
                }

                MessageBox.Show("PDF 익스포트 성공했습니다.", "PDF 성공");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"예외발생 : {ex.Message}");
            }
        }
    }
}
