using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_fields_with_different_objects
{
    class book
    {
        static string title;
        static book()
        {
            Console.WriteLine(" static constructor called");
            title = "mkpits";
        }
        public void display()
        {
            Console.WriteLine("title : " + title);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            book b1 = new book();
            b1.display(); //this will call static constructor only once
            book b2 = new book();
            b2.display(); // now static constructor will not be called;
            Console.ReadKey();
        }
    }
}

