using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace square
{
   internal class square
    {
        public static void Main()
        {
            int num, square;
            Console.WriteLine("enter number");
            num=Convert.ToInt32(Console.ReadLine());
            square = num * num;
            Console.WriteLine("square=" + square);
            Console.ReadKey();
        }
    }
}
