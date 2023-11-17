using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace runtime_polymorphism_account
{
    class account
    {
        public int accountno;
        public int balance = 1000;
        public virtual string deposit(int accountno, int amount)
        {
            return "deposit method of account class";

        }
        public String showbalance()
        {
            return "balance amount : " + balance;
        }
    }

    class Current : account
    {

        public override string deposit(int accountno, int amount)
        {
            this.accountno= accountno;
            balance = balance + amount;
            return "amount deposited successfully in current class";
        }
    }
    public class TestBase
    {
        public static void Main()
        {
            
            account act = new Current();
            String res = act.deposit(123, 2000);
            Console.WriteLine("account no is " + act.accountno);
            Console.WriteLine(res);
            res = act.showbalance();
            Console.WriteLine(res);
            Console.ReadKey();

        }
    }
}

