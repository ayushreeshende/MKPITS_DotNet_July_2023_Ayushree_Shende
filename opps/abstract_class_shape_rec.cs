using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_class_shape_rec
{
    public abstract class shape
    {
        public abstract void draw();

    }
    public class rectangle : shape
    {
        public override void draw()
        {
            Console.WriteLine("rectangle is drawing");
        }
    }
    public class circle:shape
    {
        public override void draw()
        {
            Console.WriteLine("circle is drawing");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            shape s;
                s = new rectangle();
                s.draw();
            s = new circle();
                s.draw();
            Console.ReadKey();

        }
    }
}
