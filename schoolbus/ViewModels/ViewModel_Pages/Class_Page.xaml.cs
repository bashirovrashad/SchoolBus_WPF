using ClassLibrary_Data_Access.Repositories_.Concretes_;
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
    /// Interaction logic for Class_Page.xaml
    /// </summary>
    public partial class Class_Page : Page
    {
        private New_Class_Window _window = null;
        public ObservableCollection<Class_> Class_s { get; set; }
        Class_Repos Class_Repos { get; set; }
        public Class_Page()
        {
            InitializeComponent();
          

            Class_Repos = new Class_Repos();
            Class_s = new ObservableCollection<Class_>(Class_Repos.GetAll()) { };
            DataContext = this;
        }
      
        private void Refresh_click(object sender, RoutedEventArgs e)
        {
            Class_Repos = new Class_Repos();
            Class_s.Clear();
            var classes = Class_Repos.GetAll();
            foreach (var cls in classes)
            {
                Class_s.Add(cls); 
            }
            DataContext = this;
        }
        private void new_class_window_open(object sender, RoutedEventArgs e)
        {
            if (_window == null)
            {
                _window = new New_Class_Window();
            }
            _window.Closed += New_Class_Window_Closed;
            _window.ShowDialog();
            
        }

        private void New_Class_Window_Closed(object sender, EventArgs e)
        {
            _window = null;
        }
    }
}
