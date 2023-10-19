using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace table

{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 10;
            int result = 1;
            int cnt = 1;
            Console.WriteLine("enter  number");
            num = Convert.ToInt32(Console.ReadLine());

            for (cnt = 1; cnt <= 10; cnt++)
            {
                result = num * cnt;
                Console.WriteLine("{0}*{1}={2}", cnt, num, result);
            }


            
            Console.ReadKey();
        }
    }
}
