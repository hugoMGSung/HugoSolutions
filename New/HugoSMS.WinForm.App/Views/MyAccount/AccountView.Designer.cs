
namespace HugoSMS.WinForm.App.Views.MyAccount
{
    partial class AccountView
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
            this.BtnUpdateAccount = new System.Windows.Forms.Button();
            this.LblIdentityNum = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LblUserID = new System.Windows.Forms.Label();
            this.LblUserEmail = new System.Windows.Forms.Label();
            this.LblUserActivated = new System.Windows.Forms.Label();
            this.LblUserAdmin = new System.Windows.Forms.Label();
            this.LblUserSurname = new System.Windows.Forms.Label();
            this.LblUserName = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnUpdateAccount
            // 
            this.BtnUpdateAccount.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BtnUpdateAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnUpdateAccount.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnUpdateAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdateAccount.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdateAccount.ForeColor = System.Drawing.Color.White;
            this.BtnUpdateAccount.Location = new System.Drawing.Point(944, 24);
            this.BtnUpdateAccount.Name = "BtnUpdateAccount";
            this.BtnUpdateAccount.Size = new System.Drawing.Size(232, 40);
            this.BtnUpdateAccount.TabIndex = 175;
            this.BtnUpdateAccount.Text = "내계정 변경";
            this.BtnUpdateAccount.UseVisualStyleBackColor = false;
            this.BtnUpdateAccount.Click += new System.EventHandler(this.BtnUpdateAccount_Click);
            // 
            // LblIdentityNum
            // 
            this.LblIdentityNum.AutoSize = true;
            this.LblIdentityNum.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIdentityNum.Location = new System.Drawing.Point(251, 144);
            this.LblIdentityNum.Name = "LblIdentityNum";
            this.LblIdentityNum.Size = new System.Drawing.Size(62, 19);
            this.LblIdentityNum.TabIndex = 174;
            this.LblIdentityNum.Text = "IDNum";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(44, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 19);
            this.label7.TabIndex = 173;
            this.label7.Text = "Identity Number";
            // 
            // LblUserID
            // 
            this.LblUserID.AutoSize = true;
            this.LblUserID.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUserID.Location = new System.Drawing.Point(251, 119);
            this.LblUserID.Name = "LblUserID";
            this.LblUserID.Size = new System.Drawing.Size(57, 19);
            this.LblUserID.TabIndex = 172;
            this.LblUserID.Text = "userID";
            // 
            // LblUserEmail
            // 
            this.LblUserEmail.AutoSize = true;
            this.LblUserEmail.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUserEmail.Location = new System.Drawing.Point(251, 219);
            this.LblUserEmail.Name = "LblUserEmail";
            this.LblUserEmail.Size = new System.Drawing.Size(82, 19);
            this.LblUserEmail.TabIndex = 171;
            this.LblUserEmail.Text = "userEmail";
            // 
            // LblUserActivated
            // 
            this.LblUserActivated.AutoSize = true;
            this.LblUserActivated.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUserActivated.Location = new System.Drawing.Point(251, 269);
            this.LblUserActivated.Name = "LblUserActivated";
            this.LblUserActivated.Size = new System.Drawing.Size(113, 19);
            this.LblUserActivated.TabIndex = 170;
            this.LblUserActivated.Text = "userActivated";
            // 
            // LblUserAdmin
            // 
            this.LblUserAdmin.AutoSize = true;
            this.LblUserAdmin.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUserAdmin.Location = new System.Drawing.Point(251, 244);
            this.LblUserAdmin.Name = "LblUserAdmin";
            this.LblUserAdmin.Size = new System.Drawing.Size(92, 19);
            this.LblUserAdmin.TabIndex = 169;
            this.LblUserAdmin.Text = "userAdmin";
            // 
            // LblUserSurname
            // 
            this.LblUserSurname.AutoSize = true;
            this.LblUserSurname.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUserSurname.Location = new System.Drawing.Point(251, 194);
            this.LblUserSurname.Name = "LblUserSurname";
            this.LblUserSurname.Size = new System.Drawing.Size(109, 19);
            this.LblUserSurname.TabIndex = 168;
            this.LblUserSurname.Text = "userSurname";
            // 
            // LblUserName
            // 
            this.LblUserName.AutoSize = true;
            this.LblUserName.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUserName.Location = new System.Drawing.Point(251, 169);
            this.LblUserName.Name = "LblUserName";
            this.LblUserName.Size = new System.Drawing.Size(86, 19);
            this.LblUserName.TabIndex = 167;
            this.LblUserName.Text = "userName";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(44, 119);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(68, 19);
            this.label16.TabIndex = 166;
            this.label16.Text = "User ID:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(44, 219);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 19);
            this.label10.TabIndex = 165;
            this.label10.Text = "Email:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(44, 269);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(90, 19);
            this.label19.TabIndex = 164;
            this.label19.Text = "Activated: ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(44, 244);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 19);
            this.label13.TabIndex = 163;
            this.label13.Text = "Admin: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(44, 194);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 19);
            this.label9.TabIndex = 162;
            this.label9.Text = "Surname:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(44, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 19);
            this.label6.TabIndex = 161;
            this.label6.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(39, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 40);
            this.label1.TabIndex = 160;
            this.label1.Text = "내 계정정보";
            // 
            // AccountView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnUpdateAccount);
            this.Controls.Add(this.LblIdentityNum);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.LblUserID);
            this.Controls.Add(this.LblUserEmail);
            this.Controls.Add(this.LblUserActivated);
            this.Controls.Add(this.LblUserAdmin);
            this.Controls.Add(this.LblUserSurname);
            this.Controls.Add(this.LblUserName);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Name = "AccountView";
            this.Size = new System.Drawing.Size(1203, 491);
            this.Load += new System.EventHandler(this.AccountView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnUpdateAccount;
        private System.Windows.Forms.Label LblIdentityNum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LblUserID;
        private System.Windows.Forms.Label LblUserEmail;
        private System.Windows.Forms.Label LblUserActivated;
        private System.Windows.Forms.Label LblUserAdmin;
        private System.Windows.Forms.Label LblUserSurname;
        private System.Windows.Forms.Label LblUserName;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
    }
}
