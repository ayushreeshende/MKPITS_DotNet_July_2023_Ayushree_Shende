using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace inheriting_methods_person_stud
{
    public class person
    {
        string name;
        string address;


        public void getpersondata(string name, string address)
        {
            this.name = name;
            this.address = address;
        }
    
        public void displaypersondata()
        {
            Console.WriteLine("name:" + name);
            Console.WriteLine("address:" + address);
        }
        class student : person
        {
            int rno;
            int marks;
            public void getstudentdata(int rno, int marks)
            {
                this.rno = rno;
                this.marks = marks;
            }
            public void displaystudentdata()
            {
                Console.WriteLine("rno:" + rno);
                Console.WriteLine("marks:" + marks);
            }
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                student s = new student();
                s.getpersondata("amit", "nagpur");
                s.getstudentdata(12, 450);
                s.displaystudentdata();
                s.displaypersondata();
                Console.ReadKey();
            }
        }
    }
}
