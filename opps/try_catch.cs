using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace try_catch
{
    internal class Program
    {
        class program
        {


            static void Main(string[] args)
            {
                int num;
                int n;
                Console.WriteLine("enter number 1");
                num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter number 2");
                n = Convert.ToInt32(Console.ReadLine());
                int res = 0;
                Console.WriteLine(res + "" + num);
                try
                {
                    res = num / n;

                }
                catch(Exception ee)
                {
                    Console.WriteLine("cannot divide by zero");

                }
                Console.WriteLine("res:" + num);
                Console.WriteLine("bye");
                Console.ReadKey();
            }
        }
    }
}
