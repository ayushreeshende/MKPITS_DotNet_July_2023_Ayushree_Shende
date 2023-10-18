using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dowhilecube
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, cnt = 1;
            int result = 0;
            Console.WriteLine("enter a num");
            num = Convert.ToInt32(Console.ReadLine());
            do
            {
                result = cnt * cnt * cnt;
                cnt++;
            }
            while (cnt <= num);
            {
                Console.WriteLine("num is:{0}and cube of the {1}is{2}",  cnt, cnt, result);
                Console.ReadKey();
            }
        }
    }
}
        
     