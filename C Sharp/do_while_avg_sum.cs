using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dowhileaveragesum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int sum = 0;
            double avg = 0;
            do
            {

                Console.WriteLine(num1);
                sum += num1;
                avg = (float)sum / 10.0;
                num1++;
            }
            while (num1 <= 10);
                
                    Console.WriteLine("result" + sum);
            Console.WriteLine("average:" + avg);
            Console.ReadKey();
        }
    }
}

 