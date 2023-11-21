using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_account_bank
{
    abstract class account
    {
        public int bal = (1000);
        public abstract void deposit(int amt);
        public abstract void withdrawal(int amt);
        public void showbalance()
        {
            Console.WriteLine("bal:" + bal);
        }
           
    }
    class saving:account
    {
        public override void withdrawal(int amt)
        {

            bal = bal - amt;
    }
        public override void deposit(int amt)
        {
            int interest = 500;
            bal = bal + amt + interest;
            Console.WriteLine("amount deposited with interest bal is:" + bal);
        }
        class current:account
        {
            public override void withdrawal(int amt)
            {
                bal = bal - amt;
            }
            public override void deposit(int amt)
            {
                bal = bal + amt;
                Console.WriteLine("amount deposited withour interest bal is:" + bal);
            }
        }
        internal class Program
    {
        static void Main(string[] args)
        {
                account a = null;
                Console.WriteLine("enter amount");
                int amount = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter saving or current");
                string acttype = Console.ReadLine();
                Console.WriteLine("enter deposit or withdrawl");
                string actt = Console.ReadLine();
                if (acttype == "saving")
                {
                    a= new saving();
                }
                else if (acttype == "current")
                {
                    a = new current();
                }

                if (actt == "deposit")
                {
                    a.deposit(amount);
                }
                else if (actt == "withdrawl")
                {
                    a.withdrawal(amount);
                }
                a.showbalance();

                Console.ReadLine();
            }
        }

    }
}

