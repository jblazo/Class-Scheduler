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
using Class_Scheduler.ViewModels;

namespace Class_Scheduler
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            this.Title = "Class Scheduler";
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        public void HomeViewModel()
        {
            DataContext = new HomeViewModel();
            
        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new HomeViewModel();
        }

        private void NewStudent_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new CreateStudentViewModel();
        }

        private void ViewCoursesButton_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new CourseViewModel();
        }
    }
}
