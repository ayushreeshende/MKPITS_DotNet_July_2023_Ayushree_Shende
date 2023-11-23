using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace arraylist_capacity_count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList ar = new ArrayList();
            ar.Add(11);
            ar.Add(12);
            ar.Add(13);
            foreach (int obj in ar)
            {
                Console.WriteLine("students rno:" + obj);
            }
            Console.WriteLine("capacity:{0}" + ar.Capacity);
            Console.WriteLine("count:{0}" + ar.Count);
            Console.ReadKey();
        }
    }
    }
