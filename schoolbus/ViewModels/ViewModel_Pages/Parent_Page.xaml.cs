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
    /// Interaction logic for Parent_Page.xaml
    /// </summary>
    public partial class Parent_Page : Page
    {
        New_Parent_Window New_Parent_Window = null;
        Parent_Repos _Repos { get; set; }
        public ObservableCollection<Parent> Parents { get; set; }
        public Parent_Page()
        {
            InitializeComponent();
            _Repos = new Parent_Repos();
            Parents = new ObservableCollection<Parent>(_Repos.GetAll());
            DataContext = this;
        }

        private void refresh_click(object sender, RoutedEventArgs e)
        {
            _Repos = new Parent_Repos();
            Parents.Clear();
            var parents = _Repos.GetAll();
            foreach (var parent in parents)
            {
                Parents.Add(parent);
            }
            DataContext = this;
        }



        private void new_parent_window_open(object sender, RoutedEventArgs e)
        {
            if (New_Parent_Window == null)
            {
                New_Parent_Window = new New_Parent_Window();
            }
            New_Parent_Window.Closed += New_Parent_Window_Closed;
            New_Parent_Window.ShowDialog();
        }
        private void New_Parent_Window_Closed(object sender, EventArgs e)
        {
            New_Parent_Window = null;
        }
    }
}
