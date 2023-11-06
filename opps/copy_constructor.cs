using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace copy_constructor
{
    class Book
    {
        int bookid;
        string title;
        public Book()
        {
            bookid = 123;
            title = "vb.net";
        }
        public Book(Book b2)
        {
            bookid = b2.bookid;
            title = b2.title;
        }
        public void display()
        {
            Console.WriteLine("book id:" + bookid);
            Console.WriteLine("book title:" + title);
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            Book book2 = new Book(book1);
            Console.WriteLine("book1 details are:");
            book1.display();
            Console.WriteLine("book2 details are:");
            book2.display();
            Console.ReadKey();
        }
    }
}
