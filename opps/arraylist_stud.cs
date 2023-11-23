using System;

using System.Collections;
namespace arraylist_student
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList ar = new ArrayList();
            ar.Add("raju");
            ar.Add("rakesh");
            ar.Add("arpit");
            foreach (object obj in ar)
            {
                Console.WriteLine("student name:" + obj);

            }
            Console.ReadKey();
        }
    }
}
