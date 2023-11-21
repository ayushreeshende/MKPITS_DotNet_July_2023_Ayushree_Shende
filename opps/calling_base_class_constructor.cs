using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calling_base_class_constructor
{
    class company
    {
        public string name = "mkcl";
        public company()
        {
            Console.WriteLine("base class constructor");
            Console.WriteLine("company name:" + name);
        }
    }
        class frenchise: company
        {
            public string name = "mkpits";
            public frenchise()
            {
                Console.WriteLine("derived constructor");
                Console.WriteLine("frenchise name:" + name);
            }
                
        }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            frenchise f = new frenchise();
            
            Console.ReadKey();
                
        }
    }
}
