
namespace HugoSMS.WinForm.App.Views.Users
{
    partial class EditUserView
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
            this.DgvUsers = new System.Windows.Forms.DataGridView();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblIdentityNo = new System.Windows.Forms.Label();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.TxtSurName = new System.Windows.Forms.TextBox();
            this.CboActivated = new System.Windows.Forms.ComboBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.CboAdmin = new System.Windows.Forms.ComboBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtIdNumber = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.LblUserID = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnBack = new System.Windows.Forms.Button();
            this.RboDeactivated = new System.Windows.Forms.RadioButton();
            this.RboActivated = new System.Windows.Forms.RadioButton();
            this.RboAll = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserIDentityNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserAdmin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserActivated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvUsers
            // 
            this.DgvUsers.AllowUserToAddRows = false;
            this.DgvUsers.AllowUserToDeleteRows = false;
            this.DgvUsers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvUsers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DgvUsers.BackgroundColor = System.Drawing.Color.White;
            this.DgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserID,
            this.UserIDentityNumber,
            this.UserName,
            this.UserSurname,
            this.UserEmail,
            this.UserAdmin,
            this.UserActivated});
            this.DgvUsers.Location = new System.Drawing.Point(10, 52);
            this.DgvUsers.Name = "DgvUsers";
            this.DgvUsers.ReadOnly = true;
            this.DgvUsers.RowHeadersVisible = false;
            this.DgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvUsers.Size = new System.Drawing.Size(1184, 199);
            this.DgvUsers.TabIndex = 268;
            // 
            // TxtPassword
            // 
            this.TxtPassword.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPassword.Location = new System.Drawing.Point(238, 392);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(285, 26);
            this.TxtPassword.TabIndex = 267;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(27, 400);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 19);
            this.label4.TabIndex = 266;
            this.label4.Text = "Password:";
            // 
            // BtnSearch
            // 
            this.BtnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSearch.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSearch.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnSearch.Image = global::HugoSMS.WinForm.App.Properties.Resources.search;
            this.BtnSearch.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnSearch.Location = new System.Drawing.Point(1145, 257);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(49, 45);
            this.BtnSearch.TabIndex = 265;
            this.BtnSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnSearch.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(834, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 264;
            this.label3.Text = "검색어 :";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.Red;
            this.lblPassword.Location = new System.Drawing.Point(531, 398);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(51, 15);
            this.lblPassword.TabIndex = 273;
            this.lblPassword.Text = "label14";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.Red;
            this.lblEmail.Location = new System.Drawing.Point(532, 369);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(51, 15);
            this.lblEmail.TabIndex = 272;
            this.lblEmail.Text = "label12";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.ForeColor = System.Drawing.Color.Red;
            this.lblSurname.Location = new System.Drawing.Point(532, 340);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(51, 15);
            this.lblSurname.TabIndex = 271;
            this.lblSurname.Text = "label11";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Red;
            this.lblName.Location = new System.Drawing.Point(532, 311);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(43, 15);
            this.lblName.TabIndex = 270;
            this.lblName.Text = "label8";
            // 
            // lblIdentityNo
            // 
            this.lblIdentityNo.AutoSize = true;
            this.lblIdentityNo.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdentityNo.ForeColor = System.Drawing.Color.Red;
            this.lblIdentityNo.Location = new System.Drawing.Point(532, 282);
            this.lblIdentityNo.Name = "lblIdentityNo";
            this.lblIdentityNo.Size = new System.Drawing.Size(47, 15);
            this.lblIdentityNo.TabIndex = 269;
            this.lblIdentityNo.Text = "label 2";
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmin.ForeColor = System.Drawing.Color.Red;
            this.lblAdmin.Location = new System.Drawing.Point(531, 427);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(412, 45);
            this.lblAdmin.TabIndex = 277;
            this.lblAdmin.Text = "There is a minimum of two admin users registered to this system ,\r\ntherefore you " +
    "can not unregister or deactivate \r\nthis user an admin user.";
            this.lblAdmin.Visible = false;
            // 
            // TxtSearch
            // 
            this.TxtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtSearch.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSearch.Location = new System.Drawing.Point(891, 257);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(248, 26);
            this.TxtSearch.TabIndex = 263;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("나눔고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1031, 452);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 24);
            this.label5.TabIndex = 262;
            this.label5.Text = "Update";
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdate.Image = global::HugoSMS.WinForm.App.Properties.Resources.ok_appproval_acceptance__1_;
            this.BtnUpdate.Location = new System.Drawing.Point(1024, 393);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(93, 56);
            this.BtnUpdate.TabIndex = 261;
            this.BtnUpdate.UseVisualStyleBackColor = true;
            // 
            // TxtSurName
            // 
            this.TxtSurName.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSurName.Location = new System.Drawing.Point(238, 334);
            this.TxtSurName.Name = "TxtSurName";
            this.TxtSurName.Size = new System.Drawing.Size(285, 26);
            this.TxtSurName.TabIndex = 260;
            // 
            // CboActivated
            // 
            this.CboActivated.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboActivated.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboActivated.FormattingEnabled = true;
            this.CboActivated.Location = new System.Drawing.Point(238, 452);
            this.CboActivated.Name = "CboActivated";
            this.CboActivated.Size = new System.Drawing.Size(285, 27);
            this.CboActivated.TabIndex = 259;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmail.Location = new System.Drawing.Point(238, 363);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(285, 26);
            this.TxtEmail.TabIndex = 258;
            // 
            // CboAdmin
            // 
            this.CboAdmin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboAdmin.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboAdmin.FormattingEnabled = true;
            this.CboAdmin.Location = new System.Drawing.Point(238, 421);
            this.CboAdmin.Name = "CboAdmin";
            this.CboAdmin.Size = new System.Drawing.Size(285, 27);
            this.CboAdmin.TabIndex = 257;
            // 
            // TxtName
            // 
            this.TxtName.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtName.Location = new System.Drawing.Point(238, 305);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(285, 26);
            this.TxtName.TabIndex = 256;
            // 
            // TxtIdNumber
            // 
            this.TxtIdNumber.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIdNumber.Location = new System.Drawing.Point(238, 276);
            this.TxtIdNumber.Name = "TxtIdNumber";
            this.TxtIdNumber.Size = new System.Drawing.Size(285, 26);
            this.TxtIdNumber.TabIndex = 255;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(27, 286);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 19);
            this.label7.TabIndex = 254;
            this.label7.Text = "Identity Number:";
            // 
            // LblUserID
            // 
            this.LblUserID.AutoSize = true;
            this.LblUserID.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUserID.Location = new System.Drawing.Point(240, 254);
            this.LblUserID.Name = "LblUserID";
            this.LblUserID.Size = new System.Drawing.Size(57, 19);
            this.LblUserID.TabIndex = 253;
            this.LblUserID.Text = "userID";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label16.Location = new System.Drawing.Point(27, 255);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(68, 19);
            this.label16.TabIndex = 252;
            this.label16.Text = "User ID:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(27, 371);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 19);
            this.label10.TabIndex = 251;
            this.label10.Text = "Email:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label19.Location = new System.Drawing.Point(27, 459);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(90, 19);
            this.label19.TabIndex = 250;
            this.label19.Text = "Activated: ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label13.Location = new System.Drawing.Point(27, 430);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 19);
            this.label13.TabIndex = 249;
            this.label13.Text = "Admin:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(27, 341);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 19);
            this.label9.TabIndex = 248;
            this.label9.Text = "Surname:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(27, 312);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 19);
            this.label6.TabIndex = 247;
            this.label6.Text = "Name:";
            // 
            // BtnBack
            // 
            this.BtnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnBack.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBack.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBack.Image = global::HugoSMS.WinForm.App.Properties.Resources.reply__1_;
            this.BtnBack.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnBack.Location = new System.Drawing.Point(1123, 377);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(71, 104);
            this.BtnBack.TabIndex = 246;
            this.BtnBack.Text = "Back";
            this.BtnBack.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnBack.UseVisualStyleBackColor = true;
            // 
            // RboDeactivated
            // 
            this.RboDeactivated.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RboDeactivated.AutoSize = true;
            this.RboDeactivated.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RboDeactivated.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RboDeactivated.Location = new System.Drawing.Point(1127, 27);
            this.RboDeactivated.Name = "RboDeactivated";
            this.RboDeactivated.Size = new System.Drawing.Size(61, 19);
            this.RboDeactivated.TabIndex = 245;
            this.RboDeactivated.TabStop = true;
            this.RboDeactivated.Text = "비활성";
            this.RboDeactivated.UseVisualStyleBackColor = true;
            // 
            // RboActivated
            // 
            this.RboActivated.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RboActivated.AutoSize = true;
            this.RboActivated.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RboActivated.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RboActivated.Location = new System.Drawing.Point(1072, 27);
            this.RboActivated.Name = "RboActivated";
            this.RboActivated.Size = new System.Drawing.Size(49, 19);
            this.RboActivated.TabIndex = 244;
            this.RboActivated.TabStop = true;
            this.RboActivated.Text = "활성";
            this.RboActivated.UseVisualStyleBackColor = true;
            // 
            // RboAll
            // 
            this.RboAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RboAll.AutoSize = true;
            this.RboAll.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RboAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RboAll.Location = new System.Drawing.Point(1017, 27);
            this.RboAll.Name = "RboAll";
            this.RboAll.Size = new System.Drawing.Size(49, 19);
            this.RboAll.TabIndex = 243;
            this.RboAll.TabStop = true;
            this.RboAll.Text = "모두";
            this.RboAll.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔고딕", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(4, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 34);
            this.label1.TabIndex = 242;
            this.label1.Text = "사용자 수정";
            // 
            // UserID
            // 
            this.UserID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.UserID.FillWeight = 213F;
            this.UserID.HeaderText = "번호";
            this.UserID.Name = "UserID";
            this.UserID.ReadOnly = true;
            this.UserID.Width = 54;
            // 
            // UserIDentityNumber
            // 
            this.UserIDentityNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.UserIDentityNumber.FillWeight = 82F;
            this.UserIDentityNumber.HeaderText = "고유번호";
            this.UserIDentityNumber.Name = "UserIDentityNumber";
            this.UserIDentityNumber.ReadOnly = true;
            this.UserIDentityNumber.Width = 78;
            // 
            // UserName
            // 
            this.UserName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.UserName.FillWeight = 200F;
            this.UserName.HeaderText = "이름";
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            this.UserName.Width = 54;
            // 
            // UserSurname
            // 
            this.UserSurname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.UserSurname.FillWeight = 150F;
            this.UserSurname.HeaderText = "성";
            this.UserSurname.Name = "UserSurname";
            this.UserSurname.ReadOnly = true;
            this.UserSurname.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.UserSurname.Width = 23;
            // 
            // UserEmail
            // 
            this.UserEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.UserEmail.FillWeight = 200F;
            this.UserEmail.HeaderText = "이메일";
            this.UserEmail.Name = "UserEmail";
            this.UserEmail.ReadOnly = true;
            this.UserEmail.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.UserEmail.Width = 47;
            // 
            // UserAdmin
            // 
            this.UserAdmin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.UserAdmin.FillWeight = 60F;
            this.UserAdmin.HeaderText = "관리자여부";
            this.UserAdmin.Name = "UserAdmin";
            this.UserAdmin.ReadOnly = true;
            this.UserAdmin.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.UserAdmin.Width = 71;
            // 
            // UserActivated
            // 
            this.UserActivated.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UserActivated.FillWeight = 60F;
            this.UserActivated.HeaderText = "활성화";
            this.UserActivated.Name = "UserActivated";
            this.UserActivated.ReadOnly = true;
            this.UserActivated.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // EditUserView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DgvUsers);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblIdentityNo);
            this.Controls.Add(this.lblAdmin);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.TxtSurName);
            this.Controls.Add(this.CboActivated);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.CboAdmin);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.TxtIdNumber);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.LblUserID);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.RboDeactivated);
            this.Controls.Add(this.RboActivated);
            this.Controls.Add(this.RboAll);
            this.Controls.Add(this.label1);
            this.Name = "EditUserView";
            this.Size = new System.Drawing.Size(1203, 491);
            this.Load += new System.EventHandler(this.EditUserView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView DgvUsers;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblIdentityNo;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.TextBox TxtSurName;
        private System.Windows.Forms.ComboBox CboActivated;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.ComboBox CboAdmin;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtIdNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LblUserID;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.RadioButton RboDeactivated;
        private System.Windows.Forms.RadioButton RboActivated;
        private System.Windows.Forms.RadioButton RboAll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserIDentityNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserAdmin;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserActivated;
    }
}
