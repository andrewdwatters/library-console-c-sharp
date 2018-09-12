using System;
using System.Collections.Generic;

namespace library_console_c_sharp
{
    class Program
    {
        static void Main(string[] args)
        {   //console app starts here
            Console.WriteLine("Welcome to the Library Console App C# Edition!");
            Test(); //call to test method

        }

        static void Test(){
            Console.WriteLine("\nAddBook below: \n");
            Library.AddBook(new Book("Spot", "Jane", 200)); //this adds a book to the Library bookshelf the AddBooks() method below adds several books.

            Console.WriteLine("\nAddBooks below: \n");
            Library.AddBooks(new List<Book> {new Book("Spot", "Jane", 200), new Book("Harry Potter", "JK", 300), new Book("It", "Stephen King", 150), new Book("Harry Potter 2", "JK", 200), new Book("Harry Potter 3", "JK", 350), new Book("Calvin and Hobbes", "Bill Watterson", 100) });
           
            Console.WriteLine("\nGetBookByTitle('Spot') below: \n"); // \n creates a new line for easier to read output.
            Library.ShowBookShelf(Library.GetBookByTitle("Spot")); //return all books that have the word "Spot" in it.

            Console.WriteLine("\nGetBookByAuthor('JK') below: \n");
            Library.ShowBookShelf(Library.GetBookByAuthor("JK")); //return all authors that have "JK" appear in their name.

            Console.WriteLine("\nRemoveBookByTitle('Spot') below: \n");
            Library.RemoveBookByTitle("Spot"); //Remove any books where the title matches "Spot"
            Library.ShowBookShelf();

            Console.WriteLine("\nRemoveBookByAuthor('Stephen King') below: \n");
            Library.RemoveBooksByAuthor("Stephen King"); //Remove any books by the author "Stephen King"
            Library.ShowBookShelf();

            Console.WriteLine("\nGetRandomBook() below: \n");
            Console.WriteLine(Library.GetRandomBook().GetTitle()); //Returns a random book from the bookshelf and than .GetTitle() grabs just the title property from that book to be displayed.

            Console.WriteLine("\nGetRandomAuthor() below: \n");
            Console.WriteLine(Library.GetRandomAuthorName()); //returns a random author from the bookshelf

            Console.WriteLine("\nGetAuthors() below: \n");
            Library.ShowBookShelf(Library.GetAuthors()); //returns a distinct list of all authors from the bookshelf


        }
    }


}
