using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parameterized_book
{
    class Book
    {
        int bookid;
        string title;
        string author;
        int price;

        public Book()
        {
            Console.WriteLine();
            bookid = 13;
            title = "vb.net";
            author = "kumar";
            price = 2333;

        }
        public Book(int bookid, string title, string author, int price)
        {
            Console.WriteLine("");
            this.bookid = bookid;
            this.title = title;
            this.author = author;
            this.price = price;
        }
        public void display()
        {
            Console.WriteLine("bookid=" + bookid);
            Console.WriteLine("title=" + title);
            Console.WriteLine("author=" + author);
            Console.WriteLine("price=" + price);
        }

        internal class Program
        {
            class program
            {


                static void Main(string[] args)
                {
                    Book b1 = new Book();
                    b1.display();
                    Book b2 = new Book(22, "oracle", "ayu", 500);
                    b2.display();
                       
                    Console.ReadKey();
                }
            }
        }
    }
}