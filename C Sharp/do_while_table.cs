using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace do_while_table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("enter number");
            num = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            int counter1 = 1;
            do
            {
                result = num * counter1;
                Console.WriteLine("{0}*{1}={2}", num, counter1, result);
                counter1++;




            } while (counter1<= 10);

            { 




                Console.ReadKey();
            }
        }
    }
}

            
 