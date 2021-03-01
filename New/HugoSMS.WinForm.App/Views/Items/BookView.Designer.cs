
using System.Drawing;

namespace HugoSMS.WinForm.App.Views.Items
{
    partial class BookView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.BtnViewItemsPerStore = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.StoreName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrandName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BarcodeNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TagEPC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnScanItemsInStore = new System.Windows.Forms.Button();
            this.RboOutOfStock = new System.Windows.Forms.RadioButton();
            this.RboInStock = new System.Windows.Forms.RadioButton();
            this.RboAll = new System.Windows.Forms.RadioButton();
            this.BtnExportPdf = new System.Windows.Forms.Button();
            this.BtnUpdateItem = new System.Windows.Forms.Button();
            this.BtnAddItem = new System.Windows.Forms.Button();
            this.DgvItems = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvItems)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnViewItemsPerStore
            // 
            this.BtnViewItemsPerStore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnViewItemsPerStore.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnViewItemsPerStore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnViewItemsPerStore.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnViewItemsPerStore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnViewItemsPerStore.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnViewItemsPerStore.ForeColor = System.Drawing.Color.White;
            this.BtnViewItemsPerStore.Location = new System.Drawing.Point(971, 157);
            this.BtnViewItemsPerStore.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnViewItemsPerStore.Name = "BtnViewItemsPerStore";
            this.BtnViewItemsPerStore.Size = new System.Drawing.Size(228, 40);
            this.BtnViewItemsPerStore.TabIndex = 97;
            this.BtnViewItemsPerStore.Text = "View Items per Store";
            this.BtnViewItemsPerStore.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔고딕", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(4, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 34);
            this.label1.TabIndex = 89;
            this.label1.Text = "Items";
            // 
            // StoreName
            // 
            this.StoreName.HeaderText = "Store Name";
            this.StoreName.Name = "StoreName";
            this.StoreName.ReadOnly = true;
            // 
            // ItemStatus
            // 
            this.ItemStatus.HeaderText = "Item Status";
            this.ItemStatus.Name = "ItemStatus";
            this.ItemStatus.ReadOnly = true;
            // 
            // CategoryName
            // 
            this.CategoryName.HeaderText = "Category Name";
            this.CategoryName.Name = "CategoryName";
            this.CategoryName.ReadOnly = true;
            // 
            // BrandName
            // 
            this.BrandName.HeaderText = "Brand Name";
            this.BrandName.Name = "BrandName";
            this.BrandName.ReadOnly = true;
            // 
            // BarcodeNumber
            // 
            this.BarcodeNumber.HeaderText = "Barcode Number";
            this.BarcodeNumber.Name = "BarcodeNumber";
            this.BarcodeNumber.ReadOnly = true;
            // 
            // ProductDescription
            // 
            this.ProductDescription.HeaderText = "Product Description";
            this.ProductDescription.Name = "ProductDescription";
            this.ProductDescription.ReadOnly = true;
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "Product Name";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // TagEPC
            // 
            this.TagEPC.HeaderText = "EPC";
            this.TagEPC.Name = "TagEPC";
            this.TagEPC.ReadOnly = true;
            // 
            // ItemID
            // 
            this.ItemID.HeaderText = "Item ID";
            this.ItemID.Name = "ItemID";
            this.ItemID.ReadOnly = true;
            // 
            // BtnScanItemsInStore
            // 
            this.BtnScanItemsInStore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnScanItemsInStore.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnScanItemsInStore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnScanItemsInStore.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnScanItemsInStore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnScanItemsInStore.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnScanItemsInStore.ForeColor = System.Drawing.Color.White;
            this.BtnScanItemsInStore.Location = new System.Drawing.Point(971, 203);
            this.BtnScanItemsInStore.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnScanItemsInStore.Name = "BtnScanItemsInStore";
            this.BtnScanItemsInStore.Size = new System.Drawing.Size(228, 40);
            this.BtnScanItemsInStore.TabIndex = 98;
            this.BtnScanItemsInStore.Text = "Scan Items in a Store";
            this.BtnScanItemsInStore.UseVisualStyleBackColor = false;
            // 
            // RboOutOfStock
            // 
            this.RboOutOfStock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RboOutOfStock.AutoSize = true;
            this.RboOutOfStock.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RboOutOfStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RboOutOfStock.Location = new System.Drawing.Point(867, 37);
            this.RboOutOfStock.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RboOutOfStock.Name = "RboOutOfStock";
            this.RboOutOfStock.Size = new System.Drawing.Size(96, 19);
            this.RboOutOfStock.TabIndex = 96;
            this.RboOutOfStock.TabStop = true;
            this.RboOutOfStock.Text = "OutOfStock";
            this.RboOutOfStock.UseVisualStyleBackColor = true;
            // 
            // RboInStock
            // 
            this.RboInStock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RboInStock.AutoSize = true;
            this.RboInStock.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RboInStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RboInStock.Location = new System.Drawing.Point(790, 37);
            this.RboInStock.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RboInStock.Name = "RboInStock";
            this.RboInStock.Size = new System.Drawing.Size(69, 19);
            this.RboInStock.TabIndex = 95;
            this.RboInStock.TabStop = true;
            this.RboInStock.Text = "InStock";
            this.RboInStock.UseVisualStyleBackColor = true;
            // 
            // RboAll
            // 
            this.RboAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RboAll.AutoSize = true;
            this.RboAll.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RboAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RboAll.Location = new System.Drawing.Point(742, 37);
            this.RboAll.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RboAll.Name = "RboAll";
            this.RboAll.Size = new System.Drawing.Size(40, 19);
            this.RboAll.TabIndex = 94;
            this.RboAll.TabStop = true;
            this.RboAll.Text = "All";
            this.RboAll.UseVisualStyleBackColor = true;
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
            this.BtnExportPdf.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnExportPdf.Name = "BtnExportPdf";
            this.BtnExportPdf.Size = new System.Drawing.Size(228, 43);
            this.BtnExportPdf.TabIndex = 93;
            this.BtnExportPdf.Text = "Export PDF";
            this.BtnExportPdf.UseVisualStyleBackColor = false;
            // 
            // BtnUpdateItem
            // 
            this.BtnUpdateItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnUpdateItem.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnUpdateItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnUpdateItem.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnUpdateItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdateItem.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdateItem.ForeColor = System.Drawing.Color.White;
            this.BtnUpdateItem.Location = new System.Drawing.Point(971, 111);
            this.BtnUpdateItem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnUpdateItem.Name = "BtnUpdateItem";
            this.BtnUpdateItem.Size = new System.Drawing.Size(228, 40);
            this.BtnUpdateItem.TabIndex = 92;
            this.BtnUpdateItem.Text = "Update Item";
            this.BtnUpdateItem.UseVisualStyleBackColor = false;
            // 
            // BtnAddItem
            // 
            this.BtnAddItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAddItem.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnAddItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnAddItem.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddItem.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddItem.ForeColor = System.Drawing.Color.White;
            this.BtnAddItem.Location = new System.Drawing.Point(971, 65);
            this.BtnAddItem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnAddItem.Name = "BtnAddItem";
            this.BtnAddItem.Size = new System.Drawing.Size(228, 40);
            this.BtnAddItem.TabIndex = 91;
            this.BtnAddItem.Text = "Add Item";
            this.BtnAddItem.UseVisualStyleBackColor = false;
            // 
            // DgvItems
            // 
            this.DgvItems.AllowUserToAddRows = false;
            this.DgvItems.AllowUserToDeleteRows = false;
            this.DgvItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvItems.BackgroundColor = System.Drawing.Color.White;
            this.DgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemID,
            this.TagEPC,
            this.ProductName,
            this.ProductDescription,
            this.BarcodeNumber,
            this.BrandName,
            this.CategoryName,
            this.ItemStatus,
            this.StoreName});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("나눔고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvItems.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvItems.Location = new System.Drawing.Point(10, 62);
            this.DgvItems.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DgvItems.Name = "DgvItems";
            this.DgvItems.ReadOnly = true;
            this.DgvItems.RowHeadersVisible = false;
            this.DgvItems.Size = new System.Drawing.Size(953, 418);
            this.DgvItems.TabIndex = 90;
            // 
            // Books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnViewItemsPerStore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnScanItemsInStore);
            this.Controls.Add(this.RboOutOfStock);
            this.Controls.Add(this.RboInStock);
            this.Controls.Add(this.RboAll);
            this.Controls.Add(this.BtnExportPdf);
            this.Controls.Add(this.BtnUpdateItem);
            this.Controls.Add(this.BtnAddItem);
            this.Controls.Add(this.DgvItems);
            this.Name = "Books";
            this.Size = new System.Drawing.Size(1203, 491);
            ((System.ComponentModel.ISupportInitialize)(this.DgvItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button BtnViewItemsPerStore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn StoreName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrandName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BarcodeNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TagEPC;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemID;
        private System.Windows.Forms.Button BtnScanItemsInStore;
        private System.Windows.Forms.RadioButton RboOutOfStock;
        private System.Windows.Forms.RadioButton RboInStock;
        private System.Windows.Forms.RadioButton RboAll;
        private System.Windows.Forms.Button BtnExportPdf;
        private System.Windows.Forms.Button BtnUpdateItem;
        private System.Windows.Forms.Button BtnAddItem;
        private System.Windows.Forms.DataGridView DgvItems;
    }
}
