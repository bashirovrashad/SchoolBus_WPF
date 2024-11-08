using ClassLibrary_Data_Access.Repositories_.Concretes_;
using ClassLibrary_Models.Entities_.Concretes_;
using schoolbus.Views.ViewWindows;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace schoolbus.Views.ViewPages
{
    /// <summary>
    /// Interaction logic for Driver_Page.xaml
    /// </summary>
    public partial class Driver_Page : Page
    {
        private New_Driver_Window _driver_window = null;
        Driver_Repos _Repos { get; set; }
        public ObservableCollection<Driver> Drivers { get; set; }

        public Driver_Page()
        {
            InitializeComponent();
            _Repos = new Driver_Repos();
            Drivers= new ObservableCollection<Driver>(_Repos.GetAll());
            DataContext = this;
        }

        private void refresh_click(object sender, RoutedEventArgs e)
        {
            _Repos = new Driver_Repos();
            Drivers.Clear();
            var drivers = _Repos.GetAll();
            foreach (var driver in drivers)
            {
                Drivers.Add(driver);
            }
            DataContext = this;
        }

        private void new_driver_window_open(object sender, RoutedEventArgs e)
        {
            if (_driver_window == null)
            {
                _driver_window = new New_Driver_Window();
            }
            _driver_window.Closed += New_Driver_Window_Closed;
            _driver_window.ShowDialog();
        }
        private void New_Driver_Window_Closed(object sender, EventArgs e)
        {
            _driver_window = null;
        }
    }
}
