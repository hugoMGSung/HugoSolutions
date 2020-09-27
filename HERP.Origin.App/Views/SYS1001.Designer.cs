namespace HERP.Origin.App.Views
{
    partial class SYS1001
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
            this.PageStatus = new HERP.Controls.CustomStatus();
            this.PageHead = new HERP.Controls.PageHeader();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.Label6 = new System.Windows.Forms.Label();
            this.txt사용자명 = new System.Windows.Forms.TextBox();
            this.cb그룹 = new System.Windows.Forms.ComboBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.PageHead.Title = "기본사용자관리";
            // 
            // BtnSearch
            // 
            this.BtnSearch.BackColor = System.Drawing.Color.GhostWhite;
            this.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSearch.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
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
            this.BtnClose.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnClose.Image = global::HERP.Origin.App.Properties.Resources.btn_Close;
            this.BtnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnClose.Location = new System.Drawing.Point(813, 9);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(75, 25);
            this.BtnClose.TabIndex = 14;
            this.BtnClose.Text = "       닫  기";
            this.BtnClose.UseVisualStyleBackColor = false;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.BackColor = System.Drawing.Color.White;
            this.Label6.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Label6.Location = new System.Drawing.Point(283, 55);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(51, 14);
            this.Label6.TabIndex = 86;
            this.Label6.Text = "사용자명";
            // 
            // txt사용자명
            // 
            this.txt사용자명.BackColor = System.Drawing.Color.White;
            this.txt사용자명.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt사용자명.Location = new System.Drawing.Point(340, 51);
            this.txt사용자명.Margin = new System.Windows.Forms.Padding(1);
            this.txt사용자명.Name = "txt사용자명";
            this.txt사용자명.Size = new System.Drawing.Size(149, 21);
            this.txt사용자명.TabIndex = 85;
            // 
            // cb그룹
            // 
            this.cb그룹.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cb그룹.FormattingEnabled = true;
            this.cb그룹.Location = new System.Drawing.Point(50, 51);
            this.cb그룹.Name = "cb그룹";
            this.cb그룹.Size = new System.Drawing.Size(209, 22);
            this.cb그룹.TabIndex = 83;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.White;
            this.Label1.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Label1.Location = new System.Drawing.Point(15, 54);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(29, 14);
            this.Label1.TabIndex = 84;
            this.Label1.Text = "그룹";
            // 
            // SYS1001
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 480);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.txt사용자명);
            this.Controls.Add(this.cb그룹);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.PageStatus);
            this.Controls.Add(this.PageHead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SYS1001";
            this.Text = "기본사용자관리";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Controls.PageHeader PageHead;
        private Controls.CustomStatus PageStatus;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Button BtnClose;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.TextBox txt사용자명;
        internal System.Windows.Forms.ComboBox cb그룹;
        internal System.Windows.Forms.Label Label1;
    }
}