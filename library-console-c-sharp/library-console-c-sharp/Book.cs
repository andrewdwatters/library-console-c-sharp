using System;
namespace library_console_c_sharp
{
    public class Book
    {
        public string _title { get; set; }
        public string _author { get; set; }
        public int _numberOfPages { get; set; }
        public DateTime _publishDate { get; set; }

        public Book(string title,string author,int numberOfPages)
        {
            _title = title;
            _author = author;
            _numberOfPages = numberOfPages;
            _publishDate = DateTime.Now;
        }
       

        //public Book EditBook(string title,string author,int numberOfPages,DateTime publishDate){
        //Looking for a better way to do this other then excessive overloading.
        //}
    }
}
