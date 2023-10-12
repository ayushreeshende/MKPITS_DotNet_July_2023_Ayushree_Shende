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
            Boolean b = true;
            Console.WriteLine(" value " + b);
            Console.WriteLine("enter value ");
            b = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("value = " + b);



            Console.ReadLine();
        }
    }
}
