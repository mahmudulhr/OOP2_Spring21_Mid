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
            int n = 100;
            Console.WriteLine("Even NUmber");
            for(int i=1; i<=n; i++)
            {
                if(i % 2 == 0)
                {
                    Console.WriteLine(i+" ");
                }
            }

            int n= 99;
            Console.WriteLine("odd");
            for(int i=1; i<=n;i++)
            {
                if (i%2 !=0)
                {
                    Console.WriteLine(i + "");
                }
            }
          
        }
       
    }
}
