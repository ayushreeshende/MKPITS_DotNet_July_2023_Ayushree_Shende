using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hierarchical__inheritance_amount
{
    class account
    {
       public int balance = 1000;
       public int actno;
        public void deposit(int amount)
        {
            Console.WriteLine("this is deposit method of account class");

        }
    }
    class saving : account
    {
        public void deposit(int amount)
        {
            int interest = 500;
            balance = balance + amount + interest;
            Console.WriteLine("amount deposited with interest bal is:" + balance);
        }
    }
    class current:account
    {
        public void deposit(int amount)
        {
            balance = balance + amount;
            Console.WriteLine("amount deposited without interest bal is: " + balance);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            saving s = new saving();
            s.actno = 111;
            s.deposit(1000);

            current c = new current();
            c.actno = 121;
            c.deposit(1000);
            Console.ReadKey();

        }
    }
}
