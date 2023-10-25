using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void display(int num)
        {
            int cnt = 2;
            int flag = 0;
            while(cnt<num)
            {
                if(num%cnt==0)
                {
                    flag = 1;
                    break;
                }
                cnt++;
            }
            if(flag==0)
            {
                Console.WriteLine("It is a prime number");
            }
            else
            {s
                Console.WriteLine("It is not a prime number");
            }
        }
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Enter Number: ");
            number = Convert.ToInt32(Console.ReadLine());
            display(number);
            Console.ReadKey();
        }
    }
}
