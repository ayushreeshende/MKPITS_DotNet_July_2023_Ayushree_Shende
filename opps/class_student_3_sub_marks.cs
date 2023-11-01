using student_3sub_marks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace student_3sub_marks
{
    class Student
    {
        string name;
        int rollno;
        int[] subjectmarks;
        int avg = 0;

        public void getdata(string name, int rollno, int[] m)
        {
            this.name = name;
            this.rollno = rollno;
            this.subjectmarks = m;
        }

        public void displaydata()
        {
            Console.WriteLine("rollno" + rollno);
            Console.WriteLine("name" + name);
            int total = 0;

            for (int i = 0; i < subjectmarks.Length; i++)
            {
                total = total + subjectmarks[i];
            }
            float avg = total / 3.0f;
                Console.WriteLine("avg" + avg);
            }
        }
    }


internal class Program


{
    static void Main(string[] args)
    {
        Student stud = new Student();
        Console.WriteLine("enter rollno & name");
        int rollno = Convert.ToInt32(Console.ReadLine());
        string name = Console.ReadLine();
        int[] m = new int[3];
        Console.WriteLine("enter 3 sub marks");
        for (int i = 0; i < 3; i++)
        {
            m[i] = Convert.ToInt32(Console.ReadLine());
        }

        stud.getdata(name, rollno, m);
        stud.displaydata();
        Console.ReadKey();
    }
}
   



















