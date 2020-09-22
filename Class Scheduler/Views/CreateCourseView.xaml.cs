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

namespace Class_Scheduler.Views
{
    /// <summary>
    /// Interaction logic for CreateCourseView.xaml
    /// </summary>
    public partial class CreateCourseView : UserControl
    {
        public CreateCourseView()
        {
            InitializeComponent();
        }

        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {
            string courseName = CourseNameTextBox.Text;
            string courseDescription = CourseDescriptionTextBox.Text;
            string courseCode = CourseCodeTextBox.Text;
            string tempPreReqs = PreRequisitesTextBox.Text;
            string[] preReqsStrings = tempPreReqs.Split(',');
            Course[] preReqs = new Course[preReqsStrings.Length];
            List<Course> courseList = FileInputOutput.DeserializeCourses();
            for (int i = 0; i < preReqsStrings.Length; i++)
            {
                foreach (Course ele in courseList)
                {
                    if (ele.CourseCode == preReqsStrings[i])
                    {
                        preReqs[i] = ele;
                    }
                }
            }
            

            Course course = new Course(courseCode, courseDescription, preReqs , courseName);

            FileInputOutput.SerializeCourses(course);
        }
    }
}
