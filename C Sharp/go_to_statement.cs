using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace goto_statement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("enter number");
            num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0) goto Even;
            Console.WriteLine("odd no");
            goto End;
        Even:
            Console.WriteLine("even no");
        End:
            Console.WriteLine("bye");
            Console.ReadKey();
        }
    }
}
