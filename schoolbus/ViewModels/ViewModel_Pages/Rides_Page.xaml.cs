using ClassLibrary_Data_Access.Repositories_.Concretes_;
using ClassLibrary_Models.Entities_.Concretes_;
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
    /// Interaction logic for Rides_Page.xaml
    /// </summary>
    public partial class Rides_Page : Page
    {
        private Create_Ride2_Window window_ = null;

        Ride_Repos _Repos { get; set; }
        public ObservableCollection<Ride> Rides { get; set; }
        public Rides_Page()
        {
            InitializeComponent();
            _Repos = new Ride_Repos();
            Rides = new ObservableCollection<Ride>(_Repos.GetAll());
            DataContext = this;
        }

        private void create_ride2_open(object sender, RoutedEventArgs e)
        {
            if (window_ == null)
            {
                window_ = new Create_Ride2_Window();
            }
            window_.Closed += New_Create2_Window_Closed;
            window_.ShowDialog();
        }

        private void refresh_click(object sender, RoutedEventArgs e)
        {
            _Repos = new Ride_Repos();
            Rides.Clear();
            var rides = _Repos.GetAll();
            foreach (var ride in rides)
            {
                Rides.Add(ride);
            }
            DataContext = this;
        }


        private void New_Create2_Window_Closed(object sender, EventArgs e)
        {
            window_ = null;
        }


    }
}
