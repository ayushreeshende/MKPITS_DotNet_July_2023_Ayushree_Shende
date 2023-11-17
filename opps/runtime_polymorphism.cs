using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace runtime_polymorphism
{
    public class shape
    {
        public virtual void draw()
        {
            Console.WriteLine("drawing");
        }
    }
    public class rectangle : shape
    {
        public override void draw()
        {
            Console.WriteLine("rectangle drawing");
        }
    }
    public class circle : shape
    {
        public override void draw()
        {
            Console.WriteLine("circle drawing");
        }

        internal class Program
        {
            static void Main(string[] args)
            {
                shape s;
                s = new shape();
                s.draw();
                s = new rectangle();
                s.draw();
                s = new circle();
                s.draw();
                Console.ReadKey();
            }
        }
    }
}
