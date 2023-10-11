using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radius_Circumference
{
    internal class Radius

    {
        public static void Main()
        {
            int radius;
            float area, circ;
            Console.WriteLine("enter radius");
            radius = Convert.ToInt32(Console.ReadLine());
            area = 3.14f * radius * radius;
            circ = 2 * 3.14f * radius;
            Console.WriteLine("area=" + area);
            Console.WriteLine("circ=" + circ);
            Console.ReadKey();

        }
    }
}
