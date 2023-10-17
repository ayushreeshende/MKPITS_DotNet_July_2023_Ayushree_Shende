using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numberofdays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int monthno;
            Console.WriteLine("enter monthno");
            monthno = Convert.ToInt32(Console.ReadLine());
            switch (monthno)
            {
                case 1:
                    Console.WriteLine("jan is 31 days");
                    break;
                case 2:
                    Console.WriteLine("feb is 28 days");
                    break;
                case 3:
                    Console.WriteLine("march is 31 days");
                    break;
                case 4:
                    Console.WriteLine("april is 30 days");
                    break;
                case 5:
                    Console.WriteLine("may is 31 days");
                    break;
                case 6:
                    Console.WriteLine("june is 30 days");
                    break;
                case 7:
                    Console.WriteLine("july is 31 days");
                    break;
                case 8:
                    Console.WriteLine("august is 31 days");
                    break;
                case 9:
                    Console.WriteLine("sep is 30 days");
                    break;
                case 10:
                    Console.WriteLine("oct is 31 days");
                    break;
                case 11:
                    Console.WriteLine("nov is 30 days");
                    break;
                case 12:
                    Console.WriteLine("dec is 31 days");
                    break;
                default:
                    Console.WriteLine("invalid dayno");
                    break;

                
            }
            Console.ReadKey();
        }
    }
}
