using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operation
{
    internal class Program
    {
        static void Main()
        {
            int result;
            result = -1 + 4 * 6;
            Console.WriteLine("result=" + result);
            

            result = (35 + 5) % 7;
            Console.WriteLine("result=" + result);
           

            result = 14 + -4 * 6 / 11;
            Console.WriteLine("result=" + result);
            


            result = 2 + 15 / 6 * 1 - 7 % 2;
            Console.WriteLine("result=" + result);
            Console.ReadKey();
        }
    }
}
