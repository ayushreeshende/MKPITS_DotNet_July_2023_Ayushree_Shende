using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_odd_no
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            int counter = 1;
            Console.WriteLine("enter number");
            number = Convert.ToInt32(Console.ReadLine());
            int sum = 1;
            while(true)
            {
                if(sum<=number)
                {
                    if(counter%2!=0)
                    {
                        Console.WriteLine("odd no :{0}", counter);
                        sum = sum + 1;
                    }
                }
                else
                {
                    break;
                }
                counter++;
            }
            Console.ReadKey();
        }
    }
}
