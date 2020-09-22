using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Class_Scheduler
{
    [Serializable]
    class Course
    {
        private string courseDescription;
        private string courseCode;
        private Course[] prerequisites;
        private string courseName;

        public Course(string courseCode, string courseDescription, Course[] preReqs, string courseName)
        {
            this.courseCode = courseCode;
            this.courseDescription = courseDescription;
            this.prerequisites = preReqs;
            this.courseName = courseName;
        }

        public Course()
        {
            this.courseCode = null;
            this.courseDescription = null;
            this.prerequisites = null;
            this.courseName = null;
        }

        public string CourseCode
        {
            get
            {
                return this.courseCode;
            }
            set
            {
                this.courseCode = value;
            }
        }

        public string CourseDescription
        {
            get
            {
                return this.courseDescription;
            }
            set
            {
                this.courseDescription = value;
            }
        }

        public Course[] PreRequisites
        {
            get
            {
                return this.prerequisites;
            }
            set
            {
                this.prerequisites = value;
            }
        }
        
        public string CourseName
        {
            get
            {
                return this.courseName;
            }
            set
            {
                this.courseName = value;
            }
        }

        public string PrintPreReqs
        {
            get
            {
                string returnValue = "";
                if (this.prerequisites == null)
                {
                    return returnValue;

                }

                else
                {
                    foreach (Course ele in this.prerequisites)
                    {
                        returnValue += (ele.CourseCode + " ");
                    }

                    return returnValue;
                }
            }
            
        }

        public override string ToString()
        {
            return (this.courseName + "\n" + this.courseCode + "\n" + this.courseDescription + "\n" + PrintPreReqs);
        }
    }
}
