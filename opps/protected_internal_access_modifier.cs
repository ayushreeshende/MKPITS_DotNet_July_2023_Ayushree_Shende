using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace protected_internal_access_modifier
{
    public class person
    {
        string name;
        string address;
        protected internal void getpersondata(string name, string address)
        {
            this.name = name;
            this.address = address;

        }
        protected internal void displaypersondata()
        {
            Console.WriteLine("name:" + name);
            Console.WriteLine("address:" + address);
        }
    }
    public class student : person
    {
        int rno;
        int marks;
        public void getstudentdata(int rno, int marks)
        {
            this.rno = rno;
            this.marks = marks;

        }
        public void displaystudentadata()
        {
            Console.WriteLine("rno:" + rno);
            Console.WriteLine("marks:" + marks);
        }


        internal class Program
        {
            static void Main(string[] args)
            {
                student s = new student();
                s.getpersondata("amit", "nagpur");
                s.displaypersondata();
                s.getstudentdata(124, 6700);
                s.displaystudentadata();
                Console.ReadKey();
            }
        }
    }
}
