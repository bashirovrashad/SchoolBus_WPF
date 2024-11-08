using ClassLibrary_Data_Access.Repositories_.Concretes_;
using ClassLibrary_Data_Access.Repositories_.Interfaces_;
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
    /// Interaction logic for Create_Ride_Page.xaml
    /// </summary>
    public partial class Create_Ride_Page : Page
    {
        private String name { get; set; }
        static  Ride_Repos ride_Repos = new Ride_Repos();
      //  Driver_Repos driver_repos = new Driver_Repos();
        int[] ids = new int[ride_Repos.GetAll().Count()];


        public ObservableCollection<Student> Olan_Students { get; set; }
        public ObservableCollection<Student> Olmayan_Students { get; set; }


        public Create_Ride_Page()
        {
            InitializeComponent();
           


            string[] rides_name = new string[ride_Repos.GetAll().Count()];
            for (int i = 0; i < ride_Repos.GetAll().ToList().Count; i++)
            {
                rides_name[i] = ride_Repos.GetAll().ToList()[i].Name;
                ids[i] = ride_Repos.GetAll().ToList()[i].Id;
            }
            ride_combo.ItemsSource = rides_name;
            ride_combo.SelectionChanged += Driver_combo_SelectionChanged;



            Student_Repos students_ = new Student_Repos();

            Olmayan_Students = new ObservableCollection<Student>(students_.GetAll().Where(s => s.CarId == 3));

            DataContext = this;

        }
       

        private void find_click(object sender, RoutedEventArgs e)
        {
            Driver_Repos driver_Repos = new Driver_Repos();
            Car_Repos car_Repos = new Car_Repos();
         name_label.Content= car_Repos.GetById(driver_Repos.GetAll().Where(e => e.RideId == ids[ride_combo.SelectedIndex]).ToList()[0].CarId).Name;
         number_label.Content= car_Repos.GetById(driver_Repos.GetAll().Where(e => e.RideId == ids[ride_combo.SelectedIndex]).ToList()[0].CarId).Number;
         seat_label.Content= car_Repos.GetById(driver_Repos.GetAll().Where(e => e.RideId == ids[ride_combo.SelectedIndex]).ToList()[0].CarId).Seat_Count;
         student_label.Content= car_Repos.GetById(driver_Repos.GetAll().Where(e => e.RideId == ids[ride_combo.SelectedIndex]).ToList()[0].CarId).Students.Count.ToString();





            Student_Repos students_ = new Student_Repos();
            int car_id = driver_Repos.GetAll().FirstOrDefault(d => d.Id == ids[driver_combo.SelectedIndex]).CarId;

            Olan_Students = new ObservableCollection<Student>(students_.GetAll().Where(s => s.CarId == car_id));
           // MessageBox.Show(Olan_Students.Count.ToString());


           // Olmayan_Students = new ObservableCollection<Student>(students_.GetAll().Where(s => s.CarId == 3));
          //  MessageBox.Show(Olmayan_Students.Count.ToString());






        }




        private void Driver_combo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ride_combo.SelectedIndex != -1)
            {
                Ride_Repos ride_Repos = new Ride_Repos();
                Driver_Repos driver_repos = new Driver_Repos();

                int[] ids = new int[ride_Repos.GetAll().Count()];

              
                for (int i = 0; i < ride_Repos.GetAll().ToList().Count; i++)
                {
                   
                    ids[i] = ride_Repos.GetAll().ToList()[i].Id;
                }
             
                int selectedRideId = ids[ride_combo.SelectedIndex];

              
                var drivers = driver_repos.GetAll().Where(d => d.RideId == selectedRideId).ToList();
                string[] drivers_name = drivers.Select(d => d.LastName + " " + d.FirstName).ToArray();
                int[] driver_ids = drivers.Select(d => d.Id).ToArray();

              
                driver_combo.ItemsSource = drivers_name;
                driver_combo.IsEnabled = true;

            }
            else
            {            
                driver_combo.IsEnabled = false;
            }
        }








    }
}
