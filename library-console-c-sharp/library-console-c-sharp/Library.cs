using System;
using System.Collections.Generic; //Required to use List class
using System.Linq; //Required to use Distinct()

namespace library_console_c_sharp
{
    public static class Library //Static will treat this class like a singleton and I will not have to create any instance objects of the class Library
    //All methods on Library are also static that way I can call the methods using the name of the class Library.GetRandomAuthor() for example
    {
        public static List<Book> _bookShelf = new List<Book>(); //Here I immediately initialize my list to avoid null reference errors

        public static bool AddBook(Book book){//make note of return types bool void string Book etc... they are dependent on the datatype of the return statement
            foreach (var item in Library._bookShelf) //foreach loop works the same way as javascript it will loop over each book in my bookshelf 
            {
                if (item.GetTitle() == book.GetTitle()) // check to see if the title of the book already exists in my bookshelf.
                {
                    Console.WriteLine("Sorry {0} already exists in the bookshelf.",book.GetTitle());
                    return false; //This will display the message above and return us out of the function if a match is found.
                }
            }
            Console.WriteLine("Adding {0} to the bookshelf.",book.GetTitle());
            Library._bookShelf.Add(book); //This is similar to Array.push() from Javascript. List.Add() is the method if you want to google it
            return true;
        }

        public static bool RemoveBookByTitle(string title){
            for (var i = 0; i < Library._bookShelf.Count; i++){//for loop identical to javascript we use .Count property on the List class to determine the List length
                if(Library._bookShelf[i].GetTitle() == title){ //this checks the title parameter against the current book title in the for loop if match is found it will enter the if statement and remove the match.
                    Console.WriteLine("Removing {0}", title);
                    Library._bookShelf.RemoveAt(i); //RemoveAt is a method on the List class that takes an index as a parameter.  Whatever sits on this index will be removed.
                    return true;
                }
            }
            return false;
        }

        public static bool RemoveBooksByAuthor(string author){//look at RemoveBookByTitle for explaination it's the same only difference is matching on author instead of title
            for (var i = 0; i < Library._bookShelf.Count; i++)
            {
                if (Library._bookShelf[i].GetAuthor() == author)
                {
                    Console.WriteLine("Removing book by {0}",author);
                    Library._bookShelf.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }

        public static Book GetRandomBook(){
            Random rando = new Random(); //this creates a new instance of the Random class and saves it to a variable named rando
            return Library._bookShelf[rando.Next(Library._bookShelf.Count)]; //look carefully at this syntax it is doing a lot at once.  Explaination found below
        } //The rando.Next method has several overloads were just feeding it the count of our bookshelf. It will randomly generate a number between 0 and the count given.
        //Were then using the number generated to target a specific index on the bookshelf List

        public static List<Book> GetBookByTitle(string title){
            var tempList = new List<Book>(); //creates a List within the function scope to populate with matched titles.  
            //Know what your doing with var!!! it assumes the datatype of what you assign to it when initialized. 
            //If you don't want to use var you can write this instead List<Book> tempList = new List<Book>();
            foreach (var item in _bookShelf)
            {
                if (item.GetTitle().Contains(title))//.Contains() takes a parameter and checks to see if that parameter appears in the string it is called on
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
                if (item.GetAuthor().Contains(author))
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
                addCount++;//incrementor that you should be familiar with from javascript
            }
            return addCount;
        }

        public static List<String> GetAuthors(){
            var tempList = new List<string>();
            for (int i = 0; i < Library._bookShelf.Count; i++)
            {
                tempList.Add(Library._bookShelf[i].GetAuthor());
            }
            return tempList.Distinct().ToList(); // .Distinct() gets rid of duplicates in a List but the return type is IEnumerable(spelling might be off) so it must be converted back to list with the ToList() method
        }

        public static string GetRandomAuthorName(){
            Random rando = new Random();
            return Library._bookShelf[rando.Next(Library._bookShelf.Count)].GetAuthor();
        }

        public static void ShowBookShelf(){ //This is an extra method to nicely display all my books in the bookshelf.
            Console.WriteLine("Here is your list of books: ");
            foreach (var book in Library._bookShelf)
            {
                Console.WriteLine("Title: {0}, Author: {1}, Pages: {2}, Publish Date: {3}", book.GetTitle(), book.GetAuthor(), book.GetNumberOfPages(), book.GetPublishDate());
            }//above is a nice way to create a well formatted string starting from a 0 index it will grab values to fill each braced spot based on where they are placed after the string.
        }

        public static void ShowBookShelf(List<Book> myBooks){//Overload of ShowBookShelf method.  This method can take a List of Book class objects as a parameter to be displayed.
            Console.WriteLine("Here is your list of books: ");
            foreach (var book in myBooks)
            {
                Console.WriteLine("Title: {0}, Author: {1}, Pages: {2}, Publish Date: {3}", book.GetTitle(), book.GetAuthor(), book.GetNumberOfPages(), book.GetPublishDate());
            }
        }
        public static void ShowBookShelf(List<String> myStrings){//2nd overload of ShowBookShelf method.  This can take a List of strings as a parameter to be displayed.
            Console.WriteLine("Here are your results:  ");
            foreach (var item in myStrings)
            {
                Console.WriteLine("{0}",item);
            }
        }

    }
}
