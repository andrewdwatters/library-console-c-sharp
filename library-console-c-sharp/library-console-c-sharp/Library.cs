using System;
using System.Collections.Generic; //Required to use List class
using System.Linq;

namespace library_console_c_sharp
{
    public static class Library
    {
        public static List<Book> _bookShelf = new List<Book>();

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

        public static int AddBooks(List<Book> booksToAdd){ //fix this to call AddBook method
            int addCount = 0;
            for (int i = 0; i < booksToAdd.Count; i++){
                for (int k = 0; k < Library._bookShelf.Count; k++){
                    if(booksToAdd[i]._title == Library._bookShelf[k]._title){
                        break;
                    }
                }
                Library._bookShelf.Add(booksToAdd[i]);
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

    }
}
