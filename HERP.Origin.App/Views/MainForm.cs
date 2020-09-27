using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using HERP.Origin.App.Business;
using HERP.Origin.App.Helpers;
using HERP.Origin.App.Model;
using HERP.Origin.App.Views;
using Newtonsoft.Json.Linq;

namespace HERP.Origin.App
{
    /// <summary>
    /// MainForm : 메인폼 메인소스
    /// Edited : Hugo MG Sung
    /// Dated : 2019-09-18
    /// </summary>
    public partial class MainForm : Form
    {
        private MainProc business;

        Point _imageLocation = new Point(20, 4);
        Point _imgHitArea = new Point(20, 4);
        Image closeImage;

        /// <summary>
        /// 생성자
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            // 비즈니스 로직 생성
            business = new MainProc();
            // config.json읽어와서 설정정보 처리
            GetConfig();
            // 버전 표시
            //Assembly assembly = Assembly.GetEntryAssembly();
            //Text = $"Hugo ERP: Ver {assembly.GetName().Version}";
            Text = $"Hugo ERP: Ver {Commons.Version}";
            // 이벤트 설정
            Load += OnLoad;

            closeImage = Properties.Resources.close;
            TclMain.Padding= new Point(20, 4);
        }

        private void GetConfig()
        {
            JObject obj = JObject.Parse(File.ReadAllText(@"config.json"));
            Commons.ConnString = $"Data Source={obj["sqlserver"]["host"]};" +
                                 $"Initial Catalog={obj["sqlserver"]["database"]};" +
                                 "Persist Security Info=True;"+
                                 $"User ID={obj["sqlserver"]["userid"]};" +
                                 $"Password={obj["sqlserver"]["password"]}";

            Commons.RegUserId = obj["userconfig"]["userid"].ToString();
            Commons.Version = obj["version"].ToString();
            Commons.Domain = obj["domain"].ToString();
        }

        private void SetConfig()
        {
            JObject obj = JObject.Parse(File.ReadAllText(@"config.json"));
            if (!string.IsNullOrEmpty(CurrentUser.UserId))
                obj["userconfig"]["userid"] = CurrentUser.UserId;

            File.WriteAllText(@"config.json", obj.ToString());
        }

        private void OnLoad(object sender, EventArgs e)
        {
            var form = new LoginForm {Width = 465, Height = 240};
            var result = form.ShowDialog();
            if (result != DialogResult.OK)
            {
                TssLog.Text = @"기타 문제가 발생했습니다. 관리자에게 문의하세요.";
            }
            // 닫힌 뒤에 처리
            SetConfig();
            // 트리메뉴 초기화
            InitTreeMenus();
            //InitSampleTreeMenus();

            // 로그인 사용자 정보 업데이트
            UpdateLoginInfo();
        }

        private void UpdateLoginInfo()
        {
            // 로그인 아이디 표시
            LblUserName.Text = CurrentUser.UserId;
            TssLoginTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        public List<TMenu> NewMenuList;

        /// <summary>
        /// 샘플 트리메뉴 테스트 메서드
        /// </summary>
        // ReSharper disable once UnusedMember.Local
        private void InitSampleTreeMenus()
        {
            TrvMenu.Nodes.Clear();
            var treeNode = TrvMenu.Nodes.Add(@"M1", @"HugoERP", 0, 1);
            business.GetSampleMenus();

            PopulateTreeView(0, treeNode);
            TrvMenu.ExpandAll();
        }

        private void InitTreeMenus()
        {
            TrvMenu.Nodes.Clear();
            var treeNode = TrvMenu.Nodes.Add(@"M1", @"HugoERP", 0, 1);
            NewMenuList = business.GetAllMenus(CurrentUser.UserId);

            // null이 아닐때만 트리 그리자~
            if (NewMenuList != null)
            {
                PopulateTreeView(0, treeNode);
                TrvMenu.ExpandAll();
            }
        }

        /// <summary>
        /// 트리뷰 메뉴 생성 메서드
        /// </summary>
        /// <param name="parentIdx"></param>
        /// <param name="parentNode"></param>
        private void PopulateTreeView(int parentIdx, TreeNode parentNode)
        {
            foreach (var item in NewMenuList.Where(x => x.Parent_Idx == parentIdx))
            {
                TreeNode mNode = new TreeNode
                {
                    Text = item.Name,
                    Name = item.Idx.ToString(),
                    Tag = item.ID,
                    ImageIndex = 0,
                    SelectedImageIndex = 1
                };

                TreeNode childNode;
                if (parentNode == null)
                {
                    TrvMenu.Nodes.Add(mNode);
                    childNode = mNode;
                }
                else
                {
                    parentNode.Nodes.Add(mNode);
                    childNode = mNode;
                }

                if (childNode.Level == 3)
                {
                    childNode.ImageIndex = 2;
                    childNode.SelectedImageIndex = 3;
                }
                PopulateTreeView(item.Idx, childNode);
            }
        }

        /// <summary>
        /// 메뉴트리 더블클릭 이벤트 핸들러
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TrvMenu_DoubleClick(object sender, EventArgs e)
        {
            if (TrvMenu.SelectedNode == null)
                Commons.NLogger.Error("Menu Tree is null");

            var selMenu = TrvMenu.SelectedNode;
            if (selMenu != null && selMenu.Level < 3) return;

            Debug.Assert(selMenu != null, nameof(selMenu) + " != null");
            //MessageBox.Show(selMenu.Tag.ToString());

            CreateForm(selMenu);
        }

        private void CreateForm(TreeNode selMenu)
        {
            Form curForm = null;

            if (IsFormOpened(selMenu.Tag.ToString(), ref curForm))
            {
                //curForm.WindowState = FormWindowState.Maximized;
                //curForm.BringToFront();
                ActivatePage(selMenu.Tag.ToString());
                return;
            }
            else
            {
                OpenForm(selMenu.Tag.ToString(), ref curForm);
            }

            if (curForm is null)
            {
                Commons.NLogger.Error("프로세스(프로그램) ID가 정확하지 않습니다");
                MessageBox.Show(@"프로세스(프로그램) ID가 정확하지 않습니다", @"오류", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 탭페이지 만들고 추가하기
            TabPage newPage = new TabPage(selMenu.Text);
            
            newPage.Tag = selMenu.Tag;
            // 폼이 그래도 탭페이지에 들어가지 않는다
            curForm.TopLevel = false;
            curForm.WindowState = FormWindowState.Maximized;
            curForm.Width = TclMain.Width - 8;
            curForm.Height = TclMain.Height - 8;
            curForm.Visible = true; // 이게 없으면 보이지 않는다!!

            newPage.Controls.Add(curForm);
            TclMain.TabPages.Add(newPage);
            // 사이즈 키워야 함
            //TclMain.TabPages[TclMain.TabPages.Count - 1].Width
        }

        private void ActivatePage(string formId)
        {
            foreach (TabPage item in TclMain.TabPages)
            {
                if (item.Tag.ToString() == formId)
                {
                    item.Focus();
                }
            }
        }

        private void OpenForm(string formId, ref Form outform)
        {
            var nm_namespace = @"HERP.Origin.App.Views";
            var asm = Assembly.GetExecutingAssembly();
            var modules = asm.GetModules();
            var type = modules[0].GetType($"{nm_namespace}.{formId}");
            
            try
            {
                if (type != null)
                {
                    outform = Activator.CreateInstance(type) as Form;
                }
            }
            catch (Exception e)
            {
                Commons.NLogger.Error(e.Message);
            }
        }

        private bool IsFormOpened(string formId, ref Form outform)
        {
            /*foreach (var item in this.OwnedForms)
            {
                if (item.Name.ToUpper() == formId.ToUpper())
                {
                    outform = item;
                    return true;
                }
            }

            foreach (var item in this.MdiChildren)
            {
                if (item.Name.ToUpper() == formId.ToUpper())
                {
                    outform = item;
                    return true;
                }
            }*/

            foreach (TabPage item in TclMain.TabPages)
            {
                if (item.Tag.ToString() == formId)
                {
                    outform = null;
                    return true;
                }
            }

            return false;
        }

        private void TclMain_DrawItem(object sender, DrawItemEventArgs e)
        {
            Image img = new Bitmap(closeImage);
            Rectangle r = e.Bounds;
            r = this.TclMain.GetTabRect(e.Index);
            r.Offset(2, 2);
            Brush TitleBrush = new SolidBrush(Color.Black);
            Font f = this.Font;
            string title = this.TclMain.TabPages[e.Index].Text;
            e.Graphics.DrawString(title, f, TitleBrush, new PointF(r.X, r.Y));
            e.Graphics.DrawImage(img, new Point(r.X + (this.TclMain.GetTabRect(e.Index).Width - _imageLocation.X), _imageLocation.Y));
        }

        private void TclMain_MouseClick(object sender, MouseEventArgs e)
        {
            TabControl tabControl = (TabControl)sender;
            Point p = e.Location;
            int _tabWidth = 0;
            _tabWidth = this.TclMain.GetTabRect(tabControl.SelectedIndex).Width - (_imgHitArea.X);
            Rectangle r = this.TclMain.GetTabRect(tabControl.SelectedIndex);
            r.Offset(_tabWidth, _imgHitArea.Y);
            r.Width = 16;
            r.Height = 16;
            if (TclMain.SelectedIndex >= 1)
            {
                if (r.Contains(p))
                {
                    TabPage tabPage = (TabPage)tabControl.TabPages[tabControl.SelectedIndex];
                    tabControl.TabPages.Remove(tabPage);
                }
            }
        }
    }
}