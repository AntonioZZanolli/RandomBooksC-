using System;
using System.Collections.Generic;
using RandomBooks.SharedContext;

namespace RandomBooks.ContentContext
{
    public class Book : Base
    {
        public Book(string title, int pages, string theme)
        {
            Title = title;
            Pages = pages;
            Theme = theme;
            //Books = new List<Book>();
        }

        public string Title { get; set; }
        public int Pages { get; set; }
        public string Theme { get; set; }
        public IList<Book> Books { get; set; }
    }

}