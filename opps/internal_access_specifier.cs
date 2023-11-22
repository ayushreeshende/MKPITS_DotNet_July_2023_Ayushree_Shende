using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace internal_accesss_specifier
{
    class person
    {
        internal string name = "ravi";
        
        internal void msg(string msg)
        {
            Console.WriteLine("hello:" + msg);
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                person p = new person();
                Console.WriteLine("name:" + p.name);
                Console.ReadKey();
            }
        }
    }
        }
    
