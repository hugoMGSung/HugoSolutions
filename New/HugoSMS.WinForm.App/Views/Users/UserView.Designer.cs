
namespace HugoSMS.WinForm.App.Views.Users
{
    partial class UserView
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnDeactivateUser = new System.Windows.Forms.Button();
            this.RboActivated = new System.Windows.Forms.RadioButton();
            this.RboAll = new System.Windows.Forms.RadioButton();
            this.BtnExportPdf = new System.Windows.Forms.Button();
            this.BtnUpdateUser = new System.Windows.Forms.Button();
            this.BtnAddUser = new System.Windows.Forms.Button();
            this.DgvUsers = new System.Windows.Forms.DataGridView();
            this.RboDeactivated = new System.Windows.Forms.RadioButton();
            this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserIDentityNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserAdmin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserActivated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔고딕", 21.75F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(4, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 34);
            this.label1.TabIndex = 98;
            this.label1.Text = "사용자 리스트";
            // 
            // BtnDeactivateUser
            // 
            this.BtnDeactivateUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDeactivateUser.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnDeactivateUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnDeactivateUser.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnDeactivateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDeactivateUser.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeactivateUser.ForeColor = System.Drawing.Color.White;
            this.BtnDeactivateUser.Location = new System.Drawing.Point(971, 163);
            this.BtnDeactivateUser.Name = "BtnDeactivateUser";
            this.BtnDeactivateUser.Size = new System.Drawing.Size(228, 43);
            this.BtnDeactivateUser.TabIndex = 106;
            this.BtnDeactivateUser.Tag = "ACTIVATE";
            this.BtnDeactivateUser.Text = "사용자 활성화";
            this.BtnDeactivateUser.UseVisualStyleBackColor = false;
            // 
            // RboActivated
            // 
            this.RboActivated.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RboActivated.AutoSize = true;
            this.RboActivated.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RboActivated.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RboActivated.Location = new System.Drawing.Point(849, 28);
            this.RboActivated.Name = "RboActivated";
            this.RboActivated.Size = new System.Drawing.Size(49, 19);
            this.RboActivated.TabIndex = 104;
            this.RboActivated.TabStop = true;
            this.RboActivated.Text = "활성";
            this.RboActivated.UseVisualStyleBackColor = true;
            this.RboActivated.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // RboAll
            // 
            this.RboAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RboAll.AutoSize = true;
            this.RboAll.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RboAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RboAll.Location = new System.Drawing.Point(794, 28);
            this.RboAll.Name = "RboAll";
            this.RboAll.Size = new System.Drawing.Size(49, 19);
            this.RboAll.TabIndex = 103;
            this.RboAll.TabStop = true;
            this.RboAll.Text = "모두";
            this.RboAll.UseVisualStyleBackColor = true;
            this.RboAll.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // BtnExportPdf
            // 
            this.BtnExportPdf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnExportPdf.BackColor = System.Drawing.Color.Silver;
            this.BtnExportPdf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnExportPdf.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnExportPdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExportPdf.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExportPdf.ForeColor = System.Drawing.Color.White;
            this.BtnExportPdf.Location = new System.Drawing.Point(971, 16);
            this.BtnExportPdf.Name = "BtnExportPdf";
            this.BtnExportPdf.Size = new System.Drawing.Size(228, 43);
            this.BtnExportPdf.TabIndex = 102;
            this.BtnExportPdf.Tag = "EXPORT";
            this.BtnExportPdf.Text = "PDF 익스포트";
            this.BtnExportPdf.UseVisualStyleBackColor = false;
            // 
            // BtnUpdateUser
            // 
            this.BtnUpdateUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnUpdateUser.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnUpdateUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnUpdateUser.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnUpdateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdateUser.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdateUser.ForeColor = System.Drawing.Color.White;
            this.BtnUpdateUser.Location = new System.Drawing.Point(971, 114);
            this.BtnUpdateUser.Name = "BtnUpdateUser";
            this.BtnUpdateUser.Size = new System.Drawing.Size(228, 43);
            this.BtnUpdateUser.TabIndex = 101;
            this.BtnUpdateUser.Tag = "UPDATE";
            this.BtnUpdateUser.Text = "사용자 수정";
            this.BtnUpdateUser.UseVisualStyleBackColor = false;
            this.BtnUpdateUser.Click += new System.EventHandler(this.BtnUpdateUser_Click);
            // 
            // BtnAddUser
            // 
            this.BtnAddUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAddUser.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnAddUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnAddUser.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddUser.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddUser.ForeColor = System.Drawing.Color.White;
            this.BtnAddUser.Location = new System.Drawing.Point(971, 65);
            this.BtnAddUser.Name = "BtnAddUser";
            this.BtnAddUser.Size = new System.Drawing.Size(228, 43);
            this.BtnAddUser.TabIndex = 100;
            this.BtnAddUser.Tag = "ADD";
            this.BtnAddUser.Text = "사용자 추가";
            this.BtnAddUser.UseVisualStyleBackColor = false;
            this.BtnAddUser.Click += new System.EventHandler(this.BtnAddUser_Click);
            // 
            // DgvUsers
            // 
            this.DgvUsers.AllowUserToAddRows = false;
            this.DgvUsers.AllowUserToDeleteRows = false;
            this.DgvUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvUsers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DgvUsers.BackgroundColor = System.Drawing.Color.White;
            this.DgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserID,
            this.UserIDentityNumber,
            this.UserName,
            this.UserSurname,
            this.UserEmail,
            this.UserAdmin,
            this.UserActivated});
            this.DgvUsers.Enabled = false;
            this.DgvUsers.Location = new System.Drawing.Point(10, 52);
            this.DgvUsers.Name = "DgvUsers";
            this.DgvUsers.ReadOnly = true;
            this.DgvUsers.RowHeadersVisible = false;
            this.DgvUsers.Size = new System.Drawing.Size(955, 433);
            this.DgvUsers.TabIndex = 99;
            // 
            // RboDeactivated
            // 
            this.RboDeactivated.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RboDeactivated.AutoSize = true;
            this.RboDeactivated.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RboDeactivated.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RboDeactivated.Location = new System.Drawing.Point(904, 28);
            this.RboDeactivated.Name = "RboDeactivated";
            this.RboDeactivated.Size = new System.Drawing.Size(61, 19);
            this.RboDeactivated.TabIndex = 105;
            this.RboDeactivated.TabStop = true;
            this.RboDeactivated.Text = "비활성";
            this.RboDeactivated.UseVisualStyleBackColor = true;
            this.RboDeactivated.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // UserID
            // 
            this.UserID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.UserID.FillWeight = 213.198F;
            this.UserID.HeaderText = "번호";
            this.UserID.Name = "UserID";
            this.UserID.ReadOnly = true;
            this.UserID.Width = 54;
            // 
            // UserIDentityNumber
            // 
            this.UserIDentityNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.UserIDentityNumber.FillWeight = 81.13367F;
            this.UserIDentityNumber.HeaderText = "고유번호";
            this.UserIDentityNumber.Name = "UserIDentityNumber";
            this.UserIDentityNumber.ReadOnly = true;
            this.UserIDentityNumber.Width = 78;
            // 
            // UserName
            // 
            this.UserName.FillWeight = 81.13367F;
            this.UserName.HeaderText = "이름";
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            // 
            // UserSurname
            // 
            this.UserSurname.FillWeight = 81.13367F;
            this.UserSurname.HeaderText = "성";
            this.UserSurname.Name = "UserSurname";
            this.UserSurname.ReadOnly = true;
            // 
            // UserEmail
            // 
            this.UserEmail.FillWeight = 81.13367F;
            this.UserEmail.HeaderText = "이메일";
            this.UserEmail.Name = "UserEmail";
            this.UserEmail.ReadOnly = true;
            // 
            // UserAdmin
            // 
            this.UserAdmin.FillWeight = 81.13367F;
            this.UserAdmin.HeaderText = "관리자여부";
            this.UserAdmin.Name = "UserAdmin";
            this.UserAdmin.ReadOnly = true;
            // 
            // UserActivated
            // 
            this.UserActivated.FillWeight = 81.13367F;
            this.UserActivated.HeaderText = "활성";
            this.UserActivated.Name = "UserActivated";
            this.UserActivated.ReadOnly = true;
            // 
            // UserView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnDeactivateUser);
            this.Controls.Add(this.RboActivated);
            this.Controls.Add(this.RboAll);
            this.Controls.Add(this.BtnExportPdf);
            this.Controls.Add(this.BtnUpdateUser);
            this.Controls.Add(this.BtnAddUser);
            this.Controls.Add(this.DgvUsers);
            this.Controls.Add(this.RboDeactivated);
            this.Name = "UserView";
            this.Size = new System.Drawing.Size(1203, 491);
            this.Load += new System.EventHandler(this.UserView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnDeactivateUser;
        private System.Windows.Forms.RadioButton RboActivated;
        private System.Windows.Forms.RadioButton RboAll;
        private System.Windows.Forms.Button BtnExportPdf;
        private System.Windows.Forms.Button BtnUpdateUser;
        private System.Windows.Forms.Button BtnAddUser;
        private System.Windows.Forms.DataGridView DgvUsers;
        private System.Windows.Forms.RadioButton RboDeactivated;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserIDentityNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserAdmin;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserActivated;
    }
}
