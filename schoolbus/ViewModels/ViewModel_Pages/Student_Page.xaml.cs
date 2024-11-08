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
    /// Interaction logic for Student_Page.xaml
    /// </summary>
    public partial class Student_Page : Page
    {
        New_Student_Window _student_window = null;
        public ObservableCollection<Student> Students { get; set; }
        Student_Repos _Repos {  get; set; }  
        public Student_Page()
        {
            InitializeComponent();
            _Repos = new Student_Repos();
            Students = new ObservableCollection<Student>(_Repos.GetAll());
            DataContext = this;
        }

        private void refresh_click(object sender, RoutedEventArgs e)
        {
            _Repos = new Student_Repos();
            Students.Clear();
            var students = _Repos.GetAll();
            foreach (var student in students)
            {
                Students.Add(student);
            }
            DataContext = this;
        }


        private void new_class_window_open(object sender, RoutedEventArgs e)
        {
            if (_student_window == null)
            {
                _student_window = new New_Student_Window();
            }
            _student_window.Closed += New_Student_Window_Closed;
            _student_window.ShowDialog();
        }
        private void New_Student_Window_Closed(object sender, EventArgs e)
        {
            _student_window = null;
        }
    }
}
