using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloworld
{
    class Account
    {
        private string accName;
        private string acid;
        private int balance;
        public Account() { }

        public string ACCName
        {
            get { return accName; }
            set { accName = value; }
        }
        public string ACID
        {
            get { return acid; }
            set { acid = value; }
        }
        public int BALANCE
        {
            get { return balance; }
            set { balance = value; }
        }
   
        public void showinfo()
        {
            Console.WriteLine("ACCName:" + ACCName);
            Console.WriteLine("ACID:" + ACID);
            Console.WriteLine("BALANCE:" + BALANCE);
           

        }
    }
}
