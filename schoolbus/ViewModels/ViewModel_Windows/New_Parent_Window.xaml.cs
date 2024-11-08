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
    /// Interaction logic for New_Parent_Window.xaml
    /// </summary>
    public partial class New_Parent_Window : Window
    {
        public New_Parent_Window()
        {
            InitializeComponent();
        }

        private void _focus(object sender, RoutedEventArgs e)
        {
            if (firstname_textbox.Text == "Firstname" && firstname_textbox.IsFocused) firstname_textbox.Text = "";
            if (lastname_textbox.Text == "Lastname" && lastname_textbox.IsFocused) lastname_textbox.Text = "";
            if (phone_textbox.Text == "Phone" && phone_textbox.IsFocused) phone_textbox.Text = "";
            if (username_textbox.Text == "Username" && username_textbox.IsFocused) username_textbox.Text = "";
            if (password_textbox.Text == "Password" && password_textbox.IsFocused) password_textbox.Text = "";
          
        }

        private void _lost_focus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(firstname_textbox.Text)) firstname_textbox.Text = "Firstname";
            if (string.IsNullOrEmpty(lastname_textbox.Text)) lastname_textbox.Text = "Lastname";
            if (string.IsNullOrEmpty(phone_textbox.Text)) phone_textbox.Text = "Phone";
            if (string.IsNullOrEmpty(username_textbox.Text)) username_textbox.Text = "Username";
            if (string.IsNullOrEmpty(password_textbox.Text)) password_textbox.Text = "Password";
           
        }

        private void create_click(object sender, RoutedEventArgs e)
        {
            Parent_Repos _Repos = new Parent_Repos();
            _Repos.Add(new() { FirstName = firstname_textbox.Text, LastName = lastname_textbox.Text, Phone =phone_textbox.Text, UserName= username_textbox.Text,Password=password_textbox.Text });
            _Repos.SaveChanges();
            this.Close();
        }



    }
}
