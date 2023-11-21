using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace account_bank_interface
{
    interface bank
    {
        string deposit(int acctno, int amt);
        string withdrawal(int acctno, int amt);
    }
    class account
    {
        public int actno;
        public int bal = 1000;
        public string showbalance()
        {
            return "bal is:" + bal;
        }
    }
    class saving : account
    {
        public string deposit(int acctno, int amt)
        {
            this.actno = acctno;
            bal = bal + amt;
            return "deposited successfully bal is :" + bal;

        }
        public string withdrawal(int acctno, int amt)
        {
            this.actno = acctno;
            bal = bal - amt;
            return "withdrawal successfully bal is:" + bal;


        }


        }
        internal class Program
        {
            static void Main(string[] args)
            {
                {
                    saving b;
                    b = new saving();
                    String str = b.deposit(1, 200);
                    Console.WriteLine(str);

                    str = b.withdrawal(1, 100);
                    Console.WriteLine(str);
                    Console.WriteLine(b.showbalance());
                Console.ReadKey();
                }

            }
        }
    }

