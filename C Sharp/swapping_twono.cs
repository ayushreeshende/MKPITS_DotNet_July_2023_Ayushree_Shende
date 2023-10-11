using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swapping_twonum
{
    internal class swapping
    {
        public static void Main()
        {
            int a, b, temp;
            Console.WriteLine("enter value a");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter value b");
            b = Convert.ToInt32(Console.ReadLine());
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("after swapping");
            Console.WriteLine("" + a);
            Console.WriteLine("" + b);
            Console.ReadKey();
        }
    }
}
