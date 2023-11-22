using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace protected_internal_access_specifier
{
    class protecttest
    {
        protected internal  string name = "raju";
        protected void msg(string msg)
        {
            Console.WriteLine("hello:" + msg);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            protecttest p = new protecttest();
            p.name = "raju";
            
            Console.WriteLine(p.name);
            
            Console.ReadKey();
                

        }
    }
}
