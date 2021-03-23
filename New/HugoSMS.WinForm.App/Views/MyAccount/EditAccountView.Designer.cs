
namespace HugoSMS.WinForm.App.Views.MyAccount
{
    partial class EditAccountView
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
            this.LblAdmin = new System.Windows.Forms.Label();
            this.LblPassword = new System.Windows.Forms.Label();
            this.LblUserEmail = new System.Windows.Forms.Label();
            this.LblUserSurname = new System.Windows.Forms.Label();
            this.LblUserName = new System.Windows.Forms.Label();
            this.LblIdentityNo = new System.Windows.Forms.Label();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnBack = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtUserSurname = new System.Windows.Forms.TextBox();
            this.CboActivated = new System.Windows.Forms.ComboBox();
            this.TxtUserEmail = new System.Windows.Forms.TextBox();
            this.CboAdmin = new System.Windows.Forms.ComboBox();
            this.TxtUserName = new System.Windows.Forms.TextBox();
            this.TxtIdentityNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.LblUserID = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblAdmin
            // 
            this.LblAdmin.AutoSize = true;
            this.LblAdmin.Font = new System.Drawing.Font("나눔고딕", 9.75F);
            this.LblAdmin.ForeColor = System.Drawing.Color.Red;
            this.LblAdmin.Location = new System.Drawing.Point(533, 298);
            this.LblAdmin.Name = "LblAdmin";
            this.LblAdmin.Size = new System.Drawing.Size(412, 30);
            this.LblAdmin.TabIndex = 216;
            this.LblAdmin.Text = "There is a minimum of two admin users registered to this system ,\r\ntherefore you " +
    "can not unregister or deactivate as an admin user.";
            this.LblAdmin.Visible = false;
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.Font = new System.Drawing.Font("나눔고딕", 9.75F);
            this.LblPassword.ForeColor = System.Drawing.Color.Red;
            this.LblPassword.Location = new System.Drawing.Point(533, 268);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(51, 15);
            this.LblPassword.TabIndex = 215;
            this.LblPassword.Text = "label12";
            // 
            // LblUserEmail
            // 
            this.LblUserEmail.AutoSize = true;
            this.LblUserEmail.Font = new System.Drawing.Font("나눔고딕", 9.75F);
            this.LblUserEmail.ForeColor = System.Drawing.Color.Red;
            this.LblUserEmail.Location = new System.Drawing.Point(533, 234);
            this.LblUserEmail.Name = "LblUserEmail";
            this.LblUserEmail.Size = new System.Drawing.Size(51, 15);
            this.LblUserEmail.TabIndex = 214;
            this.LblUserEmail.Text = "label11";
            // 
            // LblUserSurname
            // 
            this.LblUserSurname.AutoSize = true;
            this.LblUserSurname.Font = new System.Drawing.Font("나눔고딕", 9.75F);
            this.LblUserSurname.ForeColor = System.Drawing.Color.Red;
            this.LblUserSurname.Location = new System.Drawing.Point(533, 200);
            this.LblUserSurname.Name = "LblUserSurname";
            this.LblUserSurname.Size = new System.Drawing.Size(43, 15);
            this.LblUserSurname.TabIndex = 213;
            this.LblUserSurname.Text = "label8";
            // 
            // LblUserName
            // 
            this.LblUserName.AutoSize = true;
            this.LblUserName.Font = new System.Drawing.Font("나눔고딕", 9.75F);
            this.LblUserName.ForeColor = System.Drawing.Color.Red;
            this.LblUserName.Location = new System.Drawing.Point(533, 166);
            this.LblUserName.Name = "LblUserName";
            this.LblUserName.Size = new System.Drawing.Size(43, 15);
            this.LblUserName.TabIndex = 212;
            this.LblUserName.Text = "label4";
            // 
            // LblIdentityNo
            // 
            this.LblIdentityNo.AutoSize = true;
            this.LblIdentityNo.Font = new System.Drawing.Font("나눔고딕", 9.75F);
            this.LblIdentityNo.ForeColor = System.Drawing.Color.Red;
            this.LblIdentityNo.Location = new System.Drawing.Point(533, 131);
            this.LblIdentityNo.Name = "LblIdentityNo";
            this.LblIdentityNo.Size = new System.Drawing.Size(43, 15);
            this.LblIdentityNo.TabIndex = 211;
            this.LblIdentityNo.Text = "label2";
            // 
            // TxtPassword
            // 
            this.TxtPassword.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPassword.Location = new System.Drawing.Point(239, 262);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(285, 26);
            this.TxtPassword.TabIndex = 210;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(29, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 19);
            this.label3.TabIndex = 209;
            this.label3.Text = "Password:";
            // 
            // BtnBack
            // 
            this.BtnBack.BackgroundImage = global::HugoSMS.WinForm.App.Properties.Resources.back_arrow;
            this.BtnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnBack.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBack.Font = new System.Drawing.Font("나눔고딕", 14F);
            this.BtnBack.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnBack.Location = new System.Drawing.Point(1106, 354);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(64, 114);
            this.BtnBack.TabIndex = 208;
            this.BtnBack.Text = "Back";
            this.BtnBack.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("나눔고딕", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1032, 442);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 21);
            this.label5.TabIndex = 207;
            this.label5.Text = "Update";
            // 
            // TxtUserSurname
            // 
            this.TxtUserSurname.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUserSurname.Location = new System.Drawing.Point(239, 194);
            this.TxtUserSurname.Name = "TxtUserSurname";
            this.TxtUserSurname.Size = new System.Drawing.Size(285, 26);
            this.TxtUserSurname.TabIndex = 205;
            // 
            // CboActivated
            // 
            this.CboActivated.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboActivated.FormattingEnabled = true;
            this.CboActivated.Location = new System.Drawing.Point(239, 332);
            this.CboActivated.Name = "CboActivated";
            this.CboActivated.Size = new System.Drawing.Size(285, 27);
            this.CboActivated.TabIndex = 204;
            // 
            // TxtUserEmail
            // 
            this.TxtUserEmail.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUserEmail.Location = new System.Drawing.Point(239, 228);
            this.TxtUserEmail.Name = "TxtUserEmail";
            this.TxtUserEmail.Size = new System.Drawing.Size(285, 26);
            this.TxtUserEmail.TabIndex = 203;
            this.TxtUserEmail.TextChanged += new System.EventHandler(this.TxtUserEmail_TextChanged);
            // 
            // CboAdmin
            // 
            this.CboAdmin.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboAdmin.FormattingEnabled = true;
            this.CboAdmin.Location = new System.Drawing.Point(239, 296);
            this.CboAdmin.Name = "CboAdmin";
            this.CboAdmin.Size = new System.Drawing.Size(285, 27);
            this.CboAdmin.TabIndex = 202;
            // 
            // TxtUserName
            // 
            this.TxtUserName.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUserName.Location = new System.Drawing.Point(239, 160);
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.Size = new System.Drawing.Size(285, 26);
            this.TxtUserName.TabIndex = 201;
            // 
            // TxtIdentityNo
            // 
            this.TxtIdentityNo.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIdentityNo.Location = new System.Drawing.Point(239, 125);
            this.TxtIdentityNo.Name = "TxtIdentityNo";
            this.TxtIdentityNo.ReadOnly = true;
            this.TxtIdentityNo.Size = new System.Drawing.Size(285, 26);
            this.TxtIdentityNo.TabIndex = 200;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(29, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 19);
            this.label7.TabIndex = 199;
            this.label7.Text = "Identity Number:";
            // 
            // LblUserID
            // 
            this.LblUserID.AutoSize = true;
            this.LblUserID.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUserID.Location = new System.Drawing.Point(242, 98);
            this.LblUserID.Name = "LblUserID";
            this.LblUserID.Size = new System.Drawing.Size(57, 19);
            this.LblUserID.TabIndex = 198;
            this.LblUserID.Text = "userID";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label16.Location = new System.Drawing.Point(29, 98);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(68, 19);
            this.label16.TabIndex = 197;
            this.label16.Text = "User ID:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(29, 232);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 19);
            this.label10.TabIndex = 196;
            this.label10.Text = "Email:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label19.Location = new System.Drawing.Point(29, 336);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(90, 19);
            this.label19.TabIndex = 195;
            this.label19.Text = "Activated: ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label13.Location = new System.Drawing.Point(29, 300);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 19);
            this.label13.TabIndex = 194;
            this.label13.Text = "Admin:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(29, 198);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 19);
            this.label9.TabIndex = 193;
            this.label9.Text = "Surname:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(29, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 19);
            this.label6.TabIndex = 192;
            this.label6.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔고딕", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(26, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 34);
            this.label1.TabIndex = 191;
            this.label1.Text = "내계정 수정";
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.BackgroundImage = global::HugoSMS.WinForm.App.Properties.Resources.sign_check;
            this.BtnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdate.Font = new System.Drawing.Font("나눔고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnUpdate.Location = new System.Drawing.Point(1036, 375);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(64, 64);
            this.BtnUpdate.TabIndex = 206;
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // EditAccountView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.LblAdmin);
            this.Controls.Add(this.LblPassword);
            this.Controls.Add(this.LblUserEmail);
            this.Controls.Add(this.LblUserSurname);
            this.Controls.Add(this.LblUserName);
            this.Controls.Add(this.LblIdentityNo);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.TxtUserSurname);
            this.Controls.Add(this.CboActivated);
            this.Controls.Add(this.TxtUserEmail);
            this.Controls.Add(this.CboAdmin);
            this.Controls.Add(this.TxtUserName);
            this.Controls.Add(this.TxtIdentityNo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.LblUserID);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Name = "EditAccountView";
            this.Size = new System.Drawing.Size(1203, 491);
            this.Load += new System.EventHandler(this.EditAccountView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblAdmin;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.Label LblUserEmail;
        private System.Windows.Forms.Label LblUserSurname;
        private System.Windows.Forms.Label LblUserName;
        private System.Windows.Forms.Label LblIdentityNo;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.TextBox TxtUserSurname;
        private System.Windows.Forms.ComboBox CboActivated;
        private System.Windows.Forms.TextBox TxtUserEmail;
        private System.Windows.Forms.ComboBox CboAdmin;
        private System.Windows.Forms.TextBox TxtUserName;
        private System.Windows.Forms.TextBox TxtIdentityNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LblUserID;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
    }
}
