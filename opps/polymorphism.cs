using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    class baseclass
        {
        public virtual void show()
        {
            Console.WriteLine("hello from baseclass method");
        }
    }
    class childclass:baseclass
    {
        public override void show()
        {
            Console.WriteLine("hello from childclass method");
            
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            childclass c = new childclass();
            c.show();
            Console.ReadKey();

        }

    }
}
