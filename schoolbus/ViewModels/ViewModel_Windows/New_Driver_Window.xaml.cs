using ClassLibrary_Data_Access.Repositories_.Concretes_;
using ClassLibrary_Data_Access.Repositories_.Interfaces_;
using ClassLibrary_Models.Entities_.Concretes_;
using schoolbus.Views.ViewPages;
using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace schoolbus.Views.ViewWindows
{
    /// <summary>
    /// Interaction logic for New_Driver_Window.xaml
    /// </summary>
    public partial class New_Driver_Window : Window
    {


       static  Car_Repos car_Repos = new Car_Repos();
        
       static Ride_Repos ride_Repos = new Ride_Repos();

        int[] ids = new int[car_Repos.GetAll().Where(c => c.Driver is null && c.Id!=3).Count()];
        int[] ids2 = new int[ride_Repos.GetAll().Count()];

        public New_Driver_Window()
        {
            InitializeComponent();
            string[] cars_name = new string[car_Repos.GetAll().Where(c=>c.Driver is  null && c.Id != 3).Count()];
            var cars = car_Repos.GetAll().Where(c => c.Driver is  null && c.Id != 3);
            for (int i = 0; i < cars.Count(); i++)
            {
                cars_name[i] = cars.ToList()[i].Name;
                ids[i] = cars.ToList()[i].Id;
            }
            car_combo.ItemsSource = cars_name;


          
            string[] rides_name = new string[ride_Repos.GetAll().Count()];
            for (int i = 0; i < ride_Repos.GetAll().ToList().Count; i++)
            {
                rides_name[i] = ride_Repos.GetAll().ToList()[i].Name;
                ids2[i] = ride_Repos.GetAll().ToList()[i].Id;
            }
            ride_combo.ItemsSource = rides_name;
        }

        private void _focus(object sender, RoutedEventArgs e)
        {
            if (firstname_textbox.Text == "Firstname" && firstname_textbox.IsFocused ) firstname_textbox.Text = "";
            if (lastname_textbox.Text == "Lastname" && lastname_textbox.IsFocused) lastname_textbox.Text = "";
            if (phone_textbox.Text == "Phone" && phone_textbox.IsFocused) phone_textbox.Text = "";
            if (username_textbox.Text == "Username" && username_textbox.IsFocused) username_textbox.Text = "";
            if (password_textbox.Text == "Password" && password_textbox.IsFocused) password_textbox.Text = "";
            if (address_textbox.Text == "Home Address" && address_textbox.IsFocused) address_textbox.Text = "";
            if (Licence_textbox.Text == "Licence" && Licence_textbox.IsFocused) Licence_textbox.Text = "";
          
        }

        private void _lost_focus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(firstname_textbox.Text)) firstname_textbox.Text = "Firstname";
            if (string.IsNullOrEmpty(lastname_textbox.Text)) lastname_textbox.Text = "Lastname";
            if (string.IsNullOrEmpty(phone_textbox.Text)) phone_textbox.Text = "Phone";
            if (string.IsNullOrEmpty(username_textbox.Text)) username_textbox.Text = "Username";
            if (string.IsNullOrEmpty(password_textbox.Text)) password_textbox.Text = "Password";
            if (string.IsNullOrEmpty(address_textbox.Text)) address_textbox.Text = "Home Address";
            if (string.IsNullOrEmpty(Licence_textbox.Text)) Licence_textbox.Text = "Licence";

        }


        private void create_click(object sender, RoutedEventArgs e)
        {
            Car_Repos car_Repos = new Car_Repos();
            Ride_Repos ride_Repos = new Ride_Repos();
            Driver_Repos _Repos = new Driver_Repos();
            string a = car_combo.SelectedItem.ToString();
            
            Driver driver = new Driver();
            driver.LastName = lastname_textbox.Text;
            driver.Phone = phone_textbox.Text;
            driver.FirstName = firstname_textbox.Text;
            driver.UserName = username_textbox.Text;
            driver.Password = password_textbox.Text;
            driver.Home_Address = address_textbox.Text;
            driver.Licence = Licence_textbox.Text;
            driver.CarId = ids[car_combo.SelectedIndex];
            driver.RideId = ids2[ride_combo.SelectedIndex]; 
         
          
            _Repos.Add(driver);

            _Repos.SaveChanges();
           
            this.Close();
        }


    }
}
