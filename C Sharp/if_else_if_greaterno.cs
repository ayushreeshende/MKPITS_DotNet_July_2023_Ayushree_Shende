using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifelsegreater
{
    internal class Program
    {
       public static void Main()
        {
            int num1, num2;
            Console.WriteLine("enter number 1");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number2");
            num2 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2)
                Console.WriteLine("num 1 is greater");
            else
                Console.WriteLine("num2 is greater");


            Console.ReadKey();
        }
    }
}
