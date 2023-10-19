using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3subtotalpergrade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int marks;
            float per;
            string grade = null;
            int mark;
            int total = 0;
            for (int cnt = 0; cnt < 5; cnt++)
            {

                Console.WriteLine("enter 5 subject marks");
                mark = convert.ToInt32(console.Readline());
                total = total + mark;

            }
            per = (total / 500.0f) * 100.0f;
            
            if(per>=75)
            {
                grade = "distinction";
            }
            else if (per>=60 && per<75)
            {
                grade = "first class";
            }
            else
            {
                grade = "fail";
            }
            console.writeline("total=" + total);
            console.writeline("per=" + per);
            console.writeline("grade=" + grade);
        }
    }
}
