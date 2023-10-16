using System;

namespace Operator2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, sum;
            char op;
            Console.Write("Enter Num1");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Num 2");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter op(+,-,*,/)");
            op = Convert.ToChar(Console.ReadLine());
            if (op == '+')
            {
                sum = num1 + num2;
                Console.Write("Result is " + sum);
            }
            else if (op == '-')
            {
                sum = num1 - num2;
                Console.Write("Result is " + sum);
            }
            else if (op == '*')
            {
                sum = num1 * num2;
                Console.Write("Result is " + sum);
            }
            else if (op == '/')
            {
                sum = num1 / num2;
                Console.Write("Result is " + sum);
            }

            Console.ReadKey();
        }
    }
}