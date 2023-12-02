using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_character
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] ch = new char[3];
            int sum = 0;
            for(int i=0;i<3;i++)
            {
                Console.WriteLine("enter character");
                ch[i] = Convert.ToChar(Console.ReadLine());
            }
            for(int i=0;i<3;i++)
            {
                Console.WriteLine("{0}", ch[i]);
            }
            Console.ReadKey();
        }
    }
}
