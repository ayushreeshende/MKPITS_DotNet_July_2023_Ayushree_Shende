using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while1to10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter = 1;
            while(counter<=10)
            {
                Console.WriteLine(counter);
                counter++;
            }
            Console.ReadKey();
        }
    }
}
