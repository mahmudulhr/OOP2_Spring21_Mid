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
            /*/

            int  phy=62, chemistry=83, biology=93, mathematic=89, computer=71;
            double sum = phy + chemistry + biology + mathematic + computer;

            sum /= 5.0;

            Console.WriteLine( " Percentage " + sum + "%");
            if (sum>90)
            {
                Console.WriteLine("A+");
            }
            else if (sum >= 85 && sum < 89)
            {
                Console.WriteLine("A");
            }
            else if (sum >= 80 && sum < 85)
            {
                Console.WriteLine("B+");
            }
            else if (sum >= 75 && sum < 80)
            {
                Console.WriteLine("B");
            }
            else if (sum >= 50 && sum < 75)
            {
                Console.WriteLine("C");
            }
            else 
            {
                Console.WriteLine("FAIL");
            }


        }
       
    }
}
