using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace HERP.Controls
{
    [DefaultEvent("Click")]
    public partial class CustomButton : UserControl
    {
        public enum CustomButtonType
        {
            Etc = 0, 
            Search,
            New,
            Save,
            Delete,
            RowAdd,
            RowDel,
            Excel, 
            Print, 
            Toolbox, 
            Close, 
            Apply
        }

        public enum CustomAuth
        {
            Search = 1,
            Save, 
            Delete, 
            Excel, 
            Print, 
            Etc,
            New,
            None
        }

        private CustomButtonType _buttonType;

        public CustomButtonType ButtonType
        {
            get => _buttonType;
            set
            {
                _buttonType = value;
                switch (value)
                {
                    case CustomButtonType.Search:
                        Image = Properties.Resources.btn_Search;
                        Title = @"       조  회";
                        ButtonAuth = CustomAuth.Search;
                        break;

                    case CustomButtonType.New:
                        Image = Properties.Resources.btn_New;
                        Title = @"       초기화";
                        ButtonAuth = CustomAuth.New;
                        break;

                    case CustomButtonType.Save:
                        Image = Properties.Resources.btn_Save;
                        Title = @"       저  장";
                        ButtonAuth = CustomAuth.Save;
                        break;

                    case CustomButtonType.Delete:
                        Image = Properties.Resources.btn_Delete;
                        Title = @"       삭  제";
                        ButtonAuth = CustomAuth.Delete;
                        break;

                    case CustomButtonType.RowAdd:
                        Image = Properties.Resources.btn_RowAdd;
                        Title = @"       행추가";
                        ButtonAuth = CustomAuth.Etc;
                        break;

                    case CustomButtonType.RowDel:
                        Image = Properties.Resources.btn_RowDel;
                        Title = @"       행삭제";
                        ButtonAuth = CustomAuth.Delete;
                        break;

                    case CustomButtonType.Excel:
                        Image = Properties.Resources.btn_Excel;
                        Title = @"       엑  셀";
                        ButtonAuth = CustomAuth.Excel;
                        break;

                    case CustomButtonType.Print:
                        Image = Properties.Resources.btn_Print;
                        Title = @"       프린트";
                        ButtonAuth = CustomAuth.Print;
                        break;

                    case CustomButtonType.Toolbox:
                        Image = Properties.Resources.btn_ToolBox;
                        Title = @"       도  구";
                        ButtonAuth = CustomAuth.Search;
                        break;

                    case CustomButtonType.Close:
                        Image = Properties.Resources.btn_Close;
                        Title = @"       닫  기";
                        ButtonAuth = CustomAuth.Etc;
                        break;

                    case CustomButtonType.Apply:
                        Image = Properties.Resources.ic_check;
                        Title = @"       확  인";
                        ButtonAuth = CustomAuth.Search;
                        break;
                }
            }
        }

        public CustomAuth ButtonAuth { get; set; }

        public string Title
        {
            get => BtnCtl.Text;
            set => BtnCtl.Text = value;
        }

        public Image Image
        {
            get => BtnCtl.Image;
            set => BtnCtl.Image = value;
        }

        public delegate void CustomClick(object sender, EventArgs arg);

        public new event CustomClick Click;

        public CustomButton()
        {
            InitializeComponent();

            Load += OnLoad;
            EnabledChanged += OnEnabledChanged;
            BtnCtl.Click += BtnCtlOnClick;

            BtnCtl.Top = 1;
            BtnCtl.Left = 1;

            Width = 75;
            Height = 25;

            ButtonType = CustomButtonType.Etc;
            ButtonAuth = CustomAuth.None;
        }

        private void BtnCtlOnClick(object sender, EventArgs e)
        {
            if (ButtonType == CustomButtonType.Excel)
            {
                // export 처리
            }

            Click?.Invoke(this, e);

            if (ButtonType == CustomButtonType.Close && ParentForm != null)
            {
                ParentForm.Close();
            }
            
            // TODO : Toolbox는 나중에
        }

        private void OnEnabledChanged(object sender, EventArgs e)
        {
            if (Enabled)
            {
                BtnCtl.BackColor = Color.GhostWhite;
                BtnCtl.ForeColor = Color.Black;
            }
            else
            {
                BtnCtl.BackColor = Color.White;
                BtnCtl.ForeColor = Color.Gray;
            }
        }

        private void OnLoad(object sender, EventArgs e)
        {
            ButtonType = CustomButtonType.New;
        }
    }
}
