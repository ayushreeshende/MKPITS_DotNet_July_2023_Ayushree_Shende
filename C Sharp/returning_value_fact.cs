﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace returning_value_fact
{
    internal class Program
    {
        static int factorial (int num)

        {
            int fact = 1;
            while(num>0)
            {
                fact = fact * num;
                num--;
            }
            return fact;
        }
        static void Main(string[]args)
        {
            int number;
            Console.WriteLine("enter number");
            number = Convert.ToInt32(Console.ReadLine());
            int result = factorial(number);
            Console.WriteLine("fact" + result);
            Console.ReadKey();
        }
    }
}
