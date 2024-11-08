using ClassLibrary_Data_Access.Repositories_.Concretes_;
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
    /// Interaction logic for New_Class_Window.xaml
    /// </summary>
    public partial class New_Class_Window : Window
    {
      
        public New_Class_Window()
        {
            InitializeComponent();
        }
        Class_Repos Class_Repos { get; set; }
        private void name_focus(object sender, RoutedEventArgs e)
        {
            if (name_textbox.Text == "Class Name") name_textbox.Text = "";

        }

        private void name_lost_focus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(name_textbox.Text)) name_textbox.Text = "Class Name";
        }
        private void create_click(object sender, RoutedEventArgs e)
        {
            Class_Repos= new Class_Repos();
            Class_Repos.Add(new() { Name = name_textbox.Text});
            
            Class_Repos.SaveChanges();
          
            this.Close();
        }
      
    }
}
