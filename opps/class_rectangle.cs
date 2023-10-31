using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_rectangle
{
    class Rectangle
    {
        int area;
        int width;
        int length;

        public void getdata(int width, int length)
        {
            this.width = width;
            this.length = length;
        }

        public void calculate()
        {
            area = width * length;
            Console.WriteLine("area" + area);





        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Rectangle rec = new Rectangle();
                 rec.getdata(5, 10);
                 rec.calculate();
                Console.ReadKey();
            }
        }
    }
}
















