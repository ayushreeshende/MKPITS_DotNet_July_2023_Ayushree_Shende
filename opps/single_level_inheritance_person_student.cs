using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace single_level_inheritance_person_stud
{
    class person
    {
        public string name;
        public string address;
    }
    class student:person
    {
        public int rno;
        public int marks;
    }
    class Program
    {
        static void Main(string[] args)
        {
            student s1 = new student();
            s1.name = "anshika";
            s1.address = "mumbai";
            s1.marks = 123;
            s1.rno = 1;
            Console.WriteLine("name:" + s1.name);
            Console.WriteLine("address:" + s1.address);
            Console.WriteLine("marks:" + s1.marks);
            Console.WriteLine("rno:" + s1.rno);
            Console.ReadKey();
        }
    }
}
