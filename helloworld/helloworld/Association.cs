using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloworld
{
    class Association
    {
        static void Main( String[] args)
        {
            Department d1 = new Department(" Computer Science Eng", "CSE");
            Department d1 = new Department(" DIGITAL LOGIC", "EE");
            Student s1 = new student(" Mahmudul", "304",2.5f );
            s1.Department = d2;
            s1.showinfo();

        }
    }
}
