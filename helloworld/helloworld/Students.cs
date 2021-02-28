using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloworld
{
    class Students
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string id;

        public string Id
        {

            get { return id; }
            set { id = value; }
        }
        private float cgpa;
        public float CGPA
        {

            get { return cgpa; }
            set { cgpa = value; }
        }

        Department department;
        public Department department
        {

            get { return department; }
            set { depatment = value; }
        }

        public Student()
        {
            public Student(string name, string id,float cgpa)
            {
                this.name = name;
                this.id = id;
                this.cgpa = cgpa;
            }
        }
        public void ShowInfo()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Id: " + id);
            Console.WriteLine("CGPA: " + cgpa);
        }
    }
}
}
