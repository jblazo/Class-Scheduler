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
        private string[] prerequisites;

        public Course(string courseCode, string courseDescription, string[] preReqs)
        {
            this.courseCode = courseCode;
            this.courseDescription = courseDescription;
            this.prerequisites = preReqs;
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

        public string[] PreRequisites
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
    }
}
