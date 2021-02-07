using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloworld
{
    class Triangle
    {
        private int x;
        private int y;
        private int z;
       
        public Triangle() { }

        public int X
        {
            get { return x; }
            set { x = value; }
        }
        public int Y
        {
            get { return y; }
            set { y = value; }
        }
        public int Z
        {
            get { return z; }
            set { z = value; }
        }
      
        public void showinfo()
        {
            Console.WriteLine("X:" + X);
            Console.WriteLine("Y:" + Y);
            Console.WriteLine("Z:" + Z);
          
        }
    }
}
