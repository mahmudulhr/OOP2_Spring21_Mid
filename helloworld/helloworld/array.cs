using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloworld
{
    class array
    {
        static void Main(string[] args)
        {
            int arr1 = new int[50];
            int arr2 = new int[50];
            int i, n;
            n = Convert.ToInt32(Console.ReadLine());
                for(int i =0; i<arr1.length;i++)
                {
                Console.WriteLine("element -{0} : ", i) ;
                arr1[i] = Convert.ToInt32(Console.Redline());
                }

            for (i = 0; i < n; i++)
            {
                arr2[i] = arry1[i];
            }
             for(i=0;i<n;i++)
            {
                Console.WriteLine("{0}", arr2[i]);
            }
            Console.WriteLine("\n\n");
        }
    }
}
