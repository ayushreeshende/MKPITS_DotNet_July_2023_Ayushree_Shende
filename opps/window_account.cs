using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace windows_account_
{
    abstract class account
    {
        public int acctno;
        public int bal = 1000;
        public abstract string deposit(int a, int b);
        public string showbalance()
        {
            return "bal is:" + bal;
        }
    }
    class saving : account
    {
        public override string deposit(int a, int b)
        {
            int interest = 500;
            bal = bal + b + interest;
            acctno = a;
            return "bal is:" + bal;
            ; }
    }
    class current : account
    {
        public override string deposit(int a, int b)
        {
            bal = bal + b;
            return "bal is:" + bal;
        }
    }
           
    internal class window_account
    {
    }
}
