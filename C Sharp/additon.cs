using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addition
{
    internal class addition
    {
        public static void Main()
        {
            int num1, num2, add;
            Console.WriteLine("enter number 1");
            num1=Convert. ToInt32(Console.ReadLine());
            Console.WriteLine("enter number 2");
            num2=Convert.ToInt32(Console.ReadLine());
            add = num1 + num2;
            Console.WriteLine("result=" + add);
            Console.ReadKey();
                    
        }
    }
}
