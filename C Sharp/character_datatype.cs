using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            float b;
            Console.WriteLine("enter number");
            b = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("number " + b);

            double b1;
            Console.WriteLine("enter number");
            b1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("number " + b1);

            decimal b2;
            Console.WriteLine("enter number");
            b2 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("number " + b2);

            char ch;
            Console.WriteLine("enter charact");
            ch = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("char " + ch);

            Boolean bb;
            Console.WriteLine("enter true or false");
            bb = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("char " + bb);



            Console.ReadKey();

        }
    }
}
