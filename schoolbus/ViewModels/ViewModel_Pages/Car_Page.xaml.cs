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
    /// Interaction logic for Car_Page.xaml
    /// </summary>
    public partial class Car_Page : Page
    {
        New_Car_Window new_Car_Window = null;
        Car_Repos _Repos {  get; set; }
        public ObservableCollection<Car> Cars { get; set; }

        public Car_Page()
        {
            InitializeComponent();
            _Repos= new Car_Repos();
            Cars = new ObservableCollection<Car>(_Repos.GetAll());
            Cars.RemoveAt(2);
            DataContext = this;
        }

        private void refresh_click(object sender, RoutedEventArgs e)
        {
            _Repos = new Car_Repos();
            Cars.Clear();
            var cars = _Repos.GetAll();
            foreach (var car in cars)
            {
                Cars.Add(car);
            }
            DataContext = this;
        }



        private void new_car_window_open(object sender, RoutedEventArgs e)
        {
            if (new_Car_Window == null)
            {
                new_Car_Window = new New_Car_Window();              
            }
            new_Car_Window.Closed += New_Car_Window_Closed;
            new_Car_Window.ShowDialog();
        }

        private void New_Car_Window_Closed(object sender, EventArgs e)
        {
            new_Car_Window = null; 
        }
    }
}
