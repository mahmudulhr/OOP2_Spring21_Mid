using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloworld
{
    class Course
    {
        
        private string courseName;
        private string courseCode;
        private int courseCredit;

        public Course() { }

        public string CourseName
        {
            get { return courseName; }
            set { courseName = value; }
        }
        public string CourseCode
        {
            get { return courseCode; }
            set { courseCode = value; }
        }
        public int CourseCredit
        {
            get { return courseCredit; }
            set { courseCredit = value; }
        }

        public void showinfo()
        {
            Console.WriteLine("CourseName:" + CourseName);
            Console.WriteLine("CourseCode:" + CourseCode);
            Console.WriteLine("CourseCredit:" + CourseCredit);

        }
    }
}
