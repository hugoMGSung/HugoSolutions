namespace HERP.Controls
{
    partial class CustomToolbox
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
            this.UdZoom = new System.Windows.Forms.NumericUpDown();
            this.BtnExcel = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnZoom = new System.Windows.Forms.Button();
            this.BtnPrint = new System.Windows.Forms.Button();
            this.BtnFilter = new System.Windows.Forms.Button();
            this.BtnFind = new System.Windows.Forms.Button();
            this.BtnSort = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UdZoom)).BeginInit();
            this.SuspendLayout();
            // 
            // UdZoom
            // 
            this.UdZoom.BackColor = System.Drawing.SystemColors.Window;
            this.UdZoom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UdZoom.DecimalPlaces = 1;
            this.UdZoom.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.UdZoom.Increment = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            this.UdZoom.Location = new System.Drawing.Point(57, 126);
            this.UdZoom.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.UdZoom.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            this.UdZoom.Name = "UdZoom";
            this.UdZoom.Size = new System.Drawing.Size(15, 17);
            this.UdZoom.TabIndex = 16;
            this.UdZoom.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UdZoom.ValueChanged += new System.EventHandler(this.UdZoom_ValueChanged);
            // 
            // BtnExcel
            // 
            this.BtnExcel.BackColor = System.Drawing.Color.GhostWhite;
            this.BtnExcel.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BtnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExcel.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnExcel.Location = new System.Drawing.Point(0, 74);
            this.BtnExcel.Name = "BtnExcel";
            this.BtnExcel.Size = new System.Drawing.Size(72, 26);
            this.BtnExcel.TabIndex = 15;
            this.BtnExcel.Text = "Excel";
            this.BtnExcel.UseVisualStyleBackColor = false;
            this.BtnExcel.Click += new System.EventHandler(this.BtnExcel_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.GhostWhite;
            this.BtnExit.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnExit.Location = new System.Drawing.Point(0, 149);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(72, 26);
            this.BtnExit.TabIndex = 14;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnZoom
            // 
            this.BtnZoom.BackColor = System.Drawing.Color.GhostWhite;
            this.BtnZoom.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BtnZoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnZoom.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnZoom.Location = new System.Drawing.Point(0, 124);
            this.BtnZoom.Margin = new System.Windows.Forms.Padding(0);
            this.BtnZoom.Name = "BtnZoom";
            this.BtnZoom.Size = new System.Drawing.Size(72, 26);
            this.BtnZoom.TabIndex = 13;
            this.BtnZoom.Text = "Zoom";
            this.BtnZoom.UseVisualStyleBackColor = false;
            // 
            // BtnPrint
            // 
            this.BtnPrint.BackColor = System.Drawing.Color.GhostWhite;
            this.BtnPrint.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BtnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPrint.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnPrint.Location = new System.Drawing.Point(0, 99);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.Size = new System.Drawing.Size(72, 26);
            this.BtnPrint.TabIndex = 12;
            this.BtnPrint.Text = "Print";
            this.BtnPrint.UseVisualStyleBackColor = false;
            this.BtnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // BtnFilter
            // 
            this.BtnFilter.BackColor = System.Drawing.Color.GhostWhite;
            this.BtnFilter.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BtnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFilter.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnFilter.Location = new System.Drawing.Point(0, 49);
            this.BtnFilter.Name = "BtnFilter";
            this.BtnFilter.Size = new System.Drawing.Size(72, 26);
            this.BtnFilter.TabIndex = 11;
            this.BtnFilter.Text = "Filter";
            this.BtnFilter.UseVisualStyleBackColor = false;
            this.BtnFilter.Click += new System.EventHandler(this.BtnFilter_Click);
            // 
            // BtnFind
            // 
            this.BtnFind.BackColor = System.Drawing.Color.GhostWhite;
            this.BtnFind.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BtnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFind.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnFind.Location = new System.Drawing.Point(0, -1);
            this.BtnFind.Name = "BtnFind";
            this.BtnFind.Size = new System.Drawing.Size(72, 26);
            this.BtnFind.TabIndex = 9;
            this.BtnFind.Text = "Find";
            this.BtnFind.UseVisualStyleBackColor = false;
            this.BtnFind.Click += new System.EventHandler(this.BtnFind_Click);
            // 
            // BtnSort
            // 
            this.BtnSort.BackColor = System.Drawing.Color.GhostWhite;
            this.BtnSort.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BtnSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSort.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnSort.Location = new System.Drawing.Point(0, 24);
            this.BtnSort.Name = "BtnSort";
            this.BtnSort.Size = new System.Drawing.Size(72, 26);
            this.BtnSort.TabIndex = 10;
            this.BtnSort.Text = "Sort";
            this.BtnSort.UseVisualStyleBackColor = false;
            this.BtnSort.Click += new System.EventHandler(this.BtnSort_Click);
            // 
            // CustomToolbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.UdZoom);
            this.Controls.Add(this.BtnExcel);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnZoom);
            this.Controls.Add(this.BtnPrint);
            this.Controls.Add(this.BtnFilter);
            this.Controls.Add(this.BtnFind);
            this.Controls.Add(this.BtnSort);
            this.Font = new System.Drawing.Font("나눔고딕", 9F);
            this.Name = "CustomToolbox";
            this.Size = new System.Drawing.Size(72, 175);
            ((System.ComponentModel.ISupportInitialize)(this.UdZoom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown UdZoom;
        private System.Windows.Forms.Button BtnExcel;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnZoom;
        private System.Windows.Forms.Button BtnPrint;
        private System.Windows.Forms.Button BtnFilter;
        private System.Windows.Forms.Button BtnFind;
        private System.Windows.Forms.Button BtnSort;
    }
}
