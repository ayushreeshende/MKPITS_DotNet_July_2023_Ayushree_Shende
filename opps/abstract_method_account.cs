using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_class_account
{
  abstract  class account
    {
        public abstract void deposit();
    }
          class saving:account
    {
        public override void deposit()
        {
            Console.WriteLine("hello from saving deposit method");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            account a = new saving();
            a.deposit();
            Console.ReadKey();
        }
    }
}
