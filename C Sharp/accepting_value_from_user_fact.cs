using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace accepting_value_from_user_fact
{
    internal class Program
    {
        static void factorial(int num)
        {
            int fact = 1;
            while(num>0)
            {
                fact = fact * num;
                num--;
            }
            Console.WriteLine("fact" + fact);
        }
        static void Main(string[]args)
        {
            int number;
            Console.WriteLine("enter number");
            number = Convert.ToInt32(Console.ReadLine());
            factorial(number);
            Console.ReadKey();
        }
        
        }
    }

