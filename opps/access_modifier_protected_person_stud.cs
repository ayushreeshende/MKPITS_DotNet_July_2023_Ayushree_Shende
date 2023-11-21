using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace accesss_modifier_protected_person_student
{
    public class person
    {
        string name;
        string address;
        protected void getpersondata(string name, string address)
        {
            this.name = name;
            this.address = address;
        }
        protected void displaypersondata()
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
                getpersondata("ayu", "akola");
                this.rno = rno;
                this.marks = marks;

            }
            public void displaystudentdata()
            {
                displaypersondata();
                Console.WriteLine("rno:" + rno);
                Console.WriteLine("marks:" + marks);
            }
        }

        internal class Program
        {
            static void Main(string[] args)
            {
                student s1 = new student();
                s1.getstudentdata(111, 900000);
                s1.displaystudentdata();
                Console.ReadKey();
            }
        }
    }
}
