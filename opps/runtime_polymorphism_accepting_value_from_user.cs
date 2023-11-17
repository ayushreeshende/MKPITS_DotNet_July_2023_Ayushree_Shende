using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace runtime_polymorphism_accepting__values__from__the__user
{
    class account
    {
        public int accountno;
        public int bal = 1000;

        public virtual String deposit(int actno, int amount)
        {
            return "deposit method of account class";
        }
        public String showbalance()
        {
            return "balance amount : " + bal;
        }
    }

    class Current : account
    {

        public override string deposit(int actno, int amount)
        {
            this.accountno = actno;
            bal = bal + amount;
            return "amount deposited successfully in current class";
        }
    }
    public class TestBase
    {
        public static void Main()
        {

            account act = new Current();
            Console.WriteLine("enter account no ");
            int actno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter amount to be deposited ");
            int amount = Convert.ToInt32(Console.ReadLine());

            String res = act.deposit(actno, amount);
            Console.WriteLine("account no is " + act.accountno);
            Console.WriteLine(res);
            res = act.showbalance();
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
