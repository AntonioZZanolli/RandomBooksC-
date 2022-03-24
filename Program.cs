using System;
using RandomBooks.ContentContext;
using RandomBooks.SharedContext;

namespace RandomBooks
{
    class Program : Base
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            var choices = new Choices();
            short res = 0;
                Console.WriteLine("***********************");
                Console.WriteLine("Bem-vindo ao RandomBooks");
                Console.WriteLine("***********************");
            do
            {
                Console.WriteLine("O que deseja fazer agora?");
                Console.WriteLine("1 - Adicionar livro");
                Console.WriteLine("2 - Imprimir lista");
                Console.WriteLine("3 - Sortear");
                Console.WriteLine("4 - Sair");

                res = short.Parse(Console.ReadLine());
                switch (res)
                {
                    case 1: choices.AddBook(); break;
                    case 2: choices.PrintBooks(); break;
                    case 3: choices.SortBooks(); break;
                    default: res = 4; break;
                }
            } while (res != 4);
        }
    }
}