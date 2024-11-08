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

namespace schoolbus.Views.ViewPages
{
    /// <summary>
    /// Interaction logic for Main_Page_.xaml
    /// </summary>
    public partial class Main_Page_ : Page
    {
        
        public Main_Page_()
        {
            InitializeComponent();         
        }
        public Main_Page_(bool a)
        {
            InitializeComponent();
            Add_Calendar();
           
        }
        private void Add_Calendar()
        {
         
            mainGrid.Children.Remove(welcome);        
            Calendar calendar = new Calendar();
            calendar.Width = 600;
            calendar.Height = 600;
            mainGrid.Children.Add(calendar);
        }
    }
}
