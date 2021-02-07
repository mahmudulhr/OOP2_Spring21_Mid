using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloworld
{
    class Student
    {
        private string name;
        private string id;
        private string department;
        private float cgpa;

        public Student() { }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string ID
        {
            get { return id; }
            set { id = value; }
        }
        public string Department
        {
            get { return department; }
            set { department = value; }
        }
        public float CGPA
        {
            get { return cgpa; }
            set { cgpa = value; }
        }

        public void showinfo()
        {
            Console.WriteLine("Name:" + Name);
            Console.WriteLine("ID:" + ID);
            Console.WriteLine("Department:" + Department);
            Console.WriteLine("CGPA:" + CGPA);

        }
    }


}
