using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace abstract_account_bal_class
{
    abstract class account
    {
        public int accountno;
        public int balance;
        public abstract void deposit(int amt);

        public void showbalance()
        {
            Console.WriteLine("balance amount for account{0}is{1}", accountno, balance);
        }
    }
        class current : account
        {
            public override void deposit(int amt)
            {
                balance = balance + amt;
            }
        }
        class saving : account
        {
            public override void deposit(int amt)
            {
                int interest = 500;
                balance = balance + amt + interest;

            }
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("enter accountno");
                int accountno = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter amount to be deposited");
                int amt = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter accounttype saving or current");
                string accounttype = Console.ReadLine();
                account act = null;

                account acount = null;
                if (accounttype == "saving")
                {
                    act = new saving();
                }
                else if (accounttype == "current")
                {
                    act = new current();
                }
                act.accountno = accountno;
                act.deposit(amt);
                act.showbalance();
            Console.ReadKey();
            }
        }

    }


