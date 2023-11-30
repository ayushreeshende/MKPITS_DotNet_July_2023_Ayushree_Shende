using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringbuilder
{
    internal class Program
    {
        class program
        {


            static void Main(string[] args)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("ravi");
                sb.Append("amit");
                Console.WriteLine(sb.ToString());
                Console.WriteLine("bye");
                Console.ReadKey();

            }
        }
    }
}
