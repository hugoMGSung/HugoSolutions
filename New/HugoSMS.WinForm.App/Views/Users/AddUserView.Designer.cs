
namespace HugoSMS.WinForm.App.Views.Users
{
    partial class AddUserView
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
            this.LblInvalidPassword = new System.Windows.Forms.Label();
            this.LblInvalidEmail = new System.Windows.Forms.Label();
            this.LblInvalidSurname = new System.Windows.Forms.Label();
            this.LblInvalidNumber = new System.Windows.Forms.Label();
            this.LblInvalidName = new System.Windows.Forms.Label();
            this.LblEmailExist = new System.Windows.Forms.Label();
            this.LblIDNumberExist = new System.Windows.Forms.Label();
            this.BtnBack = new System.Windows.Forms.Button();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LblTitle = new System.Windows.Forms.Label();
            this.LblAdd = new System.Windows.Forms.Label();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.TxtSurName = new System.Windows.Forms.TextBox();
            this.CboActivated = new System.Windows.Forms.ComboBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.CboAdmin = new System.Windows.Forms.ComboBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtIdNumber = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblInvalidPassword
            // 
            this.LblInvalidPassword.AutoSize = true;
            this.LblInvalidPassword.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInvalidPassword.ForeColor = System.Drawing.Color.Red;
            this.LblInvalidPassword.Location = new System.Drawing.Point(711, 203);
            this.LblInvalidPassword.Name = "LblInvalidPassword";
            this.LblInvalidPassword.Size = new System.Drawing.Size(165, 15);
            this.LblInvalidPassword.TabIndex = 350;
            this.LblInvalidPassword.Text = "Invalid Password entered!";
            this.LblInvalidPassword.Visible = false;
            // 
            // LblInvalidEmail
            // 
            this.LblInvalidEmail.AutoSize = true;
            this.LblInvalidEmail.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInvalidEmail.ForeColor = System.Drawing.Color.Red;
            this.LblInvalidEmail.Location = new System.Drawing.Point(711, 174);
            this.LblInvalidEmail.Name = "LblInvalidEmail";
            this.LblInvalidEmail.Size = new System.Drawing.Size(138, 15);
            this.LblInvalidEmail.TabIndex = 349;
            this.LblInvalidEmail.Text = "Invalid Email entered!";
            this.LblInvalidEmail.Visible = false;
            // 
            // LblInvalidSurname
            // 
            this.LblInvalidSurname.AutoSize = true;
            this.LblInvalidSurname.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInvalidSurname.ForeColor = System.Drawing.Color.Red;
            this.LblInvalidSurname.Location = new System.Drawing.Point(711, 145);
            this.LblInvalidSurname.Name = "LblInvalidSurname";
            this.LblInvalidSurname.Size = new System.Drawing.Size(160, 15);
            this.LblInvalidSurname.TabIndex = 348;
            this.LblInvalidSurname.Text = "Invalid Surname entered!";
            this.LblInvalidSurname.Visible = false;
            // 
            // LblInvalidNumber
            // 
            this.LblInvalidNumber.AutoSize = true;
            this.LblInvalidNumber.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInvalidNumber.ForeColor = System.Drawing.Color.Red;
            this.LblInvalidNumber.Location = new System.Drawing.Point(711, 87);
            this.LblInvalidNumber.Name = "LblInvalidNumber";
            this.LblInvalidNumber.Size = new System.Drawing.Size(145, 15);
            this.LblInvalidNumber.TabIndex = 347;
            this.LblInvalidNumber.Text = "Invalid Idetity Number!";
            this.LblInvalidNumber.Visible = false;
            // 
            // LblInvalidName
            // 
            this.LblInvalidName.AutoSize = true;
            this.LblInvalidName.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInvalidName.ForeColor = System.Drawing.Color.Red;
            this.LblInvalidName.Location = new System.Drawing.Point(711, 116);
            this.LblInvalidName.Name = "LblInvalidName";
            this.LblInvalidName.Size = new System.Drawing.Size(141, 15);
            this.LblInvalidName.TabIndex = 346;
            this.LblInvalidName.Text = "Invalid Name entered!";
            this.LblInvalidName.Visible = false;
            // 
            // LblEmailExist
            // 
            this.LblEmailExist.AutoSize = true;
            this.LblEmailExist.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmailExist.ForeColor = System.Drawing.Color.Red;
            this.LblEmailExist.Location = new System.Drawing.Point(524, 176);
            this.LblEmailExist.Name = "LblEmailExist";
            this.LblEmailExist.Size = new System.Drawing.Size(130, 15);
            this.LblEmailExist.TabIndex = 345;
            this.LblEmailExist.Text = "Email already exists!";
            this.LblEmailExist.Visible = false;
            // 
            // LblIDNumberExist
            // 
            this.LblIDNumberExist.AutoSize = true;
            this.LblIDNumberExist.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIDNumberExist.ForeColor = System.Drawing.Color.Red;
            this.LblIDNumberExist.Location = new System.Drawing.Point(524, 87);
            this.LblIDNumberExist.Name = "LblIDNumberExist";
            this.LblIDNumberExist.Size = new System.Drawing.Size(162, 15);
            this.LblIDNumberExist.TabIndex = 344;
            this.LblIDNumberExist.Text = "ID number already exists!";
            this.LblIDNumberExist.Visible = false;
            // 
            // BtnBack
            // 
            this.BtnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnBack.BackgroundImage = global::HugoSMS.WinForm.App.Properties.Resources.reply__1_;
            this.BtnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnBack.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBack.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBack.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnBack.Location = new System.Drawing.Point(1115, 374);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(71, 104);
            this.BtnBack.TabIndex = 343;
            this.BtnBack.Text = "뒤로";
            this.BtnBack.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // TxtPassword
            // 
            this.TxtPassword.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPassword.Location = new System.Drawing.Point(230, 203);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(285, 26);
            this.TxtPassword.TabIndex = 335;
            this.TxtPassword.Leave += new System.EventHandler(this.TxtPassword_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(24, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 19);
            this.label2.TabIndex = 341;
            this.label2.Text = "패스워드 :";
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("나눔고딕", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LblTitle.Location = new System.Drawing.Point(4, 15);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(158, 34);
            this.LblTitle.TabIndex = 340;
            this.LblTitle.Text = "사용자 추가";
            // 
            // LblAdd
            // 
            this.LblAdd.AutoSize = true;
            this.LblAdd.Font = new System.Drawing.Font("나눔고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAdd.Location = new System.Drawing.Point(444, 356);
            this.LblAdd.Name = "LblAdd";
            this.LblAdd.Size = new System.Drawing.Size(50, 24);
            this.LblAdd.TabIndex = 339;
            this.LblAdd.Text = "추가";
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackgroundImage = global::HugoSMS.WinForm.App.Properties.Resources.ok_appproval_acceptance__1_;
            this.BtnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnAdd.Enabled = false;
            this.BtnAdd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnAdd.Location = new System.Drawing.Point(424, 296);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(93, 56);
            this.BtnAdd.TabIndex = 338;
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // TxtSurName
            // 
            this.TxtSurName.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSurName.Location = new System.Drawing.Point(230, 143);
            this.TxtSurName.Name = "TxtSurName";
            this.TxtSurName.Size = new System.Drawing.Size(285, 26);
            this.TxtSurName.TabIndex = 333;
            this.TxtSurName.Leave += new System.EventHandler(this.TxtSurName_Leave);
            // 
            // CboActivated
            // 
            this.CboActivated.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboActivated.FormattingEnabled = true;
            this.CboActivated.Location = new System.Drawing.Point(230, 265);
            this.CboActivated.Name = "CboActivated";
            this.CboActivated.Size = new System.Drawing.Size(285, 27);
            this.CboActivated.TabIndex = 337;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmail.Location = new System.Drawing.Point(230, 173);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(285, 26);
            this.TxtEmail.TabIndex = 334;
            this.TxtEmail.Leave += new System.EventHandler(this.TxtEmail_Leave);
            // 
            // CboAdmin
            // 
            this.CboAdmin.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboAdmin.FormattingEnabled = true;
            this.CboAdmin.Location = new System.Drawing.Point(230, 233);
            this.CboAdmin.Name = "CboAdmin";
            this.CboAdmin.Size = new System.Drawing.Size(285, 27);
            this.CboAdmin.TabIndex = 336;
            // 
            // TxtName
            // 
            this.TxtName.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtName.Location = new System.Drawing.Point(230, 113);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(285, 26);
            this.TxtName.TabIndex = 332;
            this.TxtName.Leave += new System.EventHandler(this.TxtName_Leave);
            // 
            // TxtIdNumber
            // 
            this.TxtIdNumber.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIdNumber.Location = new System.Drawing.Point(230, 83);
            this.TxtIdNumber.Name = "TxtIdNumber";
            this.TxtIdNumber.Size = new System.Drawing.Size(285, 26);
            this.TxtIdNumber.TabIndex = 331;
            this.TxtIdNumber.Leave += new System.EventHandler(this.TxtIdNumber_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(24, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 19);
            this.label7.TabIndex = 331;
            this.label7.Text = "고유번호 :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(24, 180);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 19);
            this.label10.TabIndex = 330;
            this.label10.Text = "이메일 :";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label19.Location = new System.Drawing.Point(24, 273);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(48, 19);
            this.label19.TabIndex = 329;
            this.label19.Text = "활성 :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label13.Location = new System.Drawing.Point(24, 242);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 19);
            this.label13.TabIndex = 328;
            this.label13.Text = "관리자여부 :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(24, 149);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 19);
            this.label9.TabIndex = 327;
            this.label9.Text = "성 :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(24, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 19);
            this.label6.TabIndex = 326;
            this.label6.Text = "이름 :";
            // 
            // AddUserView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LblInvalidPassword);
            this.Controls.Add(this.LblInvalidEmail);
            this.Controls.Add(this.LblInvalidSurname);
            this.Controls.Add(this.LblInvalidNumber);
            this.Controls.Add(this.LblInvalidName);
            this.Controls.Add(this.LblEmailExist);
            this.Controls.Add(this.LblIDNumberExist);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblTitle);
            this.Controls.Add(this.LblAdd);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.TxtSurName);
            this.Controls.Add(this.CboActivated);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.CboAdmin);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.TxtIdNumber);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Name = "AddUserView";
            this.Size = new System.Drawing.Size(1203, 491);
            this.Load += new System.EventHandler(this.AddUserView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblInvalidPassword;
        private System.Windows.Forms.Label LblInvalidEmail;
        private System.Windows.Forms.Label LblInvalidSurname;
        private System.Windows.Forms.Label LblInvalidNumber;
        private System.Windows.Forms.Label LblInvalidName;
        private System.Windows.Forms.Label LblEmailExist;
        private System.Windows.Forms.Label LblIDNumberExist;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Label LblAdd;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.TextBox TxtSurName;
        private System.Windows.Forms.ComboBox CboActivated;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.ComboBox CboAdmin;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtIdNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
    }
}
