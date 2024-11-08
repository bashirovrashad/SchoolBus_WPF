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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace schoolbus.User_Controls_for_Schoolbus
{
    /// <summary>
    /// Interaction logic for UserControl_Student.xaml
    /// </summary>
    public partial class UserControl_Student : UserControl
    {
        bool yoxla = false;
        public UserControl_Student()
        {
            InitializeComponent();
            Class_Repos _Repos = new Class_Repos();
            Student_Repos _Student = new Student_Repos();
            string[] clas_name = new string[_Repos.GetAll().Count()];
            for (int i = 0; i < _Repos.GetAll().Count(); i++)
            {
                clas_name[i] = _Repos.GetAll().ToList()[i].Name;
                class_combo.Items.Add(clas_name[i]);    
            }
           
          
            class_combo.IsEnabled   = false;
        }

        private void noqte_click(object sender, RoutedEventArgs e)
        {
            if (yoxla)
            {

                Update_button.Visibility = Visibility.Collapsed;
                Remove_button.Visibility = Visibility.Collapsed;    
                ok_button.Visibility = Visibility.Collapsed;
                yoxla = false;
            }
            else
            {

                Update_button.Visibility = Visibility.Visible;
                Remove_button.Visibility = Visibility.Visible;              
                yoxla = true;
            }
        }

        private void update_click(object sender, RoutedEventArgs e)
        {
            ok_button.Visibility = Visibility.Visible;
        }
    }
}
