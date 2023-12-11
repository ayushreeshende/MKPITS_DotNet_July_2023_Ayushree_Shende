using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    class Author
    {
        public string AuthorName { get; }

        public Author(string AuthorName)
        {

            this.AuthorName = AuthorName;
    }

    }
    class book
    {
        public string title { get; }
        public string ISBN { get; }
        public Author Author { get; }


        public book(string title, string isbn, Author author)
        {
          this.  title = title;
       this.     ISBN = isbn;
         this.   Author = author;
        }

        public override string ToString()
        {
            return $"Title: {title}, ISBN: {ISBN}, Author: {Author.AuthorName}";
        }
    }

    class Library
    {
        class library
        {
            class Library
            {
                private List<book> books = new List<book>();

                public void AddBook(book book)
                {
                    books.Add(book);
                    Console.WriteLine($"Book added to the library: {book}");
                }

                public void RemoveBook(string isbn)
                {
                    book bookToRemove = null;

                    foreach (var book in books)
                    {
                        if (book.ISBN == isbn)
                        {
                            bookToRemove = book;
                            break;
                        }
                    }

                    if (bookToRemove != null)
                    {
                        books.Remove(bookToRemove);
                        Console.WriteLine($"Book removed from the library: {bookToRemove}");
                    }
                    else
                    {
                        Console.WriteLine($"Book with ISBN {isbn} not found in the library.");
                    }
                }

                public void DisplayBooks()
                {
                    Console.WriteLine("Books in the library:");
                    foreach (var book in books)
                    {
                        Console.WriteLine(book);
                    }
                    Console.WriteLine();
                }
            }

            class Program
            {
                static void Main()
                {

                    Author author1 = new Author("George");
                    Author author2 = new Author("Jane Smith");


                    book book1 = new book("Introduction to C#", "123456", author1);
                    book book2 = new book("Introduction to C#", "789012", author2);
                    book book3 = new book("Advanced C#", "345678", author1);


                    Library library = new Library();


                    library.AddBook(book1);
                    library.AddBook(book2);
                    library.AddBook(book3);


                    library.DisplayBooks();


                    library.RemoveBook("789012");


                    library.DisplayBooks();
                    Console.ReadKey();
                }
                
            }
        }


    }

    }
    
  