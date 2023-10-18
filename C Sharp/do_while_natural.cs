using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dowhilenatural
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter = 1;
            do
            {

                Console.WriteLine("counter{0}",counter);
                counter++;
            }
            while (counter<= 10);
           Console.ReadKey();

        }
    }
}

       