using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace variable_len_parameter_list
{
    internal class Program
    {
        static int calculate(params int []num)

        {
            int i, total = 0;
            for (i = 0; i < num.Length;i++)
            {
                total = total + num[i];
            }
            return total;
        }
        static void Main(string[]args)
        {
            int result = calculate(1, 2, 3);
            Console.WriteLine("total=" + result);
            Console.ReadKey();
        }
    }
}
