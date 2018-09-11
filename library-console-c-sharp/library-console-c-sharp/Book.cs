using System;
namespace library_console_c_sharp
{
    public class Book
    {
        public string _title { get; set; } //Auto-implemented properties.  
        public string _author { get; set; } //Don't let the public keyword fool you.  These are private properties but with {get; set;}
        public int _numberOfPages { get; set; } //each of the private properties get a public getter and setter method made for them
        public DateTime _publishDate { get; set; }

        public Book(string title,string author,int numberOfPages) //Book class constructor
        {
            _title = title;
            _author = author;
            _numberOfPages = numberOfPages;
            _publishDate = DateTime.Now;
        }
        public Book(string title,string author,int numberOfPages,DateTime publishDate){ //Overload for Book class constructor that includes setting a specific publishDate
            _title = title;
            _author = author;
            _numberOfPages = numberOfPages;
            _publishDate = publishDate;
        }
       

        //public Book EditBook(string title,string author,int numberOfPages,DateTime publishDate){
        //Looking for a better way to do this other then excessive overloading.
        //}
    }
}
