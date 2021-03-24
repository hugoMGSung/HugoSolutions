
namespace HugoSMS.WinForm.App.Views.Stores
{
    partial class StoreView
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
            this.label1 = new System.Windows.Forms.Label();
            this.BtnExportPdf = new System.Windows.Forms.Button();
            this.BtnUpdateStore = new System.Windows.Forms.Button();
            this.BtnAddStore = new System.Windows.Forms.Button();
            this.DgvData = new System.Windows.Forms.DataGridView();
            this.StoreID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StoreName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StoreLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountItems = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔고딕", 21.75F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(4, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 34);
            this.label1.TabIndex = 99;
            this.label1.Text = "창고 리스트";
            // 
            // BtnExportPdf
            // 
            this.BtnExportPdf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnExportPdf.BackColor = System.Drawing.Color.Silver;
            this.BtnExportPdf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnExportPdf.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnExportPdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExportPdf.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExportPdf.ForeColor = System.Drawing.Color.White;
            this.BtnExportPdf.Location = new System.Drawing.Point(971, 16);
            this.BtnExportPdf.Name = "BtnExportPdf";
            this.BtnExportPdf.Size = new System.Drawing.Size(228, 43);
            this.BtnExportPdf.TabIndex = 108;
            this.BtnExportPdf.Tag = "EXPORT";
            this.BtnExportPdf.Text = "PDF 익스포트";
            this.BtnExportPdf.UseVisualStyleBackColor = false;
            this.BtnExportPdf.Click += new System.EventHandler(this.BtnExportPdf_Click);
            // 
            // BtnUpdateStore
            // 
            this.BtnUpdateStore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnUpdateStore.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnUpdateStore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnUpdateStore.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnUpdateStore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdateStore.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdateStore.ForeColor = System.Drawing.Color.White;
            this.BtnUpdateStore.Location = new System.Drawing.Point(971, 114);
            this.BtnUpdateStore.Name = "BtnUpdateStore";
            this.BtnUpdateStore.Size = new System.Drawing.Size(228, 43);
            this.BtnUpdateStore.TabIndex = 110;
            this.BtnUpdateStore.Tag = "UPDATE";
            this.BtnUpdateStore.Text = "창고 수정";
            this.BtnUpdateStore.UseVisualStyleBackColor = false;
            this.BtnUpdateStore.Click += new System.EventHandler(this.BtnUpdateStore_Click);
            // 
            // BtnAddStore
            // 
            this.BtnAddStore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAddStore.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnAddStore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnAddStore.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnAddStore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddStore.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddStore.ForeColor = System.Drawing.Color.White;
            this.BtnAddStore.Location = new System.Drawing.Point(971, 65);
            this.BtnAddStore.Name = "BtnAddStore";
            this.BtnAddStore.Size = new System.Drawing.Size(228, 43);
            this.BtnAddStore.TabIndex = 109;
            this.BtnAddStore.Tag = "ADD";
            this.BtnAddStore.Text = "창고 추가";
            this.BtnAddStore.UseVisualStyleBackColor = false;
            this.BtnAddStore.Click += new System.EventHandler(this.BtnAddStore_Click);
            // 
            // DgvData
            // 
            this.DgvData.AllowUserToAddRows = false;
            this.DgvData.AllowUserToDeleteRows = false;
            this.DgvData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvData.BackgroundColor = System.Drawing.Color.White;
            this.DgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StoreID,
            this.StoreName,
            this.StoreLocation,
            this.AmountItems});
            this.DgvData.Location = new System.Drawing.Point(10, 52);
            this.DgvData.Name = "DgvData";
            this.DgvData.ReadOnly = true;
            this.DgvData.RowHeadersVisible = false;
            this.DgvData.Size = new System.Drawing.Size(955, 428);
            this.DgvData.TabIndex = 111;
            // 
            // StoreID
            // 
            this.StoreID.HeaderText = "Store ID";
            this.StoreID.Name = "StoreID";
            this.StoreID.ReadOnly = true;
            // 
            // StoreName
            // 
            this.StoreName.HeaderText = "Store Name";
            this.StoreName.Name = "StoreName";
            this.StoreName.ReadOnly = true;
            // 
            // StoreLocation
            // 
            this.StoreLocation.HeaderText = "Store Location";
            this.StoreLocation.Name = "StoreLocation";
            this.StoreLocation.ReadOnly = true;
            // 
            // AmountItems
            // 
            this.AmountItems.HeaderText = "Amount of Items";
            this.AmountItems.Name = "AmountItems";
            this.AmountItems.ReadOnly = true;
            // 
            // StoreView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.DgvData);
            this.Controls.Add(this.BtnUpdateStore);
            this.Controls.Add(this.BtnAddStore);
            this.Controls.Add(this.BtnExportPdf);
            this.Controls.Add(this.label1);
            this.Name = "StoreView";
            this.Size = new System.Drawing.Size(1203, 491);
            this.Load += new System.EventHandler(this.StoreView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnExportPdf;
        private System.Windows.Forms.Button BtnUpdateStore;
        private System.Windows.Forms.Button BtnAddStore;
        private System.Windows.Forms.DataGridView DgvData;
        private System.Windows.Forms.DataGridViewTextBoxColumn StoreID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StoreName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StoreLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountItems;
    }
}
