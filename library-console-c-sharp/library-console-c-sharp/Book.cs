using System;
namespace library_console_c_sharp
{
    public class Book
    {
        //The 4 lines of code below accomplish the same task as lines 13-49
        //public string _title { get; set; } //Auto-implemented properties.  
        //public string _author { get; set; } //Don't let the public keyword fool you.  These are private properties but with {get; set;}
        //public int _numberOfPages { get; set; } //each of the private properties get a public getter and setter method made for them
        //public DateTime _publishDate { get; set; }

        //Properties without auto-implementation
        private string _title; 
        private string _author;
        private int _numberOfPages;
        private DateTime _publishDate;

        public string GetTitle() //get method for title
        {
            return this._title;
        }
        public void SetTitle(string title) //set method for title
        {
            this._title = title;
        }

        public string GetAuthor() //get method for author
        {
            return this._author;
        }

        public void SetAuthor(string author){ //set method for author
            this._author = author;
        }

        public int GetNumberOfPages(){ //get method for number of pages
            return this._numberOfPages;
        }

        public void SetNumberOfPages(int numberOfPages){ //set method for number of pages
            this._numberOfPages = numberOfPages;
        }

        public DateTime GetPublishDate(){ //get method for publish date
            return this._publishDate;
        }

        public void SetPublishDate(DateTime publishDate){ //set method for publish date
            this._publishDate = publishDate;
        }

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
    }
}
