using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace row_i_j
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i=0,j=0;i<=5;i++,j++)
            {
                Console.WriteLine("i=" + i);
                Console.WriteLine("j=" + j);
            }
            Console.ReadKey();
        }
    }
}
