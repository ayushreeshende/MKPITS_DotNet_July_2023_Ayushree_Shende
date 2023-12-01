using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace null_reference_exception
{
    internal class Program
    {
        class program
        {


            static void Main(string[] args)
            {
                string str = null;
                try
                {
                    Console.WriteLine(str.Substring(5));

                }
                catch (Exception ee)
                {
                    Console.WriteLine("null reference exception ee");
                }
                Console.WriteLine("ee".ToString());
                Console.WriteLine("bye");
                Console.ReadKey();
            }
          

        }
    }
}
