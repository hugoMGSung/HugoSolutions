namespace HERP.Krypton.App
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
            this.KryptonRibbon = new ComponentFactory.Krypton.Ribbon.KryptonRibbon();
            this.KryptonDockingManager = new ComponentFactory.Krypton.Docking.KryptonDockingManager();
            this.KryptionManager = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.KryptonDockableWorkspace = new ComponentFactory.Krypton.Docking.KryptonDockableWorkspace();
            ((System.ComponentModel.ISupportInitialize)(this.KryptonRibbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KryptonDockableWorkspace)).BeginInit();
            this.SuspendLayout();
            // 
            // KryptonRibbon
            // 
            this.KryptonRibbon.InDesignHelperMode = true;
            this.KryptonRibbon.Name = "KryptonRibbon";
            this.KryptonRibbon.SelectedContext = null;
            this.KryptonRibbon.SelectedTab = null;
            this.KryptonRibbon.Size = new System.Drawing.Size(1262, 149);
            this.KryptonRibbon.TabIndex = 1;
            // 
            // KryptonDockableWorkspace
            // 
            this.KryptonDockableWorkspace.AutoHiddenHost = false;
            this.KryptonDockableWorkspace.CompactFlags = ((ComponentFactory.Krypton.Workspace.CompactFlags)(((ComponentFactory.Krypton.Workspace.CompactFlags.RemoveEmptyCells | ComponentFactory.Krypton.Workspace.CompactFlags.RemoveEmptySequences) 
            | ComponentFactory.Krypton.Workspace.CompactFlags.PromoteLeafs)));
            this.KryptonDockableWorkspace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KryptonDockableWorkspace.Location = new System.Drawing.Point(0, 149);
            this.KryptonDockableWorkspace.Name = "KryptonDockableWorkspace";
            // 
            // 
            // 
            this.KryptonDockableWorkspace.Root.UniqueName = "A594335887DA48836584888C752EE2F8";
            this.KryptonDockableWorkspace.Root.WorkspaceControl = this.KryptonDockableWorkspace;
            this.KryptonDockableWorkspace.ShowMaximizeButton = false;
            this.KryptonDockableWorkspace.Size = new System.Drawing.Size(1262, 524);
            this.KryptonDockableWorkspace.TabIndex = 2;
            this.KryptonDockableWorkspace.TabStop = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.KryptonDockableWorkspace);
            this.Controls.Add(this.KryptonRibbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hugo Enterprise Resources Plan";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.KryptonRibbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KryptonDockableWorkspace)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComponentFactory.Krypton.Ribbon.KryptonRibbon KryptonRibbon;
        private ComponentFactory.Krypton.Docking.KryptonDockingManager KryptonDockingManager;
        private ComponentFactory.Krypton.Toolkit.KryptonManager KryptionManager;
        private ComponentFactory.Krypton.Docking.KryptonDockableWorkspace KryptonDockableWorkspace;
    }
}

