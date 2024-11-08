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

namespace schoolbus.Views.ViewWindows
{
    /// <summary>
    /// Interaction logic for New_Car_Window.xaml
    /// </summary>
    public partial class New_Car_Window : Window
    {
        public New_Car_Window()
        {
            InitializeComponent();
        }
        Car_Repos Car_Repos = new Car_Repos();
        private void _focus(object sender, RoutedEventArgs e)
        {
            if (name_textbox.Text == "Name" && name_textbox.IsFocused ) name_textbox.Text = "";
            if (number_textbox.Text == "Number" && number_textbox.IsFocused) number_textbox.Text = "";
            if (count_textbox.Text == "Seat Count" && count_textbox.IsFocused) count_textbox.Text = "";

        }

        private void _lost_focus(object sender, RoutedEventArgs e)
        {         
             if (string.IsNullOrEmpty(name_textbox.Text)) name_textbox.Text = "Name";
             if (string.IsNullOrEmpty(number_textbox.Text)) number_textbox.Text = "Number";
             if (string.IsNullOrEmpty(count_textbox.Text)) count_textbox.Text = "Seat Count";

        }
        private void create_click(object sender, RoutedEventArgs e)
        {
            Car_Repos.Add(new() { Name = name_textbox.Text,Number=number_textbox.Text,Seat_Count= Convert.ToInt32( count_textbox.Text) });
            Car_Repos.SaveChanges();
            this.Close();
            
        }

    }
}
