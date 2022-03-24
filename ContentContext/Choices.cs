using System;
using System.Collections.Generic;

namespace RandomBooks.ContentContext
{
    class Choices : Program
    {
        public List<Book> Books { get; set; }
        public Choices()
        {
            Books = new List<Book>();
        }

        public void AddBook()
        {
            Console.WriteLine("Dígite o titulo do livro:");
            string Title = Console.ReadLine();
            // string Title = "Nome do vento";
            Console.WriteLine("Dígite a quantidade de páginas do livro:");
            int Pages = int.Parse(Console.ReadLine());
            // int Pages = 123;
            Console.WriteLine("Dígite o tema do livro:");
            string Theme = Console.ReadLine();
            // string Theme = "Fantasia";
            Books.Add(new Book(Title, Pages, Theme));
        }

        public void PrintBooks()
        {
            foreach (var Book in this.Books)
            {
                Console.WriteLine("---------------");
                Console.WriteLine(Books.IndexOf(Book));
                Console.WriteLine(Book.Title);
                Console.WriteLine(Book.Pages);
                Console.WriteLine(Book.Theme);
                Console.WriteLine("---------------");
            }
        }

        public void SortBooks()
        {
            Random rand = new Random(DateTime.Now.Millisecond);

            var resultado = Books[rand.Next(Books.Count)].Title;
            Console.WriteLine(resultado);
        }


    }
}