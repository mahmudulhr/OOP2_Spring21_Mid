using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world");


            int num1 = 5;
            int num2 = 3;
            Console.WriteLine("Addition is :" + (num1 + num2));
            Console.WriteLine("Substraction is :{0}", (num1 - num2));
            Console.WriteLine("Multiplication is :{0}", (num1 * num2));
            Console.WriteLine("Division is :" + (num1 / num2));
        }
    }
}
