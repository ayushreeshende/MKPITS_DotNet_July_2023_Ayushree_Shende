using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_of_num
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num=new int [] { 2, 5, 8 };
            int sum = 0;

            for (int cnt = 0; cnt < 3; cnt++)
            {
                sum = sum + num[cnt];
            }

            Console.WriteLine("sum:" + sum);
            Console.ReadKey();
        }
    }
}
