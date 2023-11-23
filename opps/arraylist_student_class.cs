using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace arraylist_student_class
{
    class student
    {


        public int rno;
        public string name;
        public student(int rno, string name)
        {
            this.rno = rno;
            this.name = name;
        }
    }


     class Program
    {
        static void Main(string[] args)
        {
            
            student s1 = new student(12, "ayu");
            student s2 = new student(13, "khushi");
            student s3 = new student(14, "harsh");
            ArrayList ar = new ArrayList();
            ar.Add(s1);
            ar.Add(s2);
            ar.Add(s3);
            foreach (student s in ar) 
            {
                Console.WriteLine("rno:" + s.rno);
                Console.WriteLine("name" + s.name);
                Console.ReadKey();
            }

        }
    }
}
