using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_grade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string grade;
            Console.WriteLine("enter grade");
            grade = Console.ReadLine();
            switch (grade)
            {
                case "E":
                    Console.WriteLine("excellent");
                    break;
                case "V":
                    Console.WriteLine("very good");
                    break;
                case "G":
                    Console.WriteLine("good");
                    break;
                case "A":
                    Console.WriteLine("average");
                    break;
                case "F":
                    Console.WriteLine("fail");
                    break;
                default:
                    Console.WriteLine("some other grade");
                    break;
            }
            Console.ReadKey();
        }
    }
}
