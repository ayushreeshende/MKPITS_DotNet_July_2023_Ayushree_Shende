using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_primeno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, counter;
            Console.WriteLine("enter the number :");
            num = Convert.ToInt32(Console.ReadLine());
            for (counter = 1; counter <= num; counter++)
            {
                if (num % 2 != 0)
                {
                    Console.WriteLine("{0}is prime no");
                    break;
                }
                else
                {
                    Console.WriteLine("{0}is not prime no");
                    break;
                }
                Console.ReadKey();
            }
        }
    }
}

