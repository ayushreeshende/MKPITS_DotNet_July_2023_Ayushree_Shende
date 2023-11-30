using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace argument_out_of_range_exception
{
    internal class Program
    {
        class program
        {


            static void Main(string[] args)
            {
                
                string name = "ayu";
                string subject = "maths";
                Console.WriteLine(" length of name:" + name.Length);
                StringBuilder sb = new StringBuilder(name.Length,name.Length);
                try
                {
                    sb.Append("subject");
                }
                catch (Exception ee)
                {
                    Console.WriteLine(ee.ToString());
                    Console.WriteLine("bye");
                    Console.ReadKey();
                }
            }

        }
    }
}
