using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace increament
{
    internal class Program
    {
       public static void Main()
        {
            int i = 0;
            int j = ++i;
            Console.WriteLine("value of i :" + i + "\n value of j:" + j);
            Console.ReadKey();
        }
    }
}
