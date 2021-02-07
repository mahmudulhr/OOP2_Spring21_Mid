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
            /*
            int n = 100;
            Console.WriteLine("Even NUmber");
            for(int i=1; i<=n; i++)
            {
                if(i % 2 == 0)
                {
                    Console.WriteLine(i+" ");
                }
            }
            
          /*/
            int i, n =100 , sum1 = 0, sum2 = 0;
            Console.WriteLine("enter value");
            for (i=1; i<= n; i++)
            { if (i % 2 == 1)
                    sum1 = sum1 + 1;
                else
                    sum2 = sum2 + 1;
                Console.WriteLine("Sum of odd ={0}", sum1);
                Console.WriteLine("Sum of even ={0}", sum2);

            }
            
        }
       
    }
}
