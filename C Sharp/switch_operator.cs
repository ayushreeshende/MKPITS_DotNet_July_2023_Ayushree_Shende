using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchoperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, num1, num2, add, sub, mul, choice; 
            float div;
            Console.WriteLine("choice 1 for addition");
            Console.WriteLine("choice 2 for subtraction");
            Console.WriteLine("choice 3 for multiplication");
            Console.WriteLine("choice 4 for division");

            choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter first num:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter second num:");
            num2 = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    add = num1 + num2;
                    Console.WriteLine("result :" + add);
                    break;
                case 2:
                    sub = num1 - num2;
                    Console.WriteLine("result :" + sub);
                    break;
                case 3:
                    mul = num1 * num2;
                    Console.WriteLine("result :" + mul);
                    break;

                case 4:
                    div = num1 / num2;
                    Console.WriteLine("result :" + div);
                    break;


            }
            Console.ReadKey();

        }
    }
}
