using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HERP.Controls
{
    public partial class CustomStatus : UserControl
    {
        public string Result
        {
            get { return LblResult.Text; }
            set { LblResult.Text = value; }
        }

        public CustomStatus()
        {
            InitializeComponent();

            InitAdditional();

            Load += OnLoad;
            Paint += OnPaint;
            Resize += (sender, args) => Refresh();
        }

        private void OnPaint(object sender, PaintEventArgs e)
        {
            int iWidth = Width;
            int iHeight = 35;

            if (Height > 35) { iHeight = Height; }

            e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(0x00F7F7F7)), 0, 5, iWidth, iHeight);
            e.Graphics.DrawRectangle(new Pen(Color.FromArgb(0x00D6D3D6), 1), 0, 5, iWidth - 1, iHeight - 3);
            e.Graphics.DrawRectangle(new Pen(Color.FromArgb(0x00EFEBEF), 3), 2, 7, iWidth - 5, iHeight - 7);
        }

        private void OnLoad(object sender, EventArgs e)
        {
            SetStyle(ControlStyles.DoubleBuffer, true);
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            Height = 35;
        }

        private void InitAdditional()
        {
            Dock = DockStyle.Bottom;
            Height = 35;
        }
    }
}
