using System;
using System.Collections.Generic; //Required to use List class
using System.Linq;

namespace library_console_c_sharp
{
    public static class Library //Static will treat this class like a singleton and I will not have to create any instance objects of the class Library
    //All methods on Library are also static that way I can call the methods using the name of the class Library.GetRandomAuthor() for example
    {
        public static List<Book> _bookShelf = new List<Book>(); //Here I immediately initialize my list to avoid null reference errors

        public static bool AddBook(Book book){
            foreach (var item in Library._bookShelf) 
            {
                if (item._title == book._title)
                {
                    Console.WriteLine("Sorry {0} already exists in the bookshelf.",book._title);
                    return false;
                }
            }
            Console.WriteLine("Adding {0} to the bookshelf.",book._title);
            Library._bookShelf.Add(book);
            return true;
        }

        public static bool RemoveBookByTitle(string title){
            for (var i = 0; i < Library._bookShelf.Count; i++){
                if(Library._bookShelf[i]._title == title){
                    Console.WriteLine("Removing {0}", title);
                    Library._bookShelf.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }

        public static bool RemoveBooksByAuthor(string author){
            for (var i = 0; i < Library._bookShelf.Count; i++)
            {
                if (Library._bookShelf[i]._author == author)
                {
                    Console.WriteLine("Removing book by {0}",author);
                    Library._bookShelf.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }

        public static Book GetRandomBook(){
            Random rando = new Random();
            Console.WriteLine(Library._bookShelf.Count);
            return Library._bookShelf[rando.Next(Library._bookShelf.Count)];
        }

        public static List<Book> GetBookByTitle(string title){
            var tempList = new List<Book>();
            foreach (var item in _bookShelf)
            {
                if (item._title.Contains(title))
                {
                    tempList.Add(item);
                }
            }
            return tempList;
        }

        public static List<Book> GetBookByAuthor(string author){
            var tempList = new List<Book>();
            foreach (var item in _bookShelf)
            {
                if (item._author.Contains(author))
                {
                    tempList.Add(item);
                }
            }
            return tempList;
        }

        public static int AddBooks(List<Book> booksToAdd){ 
            int addCount = 0;
            for (int i = 0; i < booksToAdd.Count; i++){
                Library.AddBook(booksToAdd[i]);
                addCount++;
            }
            return addCount;
        }

        public static List<String> GetAuthors(){
            var tempList = new List<string>();
            for (int i = 0; i < Library._bookShelf.Count; i++)
            {
                tempList.Add(Library._bookShelf[i]._author);
            }
            return tempList.Distinct().ToList();
        }

        public static string GetRandomAuthorName(){
            Random rando = new Random();
            return Library._bookShelf[rando.Next(Library._bookShelf.Count)]._author;
        }

        public static void ShowBookShelf(){ //This is an extra method to nicely display all my books in the bookshelf.
            Console.WriteLine("Here is your list of books");
            foreach (var book in Library._bookShelf)
            {
                Console.WriteLine("Title: {0}, Author: {1},Pages: {2},Publish Date: {3}", book._title, book._author, book._numberOfPages, book._publishDate);
            }
        }

        public static void ShowBookShelf(List<Book> myBooks){//Overload of ShowBookShelf method.  This method can take a List of Book class objects as a parameter to be displayed.
            foreach (var book in myBooks)
            {
                Console.WriteLine("Title: {0}, Author: {1},Pages: {2},Publish Date: {3}", book._title, book._author, book._numberOfPages, book._publishDate);
            }
        }

    }
}
