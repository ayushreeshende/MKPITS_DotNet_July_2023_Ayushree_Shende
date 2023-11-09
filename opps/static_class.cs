using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_class
{
    public static class mymath
    {
        public static float pi = 3.14f;
        public static int cube(int n) { return n * n * n; }
    }
    class testmymath
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("value pf pi is:" + mymath.pi);
            Console.WriteLine("cube of 3 is:" + mymath.cube(3));
            Console.ReadKey();
        }
    }
}
