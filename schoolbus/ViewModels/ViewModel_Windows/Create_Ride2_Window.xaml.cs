using ClassLibrary_Data_Access.Repositories_.Concretes_;
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

namespace schoolbus.Views.ViewPages
{
    /// <summary>
    /// Interaction logic for Create_Ride2_Window.xaml
    /// </summary>
    public partial class Create_Ride2_Window : Window
    {
        public Create_Ride2_Window()
        {
            InitializeComponent();
        }

       
        private void _focus(object sender, RoutedEventArgs e)
        {
            if (name_textbox.Text == "Name" && name_textbox.IsFocused) name_textbox.Text = "";
            if (address1.Text == "Starting Address" && address1.IsFocused) address1.Text = "";
            if (address2.Text == "Ending Address" && address2.IsFocused) address2.Text = "";
          

        }

        private void _lost_focus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(name_textbox.Text)) name_textbox.Text = "Name";
            if (string.IsNullOrEmpty(address1.Text)) address1.Text = "Starting Address";
            if (string.IsNullOrEmpty(address2.Text)) address2.Text = "Ending Address";
          

        }
        private void create_click(object sender, RoutedEventArgs e)
        {
            Ride_Repos Ride_Repos = new Ride_Repos();
            Ride_Repos.Add(new() { Name = name_textbox.Text, Starting_Address = address1.Text, Ending_Address =address2.Text });
            Ride_Repos.SaveChanges();
            this.Close();
        }

    }
}
