using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_total_grade_per
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int marks;
            float per;
            string grade = null;

            int total = 0;
            for (int cnt = 0; cnt < 5; cnt++)
            {

                Console.WriteLine("enter 5 subject marks");
                marks = Convert.ToInt32(Console.ReadLine());
                total = total + marks;

            }
            per = (total / 500.0f) * 100.0f;

            if (per >= 75)
            {
                grade = "distinction";
            }
            else if (per >= 60 && per < 75)
            {
                grade = "first class";
            }
            else
            {
                grade = "fail";
            }
            Console.WriteLine("total=" + total);
            Console.WriteLine("per=" + per);
            Console.WriteLine("grade=" + grade);
            Console.ReadKey();
        }
        
    }
}

      