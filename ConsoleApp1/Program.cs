using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>
            {
                new Book("123", "C# Basics", new string[] { "Alaa", "Mohamed" }, new DateTime(2020, 1, 1), 150),
                new Book("436", "Advanced C#", new string[] { "Ahmed" }, new DateTime(2021, 6, 10), 200),
                new Book("416", "DataBase", new string[] { "Ali" }, new DateTime(2011, 2, 10), 300)
            };
            //BookFunctionPointer GetTitle = BookFunctions.GetTitle;
            //LibraryEngine.ProcessBooks(books, GetTitle);

            Func<Book, string> GetAuthors = BookFunctions.GetAuthors;
            LibraryEngine.ProcessBooks(books, GetAuthors);

            LibraryEngine.ProcessBooks(books, delegate (Book b) { return b.ISBN; });

            LibraryEngine.ProcessBooks(books, b => b.Price.ToString());

        }
    }
}
