using schoolbus.Views.ViewWindows;
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
    /// Interaction logic for UserControl_Class.xaml
    /// </summary>
    public partial class UserControl_Class : UserControl
    {
        bool yoxla = false;
        public UserControl_Class()
        {
            InitializeComponent();
         
        }

        private void noqte_click(object sender, RoutedEventArgs e)
        {
            if (yoxla)
            {
               
                Update_button.Visibility = Visibility.Collapsed;
                Remove_button.Visibility = Visibility.Collapsed;
                Ok_Button.Visibility = Visibility.Collapsed;

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
            Ok_Button.Visibility = Visibility.Visible;
        }
    }
}
