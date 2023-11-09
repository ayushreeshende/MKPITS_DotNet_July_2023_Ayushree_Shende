using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace static_class__contain_more_than_one_method
{
    class book
    {
        public static int bookid;
        public static void display()
        {
            Console.WriteLine("hello from static display method");
        }
    }
class program
    {

    
          static void Main(string[] args)
        {
            book.bookid = 112;
            program p = new program();
            p.Main();
            Console.WriteLine("bookid" + book.bookid);
          }
        void Main()
        {
            Console.WriteLine("hello from another main method");
            Console.ReadKey();
        }
        }
}
