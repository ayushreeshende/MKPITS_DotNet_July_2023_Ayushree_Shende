using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapes_interface
{
    public interface drawable
    {
        void draw();
    }
  public  class rectangle:drawable
    {
        public void draw()
        {
            Console.WriteLine("rec is drawable");
        }
    }
    public class circle:drawable
    {
        public void draw()
        {
            Console.WriteLine("circ is drawable");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            drawable d;
            d = new rectangle();
            d.draw();
            d = new circle();
            d.draw();
            Console.ReadKey();
        }
    }
}
