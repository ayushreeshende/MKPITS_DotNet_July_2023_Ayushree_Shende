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
            int sub1, sub2, sub3, total;
            float per;
            string grade = null;
            Console.WriteLine("enter 3 subject marks");
            sub1 = Convert.ToInt32(Console.ReadLine());
            sub2 = Convert.ToInt32(Console.ReadLine());
            sub3 = Convert.ToInt32(Console.ReadLine());
            total = sub1 + sub2 + sub3;
            Console.WriteLine("total marks:" + total);
            per = (total / 300.0f) * 100.0f;
            Console.WriteLine("percentage:{0}", per);
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
            Console.WriteLine("grade:{0}", grade);
            Console.ReadKey();
        }
    }
}
