using System;
using System.Drawing;
using System.Windows.Forms;

namespace HERP.Controls
{
    public partial class PageHeader: UserControl
    {
        private CustomButton[] _buttonItems = new CustomButton[0];

        private int _iPrevWidth = 0;
        private int _iPrevHeight = 0;

        public PageHeader()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            Height = 80;

            Load += OnLoad;
            Paint += OnPaint;
        }

        private void OnPaint(object sender, PaintEventArgs e)
        {
            SetControlSize();

            var iWidth = 100;
            if (Parent is Control) { iWidth = Parent.Width; }

            var iHeight = Height - 5;

            if (iHeight > 45 && iWidth > 100 && (_iPrevHeight != iHeight || _iPrevWidth != iWidth))
            {
                e.Graphics.DrawLine(new Pen(Color.FromArgb(0x00F7F7F7), iHeight - 37), 0, (iHeight - 37) / 2 + 37, iWidth, (iHeight - 37) / 2 + 37);
                e.Graphics.DrawLine(new Pen(Color.FromArgb(0x00D6D3D6), 1), 0, 37, iWidth, 37);
                e.Graphics.DrawLine(new Pen(Color.FromArgb(0x00EFEBEF), 4), 0, 40, iWidth, 40);
                e.Graphics.DrawLine(new Pen(Color.FromArgb(0x00D6D3D6), 1), 0, iHeight, iWidth, iHeight);
            }
        }

        private void OnLoad(object sender, EventArgs e)
        {
            SetStyle(ControlStyles.DoubleBuffer, true);
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
        }

        public CustomButton[] ButtonItems
        {

            get => _buttonItems;

            set
            {
                _buttonItems = value;

                for (var i = _buttonItems.Length - 1; i >= 0; i--)
                {
                    var btn = _buttonItems[i];

                    pnlMenu.Controls.Add(btn);
                    // btn.Move += BtnOnMove;
                    btn.Visible = true;
                }

                SetControlSize();
            }
        }

        public string Title
        {
            get => LblTitle.Text;
            set
            {
                LblTitle.Text = value;
                if (ParentForm != null)
                {
                    ParentForm.Text = value;
                }
            }
        }

        private void SetControlSize()
        {
            var iWidth = pnlMenu.Width;

            if (iWidth > 100 && Height > 8)
            {
                for (var i = _buttonItems.Length - 1; i >= 0; i--)
                {
                    var btn = _buttonItems[i];

                    if (btn.Visible)
                    {
                        iWidth -= btn.Width + 2;
                        if (iWidth < 0) iWidth = 0;
                        btn.Top = 8;
                        btn.Left = iWidth;
                    }
                }
            }
        }

        private void BtnOnMove(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
