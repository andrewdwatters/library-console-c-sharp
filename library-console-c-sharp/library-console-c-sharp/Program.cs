using System;
using System.Collections.Generic;

namespace library_console_c_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Library Console App C# Edition!");
            Test();

        }

        static void Test(){
            Library.AddBook(new Book("Spot", "Jane", 200));
            Library.AddBooks(new List<Book> {new Book("Spot", "Jane", 200), new Book("Harry Potter", "JK", 300), new Book("It", "Stephen King", 150) });
            Library.ShowBookShelf();

        }
    }


}
