using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_account
{
    interface bank
    {
        string deposit(int acctno, int amt);
    }
    class saving : bank
    {
        int acctno;
        int bal = 1000;

        public String deposit(int acctno, int amt)
        {
            this.acctno = acctno;
            bal = bal + amt;
            return "deposited successfully bal is:" + bal;
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                bank b;
                b = new saving();
                String str = b.deposit(6, 800);
                Console.WriteLine(str);
                Console.ReadKey();
            }
        }
    }
}
