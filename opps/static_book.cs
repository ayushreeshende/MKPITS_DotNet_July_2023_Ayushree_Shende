using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_book
{
    class book
    {
        public static int bookkid;
    }
    class program
    {

    
        static void Main(string[] args)
        {
            book.bookkid = 123;
            Console.WriteLine("bookid=" + book.bookkid);
            Console.ReadKey();
        }
    }
}
