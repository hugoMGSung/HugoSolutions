namespace HERP.Origin.App.Views
{
    partial class SYS2001
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.CboUseYn = new System.Windows.Forms.ComboBox();
            this.LblUseYn = new System.Windows.Forms.Label();
            this.PageStatus = new HERP.Controls.CustomStatus();
            this.PageHead = new HERP.Controls.PageHeader();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 80);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Size = new System.Drawing.Size(900, 365);
            this.splitContainer1.SplitterDistance = 267;
            this.splitContainer1.TabIndex = 7;
            // 
            // CboUseYn
            // 
            this.CboUseYn.FormattingEnabled = true;
            this.CboUseYn.Location = new System.Drawing.Point(74, 52);
            this.CboUseYn.Name = "CboUseYn";
            this.CboUseYn.Size = new System.Drawing.Size(100, 20);
            this.CboUseYn.TabIndex = 13;
            // 
            // LblUseYn
            // 
            this.LblUseYn.AutoSize = true;
            this.LblUseYn.BackColor = System.Drawing.Color.White;
            this.LblUseYn.Location = new System.Drawing.Point(15, 56);
            this.LblUseYn.Name = "LblUseYn";
            this.LblUseYn.Size = new System.Drawing.Size(53, 12);
            this.LblUseYn.TabIndex = 12;
            this.LblUseYn.Text = "사용유무";
            // 
            // PageStatus
            // 
            this.PageStatus.BackColor = System.Drawing.Color.White;
            this.PageStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PageStatus.Location = new System.Drawing.Point(0, 445);
            this.PageStatus.Name = "PageStatus";
            this.PageStatus.Result = "...";
            this.PageStatus.Size = new System.Drawing.Size(900, 35);
            this.PageStatus.TabIndex = 6;
            // 
            // PageHead
            // 
            this.PageHead.BackColor = System.Drawing.SystemColors.Window;
            this.PageHead.ButtonItems = new HERP.Controls.CustomButton[0];
            this.PageHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.PageHead.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.PageHead.Location = new System.Drawing.Point(0, 0);
            this.PageHead.Name = "PageHead";
            this.PageHead.Size = new System.Drawing.Size(900, 80);
            this.PageHead.TabIndex = 2;
            this.PageHead.Title = "메뉴관리";
            // 
            // BtnSearch
            // 
            this.BtnSearch.BackColor = System.Drawing.Color.GhostWhite;
            this.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSearch.Image = global::HERP.Origin.App.Properties.Resources.btn_Search;
            this.BtnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSearch.Location = new System.Drawing.Point(734, 9);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(75, 25);
            this.BtnSearch.TabIndex = 14;
            this.BtnSearch.Text = "       조  회";
            this.BtnSearch.UseVisualStyleBackColor = false;
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.GhostWhite;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnClose.Image = global::HERP.Origin.App.Properties.Resources.btn_Close;
            this.BtnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnClose.Location = new System.Drawing.Point(813, 9);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(75, 25);
            this.BtnClose.TabIndex = 14;
            this.BtnClose.Text = "       닫  기";
            this.BtnClose.UseVisualStyleBackColor = false;
            // 
            // SYS2001
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 480);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.CboUseYn);
            this.Controls.Add(this.LblUseYn);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.PageStatus);
            this.Controls.Add(this.PageHead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SYS2001";
            this.Text = "메뉴관리";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Controls.PageHeader PageHead;
        private Controls.CustomStatus PageStatus;
        private System.Windows.Forms.SplitContainer splitContainer1;
        internal System.Windows.Forms.ComboBox CboUseYn;
        internal System.Windows.Forms.Label LblUseYn;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Button BtnClose;
    }
}