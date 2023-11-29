

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class1
    {
        struct student
        {
            public int rno;
            public String name;
            public String course;
        }
        public static void Main()
        {
            student s1;
            Console.WriteLine("enter rno");
            s1.rno = Convert.ToInt32(Console.ReadLine());
            s1.name = Console.ReadLine();
            s1.course = Console.ReadLine();

            Console.WriteLine("rno " + s1.rno);
            Console.WriteLine("name " + s1.name);
            Console.WriteLine("course " + s1.course);
            Console.ReadKey();
        }
    }
}
