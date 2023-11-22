using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace private_accesss_specifier
{
    class program
    {
        private string name = "ramesh";
        private void msg(string msg)
        {
            Console.WriteLine("hello:" + msg);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            program program = new program();
            Console.WriteLine("hello:" + program.name);
            program.msg("duck");
            Console.ReadKey();
        }
          

        }
    }

