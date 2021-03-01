using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Input;
using Herp.Wpf.App.Helpers;
using Herp.Wpf.App.Models;
using Herp.Wpf.App.Processors;
using UserControl = System.Windows.Controls.UserControl;

namespace Herp.Wpf.App.Views
{
    /// <summary>
    /// EmployeesUc.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class EmployeesUc : UserControl
    {
        public static ObservableCollection<ExampleObject> MySource { get; set; }
        public static ObservableCollection<Employees> EmpSource { get; set; }

        private EmployeesProc empProc;

        public EmployeesUc()
        {
            InitializeComponent();

            empProc = new EmployeesProc();

            InitMainEvents();

            //MySource = new ObservableCollection<ExampleObject>();
            //MySource = CreateObjects();
            EmpSource = new ObservableCollection<Employees>();
            EmpSource = GetEmployees(null);
            GrdEmployee.ItemsSource = EmpSource;
        }

        private void InitMainEvents()
        {
            TxtName.KeyDown += (sender, args) => BtnSearch_Click(sender, args);
        }

        private ObservableCollection<Employees> GetEmployees(string name)
        {
            var list = new ObservableCollection<Employees>();
            return empProc.GetAllEmployeeses(name);
        }

        private ObservableCollection<ExampleObject> CreateObjects(int n = 10)
        {
            var list = new ObservableCollection<ExampleObject>();

            for (var i = 0; i < n; i++)
            {
                list.Add(ExampleObject.CreateRandom());
            }

            return list;
        }

        private void BtnSearch_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            GrdEmployee.ItemsSource.Clear();
            EmpSource = GetEmployees(TxtName.Text.Trim());
            GrdEmployee.ItemsSource = EmpSource;
        }

        private void BtnAddEmployee_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            AddEmployeeView view = new AddEmployeeView();
            view.ProcMode = HugoMode.CREATE;
            view.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            view.ShowDialog();
        }

        private void BtnDelEmployee_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Console.WriteLine("TEST");
            // GrdEmployee.SelectionCell {M1} Column: 12 Row: 0 이와 같이 나와야지만 삭제 가능
        }
    }
}
