
namespace HugoSMS.WinForm.App.Views
{
    partial class MainView
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
            this.BtnProducts = new System.Windows.Forms.Button();
            this.BtnLogOut = new System.Windows.Forms.Button();
            this.BtnUsers = new System.Windows.Forms.Button();
            this.BtnMyAccount = new System.Windows.Forms.Button();
            this.BtnSettings = new System.Windows.Forms.Button();
            this.BtnStores = new System.Windows.Forms.Button();
            this.BtnItemsOut = new System.Windows.Forms.Button();
            this.BtnBooks = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // BtnProducts
            // 
            this.BtnProducts.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BtnProducts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnProducts.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProducts.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnProducts.ForeColor = System.Drawing.Color.White;
            this.BtnProducts.Image = global::HugoSMS.WinForm.App.Properties.Resources.trolley;
            this.BtnProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnProducts.Location = new System.Drawing.Point(155, 8);
            this.BtnProducts.Name = "BtnProducts";
            this.BtnProducts.Size = new System.Drawing.Size(140, 45);
            this.BtnProducts.TabIndex = 46;
            this.BtnProducts.Text = "제품";
            this.BtnProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnProducts.UseVisualStyleBackColor = false;
            // 
            // BtnLogOut
            // 
            this.BtnLogOut.BackColor = System.Drawing.Color.LightSlateGray;
            this.BtnLogOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnLogOut.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogOut.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnLogOut.ForeColor = System.Drawing.Color.White;
            this.BtnLogOut.Image = global::HugoSMS.WinForm.App.Properties.Resources.right_arrow;
            this.BtnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnLogOut.Location = new System.Drawing.Point(1061, 8);
            this.BtnLogOut.Name = "BtnLogOut";
            this.BtnLogOut.Size = new System.Drawing.Size(140, 45);
            this.BtnLogOut.TabIndex = 45;
            this.BtnLogOut.Text = "로그아웃";
            this.BtnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLogOut.UseVisualStyleBackColor = false;
            this.BtnLogOut.Click += new System.EventHandler(this.BtnLogOut_Click);
            // 
            // BtnUsers
            // 
            this.BtnUsers.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnUsers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnUsers.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUsers.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnUsers.ForeColor = System.Drawing.Color.White;
            this.BtnUsers.Image = global::HugoSMS.WinForm.App.Properties.Resources.multiple_users_silhouette;
            this.BtnUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnUsers.Location = new System.Drawing.Point(759, 8);
            this.BtnUsers.Name = "BtnUsers";
            this.BtnUsers.Size = new System.Drawing.Size(140, 45);
            this.BtnUsers.TabIndex = 44;
            this.BtnUsers.Text = "사용자";
            this.BtnUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnUsers.UseVisualStyleBackColor = false;
            this.BtnUsers.Click += new System.EventHandler(this.BtnUsers_Click);
            // 
            // BtnMyAccount
            // 
            this.BtnMyAccount.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BtnMyAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnMyAccount.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnMyAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMyAccount.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnMyAccount.ForeColor = System.Drawing.Color.White;
            this.BtnMyAccount.Image = global::HugoSMS.WinForm.App.Properties.Resources.user_account_box;
            this.BtnMyAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnMyAccount.Location = new System.Drawing.Point(910, 8);
            this.BtnMyAccount.Name = "BtnMyAccount";
            this.BtnMyAccount.Size = new System.Drawing.Size(140, 45);
            this.BtnMyAccount.TabIndex = 43;
            this.BtnMyAccount.Text = "내 계정";
            this.BtnMyAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMyAccount.UseVisualStyleBackColor = false;
            this.BtnMyAccount.Click += new System.EventHandler(this.BtnMyAccount_Click);
            // 
            // BtnSettings
            // 
            this.BtnSettings.BackColor = System.Drawing.Color.MidnightBlue;
            this.BtnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnSettings.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSettings.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnSettings.ForeColor = System.Drawing.Color.White;
            this.BtnSettings.Image = global::HugoSMS.WinForm.App.Properties.Resources.settings_gears;
            this.BtnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSettings.Location = new System.Drawing.Point(608, 8);
            this.BtnSettings.Name = "BtnSettings";
            this.BtnSettings.Size = new System.Drawing.Size(140, 45);
            this.BtnSettings.TabIndex = 42;
            this.BtnSettings.Text = "설정";
            this.BtnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSettings.UseVisualStyleBackColor = false;
            // 
            // BtnStores
            // 
            this.BtnStores.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnStores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnStores.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnStores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStores.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnStores.ForeColor = System.Drawing.Color.White;
            this.BtnStores.Image = global::HugoSMS.WinForm.App.Properties.Resources.warehouse;
            this.BtnStores.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnStores.Location = new System.Drawing.Point(457, 8);
            this.BtnStores.Name = "BtnStores";
            this.BtnStores.Size = new System.Drawing.Size(140, 45);
            this.BtnStores.TabIndex = 41;
            this.BtnStores.Text = "창고";
            this.BtnStores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnStores.UseVisualStyleBackColor = false;
            this.BtnStores.Click += new System.EventHandler(this.BtnStores_Click);
            // 
            // BtnItemsOut
            // 
            this.BtnItemsOut.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnItemsOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnItemsOut.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnItemsOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnItemsOut.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnItemsOut.ForeColor = System.Drawing.Color.White;
            this.BtnItemsOut.Image = global::HugoSMS.WinForm.App.Properties.Resources.sign_out_option;
            this.BtnItemsOut.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnItemsOut.Location = new System.Drawing.Point(306, 8);
            this.BtnItemsOut.Name = "BtnItemsOut";
            this.BtnItemsOut.Size = new System.Drawing.Size(140, 45);
            this.BtnItemsOut.TabIndex = 40;
            this.BtnItemsOut.Text = "출고";
            this.BtnItemsOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnItemsOut.UseVisualStyleBackColor = false;
            // 
            // BtnBooks
            // 
            this.BtnBooks.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnBooks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnBooks.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBooks.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnBooks.ForeColor = System.Drawing.Color.White;
            this.BtnBooks.Image = global::HugoSMS.WinForm.App.Properties.Resources.Items__1_;
            this.BtnBooks.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBooks.Location = new System.Drawing.Point(4, 8);
            this.BtnBooks.Name = "BtnBooks";
            this.BtnBooks.Size = new System.Drawing.Size(140, 45);
            this.BtnBooks.TabIndex = 39;
            this.BtnBooks.Text = "입고";
            this.BtnBooks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBooks.UseVisualStyleBackColor = false;
            this.BtnBooks.Click += new System.EventHandler(this.BtnBooks_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainPanel.Location = new System.Drawing.Point(4, 59);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1203, 506);
            this.MainPanel.TabIndex = 38;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnProducts);
            this.Controls.Add(this.BtnLogOut);
            this.Controls.Add(this.BtnUsers);
            this.Controls.Add(this.BtnMyAccount);
            this.Controls.Add(this.BtnSettings);
            this.Controls.Add(this.BtnStores);
            this.Controls.Add(this.BtnItemsOut);
            this.Controls.Add(this.BtnBooks);
            this.Controls.Add(this.MainPanel);
            this.Name = "MainView";
            this.Size = new System.Drawing.Size(1210, 572);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button BtnProducts;
        public System.Windows.Forms.Button BtnLogOut;
        public System.Windows.Forms.Button BtnUsers;
        public System.Windows.Forms.Button BtnMyAccount;
        public System.Windows.Forms.Button BtnSettings;
        public System.Windows.Forms.Button BtnStores;
        public System.Windows.Forms.Button BtnItemsOut;
        public System.Windows.Forms.Button BtnBooks;
        private System.Windows.Forms.Panel MainPanel;
    }
}
