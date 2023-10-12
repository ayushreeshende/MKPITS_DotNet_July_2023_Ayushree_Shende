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
            short b = 25890;
            Console.WriteLine(" value " + b);
            Console.WriteLine("enter short");
            b = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("value = " + b);
            //for negative as well as positive no.
            ushort b1 = 23890; //unsigned 
            Console.WriteLine("value " + b1);
            Console.WriteLine("enter sbyte");
            b1 = Convert.ToUInt16(Console.ReadLine());
            Console.WriteLine("value = " + b1);


            Console.ReadLine();
        }
    }
}
