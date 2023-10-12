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
            byte b = 25; // unsigned byte for storing positive no.
            Console.WriteLine("byte value " + b);
            Console.WriteLine("enter byte");
            b = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("byte = " + b);
            //for negative as well as positive no.
            sbyte b1 = -23; //signed byte
            Console.WriteLine("sbyte value " + b1);
            Console.WriteLine("enter sbyte");
            b1 = Convert.ToSByte(Console.ReadLine());
            Console.WriteLine("sbyte = " + b1);


            Console.ReadLine();
        }
    }
}
