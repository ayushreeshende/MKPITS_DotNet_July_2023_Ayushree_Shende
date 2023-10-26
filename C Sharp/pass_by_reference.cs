using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pass_by_reference
{
    internal class Program
    {
        static void display(ref int num1)
        {
            num1 = 20;
            Console.WriteLine("num inside method" + num1);
        }
        static void Main(string[]args)
        {
            int num = 10;
            display(ref num);
            Console.WriteLine("num after passing inside main" + num);
            Console.ReadKey();
        }
    }
}
