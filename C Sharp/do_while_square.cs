using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace do_while_square
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, square;
            char choice = 'y';
            do
            {
                Console.WriteLine("enter number");
                num = Convert.ToInt32(Console.ReadLine());
                square = num * num;
                Console.WriteLine("square=" + square);
                Console.WriteLine("do you want to continue,press y or n");
                choice = Convert.ToChar(Console.ReadLine());
            } while (choice == 'y' || choice == 'y');
            Console.ReadKey();
        }
    }
}
