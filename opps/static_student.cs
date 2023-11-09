using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_student
{
    class student
    {
        public static void display()
        {
            Console.WriteLine("hello");
        }
        public void sayhi()
        {
            Console.WriteLine("hi");
        }
    }
   class Program
    {
        static void Main(string[] args)
        {
            student.display();
            student s = new student();
            s.sayhi();
            Console.ReadKey();
        }
    }
}
