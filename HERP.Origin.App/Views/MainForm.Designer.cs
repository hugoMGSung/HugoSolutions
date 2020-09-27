namespace HERP.Origin.App
{
    partial class MainForm
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

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("RootMenu");
            this.ImgButton = new System.Windows.Forms.ImageList(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.PnlMain = new System.Windows.Forms.Panel();
            this.SplitContMain = new System.Windows.Forms.SplitContainer();
            this.TabTotal = new System.Windows.Forms.TabControl();
            this.TabMenu = new System.Windows.Forms.TabPage();
            this.TrvMenu = new System.Windows.Forms.TreeView();
            this.ImgMenu = new System.Windows.Forms.ImageList(this.components);
            this.TabFavorite = new System.Windows.Forms.TabPage();
            this.TclMain = new System.Windows.Forms.TabControl();
            this.StsMain = new System.Windows.Forms.StatusStrip();
            this.TssLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.TssLoginTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.TssLog = new System.Windows.Forms.ToolStripStatusLabel();
            this.PnlTop = new System.Windows.Forms.Panel();
            this.BtnInfo = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnHelp = new System.Windows.Forms.Button();
            this.BtnFavorite = new System.Windows.Forms.Button();
            this.BtnMenu = new System.Windows.Forms.Button();
            this.LblUserName = new System.Windows.Forms.Label();
            this.PnlLogoArea = new System.Windows.Forms.Panel();
            this.PnlLogo = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.PnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContMain)).BeginInit();
            this.SplitContMain.Panel1.SuspendLayout();
            this.SplitContMain.Panel2.SuspendLayout();
            this.SplitContMain.SuspendLayout();
            this.TabTotal.SuspendLayout();
            this.TabMenu.SuspendLayout();
            this.StsMain.SuspendLayout();
            this.PnlTop.SuspendLayout();
            this.PnlLogoArea.SuspendLayout();
            this.SuspendLayout();
            // 
            // ImgButton
            // 
            this.ImgButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImgButton.ImageStream")));
            this.ImgButton.TransparentColor = System.Drawing.Color.Transparent;
            this.ImgButton.Images.SetKeyName(0, "list.png");
            this.ImgButton.Images.SetKeyName(1, "favorite.png");
            this.ImgButton.Images.SetKeyName(2, "info.png");
            this.ImgButton.Images.SetKeyName(3, "question.png");
            this.ImgButton.Images.SetKeyName(4, "exit.png");
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.PnlMain);
            this.panel2.Controls.Add(this.StsMain);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 33);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1106, 512);
            this.panel2.TabIndex = 1;
            // 
            // PnlMain
            // 
            this.PnlMain.Controls.Add(this.SplitContMain);
            this.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlMain.Location = new System.Drawing.Point(0, 0);
            this.PnlMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PnlMain.Name = "PnlMain";
            this.PnlMain.Size = new System.Drawing.Size(1106, 488);
            this.PnlMain.TabIndex = 1;
            // 
            // SplitContMain
            // 
            this.SplitContMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContMain.Location = new System.Drawing.Point(0, 0);
            this.SplitContMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SplitContMain.Name = "SplitContMain";
            // 
            // SplitContMain.Panel1
            // 
            this.SplitContMain.Panel1.Controls.Add(this.TabTotal);
            // 
            // SplitContMain.Panel2
            // 
            this.SplitContMain.Panel2.Controls.Add(this.TclMain);
            this.SplitContMain.Size = new System.Drawing.Size(1106, 488);
            this.SplitContMain.SplitterDistance = 217;
            this.SplitContMain.TabIndex = 0;
            // 
            // TabTotal
            // 
            this.TabTotal.Controls.Add(this.TabMenu);
            this.TabTotal.Controls.Add(this.TabFavorite);
            this.TabTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabTotal.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TabTotal.ImageList = this.ImgButton;
            this.TabTotal.Location = new System.Drawing.Point(0, 0);
            this.TabTotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TabTotal.Name = "TabTotal";
            this.TabTotal.SelectedIndex = 0;
            this.TabTotal.Size = new System.Drawing.Size(217, 488);
            this.TabTotal.TabIndex = 0;
            // 
            // TabMenu
            // 
            this.TabMenu.Controls.Add(this.TrvMenu);
            this.TabMenu.ImageKey = "list.png";
            this.TabMenu.Location = new System.Drawing.Point(4, 25);
            this.TabMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TabMenu.Name = "TabMenu";
            this.TabMenu.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TabMenu.Size = new System.Drawing.Size(209, 459);
            this.TabMenu.TabIndex = 0;
            this.TabMenu.Text = "메인메뉴";
            this.TabMenu.UseVisualStyleBackColor = true;
            // 
            // TrvMenu
            // 
            this.TrvMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TrvMenu.ImageIndex = 0;
            this.TrvMenu.ImageList = this.ImgMenu;
            this.TrvMenu.Location = new System.Drawing.Point(3, 2);
            this.TrvMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TrvMenu.Name = "TrvMenu";
            treeNode2.Name = "NewMenu";
            treeNode2.Text = "RootMenu";
            this.TrvMenu.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this.TrvMenu.SelectedImageIndex = 0;
            this.TrvMenu.Size = new System.Drawing.Size(203, 455);
            this.TrvMenu.TabIndex = 0;
            this.TrvMenu.DoubleClick += new System.EventHandler(this.TrvMenu_DoubleClick);
            // 
            // ImgMenu
            // 
            this.ImgMenu.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImgMenu.ImageStream")));
            this.ImgMenu.TransparentColor = System.Drawing.Color.Transparent;
            this.ImgMenu.Images.SetKeyName(0, "folder.png");
            this.ImgMenu.Images.SetKeyName(1, "folder_open.png");
            this.ImgMenu.Images.SetKeyName(2, "paper.png");
            this.ImgMenu.Images.SetKeyName(3, "paper_open.png");
            this.ImgMenu.Images.SetKeyName(4, "close.png");
            // 
            // TabFavorite
            // 
            this.TabFavorite.ImageKey = "favorite.png";
            this.TabFavorite.Location = new System.Drawing.Point(4, 25);
            this.TabFavorite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TabFavorite.Name = "TabFavorite";
            this.TabFavorite.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TabFavorite.Size = new System.Drawing.Size(209, 459);
            this.TabFavorite.TabIndex = 1;
            this.TabFavorite.Text = "즐겨찾기";
            this.TabFavorite.UseVisualStyleBackColor = true;
            // 
            // TclMain
            // 
            this.TclMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TclMain.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TclMain.Location = new System.Drawing.Point(0, 0);
            this.TclMain.Name = "TclMain";
            this.TclMain.SelectedIndex = 0;
            this.TclMain.Size = new System.Drawing.Size(885, 488);
            this.TclMain.TabIndex = 0;
            this.TclMain.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.TclMain_DrawItem);
            this.TclMain.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TclMain_MouseClick);
            // 
            // StsMain
            // 
            this.StsMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.StsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TssLabel,
            this.TssLoginTime,
            this.toolStripStatusLabel1,
            this.TssLog});
            this.StsMain.Location = new System.Drawing.Point(0, 488);
            this.StsMain.Name = "StsMain";
            this.StsMain.Padding = new System.Windows.Forms.Padding(1, 0, 12, 0);
            this.StsMain.Size = new System.Drawing.Size(1106, 24);
            this.StsMain.TabIndex = 0;
            this.StsMain.Text = "statusStrip1";
            // 
            // TssLabel
            // 
            this.TssLabel.Name = "TssLabel";
            this.TssLabel.Size = new System.Drawing.Size(77, 19);
            this.TssLabel.Text = "Login Time";
            // 
            // TssLoginTime
            // 
            this.TssLoginTime.Name = "TssLoginTime";
            this.TssLoginTime.Size = new System.Drawing.Size(144, 19);
            this.TssLoginTime.Text = "2020-09-17 22:36:17";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(12, 19);
            this.toolStripStatusLabel1.Text = "|";
            // 
            // TssLog
            // 
            this.TssLog.Name = "TssLog";
            this.TssLog.Size = new System.Drawing.Size(82, 19);
            this.TssLog.Text = "Any Results";
            // 
            // PnlTop
            // 
            this.PnlTop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PnlTop.BackgroundImage")));
            this.PnlTop.Controls.Add(this.BtnInfo);
            this.PnlTop.Controls.Add(this.BtnExit);
            this.PnlTop.Controls.Add(this.BtnHelp);
            this.PnlTop.Controls.Add(this.BtnFavorite);
            this.PnlTop.Controls.Add(this.BtnMenu);
            this.PnlTop.Controls.Add(this.LblUserName);
            this.PnlTop.Controls.Add(this.PnlLogoArea);
            this.PnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlTop.Location = new System.Drawing.Point(0, 0);
            this.PnlTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PnlTop.Name = "PnlTop";
            this.PnlTop.Size = new System.Drawing.Size(1106, 33);
            this.PnlTop.TabIndex = 0;
            this.PnlTop.TabStop = true;
            // 
            // BtnInfo
            // 
            this.BtnInfo.BackColor = System.Drawing.Color.Transparent;
            this.BtnInfo.FlatAppearance.BorderSize = 0;
            this.BtnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInfo.ImageKey = "info.png";
            this.BtnInfo.ImageList = this.ImgButton;
            this.BtnInfo.Location = new System.Drawing.Point(247, 6);
            this.BtnInfo.Name = "BtnInfo";
            this.BtnInfo.Size = new System.Drawing.Size(22, 20);
            this.BtnInfo.TabIndex = 44;
            this.BtnInfo.UseVisualStyleBackColor = false;
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.Transparent;
            this.BtnExit.FlatAppearance.BorderSize = 0;
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.ImageKey = "exit.png";
            this.BtnExit.ImageList = this.ImgButton;
            this.BtnExit.Location = new System.Drawing.Point(303, 6);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(22, 20);
            this.BtnExit.TabIndex = 43;
            this.BtnExit.UseVisualStyleBackColor = false;
            // 
            // BtnHelp
            // 
            this.BtnHelp.BackColor = System.Drawing.Color.Transparent;
            this.BtnHelp.FlatAppearance.BorderSize = 0;
            this.BtnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHelp.ImageKey = "question.png";
            this.BtnHelp.ImageList = this.ImgButton;
            this.BtnHelp.Location = new System.Drawing.Point(275, 6);
            this.BtnHelp.Name = "BtnHelp";
            this.BtnHelp.Size = new System.Drawing.Size(22, 20);
            this.BtnHelp.TabIndex = 42;
            this.BtnHelp.UseVisualStyleBackColor = false;
            // 
            // BtnFavorite
            // 
            this.BtnFavorite.BackColor = System.Drawing.Color.Transparent;
            this.BtnFavorite.FlatAppearance.BorderSize = 0;
            this.BtnFavorite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFavorite.ImageKey = "favorite.png";
            this.BtnFavorite.ImageList = this.ImgButton;
            this.BtnFavorite.Location = new System.Drawing.Point(219, 6);
            this.BtnFavorite.Name = "BtnFavorite";
            this.BtnFavorite.Size = new System.Drawing.Size(22, 20);
            this.BtnFavorite.TabIndex = 41;
            this.BtnFavorite.UseVisualStyleBackColor = false;
            // 
            // BtnMenu
            // 
            this.BtnMenu.BackColor = System.Drawing.Color.Transparent;
            this.BtnMenu.FlatAppearance.BorderSize = 0;
            this.BtnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMenu.ForeColor = System.Drawing.Color.Transparent;
            this.BtnMenu.ImageKey = "list.png";
            this.BtnMenu.ImageList = this.ImgButton;
            this.BtnMenu.Location = new System.Drawing.Point(191, 6);
            this.BtnMenu.Name = "BtnMenu";
            this.BtnMenu.Size = new System.Drawing.Size(22, 20);
            this.BtnMenu.TabIndex = 40;
            this.BtnMenu.UseVisualStyleBackColor = false;
            // 
            // LblUserName
            // 
            this.LblUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblUserName.AutoSize = true;
            this.LblUserName.BackColor = System.Drawing.Color.Transparent;
            this.LblUserName.Font = new System.Drawing.Font("나눔고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LblUserName.ForeColor = System.Drawing.Color.White;
            this.LblUserName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblUserName.Location = new System.Drawing.Point(1050, 7);
            this.LblUserName.Name = "LblUserName";
            this.LblUserName.Size = new System.Drawing.Size(52, 14);
            this.LblUserName.TabIndex = 39;
            this.LblUserName.Text = "    로그인";
            this.LblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PnlLogoArea
            // 
            this.PnlLogoArea.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PnlLogoArea.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PnlLogoArea.BackgroundImage")));
            this.PnlLogoArea.Controls.Add(this.PnlLogo);
            this.PnlLogoArea.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlLogoArea.Location = new System.Drawing.Point(0, 0);
            this.PnlLogoArea.Margin = new System.Windows.Forms.Padding(0);
            this.PnlLogoArea.Name = "PnlLogoArea";
            this.PnlLogoArea.Size = new System.Drawing.Size(182, 33);
            this.PnlLogoArea.TabIndex = 36;
            // 
            // PnlLogo
            // 
            this.PnlLogo.BackColor = System.Drawing.Color.Transparent;
            this.PnlLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PnlLogo.BackgroundImage")));
            this.PnlLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PnlLogo.Location = new System.Drawing.Point(39, 6);
            this.PnlLogo.Margin = new System.Windows.Forms.Padding(0);
            this.PnlLogo.Name = "PnlLogo";
            this.PnlLogo.Size = new System.Drawing.Size(136, 21);
            this.PnlLogo.TabIndex = 21;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 545);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.PnlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hugo ERP";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.PnlMain.ResumeLayout(false);
            this.SplitContMain.Panel1.ResumeLayout(false);
            this.SplitContMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContMain)).EndInit();
            this.SplitContMain.ResumeLayout(false);
            this.TabTotal.ResumeLayout(false);
            this.TabMenu.ResumeLayout(false);
            this.StsMain.ResumeLayout(false);
            this.StsMain.PerformLayout();
            this.PnlTop.ResumeLayout(false);
            this.PnlTop.PerformLayout();
            this.PnlLogoArea.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlTop;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel PnlMain;
        private System.Windows.Forms.StatusStrip StsMain;
        internal System.Windows.Forms.Panel PnlLogoArea;
        internal System.Windows.Forms.Panel PnlLogo;
        internal System.Windows.Forms.Label LblUserName;
        private System.Windows.Forms.ImageList ImgButton;
        private System.Windows.Forms.SplitContainer SplitContMain;
        private System.Windows.Forms.TabControl TabTotal;
        private System.Windows.Forms.TabPage TabMenu;
        private System.Windows.Forms.TabPage TabFavorite;
        private System.Windows.Forms.TreeView TrvMenu;
        private System.Windows.Forms.ImageList ImgMenu;
        private System.Windows.Forms.ToolStripStatusLabel TssLabel;
        private System.Windows.Forms.ToolStripStatusLabel TssLoginTime;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel TssLog;
        private System.Windows.Forms.TabControl TclMain;
        internal System.Windows.Forms.Button BtnInfo;
        internal System.Windows.Forms.Button BtnExit;
        internal System.Windows.Forms.Button BtnHelp;
        internal System.Windows.Forms.Button BtnFavorite;
        internal System.Windows.Forms.Button BtnMenu;
    }
}

