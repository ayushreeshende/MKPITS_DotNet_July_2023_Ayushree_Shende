using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace natural_sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            int sum = 0;
            while(num<=10)
            {
                Console.WriteLine(num);
                sum += num;
                num++;

            }
            Console.WriteLine("result :" + sum);
            Console.ReadKey();
        }
    }
}
