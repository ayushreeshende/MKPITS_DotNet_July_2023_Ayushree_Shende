using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @static
{
  class program
    {
       void display()
        {
            Console.WriteLine("hello");
        }
    
        static void Main(string[] args)
        {
            program p = new program();
            p.display();
            Console.ReadKey();
        }
    }
}
