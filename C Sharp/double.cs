using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class1
    {

        public static void Main()
        {
            double b = 123456.1234567890123; //signed
            Console.WriteLine(" value " + b);
            Console.WriteLine("enter value ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("value = " + b);



            Console.ReadLine();
        }
    }
}
