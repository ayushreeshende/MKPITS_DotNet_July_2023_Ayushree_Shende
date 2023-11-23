using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_remove
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList ar = new ArrayList();
            ar.Add(19);
            ar.Add(20);
            ar.Add(13);

            ar.RemoveAt(2);
            foreach (int obj in ar)
            {
                Console.WriteLine("rno:" + obj);
            }
            
            Console.ReadKey();
        }
        }
}
