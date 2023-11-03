using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor_book
{
    class Book
    {
        int bookid;
        string title, author;
        int price;
        public Book()
        {
            bookid = 1;
            title = "java";
            author = "bitcon";
            price = 200;
        }
        public void display()
        {
            Console.WriteLine("book id=" + bookid);
            Console.WriteLine("book title=" + title);
            Console.WriteLine("book author=" + author);
            Console.WriteLine("price=" + price);
        }
    }
    class Program
    {

   
        static void Main(string[] args)
        {
            Book b = new Book();
            b.display();
            Console.ReadKey();
        }
    }
}
