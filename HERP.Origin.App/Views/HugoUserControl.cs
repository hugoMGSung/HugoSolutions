using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Data.TreeList;
using Org.BouncyCastle.Bcpg.OpenPgp;

namespace HERP.Origin.App.Views
{
    public partial class HugoUserControl : Form
    {
        public string ProgramId { get; set; }

        public bool MdiChild
        {
            get => isMdiChild;
            set
            {
                isMdiChild = value;
                if (isMdiChild)
                {
                    Padding = new Padding(8);
                    BackColor = Color.White;
                }
                else
                {
                    Padding = new Padding(0);
                    BackColor = SystemColors.Control;
                }
            }
        }
        private bool isMdiChild = true;

        public HugoUserControl()
        {
            InitializeComponent();

            Padding = new Padding(8);
            BackColor = Color.White;
            isMdiChild = true;
        }
    }
}
