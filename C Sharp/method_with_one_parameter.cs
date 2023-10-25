using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_with_one_parameter__fact
{
    internal class Program
    {
        static void factorial(int num)

        {
            int fact = 1;
            while (num > 0)
            {
                fact = fact * num;
                num--;
            }
            Console.WriteLine("fact=" + fact);
        }
        static void Main(string[]args)
        {
            factorial (6);
            Console.ReadKey();
        }

        }
    }

