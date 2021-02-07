using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloworld
{
    class Program
    {
        static void Main (string[] args)
        {

            
                Student a = new Student();
                a.Name = "Hasan";
                a.ID = "1-11111-11";
                a.Department = "Computer Science";
                a.CGPA = "3.5";
                a.showinfo();

                Console.WriteLine();


        }
    }
}

