using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace average_sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int sum = 0;
                double avg = 0;
            while(num1<=10)
            {
                Console.WriteLine(num1);
                sum += num1;
                avg = (float)sum / 10.0;
                num1++;
            }
            Console.WriteLine("result" + sum);
            Console.WriteLine("average:" + avg);
            Console.ReadKey();
        }
    }
}
