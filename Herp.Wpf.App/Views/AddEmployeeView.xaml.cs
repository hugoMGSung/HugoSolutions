using Herp.Wpf.App.Helpers;
using Herp.Wpf.App.Processors;
using MahApps.Metro.Controls;

namespace Herp.Wpf.App.Views
{
    /// <summary>
    /// AddEmployeeView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class AddEmployeeView : MetroWindow
    {
        private EmployeesProc empProc;

        public AddEmployeeView()
        {
            InitializeComponent();

            empProc = new EmployeesProc();

            InitMainEvents();
            InitControlEvents();
            TxtFirstName.Focus();
        }

        public HugoMode ProcMode { get; set; }

        private void InitControlEvents()
        {
            
        }

        private void InitMainEvents()
        {
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {

        }
    }
}
