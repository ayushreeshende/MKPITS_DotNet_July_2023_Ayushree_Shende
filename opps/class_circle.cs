using class_circle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_circle
{
    class Circle
    {
        int radius;
        float area_circ, area;

        public void getdata(int radius, int area)
        {
            this.radius = radius;
            this.area = area;
            this.area_circ = area_circ;
        }
    
        public void displaydata()
        {
            area = 3.14f * radius * radius;
            Console.WriteLine("area:" + area);
            area_circ = 2 * 3.14f * radius;
            Console.WriteLine("area of circumference:" + area_circ);

        }

    }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
       Circle c1= new Circle();
            c1.getdata(7,7);
            c1.displaydata();
            Console.ReadKey();
        }
    }

