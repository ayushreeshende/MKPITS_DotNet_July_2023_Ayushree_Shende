using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_class_shape
{
  abstract  class shape
    {
        public abstract void draw();
        

        }
    class rectangle:shape
    {
        public override void draw()
        {
            Console.WriteLine("code to draw class");
        }

    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
           shape s = new rectangle();
            s.draw();
            Console.ReadKey();
        }
    }
}
