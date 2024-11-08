using ClassLibrary_Data_Access.Repositories_.Concretes_;
using ClassLibrary_Models.Entities_.Concretes_;
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
    /// Interaction logic for New_Student_Window.xaml
    /// </summary>
    public partial class New_Student_Window : Window
    {
       static  Parent_Repos p_Repos = new Parent_Repos();
        int[] ids= new int[p_Repos.GetAll().Count];
       static Class_Repos c_Repos = new Class_Repos();
        int[] ids2 = new int[c_Repos.GetAll().Count];

        public New_Student_Window()
        {
           
            InitializeComponent();
           
            string[] parents_name = new string[p_Repos.GetAll().Count()];
            for (int i = 0; i < p_Repos.GetAll().ToList().Count; i++)
            {
                parents_name[i] =  p_Repos.GetAll().ToList()[i].LastName + "  " + p_Repos.GetAll().ToList()[i].FirstName;
                ids[i] = p_Repos.GetAll().ToList()[i].Id;
            }
            parent_combo.ItemsSource = parents_name;


            string[] class_name = new string[c_Repos.GetAll().Count()];
            for (int i = 0; i < c_Repos.GetAll().ToList().Count; i++)
            {
                class_name[i] =  c_Repos.GetAll().ToList()[i].Name ;
                ids2[i] = c_Repos.GetAll().ToList()[i].Id;
            }
            class_combo.ItemsSource = class_name;

        }

        private void _focus(object sender, RoutedEventArgs e)
        {
            if (firstname_textbox.Text == "Firstname" && firstname_textbox.IsFocused) firstname_textbox.Text = "";
            if (lastname_textbox.Text == "Lastname" && lastname_textbox.IsFocused) lastname_textbox.Text = "";          
            if (address1_textbox.Text == "Home Address" && address1_textbox.IsFocused) address1_textbox.Text = "";
            if (address2_textbox.Text == "Other Address" && address2_textbox.IsFocused) address2_textbox.Text = "";

        }

        private void _lost_focus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(firstname_textbox.Text)) firstname_textbox.Text = "Firstname";
            if (string.IsNullOrEmpty(lastname_textbox.Text)) lastname_textbox.Text = "Lastname";
            if (string.IsNullOrEmpty(address1_textbox.Text)) address1_textbox.Text = "Home Address";
            if (string.IsNullOrEmpty(address2_textbox.Text)) address2_textbox.Text = "Other Address";

        }

        private void create_click(object sender, RoutedEventArgs e)
        {
            Student_Repos student_Repos = new Student_Repos();
            Parent_Repos parent_Repos = new Parent_Repos();
            Class_Repos class_Repos = new Class_Repos();
            Car_Repos car_Repos = new Car_Repos();
            Student student = new Student();
           
            student.FirstName = firstname_textbox.Text;
            student.LastName = lastname_textbox.Text;
            student.Home_Address = address1_textbox.Text;
            student.Other_Address= address2_textbox.Text;
            student.Class_Id= ids2[class_combo.SelectedIndex];
            student.ParentId = ids[parent_combo.SelectedIndex];
            student.CarId = 3;
           
          //  student.Parent = parent_Repos.GetById(parent_combo.SelectedIndex + 1);
          //  student.Class_ = class_Repos.GetById(class_combo.SelectedIndex + 1);


            //student_Repos.Add(new()
            //{
            //  //  FirstName = firstname_textbox.Text,
            //  //  LastName = lastname_textbox.Text,
            //  //  Home_Address = address1_textbox.Text,
            //  //  Other_Address = address2_textbox.Text,
            //  //  Class_Id = class_combo.SelectedIndex + 1,
            //  //  ParentId = parent_combo.SelectedIndex + 1,
            //  // // Parent = parent_Repos.GetById(parent_combo.SelectedIndex + 1),
            //  ////  Class_ = class_Repos.GetById(class_combo.SelectedIndex + 1),
            //  //  CarId = 1,
            //  //  //Car = car_Repos.GetById(1)
            //});

            student_Repos.Add(student);
            student_Repos.SaveChanges();

            Class_ guncel = class_Repos.GetById(student.Class_Id);
            guncel.Student_Count++;
            class_Repos.Update(guncel);
            class_Repos.SaveChanges();


            this.Close();
        }



    }
}
