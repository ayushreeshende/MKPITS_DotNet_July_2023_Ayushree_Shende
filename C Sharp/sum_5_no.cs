﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_of_5_no
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int sum = 0;
            
                for (int cnt = 1; cnt <= 5; cnt++) 
                {
                    Console.WriteLine("enter number");
                    num = Convert.ToInt32(Console.ReadLine());
                    sum = sum + num;

                }
                Console.WriteLine("sum of 5 no.=" + sum);
                Console.ReadKey();
            
        }

    }
}
    


