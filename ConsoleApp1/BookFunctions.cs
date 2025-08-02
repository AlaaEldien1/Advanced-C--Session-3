using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public delegate string BookFunctionPointer(Book b);

    internal class BookFunctions
    {
        public static string GetTitle(Book b) => b.Title;
        public static string GetAuthors(Book b) => string.Join(", ",b.Authors);
        public static string GetPrice (Book b) => b.Price.ToString("C");  
    }
}
