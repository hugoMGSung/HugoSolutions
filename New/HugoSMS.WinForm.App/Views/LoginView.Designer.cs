
namespace HugoSMS.WinForm.App.Views
{
    partial class LoginView
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
            this.PnlLogin = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.ChkDispPassword = new System.Windows.Forms.CheckBox();
            this.LblResult = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PnlLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlLogin
            // 
            this.PnlLogin.Controls.Add(this.label5);
            this.PnlLogin.Controls.Add(this.BtnLogin);
            this.PnlLogin.Controls.Add(this.ChkDispPassword);
            this.PnlLogin.Controls.Add(this.LblResult);
            this.PnlLogin.Controls.Add(this.label3);
            this.PnlLogin.Controls.Add(this.label2);
            this.PnlLogin.Controls.Add(this.TxtPassword);
            this.PnlLogin.Controls.Add(this.TxtEmail);
            this.PnlLogin.Controls.Add(this.label1);
            this.PnlLogin.Location = new System.Drawing.Point(605, 33);
            this.PnlLogin.Name = "PnlLogin";
            this.PnlLogin.Size = new System.Drawing.Size(511, 506);
            this.PnlLogin.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(224, 352);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 25);
            this.label5.TabIndex = 39;
            this.label5.Text = "승인";
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackgroundImage = global::HugoSMS.WinForm.App.Properties.Resources.ok_appproval_acceptance__1_;
            this.BtnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnLogin.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogin.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnLogin.Location = new System.Drawing.Point(202, 293);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(93, 56);
            this.BtnLogin.TabIndex = 38;
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // ChkDispPassword
            // 
            this.ChkDispPassword.AutoSize = true;
            this.ChkDispPassword.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkDispPassword.Location = new System.Drawing.Point(176, 224);
            this.ChkDispPassword.Name = "ChkDispPassword";
            this.ChkDispPassword.Size = new System.Drawing.Size(123, 24);
            this.ChkDispPassword.TabIndex = 37;
            this.ChkDispPassword.Text = "패스워드 표시";
            this.ChkDispPassword.UseVisualStyleBackColor = true;
            this.ChkDispPassword.CheckedChanged += new System.EventHandler(this.ChkDispPassword_CheckedChanged);
            // 
            // LblResult
            // 
            this.LblResult.AutoSize = true;
            this.LblResult.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblResult.ForeColor = System.Drawing.Color.Red;
            this.LblResult.Location = new System.Drawing.Point(197, 451);
            this.LblResult.Name = "LblResult";
            this.LblResult.Size = new System.Drawing.Size(110, 30);
            this.LblResult.TabIndex = 36;
            this.LblResult.Text = "접근 불가!";
            this.LblResult.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(27, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 30);
            this.label3.TabIndex = 35;
            this.label3.Text = "이메일:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(27, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 30);
            this.label2.TabIndex = 34;
            this.label2.Text = "패스워드:";
            // 
            // TxtPassword
            // 
            this.TxtPassword.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPassword.Location = new System.Drawing.Point(176, 185);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(294, 33);
            this.TxtPassword.TabIndex = 33;
            this.TxtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPassword_KeyPress);
            // 
            // TxtEmail
            // 
            this.TxtEmail.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmail.Location = new System.Drawing.Point(176, 126);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(294, 33);
            this.TxtEmail.TabIndex = 32;
            this.TxtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtEmail_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(198, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 37);
            this.label1.TabIndex = 31;
            this.label1.Text = "로그인";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PnlLogin);
            this.Name = "LoginView";
            this.Size = new System.Drawing.Size(1150, 580);
            this.Load += new System.EventHandler(this.LoginView_Load);
            this.ClientSizeChanged += new System.EventHandler(this.LoginView_ClientSizeChanged);
            this.PnlLogin.ResumeLayout(false);
            this.PnlLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlLogin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.CheckBox ChkDispPassword;
        private System.Windows.Forms.Label LblResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label label1;
    }
}
