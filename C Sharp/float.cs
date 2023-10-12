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
            float b = 123.4567890f; //signed
            Console.WriteLine(" value " + b);
            Console.WriteLine("enter value ");
            b = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("value = " + b);



            Console.ReadLine();
        }
    }
}
