using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_bank_account
{
    class BankAccount
    {
        public int AccountNumber { get; set; }
        public string AccountHolder { get; set; }
        public int Balance { get; set; }
        public void display()
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("account details of customer:");
            Console.WriteLine("----------------------------");
            Console.WriteLine("account no:" + AccountNumber);
            Console.WriteLine("account Holder name:" + AccountHolder);
            Console.WriteLine("Balance:" + Balance);

        }
        public void transfer(BankAccount ba)
        {
            Balance = Balance + ba.Balance;
            ba.Balance = 0;
        }
        public void Showbalance()
        {
            Console.WriteLine("current balance for account no {0}is{1}", AccountNumber, Balance);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount b1 = new BankAccount();
            b1.AccountNumber = 1;
            b1.AccountHolder = "akash";
            b1.Balance = 100;

            b1.display();

            BankAccount b2 = new BankAccount();
            b2.AccountNumber = 2;
            b2.AccountHolder = "lucky";
            b2.Balance = 50;

            b2.display();

            b1.transfer(b2);
            Console.WriteLine("----------------------------------");
            Console.WriteLine("balance after transaction ");
            Console.WriteLine("----------------------------------");

            b1.Showbalance();
            b2.Showbalance(); 
            Console.ReadKey();


        }
    }
}




















