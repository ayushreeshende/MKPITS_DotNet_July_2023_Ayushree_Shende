using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace length_breadth
{
    internal class rectangle

    {
      public static void Main()

        {
            int l, b, area;
            Console.WriteLine("enter length");
            l=Convert .ToInt32(Console.ReadLine());
            Console.WriteLine("enter breadth");
            b = Convert.ToInt32(Console.ReadLine());
            area = l *b;
            Console.WriteLine("area=" + area);
            Console.ReadKey();
        }
    }
}
