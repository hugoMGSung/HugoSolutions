namespace HERP.Controls
{
    partial class CustomButton
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
            this.BtnCtl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnCtl
            // 
            this.BtnCtl.BackColor = System.Drawing.Color.GhostWhite;
            this.BtnCtl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnCtl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnCtl.FlatAppearance.BorderSize = 0;
            this.BtnCtl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCtl.Font = new System.Drawing.Font("나눔고딕", 9F);
            this.BtnCtl.ForeColor = System.Drawing.Color.Black;
            this.BtnCtl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCtl.Location = new System.Drawing.Point(1, 1);
            this.BtnCtl.Margin = new System.Windows.Forms.Padding(0);
            this.BtnCtl.Name = "BtnCtl";
            this.BtnCtl.Size = new System.Drawing.Size(73, 23);
            this.BtnCtl.TabIndex = 12;
            this.BtnCtl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCtl.UseVisualStyleBackColor = false;
            // 
            // CustomButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.BtnCtl);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("나눔고딕", 9F);
            this.Name = "CustomButton";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.Size = new System.Drawing.Size(75, 25);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnCtl;
    }
}
