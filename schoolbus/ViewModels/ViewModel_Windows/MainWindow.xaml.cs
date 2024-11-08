using ClassLibrary_Data_Access.Repositories_.Concretes_;
using ClassLibrary_Models.Entities_.Concretes_;
using schoolbus.Views.ViewPages;
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

namespace schoolbus
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {   
        private Create_Ride_Page Create_Ride_Page = new Create_Ride_Page();
        private Rides_Page Rides_ = new Rides_Page();
        private Class_Page Class_Page = new Class_Page();
        private Student_Page Student_ = new Student_Page();
        private Parent_Page Parent_ = new Parent_Page();
        private Driver_Page Driver_ = new Driver_Page();   
        private Car_Page Car_ = new Car_Page(); 
        private Main_Page_ main_page = new Main_Page_(true);
        public MainWindow()
        {
            InitializeComponent();        
            mainframe.Navigate(new Main_Page_());

            //Car_Repos car_Repos = new Car_Repos();         
            //Ride_Repos ride_Repos = new Ride_Repos();
            //Driver_Repos _Repos = new Driver_Repos();
            
        }

        private void create_ride_page_open(object sender, RoutedEventArgs e)
        {
            mainframe.Navigate(Create_Ride_Page);
           
            create_ride_button.Background = Brushes.DarkOrange;
            rides_button.Background = Brushes.White;
            class_button.Background = Brushes.White;
            student_button.Background = Brushes.White;
            parent_button.Background = Brushes.White;
            driver_button.Background = Brushes.White;
            car_button.Background = Brushes.White;
            holiday_button.Background = Brushes.White;

        }


        private void rides_page_open(object sender, RoutedEventArgs e)
        {
            mainframe.Navigate(Rides_);

            rides_button.Background = Brushes.DarkOrange;
            create_ride_button.Background = Brushes.White;
            class_button.Background = Brushes.White;
            student_button.Background = Brushes.White;
            parent_button.Background = Brushes.White;
            driver_button.Background = Brushes.White;
            car_button.Background = Brushes.White;
            holiday_button.Background = Brushes.White;

        }



        private void class_page_open(object sender, RoutedEventArgs e)
        {          
            mainframe.Navigate(Class_Page);

            class_button.Background = Brushes.DarkOrange;
            rides_button.Background = Brushes.White;
            create_ride_button.Background = Brushes.White;
            student_button.Background = Brushes.White;
            parent_button.Background = Brushes.White;
            driver_button.Background = Brushes.White;
            car_button.Background = Brushes.White;
            holiday_button.Background = Brushes.White;

        }
        private void student_page_open(object sender, RoutedEventArgs e)
        {          
            mainframe.Navigate(Student_);

            student_button.Background = Brushes.DarkOrange;
            rides_button.Background = Brushes.White;
            class_button.Background = Brushes.White;
            create_ride_button.Background = Brushes.White;
            parent_button.Background = Brushes.White;
            driver_button.Background = Brushes.White;
            car_button.Background = Brushes.White;
            holiday_button.Background = Brushes.White;
        }

        

        private void parent_page_open(object sender, RoutedEventArgs e)
        {
            mainframe.Navigate(Parent_);

            parent_button.Background = Brushes.DarkOrange;
            rides_button.Background = Brushes.White;
            class_button.Background = Brushes.White;
            student_button.Background = Brushes.White;
            create_ride_button.Background = Brushes.White;
            driver_button.Background = Brushes.White;
            car_button.Background = Brushes.White;
            holiday_button.Background = Brushes.White;
        }
        

        private void driver_page_open(object sender, RoutedEventArgs e)
        {
            mainframe.Navigate(Driver_);

            driver_button.Background = Brushes.DarkOrange;
            rides_button.Background = Brushes.White;
            class_button.Background = Brushes.White;
            student_button.Background = Brushes.White;
            create_ride_button.Background = Brushes.White;
            parent_button.Background = Brushes.White;
            car_button.Background = Brushes.White;
            holiday_button.Background = Brushes.White;
        }

        private void car_page_open(object sender, RoutedEventArgs e)
        {
            mainframe.Navigate(Car_);

            car_button.Background = Brushes.DarkOrange;
            rides_button.Background = Brushes.White;
            class_button.Background = Brushes.White;
            student_button.Background = Brushes.White;
            create_ride_button.Background = Brushes.White;
            driver_button.Background = Brushes.White;
            parent_button.Background = Brushes.White;
            holiday_button.Background = Brushes.White;
        }
        
      
        private void holiday_click(object sender, RoutedEventArgs e)
        {
            mainframe.Navigate(main_page);
         
            holiday_button.Background = Brushes.DarkOrange;
            rides_button.Background = Brushes.White;
            class_button.Background = Brushes.White;
            student_button.Background = Brushes.White;
            create_ride_button.Background = Brushes.White;
            driver_button.Background = Brushes.White;
            parent_button.Background = Brushes.White;
            car_button.Background = Brushes.White;
        }

    }
}
