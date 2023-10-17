using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oddno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter = 20;
            while(counter<=30)
            {
                if(counter %2==1)
                {
                    Console.WriteLine("{0} is odd", counter);
                }
                counter = counter + 1;
            }
            Console.ReadKey();
        }
    }
}
