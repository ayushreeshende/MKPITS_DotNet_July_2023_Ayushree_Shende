using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapes

{
    internal class Program
    {
        static void Main(string[] args)
        {
            int r, num, sqr, num1, rectangle, l, b, h, triangle;
            float area;
            Console.WriteLine("enter number");
            num = Convert.ToInt32(Console.ReadLine());
            switch(num)
            {
                case 1:
                    Console.WriteLine("enter circle of radius:");
                    r = Convert.ToInt32(Console.ReadLine());
                    area = 3.14f * r * r;
                    Console.WriteLine("area=" + area);
                    break;

                case 2:
                    Console.WriteLine("enter a number");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    sqr = num1 * num1;
                    Console.WriteLine("result :" + sqr);
                    break;

                case 3:
                    Console.WriteLine("enter length");
                    l = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("enter breadth");
                    b = Convert.ToInt32(Console.ReadLine());
                    rectangle = l * b;
                    Console.WriteLine("result:" + rectangle);
                    break;

                case 4:
                    Console.WriteLine("enter base");
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("enter height");
                    h = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("enter length");
                    l = Convert.ToInt32(Console.ReadLine());
                    triangle = l * b *h;
                    Console.WriteLine("result:" + triangle);
                    break;
                default:
                    Console.WriteLine("invalid");
                    break;



            }
            Console.ReadKey();
        }
    }
}
