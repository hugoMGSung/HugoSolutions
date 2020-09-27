using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Docking;
using ComponentFactory.Krypton.Toolkit;
using ComponentFactory.Krypton.Navigator;
using ComponentFactory.Krypton.Workspace;

namespace HERP.Krypton.App
{
    public partial class MainForm : KryptonForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            KryptonDockingWorkspace w = KryptonDockingManager.ManageWorkspace("Workspace", KryptonDockableWorkspace);
            //KryptonDockingManager.ManageControl("Control", KryptonPanel, w);
            //KryptonDockingManager.ManageFloating("Floating", this);

            KryptonDockingManager.AddToWorkspace("Workspace", new KryptonPage[] { NewPage(), NewPage() });
            //KryptonDockingManager.AddDockspace("Control", DockingEdge.Bottom, new KryptonPage[] { NewPage(), NewPage() });
            //KryptonDockingManager.AddAutoHiddenGroup("Control", DockingEdge.Left, new KryptonPage[] { NewPage(), NewPage(), NewPage() });
            //KryptonDockingManager.AddFloatingWindow("Floating", new KryptonPage[] { NewPage(), NewPage() });

        }

        private int _count = 1;
        private KryptonPage NewPage()
        {
            // Create and uniquely name the page
            KryptonPage page = new KryptonPage();
            page.Text = "Page " + (_count++).ToString();
            page.TextTitle = page.Text;
            page.UniqueName = page.Text;

            // Add rich text box as content of the page
            KryptonRichTextBox rtb = new KryptonRichTextBox();
            rtb.StateCommon.Border.Draw = InheritBool.False;
            rtb.Dock = DockStyle.Fill;
            rtb.Text = "Page Content";
            page.Controls.Add(rtb);

            return page;
        }
    }
}
