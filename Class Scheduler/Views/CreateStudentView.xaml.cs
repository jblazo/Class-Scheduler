using System;
using System.IO;
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

namespace Class_Scheduler.Views
{
    /// <summary>
    /// Interaction logic for CreateStudentView.xaml
    /// </summary>
    public partial class CreateStudentView : UserControl
    {
        public CreateStudentView()
        {
            InitializeComponent();
        }
        private void CreateStudent(object sender, RoutedEventArgs e)
        {
            try
            {
                string studentName = NameTextBox.Text;
                DateTime birthdate = DateTime.Parse(BirthdateTextBox.Text);
                string tempgraddate = GradDateBox.Text;
                GraduationDate graddate;
                if (tempgraddate == "December 2020")
                {
                    graddate = new GraduationDate(12, 2020);
                }
                else
                {
                    graddate = new GraduationDate(05, 2021);
                }
                string tempMajor = MajorBox.Text;
                Major studentMajor = null;
                if (tempMajor == "Computer Science")
                {
                    string[] temp2 = { "test", "test" };
                    studentMajor = new Major(temp2, tempMajor);
                }
                Student newStudent = new Student(studentName, birthdate, studentMajor, graddate);
                FileInputOutput.SerializeStudent(newStudent);
                FileInputOutput.DeserializeStudents();
            }
            catch
            {
                MessageBox.Show("Something went wrong. Error: ");
                
            }
            
            

        }
    }
}
